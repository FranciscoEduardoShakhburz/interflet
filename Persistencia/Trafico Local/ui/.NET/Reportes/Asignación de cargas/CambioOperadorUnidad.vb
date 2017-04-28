Imports System.Data
Imports System.Data.SqlClient

Public Class CambioOperadorUnidad

    Private numOperador As Integer
    Private operador As String
    Private numCarga As Integer
    Private contenedor As String
    Private motivo As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal numOperador As Integer, ByVal operador As String, ByVal numCarga As Integer, ByVal contenedor As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.numOperador = numOperador
        Me.operador = operador
        Me.numCarga = numCarga
        Me.contenedor = contenedor

    End Sub

    Private Sub CambioOperador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.rBNegoViaje.Checked = True

    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click

        Me.guardar()
        Me.Close()

    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click

        Me.Close()

    End Sub

    Private Sub guardar()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String
        Dim motivo As String

        Try
            If Me.rBNegoViaje.Checked Then

                motivo = "Se negó a viajar"

            ElseIf Me.rBNoSePresento.Checked Then

                motivo = "No se presentó a laborar"

            ElseIf Me.rBPenalizacion.Checked Then

                motivo = "Tiene penalización"

            ElseIf Me.rBOtro.Checked Then

                motivo = rTBOtro.Text

            End If

            consulta = "INSERT INTO Trafico_Asignacion_MotivoCambioOperador (operadorId, operador, cargaId, contenedor, motivo, cuando, donde) VALUES (" & Me.numOperador & ", '" & Me.operador & "', " & Me.numCarga & ", '" & Me.contenedor & "' , '" & motivo & "', GETDATE(), HOST_NAME())"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al guadar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class