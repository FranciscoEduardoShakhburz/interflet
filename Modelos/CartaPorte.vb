Public Class CartaPorte
    Private noGuia As Integer
    Private numCartaPorte As String
    Private idArea As Integer

    Public Sub New()
        Me.noGuia = -1
        Me.numCartaPorte = ""
        Me.idArea = -1
    End Sub

    Public Property NumeroGuia() As Integer
        Get
            Return Me.noGuia
        End Get
        Set(ByVal value As Integer)
            Me.noGuia = value
        End Set
    End Property

    Public Property CartaPorte() As String
        Get
            Return Me.numCartaPorte
        End Get
        Set(ByVal value As String)
            Me.numCartaPorte = value
        End Set
    End Property

    Public Property AreaDeCartaPorte() As Integer
        Get
            Return Me.idArea
        End Get
        Set(ByVal value As Integer)
            Me.idArea = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me.numCartaPorte
    End Function
End Class
