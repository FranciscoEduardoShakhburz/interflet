Imports System.Data
Imports System.Data.SqlClient

Public Class CambiarOperador

    Public padre As RProgramacio

    Public Sub New(ByVal padre As RProgramacio)

        Me.InitializeComponent()
        Me.padre = padre
        Me.resultadosDeBusqueda()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Me.padre.fijarOperador(Me.txtNombre.Text, Me.txtUnidad.Text)
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.padre.oper = ""
        Me.Close()

    End Sub

    Private Sub txtPlacas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlacas.TextChanged

        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        If Not String.IsNullOrEmpty(Me.txtPlacas.Text) Then
            Try

                sql = "SELECT TOP(1) id_unidad FROM mtto_unidades WHERE REPLACE(REPLACE(placas, ' ', ''), '-', '') LIKE ('%' + REPLACE(REPLACE('" & Me.txtPlacas.Text & "', ' ', ''), '-', '') + '%')"
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables(0).Rows.Count > 0 Then

                    Me.txtUnidad.Text = dS.Tables(0).Rows(0).Item(0).ToString()

                End If

                conexion.Dispose()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try

        Else

            Me.txtUnidad.Text = ""

        End If
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

        Me.txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtNombre.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub CambiarOperador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.resultadosDeBusqueda()

    End Sub
End Class