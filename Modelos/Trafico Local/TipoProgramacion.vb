Public Class TipoProgramacion
    Public id_programacion As Integer
    Public id_nombre_programacion As String
    Public id_abreviatura_programacion As String

    Public Sub New()
        Me.id_programacion = 0
        Me.id_nombre_programacion = ""
        Me.id_abreviatura_programacion = ""
    End Sub

    Public Overrides Function ToString() As String
        Return Me.id_nombre_programacion
    End Function
End Class
