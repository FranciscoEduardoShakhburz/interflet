Imports System.Data
Imports System.Data.SqlClient

Public Class AlertasTramoSencillo

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AlertasTramoSencillo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.consultarinformacion()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub consultarinformacion()

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sDA As SqlDataAdapter
        Dim viaje As DataGridViewRow
        Dim dS As DataSet
        Dim consulta As String
        Dim tiempo As String

        Try

            If Me.dGVTramos.Rows.Count > 0 Then
                For i As Integer = 0 To Me.dGVTramos.Rows.Count - 2

                    viaje = Me.dGVTramos.Rows(i)
                    consulta = "SELECT TOP(1) georeference, [status] = dbo.UDF_Consulta_Status_QSP(economico) FROM TPosicion WHERE economico = '" & viaje.Cells("colUnidad").Value.ToString() & "' ORDER BY fecha DESC"
                    conexion = Connection.getInstance().getConnectionQSP()
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
                    tiempo = IIf(dS.Tables(0).Rows(0)("status").ToString().Split("*")(0).Contains("CLIENTE"), Me.unidadEnMismoSitio(viaje.Cells("colUnidad").Value.ToString()), "00:00:00")
                    viaje.Cells("colSitio").Value = IIf(dS.Tables(0).Rows(0)("georeference").ToString().Equals("null"), "Sitio desconocida", dS.Tables(0).Rows(0)("georeference").ToString())
                    viaje.Cells("colStatus").Value = dS.Tables(0).Rows(0)("status").ToString().Split("*")(0)
                    viaje.Cells("colTiempo").Value = tiempo
                    Me.checarTiempoPlanta(viaje.Cells("colUnidad").Value.ToString(), tiempo)
                    Me.dGVTramos.Update()

                Next
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function unidadEnMismoSitio(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim respaldo As DataRow
        Dim consulta As String
        Dim resultado As String

        resultado = ""

        Try

            consulta = "SELECT TOP (100) economico, georeference, velocidad, fecha FROM TPosicion (NOLOCK) WHERE economico = '" & unidad & "' ORDER BY fecha DESC"
            conexion = Connection.getInstance().getConnectionQSP()
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

                    respaldo = dS.Tables(0).Rows(0)

                    For Each fila As DataRow In dS.Tables(0).Rows
                        If respaldo("georeference").ToString().Equals(fila("georeference").ToString()) Then

                            respaldo = fila

                        Else

                            Exit For

                        End If
                    Next

                    Dim ts As TimeSpan = DateTime.Now.Subtract(Convert.ToDateTime(respaldo("fecha").ToString()))
                    Dim dias As Int32 = ts.Days
                    Dim horas As Int32 = ts.Hours
                    Dim minutos As Int32 = ts.Minutes
                    Dim segundos As Int32 = ts.Seconds

                    If dias > 0 Or horas > 0 Or minutos >= 30 Then

                        resultado = IIf(horas < 10, "0" & horas, horas) & ":" & IIf(minutos < 10, "0" & minutos, minutos) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

                    Else

                        resultado = "00:00:00"

                    End If
                Else

                    consulta = "SELECT veh.[description] AS economico, location, act.speed AS velocidad, act.activityDateTime AS fecha FROM QFSActivity act (NOLOCK) LEFT JOIN QFSVehicles veh (NOLOCK) ON act.vehicleId = veh.vehicleID WHERE act.activityDateTime >= CONVERT(VARCHAR(10), DATEADD(dd, -5, GETDATE()), 105)AND veh.[description] = '" & unidad & "' ORDER BY act.activityDateTime DESC"
                    conexion = Connection.getInstance().getConnectionQFS()
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

                            respaldo = dS.Tables(0).Rows(0)

                            For Each fila As DataRow In dS.Tables(0).Rows
                                If respaldo("location").ToString().Equals(fila("location").ToString()) Then

                                    respaldo = fila

                                Else

                                    Exit For

                                End If
                            Next

                            Dim ts As TimeSpan = DateTime.Now.Subtract(Convert.ToDateTime(respaldo("fecha").ToString()))
                            Dim dias As Int32 = ts.Days
                            Dim horas As Int32 = ts.Hours
                            Dim minutos As Int32 = ts.Minutes
                            Dim segundos As Int32 = ts.Seconds

                            If dias > 0 Or horas > 0 Or minutos >= 30 Then

                                resultado = IIf(horas < 10, "0" & horas, horas) & ":" & IIf(minutos < 10, "0" & minutos, minutos) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

                            Else

                                resultado = "00:00:00"

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la unidad estacionada: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return resultado

    End Function

    Private Sub checarTiempoPlanta(ByVal unidad As String, ByVal hora As String)

        Try

            If String.Compare(hora, "01:00:00") > 0 Then

                Dim alerta As Alerta = New Alerta("Tiempo en planta", unidad, "00:00:00", "")
                alerta.ShowDialog()

            End If

        Catch ex As Exception

            MessageBox.Show("Error al consultar desconexiones: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class