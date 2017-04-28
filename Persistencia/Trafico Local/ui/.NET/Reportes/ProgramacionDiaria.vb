Imports System.Data.SqlClient
Public Class ProgramacionDiaria

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click
        Me.Close()
    End Sub


    Private Sub ProgramacionDiaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim sql As String = "SELECT a.* FROM trafico_referencia_folio a, trafico_reporte_programacion b WHERE a.referencia = b.referencia and b.tipo_pro = 1 and a.fecha = (CONVERT (char(10), getdate(), 103)) order by a.prioridad"
        Dim command As New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        Dim oDa As SqlDataAdapter = New SqlDataAdapter(command)
        Dim oDs As DataSet = New DataSet()
        oDa.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then

            grid.DataSource = oDs.Tables(0)
            Cursor.Current = Cursors.Arrow

        Else

            MessageBox.Show("No se encontraron registros", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub bto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_guardar.Click

        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim i As Integer = 0
        cn.Open()

        While grid.Rows.Count > i

            Dim command As New SqlCommand("update trafico_referencia_folio set prioridad = " & grid.Rows(i).Cells(9).Value.ToString & " where referencia = '" & grid.Rows(i).Cells(0).Value.ToString & "' and contenedor = '" & grid.Rows(i).Cells(1).Value.ToString & "'", cn)
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()
            i = i + 1

        End While

        MessageBox.Show("Proceso Terminado")

    End Sub

End Class