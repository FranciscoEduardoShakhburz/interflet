Imports System.Data.SqlClient

Public Class formCatGastos

    Private Sub formCatGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getGastos()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Cursor = Cursors.WaitCursor
        Dim gastoViaje As String = Me.txtNombreConcepto.Text.ToUpper.Trim
        Dim valor As Double = Convert.ToDouble(IIf(String.IsNullOrEmpty(Me.txtCantidad.Text.Trim), "0.00", Me.txtCantidad.Text.Trim))

        If Not String.IsNullOrEmpty(gastoViaje) Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO trafico_conceptos_gasto (desc_gasto_viaje, valor) VALUES(@gastoViaje, @valor)"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.CommandType = CommandType.Text
            command.Parameters.AddWithValue("@gastoViaje", gastoViaje)
            command.Parameters.AddWithValue("@valor", valor)
            command.ExecuteNonQuery()
            conn.Close()
            Me.getGastos()
            Me.txtNombreConcepto.Text = ""
            Me.txtNombreConcepto.Focus()
        Else
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            conn.Open()
            Dim sql As String = "update trafico_conceptos_gasto set desc_gasto_viaje = @gasto, valor = @valor where id_gasto_viaje = @id_gasto"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.CommandType = CommandType.Text
            command.Parameters.AddWithValue("@gasto", Me.gridGastos.CurrentRow.Cells(1).Value.ToString())
            command.Parameters.AddWithValue("@valor", Me.gridGastos.CurrentRow.Cells(2).Value.ToString())
            command.Parameters.AddWithValue("@id_gasto", Me.gridGastos.CurrentRow.Cells(0).Value.ToString())
            command.ExecuteNonQuery()
            conn.Close()
            Me.getGastos()
            Me.txtNombreConcepto.Text = ""
            Me.txtNombreConcepto.Focus()
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub getGastos()
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "SELECT id_gasto_viaje as [ID], desc_gasto_viaje as [Gasto], valor as [Valor] FROM trafico_conceptos_gasto"
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(sql, conn)
        Dim table As New DataTable
        adapter.Fill(table)
        Me.gridGastos.DataSource = table
        conn.Close()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub gridGastos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridGastos.KeyDown
        Cursor = Cursors.WaitCursor
        If e.KeyCode = Keys.Delete Then
            Dim resultado As DialogResult = MessageBox.Show("¿Esta seguro de eliminar el gasto?", "Gastos de Viaje", MessageBoxButtons.YesNo)
            If resultado = Windows.Forms.DialogResult.Yes Then
                Dim id As String = Me.gridGastos.CurrentRow.Cells("ID").Value.ToString.Trim
                Dim conn As SqlConnection = Connection.getInstance().getConnection()
                conn.Open()
                Dim sql As String = "DELETE FROM trafico_conceptos_gasto WHERE id_gasto_viaje = @id"
                Dim command As SqlCommand = New SqlCommand(sql, conn)
                command.Parameters.AddWithValue("@id", id)
                command.ExecuteNonQuery()
                conn.Close()
                Me.getGastos()
            End If
        End If
        Cursor = Cursors.Arrow
    End Sub
End Class