Imports System.Data.SqlClient
Imports System.Collections.Generic


Public Class formReporteEvaluacion

    Private data As DataSet

    Public Sub New( _
        ByVal viaje As String, _
        ByVal cliente As String, _
        ByVal semana As String, _
        ByVal fechaInicial As String, _
        ByVal fechaFinal As String, _
        ByVal operador As String, _
        ByVal ciudad As Integer, _
        ByVal unidad As String, _
        ByVal justificacion As String)
        InitializeComponent()
        Me.lblFechaInicial.Text = "Fecha Inicial: " & fechaInicial
        Me.lblFechaFinal.Text = "Fecha Final: " & fechaFinal

        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_DETALLE_EVALUACION", conn)

        command.CommandType = CommandType.StoredProcedure
        command.CommandTimeout = 5000
        conn.Open()

        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@NoViaje", viaje)
        param = command.Parameters.AddWithValue("@Cliente", cliente)
        param = command.Parameters.AddWithValue("@Semana", semana)
        param = command.Parameters.AddWithValue("@FecIni", fechaInicial)
        param = command.Parameters.AddWithValue("@FecFin", fechaFinal)
        param = command.Parameters.AddWithValue("@Operador", operador)
        param = command.Parameters.AddWithValue("@Area", ciudad)
        param = command.Parameters.AddWithValue("@Unidad", unidad)
        param = command.Parameters.AddWithValue("@Justificacion", justificacion)

        oDa = New SqlDataAdapter(command)
        Me.data = New DataSet()
        oDa.Fill(data)
        Me.gridDescuentoRendimiento.DataSource = Me.data.Tables(0)
        Me.gridTotalDescuento.DataSource = Me.data.Tables(1)
        Me.gridTiempoEnBaja.DataSource = Me.data.Tables(2)
        Me.gridExcesoVelocidad.DataSource = Me.data.Tables(3)
        Me.gridSobreRevoluciones.DataSource = Me.data.Tables(4)
        Me.gridTiempoArriba.DataSource = Me.data.Tables(5)
        Me.gridDescolgadas.DataSource = Me.data.Tables(6)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Excel.datasetToExcel(Me.data)
    End Sub

    Private Sub gridDescuentoRendimiento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridDescuentoRendimiento.KeyDown
        Cursor = Cursors.WaitCursor
        If Me.gridDescuentoRendimiento.Rows.Count > 0 AndAlso e.KeyCode = Keys.Delete Then
            Dim filas_seleccionadas As DataGridViewSelectedRowCollection = Me.gridDescuentoRendimiento.SelectedRows
            Dim viaje As String = ""
            For Each fila As DataGridViewRow In filas_seleccionadas
                viaje = fila.Cells("VIAJE").Value.ToString()
                Me.gridDescuentoRendimiento.Rows.Remove(fila)
                Me.eliminarViajeEnOtrosGrids(Me.gridTotalDescuento, viaje)
                Me.eliminarViajeEnOtrosGrids(Me.gridTiempoEnBaja, viaje)
                Me.eliminarViajeEnOtrosGrids(Me.gridExcesoVelocidad, viaje)
                Me.eliminarViajeEnOtrosGrids(Me.gridSobreRevoluciones, viaje)
                Me.eliminarViajeEnOtrosGrids(Me.gridTiempoArriba, viaje)
                Me.eliminarViajeEnOtrosGrids(Me.gridDescolgadas, viaje)
            Next
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub eliminarViajeEnOtrosGrids(ByVal grid As DataGridView, ByVal viaje As String)
        If grid.Rows.Count > 0 Then
            For Each row As DataGridViewRow In grid.Rows
                If row.Cells("VIAJE").Value = viaje Then
                    grid.Rows.Remove(row)
                End If
            Next
        End If
    End Sub
End Class