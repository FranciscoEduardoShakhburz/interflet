Public Class frmReporteReset
    Public parametro As Integer
    Private Sub frmReporteReset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UP_ReporteResetTableAdapter.Fill(Me.ProduccionInterfletdbReportes.UP_ReporteReset, parametro)
        Me.ReportViewer.RefreshReport()

        Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim deviceInfo As String
        Dim bytes As Byte()
        bytes = Me.ReportViewer.LocalReport.Render("Excel", deviceInfo, mimeType, encoding, extension, streamids, warnings)
        Dim fs As New IO.FileStream("c:\reporte.xls", IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        Process.Start("c:\reporte.xls")

    End Sub
End Class