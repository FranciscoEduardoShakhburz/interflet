Imports System.ComponentModel

Public Class Viaje
    Private idCliente As String
    Private nombreCliente As String
    Private noViaje As String
    Private unidad As String

    Private operador As String
    Private destino As String
    Private referencias As String
    Private observaciones As String

    Private promedioVelocidad As String
    Private status As String
    Private ubicacion As String
    Private placas As String

    Private horaSalida As DateTime
    Private proximoDescanso As DateTime

    Public Sub New()
        Me.idCliente = ""
        Me.nombreCliente = ""
        Me.noViaje = ""
        Me.unidad = ""

        Me.operador = ""
        Me.destino = ""
        Me.referencias = ""
        Me.observaciones = ""

        Me.promedioVelocidad = ""
        Me.status = ""
        Me.ubicacion = ""
        Me.placas = ""
    End Sub

#Region "Setter's & Getter's"

    Public Property id_Cliente() As String
        Get
            Return Me.idCliente
        End Get
        Set(ByVal Value As String)
            Me.idCliente = Value
        End Set
    End Property

    Public Property cliente() As String
        Get
            Return Me.nombreCliente
        End Get
        Set(ByVal Value As String)
            Me.nombreCliente = Value
        End Set
    End Property

    Public Property viaje() As String
        Get
            Return Me.noViaje
        End Get
        Set(ByVal Value As String)
            Me.noViaje = Value
        End Set
    End Property

    Public Property unidadViaje() As String
        Get
            Return Me.unidad
        End Get
        Set(ByVal Value As String)
            Me.unidad = Value
        End Set
    End Property

    Public Property nombreOperador() As String
        Get
            Return Me.idCliente
        End Get
        Set(ByVal Value As String)
            Me.idCliente = Value
        End Set
    End Property

    Public Property destinoViaje() As String
        Get
            Return Me.destino
        End Get
        Set(ByVal Value As String)
            Me.destino = Value
        End Set
    End Property

    Public Property referenciasViaje() As String
        Get
            Return Me.referencias
        End Get
        Set(ByVal Value As String)
            Me.referencias = Value
        End Set
    End Property

    Public Property observacionesViaje() As String
        Get
            Return Me.observaciones
        End Get
        Set(ByVal Value As String)
            Me.observaciones = Value
        End Set
    End Property

    Public Property promedioVelocidadViaje() As String
        Get
            Return Me.promedioVelocidad
        End Get
        Set(ByVal Value As String)
            Me.promedioVelocidad = Value
        End Set
    End Property

    Public Property statusViaje() As String
        Get
            Return Me.status
        End Get
        Set(ByVal Value As String)
            Me.status = Value
        End Set
    End Property


    Public Property ubicacionViaje() As String
        Get
            Return Me.ubicacion
        End Get
        Set(ByVal Value As String)
            Me.ubicacion = Value
        End Set
    End Property

    Public Property salidaViaje() As DateTime
        Get
            Return Me.horaSalida
        End Get
        Set(ByVal value As DateTime)
            Me.horaSalida = value
        End Set
    End Property

    Public Property descansoOperador() As DateTime
        Get
            Return Me.proximoDescanso
        End Get
        Set(ByVal value As DateTime)
            Me.proximoDescanso = value
        End Set
    End Property

    Public Property placasUnidad() As String
        Get
            Return Me.placas
        End Get
        Set(ByVal value As String)
            Me.placas = value
        End Set
    End Property
#End Region

    Public Overrides Function ToString() As String
        Return "No. Cliente: " & Me.idCliente & Environment.NewLine & "Operador: " & Me.operador & Environment.NewLine & "Destino: " & Me.destino & Environment.NewLine & "Referencias: " & Me.referencias & Environment.NewLine & "Observaciones: " & Me.observaciones & Environment.NewLine & "Placas: " & Me.placas & Environment.NewLine & "Ubicacion: " & Me.ubicacion
    End Function
End Class
