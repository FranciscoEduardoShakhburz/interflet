Imports System.Data.SqlClient

Public Class formEnviarCorreo
    Private idCliente As Integer
    Private nombreCliente As String
    Private noViaje As String
    Private unidad As String
    Private operador As String
    Private destino As String
    Private referencias As String
    Private observaciones As String
    Private placas As String
    Private ubicacion As String

    Public Sub New()
        InitializeComponent()
        Me.idCliente = 0
        Me.nombreCliente = ""
        Me.noViaje = ""
        Me.unidad = ""
        Me.operador = ""
        Me.destino = ""
        Me.referencias = ""
        Me.observaciones = ""
        Me.placas = ""
        Me.ubicacion = ""
    End Sub

    Public Sub New(ByVal idCliente As Integer, ByVal nombreCliente As String, ByVal noViaje As String, ByVal unidad As String, ByVal operador As String, ByVal destino As String, ByVal referencias As String, ByVal observaciones As String, ByVal placas As String, ByVal ubicacion As String)
        InitializeComponent()
        Me.idCliente = idCliente
        Me.nombreCliente = nombreCliente
        Me.noViaje = noViaje
        Me.unidad = unidad
        Me.operador = operador
        Me.destino = destino
        Me.referencias = referencias
        Me.observaciones = observaciones
        Me.placas = placas
        Me.ubicacion = ubicacion
    End Sub

    Private Sub formEnviarCorreo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtIdCliente.Text = Me.idCliente.ToString()
        Me.txtCliente.Text = Me.nombreCliente
        Me.txtNoViaje.Text = Me.noViaje
        Me.txtUnidad.Text = Me.unidad
        Me.txtOperador.Text = Me.operador
        Me.txtDestino.Text = Me.destino
        Me.txtReferencias.Text = Me.referencias
        Me.txtObservaciones.Text = Me.observaciones
        Me.txtPlacas.Text = Me.placas
        Me.txtUbicacion.Text = Me.ubicacion
        Me.getCorreos(Convert.ToInt32(Me.txtIdCliente.Text.Trim))
    End Sub

    Private Sub getCorreos(ByVal idCliente As Integer)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT email FROM trafico_cliente_email WHERE idCliente = " & idCliente
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.CommandType = CommandType.Text
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim contador As Integer = 0
        If reader.HasRows Then
            While reader.Read
                Me.chkListaCorreos.Items.Add((reader.GetString(0)))
                Me.chkListaCorreos.SetItemChecked(contador, True)
                contador += 1
            End While
        End If
        conn.Dispose()
        conn.Close()
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Dim correo As String = "Unidad: " & Me.unidad & Environment.NewLine & "Operador: " & Me.operador & Environment.NewLine & "Destino: " & Me.destino & Environment.NewLine & "Referencias: " & Me.referencias & Environment.NewLine & "Observaciones: " & Me.observaciones & Environment.NewLine & "Placas: " & Me.placas & Environment.NewLine & "Ubicacion: " & Me.txtUbicacion.Text

        Dim dimension As Integer = Me.chkListaCorreos.Items.Count - 1
        Dim lista(dimension) As String
        For i As Integer = 0 To dimension
            If Me.chkListaCorreos.GetItemChecked(i) Then
                lista(i) = Me.chkListaCorreos.Items(i).ToString()
            End If
        Next

        If Email.getInstance().sendEmail("Ubicación de Unidad", correo, lista) Then
            MessageBox.Show("¡Correo Enviado!")
        Else
            MessageBox.Show("El correo no ha sido enviado. Favor de ponerse en contacto con el Depto. de Sistemas")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class