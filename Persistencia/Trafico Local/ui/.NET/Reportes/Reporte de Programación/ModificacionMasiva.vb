Imports System.Data.SqlClient

Public Class ModificacionMasiva

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim cont, ref As String
        Dim nFilas As Int16
        Dim cambOp As CambiarOperador

        Cursor.Current = Cursors.AppStarting

        If String.IsNullOrEmpty(Me.txtBusqueda.Text) Or Me.gridCargas.Rows.Count = 0 Then

            MessageBox.Show("Primero realice una consulta", "No se puede completar la acción", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If

        If Not String.IsNullOrEmpty(Me.txtNoVisita.Text) OrElse Not String.IsNullOrEmpty(Me.txtOperador.Text) OrElse Not String.IsNullOrEmpty(Me.txtPlacas.Text) OrElse Not String.IsNullOrEmpty(Me.txtUnidad.Text) OrElse Not String.IsNullOrEmpty(Me.txtTerminal.Text) Then

            Try

                For Each carga As DataGridViewRow In Me.gridCargas.Rows

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand("up_actualizar_operador_visita", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000

                    With comando.Parameters

                        .AddWithValue("@referencia", carga.Cells(1).Value.ToString())
                        .AddWithValue("@contenedor", carga.Cells(2).Value.ToString())
                        .AddWithValue("@nombre", Me.txtOperador.Text)
                        .AddWithValue("@unidad", Me.txtUnidad.Text)
                        .AddWithValue("@folio", Me.txtNoVisita.Text)
                        .AddWithValue("@fecha", Me.dteFecha.Value.ToString("dd/MM/yyyy"))
                        .AddWithValue("@hora", Me.cmbHoras.SelectedItem.ToString() & ":" & Me.cmbMinutos.SelectedItem.ToString())
                        .AddWithValue("@terminal", Me.txtTerminal.Text)
                        .AddWithValue("@fechaTraslado", Me.dteFechaTraslado.Value.ToString("dd/MM/yyyy"))
                        .AddWithValue("@tipo", 2)
                        .AddWithValue("@bloque", Me.txtBloque.Text)

                    End With

                    comando.ExecuteNonQuery()
                    comando.Dispose()
                    conexion.Dispose()

                    If Me.txtTerminal.Text.Equals("DAH") Then

                        sql = "UPDATE trafico_reporte_programacion SET despachado = 1 WHERE REFERENCIA = '" & carga.Cells(1).Value.ToString() & "' AND CONTENEDOR = '" & carga.Cells(2).Value.ToString() & "' AND TIPO_PRO IN (2, 3)"
                        conexion = Connection.getInstance().getConnection()
                        conexion.Open()
                        comando = New SqlCommand(sql, conexion)
                        comando.CommandType = CommandType.Text
                        comando.CommandTimeout = 1000
                        comando.ExecuteNonQuery()
                        comando.Dispose()
                        conexion.Dispose()

                    End If
                Next

                MessageBox.Show("Los datos de modificaron correctamente.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else

            MessageBox.Show("Debe insertar el nombre del operador y la unidad", "No se puede completar la acción", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim res As DialogResult = MessageBox.Show("¿Esta seguro que desea eliminar " & Me.gridCargas.SelectedRows.Count & " elemento(s)?", "¡Confirme!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If res = Windows.Forms.DialogResult.Yes Then
            For Each carga As DataGridViewRow In Me.gridCargas.SelectedRows

                Me.gridCargas.Rows.Remove(carga)

            Next
        End If
    End Sub

    Private Sub gridCargas_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridCargas.RowEnter

        Me.btnEliminar.Enabled = True

    End Sub

    Private Sub ModificacionMasiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.rdBtnForaneos.Checked = True
        Me.rdBtnReferencia.Checked = True
        Me.gridCargas.DataSource = Nothing
        Me.resultadosDeBusqueda()
        Me.llenarCombos()
        Me.cmbHoras.SelectedIndex = 0
        Me.cmbMinutos.SelectedIndex = 0

    End Sub

    Private Sub resultadosDeBusqueda()

        Dim autoCompletado = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre FROM personal_personal"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtOperador.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub llenarCombos()

        For i As Integer = 0 To 2
            For j As Integer = 0 To 9
                If i = 2 AndAlso j = 4 Then

                    Exit For

                Else

                    Me.cmbHoras.Items.Add(i & "" & j)

                End If
            Next
        Next

        For i As Integer = 0 To 5
            For j As Integer = 0 To 9

                Me.cmbMinutos.Items.Add(i & "" & j)

            Next
        Next
    End Sub

    Private Sub gridCargas_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridCargas.CellMouseClick

        Me.txtNoVisita.Text = Me.gridCargas.Rows(e.RowIndex).Cells(0).Value.ToString()
        Me.txtOperador.Text = Me.gridCargas.Rows(e.RowIndex).Cells(4).Value.ToString()
        Me.txtPlacas.Text = Me.gridCargas.Rows(e.RowIndex).Cells(6).Value.ToString()
        Me.txtUnidad.Text = Me.gridCargas.Rows(e.RowIndex).Cells(5).Value.ToString()
        Me.txtTerminal.Text = Me.gridCargas.Rows(e.RowIndex).Cells(3).Value.ToString()
        Me.dteFecha.Value = Convert.ToDateTime(Me.gridCargas.Rows(e.RowIndex).Cells(7).Value.ToString())
        Me.cmbHoras.SelectedItem = Me.gridCargas.Rows(e.RowIndex).Cells(8).Value.ToString().Split(":")(0).ToString()
        Me.cmbMinutos.SelectedItem = Me.gridCargas.Rows(e.RowIndex).Cells(8).Value.ToString().Split(":")(1).ToString()
        Me.txtBloque.Text = Me.gridCargas.Rows(e.RowIndex).Cells(9).Value.ToString()

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        If String.IsNullOrEmpty(Me.txtBusqueda.Text) Then

            Me.gridCargas.DataSource = Nothing

        Else
            Try

                Me.gridCargas.DataSource = Nothing
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand("up_buscar_visitas", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000

                With comando.Parameters
                    If Me.rdBtnContenedor.Checked Then

                        .AddWithValue("@contenedor", Me.txtBusqueda.Text)
                        .AddWithValue("@referencia", "")
                        .AddWithValue("@visita", "")
                        .AddWithValue("@boleta", "")

                    ElseIf Me.rdBtnReferencia.Checked Then

                        .AddWithValue("@contenedor", "")
                        .AddWithValue("@referencia", Me.txtBusqueda.Text)
                        .AddWithValue("@visita", "")
                        .AddWithValue("@boleta", "")

                    ElseIf Me.rdBtnVisita.Checked Then

                        .AddWithValue("@contenedor", "")
                        .AddWithValue("@referencia", "")
                        .AddWithValue("@visita", Me.txtBusqueda.Text)
                        .AddWithValue("@boleta", "")

                    ElseIf Me.rdBtnBoleta.Checked Then

                        .AddWithValue("@contenedor", "")
                        .AddWithValue("@referencia", "")
                        .AddWithValue("@visita", "")
                        .AddWithValue("@boleta", Me.txtBusqueda.Text)

                    End If

                    If Me.rdBtnForaneos.Checked Then

                        .AddWithValue("@tipoBusqueda", 1)

                    Else

                        .AddWithValue("@tipoBusqueda", 2)

                    End If
                End With

                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables(0).Rows.Count > 0 Then

                    Me.gridCargas.DataSource = dS.Tables(0)

                End If
            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message & " Rastro de la pila: " & ex.StackTrace & " Fuente: " & ex.Source)

            End Try
        End If
    End Sub

    Private Sub rdBtnBoleta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBtnBoleta.CheckedChanged

        If Me.rdBtnBoleta.Checked Then

            Me.txtOperador.Enabled = False
            Me.txtPlacas.Enabled = False
            Me.txtUnidad.Enabled = False

        Else

            Me.txtOperador.Enabled = True
            Me.txtPlacas.Enabled = True
            Me.txtUnidad.Enabled = True

        End If
    End Sub

    Private Sub txtPlacas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlacas.KeyPress

        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        If Not String.IsNullOrEmpty(Me.txtPlacas.Text) Then
            Try

                sql = "SELECT TOP(1) id_unidad FROM mtto_unidades WHERE REPLACE(REPLACE(placas, ' ', ''), '-', '') LIKE REPLACE(REPLACE('%" & Me.txtPlacas.Text.TrimStart().TrimEnd() & "%', ' ', ''), '-', '') "
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables(0).Rows.Count > 0 Then

                    Me.txtUnidad.Text = dS.Tables(0).Rows(0).Item(0).ToString()

                End If

                conexion.Dispose()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        Else

            Me.txtUnidad.Text = ""

        End If
    End Sub

    Private Sub txtUnidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidad.KeyDown

        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        If Not String.IsNullOrEmpty(Me.txtUnidad.Text) Then
            Try

                sql = "SELECT TOP(1) placas FROM mtto_unidades WHERE REPLACE (REPLACE(id_unidad, ' ', ''), '-', '') LIKE REPLACE(REPLACE('" & Me.txtUnidad.Text.TrimStart().TrimEnd() & "%', ' ', ''), '-', '')"
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables(0).Rows.Count > 0 Then

                    Me.txtPlacas.Text = dS.Tables(0).Rows(0).Item(0).ToString()

                End If

                conexion.Dispose()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        Else

            Me.txtPlacas.Text = ""

        End If
    End Sub
End Class