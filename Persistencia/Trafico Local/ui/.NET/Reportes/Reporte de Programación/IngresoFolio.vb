Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class IngresoFolio

    Public padre As RProgramacio
    Public referencia As String
    Public contenedor As String
    Public sql As String
    Public esContenedor As Boolean
    Public fecha As String
    Public dS As DataSet

    Private Sub IngresoFolio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oDs As DataSet
        Dim dT As DataTable
        Dim oDa As SqlDataAdapter
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim command As New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text

        If Me.dS Is Nothing Then
            Try

                cn.Open()
                oDa = New SqlClient.SqlDataAdapter(command)
                oDs = New System.Data.DataSet()
                oDa.Fill(oDs)
                cn.Close()
                cn.Dispose()
                command.Dispose()

                If oDs.Tables(0).Rows.Count > 0 Then

                    Me.grid.DataSource = oDs.Tables(0)

                ElseIf oDs.Tables(1).Rows.Count > 0 Then

                    Me.cargarCombos()
                    Me.cmbHoraBoleta.SelectedIndex = 0
                    Me.cmbMinutoBoleta.SelectedIndex = 0
                    Me.tabBoleta_Enter(sender, e)
                    Me.cmbHoraVisita.SelectedIndex = 0
                    Me.cmbMinutoVisita.SelectedIndex = 0
                    Me.resultadosDeBusqueda()
                    Exit Sub

                Else

                    If Me.esContenedor Then

                        dT = Me.buscarCargaFP(contenedor, "", 1)

                    Else

                        dT = Me.buscarCargaFP(referencia, "", 0)

                    End If

                    If dT.Rows.Count > 0 Then
                        For Each fila As DataRow In dT.Rows

                            Me.actualizarInfoDBF(fila.Item(0).ToString(), fila.Item(1).ToString())
                            Me.insertarCarga(fila.Item(0).ToString(), fila.Item(1).ToString(), fila.Item(2).ToString(), fila.Item(3).ToString(), fila.Item(4).ToString(), fila.Item(5).ToString(), fila.Item(6).ToString(), fila.Item(7).ToString())
                            cn = Connection.getInstance().getConnection()
                            command = New SqlCommand(sql, cn)
                            cn.Open()
                            oDa = New SqlClient.SqlDataAdapter(command)
                            oDs = New System.Data.DataSet()
                            oDa.Fill(oDs)
                            cn.Close()
                            cn.Dispose()
                            command.Dispose()
                            Me.grid.DataSource = oDs.Tables(0)
                        Next
                    Else

                        MessageBox.Show("No se encuentra información de esta referencia. Por favor, capture las cargas manualmente", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If

                If oDs.Tables.Count > 1 AndAlso oDs.Tables(1).Rows.Count > 0 Then

                    Me.txt_folio.Text = oDs.Tables(1).Rows(0).Item(0).ToString()
                    Me.dteFechaBoleta.Value = oDs.Tables(1).Rows(0).Item(3).ToString()
                    Me.cmbHoraBoleta.SelectedItem = Split(oDs.Tables(1).Rows(0).Item(4).ToString(), ":")(0)
                    Me.cmbMinutoBoleta.SelectedItem = Split(oDs.Tables(1).Rows(0).Item(4).ToString(), ":")(1)

                    If oDs.Tables(1).Rows.Count > 1 Then

                        Me.txtFolioVisita.Text = oDs.Tables(1).Rows(1).Item(0).ToString()
                        Me.txtOperador.Text = oDs.Tables(1).Rows(1).Item(1).ToString()
                        Me.txtUnidad.Text = oDs.Tables(1).Rows(1).Item(2).ToString()
                        Me.cmbHoraVisita.SelectedItem = Split(oDs.Tables(1).Rows(1).Item(4).ToString(), ":")(0)
                        Me.cmbMinutoVisita.SelectedItem = Split(oDs.Tables(1).Rows(1).Item(4).ToString(), ":")(1)

                    End If
                End If

                cn.Close()

                For Each carga As DataGridViewRow In Me.grid.Rows

                    carga.Cells(2).Value = False

                Next
            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else

            Me.grid.DataSource = dS.Tables(0)

        End If

        Me.cargarCombos()
        Me.cmbHoraBoleta.SelectedIndex = 0
        Me.cmbMinutoBoleta.SelectedIndex = 0
        Me.tabBoleta_Enter(sender, e)
        Me.cmbHoraVisita.SelectedIndex = 0
        Me.cmbMinutoVisita.SelectedIndex = 0
        Me.resultadosDeBusqueda()

    End Sub

    Private Sub bto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_guardar.Click

        Cursor.Current = Cursors.WaitCursor

        Try

            Dim cn As SqlConnection
            Dim command As SqlCommand

            If Not String.IsNullOrEmpty(Me.txt_folio.Text) Then
                For Each carga As DataGridViewRow In Me.grid.Rows
                    If carga.Cells(2).Value = True AndAlso carga.Visible = True Then

                        cn = Connection.getInstance.getConnection()
                        command = New SqlCommand("up_folio_insert", cn)
                        command.CommandType = CommandType.StoredProcedure
                        cn.Open()

                        With command.Parameters

                            .AddWithValue("@referencia", carga.Cells(0).Value.ToString)
                            .AddWithValue("@contenedor", carga.Cells(1).Value.ToString)
                            .AddWithValue("@folio", txt_folio.Text)
                            .AddWithValue("@estatus", 0)
                            .AddWithValue("@unidad", "")
                            .AddWithValue("@operador", "")
                            .AddWithValue("@fecha", dteFechaBoleta.Value.Date)
                            .AddWithValue("@hora", Me.cmbHoraBoleta.SelectedItem.ToString() & ":" & Me.cmbMinutoBoleta.SelectedItem.ToString())
                            .AddWithValue("@tipo", 1)
                            .AddWithValue("@bloque", "")

                        End With

                        command.ExecuteNonQuery()
                        cn.Close()
                        cn.Dispose()

                    End If
                Next
            End If

            If Not String.IsNullOrEmpty(Me.txtFolioVisita.Text) Then
                For Each carga As DataGridViewRow In Me.grid.Rows
                    If carga.Cells(2).Value = True Then

                        cn = Connection.getInstance.getConnection()
                        command = New SqlCommand("up_folio_insert", cn)
                        command.CommandType = CommandType.StoredProcedure
                        cn.Open()

                        With command.Parameters

                            .AddWithValue("@referencia", carga.Cells(0).Value.ToString)
                            .AddWithValue("@contenedor", carga.Cells(1).Value.ToString)
                            .AddWithValue("@folio", Me.txtFolioVisita.Text)
                            .AddWithValue("@estatus", 0)
                            .AddWithValue("@unidad", Me.txtUnidad.Text)
                            .AddWithValue("@operador", Me.txtOperador.Text)
                            .AddWithValue("@fecha", Me.dteFechaVisita.Value.Date)
                            .AddWithValue("@hora", Me.cmbHoraVisita.SelectedItem.ToString() & ":" & Me.cmbMinutoVisita.SelectedItem.ToString())
                            .AddWithValue("@tipo", 0)
                            .AddWithValue("@bloque", Me.txtBloque.Text)

                        End With

                        command.ExecuteNonQuery()
                        cn.Close()
                        cn.Dispose()

                    End If
                Next
            End If

            Cursor.Current = Cursors.Arrow
            'MessageBox.Show("Guardado")

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Error: " & ex.Message & " Rastro de la pila: " & ex.StackTrace, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Me.Dispose()

    End Sub

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click

        Me.Close()

    End Sub

    Private Sub cargarCombos()

        For decena As Integer = 0 To 2
            For unidad As Integer = 0 To 9
                If decena = 2 AndAlso unidad = 4 Then

                    Exit For

                Else

                    Me.cmbHoraBoleta.Items.Add(decena & "" & unidad)
                    Me.cmbHoraVisita.Items.Add(decena & "" & unidad)

                End If
            Next
        Next

        For decena As Integer = 0 To 5
            For unidad As Integer = 0 To 9

                Me.cmbMinutoBoleta.Items.Add(decena & "" & unidad)
                Me.cmbMinutoVisita.Items.Add(decena & "" & unidad)

            Next
        Next
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged

        If Me.chkTodos.Checked Then
            For Each carga As DataGridViewRow In Me.grid.Rows

                carga.Cells(2).Value = True

            Next
        Else

            For Each carga As DataGridViewRow In Me.grid.Rows

                carga.Cells(2).Value = False

            Next
        End If
    End Sub

    Private Sub tabBoleta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabBoleta.Enter

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        If Me.dS Is Nothing Then
            If Me.esContenedor Then

                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                sql = "SELECT referencia, contenedor, CONVERT(BIT, 0) AS Seleccionado, peso, tipo, almacenaje, terminal, cliente FROM trafico_reporte_programacion WHERE contenedor = '" & Me.contenedor & "' AND contenedor NOT IN (SELECT contenedor FROM trafico_referencia_folio WHERE fecha >= '" & Me.fecha & "' AND tipo = 1)"
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)
                Me.grid.DataSource = dS.Tables(0)
                conexion.Close()

            Else

                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                sql = "SELECT referencia, contenedor, CONVERT(BIT, 0) AS Seleccionado, peso, tipo, almacenaje, terminal, cliente FROM trafico_reporte_programacion WHERE referencia = '" & Me.referencia & "' AND contenedor NOT IN (SELECT contenedor FROM trafico_referencia_folio WHERE fecha >= '" & Me.fecha & "' AND tipo = 1)"
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)
                Me.grid.DataSource = dS.Tables(0)
                conexion.Close()

            End If
        Else

            Me.grid.DataSource = Me.dS.Tables(0)
            Me.grid.Update()

            For Each carga As DataGridViewRow In Me.grid.Rows
                If Me.tieneBoletaVisita(carga.Cells(0).Value.ToString(), carga.Cells(1).Value.ToString(), 1) Then ' Checamos si tiene boleta

                    carga.Visible = False

                End If
            Next
        End If
    End Sub

    Private Sub tabVisita_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabVisita.Enter

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        Try
            If Me.dS Is Nothing Then
                If Me.esContenedor Then

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    sql = "SELECT referencia, contenedor, CONVERT(BIT, 0) AS Seleccionado, peso, tipo, almacenaje, terminal, cliente FROM trafico_reporte_programacion WHERE contenedor = '" & Me.contenedor & "' AND contenedor NOT IN (SELECT contenedor FROM trafico_referencia_folio WHERE fecha >= '" & Me.fecha & "' AND tipo = 0)"
                    comando = New SqlCommand(sql, conexion)
                    comando.CommandType = CommandType.Text
                    comando.CommandTimeout = 1000
                    sDA = New SqlDataAdapter(comando)
                    dS = New DataSet()
                    sDA.Fill(dS)
                    Me.grid.DataSource = dS.Tables(0)
                    conexion.Close()

                Else

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    sql = "SELECT referencia, contenedor, CONVERT(BIT, 0) AS Seleccionado, peso, tipo, almacenaje, terminal, cliente FROM trafico_reporte_programacion WHERE referencia = '" & Me.referencia & "' AND contenedor NOT IN (SELECT contenedor FROM trafico_referencia_folio WHERE fecha >= '" & Me.fecha & "' AND tipo = 0)"
                    comando = New SqlCommand(sql, conexion)
                    comando.CommandType = CommandType.Text
                    comando.CommandTimeout = 1000
                    sDA = New SqlDataAdapter(comando)
                    dS = New DataSet()
                    sDA.Fill(dS)
                    Me.grid.DataSource = dS.Tables(0)
                    conexion.Close()

                End If

            Else

                Me.grid.DataSource = Me.dS.Tables(0)
                Me.grid.Update()

                For Each carga As DataGridViewRow In Me.grid.Rows
                    If Me.tieneBoletaVisita(carga.Cells(0).Value.ToString(), carga.Cells(1).Value.ToString(), 0) Then ' Checamos si tiene visita

                        carga.Visible = False

                    End If
                Next
            End If
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message & " Rastro de pila: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub resultadosDeBusqueda()

        Dim autoCompletado As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre FROM personal_personal"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtOperador.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub txtPlacas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlacas.KeyPress

        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        If Not String.IsNullOrEmpty(Me.txtPlacas.Text) Then
            Try

                sql = "SELECT TOP(1) id_unidad FROM mtto_unidades WHERE REPLACE(REPLACE(placas, ' ', ''), '-', '') LIKE ('%' + REPLACE(REPLACE('" & Me.txtPlacas.Text & "', ' ', ''), '-', '') + '%')"
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables(0).Rows.Count > 0 Then

                    Me.txtUnidad.Text = dS.Tables(0).Rows(0).Item(0).ToString()

                End If

                conexion.Dispose()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        Else

            Me.txtUnidad.Text = ""

        End If
    End Sub

    Private Sub txtUnidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidad.KeyPress

        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        If Not String.IsNullOrEmpty(Me.txtUnidad.Text) Then
            Try

                sql = "SELECT TOP(1) placas FROM mtto_unidades WHERE REPLACE(REPLACE(id_unidad , ' ', ''), '-', '') LIKE ('%' + REPLACE(REPLACE('" & Me.txtUnidad.Text & "', ' ', ''), '-', '') + '%')"
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables(0).Rows.Count > 0 Then

                    Me.txtPlacas.Text = dS.Tables(0).Rows(0).Item(0).ToString()

                End If

                conexion.Dispose()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        Else

            Me.txtPlacas.Text = ""

        End If
    End Sub

    Private Sub txt_folio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_folio.KeyDown, dteFechaBoleta.KeyDown, txtUnidad.KeyDown, txtPlacas.KeyDown, txtOperador.KeyDown, txtFolioVisita.KeyDown, txtBloque.KeyDown, dteFechaVisita.KeyDown, cmbMinutoVisita.KeyDown, cmbHoraVisita.KeyDown, cmbMinutoBoleta.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub

    Private Function buscarCargaFP(ByVal busqueda As String, ByVal con As String, ByVal tipoBus As Integer) As DataTable

        Dim dS1, dS2, dS3, dS4, dS5 As DataSet
        Dim fila As DataRow
        Dim tabla As DataTable
        Dim consulta1, consulta2, consulta3, consulta4, consulta5 As String
        Dim ruta1, ruta2, ruta4, ruta5 As String
        Dim nombreCliente As String
        Dim referencia, contenedor As String

        tabla = New DataTable()
        tabla.Columns.Add("Referencia")
        tabla.Columns.Add("Contenedor")
        tabla.Columns.Add("Tipo")
        tabla.Columns.Add("Peso")
        tabla.Columns.Add("Terminal origen")
        tabla.Columns.Add("Fecha de demora")
        tabla.Columns.Add("Fecha de almacenaje")
        tabla.Columns.Add("Cliente")
        nombreCliente = ""

        If Not String.IsNullOrEmpty(busqueda) Then
            If tipoBus = 0 Then

                consulta1 = "SELECT referencia, contenedor FROM datosrefp.dbf WHERE referencia = '" & busqueda & "'"

            Else

                consulta1 = "SELECT TOP(1) referencia, contenedor FROM datosrefp.dbf WHERE contenedor = '" & busqueda.TrimEnd().TrimStart().Replace(" ", "").Replace("-", "") & "' ORDER BY referencia DESC"

            End If

            ruta1 = "H:\Sica\LisRep\Patieros\"
            dS1 = Me.buscarInfo(ruta1, consulta1)

            If dS1.Tables(0).Rows.Count > 0 Then
                For Each info As DataRow In dS1.Tables(0).Rows

                    tabla.Rows.Add()
                    fila = tabla.Rows(tabla.Rows.Count - 1)
                    referencia = info(0).ToString()
                    contenedor = info(1).ToString().TrimEnd().TrimStart().Substring(0, 4) & "-" & info(1).ToString().TrimStart().TrimEnd().Substring(4, 6) & "-" & info(1).ToString().TrimStart().TrimEnd().Substring(10)
                    fila("Referencia") = referencia
                    fila("Contenedor") = contenedor

                Next

                ruta4 = "Z:\RECO\TRAFICO\data\"
                consulta4 = "SELECT Cvecli21 FROM stctrl21.dbf WHERE refcia21 = '" & referencia.TrimStart().TrimEnd().Trim() & "' AND Patent21 = '3341' AND Cveadu21 = 81 AND Cvesec21 = 0 AND Llave21 = '3341810'"
                dS4 = Me.buscarInfo(ruta4, consulta4)

                If dS4.Tables(0).Rows.Count > 0 Then

                    ruta5 = "Z:\RECO\SAAI\DBFS\"
                    consulta5 = "SELECT nomcli18  FROM ssclie18.dbf  where cvecli18 = " & dS4.Tables(0).Rows(0)(0).ToString()
                    dS5 = Me.buscarInfo(ruta5, consulta5)

                    If dS5.Tables(0).Rows.Count > 0 Then

                        nombreCliente = dS5.Tables(0).Rows(0)(0).ToString()

                    End If
                End If

                For Each carga As DataRow In tabla.Rows

                    ruta2 = "z:\RECO\SORF\EMP003\DATA\"
                    consulta2 = "SELECT tamcon01, tipocon01, pesobr01 FROM srasigtras.dbf WHERE refciaaa = '" & carga("Referencia").ToString().TrimEnd().TrimStart() & "' AND numcon01 = '" & (carga("Contenedor").ToString().TrimEnd().TrimStart().Split("-")(0) & carga("Contenedor").ToString().TrimEnd().TrimStart().Split("-")(1) & "-" & carga("Contenedor").ToString().TrimEnd().TrimStart().Split("-")(2)) & "'"
                    dS2 = Me.buscarInfo(ruta2, consulta2)

                    If dS2.Tables(0).Rows.Count > 0 Then

                        carga("Tipo") = dS2.Tables(0).Rows(0)(0).ToString() & " " & dS2.Tables(0).Rows(0)(1).ToString()
                        carga("Peso") = dS2.Tables(0).Rows(0)(2).ToString()

                    End If

                    consulta3 = "SELECT terorigen, tipprog, fecdemora, fecalmacen FROM datosref.dbf WHERE referencia = '" & carga("Referencia").ToString().TrimStart().TrimEnd() & "'"
                    dS3 = Me.buscarInfo(ruta1, consulta3)

                    If dS3.Tables(0).Rows.Count > 0 Then

                        carga("Terminal origen") = dS3.Tables(0).Rows(0)(0).ToString().TrimEnd().TrimStart()
                        carga("Fecha de demora") = Convert.ToDateTime(dS3.Tables(0).Rows(0)(2).ToString().TrimEnd().TrimStart()).ToString("dd/MM/yyyy")
                        carga("Fecha de almacenaje") = Convert.ToDateTime(dS3.Tables(0).Rows(0)(3).ToString().TrimEnd().TrimStart()).ToString("dd/MM/yyyy")

                    Else

                        carga("Terminal origen") = ""
                        carga("Fecha de demora") = ""
                        carga("Fecha de almacenaje") = ""

                    End If

                    carga("Cliente") = nombreCliente

                Next
            End If
        End If

        Return tabla

    End Function

    Private Function buscarInfo(ByVal ruta As String, ByVal consulta As String) As DataSet

        Dim dset As New Data.DataSet

        Dim dad As New OleDbDataAdapter(consulta, "Provider=vfpoledb.1;Data Source=" + ruta + ";Mode=3;")

        Try

            dad.Fill(dset)
            dad.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al buscar la información: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dset

    End Function

    Private Sub actualizarInfoDBF(ByVal ref As String, ByVal cont As String)

        Dim comando As OleDbCommand
        Dim conexion As OleDbConnection
        Dim consulta As String
        Dim ruta As String

        Try

            ruta = "H:\Sica\LisRep\Patieros\"
            conexion = New OleDbConnection("Provider=vfpoledb.1;Data Source=" + ruta + ";Mode=3;")
            consulta = "UPDATE datosrefp.dbf SET estado = 2 WHERE referencia = '" & ref & "' AND contenedor = '" & cont.Replace("-", "") & "'"
            conexion.Open()
            comando = New OleDbCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            comando.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub insertarCarga(ByVal ref As String, ByVal cont As String, ByVal tipo As String, ByVal peso As String, ByVal terOrigen As String, ByVal fecDemora As String, ByVal fecAlmacenaje As String, ByVal cliente As String)

        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim command As SqlCommand

        If String.IsNullOrEmpty(cont) Or String.IsNullOrEmpty(ref) Then

            MessageBox.Show("El contenedor y la referencia son requeridos")
            Return

        Else

            cn.Open()
            command = New SqlCommand("up_inserte_RProgramacion", cn)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters

                .AddWithValue("@TIPO_OPER", "IMPO")
                .AddWithValue("@TERMINAL", terOrigen)
                .AddWithValue("@REFERENCIA", ref.TrimStart().TrimEnd())
                .AddWithValue("@TIPO", tipo)
                .AddWithValue("@PESO", peso)
                .AddWithValue("@DEMORA", fecDemora)
                .AddWithValue("@ALMACENAJE", fecAlmacenaje)
                .AddWithValue("@CONTENEDOR", cont.TrimStart().TrimEnd())
                .AddWithValue("@CLIENTE", cliente.TrimStart().TrimEnd())
                .AddWithValue("@tipo_insert", 1)
                .AddWithValue("@TIPO_PRO", 3)

            End With

            Try

                command.ExecuteNonQuery()
                'MessageBox.Show("Los datos se han guardado correctamente", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End If
    End Sub

    Private Function tieneBoletaVisita(ByVal referencia As String, ByVal contenedor As String, ByVal tipo As Integer) As Boolean

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim query As String
        Dim res As Boolean = False

        query = "SELECT COUNT(tipo) FROM trafico_referencia_folio WHERE referencia = '" & referencia.TrimEnd().TrimStart() & "' AND contenedor = '" & contenedor.TrimEnd().TrimStart() & "' AND tipo = " & tipo & ""
        conexion = Connection.getInstance().getConnection()
        comando = New SqlCommand(query, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 600

        Try

            conexion.Open()

            If Convert.ToInt16(comando.ExecuteScalar().ToString()) > 0 Then

                res = True

            End If
        Catch ex As Exception

            MessageBox.Show("Error al checar las boletas y visitas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return res

    End Function
End Class