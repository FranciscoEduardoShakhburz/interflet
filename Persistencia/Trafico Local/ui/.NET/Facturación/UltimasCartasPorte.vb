Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class UltimasCartasPorte

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim tracto As DataSet
        Dim remolque As DataSet
        Dim dolly As DataSet
        Dim unidades As List(Of String)
        Dim remolques As List(Of String)
        Dim dollys As List(Of String)
        Dim sql As String
        Dim k As Integer = 0
        Dim l As Integer = 0

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        comando = New SqlCommand("up_consultarNumEco_equipos", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandTimeout = 10000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        If dS.Tables.Count > 0 AndAlso dS.Tables(0).Rows.Count > 0 Then

            unidades = New List(Of String)

            For index As Integer = 1 To dS.Tables(0).Rows.Count - 1

                unidades.Add(dS.Tables(0).Rows(index)(0).ToString())

            Next

            remolques = New List(Of String)

            For index As Integer = 0 To dS.Tables(2).Rows.Count - 1

                remolques.Add(dS.Tables(2).Rows(index)(0).ToString())

            Next
            
            dollys = New List(Of String)

            For index As Integer = 0 To dS.Tables(1).Rows.Count - 1

                dollys.Add(dS.Tables(1).Rows(index)(0).ToString())

            Next

            tracto = New DataSet()
            tracto.Tables.Add()
            tracto.Tables(0).Columns.Add("UNIDAD")
            tracto.Tables(0).Columns.Add("AREA")
            tracto.Tables(0).Columns.Add("ULTIMA CARTA PORTE")
            tracto.Tables(0).Columns.Add("FECHA ULTIMA C.P.")
            tracto.Tables(0).Columns.Add("STATUS ULTIMA CP")
            tracto.Tables(0).Columns.Add("OPERADOR ULTIMA C.P.")
            tracto.Tables(0).Columns.Add("PENULTIMA CARTA PORTE")
            tracto.Tables(0).Columns.Add("FECHA PENULTIMA C.P.")
            tracto.Tables(0).Columns.Add("STATUS PENULTIMA CP")
            tracto.Tables(0).Columns.Add("NO. DE DÍAS SIN MOVIMIENTOS")
            tracto.Tables(0).Columns.Add("FECHA Y HORA ULT. MOV.")
            tracto.Tables(0).Columns.Add("TIPO DE MOVIMIENTO")
            tracto.Tables(0).Columns.Add("LUGAR")
            tracto.Tables(0).Columns.Add("ESTATUS")
            remolque = New DataSet()
            remolque.Tables.Add()
            remolque.Tables(0).Columns.Add("REMOLQUE")
            'remolque.Tables(0).Columns.Add("AREA")
            remolque.Tables(0).Columns.Add("ULTIMA CARTA PORTE")
            remolque.Tables(0).Columns.Add("FECHA ULTIMA C.P.")
            remolque.Tables(0).Columns.Add("STATUS ULTIMA CP")
            remolque.Tables(0).Columns.Add("OPERADOR ULTIMA C.P.")
            remolque.Tables(0).Columns.Add("PENULTIMA CARTA PORTE")
            remolque.Tables(0).Columns.Add("FECHA PENULTIMA C.P.")
            remolque.Tables(0).Columns.Add("STATUS PENULTIMA CP")
            remolque.Tables(0).Columns.Add("NO. DE DÍAS SIN MOVIMIENTOS")
            remolque.Tables(0).Columns.Add("FECHA Y HORA ULT. MOV.")
            remolque.Tables(0).Columns.Add("TIPO DE MOVIMIENTO")
            remolque.Tables(0).Columns.Add("LUGAR")
            remolque.Tables(0).Columns.Add("ESTATUS")
            dolly = New DataSet()
            dolly.Tables.Add()
            dolly.Tables(0).Columns.Add("DOLLY")
            'dolly.Tables(0).Columns.Add("AREA")
            dolly.Tables(0).Columns.Add("ULTIMA CARTA PORTE")
            dolly.Tables(0).Columns.Add("FECHA ULTIMA C.P.")
            dolly.Tables(0).Columns.Add("STATUS ULTIMA CP")
            dolly.Tables(0).Columns.Add("OPERADOR ULTIMA C.P.")
            dolly.Tables(0).Columns.Add("PENULTIMA CARTA PORTE")
            dolly.Tables(0).Columns.Add("FECHA PENULTIMA C.P.")
            dolly.Tables(0).Columns.Add("STATUS PENULTIMA CP")
            dolly.Tables(0).Columns.Add("NO. DE DÍAS SIN MOVIMIENTOS")
            dolly.Tables(0).Columns.Add("FECHA Y HORA ULT. MOV.")
            dolly.Tables(0).Columns.Add("TIPO DE MOVIMIENTO")
            dolly.Tables(0).Columns.Add("LUGAR")
            dolly.Tables(0).Columns.Add("ESTATUS")

            For Each unidad As String In unidades

                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand("up_ultimasCP_unidades", conexion)

                With comando.Parameters

                    .AddWithValue("@unidad", unidad)
                    .AddWithValue("@tipoUnidad", 1)

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables.Count > 0 AndAlso dS.Tables(0).Rows.Count > 0 Then

                    tracto.Tables(0).Rows.Add()
                    tracto.Tables(0).Rows(k)(0) = unidad
                    
                    For j As Integer = 2 To 4

                        tracto.Tables(0).Rows(k)(j) = dS.Tables(0).Rows(0)(j)

                    Next

                    tracto.Tables(0).Rows(k)(5) = dS.Tables(0).Rows(1)(1)
                    tracto.Tables(0).Rows(k)(6) = dS.Tables(0).Rows(1)(2)
                    tracto.Tables(0).Rows(k)(7) = dS.Tables(0).Rows(1)(3)
                    tracto.Tables(0).Rows(k)(8) = dS.Tables(0).Rows(0)(5)
                    tracto.Tables(0).Rows(k)(12) = dS.Tables(0).Rows(0)(6)
                    tracto.Tables(0).Rows(k)(1) = dS.Tables(0).Rows(0)(7)

                    If dS.Tables(1).Rows.Count > 0 Then

                        tracto.Tables(0).Rows(k)(9) = dS.Tables(1).Rows(0)(0) & " " & dS.Tables(1).Rows(0)(1)
                        tracto.Tables(0).Rows(k)(10) = dS.Tables(1).Rows(0)(2)
                        tracto.Tables(0).Rows(k)(11) = dS.Tables(1).Rows(0)(3)

                    End If

                    k += 1

                End If
            Next

            comando.Dispose()
            conexion.Close()
            k = 0

            For index As Integer = 0 To remolques.Count - 1

                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand("up_ultimasCP_unidades", conexion)

                With comando.Parameters

                    .AddWithValue("@unidad", remolques.Item(index))
                    .AddWithValue("@tipoUnidad", 2)

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables.Count > 0 AndAlso dS.Tables(0).Rows.Count > 0 Then

                    remolque.Tables(0).Rows.Add()
                    remolque.Tables(0).Rows(k)(0) = remolques.Item(index)

                    For j As Integer = 1 To 4

                        remolque.Tables(0).Rows(k)(j) = dS.Tables(0).Rows(0)(j)

                    Next

                    remolque.Tables(0).Rows(k)(5) = dS.Tables(0).Rows(1)(1)
                    remolque.Tables(0).Rows(k)(6) = dS.Tables(0).Rows(1)(2)
                    remolque.Tables(0).Rows(k)(7) = dS.Tables(0).Rows(1)(3)
                    remolque.Tables(0).Rows(k)(8) = dS.Tables(0).Rows(0)(5)
                    remolque.Tables(0).Rows(k)(12) = dS.Tables(0).Rows(0)(6)

                    If dS.Tables(1).Rows.Count > 0 Then

                        remolque.Tables(0).Rows(k)(9) = dS.Tables(1).Rows(0)(0) & " " & dS.Tables(1).Rows(0)(1)
                        remolque.Tables(0).Rows(k)(10) = dS.Tables(1).Rows(0)(2)
                        remolque.Tables(0).Rows(k)(11) = dS.Tables(1).Rows(0)(3)

                    End If

                    k += 1

                End If
            Next

            comando.Dispose()
            conexion.Close()
            k = 0

            For index As Integer = 0 To dollys.Count - 1

                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand("up_ultimasCP_unidades", conexion)

                With comando.Parameters

                    .AddWithValue("@unidad", dollys.Item(index))
                    .AddWithValue("@tipoUnidad", 3)

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables.Count > 0 AndAlso dS.Tables(0).Rows.Count > 0 Then

                    dolly.Tables(0).Rows.Add()
                    dolly.Tables(0).Rows(k)(0) = dollys.Item(index)

                    For j As Integer = 1 To 4

                        dolly.Tables(0).Rows(k)(j) = dS.Tables(0).Rows(0)(j)

                    Next

                    If dS.Tables(0).Rows.Count > 1 Then

                        dolly.Tables(0).Rows(k)(5) = dS.Tables(0).Rows(1)(1)
                        dolly.Tables(0).Rows(k)(6) = dS.Tables(0).Rows(1)(2)
                        dolly.Tables(0).Rows(k)(7) = dS.Tables(0).Rows(1)(3)

                    End If
                    
                    dolly.Tables(0).Rows(k)(8) = dS.Tables(0).Rows(0)(5)
                    dolly.Tables(0).Rows(k)(12) = dS.Tables(0).Rows(0)(6)

                    If dS.Tables(1).Rows.Count > 0 Then

                        dolly.Tables(0).Rows(k)(9) = dS.Tables(1).Rows(0)(0) & " " & dS.Tables(1).Rows(0)(1)
                        dolly.Tables(0).Rows(k)(10) = dS.Tables(1).Rows(0)(2)
                        dolly.Tables(0).Rows(k)(11) = dS.Tables(1).Rows(0)(3)

                    End If

                    k += 1

                End If
            Next

            comando.Dispose()
            conexion.Close()

            Me.exportar(remolque, dolly, tracto)
            Cursor.Current = Cursors.Arrow

        End If
    End Sub

    Private Sub exportar(ByVal dataset1 As DataSet, ByVal dataset2 As DataSet, ByVal dataset3 As DataSet)

        Dim App As New Microsoft.Office.Interop.Excel.Application
        Dim libro As Microsoft.Office.Interop.Excel.Workbook
        Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim filaTotal As Integer = 0
        libro = App.Workbooks.Add

        If dataset1.Tables.Count > 0 Then

            'libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add

            For tablaActual As Integer = 0 To dataset1.Tables.Count - 1
                For i As Integer = 1 To dataset1.Tables(tablaActual).Columns.Count - 1

                    hoja.Cells.Item(filaTotal + 1, i) = dataset1.Tables(tablaActual).Columns(i - 1).ToString()

                Next

                filaTotal += 1

                Dim inicioFormato As Integer = filaTotal

                For fila As Integer = 0 To dataset1.Tables(tablaActual).Rows.Count - 1
                    If Not dataset1.Tables(tablaActual).Rows(fila).RowState = DataRowState.Deleted Then
                        For columna As Integer = 0 To dataset1.Tables(tablaActual).Columns.Count - 2

                            hoja.Cells.Item(filaTotal + 1, columna + 1) = dataset1.Tables(tablaActual).Rows(fila).Item(columna).ToString()

                        Next

                        If Convert.ToInt32(dataset1.Tables(tablaActual).Rows(fila).Item(12).ToString()) = 1 Then

                            hoja.Range("A" & (filaTotal + 1) & ":L" & (filaTotal + 1)).Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)

                        End If

                        filaTotal += 1

                    End If
                Next

                hoja.Cells.Item(filaTotal + 1, 1) = ""
                filaTotal += 1

            Next

            If Me.rdBtnDias.Checked Then

                hoja.Range("A1", "L" & filaTotal).Select()
                hoja.Range("A1", "L" & filaTotal).Sort(Key1:=hoja.Range("A1", "L" & filaTotal).Range("I1"), _
                                    Order1:=Microsoft.Office.Interop.Excel.XlSortOrder.xlDescending, _
                                    Orientation:=Microsoft.Office.Interop.Excel.XlSortOrientation.xlSortColumns)

            End If

            hoja.Columns.AutoFit()
            hoja.Rows.Item(1).Font.Bold = 1

        End If

        filaTotal = 0

        If dataset2.Tables.Count > 0 Then

            hoja = libro.Worksheets.Add

            For tablaActual As Integer = 0 To dataset2.Tables.Count - 1
                For i As Integer = 1 To dataset2.Tables(tablaActual).Columns.Count - 1

                    hoja.Cells.Item(filaTotal + 1, i) = dataset2.Tables(tablaActual).Columns(i - 1).ToString()

                Next

                filaTotal += 1

                Dim inicioFormato As Integer = filaTotal

                For fila As Integer = 0 To dataset2.Tables(tablaActual).Rows.Count - 1
                    If Not dataset2.Tables(tablaActual).Rows(fila).RowState = DataRowState.Deleted Then
                        For columna As Integer = 0 To dataset2.Tables(tablaActual).Columns.Count - 2

                            hoja.Cells.Item(filaTotal + 1, columna + 1) = dataset2.Tables(tablaActual).Rows(fila).Item(columna).ToString()

                        Next

                        If Convert.ToInt32(dataset2.Tables(tablaActual).Rows(fila).Item(12).ToString()) = 1 Then

                            hoja.Range("A" & (filaTotal + 1) & ":L" & (filaTotal + 1)).Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)

                        End If

                        filaTotal += 1

                    End If
                Next

                hoja.Cells.Item(filaTotal + 1, 1) = ""
                filaTotal += 1

            Next

            If Me.rdBtnDias.Checked Then

                hoja.Range("A1", "M" & filaTotal).Select()
                hoja.Range("A1", "M" & filaTotal).Sort(Key1:=hoja.Range("A1", "M" & filaTotal).Range("I1"), _
                                    Order1:=Microsoft.Office.Interop.Excel.XlSortOrder.xlDescending, _
                                    Orientation:=Microsoft.Office.Interop.Excel.XlSortOrientation.xlSortColumns)

            End If

            hoja.Columns.AutoFit()
            hoja.Rows.Item(1).Font.Bold = 1

        End If

        filaTotal = 0

        If dataset3.Tables.Count > 0 Then

            hoja = libro.Worksheets.Add

            For tablaActual As Integer = 0 To dataset3.Tables.Count - 1
                For i As Integer = 1 To dataset3.Tables(tablaActual).Columns.Count - 1

                    hoja.Cells.Item(filaTotal + 1, i) = dataset3.Tables(tablaActual).Columns(i - 1).ToString()

                Next

                filaTotal += 1
                Dim inicioFormato As Integer = filaTotal

                For fila As Integer = 0 To dataset3.Tables(tablaActual).Rows.Count - 1
                    If Convert.ToInt16(dataset3.Tables(tablaActual).Rows(fila).Item(12).ToString()) = 1 AndAlso Me.chkActivos.Checked Then

                        Continue For

                    End If

                    If Not dataset3.Tables(tablaActual).Rows(fila).RowState = DataRowState.Deleted Then
                        For columna As Integer = 0 To dataset3.Tables(tablaActual).Columns.Count - 2

                            hoja.Cells.Item(filaTotal + 1, columna + 1) = dataset3.Tables(tablaActual).Rows(fila).Item(columna).ToString()

                        Next

                        If Convert.ToInt32(dataset3.Tables(tablaActual).Rows(fila).Item(12).ToString()) = 1 Then

                            hoja.Range("A" & (filaTotal + 1) & ":M" & (filaTotal + 1)).Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)

                        End If

                        filaTotal += 1

                    End If
                Next

                hoja.Cells.Item(filaTotal + 1, 1) = ""
                filaTotal += 1

            Next

            If Me.rdBtnDias.Checked Then

                hoja.Range("A1", "M" & filaTotal).Select()
                hoja.Range("A1", "M" & filaTotal).Sort(Key1:=hoja.Range("A1", "M" & filaTotal).Range("I1"), _
                                    Order1:=Microsoft.Office.Interop.Excel.XlSortOrder.xlDescending, _
                                    Orientation:=Microsoft.Office.Interop.Excel.XlSortOrientation.xlSortColumns)

            End If

            hoja.Columns.AutoFit()
            hoja.Rows.Item(1).Font.Bold = 1
            App.Application.Visible = True

        End If

        hoja = Nothing
        libro = Nothing
        App = Nothing
        GC.Collect()

    End Sub

    Private Sub UltimasCartasPorte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.rdBtnUnidad.Checked = True
        Me.chkActivos.Checked = True

    End Sub
End Class