Public Class formEscogerCiudad
    Private Sub formEscogerCiudad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.comboCiudades.SelectedItem = "Selecciona una ciudad disponible...."
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim ciudad As String = Me.comboCiudades.SelectedItem.ToString().Trim
        If ciudad = "Selecciona una ciudad disponible...." Then
            MessageBox.Show("Escoge una ciudad disponible")
        Else
            frmDatosViaje.getReset(ciudad)
        End If
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmDatosViaje.Limpiar()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class