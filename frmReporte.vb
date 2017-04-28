Public Class frmReporte
    Public parametro As Integer
    Private Sub frmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Donde: 

        'ProduccionInterfletdbReportes es el dataset que creamos anoche para los reportes

        'UP_PruebaReporte es un sp que se trae filas de la siguiente manera:
        '   SELECT 
        '       *
        '   FROM([ProduccionInterfletdb].[dbo].[compras_insumos])
        '   where id_concepto = @p1

        'UP_PruebaReporteTableAdapter es el table adapter generado al agregar el sp al data set


        'por lo tanto ya no le mandamos parametros al reporte mejor usamos el table adapter
        'para que llene el dataset y haga la chamba de los parametros
        'y asi el reporte ya solo recibe las filas resultantes :) 
        Me.UP_PruebaReporteTableAdapter.Fill(Me.ProduccionInterfletdbReportes.UP_PruebaReporte, parametro)

        'actualizamos el reporte
        Me.ReportViewer.RefreshReport()

        'Generamos el archivo y ya ;) (k)
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