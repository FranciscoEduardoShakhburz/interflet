Imports System.Data
Imports System.Data.SqlClient

Public Class ReporteViaje

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReporteViaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click

    End Sub

    Private Sub bCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCerrar.Click

        Me.Close()

    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click

    End Sub

    Private Sub consultarInformacion(ByVal noViaje As Integer)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("", conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            dS = New DataSet()

            With comando.Parameters

                .AddWithValue("@noViaje", noViaje)

            End With

            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then



                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la informacion", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class