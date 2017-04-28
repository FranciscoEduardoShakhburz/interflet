Public Class SeleccionarPrioridadCargas

    Private row1 As DataGridViewRow
    Private row2 As DataGridViewRow

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef row1 As DataGridViewRow, ByRef row2 As DataGridViewRow)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.row1 = row1
        Me.row2 = row2

    End Sub

    Private Sub SeleccionarPrioridadCargas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarGrid()

    End Sub

    Private Sub bAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click

        Me.guardar()
        Me.Close()

    End Sub

    Private Sub bCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancelar.Click

        Me.Close()

    End Sub

    Private Sub cargarGrid()

        Dim fila As DataGridViewRow

        fila = Me.dGVPrioridad.Rows(Me.dGVPrioridad.Rows.Add())
        fila.Cells("colPrioridad").Value = ""
        fila.Cells("colContenedor").Value = Me.row1.Cells("colContenedores").Value.ToString()
        fila.Cells("colCliente").Value = Me.row1.Cells("colClienteCont").Value.ToString()
        fila.Cells("colDestino").Value = Me.row1.Cells("colDestinoCont").Value.ToString()
        fila = Me.dGVPrioridad.Rows(Me.dGVPrioridad.Rows.Add())
        fila.Cells("colPrioridad").Value = ""
        fila.Cells("colContenedor").Value = Me.row2.Cells("colContenedores").Value.ToString()
        fila.Cells("colCliente").Value = Me.row2.Cells("colClienteCont").Value.ToString()
        fila.Cells("colDestino").Value = Me.row2.Cells("colDestinoCont").Value.ToString()
        
    End Sub

    Private Sub guardar()


        If Not String.IsNullOrEmpty(Me.dGVPrioridad.Rows(0).Cells("colPrioridad").Value.ToString()) And Not String.IsNullOrEmpty(Me.dGVPrioridad.Rows(1).Cells("colPrioridad").Value.ToString()) Then

            Me.row1.Cells("colClienteCont").Value = Me.row1.Cells("colClienteCont").Value.ToString() & " (" & Me.dGVPrioridad.Rows(0).Cells("colPrioridad").Value.ToString() & ")"
            Me.row2.Cells("colClienteCont").Value = Me.row2.Cells("colClienteCont").Value.ToString() & " (" & Me.dGVPrioridad.Rows(1).Cells("colPrioridad").Value.ToString() & ")"

        Else

            MessageBox.Show("Se debe establecer la prioridad de las cargas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
End Class