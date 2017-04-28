Imports System.Data
Imports System.Data.SqlClient

Public Class SeleccionarFechaMod

    Private referencia As String
    Private contenedor As String

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sql As String

        Try

            sql = "UPDATE trafico_reporte_programacion SET fechaModulacion = '" & Me.dteFecha.Value.ToString("dd/MM/yyyy") & "', despachado = 1 WHERE REFERENCIA = '" & Me.referencia & "' AND  CONTENEDOR = '" & Me.contenedor & "'"
            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            comando.ExecuteNonQuery()
            comando.Dispose()
            conexion.Dispose()
            Me.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub

    Public Sub modReferencia(ByVal ref As String)

        Me.referencia = ref

    End Sub

    Public Sub modContenedor(ByVal con As String)

        Me.contenedor = con

    End Sub
End Class