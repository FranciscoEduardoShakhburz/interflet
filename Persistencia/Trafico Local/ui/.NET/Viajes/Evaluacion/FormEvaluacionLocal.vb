Imports System.Data.SqlClient
Public Class FormEvaluacionLocal


    Private Sub bto_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_consultar.Click

        Cursor = Cursors.WaitCursor
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim command As New SqlCommand("up_evaluacion_local", cn)
        Dim param As SqlParameter

        command.CommandType = CommandType.StoredProcedure
        cn.Open()
        param = command.Parameters.AddWithValue("@fecini", cmb_fecini.Value.Date)
        param = command.Parameters.AddWithValue("@fecfin", cmb_fecfin.Value.Date)

        If rfecha.Checked Then

            param = command.Parameters.AddWithValue("@tipo", 1)

        End If

        If rviaje.Checked Then

            param = command.Parameters.AddWithValue("@tipo", 2)
            param = command.Parameters.AddWithValue("@viaje", txt_param.Text)

        End If

        If runidad.Checked Then

            param = command.Parameters.AddWithValue("@tipo", 3)
            param = command.Parameters.AddWithValue("@unidad", txt_param.Text)

        End If

        If roperador.Checked Then

            param = command.Parameters.AddWithValue("@tipo", 4)
            param = command.Parameters.AddWithValue("@operador", txt_param.Text)

        End If

        Try

            oDa = New SqlClient.SqlDataAdapter(command)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            grid_evaluacion.DataSource = oDs.Tables(0)
            Celdas()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Cursor = Cursors.Arrow

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    Private Sub bto_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_excel.Click

        Excel.gridToExcel(grid_evaluacion)

    End Sub

    Public Sub Celdas()

        grid_evaluacion.Columns(0).ReadOnly = True
        grid_evaluacion.Columns(1).ReadOnly = True
        grid_evaluacion.Columns(2).ReadOnly = True
        grid_evaluacion.Columns(3).ReadOnly = True
        grid_evaluacion.Columns(4).ReadOnly = True
        grid_evaluacion.Columns(5).ReadOnly = True
        grid_evaluacion.Columns(6).ReadOnly = True
        grid_evaluacion.Columns(7).ReadOnly = True
        grid_evaluacion.Columns(8).ReadOnly = True
        grid_evaluacion.Columns(9).ReadOnly = True
        grid_evaluacion.Columns(10).ReadOnly = True
        grid_evaluacion.Columns(11).ReadOnly = True
        grid_evaluacion.Columns(12).ReadOnly = True
        grid_evaluacion.Columns(13).ReadOnly = True
        grid_evaluacion.Columns(14).ReadOnly = True
        grid_evaluacion.Columns(17).ReadOnly = True

    End Sub

    Private Sub bto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_guardar.Click

        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim i As Integer = 0
        cn.Open()

        While grid_evaluacion.Rows.Count > i

            Dim command As New SqlCommand("insert_evaluacion_local", cn)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@id_combustible", grid_evaluacion.Rows(i).Cells(0).Value.ToString)
            command.Parameters.AddWithValue("@unida", grid_evaluacion.Rows(i).Cells(1).Value.ToString)
            command.Parameters.AddWithValue("@cant_combustible", grid_evaluacion.Rows(i).Cells(2).Value)
            command.Parameters.AddWithValue("@viaje", grid_evaluacion.Rows(i).Cells(3).Value)
            command.Parameters.AddWithValue("@tipo_viaje", grid_evaluacion.Rows(i).Cells(4).Value.ToString)
            command.Parameters.AddWithValue("@fec_modif", grid_evaluacion.Rows(i).Cells(5).Value)
            command.Parameters.AddWithValue("@observaciones_lis", grid_evaluacion.Rows(i).Cells(6).Value)
            command.Parameters.AddWithValue("@km_reset", grid_evaluacion.Rows(i).Cells(7).Value)
            command.Parameters.AddWithValue("@litros_lis", grid_evaluacion.Rows(i).Cells(8).Value)
            command.Parameters.AddWithValue("@litros_reset", grid_evaluacion.Rows(i).Cells(9).Value)
            command.Parameters.AddWithValue("@dif_litros", grid_evaluacion.Rows(i).Cells(10).Value)
            command.Parameters.AddWithValue("@faltante_ajuste", grid_evaluacion.Rows(i).Cells(11).Value)
            command.Parameters.AddWithValue("@rend_reset", grid_evaluacion.Rows(i).Cells(12).Value)
            command.Parameters.AddWithValue("@rend_real_calculado", grid_evaluacion.Rows(i).Cells(13).Value)
            command.Parameters.AddWithValue("@descuento", grid_evaluacion.Rows(i).Cells(14).Value)
            command.Parameters.AddWithValue("@porcentaje", grid_evaluacion.Rows(i).Cells(15).Value)
            command.Parameters.AddWithValue("@observaciones", grid_evaluacion.Rows(i).Cells(16).Value)
            command.Parameters.AddWithValue("@total_desc", grid_evaluacion.Rows(i).Cells(17).Value)

            Try

                command.ExecuteNonQuery()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            i = i + 1

        End While

        cn.Close()
        MessageBox.Show("Proceso Terminado")

    End Sub

    Private Sub grid_evaluacion_RowLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid_evaluacion.CellEndEdit

        If e.ColumnIndex = 14 Then

            Dim valor As Double = grid_evaluacion.Rows(e.RowIndex).Cells(14).Value
            valor = (grid_evaluacion.Rows(e.RowIndex).Cells(13).Value) - ((grid_evaluacion.Rows(e.RowIndex).Cells(13).Value) / (valor))
            grid_evaluacion.Rows(e.RowIndex).Cells(16).Value = valor

        End If
    End Sub

    Private Sub grid_evaluacion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_evaluacion.SelectionChanged

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim command As New SqlCommand("up_hist_evaluacion_local", cn)
        command.CommandType = CommandType.StoredProcedure
        cn.Open()

        Try

            command.Parameters.AddWithValue("@unidad", grid_evaluacion.CurrentRow.Cells(1).Value.ToString)
            command.Parameters.AddWithValue("mes", txt_meses.Text)
            oDa = New SqlClient.SqlDataAdapter(command)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            grid_his.DataSource = oDs.Tables(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormEvaluacionLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rfecha.Checked = True
    End Sub
End Class