Imports System.Data
Imports System.Data.SqlClient

Public Class AgregarCarga

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim cont As Integer = 0
        Dim command As SqlCommand

        If String.IsNullOrEmpty(Me.txtContenedor.Text) Or String.IsNullOrEmpty(Me.txtReferencia.Text) Then

            MessageBox.Show("El contenedor y la referencia son requeridos")
            Return

        Else

            cn.Open()
            command = New SqlCommand("up_inserte_RProgramacion", cn)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters

                .AddWithValue("@TIPO_OPER", "IMPO")
                .AddWithValue("@TERMINAL", Me.txtTerminal.Text)
                .AddWithValue("@REFERENCIA", Me.txtReferencia.Text)
                .AddWithValue("@CLIENTE", Me.txtCliente.Text)
                .AddWithValue("@TIPO", Me.txtTipo.Text)
                .AddWithValue("@CONTENEDOR", Me.txtContenedor.Text)
                .AddWithValue("@tipo_insert", 1)

                If Me.cmbTipo.SelectedIndex = 0 Then

                    .AddWithValue("@TIPO_PRO", 1)

                ElseIf Me.cmbTipo.SelectedIndex = 1 Then

                    .AddWithValue("@TIPO_PRO", 2)

                ElseIf Me.cmbTipo.SelectedIndex = 2 Then

                    .AddWithValue("@TIPO_PRO", 3)

                End If
            End With

            Try

                command.ExecuteNonQuery()
                MessageBox.Show("Los datos se han guardado correctamente", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.resetControles()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    Private Sub resultadosDeBusquedaCliente()

        Dim autoCompletado = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre FROM trafico_cliente"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCliente.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub resultadosDeBusquedaTerminal()

        Dim autoCompletado = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre_terminal FROM trafico_local_terminal"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtTerminal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTerminal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtTerminal.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub AgregarCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.resultadosDeBusquedaCliente()
        Me.resultadosDeBusquedaTerminal()
        Me.cmbTipo.SelectedIndex = 0

    End Sub

    Private Sub resetControles()

        Me.cmbTipo.SelectedIndex = 0
        Me.txtCliente.Text = ""
        Me.txtContenedor.Text = ""
        Me.txtReferencia.Text = ""
        Me.txtTerminal.Text = ""
        Me.txtTipo.Text = ""

    End Sub

    Private Sub txtTerminal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTerminal.KeyDown, txtTipo.KeyDown, txtReferencia.KeyDown, txtContenedor.KeyDown, txtCliente.KeyDown, cmbTipo.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub
End Class