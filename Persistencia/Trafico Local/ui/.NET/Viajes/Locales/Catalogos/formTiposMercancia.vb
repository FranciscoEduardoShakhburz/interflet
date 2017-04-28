Imports System.Data.SqlClient

Public Class formTiposMercancia

    Private Sub formTiposMercancia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getTiposMercancia()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not String.IsNullOrEmpty(Me.txtTipoMercancia.Text) Then
            Me.insertMercancia(Me.txtTipoMercancia.Text)
        End If
    End Sub

    Private Sub txtTipoMercancia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMercancia.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not String.IsNullOrEmpty(Me.txtTipoMercancia.Text) Then
            Me.insertMercancia(Me.txtTipoMercancia.Text)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub insertMercancia(ByVal mercancia As String)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "INSERT INTO TRAFICO_LOCAL_MERCANCIA (ID_TIPO_MERCANCIA) VALUES (@TIPO_MERCANCIA)"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@TIPO_MERCANCIA", mercancia.ToUpper)
        command.ExecuteNonQuery()
        MessageBox.Show("¡Tipo de Mercancía Guardado!")
        Me.getTiposMercancia()
        Me.txtTipoMercancia.Text = ""
    End Sub

    Private Sub getTiposMercancia()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "SELECT * FROM TRAFICO_LOCAL_MERCANCIA"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridTiposMercancia.DataSource = table
    End Sub

    Private Sub gridTiposMercancia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridTiposMercancia.KeyDown
        If e.KeyCode = Keys.Delete AndAlso Me.gridTiposMercancia.Rows.Count > 0 Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            conn.Open()
            Dim sql As String = "DELETE FROM TRAFICO_LOCAL_MERCANCIA WHERE ID_MERCANCIA = @ID_MERCANCIA"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            command.Parameters.AddWithValue("@ID_MERCANCIA", Me.gridTiposMercancia.CurrentRow.Cells("ID_MERCANCIA").Value.ToString())
            command.ExecuteNonQuery()
            MessageBox.Show("¡Tipo de Mercancía Eliminada!")
            Me.getTiposMercancia()
        End If
    End Sub
End Class