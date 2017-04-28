Imports System.Data
Imports System.Data.SqlClient

Public Class EditarCarga

    Private carga As DataGridViewRow

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef carga As DataGridViewRow)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.carga = carga

    End Sub

    Private Sub EditarCarga_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarInformación()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub cargarInformación()

        Me.tBNumero.Text = Me.carga.Cells("colNumero").Value.ToString()
        Me.tBContenedor.Text = Me.carga.Cells("colContenedores").Value.ToString()
        Me.tBReferencia.Text = Me.carga.Cells("colReferencia").Value.ToString()
        Me.tBDemoras.Text = carga.Cells("colDemoras").Value.ToString()
        Me.tBNaviera.Text = carga.Cells("colNaviera").Value.ToString()
        Me.tBEsPeligrosa.Text = carga.Cells("colEsPeligrosa").Value.ToString()
        Me.tBCliente.Text = Me.carga.Cells("colClienteCont").Value.ToString()
        Me.tBConfiguracion.Text = Me.carga.Cells("colConfiguracion").Value.ToString()
        Me.tBPlanta.Text = Me.carga.Cells("colFechaPlanta").Value.ToString()
        Me.tBEntregarEn.Text = Me.carga.Cells("colEntregarEn").Value.ToString()
        Me.tBDestino.Text = Me.carga.Cells("colDestinoCont").Value.ToString()
        Me.tBOperacion.Text = Me.carga.Cells("colOperacion").Value.ToString()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

    End Sub
End Class