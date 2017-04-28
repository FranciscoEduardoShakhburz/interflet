Imports System.Data
Imports System.Data.SqlClient

Public Class ReporteSalidas

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReporteSalidas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.rdBtnPendientes.Checked = True

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Me.consultarViajes(Me.dTPFecha.Value)
        
    End Sub

    Private Sub btnAgregarViaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Me.exportarReporteConFormato(Me.dGVViajes)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.guardarReporte()
        MessageBox.Show("El reporte se guardó correctamente", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Dim edit As EditarViaje = New EditarViaje(Me.dGVViajes.SelectedRows(0))
        edit.ShowDialog(Me)

    End Sub

    Private Sub rdBtnPendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBtnPendientes.CheckedChanged

        Me.consultarViajes(Me.dTPFecha.Value)

    End Sub

    Private Sub consultarViajes(ByVal fecha As DateTime)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim filaViaje As DataGridViewRow

        Try

            Me.dGVViajes.Rows.Clear()
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Consulta_Viajes", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@fecha", fecha)
                .AddWithValue("@tipoConsulta", IIf(Me.rdBtnPendientes.Checked = True, 1, 2))

            End With

            conexion.Open()
            dS = New DataSet
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each viaje As DataRow In dS.Tables(0).Rows

                        filaViaje = Me.dGVViajes.Rows(Me.dGVViajes.Rows.Add())
                        filaViaje.Cells("colFecha").Value = viaje("FechaProg").ToString()
                        filaViaje.Cells("colUnidad").Value = viaje("id_unidad").ToString()
                        filaViaje.Cells("colOperador").Value = viaje("personalnombre").ToString()
                        filaViaje.Cells("colPlacas").Value = viaje("placa").ToString()
                        filaViaje.Cells("colViaje").Value = viaje("No_Viaje").ToString()
                        filaViaje.Cells("colCliente").Value = viaje("nombre").ToString()
                        filaViaje.Cells("colDestino").Value = viaje("destino").ToString()
                        filaViaje.Cells("colCartaPorte").Value = viaje("Num_Guia").ToString()
                        filaViaje.Cells("colContenedores").Value = viaje("observaciones").ToString()
                        filaViaje.Cells("colObservaciones").Value = viaje("Referencia").ToString()
                        filaViaje.Cells("colTipoOp").Value = viaje("tipooper").ToString()
                        filaViaje.Cells("colEntregarEn").Value = viaje("entregar_en").ToString()
                        filaViaje.Cells("colRemolque").Value = viaje("id_remolque1").ToString()
                        filaViaje.Cells("colDolly").Value = viaje("dolly").ToString()
                        filaViaje.Cells("colHoraDocumentacion").Value = viaje("horaDocumentacionLista").ToString()
                        filaViaje.Cells("colHoraDocumentosEntregados").Value = viaje("horaDocumentosEntregados").ToString()

                    Next
                End If
            End If

        Catch ex As Exception

            MessageBox.Show("Error al consultar los viajes: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub exportarReporteConFormato(ByVal dGVViajes As DataGridView)

        If dGVViajes.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim borders As Microsoft.Office.Interop.Excel.Borders
            Dim style1 As Microsoft.Office.Interop.Excel.Style
            Dim style2 As Microsoft.Office.Interop.Excel.Style
            Dim columnas As Integer = dGVViajes.ColumnCount
            Dim filas As Integer = dGVViajes.RowCount
            Dim filaTotal = 0

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()
            hoja.Cells.Item(4, 1) = "NUM. ECO."
            hoja.Cells.Item(4, 2) = "OPERADOR"
            hoja.Cells.Item(4, 3) = "PLACAS"
            hoja.Cells.Item(4, 4) = "VIAJE"
            hoja.Cells.Item(4, 5) = "OBSERVACIONES"
            hoja.Cells.Item(4, 6) = "CLIENTE"
            hoja.Cells.Item(4, 7) = "DESTINO"
            hoja.Cells.Item(4, 8) = "NUM. DE TALON CP"
            hoja.Cells.Item(4, 9) = "NUMERO DE CONTENEDOR/S CAJA O PLANA"
            hoja.Cells.Item(4, 10) = "TIPO DE OPER"
            hoja.Cells.Item(4, 11) = "DIRECCION DE ENTREGA"
            hoja.Cells.Item(4, 12) = "REMOLQUE"
            hoja.Cells.Item(4, 13) = "DOLLY"
            hoja.Cells.Item(4, 14) = "HORA DE DOCUMENTACION LISTA"
            hoja.Cells.Item(4, 15) = "HORA DOCUMENTOS ENTREGADOS"

            For fila As Integer = 0 To filas - 1

                hoja.Cells.Item(fila + 5, 1) = dGVViajes.Rows(fila).Cells("colUnidad").Value
                hoja.Cells.Item(fila + 5, 2) = dGVViajes.Rows(fila).Cells("colOperador").Value
                hoja.Cells.Item(fila + 5, 3) = dGVViajes.Rows(fila).Cells("colPlacas").Value
                hoja.Cells.Item(fila + 5, 4) = dGVViajes.Rows(fila).Cells("colViaje").Value
                hoja.Cells.Item(fila + 5, 5) = dGVViajes.Rows(fila).Cells("colObservaciones").Value
                hoja.Cells.Item(fila + 5, 6) = dGVViajes.Rows(fila).Cells("colCliente").Value
                hoja.Cells.Item(fila + 5, 7) = dGVViajes.Rows(fila).Cells("colDestino").Value
                hoja.Cells.Item(fila + 5, 8) = dGVViajes.Rows(fila).Cells("colCartaPorte").Value
                hoja.Cells.Item(fila + 5, 9) = dGVViajes.Rows(fila).Cells("colContenedores").Value
                hoja.Cells.Item(fila + 5, 10) = dGVViajes.Rows(fila).Cells("colTipoOp").Value
                hoja.Cells.Item(fila + 5, 11) = dGVViajes.Rows(fila).Cells("colEntregarEn").Value
                hoja.Cells.Item(fila + 5, 12) = dGVViajes.Rows(fila).Cells("colRemolque").Value
                hoja.Cells.Item(fila + 5, 13) = dGVViajes.Rows(fila).Cells("colDolly").Value
                hoja.Cells.Item(fila + 5, 14) = dGVViajes.Rows(fila).Cells("colHoraDocumentacion").Value
                hoja.Cells.Item(fila + 5, 15) = dGVViajes.Rows(fila).Cells("colHoraDocumentosEntregados").Value
                filaTotal += 1

            Next

            filaTotal += 4
            borders = hoja.Range("A" & 4, "O" & filaTotal).Borders
            borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            borders.Weight = 2.0R
            hoja.Range("A4", "O4").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.SteelBlue)
            hoja.Range("A1", "O3").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
            hoja.Range("A" & 4, "O" & filaTotal).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Range("A" & 4, "O" & filaTotal).VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Range("A" & 4, "O" & filaTotal).WrapText = True
            hoja.Range("F2", "F2").Value = Me.dTPFecha.Value.ToString("dd/MM/yyyy")
            hoja.Range("F2", "F2").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            hoja.Range("F2", "F2").Borders.Weight = 3.0R
            hoja.Range("F2", "F2").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Range("F2", "F2").VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Range("F3", "F3").Value = Me.dTPFecha.Value.AddDays(2).ToString("dd/MM/yyyy")
            hoja.Range("F3", "F3").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            hoja.Range("F3", "F3").Borders.Weight = 3.0R
            hoja.Range("F3", "F3").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Range("F3", "F3").VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Rows.Item(1).Font.Bold = 1
            hoja.Rows.Item(1).HorizontalAlignment = 3
            hoja.Columns.AutoFit()
            App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()

        End If
    End Sub

    Private Sub guardarReporte()

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ReporteSalidas_Ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 1000
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            For Each viaje As DataGridViewRow In Me.dGVViajes.Rows

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("UP_ReporteSalidas_Detalle_Ins", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                conexion.Open()

                With comando.Parameters

                    .AddWithValue("@unidad", viaje.Cells("colUnidad").Value.ToString())
                    .AddWithValue("@operador", viaje.Cells("colOperador").Value.ToString())
                    .AddWithValue("@placas", viaje.Cells("colPlacas").Value.ToString())
                    .AddWithValue("@viaje", Convert.ToInt32(viaje.Cells("colViaje").Value.ToString()))
                    .AddWithValue("@observaciones", viaje.Cells("colUnidad").Value.ToString())
                    .AddWithValue("@cliente", viaje.Cells("colCliente").Value.ToString())
                    .AddWithValue("@destino", viaje.Cells("colDestino").Value.ToString())
                    .AddWithValue("@cartaPorte", viaje.Cells("colCartaPorte").Value.ToString())
                    .AddWithValue("@contenedores", viaje.Cells("colContenedores").Value.ToString())
                    .AddWithValue("@tipoOper", viaje.Cells("colTipoOp").Value.ToString())
                    .AddWithValue("@direccionEntrega", viaje.Cells("colEntregarEn").Value.ToString())
                    .AddWithValue("@remolque", viaje.Cells("colRemolque").Value.ToString())
                    .AddWithValue("@dolly", viaje.Cells("colDolly").Value.ToString())
                    .AddWithValue("@horaDocumentacionLista", viaje.Cells("colHoraDocumentacion").Value.ToString())
                    .AddWithValue("@horaDocumentosEntregados", viaje.Cells("colHoraDocumentosEntregados").Value.ToString())
                    .AddWithValue("@fechaReporte", Me.dTPFecha.Value)

                End With

                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            Next
        Catch ex As Exception

            MessageBox.Show("Error al guardar el reporte: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Me.eliminarRegistros()

    End Sub

    Private Sub eliminarRegistros()

        For Each viaje As DataGridViewRow In Me.dGVViajes.SelectedRows

            Me.dGVViajes.Rows.Remove(viaje)

        Next
    End Sub
End Class