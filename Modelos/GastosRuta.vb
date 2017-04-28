Public Class GastosRuta
    Public ruta As String
    Public viaje As String
    Public unidad As String
    Public operador As String
    Public configviaje As String
    Public cliente As String
    Public efectivo_casetas As String
    Public efectivo_iave As String
    Public litros_diesel As String
    Public costo_diesel As String
    Public pension As String
    Public maniobras As String
    Public anticipo As String
    Public transferencia As String
    Public total_gastos As String
    Public transferencia_sig_dia As String
    Public cantidad_viaje As String
    Public dinero_viaje As String
    Public vale, id As String

    Public Sub New()
        Me.vale = ""
        Me.ruta = ""
        Me.viaje = ""
        Me.unidad = ""
        Me.operador = ""
        Me.configviaje = ""
        Me.cliente = ""
        Me.efectivo_casetas = ""
        Me.efectivo_iave = ""
        Me.litros_diesel = ""
        Me.costo_diesel = ""
        Me.pension = ""
        Me.maniobras = ""
        Me.anticipo = ""
        Me.transferencia = ""
        Me.total_gastos = ""
        Me.transferencia_sig_dia = ""
        Me.cantidad_viaje = ""
        Me.dinero_viaje = ""
        Me.id = ""
    End Sub

    Public Overrides Function ToString() As String
        Return viaje & "_" & unidad & ".doc"
    End Function
End Class
