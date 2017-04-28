Imports System.Data.SqlClient

Public Class formTiposProgramacion

    Private Sub formTiposProgramacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getTiposProgramacion()
    End Sub

    Private Sub gridTiposProgramacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridTiposProgramacion.KeyDown
        If Me.gridTiposProgramacion.Rows.Count > 0 AndAlso e.KeyCode = Keys.Delete Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim sql As String = "DELETE FROM TRAFICO_LOCAL_PROGRAMACION WHERE ID_PROGRAMACION = @ID_PROGRAMACION"
            conn.Open()
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@ID_PROGRAMACION", Me.gridTiposProgramacion.CurrentRow.Cells("id_programacion").Value)
            command.ExecuteNonQuery()
            MessageBox.Show("¡Tipo de programación eliminado!")
            Me.getTiposProgramacion()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not String.IsNullOrEmpty(Me.txtTipoProgramacion.Text.Trim) AndAlso Not String.IsNullOrEmpty(Me.txtAbreviaturaProgramacion.Text.Trim) Then
            Me.insertTiposProgramacion(Me.txtTipoProgramacion.Text.Trim, Me.txtAbreviaturaProgramacion.Text.Trim)
        Else
            MessageBox.Show("Escribe los dos campos")
        End If
    End Sub
    
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub getTiposProgramacion()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT * FROM TRAFICO_LOCAL_PROGRAMACION"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        conn.Open()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridTiposProgramacion.DataSource = table
    End Sub

    Private Sub insertTiposProgramacion(ByVal nombre As String, ByVal abreviatura As String)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "INSERT INTO TRAFICO_LOCAL_PROGRAMACION (ID_NOMBRE_PROGRAMACION,ID_ABREVIATURA_PROGRAMACION) VALUES (@ID_NOMBRE_PROGRAMACION, @ID_ABREVIATURA_PROGRAMACION)"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        conn.Open()
        command.Parameters.AddWithValue("@ID_NOMBRE_PROGRAMACION", nombre.ToUpper)
        command.Parameters.AddWithValue("@ID_ABREVIATURA_PROGRAMACION", abreviatura.ToUpper)
        command.ExecuteNonQuery()
        MessageBox.Show("¡Tipo de programación agregado!")
        Me.getTiposProgramacion()
        Me.txtTipoProgramacion.Text = ""
        Me.txtAbreviaturaProgramacion.Text = ""
    End Sub
End Class