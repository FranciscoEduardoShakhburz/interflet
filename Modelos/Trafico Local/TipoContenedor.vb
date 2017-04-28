Public Class TipoContenedor
    Public id_tipo_contenedor As Integer
    Public tipo_contenedor As String

    Public Sub New()
        Me.id_tipo_contenedor = 0
        Me.tipo_contenedor = ""
    End Sub

    Public Overrides Function ToString() As String
        Return Me.tipo_contenedor
    End Function
End Class
