Public Class formTipoViaje

    Private Sub formTipoViaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getTipos()
    End Sub

    Private Sub btnTipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipos.Click
        Dim tipo As String = Me.txtTipoViaje.Text.Trim
        If Not String.IsNullOrEmpty(tipo) Then
            TipoViajeDAO.insertTipoViaje(tipo)
            Me.getTipos()
        Else
            MessageBox.Show("Escribe un tipo de viaje")
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Public Sub getTipos()
        Cursor = Cursors.WaitCursor
        Me.grdTipoViajes.DataSource = TipoViajeDAO.getTableTiposViaje()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Cursor = Cursors.WaitCursor
        TipoViajeDAO.deleteTipoViaje(Convert.ToInt32(Me.grdTipoViajes.CurrentRow.Cells("id_tipoviaje").Value()))
        Me.getTipos()
        Cursor = Cursors.Arrow
    End Sub
End Class