Imports System.Data.SqlClient

Public Class formCasetasIAVE
    Private area As Integer
    Private filtroCasetas As Integer

    Private Sub formCasetasIAVE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbCasetas.SelectedIndex = 0 'TODAS
        Me.cmbSucursal.SelectedIndex = 0 'Ciudades
        Me.txtViaje.Text = "0"
    End Sub

    Private Sub btnBuscarbtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarbtnBuscar.Click
        Me.buscarCasetasIAVE()
    End Sub

    Private Sub buscarCasetasIAVE()

        Cursor = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_CONCILIACION_IAVE", conn)
        command.CommandType = CommandType.StoredProcedure
        command.CommandTimeout = 1000
        conn.Open()
        Dim noViaje As Integer

        If String.IsNullOrEmpty(Me.txtViaje.Text.Trim()) Then

            noViaje = 0

        Else

            noViaje = Convert.ToInt32(Me.txtViaje.Text.Trim())

        End If

        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@NO_VIAJE", noViaje)
        param = command.Parameters.AddWithValue("@UNIDAD", Me.txtUnidad.Text.Trim())
        param = command.Parameters.AddWithValue("@FECHA_INICIAL", Me.cmbFechaInicial.Value.Date)
        param = command.Parameters.AddWithValue("@FECHA_FINAL", Me.cmbFechaFinal.Value.Date)
        param = command.Parameters.AddWithValue("@ESTADO_CASETAS", Me.filtroCasetas)
        param = command.Parameters.AddWithValue("@SUCURSAL", Me.area)
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.gridCasetasIAVE.DataSource = oDs.Tables(0)
        Me.setRowColor()
        Cursor = Cursors.Arrow

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Excel.gridToExcel(Me.gridCasetasIAVE)
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSucursal.SelectedIndexChanged
        If Me.cmbSucursal.SelectedItem = "Altamira" Then
            Me.area = 1
        ElseIf Me.cmbSucursal.SelectedItem = "Manzanillo" Then
            Me.area = 2
        Else
            Me.area = 3
        End If
    End Sub

    Private Sub cmbCasetas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCasetas.SelectedIndexChanged
        If Me.cmbCasetas.SelectedItem = "TODAS" Then
            Me.filtroCasetas = 1
        ElseIf Me.cmbCasetas.SelectedItem = "ACEPTADAS" Then
            Me.filtroCasetas = 2
        ElseIf Me.cmbCasetas.SelectedItem = "CANCELADAS" Then
            Me.filtroCasetas = 3
        Else
            Me.filtroCasetas = 4
        End If
    End Sub


    Private Sub gridCasetasIAVE_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridCasetasIAVE.ColumnHeaderMouseClick
        Me.setRowColor()
    End Sub

    Private Sub setRowColor()
        For i As Integer = 0 To Me.gridCasetasIAVE.Rows.Count - 1
            If IsDBNull(Me.gridCasetasIAVE.Rows(i).Cells("No. Viaje").Value) Then
                Me.gridCasetasIAVE.Rows(i).DefaultCellStyle.BackColor = Color.White()
            ElseIf Me.gridCasetasIAVE.Rows(i).Cells("Aceptado").Value = True Then
                Me.gridCasetasIAVE.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen()
            Else
                Me.gridCasetasIAVE.Rows(i).DefaultCellStyle.BackColor = Color.Tomato()
            End If
        Next
    End Sub

    Private Sub gridCasetasIAVE_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridCasetasIAVE.CellValueChanged
        If e.ColumnIndex() = 8 Then
            Dim isChecked As Boolean = DirectCast(Me.gridCasetasIAVE.Rows(Me.gridCasetasIAVE.CurrentRow.Index).Cells(8).FormattedValue(), Boolean)
            Dim id As String = Me.gridCasetasIAVE.Rows(Me.gridCasetasIAVE.CurrentRow.Index).Cells(0).FormattedValue().ToString()
            Dim observaciones As String = Me.gridCasetasIAVE.Rows(Me.gridCasetasIAVE.CurrentRow.Index).Cells(7).FormattedValue().ToString()


            Dim contrasena As String = InputBox("Contraseña", "Ingrese la contraseña Correcta")
            If contrasena = "123456" Then
                Dim sql As String = ""
                Dim conn As SqlConnection = Connection.getInstance().getConnection()
                If String.IsNullOrEmpty(id) Then
                    conn.Open()
                    Dim command As New SqlCommand("UP_GUARDA_CASETASIAVE", conn)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@NO_VIAJE", -1)
                    command.Parameters.AddWithValue("@ID_UNIDAD", Me.gridCasetasIAVE.Rows(Me.gridCasetasIAVE.CurrentRow.Index).Cells(1).Value.ToString())
                    command.Parameters.AddWithValue("@TARJETA_IAVE", Me.gridCasetasIAVE.Rows(Me.gridCasetasIAVE.CurrentRow.Index).Cells(2).Value.ToString())
                    command.Parameters.AddWithValue("@FECHA", Convert.ToDateTime(Me.gridCasetasIAVE.Rows(Me.gridCasetasIAVE.CurrentRow.Index).Cells(3).Value.ToString()))
                    command.Parameters.AddWithValue("@ACEPTADO", isChecked)
                    command.Parameters.AddWithValue("@ID_AREA", Me.area)
                    command.Parameters.AddWithValue("@CASETA", Me.gridCasetasIAVE.Rows(Me.gridCasetasIAVE.CurrentRow.Index).Cells(4).Value.ToString())
                    command.Parameters.AddWithValue("@ID_TARJETA", 0)
                    command.Parameters.AddWithValue("@OBSERVACIONES", Me.gridCasetasIAVE.Rows(Me.gridCasetasIAVE.CurrentRow.Index).Cells(7).Value.ToString())
                    command.ExecuteNonQuery()
                    conn.Close()
                Else
                    sql = "UPDATE trafico_tarjeta_iave set aceptado = @aceptado, observaciones = @observaciones where id_tarjeta_iave = @id"
                    conn.Open()
                    Dim command As SqlCommand = New SqlCommand(sql, conn)
                    command.CommandType = CommandType.Text
                    command.Parameters.AddWithValue("@aceptado", isChecked)
                    command.Parameters.AddWithValue("@id", id)
                    command.Parameters.AddWithValue("@observaciones", observaciones)
                    command.ExecuteNonQuery()
                    conn.Close()
                End If
                Me.buscarCasetasIAVE()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Cursor.Current = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_CONCILIACION_IAVE_TODOS", conn)
        command.CommandType = CommandType.StoredProcedure
        conn.Open()
        command.CommandTimeout = 600
        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@FECHA_INICIAL", Me.cmbFechaInicial.Value.Date)
        param = command.Parameters.AddWithValue("@FECHA_FINAL", Me.cmbFechaFinal.Value.Date)
        param = command.Parameters.AddWithValue("@ESTADO_CASETAS", Me.filtroCasetas)
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.gridCasetasIAVE.DataSource = oDs.Tables(0)
        Me.setRowColor()
    End Sub
End Class