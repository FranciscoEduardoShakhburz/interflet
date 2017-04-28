Public Class frmRepViajesEvaluados

    Private Sub btnBuscar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar2.Click

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("UP_Consulta_ViajesEvaluados", oConexion)
        Me.grdReporte.DataSource = Nothing
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Try

            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            Me.grdReporte.DataSource = oDs.Tables(0)

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Excel.gridToExcel(Me.grdReporte)

    End Sub
End Class