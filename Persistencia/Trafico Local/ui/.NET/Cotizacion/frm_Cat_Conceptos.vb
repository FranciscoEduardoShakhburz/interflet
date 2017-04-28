Option Strict Off
Option Explicit On
Imports System.Data
Imports System
Imports System.Drawing
Imports System.Drawing.Printing

Friend Class frm_Cat_Conceptos
    Inherits System.Windows.Forms.Form

    Dim i As Integer = 0
    Dim MyDataGridViewPrinter As DataGridViewPrinter

    Private Sub frm_Cat_Conceptos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'ProduccionInterfletdbDataSet.Cat_Conceptos' Puede moverla o quitarla según sea necesario.
        Me.Cat_ConceptosTableAdapter.Fill(Me.ProduccionInterfletdbDataSet.Cat_Conceptos)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click

        Me.Cat_ConceptosTableAdapter.Update(Me.ProduccionInterfletdbDataSet.Cat_Conceptos)

    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click

        'PrintDocument1.Print()

        If SetupThePrinting() Then

            Dim MyPrintPreviewDialog As New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = PrintDocument1
            MyPrintPreviewDialog.ShowDialog()
            'PrintDocument1.Print()

        Else

            PrintDocument1.Print()

        End If
    End Sub

    Private Function SetupThePrinting() As Boolean

        Dim MyPrintDialog As New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.PrintToFile = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then

            Return False

        End If

        PrintDocument1.DocumentName = "Catalogo de Conceptos"
        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins.Bottom = 40
        PrintDocument1.DefaultPageSettings.Margins.Right = 40
        PrintDocument1.DefaultPageSettings.Margins.Left = 40
        PrintDocument1.DefaultPageSettings.Margins.Top = 40

        If MessageBox.Show("¿Desea que el reporte se muestre centrado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridView1, PrintDocument1, True, True, "Catalogo de Conceptos", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, False)

        Else

            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridView1, PrintDocument1, False, True, "Catalogo de Conceptos", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, False)
            Return True

        End If
    End Function

    ' Specify the output to print by handling the PrintPage event 
    ' and by using the Graphics included in the PrintPageEventArgs.
    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)

        If (more = True) Then

            e.HasMorePages = True

        End If

        ' La fuente que vamos a usar para imprimir.
        'Dim printFont As System.Drawing.Font = New Font("Arial", 10)
        'Dim topMargin As Double = e.MarginBounds.Top
        'Dim yPos As Double = 0
        'Dim linesPerPage As Double = 0
        'Dim count As Integer = 0
        'Dim texto As String = ""
        'Dim row As System.Windows.Forms.DataGridViewRow
        'Dim ps As New PaperSize("A4", 850, 1100)
        'e.PageSettings.Landscape = False
        'e.PageSettings.PaperSize = ps
        ' Calculamos el número de líneas que caben en cada página. 
        'linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)
        ' Recorremos las filas del DataGridView hasta que lleguemos
        ' a las líneas que nos caben en cada página o al final del grid. 
        'While count < linesPerPage And i < DataGridView1.Rows.Count - 1
        'row = DataGridView1.Rows(i)
        'texto = ""
        'For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
        'texto += vbTab + celda.Value.ToString()
        'Next
        ' Calculamos la posición en la que se escribe la línea 
        'yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        ' Escribimos la línea con el objeto Graphics 
        'e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        'count += 1
        'i += 1
        'End While
        ' Una vez fuera del bucle comprobamos si nos quedan más filas 
        ' por imprimir, si quedan saldrán en la siguente página 
        'If i < DataGridView1.Rows.Count - 1 Then
        ' e.HasMorePages = True
        ' Else
        ' si llegamos al final, se establece HasMorePages a 
        ' false para que se acabe la impresión 
        'e.HasMorePages = False
        ' Es necesario poner el contador a 0 porque, por ejemplo si se hace 
        ' una impresión desde PrintPreviewDialog, se vuelve disparar este 
        ' evento como si fuese la primera vez, y si i está con el valor de la 
        ' última fila del grid no se imprime nada 
        'i = 0
        'End If

    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click

        'verfying the datagridview having data or not
        If ((DataGridView1.Columns.Count = 0) Or (DataGridView1.Rows.Count = 0)) Then

            Exit Sub

        End If

        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            If DataGridView1.Columns(i).Visible = True Then

                dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)

            End If
        Next

        'add rows to the table
        Dim dr1 As DataRow

        For i As Integer = 0 To DataGridView1.RowCount - 1

            dr1 = dset.Tables(0).NewRow

            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                If DataGridView1.Columns(j).Visible = True Then

                    dr1(j) = DataGridView1.Rows(i).Cells(j).Value

                End If
            Next

            dset.Tables(0).Rows.Add(dr1)

        Next

        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        Dim strFileName As String = "c:\Cat_Conceptos.xls"
        Dim blnFileOpen As Boolean = False

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()
        
        For Each dc In dt.Columns

            colIndex = colIndex + 1
            excel.Cells(1, colIndex) = dc.ColumnName

        Next

        For Each dr In dt.Rows

            rowIndex = rowIndex + 1
            colIndex = 0

            For Each dc In dt.Columns

                colIndex = colIndex + 1
                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

            Next
        Next

        wSheet.Columns.AutoFit()
        
        'Try
        'Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
        'fileTemp.Close()
        'Catch ex As Exception
        'blnFileOpen = False
        'End Try

        'If System.IO.File.Exists(strFileName) Then
        'System.IO.File.Delete(strFileName)
        'End If

        'wBook.SaveAs(strFileName)
        'excel.Workbooks.Open(strFileName)
        excel.Visible = True

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class