Imports System.Data.SqlClient

Public Class formReporteGastos

    Private Sub formReporteGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getConfigViaje()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_GASTOS_RUTA", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@RUTA", Me.txtRuta.Text.Trim)
        command.Parameters.AddWithValue("@CONFIG_VIAJE", DirectCast(Me.comboConfigViaje.SelectedItem, TipoViaje).Tipo)
        command.Parameters.AddWithValue("@OPERADOR", Me.txtOperador.Text.Trim)
        command.Parameters.AddWithValue("@UNIDAD", Me.txtUnidad.Text.Trim)
        command.Parameters.AddWithValue("@FECHA_INICIAL", Me.dateFechaInicial.Value.ToString("dd/MM/yyyy"))
        command.Parameters.AddWithValue("@FECHA_FINAL", Me.dateFechaFinal.Value.ToString("dd/MM/yyyy"))
        conn.Open()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridGastos.DataSource = table
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Cursor = Cursors.WaitCursor
        Excel.gridToExcel(Me.gridGastos)
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub getConfigViaje()
        For Each configViaje As TipoViaje In TipoViajeDAO.getListTiposViaje()
            Me.comboConfigViaje.Items.Add(configViaje)
        Next
        Me.comboConfigViaje.SelectedIndex = 0
    End Sub

End Class