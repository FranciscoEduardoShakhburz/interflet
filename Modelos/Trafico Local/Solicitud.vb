Public Class Solicitud
    Public folio_solicitud_viaje As String
    Public id_solicitud As Integer
    Public referencia As String
    Public ejecutivo As String
    Public cliente As String
    Public pedido_cliente As String
    Public proveedor As String
    Public buque As String
    Public mercancia As String
    Public estatus As String
    Public naviera As String
    Public booking As String
    Public imo As String
    Public un As String
    Public no_contenedores As String
    Public observaciones As String
    Public movimiento As Integer
    Public id_agencia_aduanal As Integer
    Public id_tipo_mercancia As Integer
    Public id_terminal_origen As Integer
    Public id_tipo_programacion As Integer
    Public id_terminal_reexpedicion As Integer
    Public id_tipo_contenedor As Integer
    Public fecha_solicitud As DateTime
    Public eta As DateTime
    Public fecha_pago_pedimento As DateTime
    Public fecha_demoras As DateTime
    Public fecha_almacenaje As DateTime
    Public fecha_zarpe As DateTime
    Public fecha_arribo As DateTime
    Public fecha_cierre_documentos As DateTime
    Public fecha_cierre_despacho As DateTime
    Public tipo_viaje As DateTime

    Public Sub New()
        Me.folio_solicitud_viaje = String.Empty
        Me.id_solicitud = 0
        Me.referencia = ""
        Me.ejecutivo = ""
        Me.cliente = ""
        Me.pedido_cliente = ""
        Me.proveedor = ""
        Me.buque = ""
        Me.mercancia = ""
        Me.estatus = ""
        Me.naviera = ""
        Me.booking = ""
        Me.imo = ""
        Me.un = ""
        Me.no_contenedores = ""
        Me.observaciones = ""
        Me.movimiento = 0
        Me.id_agencia_aduanal = 0
        Me.id_tipo_mercancia = 0
        Me.id_terminal_origen = 0
        Me.id_tipo_programacion = 0
        Me.id_terminal_reexpedicion = 0
        Me.id_tipo_contenedor = 0
        Me.fecha_solicitud = DateTime.Now()
        Me.eta = DateTime.Now()
        Me.fecha_pago_pedimento = DateTime.Now()
        Me.fecha_demoras = DateTime.Now()
        Me.fecha_almacenaje = DateTime.Now()
        Me.fecha_zarpe = DateTime.Now()
        Me.fecha_arribo = DateTime.Now()
        Me.fecha_cierre_documentos = DateTime.Now()
        Me.fecha_cierre_despacho = DateTime.Now()
        Me.tipo_viaje = String.Empty
    End Sub

    Public Overrides Function ToString() As String
        Return Me.folio_solicitud_viaje
    End Function
End Class
