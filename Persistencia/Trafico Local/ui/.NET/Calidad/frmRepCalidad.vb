Public Class frmRepCalidad

    Public parametro As Date
    Public parametro2 As Date
    Public area As Integer
    Public tipo As Integer

    Private Sub frmRepCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            PI_Calidad.EnforceConstraints = False
            Me.UP_Consulta_ReporteCalidad_v2TableAdapter.setTimeOut(5000)
            Me.UP_Consulta_ReporteCalidad_v2TableAdapter.Fill(Me.PI_Calidad.UP_Consulta_ReporteCalidad_v2, parametro, parametro2, area, tipo)
            Me.RepView1.RefreshReport()
            Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim extension As String = Nothing
            Dim deviceInfo As String
            Dim bytes As Byte()
            Dim fs As New IO.FileStream("c:\reporte.xls", IO.FileMode.Create)

            bytes = Me.RepView1.LocalReport.Render("Excel", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            Process.Start("c:\reporte.xls")

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try
    End Sub
End Class