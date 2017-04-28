Public Class TipoMercancia
    Public id_mercancia As Integer
    Public id_tipo_mercancia As String

    Public Sub New()
        Me.id_mercancia = 0
        Me.id_tipo_mercancia = ""
    End Sub

    Public Overrides Function ToString() As String
        Return Me.id_tipo_mercancia
    End Function
End Class
