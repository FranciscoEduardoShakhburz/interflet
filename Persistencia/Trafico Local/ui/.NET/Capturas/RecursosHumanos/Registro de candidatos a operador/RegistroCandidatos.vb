Imports System.Data
Imports System.Data.SqlClient

Public Class RegistroCandidatos

    Private contraseñaCorrecta As Boolean
    Private tipoUsuario As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal tipoUsuario As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.tipoUsuario = tipoUsuario

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim registro As IngresarRegistro = New IngresarRegistro(Me)
        registro.ShowDialog(Me)
        Me.checarTipoBusqueda()

    End Sub

    Private Sub RegistroCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cmbEstatus.SelectedIndex = 0

        If Not Me.tipoUsuario.Equals("Admin") Then

            Me.contMenuGrid.Enabled = False

        End If
    End Sub

    Private Sub rdBtnFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBtnFechas.CheckedChanged, rdBtnRFC.CheckedChanged, rdBtnNombre.CheckedChanged, rdBtnEstatus.CheckedChanged

        Me.checarTipoBusqueda()

    End Sub

    Private Sub dteDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteDesde.ValueChanged, dteHasta.ValueChanged


        If Me.rdBtnFechas.Checked Then

            Me.consultar(1, Me.dteDesde.Value.Date, Me.dteHasta.Value.Date, "", "", "")

        End If
    End Sub

    Private Sub txtCandidato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCandidato.TextChanged

        If Me.rdBtnNombre.Checked Then
            If String.IsNullOrEmpty(Me.txtCandidato.Text) Then

                Me.gridRegistros.DataSource = Nothing

            Else

                Me.consultar(2, DateTime.Now, DateTime.Now, Me.txtCandidato.Text, "", "")

            End If
        End If
    End Sub

    Private Sub txtRFC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRFC.TextChanged

        If Me.rdBtnRFC.Checked Then
            If String.IsNullOrEmpty(Me.txtRFC.Text) Then

                Me.gridRegistros.DataSource = Nothing

            Else

                Me.consultar(3, DateTime.Now, DateTime.Now, "", "", Me.txtRFC.Text)

            End If
        End If
    End Sub

    Private Sub cmbEstatus_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstatus.SelectionChangeCommitted

        If Me.rdBtnRFC.Checked Then

            Me.consultar(4, DateTime.Now, DateTime.Now, "", Me.cmbEstatus.SelectedItem, "")

        End If
    End Sub

    Private Sub consultar(ByVal tipoConsulta As Integer, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime, ByVal nombre As String, ByVal estatus As String, ByVal rfc As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Consulta_RegistroCandidatos", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@tipoConsulta", tipoConsulta)
                .AddWithValue("@fechaInicial", fechaInicial)
                .AddWithValue("@fechaFinal", fechaFinal)
                .AddWithValue("@nombre", nombre)
                .AddWithValue("@estatus", estatus)
                .AddWithValue("@rfc", rfc)

            End With

            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Me.gridRegistros.DataSource = dS.Tables(0)

                Else

                    Me.gridRegistros.DataSource = Nothing

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub contraCorrecta()

        Me.contraseñaCorrecta = True

    End Sub

    Public Sub checarTipoBusqueda()

        If Me.rdBtnFechas.Checked Then

            Me.consultar(1, Me.dteDesde.Value.Date, Me.dteHasta.Value.Date, "", "", "")

        ElseIf Me.rdBtnNombre.Checked Then
            If String.IsNullOrEmpty(Me.txtCandidato.Text) Then

                Me.gridRegistros.DataSource = Nothing

            Else

                Me.consultar(2, DateTime.Now, DateTime.Now, Me.txtCandidato.Text, "", "")

            End If
        ElseIf Me.rdBtnRFC.Checked Then
            If String.IsNullOrEmpty(Me.txtRFC.Text) Then

                Me.gridRegistros.DataSource = Nothing

            Else

                Me.consultar(3, DateTime.Now, DateTime.Now, "", "", Me.txtRFC.Text)

            End If
        ElseIf Me.rdBtnEstatus.Checked Then

            Me.consultar(4, DateTime.Now, DateTime.Now, "", Me.cmbEstatus.SelectedItem, "")

        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim consulta As String

        Try
            For Each registro As DataGridViewRow In Me.gridRegistros.SelectedRows

                consulta = "DELETE FROM RH_Registro_Candidatos_Detalle WHERE rfc = '" & registro.Cells("R.F.C.").Value.ToString() & "' AND nombre = '" & registro.Cells("Nombre").Value.ToString() & "'"
                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            Next

            MessageBox.Show("Los registros se eliminaron correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.checarTipoBusqueda()

        Catch ex As Exception

            MessageBox.Show("Error al eliminar el registro: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub gridRegistros_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridRegistros.CellMouseDoubleClick

        Dim registro As IngresarRegistro = New IngresarRegistro(Me.gridRegistros.CurrentRow.Cells("R.F.C.").Value.ToString(), Me.gridRegistros.CurrentRow.Cells("Nombre").Value.ToString(), Me)
        registro.ShowDialog(Me)

    End Sub

    Private Sub CambiarEstatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarEstatusToolStripMenuItem.Click

        Dim registro As IngresarRegistro = New IngresarRegistro(Me.gridRegistros.CurrentRow.Cells("R.F.C.").Value.ToString(), Me.gridRegistros.CurrentRow.Cells("Nombre").Value.ToString(), Me)
        
        If Me.tipoUsuario.Equals("Admin") Then

            registro.cmbEstatus.Enabled = True
            registro.ShowDialog(Me)
            Me.checarTipoBusqueda()

        Else

            MessageBox.Show("No tiene permiso para realizar esta acción", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Excel.gridToExcel(Me.gridRegistros)

    End Sub
End Class