Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Collections.Generic
Imports System.Drawing

Public Class SeguimientoEmbarques

    Private hilo As Thread
    Private hiloStart As ThreadStart
    Private CallCargarInformacion As MethodInvoker

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Private Sub ContenedoresEnViaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        hiloStart = New ThreadStart(AddressOf ActualizacionesBackground)
        CallCargarInformacion = New MethodInvoker(AddressOf Me.cargarInformacion)
        hilo = New Thread(hiloStart)
        hilo.IsBackground = True
        hilo.Name = "Actualizar"
        hilo.Start()
        predeterminarColumnas()
        Me.rBTodo.Checked = True
        Me.gridInfo.Font = New Font("Ubuntu", 16)
        Me.cmBStatus.SelectedIndex = 0

    End Sub

    Public Sub ActualizacionesBackground()

        While True

            Me.BeginInvoke(CallCargarInformacion)
            Thread.Sleep(1800000)

        End While

    End Sub

    Private Sub cargarInformacion()

        Cursor.Current = Cursors.WaitCursor
        Dim sDA As SqlDataAdapter
        Dim dS, dS1 As DataSet
        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim contenedor As DataGridViewRow
        Dim fechaCliente As DateTime
        Dim tiempo As String
        Dim sql As String
        Dim split As String()
        Dim fechaUltPos As String
        Dim unidadesEnCliente As Integer
        Dim unidadesEnRegreso As Integer
        Dim cumplieron As Integer
        Dim estatus As String
        Dim ignicion As String
        Cursor.Current = Cursors.WaitCursor
        Me.gridInfo.Rows.Clear()

        'Try

        Me.pBar.Minimum = 1
        Me.pBar.Step = 1
        Dim j As Integer
        unidadesEnCliente = 0
        unidadesEnRegreso = 0
        cumplieron = 0

        sql = "DECLARE @id INT SET @id = (SELECT TOP(1) idReporte FROM trafico_contenedores_viaje WHERE fechaReporte = CONVERT(VARCHAR(20),GETDATE(),103) ORDER BY fechaReporte DESC) SELECT * FROM trafico_contenedores_viaje_detalle WHERE idReporte = @id"
        conexion = Connection.getInstance().getConnection()
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)
        conexion.Close()
        conexion.Dispose()
        comando.Dispose()

        If dS.Tables(0).Rows.Count > 0 Then

            Me.pBar.Maximum = dS.Tables(0).Rows.Count

            For Each carga As DataRow In dS.Tables(0).Rows

                Me.gridInfo.Rows.Add()
                estatus = Me.consultarEstatus(carga("eco").ToString())
                ignicion = Me.unidadEstacionada(carga("eco").ToString())
                contenedor = Me.gridInfo.Rows(Me.gridInfo.Rows.Count - 1)
                contenedor.Cells("colFecha").Value = carga("fecha").ToString()
                contenedor.Cells("colHora").Value = carga("hora").ToString()
                contenedor.Cells("colFechaDoc").Value = Convert.ToDateTime(carga("fechaDocumentacion").ToString()).ToString("yyyy/MM/dd")
                contenedor.Cells("colEco").Value = carga("eco").ToString()
                contenedor.Cells("colPlacas").Value = carga("placas").ToString()
                contenedor.Cells("colSitio").Value = Me.sitioActual(carga("eco").ToString())
                contenedor.Cells("colViaje").Value = carga("viaje").ToString()
                contenedor.Cells("colIgnicion").Value = ignicion.Split(" ")(0)
                contenedor.Cells("colTiempoEstacionada").Value = ignicion.Split(" ")(1)
                contenedor.Cells("colAlerta").Value = Me.consultarAlerta(carga("eco").ToString())
                contenedor.Cells("colCartaPorte").Value = carga("cartaPorte").ToString()
                contenedor.Cells("colFechaSalPatio2").Value = carga("fechaSalidaPatio2").ToString()
                contenedor.Cells("colHoraSalPatio2").Value = carga("horaSalidaPatio2").ToString()
                contenedor.Cells("colEquipoArrastre").Value = carga("equipoArrastre").ToString()
                contenedor.Cells("colTipoRemolques").Value = carga("tipoRemolques").ToString()
                contenedor.Cells("colCel").Value = carga("cel").ToString()
                contenedor.Cells("colOperador").Value = carga("operador").ToString()
                contenedor.Cells("colCliente").Value = carga("cliente").ToString()
                contenedor.Cells("colReferencia").Value = carga("referencia").ToString()
                contenedor.Cells("colTipoOperacion").Value = carga("tipoOperacion").ToString()
                contenedor.Cells("colContenedor").Value = carga("contenedor").ToString()
                contenedor.Cells("colFechaProgEnt").Value = carga("fechaProgramadaEntrega").ToString()
                contenedor.Cells("colDestino").Value = carga("destino").ToString()
                contenedor.Cells("colRuta").Value = carga("ruta").ToString()
                contenedor.Cells("colFueraRuta").Value = Me.estaEnRuta(carga("eco").ToString(), estatus.Split("-")(0), contenedor.Cells("colSitio").Value.ToString(), carga("destino").ToString())
                contenedor.Cells("colStatus").Value = estatus.Split("-")(0)
                contenedor.Cells("colHoraStatus").Value = estatus.Split("-")(1).Split(" ")(1).Substring(0, 5)
                contenedor.Cells("colComentarios").Value = carga("comentarios").ToString()

                If Not contenedor.Cells("colStatus").Value.ToString().Equals("") Then

                    fechaUltPos = estatus.Split("-")(1)

                    If Not fechaUltPos.Equals("") Then

                        contenedor.Cells("colStatus").Value = contenedor.Cells("colStatus").Value.ToString().Split("-")(0)
                        contenedor.Cells("colTiempo").Value = Me.sacarTiempo(fechaUltPos)

                        If Convert.ToInt16(contenedor.Cells("colTiempo").Value.ToString().Split(" ")(0)) >= 1 Then
                            If contenedor.Cells("colStatus").Value.ToString().Contains("PATIO") Or contenedor.Cells("colStatus").Value.ToString().Contains("CLIENTE") Then

                                contenedor.DefaultCellStyle.BackColor = Color.GreenYellow

                            Else

                                contenedor.DefaultCellStyle.BackColor = Color.Yellow

                            End If
                        End If
                    End If

                    If contenedor.Cells("colStatus").Value.ToString.Contains("CLIENTE") Then

                        unidadesEnCliente += 1

                    End If

                    If contenedor.Cells("colStatus").Value.ToString.Contains("REGRESO") Then

                        unidadesEnRegreso += 1

                    End If
                End If

                If contenedor.Cells("colStatus").Value.ToString.Contains("REGRESO") Or contenedor.Cells("colStatus").Value.ToString.Contains("CLIENTE") Then
                    If Not String.IsNullOrEmpty(carga("fechaProgramadaEntrega").ToString()) Then

                        fechaCliente = Me.fechaLlegadaCliente(contenedor.Cells("colEco").Value.ToString())

                        If Convert.ToDateTime(carga("fechaProgramadaEntrega").ToString() & " 00:00:00.000").ToString("yyyyMMdd") >= fechaCliente.ToString("yyyyMMdd") Then

                            cumplieron += 1
                            contenedor.Cells("colLlegoATiempo").Value = "SI"

                        Else

                            contenedor.Cells("colLlegoATiempo").Value = "NO"

                        End If
                    Else

                        contenedor.Cells("colLlegoATiempo").Value = ""

                    End If
                Else

                    contenedor.Cells("colLlegoATiempo").Value = ""

                End If

                Me.pBar.PerformStep()
                Me.gridInfo.Sort(Me.gridInfo.Columns("colStatus"), System.ComponentModel.ListSortDirection.Descending)
                Me.filtrarInformacion()
                Me.gridInfo.Update()

            Next

            Me.pBar.Step = 1
            Me.pBar.Value = 1
            Me.guardarReporte()
            'MessageBox.Show("Unidades en cliente: " & unidadesEnCliente & vbCrLf & "Unidades en regreso: " & unidadesEnRegreso & vbCrLf & "Cumplieron: " & cumplieron)
            Exit Sub
        End If

        conexion = Connection.getInstance().getConnection()
        comando = New SqlCommand("UP_Seguimiento_Contenedores", conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)
        conexion.Close()
        conexion.Dispose()
        comando.Dispose()

        If dS.Tables(0).Rows.Count > 0 Then

            Me.pBar.Maximum = dS.Tables(0).Rows.Count

            For Each carga As DataRow In dS.Tables(0).Rows

                estatus = Me.consultarEstatus(carga("eco"))
                carga("status") = estatus
                carga.AcceptChanges()

                If Not carga("status").ToString().Equals("") Then

                    fechaUltPos = carga("status").ToString().Split("-")(1)

                    If Not fechaUltPos.Equals("") Then

                        carga("status") = carga("status").ToString().Split("-")(0)
                        carga("tiempo") = Me.sacarTiempo(fechaUltPos)

                    End If

                    If carga("status").ToString().Contains("CLIENTE") Then

                        unidadesEnCliente += 1

                    End If

                    If carga("status").ToString().Contains("REGRESO") Then

                        unidadesEnRegreso += 1

                    End If
                End If

                carga.AcceptChanges()

                If Not carga("status").ToString().Contains("CLIENTE") Or Not carga("status").ToString().Contains("PATIO") Then

                    sql = "SELECT TOP (1)  fechaHora = CONVERT(VARCHAR(20), fecha, 111) + ' ' + CONVERT(VARCHAR(20), fecha, 114) FROM TPosicion WHERE economico = '" & carga("eco").ToString() & "' AND proximidadciudad LIKE '%ID - SALIDA LIB ALTAMIRA%' ORDER BY fecha DESC SELECT TOP(1) fechaSalidaPatio2 = CONVERT(VARCHAR(20), horaRecepcion, 111) + ' ' + CONVERT(VARCHAR(20), horaRecepcion, 108) FROM TPosicion WHERE economico = '" & carga("eco").ToString() & "' COLLATE SQL_Latin1_General_CP1_CI_AS AND proximidadciudad LIKE '%TER - PATIO 2%' ORDER BY fecha DESC"
                    conexion = Connection.getInstance().getConnectionQSP()
                    conexion.Open()
                    comando = New SqlCommand(sql, conexion)
                    comando.CommandType = CommandType.Text
                    comando.CommandTimeout = 1000
                    sDA = New SqlDataAdapter(comando)
                    dS1 = New DataSet()
                    sDA.Fill(dS1)

                    If dS1.Tables(0).Rows.Count > 0 Then

                        carga("fechaSalida") = dS1.Tables(0).Rows(0)("fechaHora").ToString().Split(" ")(0)
                        carga("horaSalida") = dS1.Tables(0).Rows(0)("fechaHora").ToString().Split(" ")(1).Substring(0, 5)

                    End If

                    If dS1.Tables(1).Rows.Count > 0 Then

                        carga("fechaSalidaPatio2") = dS1.Tables(1).Rows(0)("fechaSalidaPatio2").ToString().Split(" ")(0)
                        carga("horaSalidaPatio2") = dS1.Tables(1).Rows(0)("fechaSalidaPatio2").ToString().Split(" ")(1).Substring(0, 5)

                    End If

                    comando.Dispose()
                    conexion.Close()

                End If

                If Not String.IsNullOrEmpty(carga("tipoRemolques").ToString()) Then

                    carga("tipoRemolques") = IIf(carga("tipoRemolques").ToString().Split(",").Length > 1, carga("tipoRemolques").ToString().Split(",")(0).Split(" ")(0).Substring(0, 2) & " " & carga("tipoRemolques").ToString().Split(",")(0).Split(" ")(1) & ", " & carga("tipoRemolques").ToString().Split(",")(1).TrimStart().Split(" ")(0).Substring(0, 2) & " " & carga("tipoRemolques").ToString().Split(",")(1).TrimStart().Split(" ")(1), carga("tipoRemolques").ToString().Split(",")(0).Split(" ")(0).Substring(0, 2) & " " & carga("tipoRemolques").ToString().Split(",")(0).Split(" ")(1))

                End If

                If carga("status").ToString().Contains("REGRESO") Or carga("status").ToString().Contains("CLIENTE") Then
                    If Not String.IsNullOrEmpty(carga("fechaProgEnt").ToString()) Then

                        fechaCliente = Me.fechaLlegadaCliente(carga("eco").ToString().ToString())

                        If Convert.ToDateTime(carga("fechaProgEnt").ToString() & " 00:00:00.000").ToString("yyyyMMdd") <= DateTime.Now.ToString("yyyyMMdd") Then

                            cumplieron += 1
                            carga("llegoATiempo") = "SI"

                        Else

                            carga("llegoATiempo") = "NO"

                        End If
                    Else

                        carga("llegoATiempo") = ""
                        fechaCliente = Nothing

                    End If
                Else

                    carga("llegoATiempo") = ""
                    fechaCliente = Nothing

                End If

                Me.gridInfo.Rows.Add()
                ignicion = Me.unidadEstacionada(carga("eco").ToString())
                contenedor = Me.gridInfo.Rows(Me.gridInfo.Rows.Count - 1)
                contenedor.Cells("colFecha").Value = carga("fechaSalida").ToString()
                contenedor.Cells("colHora").Value = carga("horaSalida").ToString()
                contenedor.Cells("colFechaDoc").Value = Convert.ToDateTime(carga("fechaDocumentacion").ToString()).ToString("yyyy/MM/dd")
                contenedor.Cells("colEco").Value = carga("eco").ToString()
                contenedor.Cells("colPlacas").Value = carga("placas").ToString()
                contenedor.Cells("colSitio").Value = Me.sitioActual(carga("eco").ToString())
                contenedor.Cells("colViaje").Value = carga("viaje").ToString()
                contenedor.Cells("colIgnicion").Value = ignicion.Split(" ")(0)
                contenedor.Cells("colTiempoEstacionada").Value = ignicion.Split(" ")(1)
                contenedor.Cells("colAlerta").Value = Me.consultarAlerta(carga("eco").ToString())
                contenedor.Cells("colCartaPorte").Value = carga("cartaPorte").ToString()
                contenedor.Cells("colFechaSalPatio2").Value = carga("fechaSalidaPatio2").ToString()
                contenedor.Cells("colHoraSalPatio2").Value = carga("horaSalidaPatio2").ToString()
                contenedor.Cells("colEquipoArrastre").Value = carga("equipoArrastre").ToString()
                contenedor.Cells("colTipoRemolques").Value = carga("tipoRemolques").ToString()
                contenedor.Cells("colTiempo").Value = carga("tiempo").ToString()
                contenedor.Cells("colCel").Value = carga("cel").ToString()
                contenedor.Cells("colOperador").Value = carga("operador").ToString()
                contenedor.Cells("colCliente").Value = carga("cliente").ToString()
                contenedor.Cells("colReferencia").Value = carga("referencia").ToString()
                contenedor.Cells("colTipoOperacion").Value = carga("tipoOperacion").ToString()
                contenedor.Cells("colContenedor").Value = carga("contenedores").ToString()
                contenedor.Cells("colFechaProgEnt").Value = carga("fechaProgEnt").ToString()
                contenedor.Cells("colFechaCliente").Value = IIf(Not fechaCliente.ToString("dd/MM/yyyy").Equals("01/01/0001"), fechaCliente, "")
                contenedor.Cells("colLlegoATiempo").Value = carga("llegoATiempo")
                contenedor.Cells("colDestino").Value = carga("destino").ToString()
                contenedor.Cells("colRuta").Value = carga("ruta").ToString()
                contenedor.Cells("colStatus").Value = carga("status").ToString()
                contenedor.Cells("colHoraStatus").Value = estatus.Split("-")(1).Split(" ")(1).Substring(0, 5)
                contenedor.Cells("colComentarios").Value = carga("comentarios").ToString()

                If Not contenedor.Cells("colTiempo").Value.ToString().Equals("") Then
                    If Convert.ToInt16(contenedor.Cells("colTiempo").Value.ToString().Split(" ")(0)) >= 1 Then
                        If contenedor.Cells("colStatus").Value.ToString().Contains("PATIO") Or contenedor.Cells("colStatus").Value.ToString().Contains("CLIENTE") Then

                            contenedor.DefaultCellStyle.BackColor = Color.GreenYellow

                        Else

                            contenedor.DefaultCellStyle.BackColor = Color.Yellow

                        End If
                    End If
                End If

                If carga("status").ToString().ToString().Contains("CLIENTE") Then

                    unidadesEnCliente += 1

                End If

                If carga("status").ToString().Contains("REGRESO") Then

                    unidadesEnRegreso += 1

                End If

                Me.pBar.PerformStep()
                Me.gridInfo.Sort(Me.gridInfo.Columns("colStatus"), System.ComponentModel.ListSortDirection.Descending)
                Me.filtrarInformacion()
                Me.gridInfo.Update()

            Next

            Me.guardarReporte()

        End If

        Me.pBar.Step = 1
        Me.pBar.Value = 1

        'Catch ex As Exception

        '    MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End Try

        Cursor.Current = Cursors.Arrow

    End Sub

    Private Function sitioActual(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sitio As String
        Dim consulta As String

        Try

            consulta = "SELECT ISNULL((SELECT TOP(1) ISNULL(georeference, '') FROM TPosicion WHERE economico = '" & unidad & "' ORDER BY fecha DESC), '')"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            sitio = comando.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(sitio) Then

                consulta = "SELECT TOP(1) act.location FROM QFSActivity act LEFT JOIN QFSVehicles veh ON act.vehicleId = veh.vehicleID WHERE veh.description = '" & unidad & "' ORDER BY act.activityDateTime DESC"
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

    Private Function consultarAlerta(ByVal unidad As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String
        Dim resultado As String

        resultado = ""

        Try

            consulta = "SELECT TOP(1) CASE tipoAlerta WHEN 'EXCESO DE VELOCIDAD' THEN 'Vel' WHEN 'BOTÓN DE PÁNICO'  THEN 'Pan' END AS [alerta], CONVERT(VARCHAR(10), fecha, 108) AS [hora] FROM alertasCC WHERE (tipoAlerta LIKE '%velocidad%' OR tipoAlerta LIKE '%pánico%') AND (fecha >= CONVERT(VARCHAR(20), GETDATE(), 105)) AND alias = '" & unidad & "' ORDER BY fecha DESC"
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

    Private Function estaEnRuta(ByVal unidad As String, ByVal estatusViaje As String, ByVal sitio As String, ByVal destino As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String
        Dim area As Integer

        consulta = ""
        area = Me.consultarArea(unidad)

        If (estatusViaje.Contains("REGRESO") Or estatusViaje.Contains("TRANSITO")) And Not sitio.Contains("PRO -") And Not sitio.Contains("PROV -") And Not sitio.Contains("PEN -") Then

            '***************************************'
            '***************ALTAMIRA***************'
            '***************************************'

            If (destino.Contains("MONTERREY") Or destino.Contains("APODACA") Or destino.Contains("ESCOBEDO") Or destino.Contains("GARCIA")) And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (1, 2)"

            ElseIf (destino.Contains("SLP") Or destino.Contains("SAN LUIS POTOSI")) And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 4)"

            ElseIf (destino.Contains("QRO") Or destino.Contains("QUERETARO")) And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 5, 6)"

            ElseIf destino.Contains("SALTILLO") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (1, 7, 8)"

            ElseIf destino.Contains("ALAMO") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (9, 10)"

            ElseIf destino.Contains("HUEHUETOCA") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (9, 11, 12)"

            ElseIf destino.Contains("CD. VICTORIA") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (13, 14)"

            ElseIf destino.Contains("REYNOSA") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (13, 15, 16)"

            ElseIf destino.Contains("MARTINEZ DE LA TORRE") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (9, 17)"

            ElseIf destino.Contains("SAN JOSE ITURBIDE") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 34, 35)"

            ElseIf destino.Contains("RAMOS ARIZPE") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (1, 2, 36)"

            ElseIf destino.Contains("LAGOS DE MORENO") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 37, 39)"

            ElseIf destino.Contains("GUADALAJARA") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 19, 37, 40)"

            ElseIf (destino.Contains("SANTA ROSA JAUREGUI") Or destino.Contains("SANTA ROSA JAUREGUI *")) And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 41)"

            ElseIf destino.Contains("SAN NICOLAS DE LOS GARZA") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (1, 2)"

            ElseIf destino.Contains("SILAO") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 37, 42, 43, 44)"

            ElseIf destino.Contains("AGUASCALIENTES") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 47)"

            ElseIf destino.Contains("CHIHUAHUA") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (1, 2, 7, 8, 48, 49, 50, 51)"

            ElseIf (destino.Contains("CELAYA") Or destino.Contains("APASEO EL GRANDE")) And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (3, 4, 41, 45)"

            ElseIf destino.Contains("BENITO JUAREZ") And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (1, 2)"

            ElseIf (destino.Contains("GOMEZ PALACIO") Or destino.Contains("TORREON")) And area = 1 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (1, 2, 7, 8, 48, 49)"

                '***************************************'
                '*************MANZANILLO**************'
                '***************************************'

            ElseIf (destino.Contains("GUADALAJARA") Or destino.Contains("GDL")) And area = 2 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (18, 19)"

            ElseIf destino.Contains("MONTERREY") And area = 2 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (18, 20, 22, 2)"

            ElseIf (destino.Contains("MEXICO") Or destino.Contains("DF")) And area = 2 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (18, 24, 25, 26)"

            ElseIf (destino.Contains("QUERETARO") Or destino.Contains("QRO")) And area = 2 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (6, 18, 24)"

                '***************************************'
                '**************VERACRUZ***************'
                '***************************************'

            ElseIf (destino.Contains("MEXICO") Or destino.Contains("DF")) And area = 3 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (26, 27, 28)"

            ElseIf destino.ToString().Contains("PUEBLA") And area = 3 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (27, 29, 30)"

            ElseIf (destino.Contains("QUERETARO") Or destino.Contains("QRO")) And area = 3 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (6, 27, 31)"

            ElseIf destino.Contains("HUEHUETOCA") And area = 3 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (12, 27, 32)"

            ElseIf destino.Contains("TLAXCALA") And area = 3 Then

                consulta = "SELECT nombre FROM Trafico_Tramos_Satelital WHERE idRuta in (27, 33)"

            End If

            If Not String.IsNullOrEmpty(consulta) And Not destino.Contains("PRO -") And Not destino.Contains("PEN -") Then

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
                            If sitio.Contains(registro("nombre").ToString()) Then

                                estaEnRuta = True
                                Exit For

                            Else

                                estaEnRuta = False

                            End If
                        Next
                    End If
                End If

                If estaEnRuta Then

                    Return "SI"

                Else

                    Return "NO"

                End If
            Else

                If sitio.Contains("desconocida") Then

                    Return "NO"

                Else

                    Return "N/A"

                End If
            End If
        Else

            Return "N/A"

        End If
    End Function

    Private Function consultarArea(ByVal unidad As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String
        Dim area As Integer
        area = 0

        Try

            consulta = "SELECT id_area FROM mtto_unidades WHERE id_unidad = '" & unidad & "'"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            area = Convert.ToInt32(comando.ExecuteScalar())
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al consultar la unidad: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return area

    End Function

    Private Function unidadEstacionada(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim respaldo As DataRow
        Dim consulta As String
        Dim resultado As String

        Try

            consulta = "SELECT economico, CASE ignicion WHEN 'Encendido' THEN 'ON' ELSE 'OFF' END AS [ignicion], velocidad, fecha FROM TPosicion WHERE fecha >= CONVERT(VARCHAR(10), DATEADD(dd, -35, GETDATE()), 105) AND economico = '" & unidad & "' ORDER BY fecha DESC"
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

                    If minutos >= 5 And segundos >= 0 Then

                        resultado = respaldo("ignicion").ToString() & " " & IIf(horas < 10, "0" & horas, horas) & ":" & IIf(minutos < 10, "0" & minutos, minutos) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

                    Else

                        resultado = respaldo("ignicion").ToString() & " 00:00:00"

                    End If
                Else

                    consulta = "SELECT veh.[description] AS economico, CASE act.ignitionOn WHEN 1 THEN 'ON' ELSE 'OFF' END AS ignicion, act.speed AS velocidad, act.activityDateTime AS fecha FROM QFSActivity act LEFT JOIN QFSVehicles veh ON act.vehicleId = veh.vehicleID WHERE act.activityDateTime >= CONVERT(VARCHAR(10), DATEADD(dd, -5, GETDATE()), 105)AND veh.[description] = '" & unidad & "' ORDER BY act.activityDateTime DESC"
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

                            If minutos >= 5 And segundos >= 0 Then

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

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Me.cargarInformacion()

    End Sub

    Private Sub guardarReporte()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet()

        Cursor.Current = Cursors.WaitCursor

        Try

            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand("up_repContenedoresEnViaje_ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 1000
            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()

            For Each contenedor As DataGridViewRow In Me.gridInfo.Rows
                If contenedor.Cells("colTiempo").Value IsNot Nothing Then

                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand("up_repContenedoresEnViaje_detalle_ins", conexion)

                    With comando.Parameters

                        .AddWithValue("@fechaSalida", contenedor.Cells("colFecha").Value.ToString())
                        .AddWithValue("@horaSalida", contenedor.Cells("colHora").Value.ToString())
                        .AddWithValue("@fechaDoc", Convert.ToDateTime(contenedor.Cells("colFechaDoc").Value.ToString()))
                        .AddWithValue("@eco", contenedor.Cells("colEco").Value.ToString())
                        .AddWithValue("@placas", contenedor.Cells("colPlacas").Value.ToString())
                        .AddWithValue("@viaje", contenedor.Cells("colViaje").Value.ToString())
                        .AddWithValue("@cartaPorte", contenedor.Cells("colCartaPorte").Value.ToString())
                        .AddWithValue("@fechaSalPatio2", contenedor.Cells("colfechaSalPatio2").Value.ToString())
                        .AddWithValue("@horaSalPatio2", contenedor.Cells("colhoraSalPatio2").Value.ToString())
                        .AddWithValue("@cel", contenedor.Cells("colCel").Value.ToString())
                        .AddWithValue("@operador", contenedor.Cells("colOperador").Value.ToString())
                        .AddWithValue("@cliente", contenedor.Cells("colCliente").Value.ToString())
                        .AddWithValue("@referencia", contenedor.Cells("colReferencia").Value.ToString())
                        .AddWithValue("@tipoOperacion", contenedor.Cells("colTipoOperacion").Value.ToString())
                        .AddWithValue("@contenedor", contenedor.Cells("colContenedor").Value.ToString())
                        .AddWithValue("@fechaProgEnt", contenedor.Cells("colFechaProgEnt").Value.ToString())
                        .AddWithValue("@llegoATiempo", contenedor.Cells("colLlegoATiempo").Value.ToString())
                        .AddWithValue("@equipoArrastre", contenedor.Cells("colEquipoArrastre").Value.ToString())
                        .AddWithValue("@tipoRemolques", contenedor.Cells("colTipoRemolques").Value.ToString())
                        .AddWithValue("@destino", contenedor.Cells("colDestino").Value.ToString())
                        .AddWithValue("@ruta", contenedor.Cells("colRuta").Value.ToString())
                        .AddWithValue("@status", contenedor.Cells("colStatus").Value.ToString())
                        .AddWithValue("@comentarios", contenedor.Cells("colComentarios").Value.ToString())
                        .AddWithValue("@tiempoSinEm", contenedor.Cells("colTiempo").Value.ToString())

                    End With

                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000
                    comando.ExecuteNonQuery()
                    conexion.Close()
                    conexion.Dispose()
                    comando.Dispose()

                End If
            Next

            Cursor.Current = Cursors.Arrow

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Hubo un problema al guardar un registro: " & ex.Message, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End Try
    End Sub

    Private Sub ContenedoresEnViaje_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Me.hilo.Suspend()

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click

        Excel.gridToExcel(Me.gridInfo)

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click

        Me.guardarReporte()
        MessageBox.Show("El reporte se ha guardado correctamente", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Function sacarTiempo(ByVal fecha As String) As String

        Dim fechaInicial As New DateTime(Convert.ToInt32(fecha.Split(" ")(0).Split("/")(2)), Convert.ToInt32(fecha.Split(" ")(0).Split("/")(1)), Convert.ToInt32(fecha.Split(" ")(0).Split("/")(0)), Convert.ToInt32(fecha.Split(" ")(1).Split(":")(0)), Convert.ToInt32(fecha.Split(" ")(1).Split(":")(1)), Convert.ToInt32(fecha.Split(" ")(1).Split(":")(2)))
        Dim ts As TimeSpan = DateTime.Now.Subtract(fechaInicial)
        Dim dias As Int32 = ts.Days
        Dim horas As Int32 = ts.Hours
        Dim minutos As Int32 = ts.Minutes
        Dim segundos As Int32 = ts.Seconds

        Return IIf(dias < 10, "0" & dias, dias) & " d " & IIf(horas < 10, "0" & horas, horas) & " h " & IIf(minutos < 10, "0" & minutos, minutos) & " m"

    End Function

    Private Sub SelectorDeColumnasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectorDeColumnasToolStripMenuItem.Click

        Dim selector As SelectorColumnas = New SelectorColumnas(Me)
        selector.ShowDialog(Me)

    End Sub

    Private Sub predeterminarColumnas()

        For Each columna As DataGridViewColumn In Me.gridInfo.Columns
            If columna.Name.Equals("colFecha") Or columna.Name.Equals("colHora") Or columna.Name.Equals("colEco") Or columna.Name.Equals("colCel") Or columna.Name.Equals("colOperador") Or columna.Name.Equals("colCliente") Or columna.Name.Equals("colReferencia") Or columna.Name.Equals("colContenedor") Or columna.Name.Equals("colDestino") Or columna.Name.Equals("colStatus") Or columna.Name.Equals("colComentarios") Then

                columna.Visible = True

            Else

                columna.Visible = False

            End If
        Next
    End Sub

    Private Sub filtrarInformacion()

        If Me.gridInfo.Rows.Count > 0 Then
            For Each embarque As DataGridViewRow In Me.gridInfo.Rows
                If Me.rBTodo.Checked Then

                    embarque.Visible = True

                ElseIf Me.rBFechaSal.Checked Then
                    If Not String.IsNullOrEmpty(embarque.Cells("colFecha").Value.ToString()) Then
                        If Convert.ToDateTime(embarque.Cells("colFecha").Value.ToString()).ToString("yyyyMMdd").Equals(Me.dTPFecha.Value.ToString("yyyyMMdd")) Then

                            embarque.Visible = True

                        Else

                            embarque.Visible = False

                        End If
                    Else

                        embarque.Visible = False

                    End If
                ElseIf Me.rBEstatus.Checked Then
                    If embarque.Cells("colStatus").Value.ToString().Equals(Me.cmBStatus.SelectedItem.ToString()) Then

                        embarque.Visible = True

                    Else

                        embarque.Visible = False

                    End If
                ElseIf Me.rBFechaDoc.Checked Then
                    If embarque.Cells("colFechaDoc").Value.ToString().Equals(Me.dTPFechaDoc.Value.ToString("yyyy/MM/dd")) Then

                        embarque.Visible = True

                    Else

                        embarque.Visible = False

                    End If
                End If
            Next
        End If
    End Sub

    Private Sub gridInfo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridInfo.CellDoubleClick

        If e.ColumnIndex = Me.gridInfo.Columns.Item("colEco").Index Then

            Dim captura As CaptSeguimientoEmbarques = New CaptSeguimientoEmbarques(Me.gridInfo.CurrentRow.Cells("colEco").Value.ToString())
            captura.ShowDialog(Me)

        End If
    End Sub

    Private Function fechaLlegadaCliente(ByVal unidad) As DateTime

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        Try

            sql = "DECLARE @salida DATETIME SET @salida = dbo.UDF_CONSULTA_ULTIMA_SALIDAQSP('" & unidad & "') SELECT TOP(1) fecha FROM TPosicion WHERE economico = '" & unidad & "' AND fecha >= @salida AND proximidadCiudad LIKE '%CL -%' ORDER BY fecha"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            conexion.Open()
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Return Convert.ToDateTime(dS.Tables(0).Rows(0)(0).ToString())

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error al consultar la fecha con cliente: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing

        End Try
    End Function

    Private Sub EstadìsticasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadìsticasToolStripMenuItem.Click

        Dim estadisticas As Estadisticas = New Estadisticas(Me.gridInfo)
        estadisticas.ShowDialog(Me)

    End Sub

    Private Sub dTPFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dTPFecha.ValueChanged, dTPFechaDoc.ValueChanged

        Me.filtrarInformacion()

    End Sub

    Private Sub cmBStatus_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmBStatus.SelectionChangeCommitted

        Me.filtrarInformacion()

    End Sub

    Private Sub rBTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBTodo.CheckedChanged, rBFechaSal.CheckedChanged, rBFechaDoc.CheckedChanged, rBEstatus.CheckedChanged

        Me.filtrarInformacion()

    End Sub
End Class