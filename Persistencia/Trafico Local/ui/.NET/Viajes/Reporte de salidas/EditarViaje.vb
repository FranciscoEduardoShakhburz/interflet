Imports System.Data
Imports System.Data.SqlClient

Public Class EditarViaje

    Private viaje As DataGridViewRow

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef viaje As DataGridViewRow)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.viaje = viaje

    End Sub

    Private Sub EditarViaje_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Cursor.Current = Cursors.WaitCursor
        Me.dTPFecha.Value = Convert.ToDateTime(Me.viaje.Cells("colFecha").Value.ToString())
        Me.txtUnidad.Text = Me.viaje.Cells("colUnidad").Value.ToString()
        Me.txtOperador.Text = Me.viaje.Cells("colOperador").Value.ToString()
        Me.txtPlacas.Text = Me.viaje.Cells("colPlacas").Value.ToString()
        Me.txtViaje.Text = Me.viaje.Cells("colViaje").Value.ToString()
        Me.txtHoraDoc.Text = Me.viaje.Cells("colHoraDocumentacion").Value.ToString()
        Me.txtContenedores.Text = Me.viaje.Cells("colContenedores").Value.ToString()
        Me.txtCliente.Text = Me.viaje.Cells("colCliente").Value.ToString()
        Me.txtDestino.Text = Me.viaje.Cells("colDestino").Value.ToString()
        Me.txtCP.Text = Me.viaje.Cells("colCartaPorte").Value.ToString()
        Me.txtTipoOp.Text = Me.viaje.Cells("colTipoOp").Value.ToString()
        Me.txtDocsEntregados.Text = Me.viaje.Cells("colHoraDocumentosEntregados").Value.ToString()
        Me.txtEntregarEn.Text = Me.viaje.Cells("colEntregarEn").Value.ToString()
        Me.txtRemolque1.Text = Me.viaje.Cells("colRemolque").Value.ToString()
        Me.txtDolly.Text = Me.viaje.Cells("colDolly").Value.ToString()
        Me.txtHoraDoc.Text = Me.viaje.Cells("colHoraDocumentacion").Value.ToString()
        Me.txtDocsEntregados.Text = Me.viaje.Cells("colHoraDocumentosEntregados").Value.ToString()
        Me.rTBObservaciones.Text = Me.viaje.Cells("colObservaciones").Value.ToString()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try

            Cursor.Current = Cursors.WaitCursor
            Me.viaje.Cells("colFecha").Value = Me.dTPFecha.Value
            Me.viaje.Cells("colUnidad").Value = Me.txtUnidad.Text
            Me.viaje.Cells("colOperador").Value = Me.txtOperador.Text
            Me.viaje.Cells("colPlacas").Value = Me.txtPlacas.Text
            Me.viaje.Cells("colViaje").Value = Me.txtViaje.Text
            Me.viaje.Cells("colHoraDocumentacion").Value = Me.txtHoraDoc.Text
            Me.viaje.Cells("colCliente").Value = Me.txtCliente.Text
            Me.viaje.Cells("colDestino").Value = Me.txtDestino.Text
            Me.viaje.Cells("colCartaPorte").Value = Me.txtCP.Text
            Me.viaje.Cells("colContenedores").Value = Me.txtContenedores.Text
            Me.viaje.Cells("colTipoOp").Value = Me.txtTipoOp.Text
            Me.viaje.Cells("colHoraDocumentosEntregados").Value = Me.txtDocsEntregados.Text
            Me.viaje.Cells("colEntregarEn").Value = Me.txtEntregarEn.Text
            Me.viaje.Cells("colRemolque").Value = Me.txtRemolque1.Text
            Me.viaje.Cells("colDolly").Value = Me.txtDolly.Text
            Me.viaje.Cells("colObservaciones").Value = Me.rTBObservaciones.Text
            MessageBox.Show("El viaje se ha guardado correctamente.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor.Current = Cursors.Arrow
            Me.Close()

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub
End Class