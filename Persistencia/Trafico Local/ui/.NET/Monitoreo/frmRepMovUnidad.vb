Public Class frmRepMovUnidad

    Private Sub frmRepMovUnidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        Me.btnExportar.Enabled = False
        Me.QFSUbicacion.EnforceConstraints = False
    End Sub

    Private Sub Limpiar()
        Me.TxtUnidad.Text = ""
        Me.cmbFecIni.Value = Today
        Me.cmbFecFin.Value = Today
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.UP_Consulta_UbicacionUnidadTableAdapter.Fill(Me.QFSUbicacion.UP_Consulta_UbicacionUnidad, Me.TxtUnidad.Text, Me.cmbFecIni.Value.Date, Me.cmbFecFin.Value.Date)
        Me.btnExportar.Enabled = True
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Excel.gridToExcel(Me.grdUbicacionUnidad)
    End Sub
End Class