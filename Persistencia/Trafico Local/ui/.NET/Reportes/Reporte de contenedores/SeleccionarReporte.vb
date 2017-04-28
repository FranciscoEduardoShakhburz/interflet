Imports System.Data.SqlClient

Public Class SeleccionarReporte

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim App As Microsoft.Office.Interop.Excel.Application
        Dim libro As Microsoft.Office.Interop.Excel.Workbook
        Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim dA As SqlDataAdapter
        Dim dS As DataSet
        Dim fechaDesde As Date = Me.dteDesde.Value.ToString("dd/MM/yyyy")
        Dim fechaHasta As Date = Me.dteHasta.Value.ToString("dd/MM/yyyy")
        Dim span As TimeSpan
        Dim diferencia As Int32

        If Me.rdBtnRepGeneral.Checked Then

            span = fechaHasta.Subtract(fechaDesde)
            diferencia = Convert.ToInt32(span.TotalDays)
            App = New Microsoft.Office.Interop.Excel.Application
            libro = App.Workbooks.Add()

            For index As Integer = 0 To diferencia

                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                sql = "SELECT MANIOBRA, TERMINAL, REFERENCIA, CLIENTE, CONTENEDOR, TIPO, LLEGADA, DEMORA, STATUS, NAVIERA, GRUPO, OBSERVACIONES FROM trafico_reporte_estatus_contenedores_detalle det JOIN trafico_reporte_estatus_contenedores enc ON enc.idReporte = det.idReporte WHERE enc.fechaReporte = '" & fechaDesde.AddDays(index).ToString("dd/MM/yyyy") & "'"
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                dA = New SqlDataAdapter(comando)
                dS = New DataSet()
                dA.Fill(dS)

                If dS.Tables(0).Rows.Count > 1 Then

                    hoja = libro.Sheets.Add(, libro.Sheets(libro.Sheets.Count))
                    hoja.Name = fechaDesde.AddDays(index).ToString("dd-MM-yyyy")

                    For index1 As Integer = 1 To dS.Tables(0).Columns.Count

                        hoja.Cells.Item(1, index1) = dS.Tables(0).Columns.Item(index1 - 1).ColumnName

                    Next

                    For fila As Integer = 0 To dS.Tables(0).Rows.Count - 1
                        For columna As Integer = 0 To dS.Tables(0).Columns.Count - 1

                            hoja.Cells.Item(fila + 2, columna + 1) = dS.Tables(0).Rows(fila).Item(columna).ToString()

                        Next
                    Next

                    hoja.Rows.Item(1).Font.Bold = 1
                    hoja.Rows.Item(1).HorizontalAlignment = 3
                    hoja.Columns.AutoFit()

                End If
            Next

            libro.Sheets("hoja1").Delete()
            libro.Sheets("hoja2").Delete()
            'libro.Sheets("hoja3").Delete()
            App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()

        ElseIf Me.rdbtnCargasPase.Checked Then

            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            sql = "SELECT MANIOBRA, TERMINAL, REFERENCIA, CLIENTE, CONTENEDOR, TIPO, LLEGADA, DEMORA, [STATUS], NAVIERA, GRUPO, OBSERVACIONES FROM trafico_reporte_estatus_contenedores_detalle det JOIN trafico_reporte_estatus_contenedores enc ON enc.idReporte = det.idReporte WHERE enc.fechaReporte = '" & Date.Today.ToString("dd/MM/yyyy") & "' AND maniobra <> '' AND [STATUS] = 'DA'"
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            dA = New SqlDataAdapter(comando)
            dS = New DataSet()
            dA.Fill(dS)

            If dS.Tables(0).Rows.Count > 1 Then

                hoja = libro.Sheets.Add(, libro.Sheets(libro.Sheets.Count))
                hoja.Name = Date.Today.ToString("dd-MM-yyyy")

                For index1 As Integer = 1 To dS.Tables(0).Columns.Count

                    hoja.Cells.Item(1, index1) = dS.Tables(0).Columns.Item(index1 - 1).ColumnName

                Next

                For fila As Integer = 0 To dS.Tables(0).Rows.Count - 1
                    For columna As Integer = 0 To dS.Tables(0).Columns.Count - 1

                        hoja.Cells.Item(fila + 2, columna + 1) = dS.Tables(0).Rows(fila).Item(columna).ToString()

                    Next
                Next

                hoja.Rows.Item(1).Font.Bold = 1
                hoja.Rows.Item(1).HorizontalAlignment = 3
                hoja.Columns.AutoFit()
                libro.Sheets("hoja1").Delete()
                libro.Sheets("hoja2").Delete()
                'libro.Sheets("hoja3").Delete()
                App.Application.Visible = True
                hoja = Nothing
                libro = Nothing
                App = Nothing
                GC.Collect()

            End If
            Else

                MessageBox.Show("Por favor, seleccione un reporte", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub
End Class