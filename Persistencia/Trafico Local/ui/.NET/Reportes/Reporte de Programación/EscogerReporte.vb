Imports System.Data
Imports System.Data.SqlClient


Public Class EscogerReporte

    Private fechaInicial As Date
    Private fechaFinal As Date

    Public Sub New(ByVal fechaInicial As String, ByVal fechaFinal As String)

        Me.InitializeComponent()
        Me.fechaInicial = fechaInicial
        Me.fechaFinal = fechaFinal

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim dA As SqlDataAdapter
        Dim dS As DataSet
        Dim fechaDesde As Date = Me.fechaInicial
        Dim fechaHasta As Date = Me.fechaFinal

        Try

            If Me.rdBtnReporteProgramacion.Checked Then

                Cursor.Current = Cursors.WaitCursor
                Dim App As Microsoft.Office.Interop.Excel.Application
                Dim libro As Microsoft.Office.Interop.Excel.Workbook
                Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
                Dim sql As String
                Dim span As TimeSpan
                Dim diferencia As Int32
                Dim filaX As Int32

                span = fechaHasta.Subtract(fechaDesde)
                diferencia = Convert.ToInt32(span.TotalDays)
                App = New Microsoft.Office.Interop.Excel.Application
                libro = App.Workbooks.Add()

                For index As Integer = 0 To diferencia

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    sql = "SELECT EJ_CTA AS [EJECTIVO DE CUENTA], NAVIERA, OPERACION = TIPO_OPER, TERMINAL, REFERENCIA, CLIENTE, CONTENEDOR, TIPO, PESO, DESTINO, ALMACENAJE, OBSERVACIONES, PLANTA FROM trafico_reporte_programacion WHERE CONVERT(VARCHAR(15), fecha_subida, 103) = '" & Me.fechaInicial.AddDays(index).ToString("dd/MM/yyyy") & "'"
                    sql += "SELECT TERMINAL, CLIENTE, OPERACION = 'EXPO', REFERENCIA, BOOKING, PEDIDO, CONTENEDOR, PLANTA, DOCUMENTAL, CIERRE FROM trafico_reporte_programacion_expo WHERE CONVERT(VARCHAR(15), fecha_subida, 103) = '" & Me.fechaInicial.AddDays(index).ToString("dd/MM/yyyy") & "'"
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

                                filaX = fila + 2
                                hoja.Cells.Item(filaX, columna + 1) = dS.Tables(0).Rows(fila).Item(columna).ToString()

                            Next
                        Next

                        filaX += 2

                        If dS.Tables(1).Rows.Count > 1 Then

                            hoja.Rows.Item(filaX).Font.Bold = 1
                            hoja.Rows.Item(filaX).HorizontalAlignment = 3

                            For index1 As Integer = 1 To dS.Tables(1).Columns.Count

                                hoja.Cells.Item(filaX, index1) = dS.Tables(1).Columns.Item(index1 - 1).ColumnName

                            Next

                            filaX += 1

                            For fila As Integer = 0 To dS.Tables(1).Rows.Count - 1
                                For columna As Integer = 0 To dS.Tables(1).Columns.Count - 1

                                    hoja.Cells.Item(filaX, columna + 1) = dS.Tables(1).Rows(fila).Item(columna).ToString()

                                Next

                                filaX += 1

                            Next
                        End If

                        hoja.Rows.Item(1).Font.Bold = 1
                        hoja.Rows.Item(1).HorizontalAlignment = 3
                        hoja.Columns.AutoFit()

                    End If
                Next

                libro.Sheets("hoja1").Delete()
                libro.Sheets("hoja2").Delete()
                libro.Sheets("hoja3").Delete()
                App.Application.Visible = True
                hoja = Nothing
                libro = Nothing
                App = Nothing
                GC.Collect()
                Me.Dispose()

            ElseIf Me.rdBtnReporteVisitas.Checked Then

                Dim separator(1) As String
                Dim lon As Int16
                Dim dS1 As DataSet = New DataSet()
                Dim dS2 As DataSet = New DataSet()
                Dim dS3 As DataSet = New DataSet()

                separator(0) = "/"

                If Me.chkPendientes.Checked Then

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand("up_reporte_visitas", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000

                    With comando.Parameters

                        .AddWithValue("@fechaInicial", Me.desdePendientes.Value.ToString("dd/MM/yyyy"))
                        .AddWithValue("@fechaFinal", Me.hastaPendientes.Value.ToString("dd/MM/yyyy"))
                        .AddWithValue("@tipoReporte ", 1)

                    End With

                    dA = New SqlDataAdapter(comando)
                    dS = New DataSet()
                    dA.Fill(dS)
                    Me.eliminarBoletas(dS)
                    Dim i As Integer = 0
                    Dim j As Integer = i + 1
                    Dim contador As Integer = 1
                    Dim contenedor As String

                    While i < dS.Tables(0).Rows.Count - 1
                        While j < dS.Tables(0).Rows.Count - 1
                            If dS.Tables(0).Rows(i)("CLIENTE").ToString().Equals(dS.Tables(0).Rows(j)("CLIENTE").ToString()) And dS.Tables(0).Rows(i)("REFERENCIA").ToString().Equals(dS.Tables(0).Rows(j)("REFERENCIA").ToString()) And dS.Tables(0).Rows(i)("VISITA").ToString().Equals(dS.Tables(0).Rows(j)("VISITA").ToString()) Then

                                dS.Tables(0).Rows(i)("NUM. CONT.") += " / " + dS.Tables(0).Rows(j)("NUM. CONT.")
                                dS.Tables(0).Rows(j).Delete()
                                dS.Tables(0).AcceptChanges()
                                contador += 1

                            Else

                                j += 1

                            End If
                        End While

                        If contador > 1 Then

                            dS.Tables(0).Rows(i)("CONT") = contador & " X " & dS.Tables(0).Rows(i)("CONT")
                            contador = 1

                        End If

                        i += 1
                        j = i + 1

                    End While

                    For Each fila As DataRow In dS.Tables(0).Rows

                        'fila.Item(2) = fila.Item(1).ToString().Split(separator, StringSplitOptions.None)(lon - 1)
                        lon = fila.Item("TERMINAL ORIGEN").ToString().Split(separator, StringSplitOptions.None).Length

                        If lon >= 2 Then

                            fila.Item("TERMINAL ORIGEN") = fila.Item("TERMINAL ORIGEN").ToString().Split(separator, StringSplitOptions.None)(0)
                            fila.AcceptChanges()

                        End If
                    Next

                    dS1 = dS
                    conexion.Close()
                    comando.Dispose()

                End If

                If Me.chkPatio.Checked Then

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand("up_reporte_visitas", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000

                    With comando.Parameters

                        .AddWithValue("@fechaInicial", Me.desdePatio.Value.ToString("dd/MM/yyyy"))
                        .AddWithValue("@fechaFinal", Me.hastaPatio.Value.ToString("dd/MM/yyyy"))
                        .AddWithValue("@tipoReporte ", 2)

                    End With

                    dA = New SqlDataAdapter(comando)
                    dS = New DataSet()
                    dA.Fill(dS)

                    For Each fila As DataRow In dS.Tables(0).Rows

                        lon = fila.Item(1).ToString().Split(separator, StringSplitOptions.None).Length

                        If lon >= 2 Then

                            'fila.Item(2) = fila.Item(1).ToString().Split(separator, StringSplitOptions.None)(lon - 1)
                            fila.Item(1) = fila.Item(1).ToString().Split(separator, StringSplitOptions.None)(0)
                            fila.AcceptChanges()

                        End If
                    Next

                    dS2 = dS
                    conexion.Close()
                    comando.Dispose()

                End If

                If Me.chkTodo.Checked Then

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand("up_reporte_visitas", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000

                    With comando.Parameters

                        .AddWithValue("@fechaInicial", Me.desdePendientes.Value.ToString("dd/MM/yyyy"))
                        .AddWithValue("@fechaFinal", Me.hastaPendientes.Value.ToString("dd/MM/yyyy"))
                        .AddWithValue("@tipoReporte ", 3)

                    End With

                    dA = New SqlDataAdapter(comando)
                    dS = New DataSet()
                    dA.Fill(dS)

                    For Each fila As DataRow In dS.Tables(0).Rows

                        lon = fila.Item(1).ToString().Split(separator, StringSplitOptions.None).Length

                        If lon >= 2 Then

                            'fila.Item(2) = fila.Item(1).ToString().Split(separator, StringSplitOptions.None)(lon - 1)
                            fila.Item(1) = fila.Item(1).ToString().Split(separator, StringSplitOptions.None)(0)
                            fila.AcceptChanges()

                        End If
                    Next

                    dS3 = dS
                    conexion.Close()
                    comando.Dispose()

                End If

                If Me.chkPendientes.Checked And Me.chkPatio.Checked Then

                    Excel.twoDataSetToExcel(dS1, dS2)

                ElseIf Me.chkPendientes.Checked Then

                    Excel.datasetToExcel(dS1)

                ElseIf Me.chkPatio.Checked Then

                    Excel.datasetToExcel(dS2)

                ElseIf Me.chkTodo.Checked Then

                    Excel.datasetToExcel(dS3)

                End If
            End If

            Me.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    Private Sub rdBtnReporteProgramacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBtnReporteProgramacion.CheckedChanged, rdBtnResumen.CheckedChanged

        If Me.rdBtnReporteProgramacion.Checked Or Me.rdBtnResumen.Checked Then

            Me.chkPendientes.Visible = False
            Me.chkPatio.Visible = False
            Me.chkTodo.Visible = False
            Me.Label1.Visible = False
            Me.Label2.Visible = False
            Me.Label3.Visible = False
            Me.Label4.Visible = False
            Me.desdePendientes.Visible = False
            Me.hastaPendientes.Visible = False
            Me.desdePatio.Visible = False
            Me.hastaPatio.Visible = False

        Else

            Me.chkPendientes.Visible = True
            Me.chkPatio.Visible = True
            Me.chkTodo.Visible = True
            Me.Label1.Visible = True
            Me.Label2.Visible = True
            Me.Label3.Visible = True
            Me.Label4.Visible = True
            Me.desdePendientes.Visible = True
            Me.hastaPendientes.Visible = True
            Me.desdePatio.Visible = True
            Me.hastaPatio.Visible = True

        End If
    End Sub

    Private Sub chkTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodo.CheckedChanged

        If chkTodo.Checked Then

            Me.chkPendientes.Checked = False
            Me.chkPatio.Checked = False

        Else

            Me.chkTodo.Checked = False

        End If
    End Sub

    Private Sub chkPendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPendientes.CheckedChanged, chkPatio.CheckedChanged

        Me.chkTodo.Checked = False

    End Sub

    Private Sub eliminarBoletas(ByRef ds As DataSet)

        Dim index1 As Integer = 0
        Dim index2 As Integer = 0

        If ds.Tables.Count > 0 Then
            While index1 < ds.Tables(0).Rows.Count
                While index2 < ds.Tables(1).Rows.Count
                    If ds.Tables(0).Rows(index1)("NUM. CONT.").ToString().Equals(ds.Tables(1).Rows(index2)("NUM. CONT.").ToString()) Then

                        ds.Tables(1).Rows(index2).Delete()
                        ds.Tables(1).AcceptChanges()

                    Else

                        index2 += 1

                    End If
                End While

                index1 += 1
                index2 = 0

            End While
        End If
    End Sub
End Class