Public Class TipoMovimiento
    Public id_movimiento As Integer
    Public nombre_movimiento As String

    Public Sub New()
        Me.id_movimiento = 0
        Me.nombre_movimiento = ""
    End Sub

    Public Overrides Function ToString() As String
        Return Me.nombre_movimiento
    End Function
End Class
