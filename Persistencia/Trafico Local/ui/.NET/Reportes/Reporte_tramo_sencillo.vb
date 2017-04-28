Imports System.Data.SqlClient
Public Class Reporte_tramo_sencillo

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click

        Me.Close()

    End Sub


    Private Sub bto_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_consultar.Click

        Cursor = Cursors.WaitCursor
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        cn.Open()
        Dim command As New SqlCommand("up_reporte_tramo_sencillo", cn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@fec", cmb_fec.Value.Date)
        command.CommandTimeout = 6000
        Dim oDa As SqlDataAdapter = New SqlDataAdapter(command)
        Dim oDs As DataSet = New DataSet()
        oDa.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then

            grid.DataSource = oDs.Tables(0)
            cn.Close()
            Cursor = Cursors.Arrow

        Else

            cn.Close()
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("No se encontraron registros", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub bto_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_excel.Click

        Cursor.Current = Cursors.WaitCursor
        Excel.gridToExcel(grid)
        Cursor.Current = Cursors.Arrow

    End Sub
End Class