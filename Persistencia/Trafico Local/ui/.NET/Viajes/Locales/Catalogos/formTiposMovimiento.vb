Imports System.Data.SqlClient

Public Class formTiposMovimiento

    Private Sub formTiposMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getTiposMovimientos()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub txtTipoMovimiento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMovimiento.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not String.IsNullOrEmpty(Me.txtTipoMovimiento.Text) Then
            Me.insertTipoMovimiento(Me.txtTipoMovimiento.Text.ToUpper)
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not String.IsNullOrEmpty(Me.txtTipoMovimiento.Text) Then
            Me.insertTipoMovimiento(Me.txtTipoMovimiento.Text.ToUpper)
        End If
    End Sub

    Private Sub getTiposMovimientos()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT * FROM TRAFICO_LOCAL_MOVIMIENTO"
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable
        adapter.Fill(table)
        Me.gridTiposMovimientos.DataSource = table
    End Sub

    Private Sub insertTipoMovimiento(ByVal tipoMovimiento As String)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "INSERT INTO TRAFICO_LOCAL_MOVIMIENTO (NOMBRE_MOVIMIENTO) VALUES (@NOMBRE_MOVIMIENTO)"
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@NOMBRE_MOVIMIENTO", tipoMovimiento.ToUpper)
        command.ExecuteNonQuery()
        Me.getTiposMovimientos()
        Me.txtTipoMovimiento.Text = ""
    End Sub

    Private Sub gridTiposMovimientos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridTiposMovimientos.KeyDown
        If Me.gridTiposMovimientos.Rows.Count > 0 Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim sql As String = "DELETE FROM TRAFICO_LOCAL_MOVIMIENTO WHERE ID_MOVIMIENTO = @ID_MOVIMIENTO"
            conn.Open()
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@ID_MOVIMIENTO", Me.gridTiposMovimientos.CurrentRow.Cells("id_movimiento").Value)
            command.ExecuteNonQuery()
            Me.getTiposMovimientos()
        End If
    End Sub
End Class