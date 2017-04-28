Imports System.Data
Imports System.Data.SqlClient

Public Class SeleccionarCliente

    Public cliente As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef datos As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SeleccionarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarDatos()

    End Sub

    Private Sub cargarDatos()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim cons As String
        Dim cliente As DataGridViewRow

        Try

            cons = "SELECT clienteId, nombre, correos FROM SistemaInterflet_CatClientes ORDER BY clienteId ASC"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(cons, conexion)
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
                    For Each clie As DataRow In dS.Tables(0).Rows

                        cliente = Me.dGVClientes.Rows(Me.dGVClientes.Rows.Add())
                        cliente.Cells("colNumero").Value = clie("clienteId").ToString()
                        cliente.Cells("colNombre").Value = clie("nombre").ToString()
                        cliente.Cells("colCorreos").Value = clie("correos").ToString()

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub dGVClientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVClientes.CellDoubleClick

        Me.cliente = Me.dGVClientes.SelectedRows(0).Cells("colNumero").Value.ToString() & "*" & Me.dGVClientes.SelectedRows(0).Cells("colNombre").Value.ToString() & "*" & Me.dGVClientes.SelectedRows(0).Cells("colCorreos").Value.ToString()
        Me.Close()

    End Sub
End Class