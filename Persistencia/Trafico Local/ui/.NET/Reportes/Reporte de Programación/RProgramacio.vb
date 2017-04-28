Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class RProgramacio

    Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim workbook As Microsoft.Office.Interop.Excel.Workbook
    Dim APP As New Microsoft.Office.Interop.Excel.Application
    Dim archivo As String
    Dim guardado As Boolean
    Public oper As String
    Public unidad As String

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click

        Me.Close()

    End Sub

    Private Sub bto_archivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_archivo.Click

        Dim oFD As New OpenFileDialog

        With oFD

            .Filter = "Ficheros Excel (*.xlsx)|*.xlsx|Todos (*.*)|*.*|(*.xls)|*.xls"
            .FileName = txt_archivo.Text

            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                ' El nombre del fichero
                Me.txt_archivo.Text = System.IO.Path.GetFileNameWithoutExtension(.FileName)
                archivo = .FileName

            End If
        End With

        If txt_archivo.Text = "" Then

        Else

            workbook = APP.Workbooks.Open(archivo)

            Try

                If r_impo.Checked Then

                    worksheet = workbook.Worksheets("Impo")

                Else

                    worksheet = workbook.Worksheets("Expo")

                End If

                Me.bto_subir.Enabled = True

            Catch ex As Exception

                MessageBox.Show("Asegúrese de que la hoja de Excel se llame Impo o Expo,  dependiendo el caso", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If
    End Sub

    Private Sub bto_subir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_subir.Click

        If txt_archivo.Text = "" Then

            MessageBox.Show("No seleccionó ningún archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            If r_impo.Checked Then

                Me.subirImpo()

            Else

                Me.subirExpo()

            End If

            Me.txt_archivo.Text = ""
            Me.bto_subir.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Cursor.Current = Cursors.WaitCursor
        Dim sql As String
        
        If ch_todos.Checked Then

            sql = "SELECT EJ_CTA, NAVIERA, TIPO_OPER, TIPO_PROGRAMACION, TERMINAL, REFERENCIA, CLIENTE, TIPO, CONTENEDOR, PESO, VIAJA_DIA, DESCRIP, MERCANCIA, ENTREGA2, DESTINO, DEMORA, ALMACENAJE, OBSERVACIONES, PLANTA, T_TR, T_REEX, PTA_R, VACIO, OBSERVACION, TIPO_PRO, id FROM trafico_reporte_programacion WHERE planta IS NULL AND tipo_pro IN(1) AND despachado = 0"
            sql += "SELECT EJ_CTA, NAVIERA, TIPO_OPER, TIPO_PROGRAMACION, TERMINAL, REFERENCIA, CLIENTE, TIPO, CONTENEDOR, PESO, VIAJA_DIA, DESCRIP, MERCANCIA, ENTREGA2, DESTINO, DEMORA, ALMACENAJE, OBSERVACIONES, PLANTA, T_TR, T_REEX, PTA_R, VACIO, OBSERVACION, TIPO_PRO, id FROM trafico_reporte_programacion where planta IS NULL AND tipo_pro IN(1) AND despachado = 0"

        Else

            sql = "SELECT EJ_CTA, NAVIERA, TIPO_OPER, TIPO_PROGRAMACION, TERMINAL, REFERENCIA, CLIENTE, TIPO, CONTENEDOR, PESO, VIAJA_DIA, DESCRIP, MERCANCIA, ENTREGA2, DESTINO, DEMORA, ALMACENAJE, OBSERVACIONES, PLANTA, T_TR, T_REEX, PTA_R, VACIO, OBSERVACION, TIPO_PRO, id FROM trafico_reporte_programacion  WHERE CONVERT(VARCHAR(20), fecha_subida, 103) BETWEEN '" & Me.cmb_fecini.Value.ToString("dd/MM/yyyy") & "' AND '" & Me.cmb_fin.Value.ToString("dd/MM/yyyy") & "' AND tipo_pro IN(1) AND despachado = 0 ORDER BY planta "

            sql += "SELECT EJ_CTA, NAVIERA, TIPO_OPER, TIPO_PROGRAMACION, TERMINAL, REFERENCIA, CLIENTE, TIPO, CONTENEDOR, PESO, VIAJA_DIA, DESCRIP, MERCANCIA, ENTREGA2, DESTINO, DEMORA, ALMACENAJE, OBSERVACIONES, PLANTA, T_TR, T_REEX, PTA_R, VACIO, OBSERVACION, TIPO_PRO, id FROM trafico_reporte_programacion  WHERE CONVERT(VARCHAR(20), fecha_subida, 103) BETWEEN '" & Me.cmb_fecini.Value.ToString("dd/MM/yyyy") & "' AND '" & Me.cmb_fin.Value.ToString("dd/MM/yyyy") & "' AND tipo_pro in(2,3) AND despachado = 0 ORDER BY planta "

            sql += "SELECT contenedor, terminal, cliente, referencia, booking, pedido, fechaPlanta, cita, direccion, documental, cierre FROM trafico_reporte_programacion_expo WHERE CONVERT(VARCHAR(20), fechaReporte, 112) BETWEEN '" & Me.cmb_fecini.Value.ToString("yyyyMMdd") & "' AND '" & Me.cmb_fin.Value.ToString("yyyyMMdd") & "'"

        End If

        Try

            Dim cn As SqlConnection = Connection.getInstance.getConnection
            Dim oDs As DataSet
            Dim oDa As SqlDataAdapter
            Dim command As New SqlCommand(sql, cn)

            command.CommandType = CommandType.Text
            cn.Open()
            oDa = New SqlClient.SqlDataAdapter(command)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            Me.gridImpo.DataSource = oDs.Tables(0)
            Me.grid2.DataSource = oDs.Tables(1)
            Me.gridExpo.DataSource = oDs.Tables(2)
            Cursor.Current = Cursors.Arrow
            Me.bto_guardar.Enabled = True
            Me.guardado = False
            Me.resaltarCargasFolioGridImpo()
            Me.resaltarCargasFolioGrid2()

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("No se pudo realizar la consulta debido al siguiente error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub resaltarCargasFolioGridImpo()

        Dim sql As String
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim oDs As DataSet
        Dim oDa As SqlDataAdapter
        Dim command As SqlCommand
        Dim item As DataGridViewRow

        sql = "SELECT referencia, contenedor, tipo FROM trafico_referencia_folio WHERE referencia <> '' ORDER BY tipo"
        command = New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        cn.Open()
        oDa = New SqlClient.SqlDataAdapter(command)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        cn.Close()

        For index1 As Int32 = 0 To Me.gridImpo.Rows.Count - 2

            item = Me.gridImpo.Rows(index1)

            For index As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                If item.Cells(5).Value.ToString.Equals(oDs.Tables(0).Rows.Item(index).Item(0).ToString()) AndAlso item.Cells(8).Value.ToString.Equals(oDs.Tables(0).Rows.Item(index).Item(1).ToString()) Then
                    If oDs.Tables(0).Rows.Item(index).Item(2).ToString() = "0" Then

                        item.DefaultCellStyle.BackColor = Color.PaleGreen
                        Exit For

                    End If

                    If oDs.Tables(0).Rows.Item(index).Item(2).ToString() = "1" Then

                        item.DefaultCellStyle.BackColor = Color.Yellow
                        Exit For

                    End If
                End If
            Next
        Next
    End Sub

    Public Sub resaltarCargasFolioGrid2()

        Dim sql As String
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim oDs As DataSet
        Dim oDa As SqlDataAdapter
        Dim command As SqlCommand
        Dim item As DataGridViewRow

        sql = "SELECT referencia, contenedor, tipo FROM trafico_referencia_folio WHERE referencia <> '' ORDER BY tipo"
        command = New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        command.CommandTimeout = 1000
        cn.Open()
        oDa = New SqlClient.SqlDataAdapter(command)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        cn.Close()

        For index2 As Int32 = 0 To Me.grid2.Rows.Count - 2

            item = Me.grid2.Rows(index2)

            For index As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                If item.Cells(5).Value.ToString.Equals(oDs.Tables(0).Rows.Item(index).Item(0).ToString()) AndAlso item.Cells(8).Value.ToString.Equals(oDs.Tables(0).Rows.Item(index).Item(1).ToString()) Then
                    If oDs.Tables(0).Rows.Item(index).Item(2).ToString() = "0" Then

                        item.DefaultCellStyle.BackColor = Color.PaleGreen
                        Exit For

                    End If

                    If oDs.Tables(0).Rows.Item(index).Item(2).ToString() = "1" Then

                        item.DefaultCellStyle.BackColor = Color.Yellow
                        Exit For

                    End If
                End If
            Next
        Next

        Dim arrTerminal As String()

        For index3 As Int32 = 0 To Me.grid2.Rows.Count - 2

            item = Me.grid2.Rows(index3)

            arrTerminal = item.Cells(4).Value.ToString().Split("/")

            If arrTerminal(arrTerminal.Length - 1).Equals("DAH") Or arrTerminal(arrTerminal.Length - 1).Equals("D.A H.") Then

                item.DefaultCellStyle.BackColor = Color.Pink

            End If
        Next
    End Sub

    Private Sub bto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_guardar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim cont As Integer = 0
        Dim command As SqlCommand

        If gridImpo.Rows.Count > 0 Then

            cn.Open()

            While gridImpo.Rows.Count > cont

                command = New SqlCommand("up_inserte_RProgramacion", cn)
                command.CommandType = CommandType.StoredProcedure

                With command.Parameters

                    .AddWithValue("@EJ_CTA", gridImpo.Rows(cont).Cells(0).Value.ToString())
                    .AddWithValue("@naviera", gridImpo.Rows(cont).Cells(1).Value.ToString())
                    .AddWithValue("@TIPO_OPER", gridImpo.Rows(cont).Cells(2).Value.ToString())
                    .AddWithValue("@TIPO_PROGRAMACION", gridImpo.Rows(cont).Cells(3).Value.ToString())
                    .AddWithValue("@TERMINAL", gridImpo.Rows(cont).Cells(4).Value.ToString())
                    .AddWithValue("@REFERENCIA", gridImpo.Rows(cont).Cells(5).Value.ToString())
                    .AddWithValue("@CLIENTE", gridImpo.Rows(cont).Cells(6).Value.ToString())
                    .AddWithValue("@TIPO", gridImpo.Rows(cont).Cells(7).Value.ToString())
                    .AddWithValue("@CONTENEDOR", gridImpo.Rows(cont).Cells(8).Value.ToString())
                    .AddWithValue("@PESO", gridImpo.Rows(cont).Cells(9).Value.ToString())
                    .AddWithValue("@VIAJA_DIA", gridImpo.Rows(cont).Cells(10).Value.ToString())
                    .AddWithValue("@DESCRIP", gridImpo.Rows(cont).Cells(11).Value.ToString())
                    .AddWithValue("@MERCANCIA", gridImpo.Rows(cont).Cells(12).Value.ToString())
                    .AddWithValue("@ENTREGA2", gridImpo.Rows(cont).Cells(13).Value.ToString())
                    .AddWithValue("@DESTINO", gridImpo.Rows(cont).Cells(14).Value.ToString())
                    .AddWithValue("@DEMORA", gridImpo.Rows(cont).Cells(15).Value.ToString())
                    .AddWithValue("@ALMACENAJE", gridImpo.Rows(cont).Cells(16).Value.ToString())
                    .AddWithValue("@OBSERVACIONES", gridImpo.Rows(cont).Cells(17).Value.ToString())
                    .AddWithValue("@PLANTA", gridImpo.Rows(cont).Cells(18).Value)
                    .AddWithValue("@T_TR", gridImpo.Rows(cont).Cells(19).Value)
                    .AddWithValue("@T_REEX", gridImpo.Rows(cont).Cells(20).Value.ToString())
                    .AddWithValue("@PTA_R", gridImpo.Rows(cont).Cells(21).Value.ToString())
                    .AddWithValue("@VACIO", gridImpo.Rows(cont).Cells(22).Value.ToString())
                    .AddWithValue("@OBSERVACION", gridImpo.Rows(cont).Cells(23).Value.ToString())
                    .AddWithValue("@TIPO_PRO", gridImpo.Rows(cont).Cells(24).Value.ToString())

                End With

                Try

                    command.ExecuteNonQuery()
                    Me.guardado = True

                Catch ex As Exception

                    MessageBox.Show(ex.Message)

                End Try

                cont = cont + 1

            End While
        Else

            MessageBox.Show("Realize una consulta primeramente")

        End If

        MessageBox.Show("El reporte se guardó correctamente", "¡Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cn.Close()

    End Sub

    Private Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridImpo.CellDoubleClick

        If e.ColumnIndex = 5 Then

            IngresoFolio.fecha = Me.cmb_fecini.Value.ToString("dd/MM/yyyy")
            IngresoFolio.sql = "SELECT referencia, contenedor, CONVERT(BIT, 0) AS Seleccionado, peso, tipo, almacenaje, terminal, cliente FROM trafico_reporte_programacion WHERE referencia = '" & Me.gridImpo.Rows(e.RowIndex).Cells(5).Value.ToString() & "' AND despachado = 0 AND contenedor NOT IN (SELECT contenedor FROM trafico_referencia_folio WHERE fecha >= '" & Me.cmb_fecini.Value.ToString("dd/MM/yyyy") & "' AND tipo = 1)"
            IngresoFolio.Show(Me)
            IngresoFolio.esContenedor = False
            IngresoFolio.referencia = Me.gridImpo.Rows(e.RowIndex).Cells(5).Value.ToString()

        End If

        Me.resaltarCargasFolioGridImpo()
        Me.resaltarCargasFolioGrid2()

    End Sub

    Private Sub grid2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid2.CellDoubleClick

        If e.ColumnIndex = 5 Then
            'IngresoFolio.referencia = Me.grid.Rows(e.RowIndex).Cells(5).Value.ToString()
            'IngresoFolio.Show()
        End If

    End Sub

    Private Sub bto_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_buscar.Click

        Cursor.Current = Cursors.WaitCursor

        If txt_param.Text = "" Then

            MessageBox.Show("Ingrese un número de contenedor o referencia")

        Else

            If rcontenedor.Checked Then

                IngresoFolio.fecha = Me.cmb_fecini.Value.ToString("dd/MM/yyyy")
                IngresoFolio.sql = "SELECT referencia, contenedor, CONVERT(BIT, 0) AS Seleccionado, peso, tipo, almacenaje, terminal, cliente FROM trafico_reporte_programacion WHERE contenedor = '" & txt_param.Text & "' AND despachado = 0 AND contenedor NOT IN (SELECT contenedor FROM trafico_referencia_folio WHERE fecha >= '" & Me.cmb_fecini.Value.ToString("dd/MM/yyyy") & "' AND tipo = 1)"
                IngresoFolio.esContenedor = True
                IngresoFolio.contenedor = txt_param.Text

            Else

                IngresoFolio.sql = "SELECT referencia, contenedor, CONVERT(BIT, 0) AS Seleccionado, peso, tipo, almacenaje, terminal, cliente FROM trafico_reporte_programacion WHERE referencia = '" & txt_param.Text & "' AND despachado = 0 AND contenedor NOT IN (SELECT contenedor FROM trafico_referencia_folio WHERE fecha >= '" & Me.cmb_fecini.Value.ToString("dd/MM/yyyy") & "' AND tipo = 1) SELECT referencia, contenedor, CONVERT(BIT, 0) AS Seleccionado, peso, tipo, almacenaje, terminal, cliente FROM trafico_reporte_programacion WHERE referencia = '" & txt_param.Text & "' AND despachado = 0 AND contenedor IN (SELECT contenedor FROM trafico_referencia_folio WHERE fecha >= '" & Me.cmb_fecini.Value.ToString("dd/MM/yyyy") & "' AND tipo = 1)"
                IngresoFolio.esContenedor = False
                IngresoFolio.referencia = txt_param.Text

            End If

            IngresoFolio.Show()
            Cursor.Current = Cursors.Arrow

        End If
    End Sub

    Private Sub RProgramacio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        rcontenedor.Checked = True
        r_impo.Checked = True
        Me.bto_subir.Enabled = False
        Me.bto_guardar.Enabled = False
        Me.r_impo.Checked = True
        Me.rBtnBucarImpo.Checked = True
        Me.rreferencia.Checked = True
        Cursor.Current = Cursors.Arrow

    End Sub

    Public Sub subirImpo()

        Cursor.Current = Cursors.AppStarting
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim cont As Integer = 1
        'Dim fila As Integer = 1
        Dim i As Integer = 1
        Dim r As Microsoft.Office.Interop.Excel.Range = worksheet.UsedRange
        Dim array(,) As Object = r.Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault)
        Dim rangoEnY As Integer = array.GetUpperBound(0)
        'Dim rangoEnX As Integer = array.GetUpperBound(1)
        'MessageBox.Show(rangoEnY)

        While worksheet.Cells(i, 6).Value Is Nothing

            i += 1

        End While

        Try
            While cont <= rangoEnY
                If worksheet.Cells(i, 6).Value IsNot Nothing AndAlso Not worksheet.Cells(i, 6).Value.ToString().Equals("REFERENCIA") Then

                    Dim command As New SqlCommand("up_inserte_RProgramacion", cn)
                    Dim param As SqlParameter
                    command.CommandType = CommandType.StoredProcedure
                    cn.Open()

                    With command.Parameters

                        .AddWithValue("@tipo_insert", 1)
                        .AddWithValue("@EJ_CTA", worksheet.Cells(i, 1).Value)
                        .AddWithValue("@NAVIERA", worksheet.Cells(i, 2).Value)
                        .AddWithValue("@TIPO_OPER", worksheet.Cells(i, 3).Value)
                        .AddWithValue("@TIPO_PROGRAMACION", worksheet.Cells(i, 4).Value)
                        .AddWithValue("@TERMINAL", worksheet.Cells(i, 5).Value)
                        .AddWithValue("@REFERENCIA", worksheet.Cells(i, 6).Value)
                        .AddWithValue("@CLIENTE", worksheet.Cells(i, 7).Value)
                        '.AddWithValue("@TIPO", worksheet.Cells(i, 8).Value)
                        '.AddWithValue("@CONTENEDOR", worksheet.Cells(i, 9).Value)
                        '.AddWithValue("@PESO", worksheet.Cells(i, 10).Value)
                        '.AddWithValue("@VIAJA_DIA", worksheet.Cells(i, 11).Value)
                        '.AddWithValue("@DESCRIP", worksheet.Cells(i, 12).Value)
                        '.AddWithValue("@MERCANCIA", worksheet.Cells(i, 13).Value)
                        '.AddWithValue("@ENTREGA2", worksheet.Cells(i, 14).Value)
                        '.AddWithValue("@DESTINO", worksheet.Cells(i, 15).Value)
                        '.AddWithValue("@DEMORA", CType(worksheet.Cells(i, 16).Value.ToString(), Date).ToString("dd/MM/yyyy"))
                        '.AddWithValue("@ALMACENAJE", CType(worksheet.Cells(i, 17).Value.ToString(), Date).ToString("dd/MM/yyyy"))
                        '.AddWithValue("@OBSERVACIONES", worksheet.Cells(i, 18).Value)
                        '.AddWithValue("@T_TR", worksheet.Cells(i, 20).Value)
                        '.AddWithValue("@T_REEX", worksheet.Cells(i, 21).Value)
                        '.AddWithValue("@PTA_R", worksheet.Cells(i, 22).Value)
                        '.AddWithValue("@VACIO", worksheet.Cells(i, 23).Value)
                        '.AddWithValue("@TIPO_PRO", worksheet.Cells(i, 24).Value)
                        '.AddWithValue("@OBSERVACION", "")
                        .AddWithValue("@TIPO", worksheet.Cells(i, 10).Value)
                        .AddWithValue("@CONTENEDOR", worksheet.Cells(i, 11).Value)
                        .AddWithValue("@PESO", worksheet.Cells(i, 12).Value)
                        .AddWithValue("@VIAJA_DIA", worksheet.Cells(i, 13).Value)
                        .AddWithValue("@DESCRIP", worksheet.Cells(i, 14).Value)
                        .AddWithValue("@MERCANCIA", worksheet.Cells(i, 15).Value)
                        .AddWithValue("@ENTREGA2", worksheet.Cells(i, 16).Value)
                        .AddWithValue("@DESTINO", worksheet.Cells(i, 17).Value)
                        .AddWithValue("@DEMORA", CType(worksheet.Cells(i, 18).Value.ToString(), Date).ToString("dd/MM/yyyy"))
                        .AddWithValue("@ALMACENAJE", CType(worksheet.Cells(i, 19).Value.ToString(), Date).ToString("dd/MM/yyyy"))
                        .AddWithValue("@OBSERVACIONES", worksheet.Cells(i, 20).Value)
                        '.AddWithValue("@T_TR", worksheet.Cells(i, 22).Value)
                        '.AddWithValue("@T_REEX", worksheet.Cells(i, 23).Value)
                        '.AddWithValue("@PTA_R", worksheet.Cells(i, 24).Value)
                        '.AddWithValue("@VACIO", worksheet.Cells(i, 25).Value)
                        '.AddWithValue("@TIPO_PRO", worksheet.Cells(i, 26).Value)
                        '.AddWithValue("@OBSERVACION", "")
                        .AddWithValue("@T_TR", worksheet.Cells(i, 23).Value)
                        .AddWithValue("@T_REEX", worksheet.Cells(i, 24).Value)
                        .AddWithValue("@PTA_R", worksheet.Cells(i, 28).Value)
                        .AddWithValue("@VACIO", worksheet.Cells(i, 29).Value)
                        '.AddWithValue("@TIPO_PRO", worksheet.Cells(i, 30).Value)
                        '.AddWithValue("@TIPO_PRO", 0)
                        .AddWithValue("@OBSERVACION", "")


                    End With

                    Try

                        param = command.Parameters.AddWithValue("@fechaPlanta", CType(worksheet.Cells(i, 25).Value.ToString(), Date).ToString("dd/MM/yyyy"))

                    Catch ex As Exception

                        param = command.Parameters.AddWithValue("@fechaPlanta", DBNull.Value)

                    End Try

                    If worksheet.Cells(i, 1).Value = "otra" Or worksheet.Cells(i, 1).Value = "EJ. CTA." Then
                    Else

                        command.ExecuteNonQuery()

                    End If

                    cn.Close()

                End If

                i += 1
                cont += 1

            End While

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("El archivo se cargó correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            r.Application.Quit()

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("El archivo no se cargó debido al siguiente problema: " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            r.Application.Quit()

        End Try
    End Sub

    Public Sub subirExpo()

        Cursor.Current = Cursors.AppStarting
        Dim r As Microsoft.Office.Interop.Excel.Range = worksheet.UsedRange
        Dim array(,) As Object = r.Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault)
        Dim rangoEnY As Integer = array.GetUpperBound(0)
        Dim conexion As SqlConnection
        Dim command As SqlCommand
        Dim cont As Integer = 1
        Dim i As Integer = 1

        While worksheet.Cells(i, 1).Value Is Nothing

            i += 1

        End While

        
        Try

            While cont <= rangoEnY
                If worksheet.Cells(i, 1).Value IsNot Nothing AndAlso Not worksheet.Cells(i, 1).Value.ToString().Equals("CONT.") AndAlso Not worksheet.Cells(i, 1).Value.ToString().Equals("") Then

                    conexion = Connection.getInstance.getConnection()
                    command = New SqlCommand("up_inserte_RProgramacion", conexion)
                    command.CommandType = CommandType.StoredProcedure
                    command.CommandTimeout = 1000
                    conexion.Open()

                    With command.Parameters

                        .AddWithValue("@contenedorExpo", worksheet.Cells(i, 1).Value)
                        .AddWithValue("@terminalExpo", worksheet.Cells(i, 2).value)
                        .AddWithValue("@clienteExpo", worksheet.Cells(i, 3).Value)
                        .AddWithValue("@referenciaExpo", worksheet.Cells(i, 4).Value)
                        .AddWithValue("@booking", worksheet.Cells(i, 5).Value)
                        .AddWithValue("@pedido", worksheet.Cells(i, 6).value)
                        .AddWithValue("@fechaPlanta", Convert.ToDateTime(worksheet.Cells(i, 7).value.ToString()))

                        .AddWithValue("@cita", worksheet.Cells(i, 8).text)
                        .AddWithValue("@direccion", worksheet.Cells(i, 9).value)

                        If Not String.IsNullOrEmpty(worksheet.Cells(i, 10).value) Then

                            .AddWithValue("@documental", Convert.ToDateTime(worksheet.Cells(i, 10).value.ToString()).ToString("dd/MM/yyyy"))

                        Else

                            .AddWithValue("@documental", "")

                        End If


                        If Not String.IsNullOrEmpty(worksheet.Cells(i, 11).value) Then

                            .AddWithValue("@cierre", Convert.ToDateTime(worksheet.Cells(i, 11).value.ToString()).ToString("dd/MM/yyyy"))

                        Else

                            .AddWithValue("@cierre", "")

                        End If

                        .AddWithValue("@tipo_insert", 2)

                    End With

                    command.ExecuteNonQuery()

                End If

                i += 1
                cont += 1

            End While

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("El programa se cargó correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.Close()
            r.Application.Quit()

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("El programa de cargas de expo no pudo cargarse debido al siguiente error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    'Private Sub grid_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    '    resaltarCargasFolio()

    'End Sub

    Private Sub btoReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoReporte.Click

        Cursor.Current = Cursors.AppStarting
        Dim reportes As EscogerReporte = New EscogerReporte(Me.cmb_fecini.Value.ToString("dd/MM/yyyy"), Me.cmb_fin.Value.ToString("dd/MM/yyyy"))
        reportes.ShowDialog(Me)

    End Sub

    Private Sub gridExpo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridExpo.CellDoubleClick

        Dim sql As String

        If e.ColumnIndex = 3 Then

            Cursor.Current = Cursors.AppStarting
            sql = "SELECT referencia, contenedor, peso,tipo,almacenaje,terminal,cliente FROM trafico_reporte_programacion WHERE referencia = '" & Me.gridExpo.Rows(e.RowIndex).Cells(3).Value.ToString() & "'"
            IngresoBooking.setSQL(sql)
            IngresoBooking.ShowDialog(Me)

        End If
    End Sub

    Private Sub grid2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles grid2.Paint

        Me.resaltarCargasFolioGrid2()

    End Sub

    Private Sub menuCambiarOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCambiarOp.Click

        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim cont, ref As String
        Dim nFilas As Int16
        Dim cambOp As CambiarOperador

        If Me.grid2.SelectedRows(0).DefaultCellStyle.BackColor = Color.Green Then

            Cursor.Current = Cursors.AppStarting
            cambOp = New CambiarOperador(Me)
            cambOp.ShowDialog(Me)

            If Not String.IsNullOrEmpty(Me.oper) Then
                Try

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand("up_actualizar_operador_visita", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000

                    With comando.Parameters

                        .AddWithValue("@referencia", Me.grid2.SelectedRows(0).Cells(5).Value.ToString())
                        .AddWithValue("@contenedor", Me.grid2.SelectedRows(0).Cells(8).Value.ToString())
                        .AddWithValue("@nombre", Me.oper)
                        .AddWithValue("@unidad", Me.unidad)

                    End With

                    comando.ExecuteNonQuery()
                    comando.Dispose()
                    conexion.Dispose()
                    MessageBox.Show("El operador se ha actualizado correctamente", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception

                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            End If
        Else

            MessageBox.Show("La carga seleccionada no tiene visita", "No se puede completar la acción", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Public Sub fijarOperador(ByVal oper As String, ByVal unidad As String)

        Me.oper = oper
        Me.unidad = unidad

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Dim modi As ModificacionMasiva = New ModificacionMasiva()
        modi.ShowDialog(Me)

    End Sub

    Private Sub tsmiCambOperador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiCambOperador.Click

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim cambOp As CambiarOperador

        If Me.gridImpo.SelectedRows(0).DefaultCellStyle.BackColor = Color.Green Then

            Cursor.Current = Cursors.AppStarting
            cambOp = New CambiarOperador(Me)
            cambOp.ShowDialog(Me)

            If Not String.IsNullOrEmpty(Me.oper) Then
                Try

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand("up_actualizar_operador_visita", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000

                    With comando.Parameters

                        .AddWithValue("@referencia", Me.gridImpo.SelectedRows(0).Cells(5).Value.ToString())
                        .AddWithValue("@contenedor", Me.gridImpo.SelectedRows(0).Cells(8).Value.ToString())
                        .AddWithValue("@nombre", Me.oper)
                        .AddWithValue("@unidad", Me.unidad)

                    End With

                    comando.ExecuteNonQuery()
                    comando.Dispose()
                    conexion.Dispose()
                    MessageBox.Show("El operador se ha actualizado correctamente", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception

                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            End If
        Else

            MessageBox.Show("La carga seleccionada no tiene visita", "No se puede completar la acción", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub AñadirFechaDeModulaciònToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirFechaDeModulaciònToolStripMenuItem.Click

        Dim sel As SeleccionarFechaMod

        sel = New SeleccionarFechaMod()
        sel.modReferencia(Me.gridImpo.SelectedRows(0).Cells(5).Value.ToString())
        sel.modContenedor(Me.gridImpo.SelectedRows(0).Cells(8).Value.ToString())
        sel.ShowDialog(Me)
        Me.Button1_Click(sender, e)

    End Sub

    Private Sub btnAgregarCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarga.Click

        Dim carga As AgregarCarga
        carga = New AgregarCarga()
        carga.ShowDialog(Me)
        Me.Button1_Click(sender, e)

    End Sub

    Private Sub GenerarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarToolStripMenuItem.Click

        Dim gen As GenerarPrograma
        gen = New GenerarPrograma()
        gen.ShowDialog()

    End Sub

    Private Sub gridImpo_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles gridImpo.Paint

        Me.resaltarCargasFolioGridImpo()

    End Sub

    Private Sub btnBuscador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscador.Click

        Dim bus As BuscadorCargas
        bus = New BuscadorCargas()
        bus.ShowDialog()

    End Sub

    Private Sub IngresarFolioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarFolioToolStripMenuItem.Click

        If Me.gridImpo.SelectedRows.Count > 0 Then

            IngresoFolio.dS = New DataSet()
            Dim selec As New DataColumn("selecccionado", GetType(Boolean))
            IngresoFolio.dS.Tables.Add()
            IngresoFolio.dS.Tables(0).Columns.Add("referencia")
            IngresoFolio.dS.Tables(0).Columns.Add("contenedor")
            IngresoFolio.dS.Tables(0).Columns.Add(selec)
            IngresoFolio.dS.Tables(0).Columns.Add("peso")
            IngresoFolio.dS.Tables(0).Columns.Add("tipo")
            IngresoFolio.dS.Tables(0).Columns.Add("almacenaje")
            IngresoFolio.dS.Tables(0).Columns.Add("terminal")
            IngresoFolio.dS.Tables(0).Columns.Add("cliente")

            For Each carga As DataGridViewRow In Me.gridImpo.SelectedRows

                IngresoFolio.dS.Tables(0).Rows.Add()
                IngresoFolio.dS.Tables(0).Rows(IngresoFolio.dS.Tables(0).Rows.Count - 1)("referencia") = carga.Cells("REFERENCIA").Value
                IngresoFolio.dS.Tables(0).Rows(IngresoFolio.dS.Tables(0).Rows.Count - 1)("contenedor") = carga.Cells("CONTENEDOR").Value
                IngresoFolio.dS.Tables(0).Rows(IngresoFolio.dS.Tables(0).Rows.Count - 1)("peso") = carga.Cells("PESO").Value
                IngresoFolio.dS.Tables(0).Rows(IngresoFolio.dS.Tables(0).Rows.Count - 1)("tipo") = carga.Cells("TIPO").Value
                IngresoFolio.dS.Tables(0).Rows(IngresoFolio.dS.Tables(0).Rows.Count - 1)("almacenaje") = carga.Cells("ALMACENAJE").Value
                IngresoFolio.dS.Tables(0).Rows(IngresoFolio.dS.Tables(0).Rows.Count - 1)("terminal") = carga.Cells("TERMINAL").Value
                IngresoFolio.dS.Tables(0).Rows(IngresoFolio.dS.Tables(0).Rows.Count - 1)("cliente") = carga.Cells("CLIENTE").Value

            Next

            IngresoFolio.Show()

        End If
    End Sub

    Private Sub btnGenerarResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarResumen.Click

        Dim resumen As ResumenCargas = New ResumenCargas()
        resumen.ShowDialog(Me)

    End Sub
End Class