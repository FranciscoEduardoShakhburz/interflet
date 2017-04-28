Public Class Autorizar

    Private registro As RegistroCandidatos
    Private contraAdmin As Boolean
    Private contraUser As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef registro As RegistroCandidatos)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.registro = registro

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If Not String.IsNullOrEmpty(Me.txtContraseña.Text) Then
            If Me.txtContraseña.Text.Equals("1972") Then

                Me.contraAdmin = True

            ElseIf Me.txtContraseña.Text.Equals("INPLANT4506") Then

                Me.contraUser = True

            End If

            Me.Close()

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub txtContraseña_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContraseña.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrEmpty(Me.txtContraseña.Text) Then
                If Me.txtContraseña.Text.Equals("1972") Then

                    Me.contraAdmin = True

                ElseIf Me.txtContraseña.Text.Equals("INPLANT4506") Then

                    Me.contraUser = True

                End If

                Me.Close()

            End If

            e.Handled = True

        End If
    End Sub

    Public Function getContraAdmin() As Boolean

        Return Me.contraAdmin

    End Function

    Public Function getContraUser() As Boolean

        Return Me.contraUser

    End Function
End Class