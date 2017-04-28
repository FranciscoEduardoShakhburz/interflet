Imports System.Data
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Threading

Public Class MonitorUnidadesRuta

    Private hilo As Thread
    Private hiloStart As ThreadStart
    Private CallCargarInformacion As MethodInvoker
    Private tiempoActualizacion As Integer

    Private Sub MonitorUnidadesEnRuta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.hilo.Suspend()

    End Sub

    Private Sub MonitorUnidadesEnRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Cursor.Current = Cursors.WaitCursor
        Me.WindowState = FormWindowState.Maximized

        If Environment.MachineName.Contains("DAH-100") Then

            Me.chBLectura.Checked = False
            Me.tiempoActualizacion = 3600000

        Else

            Me.chBLectura.Checked = True
            Me.tiempoActualizacion = 600000

        End If

        hiloStart = New ThreadStart(AddressOf ActualizacionesBackground)
        CallCargarInformacion = New MethodInvoker(AddressOf Me.consultarInformacion)
        hilo = New Thread(hiloStart)
        hilo.IsBackground = True
        hilo.Name = "Actualizar"
        hilo.Start()
        'Me.consultarInformacion()
        Me.chBSoloFuera.Checked = True
        Me.dGVMonitor.DefaultCellStyle.Font = New Font("Ubuntu", 16)
        Cursor.Current = Cursors.Arrow

    End Sub

    Public Sub ActualizacionesBackground()

        While True

            Me.BeginInvoke(CallCargarInformacion)
            Thread.Sleep(Me.tiempoActualizacion)

        End While
    End Sub

    Private Sub consultarInformacion()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim unidad As DataGridViewRow
        Dim consulta As String
        Dim mensajeCorreo As String
        Dim mensajePantalla As String
        Dim estatusViaje As String
        Dim indice As Integer
        Dim estaEnRuta As Boolean
        Dim ignicion As String
        Dim alerta As String
        Dim tiempoEnMismoLugar As String

        'Try

        Me.dGVMonitor.Rows.Clear()
        Me.pBar.Minimum = 1
        Me.pBar.Step = 1

        If Me.chBLectura.Checked = True Then

            conexion = Connection.getInstance().getConnection()
            consulta = "DECLARE @id INT SET @id = (SELECT TOP(1) idRegistro FROM Trafico_Seguimiento_Unidades ORDER BY fecha DESC) SELECT * FROM Trafico_Seguimiento_Unidades_Detalle WHERE idRegistro = @id"
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            comando.CommandTimeout = 600
            dS = New DataSet()
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count Then
                    For Each uni As DataRow In dS.Tables(0).Rows

                        indice = Me.dGVMonitor.Rows.Add()
                        unidad = Me.dGVMonitor.Rows(indice)
                        unidad.Cells("colUnidad").Value = uni("unidad").ToString()
                        unidad.Cells("colFlota").Value = uni("flota").ToString()
                        unidad.Cells("colSitio").Value = uni("sitio").ToString()
                        unidad.Cells("colDestino").Value = uni("destino").ToString()
                        unidad.Cells("colStatus").Value = uni("status").ToString()
                        unidad.Cells("colHora").Value = uni("horaStatus").ToString()
                        unidad.Cells("colAlerta").Value = uni("alerta").ToString()
                        unidad.Cells("colHoraAlerta").Value = uni("horaAlerta").ToString()
                        unidad.Cells("colEstaEnRuta").Value = uni("estaEnRuta").ToString()
                        unidad.Cells("colIgnicion").Value = uni("ignicion").ToString()
                        unidad.Cells("colTiempoEstacionada").Value = uni("tiempoEstacionamiento").ToString()
                        unidad.Cells("colTiempoMismoSitio").Value = uni("tiempoMismoSitio").ToString()
                        unidad.Cells("colObservaciones").Value = uni("observaciones").ToString()
                        Me.filtrarFila(unidad)
                        Me.pBar.PerformStep()
                        Me.dGVMonitor.Update()

                        If uni("status").ToString().Contains("TRANSITO") Or uni("status").ToString().Contains("REGRESO") Then

                            Me.evaluarSitio(uni("sitio").ToString(), uni("tiempoMismoSitio").ToString(), uni("unidad").ToString())
                            Me.checarDesconexionSatelital(uni("unidad").ToString())

                        End If
                    Next

                    Me.pBar.Step = 1
                    Me.pBar.Value = 1
                    Me.dGVMonitor.Sort(Me.dGVMonitor.Columns("colEstaEnRuta"), System.ComponentModel.ListSortDirection.Descending)
                    Me.dGVMonitor.Update()

                End If
            End If
        Else

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Monitor_Rutas", conexion)
            comando.CommandType = CommandType.StoredProcedure
            sDA = New SqlDataAdapter(comando)
            comando.CommandTimeout = 2500
            dS = New DataSet()
            conexion.Open()
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
            SqlConnection.ClearPool(conexion)
            mensajeCorreo = ""
            estatusViaje = ""
            mensajePantalla = ""

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count Then
                    For Each uni As DataRow In dS.Tables(0).Rows

                        alerta = Me.consultarAlerta(uni("unidad").ToString())
                        unidad = Me.dGVMonitor.Rows(Me.dGVMonitor.Rows.Add())
                        unidad.Cells("colUnidad").Value = uni("unidad").ToString()
                        unidad.Cells("colFlota").Value = uni("flota").ToString()
                        unidad.Cells("colSitio").Value = uni("sitio").ToString()
                        unidad.Cells("colDestino").Value = uni("destino").ToString()
                        unidad.Cells("colStatus").Value = uni("status").ToString()
                        unidad.Cells("colHora").Value = uni("horaStatus").ToString()
                        unidad.Cells("colObservaciones").Value = Me.consultarObservaciones(uni("unidad").ToString())

                        If String.IsNullOrEmpty(alerta) Then

                            unidad.Cells("colAlerta").Value = ""
                            unidad.Cells("colHoraAlerta").Value = ""

                        Else

                            unidad.Cells("colAlerta").Value = alerta.Split("-")(0)
                            unidad.Cells("colHoraAlerta").Value = alerta.Split("-")(1)

                        End If

                        Me.dGVMonitor.Update()

                        If (uni("status").ToString().Contains("REGRESO") Or uni("status").ToString().Contains("TRANSITO")) And Not unidad.Cells("colSitio").Value.ToString().Contains("PROV -") And Not unidad.Cells("colSitio").Value.ToString().Contains("PEN -") Then

                            consulta = Me.consultarTramos(uni)

                            If Not String.IsNullOrEmpty(consulta) And Not unidad.Cells("colSitio").Value.ToString().Contains("PEN -") Then

                                conexion = Connection.getInstance().getConnection()
                                comando = New SqlCommand(consulta, conexion)
                                comando.CommandType = CommandType.Text
                                comando.CommandTimeout = 600
                                conexion.Open()
                                dS = New DataSet()
                                sDA = New SqlDataAdapter(comando)
                                sDA.Fill(dS)

                                If dS.Tables.Count > 0 Then
                                    If dS.Tables(0).Rows.Count > 0 Then
                                        For Each registro As DataRow In dS.Tables(0).Rows
                                            If unidad.Cells("colSitio").Value.ToString().Contains(registro("nombre").ToString()) Then

                                                estaEnRuta = True
                                                Exit For

                                            Else

                                                estaEnRuta = False

                                            End If
                                        Next
                                    End If
                                End If

                                If estaEnRuta Then

                                    unidad.Cells("colEstaEnRuta").Value = "SI"

                                Else

                                    unidad.Cells("colEstaEnRuta").Value = "NO"

                                End If
                            Else

                                If unidad.Cells("colSitio").Value.ToString().Contains("desconocida") Then

                                    unidad.Cells("colEstaEnRuta").Value = "NO"

                                Else

                                    unidad.Cells("colEstaEnRuta").Value = "NO"

                                End If

                                If String.IsNullOrEmpty(consulta) Then

                                    unidad.Cells("colEstaEnRuta").Value = "NO"

                                End If
                            End If
                        Else

                            unidad.Cells("colEstaEnRuta").Value = "N/A"

                        End If

                        ignicion = Me.unidadEstacionada(unidad.Cells("colUnidad").Value.ToString())

                        If Not String.IsNullOrEmpty(ignicion) Then

                            unidad.Cells("colIgnicion").Value = ignicion.Split(" ")(0)
                            unidad.Cells("colTiempoEstacionada").Value = ignicion.Split(" ")(1)

                        Else

                            unidad.Cells("colIgnicion").Value = ""
                            unidad.Cells("colTiempoEstacionada").Value = ""

                        End If

                        tiempoEnMismoLugar = Me.unidadEnMismoSitio(unidad.Cells("colUnidad").Value.ToString())

                        If Not String.IsNullOrEmpty(tiempoEnMismoLugar) Then

                            unidad.Cells("colTiempoMismoSitio").Value = tiempoEnMismoLugar

                        Else

                            unidad.Cells("colTiempoMismoSitio").Value = ""

                        End If

                        Me.dGVMonitor.Update()
                        Me.filtrarFila(unidad)
                        Me.guardarRegistro(unidad.Cells("colUnidad").Value.ToString(), unidad.Cells("colSitio").Value.ToString(), unidad.Cells("colDestino").Value.ToString(), unidad.Cells("colEstaEnRuta").Value.ToString(), unidad.Cells("colObservaciones").Value.ToString(), unidad.Cells("colStatus").Value.ToString(), unidad.Cells("colHora").Value.ToString(), unidad.Cells("colFlota").Value.ToString(), unidad.Cells("colAlerta").Value.ToString(), unidad.Cells("colHoraAlerta").Value.ToString(), unidad.Cells("colIgnicion").Value.ToString(), unidad.Cells("colTiempoMismoSitio").Value.ToString(), unidad.Cells("colTiempoEstacionada").Value.ToString())
                        Me.pBar.PerformStep()
                        Me.dGVMonitor.Update()

                    Next

                    Me.pBar.Step = 1
                    Me.pBar.Value = 1
                    Me.dGVMonitor.Sort(Me.dGVMonitor.Columns("colEstaEnRuta"), System.ComponentModel.ListSortDirection.Descending)
                    Me.dGVMonitor.Update()

                End If
            End If
        End If
    End Sub

    Private Function sitioActual(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sitio As String
        Dim consulta As String

        Try

            consulta = "SELECT ISNULL((SELECT TOP(1) ISNULL(georeference, '') FROM TPosicion (NOLOCK) WHERE economico = '" & unidad & "' ORDER BY fecha DESC), '')"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            sitio = comando.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(sitio) Then

                consulta = "SELECT TOP(1) act.location FROM QFSActivity act (NOLOCK) LEFT JOIN QFSVehicles veh (NOLOCK) ON act.vehicleId = veh.vehicleID WHERE veh.description = '" & unidad & "' ORDER BY act.activityDateTime DESC"
                conexion = Connection.getInstance().getConnectionQFS()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                sitio = comando.ExecuteScalar().ToString()

            End If

            sitio = IIf(sitio.Contains("null"), "Ruta desconocida", sitio)

        Catch ex As Exception

            sitio = ""
            MessageBox.Show("Error al consultar el sitio: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        conexion.Close()
        conexion.Dispose()
        comando.Dispose()
        Return sitio

    End Function

    Private Function consultarEstatus(ByVal unidad As String) As String

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim res As String = ""

        conexion = Connection.getInstance().getConnectionQSP()
        comando = New SqlCommand("UP_CONSULTA_ESTATUS_UNIDADQSP", conexion)
        'comando = New SqlCommand("UP_Consulta_UltRegistro_QSP", conexion)

        With comando.Parameters

            .AddWithValue("@ID_UNIDAD", unidad)

        End With

        comando.CommandType = CommandType.StoredProcedure
        comando.CommandTimeout = 600
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        If dS.Tables(0).Rows.Count > 0 Then

            res = dS.Tables(1).Rows.Item(0).Item("SITIO").ToString() & "-" & dS.Tables(0).Rows.Item(0).Item("FECHA").ToString()

        Else

            conexion = Connection.getInstance().getConnectionQFS()
            comando = New SqlCommand("UP_CONSULTA_ESTATUS_UNIDAD", conexion)

            With comando.Parameters

                .AddWithValue("@ID_UNIDAD", unidad)

            End With

            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 1000
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables(0).Rows.Count > 0 Then

                res = dS.Tables(1).Rows.Item(0).Item(0).ToString() & "-" & dS.Tables(1).Rows.Item(0).Item(1).ToString()

            Else

                res = dS.Tables(1).Rows.Item(0).Item(0).ToString()

            End If
        End If

        Return res

    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub guardarRegistro(ByVal unidad As String, ByVal sitio As String, ByVal destino As String, ByVal estaEnRuta As String, ByVal observaciones As String, ByVal status As String, ByVal horaStatus As String, ByVal flota As String, ByVal alerta As String, ByVal horaAlerta As String, ByVal ignicion As String, ByVal tiempoMismoSitio As String, ByVal tiempoEstacionamiento As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_TraficoSeguimiento_Insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_TraficoSeguimiento_Detalle_Insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@unidad", unidad)
                .AddWithValue("@sitio", sitio)
                .AddWithValue("@destino", destino)
                .AddWithValue("@estaEnRuta", estaEnRuta)
                .AddWithValue("@observaciones", observaciones)
                .AddWithValue("@status", status)
                .AddWithValue("@horaStatus", horaStatus)
                .AddWithValue("@flota", flota)
                .AddWithValue("@alerta", alerta)
                .AddWithValue("@horaAlerta", horaAlerta)
                .AddWithValue("@ignicion", ignicion)
                .AddWithValue("@tiempoMismoSitio", tiempoMismoSitio)
                .AddWithValue("@tiempoEstacionamiento", tiempoEstacionamiento)

            End With

            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al guardar el registro: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function unidadEstacionada(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim respaldo As DataRow
        Dim consulta As String
        Dim resultado As String

        Try

            consulta = "SELECT TOP (100) economico, CASE ignicion WHEN 'Encendido' THEN 'ON' ELSE 'OFF' END AS [ignicion], velocidad, fecha FROM TPosicion (NOLOCK) WHERE economico = '" & unidad & "' ORDER BY fecha DESC"
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
                    If (dS.Tables(0).Rows(0)("ignicion").ToString().Equals("ON") Or dS.Tables(0).Rows(0)("ignicion").ToString().Equals("OFF")) And Convert.ToInt32(dS.Tables(0).Rows(0)("velocidad").ToString()) > 0 Then

                        resultado = dS.Tables(0).Rows(0)("ignicion").ToString() & " " & "00:00:00"

                        Exit Try

                    End If

                    If dS.Tables(0).Rows(0)("ignicion").ToString().Equals("ON") Then
                        For Each fila As DataRow In dS.Tables(0).Rows
                            If fila("ignicion").ToString().Equals("ON") And Convert.ToInt32(fila("velocidad").ToString()) = 0 Then

                                respaldo = fila

                            Else

                                Exit For

                            End If
                        Next
                    Else
                        For Each fila As DataRow In dS.Tables(0).Rows
                            If fila("ignicion").ToString().Equals("OFF") And Convert.ToInt32(fila("velocidad").ToString()) = 0 Then

                                respaldo = fila

                            Else

                                Exit For

                            End If
                        Next
                    End If

                    Dim ts As TimeSpan = DateTime.Now.Subtract(Convert.ToDateTime(respaldo("fecha").ToString()))
                    Dim dias As Int32 = ts.Days
                    Dim horas As Int32 = ts.Hours
                    Dim minutos As Int32 = ts.Minutes
                    Dim segundos As Int32 = ts.Seconds

                    If dias > 0 Or horas > 0 Or minutos >= 5 Then

                        resultado = respaldo("ignicion").ToString() & " " & IIf(horas < 10, "0" & horas, horas) & ":" & IIf(minutos < 10, "0" & minutos, minutos) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

                    Else

                        resultado = respaldo("ignicion").ToString() & " 00:00:00"

                    End If
                Else

                    consulta = "SELECT veh.[description] AS economico, CASE act.ignitionOn WHEN 1 THEN 'ON' ELSE 'OFF' END AS ignicion, act.speed AS velocidad, act.activityDateTime AS fecha FROM QFSActivity act (NOLOCK) LEFT JOIN QFSVehicles veh (NOLOCK) ON act.vehicleId = veh.vehicleID WHERE act.activityDateTime >= CONVERT(VARCHAR(10), DATEADD(dd, -5, GETDATE()), 105)AND veh.[description] = '" & unidad & "' ORDER BY act.activityDateTime DESC"
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
                            If (dS.Tables(0).Rows(0)("ignicion").ToString().Equals("ON") Or dS.Tables(0).Rows(0)("ignicion").ToString().Equals("OFF")) And Convert.ToInt32(dS.Tables(0).Rows(0)("velocidad").ToString()) > 0 Then

                                resultado = dS.Tables(0).Rows(0)("ignicion").ToString() & " " & "00:00:00"

                                Exit Try
                            End If

                            If dS.Tables(0).Rows(0)("ignicion").ToString().Equals("ON") Then
                                For Each fila As DataRow In dS.Tables(0).Rows
                                    If fila("ignicion").ToString().Equals("ON") And Convert.ToInt32(fila("velocidad").ToString()) = 0 Then

                                        respaldo = fila

                                    Else

                                        Exit For

                                    End If
                                Next
                            Else
                                For Each fila As DataRow In dS.Tables(0).Rows
                                    If fila("ignicion").ToString().Equals("OFF") And Convert.ToInt32(fila("velocidad").ToString()) = 0 Then

                                        respaldo = fila

                                    Else

                                        Exit For

                                    End If
                                Next
                            End If

                            Dim ts As TimeSpan = DateTime.Now.Subtract(Convert.ToDateTime(respaldo("fecha").ToString()))
                            Dim dias As Int32 = ts.Days
                            Dim horas As Int32 = ts.Hours
                            Dim minutos As Int32 = ts.Minutes
                            Dim segundos As Int32 = ts.Seconds

                            If dias > 0 Or horas > 0 Or minutos >= 5 Then

                                resultado = respaldo("ignicion").ToString() & " " & IIf(horas < 10, "0" & horas, horas) & ":" & IIf(minutos < 10, "0" & minutos, minutos) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

                            Else

                                resultado = respaldo("ignicion").ToString() & " 00:00:00"

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

    Private Function unidadEnMismoSitio(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim respaldo As DataRow
        Dim consulta As String
        Dim resultado As String

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

    Private Function consultarAlerta(ByVal unidad As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String
        Dim resultado As String

        resultado = ""

        Try

            consulta = "SELECT TOP(1) CASE tipoAlerta WHEN 'EXCESO DE VELOCIDAD' THEN 'Vel' WHEN 'BOTÓN DE PÁNICO'  THEN 'Pan' END AS [alerta], CONVERT(VARCHAR(10), fecha, 108) AS [hora] FROM alertasCC (NOLOCK) WHERE (tipoAlerta LIKE '%velocidad%' OR tipoAlerta LIKE '%pánico%') AND (fecha >= CONVERT(VARCHAR(20), GETDATE(), 105)) AND alias = '" & unidad & "' ORDER BY fecha DESC"
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

                    resultado = dS.Tables(0).Rows(0)("alerta").ToString() & "-" & dS.Tables(0).Rows(0)("hora").ToString().Substring(0, 5)

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar alertas: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return resultado

    End Function

    Private Function consultarObservaciones(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String
        Dim observaciones As String
        observaciones = ""

        Try

            consulta = "DECLARE @id INT SET @id = (SELECT TOP(1) idRegistro FROM Trafico_Seguimiento_Unidades (NOLOCK) ORDER BY fecha DESC) DECLARE @obs VARCHAR(500) SET @obs = (SELECT ISNULL(observaciones, '') FROM Trafico_Seguimiento_Unidades_Detalle (NOLOCK) WHERE idRegistro = @id AND unidad = '" & unidad & "') IF (@obs = '') BEGIN SET @obs = (SELECT ISNULL(observaciones, '') FROM Trafico_Seguimiento_Unidades_Detalle (NOLOCK) WHERE idRegistro = (@id - 1) AND unidad = '" & unidad & "') END SELECT ISNULL(@obs, '')"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            observaciones = comando.ExecuteScalar().ToString()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("error al guardar el registro: " & ex.Message, "¡error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return observaciones

    End Function

    Private Sub dGVMonitor_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVMonitor.CellDoubleClick

        Dim observaciones As String
        Dim registro As DataGridViewRow

        registro = Me.dGVMonitor.SelectedRows(0)
        observaciones = InputBox("Ingrese las observaciones:", "Editar / Agregar", "")

        If Not String.IsNullOrEmpty(observaciones) Then

            registro.Cells("colObservaciones").Value = observaciones
            Me.guardarRegistro(registro.Cells("colUnidad").Value.ToString(), registro.Cells("colSitio").Value.ToString(), registro.Cells("colDestino").Value.ToString(), registro.Cells("colEstaEnRuta").Value.ToString(), observaciones, registro.Cells("colStatus").Value.ToString(), registro.Cells("colHora").Value.ToString(), registro.Cells("colFlota").Value.ToString(), registro.Cells("colAlerta").Value.ToString(), registro.Cells("colHoraAlerta").Value.ToString(), registro.Cells("colIgnicion").Value.ToString(), registro.Cells("colTiempoMismoSitio").Value.ToString(), registro.Cells("colTiempoEstacionada").Value.ToString())

        End If
    End Sub

    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.consultarInformacion()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Me.exportarInfo(Me.dGVMonitor)

    End Sub

    Private Sub exportarInfo(ByVal grid As DataGridView)

        If grid.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()

            Dim columnas As Integer = grid.ColumnCount
            Dim filas As Integer = grid.RowCount
            Dim filaEx As Integer = 0
            Dim columnaEx As Integer = 0


            For i As Integer = 1 To columnas

                'hoja.Cells.Item(1, i) = grid.Columns(i - 1).Name.ToString()
                hoja.Cells.Item(1, i) = grid.Columns(i - 1).HeaderText

            Next

            For fila As Integer = 0 To filas - 1
                For columna As Integer = 0 To columnas - 1
                    If grid.Rows(fila).Visible = True Then

                        hoja.Cells.Item(filaEx + 2, columna + 1) = grid.Rows(fila).Cells(columna).Value
                        hoja.Rows(filaEx + 2).Interior.Color = System.Drawing.ColorTranslator.ToOle(grid.Rows(fila).DefaultCellStyle.BackColor)
                        hoja.Rows(filaEx + 2).Font.Color = System.Drawing.ColorTranslator.ToOle(grid.Rows(fila).DefaultCellStyle.ForeColor)

                    End If
                Next

                filaEx = IIf(grid.Rows(fila).Visible = True, filaEx + 1, filaEx)

            Next

            hoja.Rows.Item(1).Font.Bold = 1
            hoja.Rows.Item(1).HorizontalAlignment = 3
            hoja.Columns.AutoFit()
            App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()

        End If
    End Sub

    Private Sub dGVMonitor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVMonitor.CellClick

        If Me.dGVMonitor.SelectedRows.Count > 0 Then

            Me.rTBComentarios.Text = Me.consultarObservaciones(Me.dGVMonitor.SelectedRows(0).Cells("colUnidad").Value.ToString())

        End If
    End Sub

    Private Function consultarTramos(ByVal uni As DataRow) As String

        '***************************************'
        '***************ALTAMIRA***************'
        '***************************************'

        If (uni("destino").ToString().Contains("MONTERREY") Or uni("destino").ToString().Contains("APODACA") Or uni("destino").ToString().Contains("ESCOBEDO") Or uni("destino").ToString().Contains("GARCIA") Or uni("destino").ToString().Contains("CIENEGA DE FLORES") Or uni("destino").ToString().Contains("GUADALUPE")) And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2)"

        ElseIf (uni("destino").ToString().Contains("SLP") Or uni("destino").ToString().Contains("SAN LUIS POTOSI")) And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 4)"

        ElseIf (uni("destino").ToString().Contains("QRO") Or uni("destino").ToString().Contains("QUERETARO")) And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 5, 6)"

        ElseIf uni("destino").ToString().Contains("SALTILLO") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 7, 8)"

        ElseIf uni("destino").ToString().Contains("ALAMO") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (9, 10)"

        ElseIf (uni("destino").ToString().Contains("HUEHUETOCA") Or uni("destino").ToString().Contains("CUAUTITLAN IZCALLI")) And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (9, 11, 12)"

        ElseIf uni("destino").ToString().Contains("CD. VICTORIA") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (13, 14)"

        ElseIf uni("destino").ToString().Contains("REYNOSA") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (13, 15, 16)"

        ElseIf uni("destino").ToString().Contains("MARTINEZ DE LA TORRE") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (9, 17)"

        ElseIf uni("destino").ToString().Contains("PASO LARGO") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (9, 59)"

        ElseIf uni("destino").ToString().Contains("SAN JOSE ITURBIDE") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 34, 35)"

        ElseIf uni("destino").ToString().Contains("RAMOS ARIZPE") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2, 36)"

        ElseIf uni("destino").ToString().Contains("LAGOS DE MORENO") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 37, 39)"

        ElseIf uni("destino").ToString().Contains("GUADALAJARA") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 19, 37, 40)"

        ElseIf (uni("destino").ToString().Contains("SANTA ROSA JAUREGUI") Or uni("destino").ToString().Contains("SANTA ROSA JAUREGUI *")) And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 41)"

        ElseIf uni("destino").ToString().Contains("SAN NICOLAS DE LOS GARZA") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2)"

        ElseIf uni("destino").ToString().Contains("SILAO") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 37, 42, 43, 44)"

        ElseIf uni("destino").ToString().Contains("AGUASCALIENTES") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 47)"

        ElseIf (uni("destino").ToString().Contains("CHIHUAHUA") Or uni("destino").ToString().Contains("CD. OBREGON")) And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2, 7, 8, 48, 49, 50, 51)"

        ElseIf (uni("destino").ToString().Contains("CELAYA") Or uni("destino").ToString().Contains("APASEO EL GRANDE")) And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 4, 41, 45)"

        ElseIf uni("destino").ToString().Contains("BENITO JUAREZ") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2)"

        ElseIf (uni("destino").ToString().Contains("GOMEZ PALACIO") Or uni("destino").ToString().Contains("TORREON")) And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2, 7, 8, 48, 49)"

        ElseIf uni("destino").ToString().Contains("ARTEAGA") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 77)"

        ElseIf uni("destino").ToString().Contains("MANZANILLO") And uni("id_area").ToString().Contains("1") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 18, 76)"

            '***************************************'
            '*************MANZANILLO**************'
            '***************************************'

        ElseIf (uni("destino").ToString().Contains("GUADALAJARA") Or uni("destino").ToString().Contains("GDL") Or uni("destino").ToString().Contains("EL SALTO") Or uni("destino").ToString().Contains("ZAPOPAN")) And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 19)"

        ElseIf (uni("destino").ToString().Contains("MONTERREY") Or uni("destino").ToString().Contains("NL")) And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 20, 22, 2)"

        ElseIf (uni("destino").ToString().Contains("MEXICO") Or uni("destino").ToString().Contains("DF")) And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 24, 25, 26)"

        ElseIf (uni("destino").ToString().Contains("QUERETARO")) And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (6, 18, 24)"

        ElseIf (uni("destino").ToString().Contains("SILAO")) And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 24, 52, 55, 56, 57)"

        ElseIf (uni("destino").ToString().Contains("TEXCOCO")) And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 24, 25, 26)"

        ElseIf (uni("destino").ToString().Contains("AGUASCALIENTES")) And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 20, 21)"

        ElseIf uni("destino").ToString().Contains("CD. GUZMAN") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (60, 61)"

        ElseIf uni("destino").ToString().Contains("CELAYA") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 23, 46, 62)"

        ElseIf uni("destino").ToString().Contains("GOMEZ PALACIO") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 20, 23, 63, 64)"

        ElseIf uni("destino").ToString().Contains("HERMOSILLO") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 19, 23, 65, 66, 67, 68)"

        ElseIf uni("destino").ToString().Contains("LEON") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 19, 23, 52, 54)"

        ElseIf uni("destino").ToString().Contains("PEDRO ESCOBEDO") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18,23, 69)"

        ElseIf uni("destino").ToString().Contains("RAMOS ARIZPE") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 19, 20, 21, 23, 70, 71, 72, 73)"

        ElseIf uni("destino").ToString().Contains("TECOMAN") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (23, 74)"

        ElseIf uni("destino").ToString().Contains("TEPIC") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 23, 65, 66)"

        ElseIf uni("destino").ToString().Contains("ALTAMIRA") And uni("id_area").ToString().Contains("2") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 18, 23, 37, 40)"

            '***************************************'
            '**************VERACRUZ***************'
            '***************************************'

        ElseIf (uni("destino").ToString().Contains("MEXICO") Or uni("destino").ToString().Contains("DF")) And uni("id_area").ToString().Contains("3") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (26, 27, 28)"

        ElseIf uni("destino").ToString().Contains("PUEBLA") And uni("id_area").ToString().Contains("3") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (27, 29, 30)"

        ElseIf (uni("destino").ToString().Contains("QUERETARO") Or uni("destino").ToString().Contains("QRO")) And uni("id_area").ToString().Contains("3") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (6, 27, 31)"

        ElseIf uni("destino").ToString().Contains("HUEHUETOCA") And uni("id_area").ToString().Contains("3") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (12, 27, 32)"

        ElseIf uni("destino").ToString().Contains("TLAXCALA") And uni("id_area").ToString().Contains("3") Then

            Return "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (27, 33)"

        End If
    End Function

    Private Sub filtrarFila(ByRef unidad As DataGridViewRow)

        If (unidad.Cells("colStatus").Value.ToString().Contains("REGRESO") Or unidad.Cells("colStatus").Value.ToString().Contains("TRANSITO")) And Not unidad.Cells("colEstaEnRuta").Value.ToString().Contains("N/A") Then

            If unidad.Cells("colEstaEnRuta").Value = "SI" And Not unidad.Cells("colTiempoEstacionada").Value.ToString().Equals("00:00:00") Then

                unidad.DefaultCellStyle.BackColor = Color.YellowGreen
                unidad.DefaultCellStyle.ForeColor = Color.White

            End If

            If unidad.Cells("colEstaEnRuta").Value.ToString().Equals("SI") And Not unidad.Cells("colTiempoMismoSitio").Value.ToString.Equals("00:00:00") Then

                unidad.DefaultCellStyle.BackColor = Color.Yellow
                unidad.DefaultCellStyle.ForeColor = Color.Blue

            End If

            If unidad.Cells("colEstaEnRuta").Value.ToString().Equals("NO") Then

                unidad.DefaultCellStyle.BackColor = Color.Red
                unidad.DefaultCellStyle.ForeColor = Color.White

            End If

            If unidad.Cells("colSitio").Value.ToString().Contains("PRO -") Or unidad.Cells("colSitio").Value.ToString().Contains("PROV -") Or unidad.Cells("colObservaciones").Value.ToString().Contains("ACCIDENTADA") Or unidad.Cells("colObservaciones").Value.ToString().Contains("CORRALON") Or unidad.Cells("colObservaciones").Value.ToString().Contains("ROBADA") Or unidad.Cells("colObservaciones").Value.ToString().Contains("TALLER") Then

                unidad.DefaultCellStyle.BackColor = Color.Orange
                unidad.DefaultCellStyle.ForeColor = Color.White
                unidad.Cells("colEstaEnRuta").Value = "ACC"

            End If

            If unidad.Cells("colEstaEnRuta").Value = "SI" And unidad.Cells("colTiempoEstacionada").Value.ToString().Equals("00:00:00") And unidad.Cells("colTiempoMismoSitio").Value.ToString.Equals("00:00:00") Then

                unidad.Visible = False

            End If
        Else

            unidad.Visible = False

        End If
    End Sub

    Private Sub evaluarSitio(ByVal sitio As String, ByVal tiempoEnMismoSitio As String, ByVal unidad As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim alerta As Alerta
        Dim tiempo As String
        Dim consulta As String

        Try

            consulta = "SELECT ISNULL((SELECT TOP(1) tiempoEstimado FROM Trafico_TramosSinSeñal_Satelital (NOLOCK) WHERE geocercas LIKE '%" & sitio & "%'), '')"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            tiempo = comando.ExecuteScalar().ToString()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
            SqlConnection.ClearPool(conexion)

            If Not String.IsNullOrEmpty(tiempo) Then
                If String.Compare(tiempoEnMismoSitio, tiempo) = 1 Then

                    alerta = New Alerta("Tiempo excedido en TSS", unidad, "00:00:00", sitio)
                    alerta.ShowDialog()

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar el tiempo estimado: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub checarDesconexionSatelital(ByVal unidad As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim alerta As Alerta
        Dim tiempo As String
        Dim hora As Date
        Dim consulta As String

        Try

            consulta = "SELECT TOP(1) CASE reason WHEN '49 POWER_DISCONNECTED' THEN 'Desconexion de satelital' END AS aviso, CONVERT(VARCHAR(10), fecha, 108) AS [hora] FROM TPosicion (NOLOCK) WHERE reason LIKE '%49 POWER_DISCONNECTED%' AND (fecha >= CONVERT(VARCHAR(20), GETDATE(), 105)) AND economico = '" & unidad & "' ORDER BY idTransaccion DESC, cuenta"
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
            SqlConnection.ClearPool(conexion)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    hora = Convert.ToDateTime(dS.Tables(0).Rows(0)("hora").ToString())

                    If Date.Compare(Date.Now, hora.AddMinutes(35)) < 0 Then

                        alerta = New Alerta("Desconexion de satelital", unidad, "00:00:00", "")
                        alerta.ShowDialog()

                    End If
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar desconexiones: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class