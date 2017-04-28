Imports System.Data
Imports System.Data.SqlClient

Public Class HistorialMttoUnidad

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
        Me.Text += " | Unidad " & Me.unidad

    End Sub

    Private Sub HistorialMttoUnidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarDatos()

    End Sub

    Private Sub cargarDatos()

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim reg As DataGridViewRow
        Dim consulta As String
        Dim indice As Integer

        Try

            conexion = Connection.getInstance().getConnection()
            consulta = "SELECT fecha, hora, motivoMantenimiento, observaciones FROM Trafico_HistorialMtto_Unidades WHERE unidad = '" & Me.unidad & "'"
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            sDA = New SqlDataAdapter(comando)
            comando.CommandTimeout = 600
            dS = New DataSet()
            conexion.Open()
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each registro As DataRow In dS.Tables(0).Rows

                        indice = Me.dGVHistorial.Rows.Add()
                        reg = Me.dGVHistorial.Rows(indice)
                        reg.Cells("colHora").Value = registro("hora").ToString()
                        reg.Cells("colFecha").Value = registro("fecha").ToString()
                        reg.Cells("colObservaciones").Value = registro("observaciones").ToString()
                        reg.Cells("colMotivo").Value = registro("motivoMantenimiento").ToString()

                    Next

                    Me.dGVHistorial.Update()

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al cargar el historial: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class