Imports System.Data.SqlClient

Public Class formClientes

    Private Sub formClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getClientes()
    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click

        Dim idCliente As Integer = Convert.ToInt32(Me.grdClientes.CurrentRow.Cells("id_cliente").Value.ToString())
        Dim nombreCliente As String = Me.grdClientes.CurrentRow.Cells("nombre").Value.ToString()
        Dim rfcCliente As String = Me.grdClientes.CurrentRow.Cells("rfc").Value.ToString()
        Dim emails As New formEmails(idCliente, nombreCliente, rfcCliente)
        emails.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub txtNombreCliente_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreCliente.KeyUp
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()

        Dim parametro As String = Me.txtNombreCliente.Text.Trim & "%"
        Dim sql As String = "select id_cliente, nombre, rfc from trafico_cliente where nombre like '" & parametro & "' order by id_cliente"

        Dim adapter As New SqlDataAdapter(sql, conn)
        Dim table As New DataTable
        adapter.Fill(table)
        conn.Close()
        Me.grdClientes.DataSource = table
        Cursor = Cursors.Arrow
    End Sub

    Private Sub grdClientes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdClientes.SelectionChanged
        Cursor = Cursors.WaitCursor
        If Me.grdClientes.Rows.Count > 1 Then
            Dim idCliente As Integer = 0
            idCliente = Convert.ToInt32(Me.grdClientes.CurrentRow.Cells("id_cliente").Value)
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim sql As String = "SELECT idEmail, idCliente, email FROM trafico_cliente_email WHERE idCliente = '" & idCliente & "'"
            Dim adapter As New SqlDataAdapter(sql, conn)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.gridEmails.DataSource = table
            conn.Dispose()
            conn.Close()
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub formClientes_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.getClientes()
    End Sub

    Private Sub getClientes()
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()

        Dim sql As String = "select id_cliente, nombre, rfc from trafico_cliente order by id_cliente"
        Dim adapter As New SqlDataAdapter(sql, conn)
        Dim table As New DataTable
        adapter.Fill(table)
        conn.Close()
        Me.grdClientes.DataSource = table
        Cursor = Cursors.Arrow
    End Sub
End Class