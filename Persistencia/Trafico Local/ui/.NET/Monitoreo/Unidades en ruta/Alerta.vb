Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class Alerta

    Private segundos As Integer
    Private min As Integer
    Private hor As Integer
    Private idAlerta As Integer
    Private tipoAlerta As String
    Private unidad As String
    Private tiempoRespuesta As String
    Const VK_STARTKEY = &H5B
    Const VK_D = 68
    Const KEYEVENTF_KEYUP = &H2
    
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal tipoAlerta As String, ByVal unidad As String, ByVal tiempoRespuesta As String, ByVal tss As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.tipoAlerta = tipoAlerta
        Me.unidad = unidad
        Me.tiempoRespuesta = tiempoRespuesta
        Me.etqUnidad.Text = unidad
        Me.etqTSS.Text = tss
        Me.minimizarTodo()

    End Sub

    Private Sub Alerta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Me.tipoAlerta.Contains("planta") Then

            My.Computer.Audio.Play(My.Resources.AlertaTramos, AudioPlayMode.Background)

        Else

            My.Computer.Audio.Play(My.Resources.Red_Alert_Sound, AudioPlayMode.Background)

        End If

        If Me.tipoAlerta.Contains("TSS") Then

            Me.etqMensaje.Text = "HA EXCEDIDO EL TIEMPO ESTIMADO"

        ElseIf Me.tipoAlerta.Contains("Desconexion") Then

            Me.etqMensaje.Text = "HA SUFRIDO UNA DESCONEXION"

        ElseIf Me.tipoAlerta.Contains("planta") Then

            Me.etqMensaje.Text = "EXCEDIÓ EL TMPO. EN PLANTA DEL CLIENTE"

        ElseIf Me.tipoAlerta.Contains("Sabotaje") Then

            Me.etqMensaje.Text = "HA PRESENTADO UN SABOTAJE"

        ElseIf Me.tipoAlerta.Contains("pánico") Then

            Me.etqMensaje.Text = "EMITIÓ UNA ALERTA DE PÁNICO"

        ElseIf Me.tipoAlerta.Contains("ruta") Then

            Me.etqMensaje.Text = "ESTÁ FUERA DE RUTA"

        End If

        Me.subirVolumenMax()
        Me.WindowState = FormWindowState.Maximized
        Me.guardarAlerta()
        Timer1.Interval = 1000
        Timer1.Start() 'Timer starts functioning
        tiempo.Interval = 1000
        tiempo.Start()
        Me.Activate()

    End Sub

    Private Sub btnProcedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcedimiento.Click

        Me.alertaAtendida()

    End Sub

    Private Sub btnVisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisto.Click

        Me.alertaAtendida()

    End Sub

    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, _
ByVal dwExtraInfo As Long)

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        Me.BackColor = Color.Red
        Timer2.Interval = 1000
        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Timer2.Stop()
        Me.BackColor = Color.White
        Timer1.Interval = 1000
        Timer1.Start()

    End Sub

    Private Sub tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo.Tick

        segundos += 1

        If segundos = 60 Then

            min += 1
            segundos = 0

        End If

        If min = 60 Then

            hor += 1
            min = 0

        End If

        tiempoTranscurrido.Text = IIf(hor < 10, "0" & hor, hor) & ":" & IIf(min < 10, "0" & min, min) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

    End Sub

    Private Sub minimizarTodo()

        'WinKey down
        keybd_event(VK_STARTKEY, 0, 0, 0)
        'D key down
        keybd_event(VK_D, 0, 0, 0)
        'D key up
        keybd_event(VK_D, 0, KEYEVENTF_KEYUP, 0)
        'WinKey up
        keybd_event(VK_STARTKEY, 0, KEYEVENTF_KEYUP, 0)

    End Sub

    Private Sub guardarAlerta()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            consulta = "INSERT INTO Trafico_AlertasCriticas_Satelital VALUES('" & Me.tipoAlerta & "', '" & Me.unidad & "', GETDATE(), HOST_NAME(), '00:00:00', 0, '') DECLARE @id INT SET @id = (SELECT TOP(1) idAlerta FROM Trafico_AlertasCriticas_Satelital WHERE unidad = '" & Me.unidad & "' AND CONVERT(INT, fechaAlerta, 112) = CONVERT(INT, GETDATE(), 112) ORDER BY fechaAlerta DESC) SELECT ISNULL(@id, 0) AS idAlerta"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            Me.idAlerta = Convert.ToInt32(comando.ExecuteScalar().ToString())

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub

    Private Sub alertaAtendida()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            consulta = "UPDATE Trafico_AlertasCriticas_Satelital SET lugarAtendio = '" & Environment.MachineName & "', tiempoRespuesta = '" & Me.tiempoTranscurrido.Text & "', visto = 1, observaciones = '" & Me.rTBObservaciones.Text & "' WHERE idAlerta = " & Me.idAlerta
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If Me.tipoAlerta.Contains("ruta") Then

                consulta = "UPDATE Trafico_Auxiliar_Estatus SET observacionesMonitoreo = '" & Me.rTBObservaciones.Text & "' WHERE economico = '" & Me.unidad & "'"
                conexion = Connection.getInstance().getConnectionQSP()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            End If
        Catch ex As Exception

            MessageBox.Show("Error al guardar la alerta: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub subirVolumenMax()

        Dim p As New ProcessStartInfo
        p.FileName = "nircmd.exe"
        p.Arguments = "setsysvolume 65535"
        Process.Start(p)

    End Sub
End Class