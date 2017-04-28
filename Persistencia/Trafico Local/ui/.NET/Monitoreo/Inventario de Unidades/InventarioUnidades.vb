Imports System.Data.SqlClient

''' <param name="sender"></param>
''' <param name="e"></param>
''' <remarks>
''' <sumary>
''' Genera el inventario de unidades de Interflet.
''' </sumary>
''' </remarks>
''' <history>[Omar Alí V. Striever] 13/10/2015 Creación</history>

Public Class InventarioUnidades

    Private guardado As Boolean
    Private celulares As String(,)

    ''' <summary>
    ''' Cierra la aplicación
    ''' </summary>
    Private Sub btoSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoSalir.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' Obtiene el estatus actual y la ubicación de las unidades.
    ''' </summary>    
    Private Sub btoGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoGenerar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim sql As String
        Dim estaEnTaller As Boolean

        Try

            Dim conexion As SqlConnection
            Dim dS, dS1 As DataSet
            Dim sDA, sDA1 As SqlDataAdapter
            Dim comando As SqlCommand
            Dim consulta As String
            
            ' Se obtiene los datos generales de cada unidad (operador, celular, cliente y destino)
            For Each fila As DataGridViewRow In Me.gridUnidades.Rows

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("UP_INVENTARIO_UNIDADES_MONITOREO", conexion)

                With comando.Parameters

                    .AddWithValue("@Unidad", fila.Cells("ECO").Value.ToString())
                    .AddWithValue("@Area", 1)

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                conexion.Open()
                sDA = New SqlClient.SqlDataAdapter(comando)
                dS = New System.Data.DataSet()
                sDA.Fill(dS)

                ' La información se inserta en cada columna del grid
                If dS.Tables(0).Rows.Count > 0 Then

                    fila.Cells("FECHA_LLEGADA").Value = dS.Tables(0).Rows.Item(0).Item("FECHA").ToString()
                    fila.Cells("CEL").Value = IIf(String.IsNullOrEmpty(dS.Tables(0).Rows.Item(0).Item("CEL").ToString()), "", dS.Tables(0).Rows.Item(0).Item("CEL").ToString())
                    fila.Cells("OPERADOR").Value = IIf(String.IsNullOrEmpty(dS.Tables(0).Rows.Item(0).Item("OPERADOR").ToString()), "S/O", dS.Tables(0).Rows.Item(0).Item("OPERADOR").ToString())
                    fila.Cells("CLIENTE").Value = IIf(String.IsNullOrEmpty(dS.Tables(0).Rows.Item(0).Item("CLIENTE").ToString()), "", dS.Tables(0).Rows.Item(0).Item("CLIENTE").ToString())
                    fila.Cells("DESTINO").Value = IIf(String.IsNullOrEmpty(dS.Tables(0).Rows.Item(0).Item("DESTINO").ToString()), "", dS.Tables(0).Rows.Item(0).Item("DESTINO").ToString())
                    fila.Cells("STATUS").Value = IIf(String.IsNullOrEmpty(dS.Tables(0).Rows.Item(0).Item("STATUS").ToString()), "", dS.Tables(0).Rows.Item(0).Item("STATUS").ToString())

                Else

                    fila.Cells("CEL").Value = ""
                    fila.Cells("OPERADOR").Value = "S/O"
                    fila.Cells("CLIENTE").Value = ""
                    fila.Cells("DESTINO").Value = ""
                    fila.Cells("STATUS").Value = ""

                End If

                conexion.Close()
                conexion.Dispose()
                fila.Cells(7).Value = ""
                fila.Cells(8).Value = ""
                conexion.Close()
                conexion.Dispose()

                If fila.Cells("STATUS").Value IsNot Nothing Then
                    If fila.Cells("STATUS").Value.ToString().Equals("PATIO") Then

                        fila.Cells("DESTINO").Value = ""
                        fila.Cells("CLIENTE").Value = "D.A. HINOJOSA, S.A. DE C.V."

                    End If
                End If

                Me.gridUnidades.Update()
                Me.Update()

            Next

            ' Una vez que el grid se llena con la información obtenida, se habilitan los botones de exportar y guardar.
            Me.btoGuardar.Enabled = True
            Me.btoExportar.Enabled = True
            'Me.predeterminarCelularesPorUnidad()
            ' Bit que permite verificar si el inventario se ha guardado o no en la base de datos
            Me.guardado = False

        Catch ex As Exception

            ' En caso de que ocurra un problema, se muestra un mensaje de error en pantalla
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Error al cargar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Cursor.Current = Cursors.Arrow

    End Sub

    ''' <summary>
    ''' Carga las celdas de Unidad y Numero celular en el grid con valores predeterminados.
    ''' </summary>    
    Private Sub InventarioUnidades_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarUnidades()
        Me.gridUnidades.AllowUserToAddRows = False
        Me.gridUnidades.AutoGenerateColumns = False
        Me.btoGuardar.Enabled = False
        Me.btoExportar.Enabled = False
        Me.gridUnidades.Update()
        'Me.predeterminarCelularesPorUnidad()

    End Sub

    ''' <summary>
    ''' Exporta la información del grid a un archivo de excel.
    ''' </summary>
    Private Sub btoExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoExportar.Click

        Cursor.Current = Cursors.WaitCursor
        Excel.gridToExcel(Me.gridUnidades)
        Cursor.Current = Cursors.Arrow

    End Sub

    ''' <summary>
    ''' Guarda el inventario en la base de datos.
    ''' </summary>
    Private Sub btoGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoGuardar.Click

        Cursor.Current = Cursors.WaitCursor

        Try

            Dim cn As SqlConnection
            Dim oDs As DataSet
            Dim oDa As SqlDataAdapter
            Dim command As SqlCommand
            Dim fecha As Date = Date.Today
            Dim sql As String
            cn = Connection.getInstance().getConnection()
            cn.Open()
            ' Se procede a guardar primero el encabezado del inventario (fecha, hora, etc)
            command = New SqlCommand("up_unidades_status_insert", cn)
            command.CommandType = CommandType.StoredProcedure
            command.CommandTimeout = 3000
            command.ExecuteNonQuery()
            cn.Close()
            cn.Dispose()
            Dim cmbCel As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()
            Dim dt As DataTable = New DataTable()
            Dim clave As String = ""

            ' Despues se procede a guardar el detalle (La información y el estatus de cada unidad)
            For Each Item As DataGridViewRow In Me.gridUnidades.Rows

                cn = Connection.getInstance().getConnection()
                cn.Open()
                command = New SqlCommand("up_unidades_status_detalle_insert", cn)

                With command.Parameters

                    .AddWithValue("@idUnidad", Item.Cells(1).Value.ToString())
                    .AddWithValue("@fechaLlegada", Item.Cells(0).Value.ToString())
                    .AddWithValue("@numeroCelular", Item.Cells(2).Value.ToString())
                    .AddWithValue("@operador", Item.Cells(3).Value.ToString())
                    .AddWithValue("@cliente", Item.Cells(4).Value.ToString())
                    .AddWithValue("@destino", Item.Cells(5).Value.ToString())
                    .AddWithValue("@status", Item.Cells(6).Value.ToString())
                    .AddWithValue("@horario", Item.Cells(7).Value.ToString())
                    .AddWithValue("@ETA", Item.Cells(8).Value.ToString())

                End With

                command.CommandType = CommandType.StoredProcedure
                command.CommandTimeout = 3000
                command.ExecuteNonQuery()
                cn.Close()
                cn.Dispose()

            Next

            Cursor.Current = Cursors.Arrow
            ' Si todo sale bien, se muestra un mensaje de éxito
            MessageBox.Show("El inventario se ha guardado exitosamente", "¡Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.guardado = True

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            ' En caso de que ocurra un problema, se muestra un mensaje de error
            MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ''' <summary>
    ''' Genera un reporte con los inventarios generados en un rango de fechas
    ''' </summary>    
    Private Sub btoReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoReporte.Click

        Cursor.Current = Cursors.WaitCursor
        Dim cn As SqlConnection
        Dim oDs As DataSet
        Dim oDa As SqlDataAdapter
        Dim command As SqlCommand
        Dim sql As String
        cn = Connection.getInstance().getConnection()
        cn.Open()
        command = New SqlCommand("up_reporte_inventario_unidades", cn)

        With command.Parameters

            .AddWithValue("@FechaDesde", Me.dteDesde.Value.ToString("dd/MM/yyyy"))
            .AddWithValue("@FechaHasta", Me.dteHasta.Value.ToString("dd/MM/yyyy"))

        End With

        command.CommandType = CommandType.StoredProcedure
        command.CommandTimeout = 3000
        oDa = New SqlClient.SqlDataAdapter(command)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        Excel.datasetToExcel(oDs)
        cn.Close()
        cn.Dispose()
        Cursor.Current = Cursors.Arrow

    End Sub

    ''' <summary>
    ''' Evento que muestra un tooltip text con el numero de celular del operador
    ''' </summary>
    Private Sub gridUnidades_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles gridUnidades.CellFormatting

        If e.ColumnIndex = 2 Then

            'Me.gridUnidades.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = "NUMERO:     " & Me.obtenerNumeroPorClave(Me.gridUnidades.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())

        End If
    End Sub

    ''' <summary>
    ''' Asigna una clave de celular predeterminada a cada unidad la cual se mostrará en la columna CEL del grid.
    ''' </summary>    
    'Private Sub predeterminarCelularesPorUnidad()

    '    Dim sql As String
    '    Dim conexion As SqlConnection
    '    Dim comando As SqlCommand
    '    Dim sDA As SqlDataAdapter
    '    Dim dS As DataSet

    '    Try

    '        sql = "SELECT unidad, clave, numero FROM trafico_claves_celular ORDER BY unidad"
    '        conexion = Connection.getInstance().getConnection()
    '        conexion.Open()
    '        comando = New SqlCommand(sql, conexion)
    '        comando.CommandType = CommandType.Text
    '        comando.CommandTimeout = 1000
    '        sDA = New SqlDataAdapter(comando)
    '        dS = New DataSet()
    '        sDA.Fill(dS)
    '        ReDim Me.celulares(dS.Tables(0).Rows.Count, 2)

    '        For index As Integer = 0 To Me.celulares.GetLength(0) - 2

    '            Me.celulares(index, 0) = dS.Tables(0).Rows(index).Item(1).ToString()
    '            Me.celulares(index, 1) = dS.Tables(0).Rows(index).Item(2).ToString()

    '        Next

    '        For Each fila As DataGridViewRow In Me.gridUnidades.Rows
    '            For index As Integer = 0 To dS.Tables(0).Rows.Count - 1
    '                If fila.Cells(1).Value.ToString().Equals(dS.Tables(0).Rows(index).Item(0).ToString()) Then

    '                    fila.Cells(2).Value = dS.Tables(0).Rows(index).Item(1).ToString()
    '                    Exit For

    '                Else

    '                    fila.Cells(2).Value = ""

    '                End If
    '            Next
    '        Next
    '    Catch ex As Exception

    '        MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End Try
    'End Sub

    'Private Function obtenerTablaCelulares() As DataTable

    '    Dim conexion As SqlConnection
    '    Dim comando As SqlCommand
    '    Dim sql As String
    '    Dim sDA As SqlDataAdapter
    '    Dim dS As DataSet

    '    Try

    '        sql = "SELECT clave, numero FROM trafico_claves_celular ORDER BY clave"
    '        conexion = Connection.getInstance().getConnection()
    '        conexion.Open()
    '        comando = New SqlCommand(sql, conexion)
    '        comando.CommandType = CommandType.Text
    '        comando.CommandTimeout = 1000
    '        sDA = New SqlDataAdapter(comando)
    '        dS = New DataSet()
    '        sDA.Fill(dS)
    '        Return dS.Tables(0)

    '    Catch ex As Exception

    '        MessageBox.Show("Error al cargar la lista de celulares: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return New DataTable()

    '    End Try
    'End Function

    Private Sub InventarioUnidades_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If Me.guardado = False Then

            Dim res As DialogResult = MessageBox.Show("El inventario no se ha guardado, ¿desea salir de la aplicación?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If res = DialogResult.Yes Then

                e.Cancel = False

            Else

                e.Cancel = True

            End If
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        ClavesCelulares.Show(Me)

    End Sub

    'Private Function obtenerNumeroPorClave(ByVal clave As String) As String

    '    For index As Integer = 0 To Me.celulares.GetLength(0) - 2
    '        If Me.celulares(index, 0).Equals(clave) Then

    '            Return Me.celulares(index, 1)

    '        End If
    '    Next
    'End Function

    Private Function consultarFechaEntrada(ByVal unidad As String) As String

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim query As String
        Dim fecha As String

        fecha = ""
        query = "SELECT TOP(1) CONVERT(VARCHAR(20), Fecha, 103) + ' ' + Hora FROM trafico_registros WHERE unidad = " & unidad & "' AND Tipo = 'E' ORDER BY fecha DESC"
        conexion = New SqlConnection()
        comando = New SqlCommand(query, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000

        Try

            conexion.Open()
            fecha = comando.ExecuteScalar().ToString()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return fecha

    End Function

    Private Sub cargarUnidades()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim fila As DataGridViewRow
        Dim consulta As String
        Dim indice As Integer

        Try

            consulta = "SELECT DISTINCT id_unidad FROM mtto_unidades WHERE id_unidad LIKE 'T-%' AND id_unidad >= 'T-179' AND id_unidad < 'T-400' AND id_area = 1 AND estatus = 'A' AND id_unidad NOT IN (SELECT unidad FROM Trafico_Unidades_Siniestradas)"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each unidad As DataRow In dS.Tables(0).Rows

                        indice = Me.gridUnidades.Rows.Add()
                        fila = Me.gridUnidades.Rows(indice)
                        fila.Cells("FECHA_LLEGADA").Value = ""
                        fila.Cells("ECO").Value = unidad("id_unidad").ToString()
                        fila.Cells("CEL").Value = ""
                        fila.Cells("OPERADOR").Value = ""
                        fila.Cells("CLIENTE").Value = ""
                        fila.Cells("DESTINO").Value = ""
                        fila.Cells("STATUS").Value = ""
                        fila.Cells("HORARIO").Value = ""
                        fila.Cells("ETA").Value = ""

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Hubo un error al consultar el registro: " & ex.Message & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub UnidadesSiniestradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesSiniestradasToolStripMenuItem.Click

        Dim uni As UnidadesSiniestradas = New UnidadesSiniestradas()
        uni.ShowDialog(Me)

    End Sub
End Class
