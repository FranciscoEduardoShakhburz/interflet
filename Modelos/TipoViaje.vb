Public Class TipoViaje
    Private idTipoViaje As Integer
    Private tipoViaje As String

    Public Sub New()
        Me.idTipoViaje = 0
        Me.tipoViaje = ""
    End Sub

    Public Sub New(ByVal idTipoViaje As String, ByVal tipoViaje As String)
        Me.idTipoViaje = idTipoViaje
        Me.tipoViaje = tipoViaje
    End Sub

    Public Property IdTipo() As String
        Get
            Return Me.idTipoViaje
        End Get
        Set(ByVal value As String)
            Me.idTipoViaje = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return Me.tipoViaje
        End Get
        Set(ByVal value As String)
            Me.tipoViaje = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.tipoViaje.ToUpper
    End Function
End Class
