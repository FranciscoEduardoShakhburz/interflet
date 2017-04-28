Imports System.Data
Imports System
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmcatDestinos

    Dim i As Integer = 0
    Dim MyDataGridViewPrinter As DataGridViewPrinter

    Private Sub frmcatDestinos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Trafico_plazaTableAdapter1.Fill(Me.ProduccionInterfletdbDataSet21.trafico_plaza)

    End Sub

    Private Sub cmbOrigen_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigen.Leave

        Try
            'Me.DataGridView1.DataSource = Nothing
            'Me.DataGridView1.Rows.Clear()
            Me.Cat_DestinoTableAdapter.FillBy(Me.ProdInter_DS_CatDestino.Cat_Destino, CType(Me.cmbOrigen.SelectedValue, Integer))
            'Me.BindingSource1.DataSource = ProdInter_DS_CatDestino
            'Me.BindingSource1.DataMember = "Cat_Destino"
            'Me.DataGridView1.DataSource = Me.BindingSource1
            'Me.DataGridView1.Refresh()
        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click

        Me.Cat_DestinoTableAdapter.Update(Me.ProdInter_DS_CatDestino.Cat_Destino)

    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click

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

        PrintDocument1.DocumentName = "Catalogo de Destinos"
        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins.Bottom = 40
        PrintDocument1.DefaultPageSettings.Margins.Right = 40
        PrintDocument1.DefaultPageSettings.Margins.Left = 40
        PrintDocument1.DefaultPageSettings.Margins.Top = 40

        If MessageBox.Show("¿Desea que el reporte se muestre centrado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridView1, PrintDocument1, True, True, "Catalogo de Destinos", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, False)

        Else

            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridView1, PrintDocument1, False, True, "Catalogo de Destinos", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, False)
            Return True

        End If
    End Function

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)

        If (more = True) Then

            e.HasMorePages = True

        End If
    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Dim aux As Int32
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
            aux = 0

            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                If DataGridView1.Columns(j).Visible = True Then

                    dr1(aux) = DataGridView1.Rows(i).Cells(j).Value
                    aux = aux + 1

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
        excel.Visible = True

    End Sub
End Class