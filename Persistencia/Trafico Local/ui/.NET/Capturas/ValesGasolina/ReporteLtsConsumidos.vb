Imports System.Data
Imports System.Data.SqlClient

Public Class ReporteLtsConsumidos

    Private Sub ReporteLtsConsumidos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.rdBtnFechas.Checked = True

    End Sub

    Private Sub consultarInformacion(ByVal tipoBusqueda As Integer, ByVal desde As Date, ByVal hasta As Date, ByVal numVale As Integer)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim val As DataGridViewRow
        Dim index As Integer

        Try

            Me.dGVVales.Rows.Clear()
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Consulta_ValesGas", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@tipoBusqueda", tipoBusqueda)
                .AddWithValue("@desde", desde)
                .AddWithValue("@hasta", hasta)
                .AddWithValue("@numVale", numVale)

            End With

            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each vale As DataRow In dS.Tables(0).Rows

                        index = Me.dGVVales.Rows.Add()
                        val = Me.dGVVales.Rows.Item(index)
                        val.Cells("colTracto").Value = vale("No. TRACTO")
                        val.Cells("colMarca").Value = vale("MARCA")
                        val.Cells("colOperador").Value = vale("OPERADOR")
                        val.Cells("colFecha").Value = vale("Fecha de consumo")
                        val.Cells("colNoVale").Value = vale("No. Vale")
                        val.Cells("colCombustible").Value = vale("Combustible")
                        val.Cells("colLitros").Value = vale("Lts Cargados")

                    Next

                    Me.filtrarVales()

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message & ". " & ex.InnerException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub checarTipoBusqueda()

        If Me.rdBtnFechas.Checked Then

            Me.consultarInformacion(1, Me.dTPDesde.Value, Me.dTPHasta.Value, 0)

        ElseIf Me.rdBtnNumero.Checked Then
            If Me.rdBtnNumero.Checked Then
                If String.IsNullOrEmpty(Me.txtNumVale.Text) Then

                    Me.dGVVales.Rows.Clear()

                Else

                    Me.consultarInformacion(2, DateTime.MinValue, DateTime.MinValue, Convert.ToInt32(Me.txtNumVale.Text))

                End If
            End If
        End If
    End Sub

    Private Sub filtrarVales()

        If Me.dGVFactura.Rows.Count > 0 Then
            For Each valeFactura As DataGridViewRow In Me.dGVFactura.Rows
                For Each vale As DataGridViewRow In Me.dGVVales.Rows
                    If vale.Cells("colNoVale").Value = valeFactura.Cells("colVale").Value Then

                        Me.dGVVales.Rows.Remove(vale)

                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rdBtnFechas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdBtnFechas.CheckedChanged, rdBtnNumero.CheckedChanged

        Me.checarTipoBusqueda()

    End Sub

    Private Sub dTPDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dTPDesde.ValueChanged, dTPHasta.ValueChanged

        If Me.rdBtnFechas.Checked Then

            Me.consultarInformacion(1, Me.dTPDesde.Value, Me.dTPHasta.Value, 0)
            
        End If
    End Sub

    Private Sub txtNumVale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumVale.TextChanged

        If Me.rdBtnNumero.Checked Then
            If String.IsNullOrEmpty(Me.txtNumVale.Text) Then

                Me.dGVVales.Rows.Clear()

            Else

                Me.consultarInformacion(2, Me.dTPDesde.Value, Me.dTPDesde.Value, Convert.ToInt32(Me.txtNumVale.Text))

            End If
        End If
    End Sub

    Private Sub btnDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDerecha.Click

        Dim indice As Integer
        Dim valePorFacturar As DataGridViewRow

        For Each valesSeleccionados As DataGridViewRow In Me.dGVVales.SelectedRows

            indice = Me.dGVFactura.Rows.Add()
            valePorFacturar = Me.dGVFactura.Rows.Item(indice)
            valePorFacturar.Cells("colNoTracto").Value = valesSeleccionados.Cells("colTracto").Value
            valePorFacturar.Cells("colMarc").Value = valesSeleccionados.Cells("colMarca").Value
            valePorFacturar.Cells("colOpe").Value = valesSeleccionados.Cells("colOperador").Value
            valePorFacturar.Cells("colFec").Value = valesSeleccionados.Cells("colFecha").Value
            valePorFacturar.Cells("colVale").Value = valesSeleccionados.Cells("colNoVale").Value
            valePorFacturar.Cells("colComb").Value = valesSeleccionados.Cells("colCombustible").Value
            valePorFacturar.Cells("colLts").Value = valesSeleccionados.Cells("colLitros").Value
            valePorFacturar.Cells("colCostoPorLt").Value = "13.16"
            valePorFacturar.Cells("colImporte").Value = (Convert.ToDecimal(valesSeleccionados.Cells("colLitros").Value) * 13.16)
            valePorFacturar.Cells("colKilometrajeInicial").Value = ""
            valePorFacturar.Cells("colKilometrajeFinal").Value = ""
            valePorFacturar.Cells("colKmsRecorridos").Value = ""
            valePorFacturar.Cells("colRendimiento").Value = ""
            Me.dGVVales.Rows.Remove(valesSeleccionados)
            Me.dGVVales.Update()

        Next
    End Sub

    Private Sub btnIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzquierda.Click

        Dim indice As Integer
        Dim valePorRegresar As DataGridViewRow

        For Each valesSeleccionados As DataGridViewRow In Me.dGVFactura.SelectedRows

            indice = Me.dGVVales.Rows.Add()
            valePorRegresar = Me.dGVVales.Rows(indice)
            valePorRegresar.Cells("colTracto").Value = valesSeleccionados.Cells("colNoTracto").Value
            valePorRegresar.Cells("colMarca").Value = valesSeleccionados.Cells("colMarc").Value
            valePorRegresar.Cells("colOperador").Value = valesSeleccionados.Cells("colOpe").Value
            valePorRegresar.Cells("colFecha").Value = valesSeleccionados.Cells("colFec").Value
            valePorRegresar.Cells("colNoVale").Value = valesSeleccionados.Cells("colVale").Value
            valePorRegresar.Cells("colCombustible").Value = valesSeleccionados.Cells("colComb").Value
            valePorRegresar.Cells("colLitros").Value = valesSeleccionados.Cells("colLts").Value
            Me.dGVFactura.Rows.Remove(valesSeleccionados)
            Me.dGVFactura.Update()

        Next
        End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Me.exportarReporte(Me.dGVFactura)

    End Sub

    Private Sub exportarReporte(ByVal grid As DataGridView)

        If grid.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim columnas As Integer = grid.ColumnCount
            Dim filas As Integer = grid.RowCount
            Dim totalLitros As Decimal = 0
            Dim totalImporte As Decimal = 0
            Dim ultimaFila As Integer

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()
            hoja.Range(hoja.Cells.Item(4, 3), hoja.Cells.Item(4, 9)).Font.Name = "Arial"
            hoja.Range(hoja.Cells.Item(4, 3), hoja.Cells.Item(4, 9)).Font.Size = 16
            hoja.Cells.Item(4, 3) = "Reporte de Litros consumidos, según Factura No."
            hoja.Range(hoja.Cells.Item(4, 3), hoja.Cells.Item(4, 9)).Merge()
            hoja.Cells.Item(4, 12) = Me.txtNum.Text
            hoja.Range(hoja.Cells.Item(4, 12), hoja.Cells.Item(4, 13)).Merge()
            hoja.Range(hoja.Cells.Item(4, 12), hoja.Cells.Item(4, 13)).HorizontalAlignment = 3
            hoja.Range(hoja.Cells.Item(4, 12), hoja.Cells.Item(4, 13)).Font.Bold = 1
            hoja.Range(hoja.Cells.Item(4, 12), hoja.Cells.Item(4, 13)).Font.Size = 14
            hoja.Range(hoja.Cells.Item(4, 12), hoja.Cells.Item(4, 13)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            hoja.Range(hoja.Cells.Item(4, 12), hoja.Cells.Item(4, 13)).Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium

            For i As Integer = 0 To columnas - 1

                hoja.Cells.Item(6, i + 3) = grid.Columns(i).HeaderText
                hoja.Cells.Item(6, i + 3).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                hoja.Cells.Item(6, i + 3).WrapText = True
                hoja.Cells.Item(6, i + 3).HorizontalAlignment = 3
                hoja.Cells.Item(6, i + 3).VerticalAlignment = 2

            Next

            For fila As Integer = 0 To filas - 1

                totalLitros += Convert.ToDecimal(grid.Rows(fila).Cells("colLts").Value.ToString())
                totalImporte += Convert.ToDecimal(grid.Rows(fila).Cells("colImporte").Value.ToString())

                For columna As Integer = 0 To columnas - 1

                    hoja.Cells.Item(fila + 7, columna + 3) = grid.Rows(fila).Cells(columna).Value

                    hoja.Cells.Item(fila + 7, columna + 3).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    hoja.Cells.Item(fila + 7, columna + 3).WrapText = True
                    hoja.Cells.Item(fila + 7, columna + 3).HorizontalAlignment = 3
                    hoja.Cells.Item(fila + 7, columna + 3).VerticalAlignment = 2
                    ultimaFila = fila + 7

                Next
            Next

            hoja.Cells.Item(ultimaFila + 2, 10) = "LTS MAGNA     " & totalLitros
            hoja.Cells.Item(ultimaFila + 2, 10).Font.Bold = 1
            hoja.Cells.Item(ultimaFila + 2, 10).HorizontalAlignment = 1
            hoja.Range(hoja.Cells.Item(ultimaFila + 2, 9), hoja.Cells.Item(ultimaFila + 2, 10)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            hoja.Range(hoja.Cells.Item(ultimaFila + 2, 10), hoja.Cells.Item(ultimaFila + 2, 10)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            hoja.Range(hoja.Cells.Item(ultimaFila + 2, 8), hoja.Cells.Item(ultimaFila + 2, 10)).Merge()
            hoja.Cells.Item(ultimaFila + 2, 11) = totalImporte
            hoja.Cells.Item(ultimaFila + 2, 11).Font.Bold = 1
            hoja.Cells.Item(ultimaFila + 2, 11).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            hoja.Cells.Item(ultimaFila + 2, 11).Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick
            hoja.Columns.AutoFit()
            App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()

        End If
    End Sub
End Class