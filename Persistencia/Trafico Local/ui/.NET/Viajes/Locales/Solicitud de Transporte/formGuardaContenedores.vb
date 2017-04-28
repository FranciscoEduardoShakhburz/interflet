Imports System.Data.SqlClient

Public Class formGuardaContenedores

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim contenedor As String = Me.txtContenedor.Text.Trim
        Dim peso As String = Me.txtPeso.Text.Trim
        Dim tamano As String = Me.txtTamano.Text.Trim

        If StringValidator.isContainer(contenedor) Then
            Dim conn As SqlConnection = Connection.getInstance.getConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO TRAFICO_LOCAL_CONTENEDOR (CONTENEDOR, TAMANO, PESO, ID_SOLICITUD) VALUES (@CONTENEDOR,@TAMANO,@PESO, @ID_SOLICITUD)"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@CONTENEDOR", contenedor.ToUpper())
            command.Parameters.AddWithValue("@TAMANO", peso)
            command.Parameters.AddWithValue("@PESO", tamano)
            command.Parameters.AddWithValue("@ID_SOLICITUD", formSolicitudTransporte.lblFolio.Text.Trim)
            command.ExecuteNonQuery()


            sql = "SELECT * FROM TRAFICO_LOCAL_CONTENEDOR WHERE ID_SOLICITUD = @ID_SOLICITUD"
            command = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@ID_SOLICITUD", formSolicitudTransporte.lblFolio.Text.Trim)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            formSolicitudTransporte.gridContenedores.DataSource = table
            MessageBox.Show("Guardado Exitosamente")
        Else
            MessageBox.Show("Escribe un contenedor válido")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class