Imports System.Data.SqlClient

Public Class formCasetasEvaluacion

    Private noViaje As String
    Private ciudad As Integer
    Private cruzoTodas As Boolean
    Private unidad As String
    Private fechaInicial As String
    Private fechaFinal As String


    Public Sub New(ByVal noViaje As String, ByVal ciudad As Integer, ByVal unidad As String, ByVal fechaInicial As String, ByVal fechaFinal As String)
        InitializeComponent()
        Me.noViaje = noViaje
        Me.ciudad = ciudad
        Me.cruzoTodas = False
        Me.lblNoViaje.Text = noViaje
        Me.unidad = unidad
        Me.fechaInicial = fechaInicial
        Me.fechaFinal = fechaFinal
        Me.getCasetas()
        Me.getCasetasIAVE()
        Me.getCasetasSatelital()
    End Sub

    Private Sub getCasetas()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As New SqlCommand("UP_CONSULTA_CASETASVIAJE", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@NO_VIAJE", Me.noViaje)
        conn.Open()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim dataTable As New DataTable()
        adapter.SelectCommand = command
        adapter.Fill(dataTable)
        Me.gridCasetas.DataSource = dataTable
        adapter.Dispose()
        conn.Close()
    End Sub

    Private Sub getCasetasIAVE()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As New SqlCommand("UP_CONSULTA_CASETASIAVE", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@UNIDAD", Me.unidad)
        command.Parameters.AddWithValue("@FECHA_INICIAL", Convert.ToDateTime(Me.fechaInicial))
        command.Parameters.AddWithValue("@FECHA_FINAL", Convert.ToDateTime(Me.fechaFinal))
        command.Parameters.AddWithValue("@VIAJE", Me.noViaje)
        conn.Open()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim dataTable As New DataTable()
        adapter.SelectCommand = command
        adapter.Fill(dataTable)
        Me.gridIAVE.DataSource = dataTable
        adapter.Dispose()
        conn.Close()
    End Sub

    Private Sub getCasetasSatelital()
        Dim conn As SqlConnection = Connection.getInstance().getConnectionQFS()
        Dim command As New SqlCommand("UP_Consulta_CasetasSatelital", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@UNIDAD", Me.unidad)
        command.Parameters.AddWithValue("@FECINIVIAJE", Convert.ToDateTime(Me.fechaInicial))
        command.Parameters.AddWithValue("@FECFINVIAJE", Convert.ToDateTime(Me.fechaFinal))
        conn.Open()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim dataTable As New DataTable()
        command.CommandTimeout = 600
        adapter.SelectCommand = command
        adapter.Fill(dataTable)
        Me.gridSatelital.DataSource = dataTable
        adapter.Dispose()
        conn.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "update datosviaje set cruzo_todas = @cruzoTodas where id_num_viaje = @viaje and id_area = @ciudad"
        Dim command As New SqlCommand(sql, conn)
        command.CommandType = CommandType.Text
        command.Parameters.AddWithValue("@cruzoTodas", Me.cruzoTodas)
        command.Parameters.AddWithValue("@viaje", Me.noViaje)
        command.Parameters.AddWithValue("@ciudad", Me.ciudad)
        conn.Open()
        command.ExecuteNonQuery()
        frmEvaluacionviaje.BuscarViajes()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub checkCruzoTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCruzoTodas.CheckedChanged
        Me.cruzoTodas = Me.checkCruzoTodas.Checked
    End Sub
End Class