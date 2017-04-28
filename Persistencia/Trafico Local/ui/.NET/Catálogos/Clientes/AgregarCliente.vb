Imports System.Data
Imports System.Data.SqlClient

Public Class AgregarCliente

    Private clienteId As Integer

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal clienteId As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.clienteId = clienteId

    End Sub
    

    Private Sub AgregarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.tBNumeroCliente.Enabled = False

        If Not Me.clienteId = 0 Then

            Dim dS As DataSet = Me.consultarInformacion()
            Dim correo As DataGridViewRow
            Dim correos As String()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Me.tBNumeroCliente.Text = dS.Tables(0).Rows(0)("clienteID").ToString()
                    Me.tBCliente.Text = dS.Tables(0).Rows(0)("nombre").ToString()
                    Me.tBHoras.Text = dS.Tables(0).Rows(0)("horas").ToString()
                    correos = (dS.Tables(0).Rows(0)("correos").ToString().Replace("; ", ";").Replace(" ", "").Trim().TrimEnd().TrimStart()).Split(";")

                    For index As Integer = 0 To correos.Length - 1

                        correo = Me.dGVCorreos.Rows(Me.dGVCorreos.Rows.Add())
                        correo.Cells("colCorreos").Value = correos(index).TrimEnd().TrimStart().Trim()

                    Next
                End If
            End If
        Else

            Me.tBNumeroCliente.Text = 0

        End If
    End Sub

    Private Sub tSBGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBGuardar.Click

        Me.guardarEnCatalogo()
        Me.Close()

    End Sub

    Private Sub tSBSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBSalir.Click

        Me.Close()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If Me.dGVCorreos.Rows.Count = 0 Then

            Me.dGVCorreos.Rows.Add()
            Me.dGVCorreos.Update()
            Exit Sub

        End If

        If Me.dGVCorreos.Rows(Me.dGVCorreos.Rows.Count - 1).Cells("colCorreos").Value IsNot Nothing Then

            Me.dGVCorreos.Rows.Add()
            Me.dGVCorreos.Update()
            Exit Sub

        ElseIf Not String.IsNullOrEmpty(Me.dGVCorreos.Rows(Me.dGVCorreos.Rows.Count - 1).Cells("colCorreos").Value.ToString()) Then

            Me.dGVCorreos.Rows.Add()
            Me.dGVCorreos.Update()
            Exit Sub

        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        For Each correo As DataGridViewRow In Me.dGVCorreos.SelectedRows

            Me.dGVCorreos.Rows.Remove(correo)

        Next
    End Sub

    Private Sub guardarEnCatalogo()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim correos As String

        correos = ""

        Try

            For Each correo As DataGridViewRow In Me.dGVCorreos.Rows

                correos += correo.Cells("colCorreos").Value.ToString() & "; "

            Next

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_CatClientes_Insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@clienteId", Convert.ToInt32(Me.tBNumeroCliente.Text))
                .AddWithValue("@nombre", Me.tBCliente.Text)
                .AddWithValue("@correos", correos)

            End With

            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al guardar el cliente: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function consultarInformacion() As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        dS = New DataSet()

        Try

            consulta = "SELECT * FROM SistemaInterflet_CatClientes WHERE clienteId = " & Me.clienteId
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

        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dS

    End Function
End Class