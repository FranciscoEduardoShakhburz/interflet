Imports System.Data.SqlClient

Public Class formLiquidaciones

    Private liquidacion As Integer
    Private operador As String
    Private unidad As String
    Private ruta As String
    Private ciudad As Integer
    Private viaje As Integer
    Private maniobras As Double
    Private cliente As String
    Private fechaInicial As DateTime
    Private fechaFinal As DateTime
    Private dataset As DataSet

#Region "Load"
    Private Sub formLiquidaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.gridResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.gridCasetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.gridCartas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.gridAnticipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.gridExtras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.gridGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.getCiudades()
        Me.txtViaje.Text = "0"
        Me.unidad = "0"
        Me.operador = "0"
        Me.ciudad = 1
        Me.maniobras = 0.0
        Me.cliente = ""
        Me.cmbCiudad.SelectedItem = "Altamira"
        Me.fechaInicial = DateTime.Today
        Me.fechaFinal = DateTime.Today
        Me.dataset = New DataSet()

    End Sub
#End Region

#Region "Consulta a Base de datos"
#Region "Búsqueda de Liquidaciones"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If Me.txtViaje.Text.Length > 0 Then

            Cursor = Cursors.WaitCursor
            Me.operador = Me.txtOperador.Text.Trim.Trim()
            Me.fechaInicial = Me.cmbFechaInicial.Value
            'Me.fechaInicial = Me.cmbFechaInicial.Text
            Me.fechaFinal = Me.cmbFechaFinal.Value
            'Me.fechaFinal = Me.cmbFechaFinal.Text
            Me.viaje = Convert.ToInt32(Me.txtViaje.Text.Trim())
            Me.unidad = Me.txtUnidad.Text.Trim()

            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim command As SqlCommand = New SqlCommand("spGetLiquidaciones", conn)
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            With command.Parameters

                .AddWithValue("@VIAJE", viaje)
                .AddWithValue("@UNIDAD", unidad)
                .AddWithValue("@OPERADOR", operador)
                .AddWithValue("@CIUDAD", ciudad)
                .AddWithValue("@FECHAINICIAL", fechaInicial)
                .AddWithValue("@FECHAFINAL", fechaFinal)

            End With

            'Dim param As SqlParameter
            'param = command.Parameters.AddWithValue("@VIAJE", viaje)
            'param = command.Parameters.AddWithValue("@UNIDAD", unidad)
            'param = command.Parameters.AddWithValue("@OPERADOR", operador)
            'param = command.Parameters.AddWithValue("@CIUDAD", ciudad)
            'param = command.Parameters.AddWithValue("@FECHAINICIAL", fechaInicial)
            'param = command.Parameters.AddWithValue("@FECHAFINAL", fechaFinal)

            Dim adapter As New SqlDataAdapter(command)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet)
            Me.gridResultado.DataSource = dataSet.Tables(0)
            Cursor = Cursors.Arrow

        End If
    End Sub
#End Region
#Region "Detalle de Liquidación por Número de Liquidación Área"

    Private Sub gridResultado_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridResultado.SelectionChanged

        Cursor = Cursors.WaitCursor

        If Me.gridResultado.Rows.Count > 0 Then

            Me.dataset = getTables("UP_CONSULTA_DETALLALIQUIDACION")

            If Me.dataset.Tables().Count > 0 Then

                Me.gridCasetas.DataSource = dataset.Tables(0)
                Me.gridCartas.DataSource = dataset.Tables(1)
                Me.gridAnticipos.DataSource = dataset.Tables(2)
                Me.gridExtras.DataSource = dataset.Tables(3)
                Me.gridGastos.DataSource = dataset.Tables(4)
                Me.unidad = Me.gridResultado.CurrentRow().Cells("ID_UNIDAD").Value.ToString().Trim()
                Me.ruta = Me.gridResultado.CurrentRow().Cells("DESC_RUTA").Value.ToString().Trim()

            End If
        End If

        Cursor = Cursors.Arrow

    End Sub
#End Region
#End Region

    Private Function getTables(ByVal procedimiento As String) As DataSet

        Me.viaje = Me.gridResultado.CurrentRow().Cells("NO_VIAJE").Value.ToString().Trim()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand(procedimiento, conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataSet As New DataSet()
        Dim param As SqlParameter

        command.CommandType = CommandType.StoredProcedure
        conn.Open()
        param = command.Parameters.AddWithValue("@AREA", Me.ciudad)
        param = command.Parameters.AddWithValue("@NO_VIAJE", Me.viaje)
        adapter.Fill(dataSet)

        Return dataSet

    End Function

#Region "Utilerías"

    Public Sub getCiudades()

        Me.cmbCiudad.Items.Add("Altamira")
        Me.cmbCiudad.Items.Add("Manzanillo")
        Me.cmbCiudad.Items.Add("Veracruz")

    End Sub

    Private Sub cmbCiudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCiudad.SelectedIndexChanged

        If Me.cmbCiudad.SelectedItem = "Altamira" Then

            Me.ciudad = 1

        ElseIf Me.cmbCiudad.SelectedItem = "Manzanillo" Then

            Me.ciudad = 2

        Else

            Me.ciudad = 3

        End If
    End Sub

#Region "Exportar a Excel General"
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Me.exportar(Me.gridResultado)

    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click

        If Me.gridExtras.Rows.Count > 0 Then

            Me.maniobras = Convert.ToDouble(Me.gridExtras.CurrentRow.Cells("MONTO_MANIOBRAS").Value.ToString().Trim())
            Me.cliente = Me.gridExtras.CurrentRow.Cells("CLIENTE").Value.ToString().Trim()

        End If

        Excel.gridDetalleLiquidacion(Me.dataset, Me.viaje, Me.unidad, Me.ruta, Me.maniobras, Me.cliente)

    End Sub

    Private Sub exportar(ByVal grid As DataGridView)

        Cursor = Cursors.WaitCursor

        If grid.Rows.Count > 0 Then

            Excel.gridToExcel(grid)

        Else

            MessageBox.Show("No existe información para exportar")

        End If

        Cursor = Cursors.Arrow

    End Sub

#End Region

#End Region
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub
End Class
