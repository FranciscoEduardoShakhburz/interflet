Imports System.Data.SqlClient

Public Class frmEvaluacionLocal

    Private tipoViaje As Integer

    Private Sub frmEvaluacionLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        Me.combosTipoViaje()
        Me.cmbTipoViaje.SelectedItem = "Todos"
        Limpiar()
        Me.grdEvaluacion.RowHeadersWidth = 4
        Cursor.Current = Cursors.Arrow

    End Sub

#Region "Combos Hardcodeados"
    Private Sub combosTipoViaje()

        Me.cmbTipoViaje.Items.Add("Todos")
        Me.cmbTipoViaje.Items.Add("Foraneo")
        Me.cmbTipoViaje.Items.Add("Local")
        Me.cmbTipoViaje.Items.Add("Almacen")

    End Sub

    Private Sub cmbTipoViaje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoViaje.SelectedIndexChanged

        If Me.cmbTipoViaje.SelectedItem = "Foraneo" Then

            Me.tipoViaje = 1

        ElseIf Me.cmbTipoViaje.SelectedItem = "Local" Then

            Me.tipoViaje = 2

        ElseIf Me.cmbTipoViaje.SelectedItem = "Almacen" Then

            Me.tipoViaje = 3

        Else

            Me.tipoViaje = 0

        End If
    End Sub
#End Region

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Cursor = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Me.grdEvaluacion.Columns.Clear()
        Me.grdEvaluacion.DataSource = Nothing
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("UP_Consulta_EvaluacionLocal", oConexion)
        'MessageBox.Show("Viaje " & TxtViaje.Text & "  semana " & TxtSemana.Text & "  fecini " & cmbFecIni.Text & "  fecFin " & cmbFecFin.Text & " tipoviaje  " & tipoViaje & " unidad " & txtUnidad.Text.Trim() & "  operador " & txtOperador.Text.Trim())

        Try

            oCommand.CommandType = CommandType.StoredProcedure
            oCommand.CommandTimeout = 5000
            oConexion.Open()
            Dim oParameter As SqlClient.SqlParameter
            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtViaje.Text)
            oParameter = oCommand.Parameters.Add("@Semana", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtSemana.Text)
            oParameter = oCommand.Parameters.Add("@FecIni", SqlDbType.DateTime)
            oParameter.Value = Me.cmbFecIni.Value
            oParameter = oCommand.Parameters.Add("@FecFin", SqlDbType.DateTime)
            oParameter.Value = Me.cmbFecFin.Value
            oParameter = oCommand.Parameters.Add("@TipoViaje", SqlDbType.TinyInt)
            oParameter.Value = Me.tipoViaje
            oParameter = oCommand.Parameters.Add("@Unidad", SqlDbType.VarChar)
            oParameter.Value = Me.txtUnidad.Text.Trim()
            oParameter = oCommand.Parameters.Add("@Operador", SqlDbType.VarChar)
            oParameter.Value = Me.txtOperador.Text.Trim()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            If oDs.Tables.Count > 0 Then

                Me.grdEvaluacion.DataSource = oDs.Tables(0)

                For i As Integer = 0 To Me.grdEvaluacion.Columns.Count - 6

                    grdEvaluacion.Columns.Item(i).ReadOnly = True

                Next
            End If

            'Me.grdEvaluacion.Columns("KM Final").Frozen = True
            Cursor = Cursors.Arrow
            Me.getConsecutivos()

        Catch ex As Exception

            If ex.Message.ToString().Trim().Contains("división entre cero") Then

                MessageBox.Show("Existe un Viaje con Kilómetros Reales en Cero. Favor de verificar el Reporte")

            End If
        End Try
    End Sub

    Private Sub Limpiar()

        Me.TxtViaje.Text = "0"
        Me.cmbFecIni.Value = DateTime.Today
        Me.cmbFecFin.Value = DateTime.Today
        Me.TxtSemana.Text = "0"

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor = Cursors.WaitCursor
        Excel.gridToExcel(Me.grdEvaluacion)
        Cursor = Cursors.Arrow

    End Sub

    Private Sub grdEvaluacion_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.getConsecutivos()

    End Sub

    Private Sub getConsecutivos()

        If Me.grdEvaluacion.Rows.Count > 0 Then

            Dim anterior As Integer = 0
            Dim actual As Integer = 0

            For i As Integer = 1 To Me.grdEvaluacion.Rows.Count - 2
                If IsNumeric(anterior) AndAlso IsNumeric(actual) Then

                    anterior = Convert.ToInt32(Me.grdEvaluacion.Rows(i - 1).Cells("Consecutivo").Value.ToString.Trim())
                    actual = Convert.ToInt32(Me.grdEvaluacion.Rows(i).Cells("Consecutivo").Value.ToString.Trim())

                    If actual = anterior + 1 Then

                        Me.grdEvaluacion.Rows(i - 1).Cells("Consecutivo").Style.BackColor = Color.LemonChiffon
                        Me.grdEvaluacion.Rows(i).Cells("Consecutivo").Style.BackColor = Color.LemonChiffon

                    End If
                End If
            Next
        End If
    End Sub

    Private Sub grdEvaluacion_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdEvaluacion.ColumnHeaderMouseClick

        Me.getConsecutivos()

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor = Cursors.WaitCursor

        If Me.grdEvaluacion.Rows.Count > 0 Then

            Dim sqlDataAdapter As SqlDataAdapter
            Dim dataSet As DataSet
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim command As SqlCommand = New SqlCommand("UP_Guarda_Evaluacion", conn)
            Dim parameter As SqlParameter
            Dim viaje As String
            Dim diferenciaReset As String
            Dim descuentoReset As String
            Dim rendimientoReal As String
            Dim porcentaje As String
            Dim justificacion As String
            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            For Each row As DataGridViewRow In Me.grdEvaluacion.Rows
                If row.Cells(Me.grdEvaluacion.Columns("Evaluado").Index).Value Then 'Esta el check en evaluado?

                    viaje = row.Cells("Viaje").Value().ToString().Trim()
                    diferenciaReset = row.Cells("Dif en Lts Reset").Value().ToString().Trim()
                    descuentoReset = row.Cells("Descto").Value.ToString().Trim()
                    rendimientoReal = row.Cells("RendRealCalculado").Value.ToString().Trim()
                    porcentaje = row.Cells(Me.grdEvaluacion.Columns("PorcAplicar").Index).Value.ToString().Trim()
                    justificacion = row.Cells(Me.grdEvaluacion.Columns("justificacion").Index).Value.ToString().Trim()

                    If Not ((String.IsNullOrEmpty(porcentaje)) OrElse (String.IsNullOrEmpty(justificacion))) Then

                        command.Parameters.Clear()
                        Parameter = command.Parameters.AddWithValue("@NoViaje", viaje)
                        Parameter = command.Parameters.AddWithValue("@DifLtsReset", diferenciaReset)
                        Parameter = command.Parameters.AddWithValue("@LtsEstandar", 0)
                        Parameter = command.Parameters.AddWithValue("@DifLtsRend", 0)
                        Parameter = command.Parameters.AddWithValue("@DesctoRend", 0)
                        Parameter = command.Parameters.AddWithValue("@RendReset", 0)
                        Parameter = command.Parameters.AddWithValue("@DesctoReset", descuentoReset)
                        Parameter = command.Parameters.AddWithValue("@RendRealCalc", rendimientoReal)
                        Parameter = command.Parameters.AddWithValue("@FaltanteAjuste", 0)
                        Parameter = command.Parameters.AddWithValue("@AplicaDescReset", 0)
                        Parameter = command.Parameters.AddWithValue("@AplicaDescRend", 0)
                        Parameter = command.Parameters.AddWithValue("@PorcAplicar", porcentaje)
                        parameter = command.Parameters.AddWithValue("@Justificacion", justificacion)
                        sqlDataAdapter = New SqlDataAdapter(command)
                        dataSet = New DataSet
                        sqlDataAdapter.Fill(dataSet)

                    Else

                        MessageBox.Show("Porcentaje o Justificación incorrecto en viaje :" & viaje)

                    End If
                End If
            Next
        End If

        MessageBox.Show("Datos Guardados Correctamente")
        Cursor = Cursors.Arrow

    End Sub
End Class