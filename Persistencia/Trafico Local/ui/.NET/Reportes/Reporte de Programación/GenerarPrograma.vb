Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Drawing.Color
Imports System.Collections.Generic

Public Class GenerarPrograma

    Private rw As DataGridViewRow
    Private dragBoxFromMouseDown As Rectangle
    Private rowIndexFromMouseDown As Integer
    Private rowIndexOfItemUnderMouseToDrop As Integer
    Private infoAgExterna As List(Of String)

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click

        Cursor.Current = Cursors.AppStarting
        Dim archivo, ruta As String
        Dim ref As String
        Dim oFD As New OpenFileDialog
        Dim dt As DataTable

        archivo = ""

        Try
            With oFD

                .Filter = "Ficheros Excel (*.xlsx)|*.xlsx|(*.xls)|*.xls|Todos (*.*)|*.*"
                .FileName = ""

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    ' El nombre del fichero
                    archivo = .FileName
                    ruta = System.IO.Path.GetFullPath(.FileName)
                    dt = Me.excelToDataTable(ruta)

                    'For Each col As DataColumn In dt.Columns

                    '    Me.gridProgInicial.Columns.Add(col.ColumnName, col.Caption)

                    'Next

                    For Each fila As DataRow In dt.Rows

                        Me.gridProgInicial.Rows.Add()

                        For column As Int16 = 0 To dt.Columns.Count - 1

                            Me.gridProgInicial.Rows(Me.gridProgInicial.Rows.Count - 1).Cells(column).Value = fila.Item(column)

                        Next


                        'If fila.Item(15) IsNot Nothing AndAlso fila.Item(15) IsNot vbNull Then
                        If Not String.IsNullOrEmpty(fila.Item(15).ToString()) Then
                            If DateDiff(DateInterval.Day, Now, Convert.ToDateTime(fila.Item(15).ToString())) <= 4 Then

                                Me.gridProgInicial.Rows(Me.gridProgInicial.Rows.Count - 1).DefaultCellStyle.BackColor = Red

                            End If
                        End If
                    Next

                    For Each columna As DataGridViewColumn In Me.gridProgInicial.Columns

                        Me.gridForaneos.Columns.Add(columna.Clone())

                    Next

                    For Each columna As DataGridViewColumn In Me.gridProgInicial.Columns

                        Me.gridLocales.Columns.Add(columna.Clone())

                    Next

                    For Each columna As DataGridViewColumn In Me.gridProgInicial.Columns

                        Me.gridTraslados.Columns.Add(columna.Clone())

                    Next

                    For Each columna As DataGridViewColumn In Me.gridProgInicial.Columns

                        Me.gridPlanta.Columns.Add(columna.Clone())

                    Next

                    'Me.btnSugerir.Enabled = True

                Else

                    Return

                End If
            End With
        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("El archivo no se cargó debido al siguiente problema: " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Function excelToDataTable(ByVal ruta As String) As DataTable

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
        Using con As New OleDbConnection(conStr)
            Using cmd As New OleDbCommand()

                cmd.Connection = con
                con.Open()
                Dim dtExcelSchema As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
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
        Using con As New OleDbConnection(conStr)
            Using cmd As New OleDbCommand()
                Using oda As New OleDbDataAdapter()

                    Dim dt As New DataTable()
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

    Private Sub MoverAlProgramaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAForaneosToolStripMenuItem.Click

        Me.moverCargas(Me.gridProgInicial, Me.gridForaneos)

    End Sub

    Private Sub MoverAlProgramaInicialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAlProgramaInicialToolStripMenuItem.Click

        Me.moverCargas(Me.gridForaneos, Me.gridProgInicial)

    End Sub

    Private Sub GenerarPrograma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.btnAgregarCarga.Enabled = False
        'Me.btnAceptar.Enabled = False
        'Me.btnExportar.Enabled = False

    End Sub

    Private Sub btnSugerir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCarga.Click

        Cursor.Current = Cursors.WaitCursor
        Dim ingresar As IngresarCarga = New IngresarCarga(Me)
        ingresar.ShowDialog()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim App As New Microsoft.Office.Interop.Excel.Application
        Dim libro As Microsoft.Office.Interop.Excel.Workbook
        Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim columnas As Integer = 44
        Dim filas As Integer = (Me.gridForaneos.Rows.Count + Me.gridLocales.Rows.Count + Me.gridPlanta.Rows.Count + Me.gridTraslados.Rows.Count)
        Dim fila As Int16 = 4

        libro = App.Workbooks.Add
        hoja = libro.Worksheets.Add()
        hoja.Cells.Item(3, 1) = "FORÁNEOS"
        hoja.Cells.Item(4, 1) = "EJ. CUENTA"
        hoja.Cells.Item(4, 2) = "NAVIERA"
        hoja.Cells.Item(4, 3) = "TIPO"
        hoja.Cells.Item(4, 4) = "TIPO DE PROGRAMACION"
        hoja.Cells.Item(4, 5) = "TERMINAL"
        hoja.Cells.Item(4, 6) = "REFERENCIA"
        hoja.Cells.Item(4, 7) = "CLIENTE"
        hoja.Cells.Item(4, 8) = "TIPO"
        hoja.Cells.Item(4, 9) = "CONTENEDOR"
        hoja.Cells.Item(4, 10) = "PESO"
        hoja.Cells.Item(4, 11) = "VIAJA DE DIA"
        hoja.Cells.Item(4, 12) = "DESC."
        hoja.Cells.Item(4, 13) = "TIPO"
        hoja.Cells.Item(4, 14) = "ENTREGA2"
        hoja.Cells.Item(4, 15) = "DESTINO"
        hoja.Cells.Item(4, 16) = "DEMORA"
        hoja.Cells.Item(4, 17) = "ALMACENAJE"
        hoja.Cells.Item(4, 18) = "OBSERVACIONES"
        hoja.Cells.Item(4, 19) = "PTA"
        hoja.Cells.Item(4, 20) = "SOL."
        hoja.Cells.Item(4, 21) = "T TR"
        hoja.Cells.Item(4, 22) = "T REEX"
        hoja.Cells.Item(4, 23) = "TR"
        hoja.Cells.Item(4, 24) = "REEX"
        hoja.Cells.Item(4, 25) = "PTA"
        hoja.Cells.Item(4, 26) = "TR-R"
        hoja.Cells.Item(4, 27) = "REEX-R"
        hoja.Cells.Item(4, 28) = "PTA-R"
        hoja.Cells.Item(4, 29) = "VACIO"
        hoja.Cells.Item(4, 30) = "CERRADO"
        hoja.Cells.Item(4, 31) = "PROCESO"
        hoja.Cells.Item(4, 32) = "FECHA DE SOLICITUD"
        hoja.Cells.Item(4, 33) = "HORA DE SOLICITUD"
        hoja.Cells.Item(4, 34) = "FECHA DE MODIFICACION"
        hoja.Cells.Item(4, 35) = "HORA DE MODIFICIACION"
        hoja.Cells.Item(4, 36) = "ESTADO"
        hoja.Cells.Item(4, 37) = "STATUS"
        hoja.Cells.Item(4, 38) = "CARGA SUELTA"
        hoja.Cells.Item(4, 39) = "Columna38"
        hoja.Cells.Item(4, 40) = "c_obstrafico2"
        hoja.Cells.Item(4, 41) = "c_obstrafico3"
        hoja.Cells.Item(4, 42) = "c_obstrafico4"
        hoja.Cells.Item(4, 43) = "c_obstrafico5"
        hoja.Cells.Item(4, 44) = "PEDIMENTO"
        fila += 1

        For Each carga As DataGridViewRow In Me.gridForaneos.Rows

            hoja.Cells.Item(fila, 1) = carga.Cells(18).Value.ToString()
            hoja.Cells.Item(fila, 2) = carga.Cells(0).Value.ToString()
            hoja.Cells.Item(fila, 3) = carga.Cells(1).Value.ToString()
            hoja.Cells.Item(fila, 4) = carga.Cells(2).Value.ToString()
            hoja.Cells.Item(fila, 5) = carga.Cells(3).Value.ToString()
            hoja.Cells.Item(fila, 6) = carga.Cells(4).Value.ToString()
            hoja.Cells.Item(fila, 7) = carga.Cells(5).Value.ToString()
            hoja.Cells.Item(fila, 8) = carga.Cells(6).Value.ToString()
            hoja.Cells.Item(fila, 9) = carga.Cells(7).Value.ToString()
            hoja.Cells.Item(fila, 10) = carga.Cells(8).Value.ToString()
            hoja.Cells.Item(fila, 11) = carga.Cells(9).Value.ToString()
            hoja.Cells.Item(fila, 12) = carga.Cells(10).Value.ToString()
            hoja.Cells.Item(fila, 13) = carga.Cells(11).Value.ToString()
            hoja.Cells.Item(fila, 14) = carga.Cells(13).Value.ToString()
            hoja.Cells.Item(fila, 15) = carga.Cells(14).Value.ToString()
            hoja.Cells.Item(fila, 16) = carga.Cells(15).Value.ToString()
            hoja.Cells.Item(fila, 17) = carga.Cells(16).Value.ToString()
            hoja.Cells.Item(fila, 18) = carga.Cells(17).Value.ToString()
            hoja.Cells.Item(fila, 19) = carga.Cells(26).Value.ToString()
            hoja.Cells.Item(fila, 20) = carga.Cells(21).Value.ToString()
            hoja.Cells.Item(fila, 21) = carga.Cells(22).Value.ToString()
            hoja.Cells.Item(fila, 22) = carga.Cells(23).Value.ToString()
            hoja.Cells.Item(fila, 23) = carga.Cells(24).Value.ToString()
            hoja.Cells.Item(fila, 24) = carga.Cells(25).Value.ToString()
            hoja.Cells.Item(fila, 25) = ""
            hoja.Cells.Item(fila, 26) = carga.Cells(27).Value.ToString()
            hoja.Cells.Item(fila, 27) = carga.Cells(28).Value.ToString()
            hoja.Cells.Item(fila, 28) = carga.Cells(29).Value.ToString()
            hoja.Cells.Item(fila, 29) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 30) = carga.Cells(30).Value.ToString()
            hoja.Cells.Item(fila, 31) = carga.Cells(31).Value.ToString()
            hoja.Cells.Item(fila, 32) = carga.Cells(21).Value.ToString()
            hoja.Cells.Item(fila, 33) = carga.Cells(35).Value.ToString()
            hoja.Cells.Item(fila, 34) = carga.Cells(34).Value.ToString()
            hoja.Cells.Item(fila, 35) = ""
            hoja.Cells.Item(fila, 36) = carga.Cells(37).Value.ToString()
            hoja.Cells.Item(fila, 37) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 38) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 41) = carga.Cells(40).Value.ToString()
            hoja.Cells.Item(fila, 44) = carga.Cells(45).Value.ToString()
            fila += 1

        Next

        fila += 1
        hoja.Cells.Item(fila, 1) = "LOCALES"
        fila += 1

        For Each carga As DataGridViewRow In Me.gridLocales.Rows

            hoja.Cells.Item(fila, 1) = carga.Cells(18).Value.ToString()
            hoja.Cells.Item(fila, 2) = carga.Cells(0).Value.ToString()
            hoja.Cells.Item(fila, 3) = carga.Cells(1).Value.ToString()
            hoja.Cells.Item(fila, 4) = carga.Cells(2).Value.ToString()
            hoja.Cells.Item(fila, 5) = carga.Cells(3).Value.ToString()
            hoja.Cells.Item(fila, 6) = carga.Cells(4).Value.ToString()
            hoja.Cells.Item(fila, 7) = carga.Cells(5).Value.ToString()
            hoja.Cells.Item(fila, 8) = carga.Cells(6).Value.ToString()
            hoja.Cells.Item(fila, 9) = carga.Cells(7).Value.ToString()
            hoja.Cells.Item(fila, 10) = carga.Cells(8).Value.ToString()
            hoja.Cells.Item(fila, 11) = carga.Cells(9).Value.ToString()
            hoja.Cells.Item(fila, 12) = carga.Cells(10).Value.ToString()
            hoja.Cells.Item(fila, 13) = carga.Cells(11).Value.ToString()
            hoja.Cells.Item(fila, 14) = carga.Cells(13).Value.ToString()
            hoja.Cells.Item(fila, 15) = carga.Cells(14).Value.ToString()
            hoja.Cells.Item(fila, 16) = carga.Cells(15).Value.ToString()
            hoja.Cells.Item(fila, 17) = carga.Cells(16).Value.ToString()
            hoja.Cells.Item(fila, 18) = carga.Cells(17).Value.ToString()
            hoja.Cells.Item(fila, 19) = carga.Cells(26).Value.ToString()
            hoja.Cells.Item(fila, 20) = carga.Cells(21).Value.ToString()
            hoja.Cells.Item(fila, 21) = carga.Cells(22).Value.ToString()
            hoja.Cells.Item(fila, 22) = carga.Cells(23).Value.ToString()
            hoja.Cells.Item(fila, 23) = carga.Cells(24).Value.ToString()
            hoja.Cells.Item(fila, 24) = carga.Cells(25).Value.ToString()
            hoja.Cells.Item(fila, 25) = ""
            hoja.Cells.Item(fila, 26) = carga.Cells(27).Value.ToString()
            hoja.Cells.Item(fila, 27) = carga.Cells(28).Value.ToString()
            hoja.Cells.Item(fila, 28) = carga.Cells(29).Value.ToString()
            hoja.Cells.Item(fila, 29) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 30) = carga.Cells(30).Value.ToString()
            hoja.Cells.Item(fila, 31) = carga.Cells(31).Value.ToString()
            hoja.Cells.Item(fila, 32) = carga.Cells(21).Value.ToString()
            hoja.Cells.Item(fila, 33) = carga.Cells(35).Value.ToString()
            hoja.Cells.Item(fila, 34) = carga.Cells(34).Value.ToString()
            hoja.Cells.Item(fila, 35) = ""
            hoja.Cells.Item(fila, 36) = carga.Cells(37).Value.ToString()
            hoja.Cells.Item(fila, 37) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 38) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 41) = carga.Cells(40).Value.ToString()
            hoja.Cells.Item(fila, 44) = carga.Cells(45).Value.ToString()
            fila += 1

        Next

        fila += 1
        hoja.Cells.Item(fila, 1) = "FECHA EN PLANTA"
        fila += 1

        For Each carga As DataGridViewRow In Me.gridPlanta.Rows

            hoja.Cells.Item(fila, 1) = carga.Cells(18).Value.ToString()
            hoja.Cells.Item(fila, 2) = carga.Cells(0).Value.ToString()
            hoja.Cells.Item(fila, 3) = carga.Cells(1).Value.ToString()
            hoja.Cells.Item(fila, 4) = carga.Cells(2).Value.ToString()
            hoja.Cells.Item(fila, 5) = carga.Cells(3).Value.ToString()
            hoja.Cells.Item(fila, 6) = carga.Cells(4).Value.ToString()
            hoja.Cells.Item(fila, 7) = carga.Cells(5).Value.ToString()
            hoja.Cells.Item(fila, 8) = carga.Cells(6).Value.ToString()
            hoja.Cells.Item(fila, 9) = carga.Cells(7).Value.ToString()
            hoja.Cells.Item(fila, 10) = carga.Cells(8).Value.ToString()
            hoja.Cells.Item(fila, 11) = carga.Cells(9).Value.ToString()
            hoja.Cells.Item(fila, 12) = carga.Cells(10).Value.ToString()
            hoja.Cells.Item(fila, 13) = carga.Cells(11).Value.ToString()
            hoja.Cells.Item(fila, 14) = carga.Cells(13).Value.ToString()
            hoja.Cells.Item(fila, 15) = carga.Cells(14).Value.ToString()
            hoja.Cells.Item(fila, 16) = carga.Cells(15).Value.ToString()
            hoja.Cells.Item(fila, 17) = carga.Cells(16).Value.ToString()
            hoja.Cells.Item(fila, 18) = carga.Cells(17).Value.ToString()
            hoja.Cells.Item(fila, 19) = carga.Cells(26).Value.ToString()
            hoja.Cells.Item(fila, 20) = carga.Cells(21).Value.ToString()
            hoja.Cells.Item(fila, 21) = carga.Cells(22).Value.ToString()
            hoja.Cells.Item(fila, 22) = carga.Cells(23).Value.ToString()
            hoja.Cells.Item(fila, 23) = carga.Cells(24).Value.ToString()
            hoja.Cells.Item(fila, 24) = carga.Cells(25).Value.ToString()
            hoja.Cells.Item(fila, 25) = ""
            hoja.Cells.Item(fila, 26) = carga.Cells(27).Value.ToString()
            hoja.Cells.Item(fila, 27) = carga.Cells(28).Value.ToString()
            hoja.Cells.Item(fila, 28) = carga.Cells(29).Value.ToString()
            hoja.Cells.Item(fila, 29) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 30) = carga.Cells(30).Value.ToString()
            hoja.Cells.Item(fila, 31) = carga.Cells(31).Value.ToString()
            hoja.Cells.Item(fila, 32) = carga.Cells(21).Value.ToString()
            hoja.Cells.Item(fila, 33) = carga.Cells(35).Value.ToString()
            hoja.Cells.Item(fila, 34) = carga.Cells(34).Value.ToString()
            hoja.Cells.Item(fila, 35) = ""
            hoja.Cells.Item(fila, 36) = carga.Cells(37).Value.ToString()
            hoja.Cells.Item(fila, 37) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 38) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 41) = carga.Cells(40).Value.ToString()
            hoja.Cells.Item(fila, 44) = carga.Cells(45).Value.ToString()
            fila += 1

        Next

        fila += 1
        hoja.Cells.Item(fila, 1) = "TRASLADOS"
        fila += 1

        For Each carga As DataGridViewRow In Me.gridTraslados.Rows

            hoja.Cells.Item(fila, 1) = carga.Cells(18).Value.ToString()
            hoja.Cells.Item(fila, 2) = carga.Cells(0).Value.ToString()
            hoja.Cells.Item(fila, 3) = carga.Cells(1).Value.ToString()
            hoja.Cells.Item(fila, 4) = carga.Cells(2).Value.ToString()
            hoja.Cells.Item(fila, 5) = carga.Cells(3).Value.ToString()
            hoja.Cells.Item(fila, 6) = carga.Cells(4).Value.ToString()
            hoja.Cells.Item(fila, 7) = carga.Cells(5).Value.ToString()
            hoja.Cells.Item(fila, 8) = carga.Cells(6).Value.ToString()
            hoja.Cells.Item(fila, 9) = carga.Cells(7).Value.ToString()
            hoja.Cells.Item(fila, 10) = carga.Cells(8).Value.ToString()
            hoja.Cells.Item(fila, 11) = carga.Cells(9).Value.ToString()
            hoja.Cells.Item(fila, 12) = carga.Cells(10).Value.ToString()
            hoja.Cells.Item(fila, 13) = carga.Cells(11).Value.ToString()
            hoja.Cells.Item(fila, 14) = carga.Cells(13).Value.ToString()
            hoja.Cells.Item(fila, 15) = carga.Cells(14).Value.ToString()
            hoja.Cells.Item(fila, 16) = carga.Cells(15).Value.ToString()
            hoja.Cells.Item(fila, 17) = carga.Cells(16).Value.ToString()
            hoja.Cells.Item(fila, 18) = carga.Cells(17).Value.ToString()
            hoja.Cells.Item(fila, 19) = carga.Cells(26).Value.ToString()
            hoja.Cells.Item(fila, 20) = carga.Cells(21).Value.ToString()
            hoja.Cells.Item(fila, 21) = carga.Cells(22).Value.ToString()
            hoja.Cells.Item(fila, 22) = carga.Cells(23).Value.ToString()
            hoja.Cells.Item(fila, 23) = carga.Cells(24).Value.ToString()
            hoja.Cells.Item(fila, 24) = carga.Cells(25).Value.ToString()
            hoja.Cells.Item(fila, 25) = ""
            hoja.Cells.Item(fila, 26) = carga.Cells(27).Value.ToString()
            hoja.Cells.Item(fila, 27) = carga.Cells(28).Value.ToString()
            hoja.Cells.Item(fila, 28) = carga.Cells(29).Value.ToString()
            hoja.Cells.Item(fila, 29) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 30) = carga.Cells(30).Value.ToString()
            hoja.Cells.Item(fila, 31) = carga.Cells(31).Value.ToString()
            hoja.Cells.Item(fila, 32) = carga.Cells(21).Value.ToString()
            hoja.Cells.Item(fila, 33) = carga.Cells(35).Value.ToString()
            hoja.Cells.Item(fila, 34) = carga.Cells(34).Value.ToString()
            hoja.Cells.Item(fila, 35) = ""
            hoja.Cells.Item(fila, 36) = carga.Cells(37).Value.ToString()
            hoja.Cells.Item(fila, 37) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 38) = carga.Cells(38).Value.ToString()
            hoja.Cells.Item(fila, 41) = carga.Cells(40).Value.ToString()
            hoja.Cells.Item(fila, 44) = carga.Cells(45).Value.ToString()
            fila += 1

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

    Private Function pedimentoPagado(ByVal referencia As String, ByVal pedimento As String) As Boolean

        Dim squery As String
        Dim dset_saai As DataTable

        squery = "SELECT Fecpag01, Firmae01, Firban01 FROM ssdage01 WHERE Refcia01 = '" & referencia & "' AND Numped01 = '" & pedimento & "' AND (firmae01 != '' AND firmae01 != 'DENEGADO') UNION SELECT Fecpag01, Firmae01, Firban01 FROM ssdagi01.dbf WHERE Refcia01 = '" & referencia & "' AND Numped01 = '" & pedimento & "' AND (firmae01 != '' AND firmae01 != 'DENEGADO')"
        Dim dad As OleDbDataAdapter
        dad = New OleDbDataAdapter(squery, "Provider=vfpoledb.1;Data Source=z:\\reco\\saai\\dbfs;Mode=3;")

        dset_saai = New DataTable()
        dad.Fill(dset_saai)

        If dset_saai.Rows.Count > 0 Then
            If Not String.IsNullOrEmpty(dset_saai.Rows.Item(0).Item(0)) And Not String.IsNullOrEmpty(dset_saai.Rows.Item(0).Item(1)) And Not String.IsNullOrEmpty(dset_saai.Rows.Item(0).Item(2)) Then

                Return True

            Else

                Return False

            End If
        Else

            Return False

        End If
    End Function

    Private Sub MoverALocalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverALocalesToolStripMenuItem.Click

        Me.moverCargas(Me.gridProgInicial, Me.gridLocales)

    End Sub

    Private Sub MoverATrasladosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverATrasladosToolStripMenuItem.Click

            Me.moverCargas(Me.gridProgInicial, Me.gridTraslados)

    End Sub

    Private Sub MoverAPlantaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAPlantaToolStripMenuItem.Click

        Me.moverCargas(Me.gridProgInicial, Me.gridPlanta)

    End Sub

    Public Sub moverCargas(ByRef grid1 As DataGridView, ByRef grid2 As DataGridView)

        For Each Item As DataGridViewRow In grid1.SelectedRows

            grid2.Rows.Add()

            For columna As Int16 = 0 To Item.Cells.Count - 1

                grid2.Rows(grid2.Rows.Count - 1).Cells(columna).Value = Item.Cells(columna).Value

            Next

            grid2.Rows(grid2.Rows.Count - 1).DefaultCellStyle = Item.DefaultCellStyle
            grid1.Rows.Remove(Item)

        Next
    End Sub

    Private Sub MoverALocalesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverALocalesToolStripMenuItem1.Click

        Me.moverCargas(Me.gridForaneos, Me.gridLocales)

    End Sub

    Private Sub MoverATrasladosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverATrasladosToolStripMenuItem1.Click

        Me.moverCargas(Me.gridForaneos, Me.gridTraslados)

    End Sub

    Private Sub MoverAAPlantaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAAPlantaToolStripMenuItem.Click

        Me.moverCargas(Me.gridForaneos, Me.gridPlanta)

    End Sub

    Private Sub MoverALocalesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverALocalesToolStripMenuItem2.Click

        Me.moverCargas(Me.gridLocales, Me.gridForaneos)

    End Sub

    Private Sub MoverATrasladosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverATrasladosToolStripMenuItem3.Click

        Me.moverCargas(Me.gridLocales, Me.gridTraslados)

    End Sub

    Private Sub MoverAPlantaToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAPlantaToolStripMenuItem4.Click

        Me.moverCargas(Me.gridLocales, Me.gridPlanta)

    End Sub

    Private Sub MoverAlProgramaInicialToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAlProgramaInicialToolStripMenuItem1.Click

        Me.moverCargas(Me.gridLocales, Me.gridProgInicial)

    End Sub

    Private Sub MoverAlProgramaIniToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAlProgramaIniToolStripMenuItem1.Click

        Me.moverCargas(Me.gridTraslados, Me.gridProgInicial)

    End Sub

    Private Sub MoverAForToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAForToolStripMenuItem2.Click

        Me.moverCargas(Me.gridTraslados, Me.gridForaneos)

    End Sub

    Private Sub MoverALocToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverALocToolStripMenuItem3.Click

        Me.moverCargas(Me.gridTraslados, Me.gridLocales)

    End Sub

    Private Sub MoverAPlaToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAPlaToolStripMenuItem4.Click

        Me.moverCargas(Me.gridTraslados, Me.gridPlanta)

    End Sub

    Private Sub MoverProgToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.moverCargas(Me.gridPlanta, Me.gridProgInicial)

    End Sub

    Private Sub MoverForToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverForToolStripMenuItem2.Click

        Me.moverCargas(Me.gridPlanta, Me.gridForaneos)

    End Sub

    Private Sub MoverLocToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverLocToolStripMenuItem3.Click

        Me.moverCargas(Me.gridPlanta, Me.gridLocales)

    End Sub

    Private Sub MoverTrasToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverTrasToolStripMenuItem4.Click

        Me.moverCargas(Me.gridPlanta, Me.gridTraslados)

    End Sub

    Private Sub colorearCargasEnGrid(ByRef grid As DataGridView, ByVal color As Int16)

        For Each carga As DataGridViewRow In grid.SelectedRows

            If color = 1 Then

                carga.DefaultCellStyle.BackColor = Red

            ElseIf color = 2 Then

                carga.DefaultCellStyle.BackColor = Yellow

            ElseIf color = 3 Then

                carga.DefaultCellStyle.BackColor = DodgerBlue

            ElseIf color = 4 Then

                carga.DefaultCellStyle.BackColor = GreenYellow

            ElseIf color = 5 Then

                carga.DefaultCellStyle.BackColor = Orange

            Else

                carga.DefaultCellStyle.BackColor = White

            End If
        Next
    End Sub

    Private Sub RojoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RojoToolStripMenuItem.Click

        Me.colorearCargasEnGrid(Me.gridForaneos, 1)
        Me.gridForaneos.Refresh()

    End Sub

    Private Sub AmarilloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmarilloToolStripMenuItem.Click

        Me.colorearCargasEnGrid(Me.gridForaneos, 2)
        Me.gridForaneos.Refresh()

    End Sub

    Private Sub AzulToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AzulToolStripMenuItem.Click

        Me.colorearCargasEnGrid(Me.gridForaneos, 3)
        Me.gridForaneos.Refresh()

    End Sub

    Private Sub VerdeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerdeToolStripMenuItem.Click

        Me.colorearCargasEnGrid(Me.gridForaneos, 4)
        Me.gridForaneos.Refresh()

    End Sub

    Private Sub NaranjaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NaranjaToolStripMenuItem.Click

        Me.colorearCargasEnGrid(Me.gridForaneos, 5)
        Me.gridForaneos.Refresh()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.insertarCargas(Me.gridForaneos, 1)
        Me.insertarCargas(Me.gridLocales, 2)
        Me.insertarCargas(Me.gridPlanta, 1)
        Me.insertarCargas(Me.gridTraslados, 3)
        Me.btnExportar_Click(sender, e)
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub insertarCargas(ByVal grid As DataGridView, ByVal tipoPro As Int16)

        Dim comando As SqlCommand
        Dim conexion As SqlConnection

        Try
            If grid.Rows.Count > 0 Then
                For Each carga As DataGridViewRow In grid.Rows

                    conexion = Connection.getInstance().getConnection()
                    comando = New SqlCommand("up_inserte_RProgramacion", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000
                    conexion.Open()

                    With comando.Parameters

                        .AddWithValue("@tipo_insert", 1)
                        .AddWithValue("@EJ_CTA", carga.Cells(18).Value.ToString())
                        .AddWithValue("@NAVIERA", carga.Cells(0).Value.ToString())
                        .AddWithValue("@TIPO_OPER", carga.Cells(1).Value.ToString())
                        .AddWithValue("@TIPO_PROGRAMACION", carga.Cells(2).Value.ToString())
                        .AddWithValue("@TERMINAL", carga.Cells(3).Value.ToString())
                        .AddWithValue("@REFERENCIA", carga.Cells(4).Value.ToString())
                        .AddWithValue("@CLIENTE", carga.Cells(5).Value.ToString())
                        .AddWithValue("@TIPO", carga.Cells(6).Value.ToString())
                        .AddWithValue("@CONTENEDOR", carga.Cells(7).Value.ToString())
                        .AddWithValue("@PESO", carga.Cells(8).Value.ToString())
                        .AddWithValue("@VIAJA_DIA", carga.Cells(9).Value.ToString())
                        .AddWithValue("@DESCRIP", carga.Cells(10).Value.ToString())
                        .AddWithValue("@MERCANCIA", carga.Cells(11).Value.ToString())
                        .AddWithValue("@ENTREGA2", carga.Cells(13).Value.ToString())
                        .AddWithValue("@DESTINO", carga.Cells(14).Value.ToString())
                        .AddWithValue("@DEMORA", CType(carga.Cells(15).Value.ToString(), Date).ToString("dd/MM/yyyy"))
                        .AddWithValue("@ALMACENAJE", CType(carga.Cells(16).Value.ToString(), Date).ToString("dd/MM/yyyy"))
                        .AddWithValue("@OBSERVACIONES", carga.Cells(17).Value.ToString())
                        .AddWithValue("@T_TR", carga.Cells(22).Value.ToString())
                        .AddWithValue("@T_REEX", carga.Cells(23).Value.ToString())
                        .AddWithValue("@PTA_R", carga.Cells(22).Value.ToString())
                        .AddWithValue("@VACIO", carga.Cells(38).Value.ToString())
                        .AddWithValue("@TIPO_PRO", tipoPro)
                        .AddWithValue("@OBSERVACION", "")
                        .AddWithValue("@PLANTA", carga.Cells(26).Value.ToString())

                    End With

                    comando.ExecuteNonQuery()
                    conexion.Close()

                Next
            End If
        Catch ex As Exception

            MessageBox.Show("No se pudo guardar el programa debido al siguiente error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub MoverAlProgramaInicialToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAlProgramaInicialToolStripMenuItem2.Click

        Me.moverCargas(Me.gridPlanta, Me.gridProgInicial)

    End Sub

    Private Sub gridProgInicial_SortCompare(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles gridProgInicial.SortCompare

        If e.Column.Equals(Me.gridProgInicial.Columns(15)) Or e.Column.Equals(Me.gridProgInicial.Columns(16)) or e.Column.Equals(Me.gridProgInicial.Columns(26)) Then

            e.Handled = True
            e.SortResult = compare(e.CellValue1, e.CellValue2)

        End If
    End Sub

    Private Function compare(ByVal s1 As Object, ByVal s2 As Object) As Integer

        Return -s1.ToString().CompareTo(s2.ToString())

    End Function

    ' list of hash codes of the selected rows
    Private Function GetSelectedRows() As List(Of Integer)

        Dim selR As New List(Of Integer)
        ' have to clear selected so the NEXT row 
        ' doesnt cause odd behavior
        For n As Integer = 0 To Me.gridProgInicial.Rows.Count - 1
            If Me.gridProgInicial.Rows(n).IsNewRow = False AndAlso Me.gridProgInicial.Rows(n).Selected Then

                selR.Add(Me.gridProgInicial.Rows(n).GetHashCode)
                Me.gridProgInicial.Rows(n).Selected = False

            End If
        Next

        Return selR

    End Function

    ' restore original selected rows
    Private Sub SetSelectedRows(ByVal selRows As List(Of Integer))

        For n As Integer = 0 To Me.gridProgInicial.Rows.Count - 1
            If Me.gridProgInicial.Rows(n).IsNewRow = False Then

                Me.gridProgInicial.Rows(n).Selected = selRows.Contains(Me.gridProgInicial.Rows(n).GetHashCode)
                ' reset Order col:
                Me.gridProgInicial.Rows(n).Cells(0).Value = n + 1

            End If
        Next
    End Sub

    Private Sub MoveRowsUp()

        ' short ref
        Dim rows As DataGridViewRowCollection = Me.gridProgInicial.Rows
        ' row index
        Dim thisRow As DataGridViewRow
        ' put selection back
        Dim selectedRows As List(Of Integer)
        ' max rows
        Dim LastRow As Int32 = IIf(Me.gridProgInicial.AllowUserToAddRows, rows.Count - 2, rows.Count - 1)
        selectedRows = GetSelectedRows()

        For n As Int32 = 0 To LastRow
            If rows(n).IsNewRow = False Then

                If (selectedRows.Contains(rows(n).GetHashCode)) AndAlso (n - 1 >= 0) AndAlso (selectedRows.Contains(rows(n - 1).GetHashCode) = False) Then

                    thisRow = rows(n)
                    rows.Remove(thisRow)
                    rows.Insert(n - 1, thisRow)

                End If
            End If
        Next

        SetSelectedRows(selectedRows)

    End Sub

    Private Sub MoveRowsDn()

        Dim rows As DataGridViewRowCollection = Me.gridProgInicial.Rows
        Dim thisRow As DataGridViewRow
        Dim selectedRows As New List(Of Integer)
        Dim LastRow As Int32 = IIf(Me.gridProgInicial.AllowUserToAddRows, rows.Count - 2, rows.Count - 1)

        selectedRows = GetSelectedRows()

        For n As Int32 = LastRow To 0 Step -1

            If rows(n).IsNewRow = False Then
                If (selectedRows.Contains(rows(n).GetHashCode)) AndAlso (n + 1 <= LastRow) AndAlso (selectedRows.Contains(rows(n + 1).GetHashCode) = False) Then

                    thisRow = rows(n)
                    rows.Remove(thisRow)
                    rows.Insert(n + 1, thisRow)

                End If
            End If
        Next

        SetSelectedRows(selectedRows)

    End Sub

    Private Sub btnMoverArribaGridProgIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoverArribaGridProgIni.Click

        Me.MoveRowsUp()

    End Sub

    Private Sub btnMoverAbajoGridProgIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoverAbajoGridProgIni.Click

        Me.MoveRowsDn()

    End Sub

    Public Sub fijarInfoAgenciaExt(ByRef info As List(Of String))

        Me.infoAgExterna = info
        Me.agregarCarga()

    End Sub

    Private Sub agregarCarga()

        Me.gridProgInicial.Rows.Add()
        Dim carga As DataGridViewRow = Me.gridProgInicial.Rows(Me.gridProgInicial.Rows.Count - 1)
        carga.Cells(0).Value = ""
        carga.Cells(1).Value = ""
        carga.Cells(2).Value = Me.infoAgExterna(0)
        carga.Cells(3).Value = Me.infoAgExterna(1)
        carga.Cells(4).Value = Me.infoAgExterna(2)
        carga.Cells(5).Value = Me.infoAgExterna(3)
        carga.Cells(6).Value = Me.infoAgExterna(4)
        carga.Cells(7).Value = Me.infoAgExterna(5)
        carga.Cells(8).Value = Me.infoAgExterna(6)
        carga.Cells(9).Value = Me.infoAgExterna(7)
        carga.Cells(10).Value = Me.infoAgExterna(8)
        carga.Cells(11).Value = Me.infoAgExterna(9)
        carga.Cells(12).Value = ""
        carga.Cells(13).Value = Me.infoAgExterna(10)
        carga.Cells(14).Value = Me.infoAgExterna(11)
        carga.Cells(15).Value = Me.infoAgExterna(12)
        carga.Cells(16).Value = Me.infoAgExterna(13)
        carga.Cells(26).Value = Me.infoAgExterna(14)
        carga.Cells(17).Value = Me.infoAgExterna(15)

        For index As Integer = 18 To 25

            carga.Cells(index).Value = ""

        Next

        For index As Integer = 26 To carga.Cells.Count - 1

            carga.Cells(index).Value = ""

        Next
    End Sub
End Class