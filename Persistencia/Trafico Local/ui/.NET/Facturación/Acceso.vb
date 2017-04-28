Public Class Acceso
    Public usuario, contraseña As String
    Public usuario2, adm, ContraUsuario, ContraAdm As String
    Public tipo As Integer = 0
    Private Sub Acceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_usuario.SelectedIndex = 1
    End Sub

    Private Sub bto_acceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_acceder.Click
        usuario = cmb_usuario.SelectedItem
        contraseña = txt_contraseña.Text
        usuario2 = "usuario"
        adm = "adm"
        ContraUsuario = "123456" ' Contraseña de Usuario
        ContraAdm = "456789" 'Contraseña de  Admin

        If usuario.Equals(usuario2) And contraseña.Equals(ContraUsuario) Then
            tipo = 1
            PaseFacturacion.Show()
            Me.Hide()
        End If
        If usuario.Equals(adm) And contraseña.Equals(ContraAdm) Then
            tipo = 2
            PaseFacturacion.Show()
            Me.Hide()
        End If
        If tipo = 0 Then
            MessageBox.Show("Usuario o Contraseña Incorrectos")
        End If

    End Sub

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click
        Me.Close()
    End Sub
End Class