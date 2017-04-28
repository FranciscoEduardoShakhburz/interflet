Imports System.Data
Imports System.Data.SqlClient

Public Class OperadoresDisponibles

    Private Sub OperadoresDisponibles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.consultarUltimoCatalogo()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim agregar As AgregarOperador
        agregar = New AgregarOperador(Me)
        agregar.ShowDialog(Me)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.guardarCatalogo()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Dim oper As AgregarOperador
        oper = New AgregarOperador(Me.dGVOperadores.SelectedRows(0))
        oper.ShowDialog()

    End Sub

    Private Sub guardarCatalogo()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_OperadoresDisponibles_Insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            For Each operador As DataGridViewRow In Me.dGVOperadores.Rows

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("UP_OperadoresDisponibles_Detalle_Insert", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 600

                With comando.Parameters

                    .AddWithValue("@idOperador", operador.Cells("colOperador").Value.ToString())
                    .AddWithValue("@modalidad", operador.Cells("colModalidad").Value.ToString())
                    .AddWithValue("@nombre", operador.Cells("colNombreOperador").Value.ToString())
                    .AddWithValue("@unidadAsignada", operador.Cells("colUnidadAsignada").Value.ToString())
                    .AddWithValue("@observaciones", operador.Cells("colObservaciones").Value.ToString())
                    .AddWithValue("@disponible", operador.Cells("colDisponible").Value.ToString())

                End With

                conexion.Open()
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            Next

            MessageBox.Show("El catalago se guardó exitosamente: ", "¡Guardado correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error al guardar el catálogo: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub consultarUltimoCatalogo()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim ope As DataGridViewRow
        Dim consulta As String

        Try

            consulta = "DECLARE @idRegistro INT SET @idRegistro = (SELECT TOP(1) idRegistro FROM Trafico_Operadores_Disponibles ORDER BY fecha DESC) SELECT * FROM Trafico_Operadores_Disponibles_Detalle WHERE idRegistro = @idRegistro"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            For Each operador As DataRow In dS.Tables(0).Rows

                ope = Me.dGVOperadores.Rows(Me.dGVOperadores.Rows.Add())
                ope.Cells("colOperador").Value = operador("idOperador").ToString()
                ope.Cells("colModalidad").Value = operador("modalidad").ToString()
                ope.Cells("colNombreOperador").Value = operador("nombre").ToString()
                ope.Cells("colUnidadAsignada").Value = operador("unidadAsignada").ToString()
                ope.Cells("colObservaciones").Value = operador("observaciones").ToString()
                ope.Cells("colDisponible").Value = operador("disponible").ToString()
                Me.dGVOperadores.Update()

            Next
        Catch ex As Exception

            MessageBox.Show("Error al consultar el catálogo: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class