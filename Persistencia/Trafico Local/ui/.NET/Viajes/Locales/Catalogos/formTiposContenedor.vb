Imports System.Data.SqlClient

Public Class formTiposContenedor

    Private Sub formTiposContenedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getTiposContenedor()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not String.IsNullOrEmpty(Me.txtTipoContenedor.Text.Trim) Then
            Me.insertTiposContenedor(Me.txtTipoContenedor.Text)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub txtTipoMercancia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoContenedor.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not String.IsNullOrEmpty(Me.txtTipoContenedor.Text.Trim) Then
            Me.insertTiposContenedor(Me.txtTipoContenedor.Text)
        End If
    End Sub

    Private Sub gridTiposMercancia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridTiposContenedor.KeyDown
        If e.KeyCode = Keys.Delete AndAlso Me.gridTiposContenedor.Rows.Count > 0 Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            conn.Open()
            Dim sql As String = "DELETE FROM TRAFICO_LOCAL_TIPO_CONTENEDOR WHERE ID_TIPO_CONTENEDOR = @ID_TIPO"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            command.Parameters.AddWithValue("@ID_TIPO", Me.gridTiposContenedor.CurrentRow.Cells("ID_TIPO_CONTENEDOR").Value.ToString())
            command.ExecuteNonQuery()
            MessageBox.Show("¡Tipo de Contenedor Eliminada!")
            Me.getTiposContenedor()
        End If
    End Sub


    Private Sub insertTiposContenedor(ByVal tipo As String)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "INSERT INTO TRAFICO_LOCAL_TIPO_CONTENEDOR (TIPO_CONTENEDOR) VALUES (@TIPO_CONTENEDOR)"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@TIPO_CONTENEDOR", tipo.ToUpper)
        command.ExecuteNonQuery()
        MessageBox.Show("¡Tipo de Contenedor Guardado!")
        Me.getTiposContenedor()
        Me.txtTipoContenedor.Text = ""
    End Sub

    Private Sub getTiposContenedor()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "SELECT * FROM TRAFICO_LOCAL_TIPO_CONTENEDOR"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridTiposContenedor.DataSource = table
    End Sub

End Class