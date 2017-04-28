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
            Me.Cat_DestinoTableAdapter.FillBy(Me.ProdInter_DS_CatDestino.Cat_Destino, CType(Me.cmbOrigen.SelectedValue, Integer))
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
        Excel.gridToExcel(Me.DataGridView1)
    End Sub

End Class