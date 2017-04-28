Imports System.Data.SqlClient

Public Class frmEvaluacionviaje

    Dim celPorcAplicar, celTotDescto, celAplicaDescReset, celAplicaDescRend, celAplicaDescFalt As Integer
    Dim celDesctoRend, celDesctoReset, celFaltanteAjuste As Integer
    Private ciudad As Integer

    Private Sub frmEvaluacionviaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        Me.getCiudades()
        Limpiar()
        Me.grdEvaluacion.RowHeadersWidth = 4
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub Limpiar()

        Me.TxtViaje.Text = "0"
        Me.TxtCliente.Text = ""
        Me.cmbFecIni.Value = DateTime.Today
        Me.cmbFecFin.Value = DateTime.Today
        Me.TxtSemana.Text = "0"
        Me.cmbArea.SelectedItem = "Altamira"

    End Sub

    Private Function Validar() As Boolean
        If Me.cmbFecIni.Value > Me.cmbFecFin.Value Then

            MsgBox("La fecha final no puede ser anterior a la fecha inicial", MsgBoxStyle.Exclamation, Me.Text)
            Me.cmbFecFin.Focus()
            Return False

        End If

        Return True

    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim celleval, celnoviaje, celDifLtsReset, celLtsEstandar, celDifLtsRend As Integer
        Dim celRendReset, celRendRealCalc As Integer
        Dim celJustificacion As Integer

        If Me.grdEvaluacion.Columns.Count > 0 Then

            celleval = grdEvaluacion.Columns("Evaluado").Index
            celnoviaje = grdEvaluacion.Columns("Viaje").Index
            celDifLtsReset = grdEvaluacion.Columns("Dif en Lts Reset").Index
            celLtsEstandar = grdEvaluacion.Columns("Lts Estandar").Index
            celDifLtsRend = grdEvaluacion.Columns("Dif Lts X Rend").Index
            celRendReset = grdEvaluacion.Columns("RendReset").Index
            celRendRealCalc = grdEvaluacion.Columns("RendRealCalculado").Index
            celFaltanteAjuste = grdEvaluacion.Columns("Faltante con Ajuste").Index
            celJustificacion = grdEvaluacion.Columns("Justificacion").Index

        End If
        Try

            For Each row As DataGridViewRow In grdEvaluacion.Rows
                If row.Cells(celleval).Value = True Then

                    Guardar(CInt(row.Cells(celnoviaje).Value), _
                    CDbl(IIf(IsDBNull(row.Cells(celDifLtsReset).Value), 0, row.Cells(celDifLtsReset).Value)), _
                    CDbl(IIf(IsDBNull(row.Cells(celLtsEstandar).Value), 0, row.Cells(celLtsEstandar).Value)), _
                    CDbl(IIf(IsDBNull(row.Cells(celDifLtsRend).Value), 0, row.Cells(celDifLtsRend).Value)), _
                    CDbl(IIf(IsDBNull(row.Cells(celDesctoRend).Value), 0, row.Cells(celDesctoRend).Value)), _
                    CDbl(IIf(IsDBNull(row.Cells(celRendReset).Value), 0, row.Cells(celRendReset).Value)), _
                    CDbl(IIf(IsDBNull(row.Cells(celDesctoReset).Value), 0, row.Cells(celDesctoReset).Value)), _
                    CDbl(IIf(IsDBNull(row.Cells(celRendRealCalc).Value), 0, row.Cells(celRendRealCalc).Value)), _
                    CDbl(IIf(IsDBNull(row.Cells(celFaltanteAjuste).Value), 0, row.Cells(celFaltanteAjuste).Value)), _
                    IIf(IsDBNull(row.Cells(celAplicaDescReset).Value), Nothing, CByte(row.Cells(celAplicaDescReset).Value)), _
                    IIf(IsDBNull(row.Cells(celAplicaDescRend).Value), Nothing, CByte(row.Cells(celAplicaDescRend).Value)), _
                    IIf(IsDBNull(row.Cells(celAplicaDescFalt).Value), Nothing, CByte(row.Cells(celAplicaDescFalt).Value)), _
                    row.Cells(celJustificacion).Value.ToString().Trim(), _
                    IIf(IsDBNull(row.Cells(celPorcAplicar).Value), Nothing, CDbl(row.Cells(celPorcAplicar).Value)))

                End If
            Next

            MessageBox.Show("Datos guardados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
            btnBuscar2_Click(sender, e)

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub Guardar(ByVal NoViaje2 As Integer, ByVal DifLtsReset2 As Decimal, ByVal LtsEstandar2 As Decimal, ByVal DifLtsRend2 As Decimal, _
    ByVal DesctoRend2 As Decimal, ByVal RendReset2 As Decimal, ByVal DesctoReset2 As Decimal, ByVal RendRealCalc2 As Decimal, _
    ByVal FaltanteAjuste2 As Decimal, ByVal AplicaDescReset2 As Boolean, ByVal AplicaDescRend2 As Boolean, ByVal AplicaDescFalt2 As Boolean, ByVal Justificacion2 As String, ByVal PorcAplicar2 As Decimal)

        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Try

            Dim oDa As SqlClient.SqlDataAdapter
            Dim oDs As System.Data.DataSet
            Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
            Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("UP_Guarda_Evaluacion", oConexion)
            oCommand.CommandType = CommandType.StoredProcedure
            oCommand.CommandTimeout = 2000
            oConexion.Open()

            Dim oParameter As SqlClient.SqlParameter

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = NoViaje2
            oParameter = oCommand.Parameters.Add("@DifLtsReset", SqlDbType.Decimal)
            oParameter.Value = DifLtsReset2
            oParameter = oCommand.Parameters.Add("@LtsEstandar", SqlDbType.Decimal)
            oParameter.Value = LtsEstandar2
            oParameter = oCommand.Parameters.Add("@DifLtsRend", SqlDbType.Decimal)
            oParameter.Value = DifLtsRend2
            oParameter = oCommand.Parameters.Add("@DesctoRend", SqlDbType.Money)
            oParameter.Value = DesctoRend2
            oParameter = oCommand.Parameters.Add("@RendReset", SqlDbType.Decimal)
            oParameter.Value = RendReset2
            oParameter = oCommand.Parameters.Add("@DesctoReset", SqlDbType.Money)
            oParameter.Value = DesctoReset2
            oParameter = oCommand.Parameters.Add("@RendRealCalc", SqlDbType.Decimal)
            oParameter.Value = RendRealCalc2
            oParameter = oCommand.Parameters.Add("@FaltanteAjuste", SqlDbType.Decimal)
            oParameter.Value = FaltanteAjuste2
            oParameter = oCommand.Parameters.Add("@AplicaDescReset", SqlDbType.Bit)
            oParameter.Value = AplicaDescReset2
            oParameter = oCommand.Parameters.Add("@AplicaDescRend", SqlDbType.Bit)
            oParameter.Value = AplicaDescRend2
            oParameter = oCommand.Parameters.Add("@aplicaDescFalt", SqlDbType.Bit)
            oParameter.Value = AplicaDescFalt2
            oParameter = oCommand.Parameters.Add("@Justificacion", SqlDbType.VarChar)
            oParameter.Value = Justificacion2
            oParameter = oCommand.Parameters.Add("@PorcAplicar", SqlDbType.Decimal)
            oParameter.Value = PorcAplicar2 / 100
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oConexion.Close()
            oConexion.Dispose()
            oCommand.Dispose()

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        Finally

            Cursor = System.Windows.Forms.Cursors.Default

        End Try
    End Sub

    Private Sub btnBuscar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar2.Click

        Cursor = Cursors.WaitCursor
        Me.BuscarViajes()
        Cursor = Cursors.Arrow

    End Sub

    Public Sub BuscarViajes()

        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_Consulta_Evaluacion", conn)
        Dim param As SqlParameter

        command.CommandType = CommandType.StoredProcedure
        command.CommandTimeout = 120000
        conn.Open()
        param = command.Parameters.AddWithValue("@NoViaje", Convert.ToInt32(Me.TxtViaje.Text.Trim()))
        param = command.Parameters.AddWithValue("@Cliente", Me.TxtCliente.Text.Trim())
        param = command.Parameters.AddWithValue("@Semana", Convert.ToInt32(Me.TxtSemana.Text.Trim()))
        param = command.Parameters.AddWithValue("@FecIni", Me.cmbFecIni.Value.Date)
        param = command.Parameters.AddWithValue("@FecFin", Me.cmbFecFin.Value.Date)
        param = command.Parameters.AddWithValue("@Operador", Me.TxtOperador.Text.Trim())
        param = command.Parameters.AddWithValue("@Area", Me.ciudad)
        param = command.Parameters.AddWithValue("@Unidad", Me.txtUnidad.Text.Trim())
        param = command.Parameters.AddWithValue("@Justificacion", Me.txtJustificacion.Text.Trim())
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.grdEvaluacion.DataSource = oDs.Tables(0)
        celFaltanteAjuste = grdEvaluacion.Columns("Faltante con Ajuste").Index
        celPorcAplicar = grdEvaluacion.Columns("% Aplicar").Index
        celTotDescto = grdEvaluacion.Columns("Tot Descto").Index
        celAplicaDescReset = grdEvaluacion.Columns("AplicaDescReset").Index
        celAplicaDescRend = grdEvaluacion.Columns("AplicaDescRend").Index
        celAplicaDescFalt = grdEvaluacion.Columns("aplicaDescFaltante").Index
        celDesctoRend = grdEvaluacion.Columns("Descto x rend").Index
        celDesctoReset = grdEvaluacion.Columns("Descto X Reset").Index
        Me.grdEvaluacion.Columns(celTotDescto).ReadOnly = True

        For i As Integer = 0 To Me.grdEvaluacion.Columns.Count - 1

            Me.grdEvaluacion.Columns(i).Width = 50  'anteriormente tenia 50

        Next

        Me.getTomato()

    End Sub

    Private Sub getTomato()

        For i As Integer = 0 To Me.grdEvaluacion.Rows.Count - 1
            If IsDBNull(Me.grdEvaluacion.Rows(i).Cells(16).Value) Then

                Me.grdEvaluacion.Rows(i).DefaultCellStyle.BackColor = Color.Tomato

            End If
        Next
    End Sub

    Private Sub grdEvaluacion_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEvaluacion.CurrentCellDirtyStateChanged

        'Aplica descuentos
        If Me.grdEvaluacion.CurrentCell.ColumnIndex = celPorcAplicar Then

            Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = False

            If Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescReset).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoReset).Value)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            ElseIf Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescRend).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoRend).Value)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            ElseIf Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescFalt).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * (Me.grdEvaluacion.CurrentRow.Cells(celFaltanteAjuste).Value) * 13.77)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            End If
        End If

        If Me.grdEvaluacion.CurrentCell.ColumnIndex = celAplicaDescReset And Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value <> 0 Then

            Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = False

            If Convert.ToBoolean(grdEvaluacion.CurrentRow.Cells(celAplicaDescReset).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoReset).Value)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            ElseIf Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescRend).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoRend).Value)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            ElseIf Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescFalt).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * (Me.grdEvaluacion.CurrentRow.Cells(celFaltanteAjuste).Value) * 14.0)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            End If
        End If

        If Me.grdEvaluacion.CurrentCell.ColumnIndex = celAplicaDescRend And Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value <> 0 Then

            Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = False

            If Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescReset).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoReset).Value)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            ElseIf Convert.ToBoolean(grdEvaluacion.CurrentRow.Cells(celAplicaDescRend).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = ((Convert.ToDouble(Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value) / 100) * Convert.ToDouble(Me.grdEvaluacion.CurrentRow.Cells(celDesctoRend).Value))
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            ElseIf Convert.ToBoolean(grdEvaluacion.CurrentRow.Cells(celAplicaDescFalt).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * (Me.grdEvaluacion.CurrentRow.Cells(celFaltanteAjuste).Value) * 14.0)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            End If
        End If
    End Sub

#Region "Utilerías & Excel"

    Private Sub cmbArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.SelectedIndexChanged

        If Me.cmbArea.SelectedItem = "Altamira" Then

            Me.ciudad = 1

        ElseIf Me.cmbArea.SelectedItem = "Manzanillo" Then

            Me.ciudad = 2

        Else

            Me.ciudad = 3

        End If
    End Sub


    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor = Cursors.WaitCursor
        Excel.gridToExcel(Me.grdEvaluacion)
        Cursor = Cursors.Arrow

    End Sub


    Private Sub getCiudades()

        Me.cmbArea.Items.Add("Altamira")
        Me.cmbArea.Items.Add("Manzanillo")
        Me.cmbArea.Items.Add("Veracruz")

    End Sub
#End Region

    Private Sub grdEvaluacion_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdEvaluacion.ColumnHeaderMouseClick

        Me.getTomato()

    End Sub

    Private Sub grdEvaluacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEvaluacion.CellDoubleClick

        Dim plaza As Integer
        Dim client As Integer
        Dim dest As Integer
        Cursor = Cursors.WaitCursor

        If e.ColumnIndex = 5 Then
            If Not String.IsNullOrEmpty(Me.grdEvaluacion.Rows(e.RowIndex).Cells(4).Value.ToString()) Then

                Dim viaje As String = Me.grdEvaluacion.Rows(e.RowIndex).Cells(4).Value.ToString()
                Dim unidad As String = Me.grdEvaluacion.Rows(e.RowIndex).Cells("Unidad").Value.ToString()
                Dim fechaInicial As String = Me.grdEvaluacion.Rows(e.RowIndex).Cells("Fec Ini Viaje").Value.ToString()
                Dim fechaFinal As String = Me.grdEvaluacion.Rows(e.RowIndex).Cells("Fec Fin Viaje").Value.ToString()
                Dim formularioCasetas As New formCasetasEvaluacion(viaje, Me.ciudad, unidad, fechaInicial, fechaFinal)
                formularioCasetas.ShowDialog()

            End If
        End If

        If e.ColumnIndex = 17 Then 'Abrir el catalogo de Rendimiento Promedio.
            If Not String.IsNullOrEmpty(Me.grdEvaluacion.Rows(e.RowIndex).Cells(4).Value.ToString()) Then

                Dim cn As New SqlConnection
                Dim command As SqlCommand
                Dim reg As SqlDataReader
                Dim viaje As Integer = Me.grdEvaluacion.Rows(e.RowIndex).Cells(4).Value.ToString()
                Dim peso As Integer = Me.grdEvaluacion.Rows(e.RowIndex).Cells(7).Value.ToString()
                cn = Connection.getInstance().getConnection()
                command = New SqlCommand("SELECT a.id_origen,a.id_cliente,b.id_ruta FROM DATOSVIAJE a,trafico_viaje b where a.id_num_viaje = b.no_viaje  and a.id_num_viaje = " & viaje, cn)
                command.CommandType = CommandType.Text
                command.CommandTimeout = 600
                cn.Open()
                reg = command.ExecuteReader

                If reg.HasRows Then

                    reg.Read()
                    plaza = reg.GetValue(0)
                    client = reg.GetValue(1)
                    dest = reg.GetValue(2)
                    Dim formRendEss As New frmRendEstSuge()
                    formRendEss.noviaje = viaje
                    formRendEss.peso = peso
                    formRendEss.clin = Me.grdEvaluacion.Rows(e.RowIndex).Cells(2).Value.ToString()
                    formRendEss.dest = Me.grdEvaluacion.Rows(e.RowIndex).Cells(1).Value.ToString()
                    formRendEss.area = Me.cmbArea.Text
                    formRendEss.Show()
                    Dim formularioRendimientos As New frmCatRendmientosProm()
                    MessageBox.Show(plaza)
                    formularioRendimientos.plaza = plaza
                    formularioRendimientos.client = client
                    formularioRendimientos.dest = dest
                    formularioRendimientos.lol = 2
                    formularioRendimientos.Show()

                Else

                    MessageBox.Show("Coloque CP Correcta")

                End If
            End If
        End If

        Cursor = Cursors.Arrow

    End Sub

    Private Sub btnReporteDiesel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteDiesel.Click

        Cursor = Cursors.WaitCursor
        Dim reporteDiesel As formReporteEvaluacion = New formReporteEvaluacion( _
            Convert.ToInt32(Me.TxtViaje.Text.Trim()), _
            Me.TxtCliente.Text.Trim(), _
            Me.TxtSemana.Text.Trim(), _
            Me.cmbFecIni.Value.ToString("dd/MM/yyyy"), _
            Me.cmbFecFin.Value.ToString("dd/MM/yyyy"), _
            Me.TxtOperador.Text.Trim(), _
            Me.ciudad, _
            Me.txtUnidad.Text.Trim(), _
            Me.txtJustificacion.Text.Trim)
        Cursor = Cursors.Arrow
        reporteDiesel.Show()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub
End Class