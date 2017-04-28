Public Class Ruta
    Private idRuta As String
    Private nombreRuta As String

    Public Sub New()
        Me.idRuta = 0
        Me.nombreRuta = ""
    End Sub

    Public Property Id() As Integer
        Get
            Return Me.idRuta
        End Get
        Set(ByVal value As Integer)
            Me.idRuta = value
        End Set
    End Property

    Public Property Ruta() As String
        Get
            Return Me.nombreRuta
        End Get
        Set(ByVal value As String)
            Me.nombreRuta = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.nombreRuta.ToUpper
    End Function
End Class
