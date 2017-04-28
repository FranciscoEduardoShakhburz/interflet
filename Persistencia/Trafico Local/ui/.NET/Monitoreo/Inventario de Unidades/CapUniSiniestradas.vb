Imports System.Data
Imports System.Data.SqlClient

Public Class CapUniSiniestradas

    Private unidad As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal unidad As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.unidad = unidad

    End Sub

    Private Sub CapUniSiniestradas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not String.IsNullOrEmpty(Me.unidad) Then

            Me.consultarInformacion()

        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Me.guardar()
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Public Sub guardar()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_UnidadesSiniestradas_Insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@unidad", Me.txtUnidad.Text)
                .AddWithValue("@observaciones", Me.rTBObservaciones.Text)

            End With

            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al guardar la unidad: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub consultarInformacion()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        Try

            consulta = "SELECT unidad, observaciones FROM Trafico_Unidades_Siniestradas WHERE unidad = '" & Me.unidad & "'"
            conexion = Connection.getInstance().getConnection()
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

                    Me.txtUnidad.Text = dS.Tables(0).Rows(0)("unidad").ToString()
                    Me.rTBObservaciones.Text = dS.Tables(0).Rows(0)("observaciones").ToString()

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class