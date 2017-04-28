Public Class AutorizarMovimiento

    Private vales As CatValeGasolina

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef vales As CatValeGasolina)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.vales = vales

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If Not String.IsNullOrEmpty(Me.txtContraseña.Text) Then
            If Me.txtContraseña.Text.Equals("NANCY84625") Then

                Me.vales.contraCorrecta()

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
                If Me.txtContraseña.Text.Equals("NANCY84625") Then

                    Me.vales.contraCorrecta()

                End If

                Me.Close()

            End If

            e.Handled = True

        End If
    End Sub
End Class