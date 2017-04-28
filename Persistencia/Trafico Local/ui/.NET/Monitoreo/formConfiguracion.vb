Imports System.Data.SqlClient

Public Class formConfiguracion

    Private Sub formConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtContrasena.Text = ""
        Me.enabledControls(False)
        Me.txtNuevaContrasena.Enabled = False
        Me.getConfig()
    End Sub



#Region "Consultas"

    Private Function isPassword(ByVal pass As String) As Boolean
        Dim consulta As String = "SELECT COUNT(*) FROM configuracion_monitoreo where contrasena = '" & pass & "'"
        Dim resultado As Boolean = False
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(consulta, conn)
        command.CommandType = CommandType.Text
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read Then
                resultado = Convert.ToBoolean(reader.GetInt32(0))
            End If
        End If
        conn.Dispose()
        conn.Close()
        Return resultado
    End Function

    Private Sub getConfig()
        Dim consulta As String = "SELECT horas_sinmovimiento, horas_descanso, contrasena FROM configuracion_monitoreo"

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(consulta, conn)
        command.CommandType = CommandType.Text
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            If reader.Read Then
                Me.txtMovimiento.Text = reader.GetInt32(0).ToString()
                Me.txtDescanso.Text = reader.GetInt32(1).ToString()
                Me.txtNuevaContrasena.Text = reader.GetString(2).Trim()
            End If
        End If
        conn.Dispose()
        conn.Close()
    End Sub

    Private Sub updateConfig()
        Dim consulta As String = "UPDATE configuracion_monitoreo SET horas_sinmovimiento = '" & Me.txtMovimiento.Text.Trim & "' ,horas_descanso = '" & Me.txtDescanso.Text.Trim & "' WHERE contrasena = '" & Me.txtContrasena.Text.Trim & "'"
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(consulta, conn)
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()
        conn.Dispose()
        conn.Close()
    End Sub
#End Region

#Region "Eventos"

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not String.IsNullOrEmpty(Me.txtDescanso.Text.Trim) OrElse String.IsNullOrEmpty(Me.txtMovimiento.Text.Trim) Then
            Me.updateConfig()
            MessageBox.Show("Configuración Guardada con Éxito")
            Me.formConfiguracion_Load(sender, e)
        Else
            MessageBox.Show("Los lapsos de tiempo no deben estar vacíos")
        End If
    End Sub

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click
        Me.getContrasena()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub txtContrasena_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContrasena.KeyUp
        If Keys.Enter = e.KeyData Then
            Me.getContrasena()
        End If
    End Sub

    Private Sub Label5_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDoubleClick
        If Me.txtNuevaContrasena.Enabled = True Then
            Me.txtNuevaContrasena.Enabled = True
        Else
            Me.txtNuevaContrasena.Enabled = False
        End If
    End Sub

#End Region

#Region "Útilerías"

    Private Sub getContrasena()
        Dim contrasena As String = Me.txtContrasena.Text.Trim.ToUpper()
        If Not String.IsNullOrEmpty(contrasena) Then
            If isPassword(contrasena) Then
                enabledControls(True)
            End If
        Else
            MessageBox.Show("Escribe una contraseña")
        End If
    End Sub

    Private Sub enabledControls(ByVal condicion As Boolean)
        Me.txtDescanso.Enabled = condicion
        Me.txtMovimiento.Enabled = condicion
        Me.btnGuardar.Enabled = condicion
    End Sub
#End Region


End Class