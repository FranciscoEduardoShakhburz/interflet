

Public Class FrmConsultaCotizacion
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If Validar() Then
            Dim NoCotizacion As Integer

            If Me.TxtNoCotizacion.Text = "" Then
                NoCotizacion = 0
            Else
                NoCotizacion = Convert.ToInt32(Me.TxtNoCotizacion.Text)
            End If

            Me.UP_Consulta_CotizacionTableAdapter.Fill(Me.PI_ConsultaCotizacion.UP_Consulta_Cotizacion, NoCotizacion, Trim(Me.TxtCliente.Text), Me.cmbFecIni.Value, Me.cmbFecFin.Value)

        End If
    End Sub

    Private Sub FrmConsultaCotizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.TxtNoCotizacion.Text = ""
        Me.TxtCliente.Text = ""
        Me.cmbFecIni.Value = DateTime.Today
        Me.cmbFecFin.Value = DateTime.Today

    End Sub
    Private Function Validar() As Boolean
        If Me.cmbFecIni.Value > Me.cmbFecFin.Value Then
            MsgBox("La fecha final no puede ser anterior a la fecha inicial", MsgBoxStyle.Exclamation, "Cotizador Interflet")
            Me.cmbFecFin.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Excel.gridToExcel(Me.DataGridView1)
    End Sub
End Class