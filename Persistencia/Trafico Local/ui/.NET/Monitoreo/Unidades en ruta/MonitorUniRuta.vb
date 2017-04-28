Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Net
Imports System.Net.Mail

Public Class MonitorUniRuta

    Private hilo As Thread
    Private hiloStart As ThreadStart
    Private CallCargarInformacion As MethodInvoker

    Private Sub MonitorUniRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Cursor.Current = Cursors.WaitCursor
        Me.crearAlertaApertura()
        Me.WindowState = FormWindowState.Maximized
        hiloStart = New ThreadStart(AddressOf ActualizacionesBackground)
        CallCargarInformacion = New MethodInvoker(AddressOf Me.consultarInformacion)
        hilo = New Thread(hiloStart)
        hilo.IsBackground = True
        hilo.Name = "Actualizar"
        hilo.Start()
        Me.dGVMonitor.DefaultCellStyle.Font = New Font("Ubuntu", 16)
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub MonitorUniRuta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.hilo.Suspend()
        Me.crearAlertaCierre()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Me.exportarInfo(Me.dGVMonitor)

    End Sub

    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.consultarInformacion()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub dGVMonitor_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVMonitor.CellClick

        If Me.dGVMonitor.SelectedRows.Count > 0 Then

            Me.rTBComentarios.Text = Me.consultarObservaciones(Me.dGVMonitor.SelectedRows(0).Cells("colUnidad").Value.ToString())

        End If
    End Sub

    Private Sub dGVMonitor_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVMonitor.CellDoubleClick

        Dim observaciones As String
        Dim registro As DataGridViewRow

        registro = Me.dGVMonitor.SelectedRows(0)
        observaciones = InputBox("Ingrese las observaciones:", "Editar / Agregar", "")

        If Not String.IsNullOrEmpty(observaciones) Then

            registro.Cells("colObservaciones").Value = observaciones
            Me.guardarComentarios(Me.dGVMonitor.SelectedRows(0).Cells("colUnidad").Value.ToString(), observaciones)

        End If
    End Sub

    Public Sub ActualizacionesBackground()

        While True

            Me.BeginInvoke(CallCargarInformacion)
            Thread.Sleep(1200000)

        End While
    End Sub

    Private Sub consultarInformacion()

        Dim tiempoEstacionada As String
        Dim tiempoMismoSitio As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim fila As DataGridViewRow
        Dim sDA As SqlDataAdapter
        Dim unidades As String
        Dim consulta As String
        Dim dS As DataSet

        Try

            Me.dGVMonitor.Rows.Clear()
            Me.pBar.Minimum = 1
            Me.pBar.Step = 1
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand("UP_Monitor_Rutas", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            conexion.Open()
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
            unidades = ""

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each unidad As DataRow In dS.Tables(0).Rows

                        tiempoEstacionada = Me.tiempoUnidadEstacionada(unidad("fechaEstacionada").ToString())
                        tiempoMismoSitio = Me.tiempoMismoSitio(unidad("fechaEntradaSitio").ToString())

                        fila = Me.dGVMonitor.Rows(Me.dGVMonitor.Rows.Add())
                        fila.Cells("colUnidad").Value = unidad("unidad").ToString()
                        fila.Cells("colFlota").Value = unidad("flota").ToString()
                        fila.Cells("colSitio").Value = unidad("sitio").ToString()
                        fila.Cells("colDestino").Value = unidad("destino").ToString()
                        fila.Cells("colStatus").Value = unidad("status").ToString()
                        fila.Cells("colHora").Value = unidad("horaEstatus").ToString()
                        fila.Cells("colIgnicion").Value = unidad("ignicion").ToString()
                        fila.Cells("colTiempoEstacionada").Value = tiempoEstacionada
                        fila.Cells("colTiempoMismoSitio").Value = tiempoMismoSitio
                        fila.Cells("colObservaciones").Value = Me.consultarObservaciones(unidad("unidad").ToString())
                        'consulta = Me.consultarTramos(unidad)
                        'fila.Cells("colEstaEnRuta").Value = IIf(Me.estanRuta(consulta, unidad("sitio").ToString()) = True, "SI", "NO")
                        fila.Cells("colEstaEnRuta").Value = IIf(Not unidad("sitio").ToString().Contains("desconocida"), "SI", "NO")
                        Me.dGVMonitor.Update()
                        Me.filtrarInformacion(fila)
                        Me.pBar.PerformStep()
                        Me.dGVMonitor.Update()

                        If Not Environment.MachineName.Contains("DAH-100") And Not Environment.MachineName.Contains("DAH-171") Then
                            'If Not Environment.MachineName.Contains("DAH-100") Then

                            Me.evaluarSitio(unidad("sitio").ToString(), tiempoMismoSitio, unidad("unidad").ToString())
                            Me.checarDesconexionSatelital(unidad("unidad").ToString())
                            Me.checarSabotajeBPanico(unidad("unidad").ToString())

                            If unidad("sitio").ToString().Contains("desconocida") Then

                                Me.enviarAlertaFueraRuta(unidad("unidad").ToString(), fila.Cells("colObservaciones").Value.ToString())
                                fila.Cells("colObservaciones").Value = Me.consultarObservaciones(unidad("unidad").ToString())

                            End If
                        Else
                            If Not Me.estaPosicionando(Convert.ToDateTime(unidad("fechaUltimaTran").ToString()), unidad("ignicion").ToString()) Then

                                If Not consultarObservaciones(unidad("unidad")).ToString().Contains("SENDOFF") Then

                                    unidades += unidad("unidad").ToString() & " - " & ultimaUbicacion(unidad("unidad").ToString()) & ", " & vbCrLf

                                End If
                            End If
                        End If
                    Next

                    If Not String.IsNullOrEmpty(unidades) Then

                        unidades = unidades.Substring(0, unidades.Length - 4)
                        Me.enviarCorreo(unidades)

                    End If

                    Me.pBar.Step = 1
                    Me.pBar.Value = 1
                    Me.dGVMonitor.Sort(Me.dGVMonitor.Columns("colEstaEnRuta"), System.ComponentModel.ListSortDirection.Descending)
                    Me.dGVMonitor.Update()

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar los viajes: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function consultarTramos(ByVal uni As DataRow) As String

        Dim consulta As String
        consulta = ""

        '***************************************'
        '***************ALTAMIRA***************'
        '***************************************'

        If (uni("destino").ToString().Contains("MONTERREY") Or uni("destino").ToString().Contains("APODACA") Or uni("destino").ToString().Contains("ESCOBEDO") Or uni("destino").ToString().Contains("GARCIA") Or uni("destino").ToString().Contains("CIENEGA DE FLORES") Or uni("destino").ToString().Contains("GUADALUPE") Or uni("destino").ToString().Contains(", NL")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2)"

        ElseIf (uni("destino").ToString().Contains("SLP") Or uni("destino").ToString().Contains("SAN LUIS POTOSI")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 4)"

        ElseIf (uni("destino").ToString().Contains("QRO") Or uni("destino").ToString().Contains("QUERETARO")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 5, 6)"

        ElseIf (uni("destino").ToString().Contains("SALTILLO") Or uni("destino").ToString().Contains("COAH")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 7, 8)"

        ElseIf uni("destino").ToString().Contains("ALAMO") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (9, 10)"

        ElseIf (uni("destino").ToString().Contains("HUEHUETOCA") Or uni("destino").ToString().Contains("CUAUTITLAN IZCALLI")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (9, 11, 12)"

        ElseIf uni("destino").ToString().Contains("CD. VICTORIA") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (13, 14)"

        ElseIf uni("destino").ToString().Contains("REYNOSA") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (13, 15, 16)"

        ElseIf uni("destino").ToString().Contains("MARTINEZ DE LA TORRE") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (9, 17)"

        ElseIf uni("destino").ToString().Contains("PASO LARGO") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (9, 59)"

        ElseIf uni("destino").ToString().Contains("SAN JOSE ITURBIDE") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 34, 35)"

        ElseIf uni("destino").ToString().Contains("RAMOS ARIZPE") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2, 36)"

        ElseIf uni("destino").ToString().Contains("LAGOS DE MORENO") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 37, 39)"

        ElseIf uni("destino").ToString().Contains("GUADALAJARA") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 19, 37, 40)"

        ElseIf (uni("destino").ToString().Contains("SANTA ROSA JAUREGUI") Or uni("destino").ToString().Contains("SANTA ROSA JAUREGUI *")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 41)"

        ElseIf uni("destino").ToString().Contains("SAN NICOLAS DE LOS GARZA") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2)"

        ElseIf uni("destino").ToString().Contains("SILAO") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 37, 42, 43, 44)"

        ElseIf uni("destino").ToString().Contains("AGUASCALIENTES") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 47)"

        ElseIf (uni("destino").ToString().Contains("CHIHUAHUA") Or uni("destino").ToString().Contains("CD. OBREGON") Or uni("destino").ToString().Contains("CHIH")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2, 7, 8, 48, 49, 50, 51)"

        ElseIf (uni("destino").ToString().Contains("CELAYA") Or uni("destino").ToString().Contains("APASEO EL GRANDE")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 4, 41, 45)"

        ElseIf uni("destino").ToString().Contains("BENITO JUAREZ") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2)"

        ElseIf (uni("destino").ToString().Contains("GOMEZ PALACIO") Or uni("destino").ToString().Contains("TORREON")) And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 2, 7, 8, 48, 49)"

        ElseIf uni("destino").ToString().Contains("ARTEAGA") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (1, 77)"

        ElseIf uni("destino").ToString().Contains("MANZANILLO") And uni("flota").ToString().Contains("Alt") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 18, 76)"

            '***************************************'
            '*************MANZANILLO**************'
            '***************************************'

        ElseIf (uni("destino").ToString().Contains("GUADALAJARA") Or uni("destino").ToString().Contains("GDL") Or uni("destino").ToString().Contains("EL SALTO") Or uni("destino").ToString().Contains("ZAPOPAN")) And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 19)"

        ElseIf (uni("destino").ToString().Contains("MONTERREY") Or uni("destino").ToString().Contains("NL")) And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 20, 22, 2)"

        ElseIf (uni("destino").ToString().Contains("MEXICO") Or uni("destino").ToString().Contains("DF")) And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 24, 25, 26)"

        ElseIf (uni("destino").ToString().Contains("QUERETARO")) And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (6, 18, 24)"

        ElseIf (uni("destino").ToString().Contains("SILAO")) And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 24, 52, 55, 56, 57)"

        ElseIf (uni("destino").ToString().Contains("TEXCOCO")) And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 24, 25, 26)"

        ElseIf (uni("destino").ToString().Contains("AGUASCALIENTES")) And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 20, 21)"

        ElseIf uni("destino").ToString().Contains("CD. GUZMAN") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (60, 61)"

        ElseIf uni("destino").ToString().Contains("CELAYA") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 23, 46, 62)"

        ElseIf uni("destino").ToString().Contains("GOMEZ PALACIO") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 20, 23, 63, 64)"

        ElseIf uni("destino").ToString().Contains("HERMOSILLO") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 19, 23, 65, 66, 67, 68)"

        ElseIf uni("destino").ToString().Contains("LEON") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 19, 23, 52, 54)"

        ElseIf uni("destino").ToString().Contains("PEDRO ESCOBEDO") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18,23, 69)"

        ElseIf uni("destino").ToString().Contains("RAMOS ARIZPE") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 19, 20, 21, 23, 70, 71, 72, 73)"

        ElseIf uni("destino").ToString().Contains("TECOMAN") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (23, 74)"

        ElseIf uni("destino").ToString().Contains("TEPIC") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (18, 23, 65, 66)"

        ElseIf uni("destino").ToString().Contains("ALTAMIRA") And uni("flota").ToString().Contains("Man") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (3, 18, 23, 37, 40)"

            '***************************************'
            '**************VERACRUZ***************'
            '***************************************'

        ElseIf (uni("destino").ToString().Contains("MEXICO") Or uni("destino").ToString().Contains("DF")) And uni("flota").ToString().Contains("Ver") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (26, 27, 28)"

        ElseIf uni("destino").ToString().Contains("PUEBLA") And uni("flota").ToString().Contains("Ver") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (27, 29, 30)"

        ElseIf (uni("destino").ToString().Contains("QUERETARO") Or uni("destino").ToString().Contains("QRO")) And uni("flota").ToString().Contains("Ver") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (6, 27, 31)"

        ElseIf uni("destino").ToString().Contains("HUEHUETOCA") And uni("flota").ToString().Contains("Ver") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (12, 27, 32)"

        ElseIf uni("destino").ToString().Contains("TLAXCALA") And uni("flota").ToString().Contains("Ver") Then

            consulta = "SELECT nombre FROM Trafico_Tramos_Satelital (NOLOCK) WHERE idRuta in (27, 33)"

        End If

        Return consulta

    End Function

    Private Function estanRuta(ByVal consulta As String, ByVal sitio As String) As Boolean

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim estaEnruta As Boolean
        Dim dS As DataSet

        Try
            If sitio.Contains("desconocida") Or String.IsNullOrEmpty(consulta) Then

                estaEnruta = False
                Exit Try

            End If

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

                            estaEnruta = True
                            Exit For

                        Else

                            estaEnruta = False

                        End If
                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al verificar si la unidad esta en ruta: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return estaEnruta

    End Function

    Private Function tiempoUnidadEstacionada(ByVal fechaUniEstacionada As Date) As String

        Dim resultado As String
        Dim ts As TimeSpan = DateTime.Now.Subtract(Convert.ToDateTime(fechaUniEstacionada))
        Dim dias As Int32 = ts.Days
        Dim horas As Int32 = ts.Hours
        Dim minutos As Int32 = ts.Minutes
        Dim segundos As Int32 = ts.Seconds

        If dias > 0 Or horas > 0 Or minutos >= 5 Then

            resultado = IIf(horas < 10, "0" & horas, horas) & ":" & IIf(minutos < 10, "0" & minutos, minutos) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

        Else

            resultado = "00:00:00"

        End If

        Return resultado

    End Function

    Private Function tiempoMismoSitio(ByVal fechaSitio As Date) As String

        Dim resultado As String
        Dim ts As TimeSpan = DateTime.Now.Subtract(fechaSitio)
        Dim dias As Int32 = ts.Days
        Dim horas As Int32 = ts.Hours
        Dim minutos As Int32 = ts.Minutes
        Dim segundos As Int32 = ts.Seconds

        If dias > 0 Or horas > 0 Or minutos >= 30 Then

            resultado = IIf(horas < 10, "0" & horas, horas) & ":" & IIf(minutos < 10, "0" & minutos, minutos) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

        Else

            resultado = "00:00:00"

        End If

        Return resultado

    End Function

    Private Sub filtrarInformacion(ByRef fila As DataGridViewRow)

        If fila.Cells("colObservaciones").Value.ToString().Contains("ACCIDENTADA") Or fila.Cells("colObservaciones").Value.ToString().Contains("CORRALON") Or fila.Cells("colObservaciones").Value.ToString().Contains("ROBADA") Or fila.Cells("colObservaciones").Value.ToString().Contains("TALLER") Then

            fila.DefaultCellStyle.BackColor = Color.Orange
            fila.DefaultCellStyle.ForeColor = Color.White
            fila.Cells("colEstaEnRuta").Value = "ACC"
            Exit Sub

        End If

        If fila.Cells("colEstaEnRuta").Value.ToString().Equals("NO") Then

            fila.DefaultCellStyle.BackColor = Color.Red
            fila.DefaultCellStyle.ForeColor = Color.White

        ElseIf fila.Cells("colEstaEnRuta").Value.ToString().Equals("SI") And Not fila.Cells("colTiempoMismoSitio").Value.ToString().Equals("00:00:00") Then

            fila.DefaultCellStyle.BackColor = Color.Yellow
            fila.DefaultCellStyle.ForeColor = Color.Blue

        ElseIf fila.Cells("colEstaEnRuta").Value.ToString().Equals("SI") And Not fila.Cells("colTiempoEstacionada").Value.ToString().Equals("00:00:00") Then

            fila.DefaultCellStyle.BackColor = Color.YellowGreen
            fila.DefaultCellStyle.ForeColor = Color.White

        Else

            Me.dGVMonitor.Rows.Remove(fila)

        End If
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

    Private Function consultarObservaciones(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String
        Dim observaciones As String
        observaciones = ""

        Try

            consulta = "SELECT ISNULL(observacionesMonitoreo, '') AS observaciones FROM Trafico_Auxiliar_Estatus WHERE economico = '" & unidad & "'"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            observaciones = comando.ExecuteScalar().ToString()
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al consutlar las observaciones: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return observaciones

    End Function

    Private Sub guardarComentarios(ByVal unidad As String, ByVal comentarios As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            consulta = "UPDATE Trafico_Auxiliar_Estatus SET observacionesMonitoreo = '" & comentarios & "' WHERE economico = '" & unidad & "'"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al guardar los comentarios: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
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

    Private Function estaPosicionando(ByVal fechaUltimaTran As DateTime, ByVal ignicion As String) As Boolean

        Dim dias As Int32
        Dim horas As Int32
        Dim ts As TimeSpan
        Dim minutos As Int32
        Dim segundos As Int32
        Dim resultado As Boolean

        Try

            ts = DateTime.Now.Subtract(fechaUltimaTran)
            dias = ts.Days
            horas = ts.Hours
            minutos = ts.Minutes
            segundos = ts.Seconds

            If horas < 1 And ignicion.Equals("ON") Then

                resultado = True

            ElseIf horas <= 4 And ignicion.Equals("OFF") Then

                resultado = True

            Else

                resultado = False

            End If
        Catch ex As Exception

            MessageBox.Show("Error al verificar el estado de la unidad: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return resultado

    End Function

    Private Sub enviarCorreo(ByVal unidades As String)

        Dim mensaje As MailMessage
        Dim smtp As SmtpClient
        Dim port As Integer
        Dim host As String

        Dim dominio As String

        Dim usuarioDe As String
        Dim contrasena As String
        Dim idPersonalDe As Integer

        port = 587
        host = "smtp.office365.com"
        dominio = "@hinojosa.com.mx"

        'Prueba
        idPersonalDe = 6942 'Omar
        usuarioDe = ObtenerDatosCorreo.nombreUsuario(idPersonalDe)
        contrasena = ObtenerDatosCorreo.contrasena(idPersonalDe)
        usuarioDe = usuarioDe & dominio

        Dim idPersonalPara As Integer
        Dim usuarioPara As String
        Dim idPersonalParaMelina As Integer
        Dim usuarioParaMelina As String
        Dim idPersonalParaEdith As Integer
        Dim usuarioParaEdith As String
        Dim idPersonalParaServCliente As Integer
        Dim usuarioParaServCliente As String
        Dim idPersonalParaAndres As Integer
        Dim usuarioParaAndres As String
        Dim idPersonalParaConsultor As Integer
        Dim usuarioParaConsultor As String

        Dim subject As String

        Dim message As String

        usuarioPara = usuarioDe

        idPersonalParaMelina = 492 'Melina
        usuarioParaMelina = ObtenerDatosCorreo.nombreUsuario(idPersonalParaMelina)
        usuarioParaMelina = usuarioParaMelina & dominio

        idPersonalParaEdith = 7187 'Edith
        usuarioParaEdith = ObtenerDatosCorreo.nombreUsuario(idPersonalParaEdith)
        usuarioParaEdith = usuarioParaEdith & dominio

        idPersonalParaServCliente = 10001 'Serv a Cliente
        usuarioParaServCliente = ObtenerDatosCorreo.nombreUsuario(idPersonalParaServCliente)
        usuarioParaServCliente = usuarioParaServCliente & dominio

        idPersonalParaAndres = 122 ' Andres
        usuarioParaAndres = ObtenerDatosCorreo.nombreUsuario(idPersonalParaAndres)
        usuarioParaAndres = usuarioParaAndres & dominio

        idPersonalParaConsultor = 10012 ' Consultor
        usuarioParaConsultor = ObtenerDatosCorreo.nombreUsuario(idPersonalParaConsultor)
        usuarioParaConsultor = usuarioParaConsultor & dominio

        subject = "Unidades sin emitir posición"

        message = "<h1 style='font-family: ""Verdana"";; font-size: 15px;'> <b> Las siguientes unidades no han emitido posición durante algún tiempo: </b> </h1> <br>"
        message += "<h3 style='font-family: ""Sans-serif"";; font-size: 15px;'>" & unidades & "</h3> <br>"
        message += "<h6 style='font-family: ""Calibri"";; font-size: 15px;'> Para dejar de recibir correos de ciertas unidades, favor de escribir en comentarios la palabra <b><i>SENDOFF</i></b>, ésto para no mandar correos de las unidades de las que ya se lleva un seguimiento</h6> "

        Try

            mensaje = New MailMessage()
            smtp = New SmtpClient()
            mensaje.From = New MailAddress(usuarioDe, "Sistema Interflet")
            mensaje.To.Add(usuarioPara)
            mensaje.To.Add(usuarioParaMelina)
            mensaje.To.Add(usuarioParaEdith)
            mensaje.To.Add(usuarioParaServCliente)
            mensaje.To.Add(usuarioParaAndres)
            mensaje.To.Add(usuarioParaConsultor)
            mensaje.Subject = subject
            mensaje.Body = message
            mensaje.IsBodyHtml = True
            mensaje.Priority = MailPriority.High
            smtp.EnableSsl = True
            smtp.Port = port
            smtp.Host = host
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(usuarioDe, contrasena)
            smtp.Send(mensaje)

        Catch ex As Exception

            MessageBox.Show("Error al enviar el correo: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub checarSabotajeBPanico(ByVal unidad As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim alerta As Alerta
        Dim tiempo As String
        Dim hora As Date
        Dim consulta As String

        Try

            consulta = "SELECT TOP(1) CASE tipoAlerta WHEN 'BOTÓN DE PÁNICO' THEN 'Botón de pánico' WHEN 'SABOTAJE' THEN 'Sabotaje de satelital' END AS aviso, CONVERT(VARCHAR(10), fecha, 108) AS [hora] FROM alertasCC (NOLOCK) WHERE (tipoAlerta LIKE '%SABOTAJE%' OR tipoAlerta LIKE '%PÁNICO%') AND (fecha >= CONVERT(VARCHAR(20), GETDATE(), 105)) AND alias ='" & unidad & "' ORDER BY fecha DESC"
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
                        If dS.Tables(0).Rows(0)("aviso").ToString().Contains("pánico") Then

                            alerta = New Alerta("Botón de pánico", unidad, "00:00:00", "")
                            alerta.ShowDialog()

                        ElseIf dS.Tables(0).Rows(0)("aviso").ToString().Contains("Sabotaje") Then

                            alerta = New Alerta("Sabotaje", unidad, "00:00:00", "")
                            alerta.ShowDialog()

                        End If
                    End If
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar desconexiones: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub enviarAlertaFueraRuta(ByVal unidad As String, ByVal observaciones As String)

        If String.IsNullOrEmpty(observaciones) Then

            Dim alerta = New Alerta("Fuera de ruta", unidad, "00:00:00", "")
            alerta.ShowDialog()

        End If
    End Sub

    Private Sub crearAlertaApertura()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String


        Try

            consulta = "INSERT INTO Trafico_AlertasCriticas_Satelital VALUES ('Apertura de reporte', 'A', GETDATE(), HOST_NAME(), '', 0, 'Se abrió el reporte de unidades')"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al insertar la alert de apertura: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub crearAlertaCierre()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            consulta = "INSERT INTO Trafico_AlertasCriticas_Satelital VALUES ('Cierre de reporte', 'C', GETDATE(), HOST_NAME(), '', 0, 'Se cerró el reporte de unidades')"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al insertar la alert de apertura: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function ultimaUbicacion(ByVal unidad As String) As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        Dim ubica As String

        Try
            consulta = "SELECT TOP(1) idTransaccion, economico, latitud, longitud, proximidadCiudad, fecha, horaRecepcion, georeference FROM TPosicion WHERE economico = '" & unidad & "' ORDER BY horaRecepcion DESC"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            'ubica = comando.ExecuteScalar().ToString()
            '
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            '
            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    ubica = "Última posición: "
                    ubica += " latitud: " & dS.Tables(0).Rows(0)("latitud").ToString() & ", "
                    ubica += " longitud: " & dS.Tables(0).Rows(0)("longitud").ToString() & ", "
                    ubica += " proximidad: " & dS.Tables(0).Rows(0)("proximidadCiudad").ToString() & ", "
                    ubica += " fecha y hora de última posición: " & dS.Tables(0).Rows(0)("horaRecepcion").ToString() & ", "
                    ubica += " referencia: " & dS.Tables(0).Rows(0)("georeference").ToString()
                End If
            End If
            '
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al consultar desconexiones: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ubica

    End Function

End Class