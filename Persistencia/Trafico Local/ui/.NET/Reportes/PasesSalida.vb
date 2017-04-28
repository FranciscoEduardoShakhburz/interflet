Imports System.Data.SqlClient

Public Class PasesSalida

    Private Sub PasesSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim comando As SqlCommand = New SqlCommand("up_pases_salida", cn)

        With comando.Parameters

            .AddWithValue("@fechaDesde", Me.dteDesde.Value.ToString("yyyy-MM-dd"))
            .AddWithValue("@fechaHasta", Me.dteHasta.Value.ToString("yyyy-MM-dd"))

        End With

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandTimeout = 1000
        cn.Open()
        oDa = New SqlClient.SqlDataAdapter(comando)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        Me.grid.DataSource = oDs.Tables(0)
        cn.Close()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click
        Me.Close()
    End Sub

    Private Sub bto_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_excel.Click
        Excel.gridToExcel(grid)
    End Sub

    Private Sub bto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim sql As String = ""
        Dim i As Integer = 0

        While grid.Rows.Count > i
            cn.Open()
            sql = "UPDATE trafico_referencia_folio SET estatus = '" & grid.Rows(i).Cells(9).Value & "' WHERE folio = '" & grid.Rows(i).Cells(0).Value.ToString & "' AND contenedor = '" & grid.Rows(i).Cells(4).Value.ToString & "'"
            Dim command As New SqlCommand(sql, cn)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()
            i = i + 1
            cn.Close()
        End While
        MessageBox.Show("Proceso Terminado")

    End Sub

    Private Sub bto_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_consultar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim comando As SqlCommand = New SqlCommand("up_pases_salida", cn)

        With comando.Parameters

            .AddWithValue("@fechaDesde", Me.dteDesde.Value.ToString("yyyy-MM-dd"))
            .AddWithValue("@fechaHasta", Me.dteHasta.Value.ToString("yyyy-MM-dd"))

        End With

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandTimeout = 1000
        cn.Open()
        oDa = New SqlClient.SqlDataAdapter(comando)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        Me.grid.DataSource = oDs.Tables(0)
        cn.Close()
        Cursor.Current = Cursors.Arrow

    End Sub
End Class