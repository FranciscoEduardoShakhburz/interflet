Public Class EditarOperador

    Private operador As DataGridViewRow

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef operador As DataGridViewRow)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.operador = operador

    End Sub

    Private Sub EditarOperador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarInformación()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub cargarInformación()

        Me.tBEconomico.Text = operador.Cells("colUnidad").Value.ToString()
        Me.tBTelefono.Text = IIf(operador.Cells("colTelefono").Value IsNot Nothing, operador.Cells("colTelefono").Value.ToString(), "")
        Me.tBOperadorId.Text = operador.Cells("colNumOperador").Value.ToString()
        Me.tBOperador.Text = operador.Cells("colOperador").Value.ToString()
        Me.tBFechaLlegada.Text = operador.Cells("colFechaLleg").Value.ToString()
        Me.dTPFechaVencLic.Value = Convert.ToDateTime(operador.Cells("colFechaVencLic").Value.ToString())

        If operador.Cells("colFechaVencSeg").Value.ToString().Equals("S/F") Then

            Me.dTPFechaVencSeg.Value = DateTime.Now

        Else

            Me.dTPFechaVencSeg.Value = Convert.ToDateTime(operador.Cells("colFechaVencSeg").Value.ToString())

        End If

        Me.tBManejaMPeligroso.Text = operador.Cells("colManejaMatPeligroso").Value.ToString()
        Me.tBStatus.Text = operador.Cells("colStat").Value.ToString()

    End Sub
End Class