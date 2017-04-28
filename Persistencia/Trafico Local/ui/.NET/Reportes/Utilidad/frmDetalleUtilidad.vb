Imports System.Data.SqlClient

Public Class frmDetalleUtilidad

    Private Sub frmDetalleUtilidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.gridHistorico.ColumnCount > 0 Then
            For i As Integer = 0 To Me.gridHistorico.Columns.Count - 1
                Me.gridHistorico.Columns(i).Width = 35
            Next
        End If
        Me.getGreen()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gridHistorico.Rows.Count > 0 Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            conn.Open()

            Dim observaciones As String
            Dim departamento As String
            Dim viaje As String

            For Each fila As DataGridViewRow In Me.gridHistorico.Rows
                observaciones = fila.Cells("Observaciones").Value.ToString()
                departamento = fila.Cells("Departamento").Value.ToString()
                viaje = fila.Cells("Viaje").Value.ToString()

                Dim command As SqlCommand = New SqlCommand("UP_GUARDA_VIAJES_BASURA", conn)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@ID_NUM_VIAJE", viaje)
                command.Parameters.AddWithValue("@ID_AREA", frmUtilidadViajes.ciudad)
                command.Parameters.AddWithValue("@BIT_ACTIVO", fila.Cells("¿Basura?").Value)
                command.Parameters.AddWithValue("@DEPARTAMENTO", departamento)
                command.Parameters.AddWithValue("@OBSERVACIONES", observaciones)
                command.ExecuteNonQuery()
            Next
            MessageBox.Show("Viajes Guardados")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.gridHistorico.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Me.gridHistorico.SelectedRows
                If row.Selected Then
                    row.Cells("¿Basura?").Value = Me.CheckBox1.Checked
                End If
            Next
        End If
    End Sub

    Public Sub getGreen()
        If Me.gridHistorico.Rows.Count > 0 Then
            For Each row As DataGridViewRow In Me.gridHistorico.Rows
                If row.Cells("¿Basura?").Value = True Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        End If
    End Sub

    Private Sub gridHistorico_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridHistorico.CellValueChanged
        Dim row As DataGridViewRow = Me.gridHistorico.Rows(e.RowIndex)
        If row.Cells("¿Basura?").Value = True Then
            row.DefaultCellStyle.BackColor = Color.LightGreen
        Else
            row.DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class