Imports System.Drawing.Color
Imports Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb

Public Class Excel

    Public Shared Sub datasetToExcel(ByVal dataset As DataSet)

        If dataset.Tables.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim filaTotal As Integer = 0

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add

            For tablaActual As Integer = 0 To dataset.Tables.Count - 1
                For i As Integer = 1 To dataset.Tables(tablaActual).Columns.Count

                    hoja.Cells.Item(filaTotal + 1, i) = dataset.Tables(tablaActual).Columns(i - 1).ToString()

                Next

                filaTotal += 1

                Dim inicioFormato As Integer = filaTotal

                For fila As Integer = 0 To dataset.Tables(tablaActual).Rows.Count - 1
                    If Not dataset.Tables(tablaActual).Rows(fila).RowState = DataRowState.Deleted Then
                        For columna As Integer = 0 To dataset.Tables(tablaActual).Columns.Count - 1

                            hoja.Cells.Item(filaTotal + 1, columna + 1) = dataset.Tables(tablaActual).Rows(fila).Item(columna).ToString()

                        Next

                        filaTotal += 1

                    End If
                Next

                If tablaActual = 0 Then

                    hoja.Range("A" & inicioFormato.ToString(), "BF" & filaTotal.ToString()).AutoFormat(11, Alignment:=False)

                ElseIf tablaActual = 1 Then

                    hoja.Range("A" & inicioFormato.ToString(), "BF" & filaTotal.ToString()).AutoFormat(11, Alignment:=False)

                Else

                    hoja.Range("A" & inicioFormato.ToString(), "D" & filaTotal.ToString()).AutoFormat(11, Alignment:=False)

                End If

                hoja.Cells.Item(filaTotal + 1, 1) = ""
                filaTotal += 1
                Dim borders As Microsoft.Office.Interop.Excel.Borders = hoja.Range("A" & inicioFormato.ToString(), "BF" & filaTotal.ToString()).Borders
                'Set the hair lines style.
                borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                borders.Weight = 2.0R

            Next

            App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()

        End If
    End Sub

    Public Shared Sub datasetToExcelUtilidad(ByVal dataset As DataSet)

        If dataset.Tables.Count > 0 Then
            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add

            Dim filaTotal As Integer = 0

            For tablaActual As Integer = 0 To dataset.Tables.Count - 1

                For i As Integer = 1 To dataset.Tables(tablaActual).Columns.Count
                    hoja.Cells.Item(filaTotal + 1, i) = dataset.Tables(tablaActual).Columns(i - 1).ToString()
                Next
                filaTotal += 1

                Dim inicioFormato As Integer = filaTotal
                For fila As Integer = 0 To dataset.Tables(tablaActual).Rows.Count - 1
                    If Not dataset.Tables(tablaActual).Rows(fila).RowState = DataRowState.Deleted Then
                        For columna As Integer = 0 To dataset.Tables(tablaActual).Columns.Count - 1
                            hoja.Cells.Item(filaTotal + 1, columna + 1) = dataset.Tables(tablaActual).Rows(fila).Item(columna).ToString()
                        Next
                        filaTotal += 1
                    End If
                Next

                hoja.Cells.Item(filaTotal + 1, 1) = ""
                filaTotal += 1

            Next
            App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing

            GC.Collect()
        End If

    End Sub

    Public Shared Sub gridToExcel(ByVal datos As System.Data.DataTable, ByVal viaje As String)

        If datos.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim columnas As Integer = datos.Columns.Count
            Dim filas As Integer = datos.Rows.Count
            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()

            For fila As Integer = 0 To filas - 1
                For columna As Integer = 0 To columnas - 1

                    hoja.Cells.Item(fila + 2, columna + 1) = datos.Rows(fila).Item(columna).ToString()

                Next
            Next

            hoja.Rows.Item(1).Font.Bold = 1
            hoja.Rows.Item(1).HorizontalAlignment = 3
            hoja.Columns.AutoFit()
            hoja.Rows.AutoFit()

            libro.SaveAs( _
                        "I:\Usuarios\Diesel\Coordenadas de Viaje\" & viaje, _
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, _
                        Type.Missing, _
                        Type.Missing, _
                        False, _
                        False, _
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, _
                        Type.Missing, _
                        Type.Missing, _
                        Type.Missing, _
                        Type.Missing, _
                        Type.Missing)
            libro.Close()
            'App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()

        End If

    End Sub

    Public Shared Sub gridToExcel(ByVal grid As DataGridView)

        If grid.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()

            Dim columnas As Integer = grid.ColumnCount
            Dim filas As Integer = grid.RowCount

            For i As Integer = 1 To columnas

                'hoja.Cells.Item(1, i) = grid.Columns(i - 1).Name.ToString()
                hoja.Cells.Item(1, i) = grid.Columns(i - 1).HeaderText

            Next

            For fila As Integer = 0 To filas - 1
                For columna As Integer = 0 To columnas - 1

                    hoja.Cells.Item(fila + 2, columna + 1) = grid.Rows(fila).Cells(columna).Value

                Next
            Next

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

    Public Shared Sub twoGridToExcel(ByVal grid As DataGridView, ByVal grid2 As DataGridView)
        If grid.Rows.Count > 0 Then
            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()

            Dim columnas As Integer = grid.ColumnCount
            Dim filas As Integer = grid.RowCount

            For i As Integer = 1 To columnas
                hoja.Cells.Item(1, i) = grid.Columns(i - 1).Name.ToString()
            Next

            Dim j2 As Integer = 1
            For j As Integer = columnas + 1 To (columnas + grid2.ColumnCount)
                hoja.Cells.Item(1, j) = grid2.Columns(j2 - 1).Name.ToString()
                j2 += 1
            Next

            For fila As Integer = 0 To filas - 1
                For columna As Integer = 0 To columnas - 1
                    hoja.Cells.Item(fila + 2, columna + 1) = grid.Rows(fila).Cells(columna).Value
                Next
            Next

            j2 = 0
            For fila As Integer = 0 To grid2.RowCount - 1
                For columna As Integer = (columnas + 1) To (columnas + (grid2.ColumnCount))
                    hoja.Cells.Item(fila + 2, columna) = grid2.Rows(fila).Cells(j2).Value
                    j2 += 1
                    If (j2 >= grid2.ColumnCount) Then
                        j2 = 0
                    End If
                Next
            Next

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

    Public Shared Sub gridDetalleLiquidacion(ByVal dataset As DataSet, ByVal viaje As Integer, ByVal unidad As String, ByVal ruta As String, ByVal maniobras As Double, ByVal cliente As String)
        If dataset.Tables().Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim formatoContabilidad As String = "$###,##0.00"

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()
            Dim numeroCartasPorte As Integer = 0
            Dim cartasPorte As String = ""

            If dataset.Tables(1).Rows.Count > 0 Then
                For Each row As DataRow In dataset.Tables(1).Rows()
                    cartasPorte += " " & row.Item("NUM_GUIA").ToString().Trim()
                    numeroCartasPorte += 1
                Next
            End If

            Dim celda As Range = hoja.Range("A1", Type.Missing)
            celda.Value = cartasPorte

            celda = hoja.Range("B1", Type.Missing)
            celda.Value = "RUTA"

            celda = hoja.Range("C1", Type.Missing)
            celda.Value = ruta

            celda = hoja.Range("D1", Type.Missing)
            celda.Value = "VIAJE: " & viaje.ToString()

            celda = hoja.Range("E1", Type.Missing)
            celda.Value = "Unidad"

            celda = hoja.Range("F1", Type.Missing)
            celda.Value = unidad

            celda = hoja.Range("G1", Type.Missing)
            celda.Value = cliente

            celda = hoja.Range("A2", Type.Missing)
            celda.Value = "CONCEPTO"

            celda = hoja.Range("B2", Type.Missing)
            celda.Value = "CANTIDAD"

            celda = hoja.Range("C2", Type.Missing)
            celda.Value = "SUBTOTAL"

            celda = hoja.Range("D2", Type.Missing)
            celda.Value = "IVA"

            celda = hoja.Range("E2", Type.Missing)
            celda.Value = "TOTAL"

            Dim contador As Integer = 0

            contador = 2
            If dataset.Tables(2).Rows.Count > 0 Then
                For Each row As DataRow In dataset.Tables(2).Rows()

                    celda = hoja.Range(("F" & contador.ToString()), Type.Missing)
                    celda.Value = row.Item("FECHA_ANTICIPO").ToString.Trim()
                    celda = hoja.Range(("G" & contador.ToString()), Type.Missing)
                    celda.Value = row.Item("MONTO_ANTICIPO").ToString.Trim()
                    contador += 1

                Next
            End If

            celda = hoja.Range("E5", Type.Missing)
            celda.Value = maniobras

            Dim contadorGastos As Integer = 6
            If dataset.Tables(4).Rows.Count > 0 Then
                For Each row As DataRow In dataset.Tables(4).Rows()
                    If row.Item("Monto_Gasto").ToString().Trim().Length > 0 Then
                        If Convert.ToDouble(row.Item("Monto_Gasto").ToString().Trim()) > 0.0 Then

                            celda = hoja.Range("A" & contadorGastos.ToString().Trim(), Type.Missing)
                            celda.Value = row.Item("Desc_Gasto").ToString().Trim().ToUpper()
                            celda = hoja.Range("E" & contadorGastos.ToString().Trim(), Type.Missing)
                            celda.Value = row.Item("Monto_Gasto").ToString().Trim()

                        End If
                    End If
                Next
            End If

            celda = hoja.Range("C22", Type.Missing)
            celda.Value = "CASETAS SIN IVA"
            celda.Font.Bold = True
            celda.Font.Size = 14
            contador = 23
            Dim indiceConIva As Integer = 0
            Dim casetasSinImpuestos As Double = 0

            If dataset.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dataset.Tables(0).Rows
                    If row.Item("IMPUESTO").ToString.Trim().Contains("asignar") Then

                        celda = hoja.Range(("C" & contador.ToString()), Type.Missing)
                        celda.Value = row.Item("NOMBRE_CASETA").ToString.Trim()

                        celda = hoja.Range(("D" & contador.ToString()), Type.Missing)
                        celda.Value = row.Item("TARIFA").ToString.Trim()

                        celda = hoja.Range(("E" & contador.ToString()), Type.Missing)
                        celda.Value = row.Item("IAVE").ToString.Trim()

                        casetasSinImpuestos += row.Item("TARIFA").ToString().Trim()

                        contador += 1

                    End If
                Next

                setFormat("C" & "23", "E" & contador.ToString(), hoja)

                Dim casetasConImpuestos As Double = 0
                celda = hoja.Range("C" & contador + 1, Type.Missing)
                hoja.Range("C" & contador + 1, Type.Missing).Font.Bold = True
                celda.Value = "CASETAS CON IVA"
                celda.Font.Bold = True
                celda.Font.Size = 14
                contador += 2
                indiceConIva = contador

                For Each row As DataRow In dataset.Tables(0).Rows
                    If row.Item("IMPUESTO").ToString.Trim().Contains("iva") Then

                        celda = hoja.Range(("C" & contador.ToString()), Type.Missing)
                        celda.Value = row.Item("NOMBRE_CASETA").ToString.Trim()

                        celda = hoja.Range(("D" & contador.ToString()), Type.Missing)
                        celda.Value = row.Item("TARIFA").ToString.Trim()

                        celda = hoja.Range(("E" & contador.ToString()), Type.Missing)
                        celda.Value = row.Item("IAVE").ToString.Trim()

                        casetasConImpuestos += Convert.ToDouble(row.Item("TARIFA").ToString.Trim())
                        contador += 1

                    End If
                Next

                Dim montoCasetasIave As Double = 0

                For Each row As DataRow In dataset.Tables(0).Rows
                    If row.Item("IAVE").ToString() = "S" Then
                        montoCasetasIave += Convert.ToDouble(row.Item("TARIFA").ToString().Trim())
                    End If
                Next

                hoja.Range("A6").Value = "Casetas IAVE"
                hoja.Range("C6").Value = (montoCasetasIave / 1.16).ToString()
                hoja.Range("D6").Value = (montoCasetasIave - (montoCasetasIave / 1.16)).ToString()
                hoja.Range("E6").Value = (montoCasetasIave).ToString()


                setFormat("C" & indiceConIva.ToString(), "E" & contador.ToString(), hoja)

                celda = hoja.Range("G23", Type.Missing)
                celda.Value = casetasConImpuestos

                celda = hoja.Range("G24", Type.Missing)
                celda.Value = casetasSinImpuestos

                celda = hoja.Range("G25", Type.Missing)
                celda.Value = casetasSinImpuestos + casetasConImpuestos
                celda.NumberFormat = formatoContabilidad


                celda = hoja.Range("F26")
                celda.Value = "Monto Casetas IAVE"

                celda = hoja.Range("G26")
                celda.Value = montoCasetasIave
                celda.NumberFormat = formatoContabilidad

                celda = hoja.Range("F27")
                celda.Value = "Total Casetas"

                celda = hoja.Range("G27")
                celda.Value = (casetasSinImpuestos + casetasConImpuestos) - montoCasetasIave

                celda = hoja.Range("C13", Type.Missing)
                celda.Value = "TOTAL GASTOS"

                celda = hoja.Range("C14", Type.Missing)
                celda.Value = "ANTICIPOS"

                celda = hoja.Range("C15", Type.Missing)
                celda.Value = "DIFERENCIA"

                celda = hoja.Range("C17", Type.Missing)
                celda.Value = "TOTAL ANTICIPOS"

                celda = hoja.Range("C18", Type.Missing)
                celda.Value = "GASTOS COMPROBADOS"

                celda = hoja.Range("C19", Type.Missing)
                celda.Value = "PENDIENTES POR COMPRABAR"

                celda = hoja.Range("F23", Type.Missing)
                celda.Value = "TOTAL CASETAS CON IVA"

                celda = hoja.Range("F24", Type.Missing)
                celda.Value = "TOTAL CASETAS SIN IVA"

                celda = hoja.Range("F25", Type.Missing)
                celda.Value = "TOTAL CASETAS COMPROBADAS"

                celda = hoja.Range("G11", Type.Missing)
                celda.Value = App.WorksheetFunction.Sum(hoja.Range("G2", "G10"))

                Dim totalAnticipos As Double = Convert.ToDouble(celda.Value)

                celda = hoja.Range("A3", Type.Missing)
                celda.Value = "CASETAS CON IVA"

                celda = hoja.Range("E3", Type.Missing)
                celda.Value = casetasConImpuestos

                Dim valorSinIva As Double = 0

                celda = hoja.Range("C3", Type.Missing)
                celda.Value = casetasConImpuestos / 1.16
                valorSinIva = celda.Value

                celda = hoja.Range("D3", Type.Missing)
                celda.Value = casetasConImpuestos - valorSinIva

                celda = hoja.Range("A4", Type.Missing)
                celda.Value = "CASETAS SIN IVA"

                celda = hoja.Range("E4", Type.Missing)
                celda.Value = casetasSinImpuestos

                celda = hoja.Range("A5", Type.Missing)
                celda.Value = "MANIOBRAS"

                celda = hoja.Range("E13", Type.Missing)
                celda.Value = App.WorksheetFunction.Sum(hoja.Range("E3", "E5"))

                celda = hoja.Range("E13")
                celda.Value = (Convert.ToDouble(celda.Value) - montoCasetasIave).ToString()

                Dim anticipo As Double = 0
                celda = hoja.Range("E14", Type.Missing)
                celda.Value = hoja.Range("G11", Type.Missing).Value
                anticipo = celda.Value


                celda = hoja.Range("E15", Type.Missing)
                celda.Value = (Convert.ToDouble(anticipo - hoja.Range("E13", Type.Missing).Value))
                celda.NumberFormat = formatoContabilidad

                celda = hoja.Range("E17", Type.Missing)
                celda.Value = hoja.Range("E14", Type.Missing).Value

                celda = hoja.Range("E18", Type.Missing)
                celda.Value = hoja.Range("E13", Type.Missing).Value

                celda = hoja.Range("E19", Type.Missing)
                celda.Value = hoja.Range("E15", Type.Missing).Value
                celda.NumberFormat = formatoContabilidad

                setFormat("F23", "G27", hoja)
                setFormat("C13", "E15", hoja)
                setFormat("C17", "E19", hoja)

                hoja.Range("A1", "G1").Interior.Color = ColorTranslator.ToOle(Color.Yellow)
                hoja.Range("A1", "G1").Font.Bold = True
                hoja.Range("A2", "G2").Font.Bold = True
                hoja.Range("A3", "A100").Font.Bold = True
                hoja.Range("C13", "E22").Font.Bold = True
                hoja.Range("H23", "I25").Font.Bold = True
                hoja.Range("C15", "E15").Font.Bold = True
                hoja.Range("C15", "E15").Font.Size = 14
                hoja.Range("C19", "E19").Font.Bold = True
                hoja.Range("C19", "E19").Font.Size = 14
                hoja.Range("F25", "G25").Font.Bold = True
                hoja.Range("F25", "G25").Font.Size = 14
                celda = hoja.Range("F11", Type.Missing)
                celda.Value = "ANTICIPOS"
                celda.Font.Bold = True

                celda = hoja.Range("G11", Type.Missing)
                celda.Font.Bold = True
                celda.NumberFormat = formatoContabilidad

                hoja.Range("F11", "G11").Font.Size = 14

                Dim a As Range = hoja.Range("A1", "Z100")
                a.Select()
                a.Columns.AutoFit()

            End If

            App.Application.Visible = True

            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()
        End If
    End Sub

    Public Shared Sub setFormat(ByVal celda1 As String, ByVal celda2 As String, ByVal hoja As Microsoft.Office.Interop.Excel.Worksheet)

        Dim formato As Range = hoja.Range(celda1, celda2)
        formato.Select()
        formato.Columns.AutoFit()
        formato.AutoFormat(11, Alignment:=False)

    End Sub

    Public Shared Sub twoDataSetToExcel(ByVal dS1 As DataSet, ByVal dS2 As DataSet)

        If dS1.Tables(0).Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim columnas As Integer = dS1.Tables(0).Columns.Count
            Dim filas As Integer = dS1.Tables(0).Rows.Count

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()

            For i As Integer = 1 To columnas

                hoja.Cells.Item(1, i) = dS1.Tables(0).Columns(i - 1).ColumnName.ToString()

            Next

            Dim j2 As Integer = 1

            For fila As Integer = 0 To filas - 1
                For columna As Integer = 0 To columnas - 1

                    hoja.Cells.Item(fila + 2, columna + 1) = dS1.Tables(0).Rows(fila).Item(columna).ToString()

                Next

                j2 = fila + 2

            Next

            j2 += 1

            For fila As Integer = 0 To dS2.Tables(0).Rows.Count - 1
                For columna As Integer = 0 To dS2.Tables(0).Columns.Count - 1

                    hoja.Cells.Item(j2, columna + 1) = dS2.Tables(0).Rows(fila).Item(columna).ToString()

                Next

                j2 += 1

            Next

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

    Public Shared Sub dataTableToExcel(ByVal dataTable As Data.DataTable)

        Dim App As New Microsoft.Office.Interop.Excel.Application
        Dim libro As Microsoft.Office.Interop.Excel.Workbook
        Dim hoja As Microsoft.Office.Interop.Excel.Worksheet

        libro = App.Workbooks.Add
        hoja = libro.Worksheets.Add
        Dim filaTotal As Integer = 0

        For i As Integer = 1 To dataTable.Columns.Count

            hoja.Cells.Item(filaTotal + 1, i) = dataTable.Columns(i - 1).ToString()

        Next

        filaTotal += 1
        Dim inicioFormato As Integer = filaTotal

        For fila As Integer = 1 To dataTable.Rows.Count - 1
            For columna As Integer = 0 To dataTable.Columns.Count - 1

                hoja.Cells.Item(filaTotal + 1, columna + 1) = dataTable.Rows(fila).Item(columna).ToString()

            Next

            filaTotal += 1

        Next

        hoja.Rows.Item(1).Font.Bold = 1
        hoja.Rows.Item(1).HorizontalAlignment = 3
        hoja.Columns.AutoFit()
        App.Application.Visible = True
        hoja = Nothing
        libro = Nothing
        App = Nothing
        GC.Collect()

    End Sub

    Public Shared Function excelToDataTable(ByVal ruta As String, ByVal nombreHoja As String, ByVal ordenar As String) As System.Data.DataTable

        Dim filePath As String = ruta
        Dim extension As String = Path.GetExtension(filePath)
        'Dim header As String = IIf(rbHeaderYes.Checked, "YES", "NO")
        Dim conStr As String, sheetName As String
        Dim Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
        Dim Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
        conStr = String.Empty

        Select Case extension.ToLower()

            Case ".xls"

                'Excel 97-03
                conStr = String.Format(Excel03ConString, filePath, "YES")
                Exit Select

            Case ".xlsx"

                'Excel 07
                conStr = String.Format(Excel07ConString, filePath, "YES")
                Exit Select

        End Select

        'Get the name of the First Sheet.
        Using con As New System.Data.OleDb.OleDbConnection(conStr)
            Using cmd As New OleDbCommand()

                cmd.Connection = con
                con.Open()
                Dim dtExcelSchema As System.Data.DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                Dim ind As Int32 = 0

                For i As Integer = 0 To dtExcelSchema.Rows.Count - 1

                    If dtExcelSchema.Rows(i)("TABLE_NAME").ToString().Contains(nombreHoja) Then

                        ind = i
                        Exit For

                    End If
                Next

                sheetName = dtExcelSchema.Rows(ind)("TABLE_NAME").ToString()
                con.Close()

            End Using
        End Using

        'Read Data from the First Sheet.
        Using con As New System.Data.OleDb.OleDbConnection(conStr)
            Using cmd As New OleDbCommand()
                Using oda As New OleDbDataAdapter()

                    Dim dt As New System.Data.DataTable()

                    If Not String.IsNullOrEmpty(ordenar) Then

                        cmd.CommandText = (Convert.ToString("SELECT * FROM [") & sheetName) + "] ORDER BY [" & ordenar & "]"

                    Else

                        cmd.CommandText = (Convert.ToString("SELECT * FROM [") & sheetName) + "]"

                    End If

                    cmd.Connection = con
                    con.Open()
                    oda.SelectCommand = cmd
                    oda.Fill(dt)
                    con.Close()
                    con.Dispose()
                    GC.Collect()
                    Return dt

                End Using
            End Using
        End Using
    End Function

    Private Function excelToDataTable(ByVal ruta As String) As System.Data.DataTable

        Dim filePath As String = ruta
        Dim extension As String = Path.GetExtension(filePath)
        'Dim header As String = IIf(rbHeaderYes.Checked, "YES", "NO")
        Dim conStr As String, sheetName As String
        Dim Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
        Dim Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
        conStr = String.Empty

        Select Case extension

            Case ".xls"

                'Excel 97-03
                conStr = String.Format(Excel03ConString, filePath, "YES")
                Exit Select

            Case ".xlsx"

                'Excel 07
                conStr = String.Format(Excel07ConString, filePath, "YES")
                Exit Select

        End Select

        'Get the name of the First Sheet.
        Using con As New System.Data.OleDb.OleDbConnection(conStr)
            Using cmd As New OleDbCommand()

                cmd.Connection = con
                con.Open()
                Dim dtExcelSchema As System.Data.DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                Dim ind As Int32 = 0

                For i As Integer = 0 To dtExcelSchema.Rows.Count - 1

                    If dtExcelSchema.Rows(i)("TABLE_NAME").ToString().Contains("prog") Then

                        ind = i
                        Exit For

                    End If
                Next

                sheetName = dtExcelSchema.Rows(ind)("TABLE_NAME").ToString()
                con.Close()

            End Using
        End Using

        'Read Data from the First Sheet.
        Using con As New System.Data.OleDb.OleDbConnection(conStr)
            Using cmd As New OleDbCommand()
                Using oda As New OleDbDataAdapter()

                    Dim dt As New System.Data.DataTable()
                    cmd.CommandText = (Convert.ToString("SELECT * FROM [") & sheetName) + "]"
                    cmd.Connection = con
                    con.Open()
                    oda.SelectCommand = cmd
                    oda.Fill(dt)
                    con.Close()
                    con.Dispose()
                    GC.Collect()
                    Return dt

                End Using
            End Using
        End Using
    End Function
End Class
