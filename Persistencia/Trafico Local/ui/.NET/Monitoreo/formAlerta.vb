Public Class formAlerta
    Public Sub New(ByVal texto As String)
        InitializeComponent()
        Me.txtAlerta.Text = texto
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class