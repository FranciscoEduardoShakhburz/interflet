Public Class formCasetasNuevas

#Region "Acciones del Formulario"
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub
#End Region

    Private Sub formCasetasNuevas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtNoViaje.Text = frmCasetasViaje.TxtNoViaje.Text
        Me.txtRuta.Text = frmDatosViaje.IdRuta
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Consulta_Casetas3", oConexion)
        Dim oParameter As SqlClient.SqlParameter

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        oParameter = oCommand.Parameters.Add("@ID_RUTA", SqlDbType.Int)
        oParameter.Value = Me.txtRuta.Text
        oDa = New SqlClient.SqlDataAdapter(oCommand)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        Me.gridCasetas.DataSource = oDs.Tables(0)
        oConexion.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try

            For i As Integer = 0 To Me.gridCasetas.RowCount - 1
                If CDbl(gridCasetas.Rows(i).Cells("Tarifa").Value) <> 0 Then
                    If IsDBNull(gridCasetas.Rows(i).Cells("Transitada").Value) Then

                        gridCasetas.Rows(i).Cells("Transitada").Value = False

                    End If

                    GuardaCasetas(Convert.ToInt32(Me.txtNoViaje.Text), Convert.ToInt32(gridCasetas.Rows(i).Cells("ID Caseta").Value), CByte(gridCasetas.Rows(i).Cells("Transitada").Value), Convert.ToInt32(gridCasetas.Rows(i).Cells("Ejes").Value), Convert.ToInt32(gridCasetas.Rows(i).Cells(0).Value))

                End If
            Next

            MessageBox.Show("Datos guardados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub GuardaCasetas(ByVal NoViaje As Integer, ByVal IdCaseta As Integer, ByVal Transitada As Boolean, ByVal noEjes As Integer, ByVal Direccion As Integer)

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_CasetasViaje", oConexion)
        Dim oParameter As SqlClient.SqlParameter

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Try

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = NoViaje
            oParameter = oCommand.Parameters.Add("@IdCaseta", SqlDbType.Int)
            oParameter.Value = IdCaseta
            oParameter = oCommand.Parameters.Add("@Transitada", SqlDbType.Bit)
            oParameter.Value = Transitada
            oParameter = oCommand.Parameters.Add("@NoEjes", SqlDbType.Int)
            oParameter.Value = noEjes
            oParameter = oCommand.Parameters.Add("@Direccion", SqlDbType.Int)
            oParameter.Value = Direccion
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oParameter.ResetSqlDbType()

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

End Class