Imports System.Data.Sqlclient
Public Class formEjecutivos

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand("insert_ejecutivo", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Nombre", Me.txt_Nom.Text)
        command.Parameters.AddWithValue("@Alias", Me.txt_alias.Text)
        command.ExecuteNonQuery()
        MessageBox.Show("Guardado con Exito")
        Me.txt_Nom.Text = ""
        Me.txt_alias.Text = ""
    End Sub
End Class