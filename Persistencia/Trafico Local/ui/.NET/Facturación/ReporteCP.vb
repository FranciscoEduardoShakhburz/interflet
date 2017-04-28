Imports System.Data
Imports System.Data.SqlClient

Public Class ReporteCP

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReporteCP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cBSucursal.SelectedIndex = 0

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Dim dS As DataSet
        dS = Me.consultarInformacion()

        If dS.Tables.Count > 0 Then
            If dS.Tables(0).Rows.Count > 0 Then

                Excel.datasetToExcel(dS)

            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Public Function consultarInformacion() As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        dS = New DataSet()

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ConsultaCP", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@desde", Me.dTPDesde.Value)
                .AddWithValue("@hasta", Me.dTPHasta.Value)
                .AddWithValue("@sucursal", Me.cBSucursal.SelectedIndex)

            End With

            dS = New DataSet()
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