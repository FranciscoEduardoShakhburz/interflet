Imports System.Data.SqlClient
Imports System.Data

Public Class AutorizarOperador

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If Me.txtContraseña.Text.ToLower().Equals("fdelatorre4551") OrElse Me.txtContraseña.Text.ToLower().Equals("jmaria9556") Then

            Me.autorizar()

        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub autorizar()

        Dim comando As SqlCommand
        Dim conexion As SqlConnection

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("up_autorizacionOperador_ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@fecha", DateTime.Today.ToString("dd/MM/yyyy"))
                .AddWithValue("@hora", Now.Hour.ToString() & ":" & Now.Minute.ToString())
                .AddWithValue("@operador", Me.txtOperador.Text.TrimEnd().TrimStart())
                .AddWithValue("@unidad", Me.txtUnidad.Text.TrimEnd().TrimStart())

            End With

            comando.ExecuteNonQuery()
            comando.Dispose()
            conexion.Close()
            MessageBox.Show("El operador " & Me.txtOperador.Text & " ha sido autorizado para viajar.", "Autorización correcta", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error al autorizar el operador: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
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

    Private Sub buscarUnidad(ByVal operador As String)

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim query As String

        Try


            query = "SELECT TOP(1) id_unidad FROM trafico_guia WHERE personalnombre= '" & operador.TrimEnd().TrimStart() & "' ORDER BY fecha_guia DESC"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(query, conexion)
            conexion.Open()
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            Me.txtUnidad.Text = IIf(comando.ExecuteScalar() Is Nothing, "", comando.ExecuteScalar())

        Catch ex As Exception

            MessageBox.Show("")

        End Try
    End Sub

    Private Sub AutorizarOperador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.resultadosDeBusqueda()

    End Sub

    Private Sub txtOperador_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOperador.KeyDown, txtUnidad.KeyDown, txtContraseña.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub

    Private Sub txtOperador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperador.TextChanged

        Me.buscarUnidad(Me.txtOperador.Text)

    End Sub
End Class