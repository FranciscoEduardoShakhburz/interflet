Public Class frmGastosViaje

    Private Sub frmGastosViaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TxtNoViaje.Text = frmDatosViaje.TxtNoViaje.Text
        Me.UP_Consulta_GastosViajeTableAdapter.Fill(Me.PI_GastosViaje.UP_Consulta_GastosViaje, CInt(Me.TxtNoViaje.Text))

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try

            For i As Integer = 0 To grdGastosViaje.RowCount - 1
                If IsDBNull(grdGastosViaje.Rows(i).Cells(2).Value) Then

                    grdGastosViaje.Rows(i).Cells(2).Value = 0

                End If

                GuardaGastos(Convert.ToInt32(Me.TxtNoViaje.Text), Convert.ToInt32(grdGastosViaje.Rows(i).Cells(0).Value), CDbl(grdGastosViaje.Rows(i).Cells(2).Value), grdGastosViaje.Rows(i).Cells(3).Value.ToString())

            Next

            MessageBox.Show("Datos guardados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
            Me.Dispose()

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub GuardaGastos(ByVal NoViaje As Integer, ByVal IdGasto As Integer, ByVal Monto As Decimal, ByVal observaciones As String)

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_GastosViaje", oConexion)
        Dim oParameter As SqlClient.SqlParameter

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Try

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = NoViaje
            oParameter = oCommand.Parameters.Add("@IdGasto", SqlDbType.Int)
            oParameter.Value = IdGasto
            oParameter = oCommand.Parameters.Add("@Monto", SqlDbType.Money)
            oParameter.Value = Monto
            oParameter = oCommand.Parameters.Add("@Observaciones", SqlDbType.VarChar)
            oParameter.Value = observaciones
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oParameter.ResetSqlDbType()

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub UPConsultaGastosViajeBindingSource_CurrentItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPConsultaGastosViajeBindingSource.CurrentItemChanged

        Dim sumObject As Object
        sumObject = Me.PI_GastosViaje.UP_Consulta_GastosViaje.Compute("Sum(Monto_Gasto)", "Monto_Gasto IS NOT NULL")
        Me.TxtSuma.Text = sumObject.ToString()

    End Sub
End Class