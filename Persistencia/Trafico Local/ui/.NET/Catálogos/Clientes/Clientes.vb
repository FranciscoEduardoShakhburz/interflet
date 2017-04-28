Imports System.Data
Imports System.Data.SqlClient

Public Class Clientes

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Clientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Cursor.Current = Cursors.WaitCursor
        Me.rBNumero.Checked = True
        Me.poblarGrid(Me.consultarInformacion())
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub tSBAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBAgregar.Click

        Dim agregar As AgregarCliente
        agregar = New AgregarCliente(True)
        agregar.ShowDialog(Me)
        Me.poblarGrid(Me.consultarInformacion())
        Me.dGVClientes.Update()

    End Sub

    Private Sub tSBEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBEditar.Click

        Dim agregar As AgregarCliente
        agregar = New AgregarCliente(Convert.ToInt32(Me.dGVClientes.SelectedRows(0).Cells("colNumeroCliente").Value.ToString()))
        agregar.ShowDialog(Me)
        Me.poblarGrid(Me.consultarInformacion())
        Me.dGVClientes.Update()

    End Sub

    Private Sub tSBEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBEliminar.Click

    End Sub

    Private Sub tSBSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBSalir.Click

        Me.Close()

    End Sub

    Private Sub tBBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBBusqueda.TextChanged

        If Not String.IsNullOrEmpty(Me.tBBusqueda.Text) Then
            If Me.rBNumero.Checked Then
                If Integer.TryParse(Me.tBBusqueda.Text, System.Int32.MinValue) = True Then

                    Me.dGVClientes.Rows.Clear()
                    Me.poblarGrid(Me.filtrado(Me.tBBusqueda.Text, 1))

                Else

                    MessageBox.Show("El número no es válido.", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            ElseIf Me.rBNombre.Checked Then

                Me.dGVClientes.Rows.Clear()
                Me.poblarGrid(Me.filtrado(Me.tBBusqueda.Text, 2))

            End If
        Else

            Me.dGVClientes.Rows.Clear()
            Me.poblarGrid(Me.consultarInformacion())

        End If
    End Sub

    Private Function consultarInformacion() As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        dS = New DataSet()

        Try

            consulta = "SELECT clienteId AS [Número de cliente], nombre AS [Nombre], correos AS [Correos], horas AS Horas FROM SistemaInterflet_CatClientes ORDER BY clienteId ASC"
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

            MessageBox.Show("Error al consultar la información dle catálogo" & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dS

    End Function

    Private Sub poblarGrid(ByVal dS As DataSet)

        Dim clie As DataGridViewRow

        If dS.Tables.Count > 0 Then
            If dS.Tables(0).Rows.Count > 0 Then
                For Each cliente As DataRow In dS.Tables(0).Rows

                    clie = Me.dGVClientes.Rows(Me.dGVClientes.Rows.Add())
                    clie.Cells("colNumeroCliente").Value = cliente("Número de cliente").ToString()
                    clie.Cells("colNombre").Value = cliente("Nombre").ToString()
                    clie.Cells("colCorreos").Value = cliente("Correos").ToString()
                    clie.Cells("colHoras").Value = cliente("Horas").ToString()

                Next
            End If
        End If
    End Sub

    Private Function filtrado(ByVal busqueda As String, ByVal opcion As Integer) As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        dS = New DataSet()

        Try

            If opcion = 1 Then

                consulta = "SELECT clienteId AS [Número de cliente], nombre AS [Nombre], correos AS [Correos], horas AS Horas FROM SistemaInterflet_CatClientes WHERE clienteId = " & Convert.ToInt32(busqueda)

            ElseIf opcion = 2 Then

                consulta = "SELECT clienteId AS [Número de cliente], nombre AS [Nombre], correos AS [Correos], horas AS Horas FROM SistemaInterflet_CatClientes WHERE nombre LIKE '%" & busqueda & "%'"

            End If

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

            MessageBox.Show("Error al consultar la información dle catálogo" & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dS

    End Function
End Class