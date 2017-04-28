Imports System.Data.SqlClient

Public Class formRutas

    Private Sub txtRutas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRutas.KeyDown
        If Not String.IsNullOrEmpty(Me.txtRutas.Text.Trim) Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim sql As String = "SELECT ID_RUTA, DESC_RUTA FROM TRAFICO_RUTA WHERE DESC_RUTA LIKE '" & Me.txtRutas.Text.Trim & "%'"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            Me.gridRutas.DataSource = table
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Me.seleccionarRuta()
    End Sub

    Private Sub gridRutas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridRutas.DoubleClick
        Me.seleccionarRuta()
    End Sub

    Private Sub gridRutas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridRutas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.seleccionarRuta()
        End If
    End Sub

    Public Sub seleccionarRuta()
        formGastosPorRuta.txtRuta.Text = Me.gridRutas.CurrentRow.Cells("DESC_RUTA").Value.ToString()
        formGastosPorRuta.id_ruta = Convert.ToInt32(Me.gridRutas.CurrentRow.Cells("ID_RUTA").Value.ToString())
    End Sub
End Class