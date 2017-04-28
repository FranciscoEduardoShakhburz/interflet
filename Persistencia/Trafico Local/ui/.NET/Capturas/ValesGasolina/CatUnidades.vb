Imports System.Data
Imports System.Data.SqlClient

Public Class CatUnidades

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim uni As Unidad = New Unidad()
        uni.ShowDialog(Me)
        Me.cargarUnidades()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Me.eliminarRegistros()
        Me.cargarUnidades()

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Dim uni As Unidad = New Unidad(Me.gridUnidades.SelectedRows(0).Cells("eco").Value.ToString())
        uni.ShowDialog(Me)
        Me.cargarUnidades()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub cargarUnidades()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String
        Dim indice As Integer = 0

        Try

            consulta = "SELECT economico, marca, modelo, numSerie, año FROM Trafico_Unidad_Agencia "
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet
            sDA.Fill(dS)
            comando.Dispose()
            conexion.Dispose()
            conexion.Close()
            Me.gridUnidades.Rows.Clear()

            If dS.Tables(0).Rows.Count > 0 Then
                For Each unidad As DataRow In dS.Tables(0).Rows

                    indice = Me.gridUnidades.Rows.Add()
                    Me.gridUnidades.Rows(indice).Cells("eco").Value = unidad("economico")
                    Me.gridUnidades.Rows(indice).Cells("marca").Value = unidad("marca")
                    Me.gridUnidades.Rows(indice).Cells("modelo").Value = unidad("modelo")
                    Me.gridUnidades.Rows(indice).Cells("numSerie").Value = unidad("numSerie")
                    Me.gridUnidades.Rows(indice).Cells("año").Value = unidad("año")

                Next
            End If
        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error al consultar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub eliminarRegistros()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try
            For Each unidad As DataGridViewRow In Me.gridUnidades.SelectedRows

                consulta = "DELETE FROM Trafico_Unidad_Agencia WHERE economico = '" & unidad.Cells("eco").Value.ToString() & "'"
                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                comando.ExecuteNonQuery()
                comando.Dispose()
                conexion.Dispose()
                conexion.Close()

            Next

            MessageBox.Show("Los registros se eliminaron satisfactoriamente", "¡Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub CatUnidades_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarUnidades()

    End Sub
End Class