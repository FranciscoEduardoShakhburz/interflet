Imports System.Data
Imports System.Data.SqlClient

Public Class ReporteMovimientosUnidades

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReporteMovimientosUnidades_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub bConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bConsultar.Click

        Dim dT As DataTable

        If String.IsNullOrEmpty(Me.tBUnidad.Text) Then

            MessageBox.Show("Debe especificar una unidad en la búsqueda.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            dT = Me.consultaInformacion()
            
            If dT.Rows.Count > 0 Then

                Me.dGVInfo.DataSource = dT

            End If
        End If
    End Sub

    Private Sub bExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click

        Excel.gridToExcel(Me.dGVInfo)

    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click

        Me.Close()

    End Sub

    Public Function consultaInformacion() As DataTable

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dT As DataTable
        Dim dS As DataSet

        dT = New DataTable()

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ReporteMovtosUnidad", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@unidad", Me.tBUnidad.Text)
                .AddWithValue("@desde", Me.dTPDesde.Value)
                .AddWithValue("@hasta", Me.dTPHasta.Value)

            End With

            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then

                dT = dS.Tables(0)

            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información", "¡!")

        End Try

        Return dT

    End Function
End Class