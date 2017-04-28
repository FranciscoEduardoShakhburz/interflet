Imports System.Data
Imports System.Data.SqlClient

Public Class CatalogoPersonal

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CatalogoPersonal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarInfo()

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        Me.filtrarPorNombre(Me.txtBusqueda.Text)

    End Sub

    Private Sub cargarInfo()

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Dim consulta As String

        Try

            conexion = Connection.getInstance().getConnection()
            consulta = "SELECT DISTINCT reg.Operador, CASE cat.descripcion WHEN 'OPERADOR LOCAL' THEN 'Local' ELSE 'Foráneo' END AS [Tipo de operador] FROM Trafico_Registros reg LEFT JOIN personal_personal per ON reg.Operador = per.nombre LEFT JOIN personal_catalogo_categoria cat ON  per.id_categoria = cat.id_categoria WHERE per.estado ='A' AND per.tipo_empleado='O' ORDER BY reg.Operador ASC"
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

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Me.dGVOperadores.DataSource = dS.Tables(0)

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al cargar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub filtrarPorNombre(ByVal nombre As String)

        If Me.dGVOperadores.Rows.Count > 0 Then
            For Each operador As DataGridViewRow In Me.dGVOperadores.Rows
                If operador.Cells("Operador").Value.ToString().Equals("") Or operador.Cells("Operador").Value.ToString().Contains(nombre) Then

                    operador.Visible = True

                Else

                    operador.Visible = True

                End If
            Next
        End If
    End Sub
End Class