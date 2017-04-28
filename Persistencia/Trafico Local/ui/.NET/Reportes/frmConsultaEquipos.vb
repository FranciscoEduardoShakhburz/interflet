Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient

Public Class frmConsultaEquipos
    Private conn As SqlConnection
    Private command As SqlCommand
    Private param As SqlParameter
    Private dataAdapter As SqlDataAdapter
    Private dataTable As System.Data.DataTable



#Region "Loader de formulario"

    Private Sub frmConsultaEquipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gridUbicacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.gridResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.llenarCombos()
        Me.conn = Connection.getInstance.getConnection()
    End Sub
#End Region
#Region "Combos Hardcodeados"
    Private Sub llenarCombos()
        Me.cmbEquipo.Items.Add("TODO LOS EQUIPOS")
        Me.cmbEquipo.Items.Add("TRACTOR")
        Me.cmbEquipo.Items.Add("DOLLY")
        Me.cmbEquipo.Items.Add("REMOLQUES")
        Me.cmbEquipo.Items.Add("CONTENEDOR")
        Me.cmbEquipo.Items.Add("CAMIONETAS")
        Me.cmbEquipo.SelectedIndex = 0

        Me.cmbUbicacion.Items.Add("TODOS")
        Me.cmbUbicacion.Items.Add("PATIO DA")
        Me.cmbUbicacion.Items.Add("PATIO EXTERNO")
        Me.cmbUbicacion.Items.Add("PATIO MANZANILLO")
        Me.cmbUbicacion.Items.Add("FUERDA DA")
        Me.cmbUbicacion.SelectedIndex = 0
    End Sub
#End Region
#Region "Salir"
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
#End Region


#Region "Búsqueda de Equipos parametrizada"
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.command = New SqlClient.SqlCommand("sp_Consulta_Equipos", Me.conn)

            Me.param = Me.command.Parameters.Add("@TipoEquipo", SqlDbType.Int)
            Me.param.Value = Me.cmbEquipo.SelectedIndex

            Me.param = Me.command.Parameters.Add("@Estatus", SqlDbType.Int)
            Me.param.Value = Convert.ToString(Me.chkBajas.CheckState()).Trim()

            Me.param = Me.command.Parameters.Add("@Lugar", SqlDbType.Int)
            Me.param.Value = Me.cmbUbicacion.SelectedIndex

            Me.param = Me.command.Parameters.Add("@Dato", SqlDbType.VarChar)
            Me.param.Value = Me.txtDescripcion.Text.Trim()

            Me.command.CommandType = CommandType.StoredProcedure

            Me.dataAdapter = New SqlClient.SqlDataAdapter(command)
            Me.dataTable = New System.Data.DataTable()
            Me.dataAdapter.Fill(Me.dataTable)


            Me.gridResultado.DataSource = Me.dataTable

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            Cursor = Cursors.Arrow
            Me.command.Dispose()
            Me.dataAdapter.Dispose()
            Me.dataTable.Dispose()
            Me.conn.Close()
        End Try
    End Sub
#End Region
#Region "Muestra de Ubicación Real basada en selección de Equipo (Al seleccionar una fila y recorrer la tabla (gridview))"
    Private Sub gridResultado_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridResultado.SelectionChanged
        Try
            Dim sql As String = ""

            If Me.gridResultado.Rows.Count > 0 Then

                If Me.gridResultado.CurrentRow().Cells(0).Value.ToString().Trim().Equals("DOLLY") Then
                    sql = "Select * from trafico_registros where DOLLY = '" & Me.gridResultado.CurrentRow().Cells(2).Value.ToString().Trim() & "'"
                ElseIf Me.gridResultado.CurrentRow().Cells(0).Value.ToString().Trim().Equals("REMOLQUE") Then
                    sql = "Select * from trafico_registros where REMOLQUE1 = '" & Me.gridResultado.CurrentRow().Cells(2).Value.ToString().Trim() & "' or REMOLQUE2 = '" & Me.gridResultado.CurrentRow().Cells(2).Value.ToString().Trim() & "'"
                Else
                    sql = "SELECT * FROM trafico_registros WHERE unidad = '" & Me.gridResultado.CurrentRow().Cells(2).Value.ToString().Trim() & "'"
                End If
                sql = sql & " order by fecha desc,hora desc"


                Me.dataAdapter = New SqlClient.SqlDataAdapter(sql, Me.conn)
                Dim dataSet As New DataSet
                Me.dataAdapter.Fill(dataSet)
                Me.gridUbicacion.DataSource = dataSet.Tables(0)

                dataSet.Dispose()
                dataAdapter.Dispose()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
#End Region


#Region "Exportar a Excel"
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Cursor = Cursors.WaitCursor
        If Me.gridResultado.RowCount > 0 Then
            Excel.gridToExcel(Me.gridResultado)
        End If
        Cursor = Cursors.Arrow
    End Sub
#End Region
End Class