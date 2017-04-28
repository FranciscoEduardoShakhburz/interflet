Imports System.Data
Imports System
Imports System.Drawing
Imports System.Drawing.Printing



Public Class frmCatFactorAjuste

    Dim i As Integer = 0
    Dim MyDataGridViewPrinter As DataGridViewPrinter

    Private Sub frmCatFactorAjuste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cat_FactorAjusteTableAdapter.Fill(Me.PI_FactorAjuste.Cat_FactorAjuste)
    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Me.Cat_FactorAjusteTableAdapter.Update(Me.PI_FactorAjuste.Cat_FactorAjuste)
    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        If SetupThePrinting() Then
            Dim MyPrintPreviewDialog As New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = PrintDocument1
            MyPrintPreviewDialog.ShowDialog()
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
        PrintDocument1.DocumentName = "Catalogo de Factores de Ajuste"
        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins.Bottom = 40
        PrintDocument1.DefaultPageSettings.Margins.Right = 40
        PrintDocument1.DefaultPageSettings.Margins.Left = 40
        PrintDocument1.DefaultPageSettings.Margins.Top = 40
        If MessageBox.Show("¿Desea que el reporte se muestre centrado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MyDataGridViewPrinter = New DataGridViewPrinter(grdFactorAjuste, PrintDocument1, True, True, "Catalogo de Factores de Ajuste", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, False)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(grdFactorAjuste, PrintDocument1, False, True, "Catalogo de Factores de Ajuste", New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, False)
            Return True
        End If
    End Function

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        Excel.gridToExcel(Me.grdFactorAjuste)
    End Sub
End Class