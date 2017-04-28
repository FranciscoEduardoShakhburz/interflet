Imports System.Data.SqlClient
Namespace PI_CalidadTableAdapters
    Partial Class UP_Consulta_ReporteCalidad_v2TableAdapter
        Public Sub setTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class
End Namespace
