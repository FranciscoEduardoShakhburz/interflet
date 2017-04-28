Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Data

Public Class formEvaluacionViaje

    Dim celPorcAplicar, celTotDescto, celAplicaDescReset, celAplicaDescRend As Integer
    Dim celDesctoRend, celDesctoReset As Integer
    Private ciudad As Integer

    Private Sub frmEvaluacionviaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.getCiudades()
        Limpiar()
        Me.grdEvaluacion.RowHeadersWidth = 4

    End Sub

    Private Sub Limpiar()

        Me.TxtViaje.Text = "0"
        Me.TxtCliente.Text = ""
        Me.cmbFecIni.Value = DateTime.Today
        Me.cmbFecFin.Value = DateTime.Today
        Me.TxtSemana.Text = "0"
        Me.cmbArea.SelectedItem = "Altamira"

    End Sub

#Region "Acceso a Datos"
#Region "Guardar"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim celleval, celnoviaje, celDifLtsReset, celLtsEstandar, celDifLtsRend As Integer
        Dim celRendReset, celRendRealCalc, celFaltanteAjuste As Integer
        Dim celJustificacion As Integer

        celleval = grdEvaluacion.Columns("Evaluado").Index
        celnoviaje = grdEvaluacion.Columns("Viaje").Index
        celDifLtsReset = grdEvaluacion.Columns("Dif en Lts Reset").Index
        celLtsEstandar = grdReset.Columns("Lts Estandar").Index
        celDifLtsRend = grdReset.Columns("Dif Lts X Rend").Index
        celRendReset = grdEvaluacion.Columns("RendReset").Index
        celRendRealCalc = grdEvaluacion.Columns("RendRealCalculado").Index
        celFaltanteAjuste = grdEvaluacion.Columns("Faltante con Ajuste").Index
        celJustificacion = grdReset.Columns("Justificacion").Index

        Try

            For i As Integer = 0 To grdEvaluacion.Rows.Count - 1
                If Me.grdEvaluacion.Rows(i).Cells(celleval).Value = True Then

                    Guardar(CInt(Me.grdEvaluacion.Rows(i).Cells(celnoviaje).Value), _
                    CDbl(IIf(IsDBNull(Me.grdEvaluacion.Rows(i).Cells(celDifLtsReset).Value), 0, Me.grdEvaluacion.Rows(i).Cells(celDifLtsReset).Value)), _
                    CDbl(IIf(IsDBNull(Me.grdReset.Rows(i).Cells(celLtsEstandar).Value), 0, Me.grdReset.Rows(i).Cells(celLtsEstandar).Value)), _
                    CDbl(IIf(IsDBNull(Me.grdReset.Rows(i).Cells(celDifLtsRend).Value), 0, Me.grdReset.Rows(i).Cells(celDifLtsRend).Value)), _
                    CDbl(IIf(IsDBNull(Me.grdReset.Rows(i).Cells(celDesctoRend).Value), 0, Me.grdReset.Rows(i).Cells(celDesctoRend).Value)), _
                    CDbl(IIf(IsDBNull(Me.grdEvaluacion.Rows(i).Cells(celRendReset).Value), 0, Me.grdEvaluacion.Rows(i).Cells(celRendReset).Value)), _
                    CDbl(IIf(IsDBNull(Me.grdReset.Rows(i).Cells(celDesctoReset).Value), 0, Me.grdReset.Rows(i).Cells(celDesctoReset).Value)), _
                    CDbl(IIf(IsDBNull(Me.grdEvaluacion.Rows(i).Cells(celRendRealCalc).Value), 0, Me.grdEvaluacion.Rows(i).Cells(celRendRealCalc).Value)), _
                    CDbl(IIf(IsDBNull(Me.grdEvaluacion.Rows(i).Cells(celFaltanteAjuste).Value), 0, Me.grdEvaluacion.Rows(i).Cells(celFaltanteAjuste).Value)), _
                    IIf(IsDBNull(Me.grdEvaluacion.Rows(i).Cells(celAplicaDescReset).Value), Nothing, CByte(Me.grdEvaluacion.Rows(i).Cells(celAplicaDescReset).Value)), _
                    IIf(IsDBNull(Me.grdEvaluacion.Rows(i).Cells(celAplicaDescRend).Value), Nothing, CByte(Me.grdEvaluacion.Rows(i).Cells(celAplicaDescRend).Value)), _
                    Me.grdReset.Rows(i).Cells(celJustificacion).Value.ToString().Trim(), _
                    IIf(IsDBNull(Me.grdReset.Rows(i).Cells(celPorcAplicar).Value), Nothing, CDbl(Me.grdReset.Rows(i).Cells(celPorcAplicar).Value)))

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
    ByVal FaltanteAjuste2 As Decimal, ByVal AplicaDescReset2 As Boolean, ByVal AplicaDescRend2 As Boolean, ByVal Justificacion2 As String, ByVal PorcAplicar2 As Decimal)

        Cursor = System.Windows.Forms.Cursors.WaitCursor

        Try

            Dim oDa As SqlClient.SqlDataAdapter
            Dim oDs As System.Data.DataSet
            Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
            Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("UP_Guarda_Evaluacion", oConexion)
            Dim oParameter As SqlClient.SqlParameter
            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
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
            oParameter = oCommand.Parameters.Add("@Justificacion", SqlDbType.VarChar)
            oParameter.Value = Justificacion2
            oParameter = oCommand.Parameters.Add("@PorcAplicar", SqlDbType.Decimal)
            oParameter.Value = PorcAplicar2 / 100
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        Finally

            Cursor = System.Windows.Forms.Cursors.Default

        End Try
    End Sub
#End Region
#Region "Buscar"
    Private Sub btnBuscar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar2.Click

        Cursor = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_Consulta_Evaluacion2", conn)
        Dim param As SqlParameter
        command.CommandType = CommandType.StoredProcedure
        command.CommandTimeout = 60000
        conn.Open()
        param = command.Parameters.AddWithValue("@NoViaje", Convert.ToInt32(Me.TxtViaje.Text.Trim()))
        param = command.Parameters.AddWithValue("@Cliente", Me.TxtCliente.Text.Trim())
        param = command.Parameters.AddWithValue("@Semana", Me.TxtSemana.Text.Trim())
        param = command.Parameters.AddWithValue("@FecIni", Me.cmbFecIni.Value.Date)
        param = command.Parameters.AddWithValue("@FecFin", Me.cmbFecFin.Value.Date)
        param = command.Parameters.AddWithValue("@Operador", Me.TxtOperador.Text.Trim())
        param = command.Parameters.AddWithValue("@Area", Me.ciudad)
        param = command.Parameters.AddWithValue("@Unidad", Me.txtUnidad.Text.Trim())
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.grdEvaluacion.DataSource = oDs.Tables(0)
        Me.grdReset.DataSource = oDs.Tables(1)
        celPorcAplicar = grdReset.Columns("% Aplicar").Index
        celTotDescto = grdReset.Columns("Tot Descto").Index()
        celAplicaDescReset = grdEvaluacion.Columns("AplicaDescReset").Index
        celAplicaDescRend = grdEvaluacion.Columns("AplicaDescRend").Index
        celDesctoRend = grdReset.Columns("Descto x Rend").Index
        celDesctoReset = grdReset.Columns("Descto X Reset").Index
        Me.grdEvaluacion.Columns(celTotDescto).ReadOnly = True
        Me.grdEvaluacion.Columns("Faltante con Ajuste").Frozen = True

        For i As Integer = 0 To Me.grdEvaluacion.Columns.Count - 1

            Me.grdEvaluacion.Columns(i).Width = 50

        Next

        For i As Integer = 0 To Me.grdReset.Columns.Count - 1

            Me.grdReset.Columns(i).Width = 50

        Next

        Me.getTomato()
        Cursor = Cursors.Arrow

    End Sub
#End Region
#End Region

#Region "Operaciones en el Grid (Rendimientos)"
    Private Sub grdEvaluacion_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEvaluacion.CurrentCellDirtyStateChanged

        If Me.grdEvaluacion.CurrentCell.ColumnIndex = celPorcAplicar Then

            Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = False

            If Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescReset).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoReset).Value)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            Else

                If Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescRend).Value) = True Then

                    Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoRend).Value)
                    Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

                End If
            End If
        End If

        If Me.grdEvaluacion.CurrentCell.ColumnIndex = celAplicaDescReset And Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value <> 0 Then

            Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = False

            If Convert.ToBoolean(grdEvaluacion.CurrentRow.Cells(celAplicaDescReset).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoReset).Value)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            Else

                If Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescRend).Value) = True Then

                    Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoRend).Value)
                    Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

                End If
            End If
        End If

        If Me.grdEvaluacion.CurrentCell.ColumnIndex = celAplicaDescRend And Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value <> 0 Then

            Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = False

            If Convert.ToBoolean(Me.grdEvaluacion.CurrentRow.Cells(celAplicaDescReset).Value) = True Then

                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = CDbl((Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value / 100) * Me.grdEvaluacion.CurrentRow.Cells(celDesctoReset).Value)
                Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

            Else

                If Convert.ToBoolean(grdEvaluacion.CurrentRow.Cells(celAplicaDescRend).Value) = True Then

                    Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).Value = ((Convert.ToDouble(Me.grdEvaluacion.CurrentRow.Cells(celPorcAplicar).Value) / 100) * Convert.ToDouble(Me.grdEvaluacion.CurrentRow.Cells(celDesctoRend).Value))
                    Me.grdEvaluacion.CurrentRow.Cells(celTotDescto).ReadOnly = True

                End If
            End If
        End If
    End Sub
#End Region

#Region "Utilerías & Excel"
    Private Function Validar() As Boolean

        If Me.cmbFecIni.Value > Me.cmbFecFin.Value Then

            MsgBox("La fecha final no puede ser anterior a la fecha inicial", MsgBoxStyle.Exclamation, Me.Text)
            Me.cmbFecFin.Focus()
            Return False

        End If

        Return True

    End Function

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
        Excel.twoGridToExcel(Me.grdEvaluacion, Me.grdReset)
        Cursor = Cursors.Arrow

    End Sub


    Private Sub getCiudades()

        Me.cmbArea.Items.Add("Altamira")
        Me.cmbArea.Items.Add("Manzanillo")
        Me.cmbArea.Items.Add("Veracruz")

    End Sub
#End Region

#Region "Búsqueda y Ordenamiento en GridReset"

    Private Sub grdEvaluacion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEvaluacion.CellClick

        If Me.grdEvaluacion.Rows.Count > 0 Then

            Dim viajeEvaluacion As String = Me.grdEvaluacion.CurrentRow.Cells("Viaje").Value.ToString().Trim()

            If Me.grdReset.Rows.Count > 0 Then

                Me.grdReset.ClearSelection()
                Dim viajeReset As String = ""

                For i As Integer = 0 To Me.grdReset.Rows.Count - 2

                    viajeReset = Me.grdReset.Rows(i).Cells("Viaje").Value.ToString()

                    If viajeEvaluacion = viajeReset Then

                        Me.grdReset.Rows(i).Selected = True
                        Me.grdReset.FirstDisplayedScrollingRowIndex = i

                    End If
                Next
            End If
        End If
    End Sub


    Private Sub grdEvaluacion_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEvaluacion.Sorted

        If Me.grdEvaluacion.Rows.Count > 0 AndAlso Me.grdReset.Rows.Count > 0 Then

            Dim posicionNueva As Integer = 0
            Dim dataTable As DataTable = CType(Me.grdReset.DataSource, DataTable).Clone()
            Dim tablaReset As DataTable = CType(Me.grdReset.DataSource, DataTable)

            For Each filaEvaluacion As DataGridViewRow In Me.grdEvaluacion.Rows
                For Each filaReset As DataGridViewRow In Me.grdReset.Rows

                    posicionNueva = filaReset.Index

                    If filaEvaluacion.Cells("Viaje").Value.ToString().Trim = filaReset.Cells("Viaje").Value.ToString().Trim Then

                        dataTable.ImportRow(tablaReset.Rows(posicionNueva))

                        Exit For
                    End If
                Next
            Next

            Me.grdReset.DataSource = dataTable

        End If
    End Sub
#End Region


    Private Sub grdEvaluacion_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdEvaluacion.ColumnHeaderMouseClick

        Me.getTomato()

    End Sub

    Private Sub grdReset_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdReset.ColumnHeaderMouseClick

        Me.getTomato()

    End Sub

    Private Sub getTomato() 'Fuck yeah! 8^)

        Dim viaje As String = ""

        For i As Integer = 0 To Me.grdReset.Rows.Count - 1

            viaje = Me.grdReset.Rows(i).Cells("Viaje").Value.ToString.Trim

            If IsDBNull(Me.grdReset.Rows(i).Cells("Rend. Estandar").Value) Then

                Me.grdReset.Rows(i).DefaultCellStyle.BackColor = Color.Tomato

                For j As Integer = 0 To Me.grdEvaluacion.Rows.Count - 1
                    If viaje = Me.grdEvaluacion.Rows(j).Cells("Viaje").Value.ToString.Trim Then

                        Me.grdEvaluacion.Rows(j).DefaultCellStyle.BackColor = Color.Tomato()

                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub grdEvaluacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEvaluacion.CellContentClick

    End Sub
End Class