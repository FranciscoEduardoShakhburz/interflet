Imports System.Data.SqlClient

Public Class formContenedores

    Private Sub formContenedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getData(formIngresoEIR.fechaActual)
    End Sub


    Private Sub getData(ByVal fecha As String)
        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_LOCALES_CONTENEDORES", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FECHA", fecha)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim data As DataSet = New DataSet()
        adapter.Fill(data)
        Me.gridProgramacion.DataSource = data.Tables(0)
        Me.gridRegistros.DataSource = data.Tables(1)
        conn.Close()
        conn.Dispose()
        command.Dispose()
    End Sub

    Private Sub gridProgramacion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridProgramacion.DoubleClick
        Dim contenedor As String = Me.gridProgramacion.CurrentRow.Cells("OBSERVACIONES").Value.ToString()
        If contenedor.Contains("CAJA") OrElse contenedor.Contains("CARGA") Then
            contenedor = ""
        Else
            contenedor = (contenedor.Replace("CONT.", "").Trim).Substring(0, 13)
        End If

        formIngresoEIR.txtContenedor.Text = contenedor
    End Sub

    Private Sub gridRegistros_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRegistros.CellDoubleClick
        Dim contenedor As String = ""
        If e.ColumnIndex = 2 OrElse e.ColumnIndex = 3 Then
            contenedor = Me.gridRegistros.CurrentRow.Cells(e.ColumnIndex).Value.ToString()
            contenedor = IIf(contenedor.Contains("CAJA") OrElse contenedor.Contains("CARGA"), "", contenedor)

        End If
        formIngresoEIR.txtContenedor.Text = contenedor.Trim
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    End Sub
End Class