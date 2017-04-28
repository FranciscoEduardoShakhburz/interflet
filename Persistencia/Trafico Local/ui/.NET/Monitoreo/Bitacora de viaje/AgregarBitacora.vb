Imports System.Data
Imports System.Data.SqlClient

Public Class AgregarBitacora

    Private fila As DataGridViewRow

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef fila As DataGridViewRow)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.fila = fila

    End Sub

    Private Sub AgregarBitacora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.rBOpNegoViajar.Checked = True

    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click

        Me.guardarBitacora()

    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click

        Me.Close()

    End Sub

    Private Sub guardarBitacora()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_BitcoraSucesos_Ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@noViaje", Convert.ToInt32(Me.fila.Cells("colViaje").Value))

                If Me.rBOpNegoViajar.Checked Then

                    .AddWithValue("@suceso", Me.rBOpNegoViajar.Text)

                ElseIf Me.rBParadaZonaPro.Checked Then

                    .AddWithValue("@suceso", Me.rBParadaZonaPro.Text)

                ElseIf Me.rBOpAbandonoUnidad.Checked Then

                    .AddWithValue("@suceso", Me.rBOpAbandonoUnidad.Text)

                ElseIf Me.rBParadaSinNot.Checked Then

                    .AddWithValue("@suceso", Me.rBParadaSinNot.Text)

                ElseIf Me.rBOpNoSePresento.Checked Then

                    .AddWithValue("@suceso", Me.rBOpNoSePresento.Text)

                ElseIf Me.rBObservacion.Checked Then

                    .AddWithValue("@suceso", Me.rBObservacion.Text)

                End If

                .AddWithValue("@observaciones", Me.rTBObservaciones.Text)
                .AddWithValue("@eliminado", 0)

            End With

            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al guardar la bitácora en sistema: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class