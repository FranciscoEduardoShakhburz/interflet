Imports System.Data
Imports System.Data.SqlClient

Public Class UnidadesSiniestradas

    Private Sub UnidadesSiniestradas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.consultarInformacion()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim capt As CapUniSiniestradas = New CapUniSiniestradas()
        capt.ShowDialog(Me)
        Me.consultarInformacion()

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Dim capt As CapUniSiniestradas = New CapUniSiniestradas(Me.dGVUnidades.SelectedRows(0).Cells("colUnidad").Value.ToString())
        capt.ShowDialog(Me)
        Me.consultarInformacion()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Me.eliminar()
        Me.consultarInformacion()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub consultarInformacion()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim unidad As DataGridViewRow
        Dim consulta As String

        Try

            Me.dGVUnidades.Rows.Clear()
            consulta = "SELECT unidad, observaciones FROM Trafico_Unidades_Siniestradas"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            dS = New DataSet()
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each uni As DataRow In dS.Tables(0).Rows

                        unidad = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Add())
                        unidad.Cells("colUnidad").Value = uni("unidad").ToString()
                        unidad.Cells("colObservaciones").Value = uni("observaciones").ToString()

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub eliminar()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim unidad As DataGridViewRow
        Dim consulta As String

        Try

            consulta = "DELETE FROM Trafico_Unidades_Siniestradas WHERE unidad = '" & Me.dGVUnidades.SelectedRows(0).Cells("colUnidad").Value.ToString() & "'"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al eliminar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class