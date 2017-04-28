Imports System.Data
Imports System.Data.SqlClient

Public Class MonitorMttoPreventivo

    Private Sub MonitorMttoPreventivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        consultarDatos()

    End Sub

    Private Sub consultarDatos()

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String
        Dim reporte As Int16
        Dim indice As Integer

        consulta = "SELECT TOP(1) idRegistro FROM Trafico_Monitor_MttoUnidades ORDER BY CONVERT(DATETIME, CAST(fecha + ' 00:00:000.000' AS DATETIME), 112) DESC"
        conexion = Connection.getInstance().getConnection()
        comando = New SqlCommand(consulta, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000

        Try

            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    reporte = Convert.ToInt16(dS.Tables(0).Rows(0)(0).ToString())

                End If
            End If

            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
            consulta = "SELECT unidad, kilometraje, horasMotor, fechaUltServ, proximoServKm, proximoServHrs, proximoServFecha FROM Trafico_Monitor_MttoUnidades_Detalle WHERE idRegistro = " & reporte & " AND eliminado = 0 ORDER BY unidad"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each registro As DataRow In dS.Tables(0).Rows

                        indice = Me.gridMonitor.Rows.Add()

                        With Me.gridMonitor.Rows(indice)

                            .Cells("Tracto").Value = registro("unidad").ToString()
                            .Cells("Kilometraje").Value = registro("kilometraje").ToString()
                            .Cells("HrsMotor").Value = registro("horasMotor").ToString()
                            .Cells("UltServicio").Value = registro("fechaUltServ").ToString()
                            .Cells("ProxServKM").Value = registro("proximoServKm").ToString()
                            .Cells("ProxServHrs").Value = registro("proximoServHrs").ToString()
                            .Cells("ProxServFecha").Value = registro("proximoServFecha").ToString()

                        End With
                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al cargar los datos: " & ex.Message, "¡Error!")

        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim entrada As String
        Dim index As Integer

        entrada = InputBox("Escriba la unidad que desea agregar", "Agregar unidad", "")

        If Not String.IsNullOrEmpty(entrada) Then
            If Not existeUnidad(entrada.TrimEnd().TrimStart()) Then

                index = Me.gridMonitor.Rows.Add()
                Me.gridMonitor.Rows(index).Cells("Tracto").Value = entrada.TrimEnd().TrimStart()
                Me.gridMonitor.Rows(index).Cells("Kilometraje").Value = ""
                Me.gridMonitor.Rows(index).Cells("HrsMotor").Value = ""
                Me.gridMonitor.Rows(index).Cells("UltServicio").Value = ""
                Me.gridMonitor.Rows(index).Cells("ProxServKM").Value = ""
                Me.gridMonitor.Rows(index).Cells("ProxServHrs").Value = ""
                Me.gridMonitor.Rows(index).Cells("ProxServFecha").Value = ""
                Me.gridMonitor.Update()
                Me.gridMonitor.UpdateCellValue(0, index)
                'Me.consultarRegistrosUnidad(index)
                Me.inicializarCeldasFila(index)

            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim comando As SqlCommand
        Dim conexion As SqlConnection

        For Each unidades As DataGridViewRow In Me.gridMonitor.SelectedRows

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UPDATE Trafico_Monitor_MttoUnidades_Detalle SET eliminado = 1 WHERE unidad = '" & unidades.Cells("Tracto").Value.ToString() & "'", conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000

            Try

                conexion.Open()
                comando.ExecuteNonQuery()
                comando.Dispose()
                conexion.Dispose()
                conexion.Close()
                Me.gridMonitor.Rows.RemoveAt(unidades.Index)

            Catch ex As Exception

                MessageBox.Show("Error al eliminar un registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Next
    End Sub

    Private Function existeUnidad(ByVal unidad As String) As Boolean

        Dim existe As Boolean = False

        If Me.gridMonitor.Rows.Count > 0 Then
            For Each tracto As DataGridViewRow In Me.gridMonitor.Rows
                If tracto.Cells("Tracto").Value.ToString().Equals(unidad.TrimEnd().TrimStart()) Then

                    existe = True
                    Exit For

                End If
            Next
        End If

        Return existe

    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub consultarRegistrosUnidad(ByVal index As Integer)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        conexion = Connection.getInstance().getConnection()
        consulta = "SELECT TOP(1) viaje.Km_Final, Valor = ISNULL([reset].Valor, '') FROM DatosViaje viaje (NOLOCK) LEFT JOIN DatosResetViaje [reset] ON viaje.Id_Num_Viaje = [reset].Id_Num_Viaje AND [reset].Id_Num_DatoReset = 15 WHERE Unidad = '" & Me.gridMonitor.Rows(index).Cells("Tracto").Value.ToString() & "' ORDER BY viaje.Fec_Movto DESC"
        comando = New SqlCommand(consulta, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000

        Try

            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables(0).Rows.Count > 0 Then

                Me.gridMonitor.Rows(index).Cells("Kilometraje").Value = dS.Tables(0).Rows(0)("Km_Final").ToString()
                Me.gridMonitor.Rows(index).Cells("HrsMotor").Value = dS.Tables(0).Rows(0)("Valor").ToString()
                Me.gridMonitor.Rows(index).Cells("ProxServKM").Value = Convert.ToDouble(dS.Tables(0).Rows(0)("Km_Final").ToString()) + 24000.0
                Me.gridMonitor.Rows(index).Cells("UltServicio").Value = ""
                Me.gridMonitor.Rows(index).Cells("ProxServFecha").Value = ""
                Me.gridMonitor.Rows(index).Cells("ProxServHrs").Value = dS.Tables(0).Rows(0)("Valor").ToString().Replace(dS.Tables(0).Rows(0)("Valor").ToString().Split(":")(0), (Convert.ToInt32(dS.Tables(0).Rows(0)("Valor").ToString().Split(":")(0)) + 625) & "")

            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar los datos de la unidad: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub gridMonitor_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridMonitor.CellLeave

        Me.marcarFilas()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim comando As SqlCommand
        Dim conexion As SqlConnection

        If Me.gridMonitor.Rows.Count > 0 Then

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("up_Monitor_MttoUnidades_insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 1000

            Try

                conexion.Open()
                comando.ExecuteNonQuery()
                comando.Dispose()
                conexion.Dispose()
                conexion.Close()

            Catch ex As Exception

                MessageBox.Show("Error al guardar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End Try

            For Each unidad As DataGridViewRow In Me.gridMonitor.Rows

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("up_Monitor_MttoUnidades_Detalle_insert", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000

                With comando.Parameters

                    .AddWithValue("@unidad", unidad.Cells("Tracto").Value.ToString())


                    If Not String.IsNullOrEmpty(unidad.Cells("Kilometraje").Value.ToString()) Then

                        .AddWithValue("@kilometraje", Convert.ToDecimal(unidad.Cells("Kilometraje").Value.ToString()))

                    Else

                        .AddWithValue("@kilometraje", Convert.ToDecimal("0"))

                    End If

                    .AddWithValue("@horasMotor", unidad.Cells("HrsMotor").Value.ToString())
                    .AddWithValue("@fechaUltServ", unidad.Cells("UltServicio").Value.ToString())

                    If Not String.IsNullOrEmpty(unidad.Cells("ProxServKM").Value.ToString()) Then

                        .AddWithValue("@proximoServKm", Convert.ToDecimal(unidad.Cells("ProxServKM").Value.ToString()))

                    Else

                        .AddWithValue("@proximoServKm", Convert.ToDecimal("0"))

                    End If

                    .AddWithValue("@proximoServHrs", unidad.Cells("ProxServHrs").Value.ToString())
                    .AddWithValue("@proximoServFecha", unidad.Cells("ProxServFecha").Value.ToString())

                End With

                Try

                    conexion.Open()
                    comando.ExecuteNonQuery()
                    comando.Dispose()
                    conexion.Dispose()
                    conexion.Close()

                Catch ex As Exception

                    MessageBox.Show("Error al guardar el registro de la unidad: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            Next

            MessageBox.Show("¡Listo!", "Proceso terminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Excel.gridToExcel(Me.gridMonitor)

    End Sub

    Private Sub consultarHorasKilometrajes(ByVal indice As Int32)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        conexion = Connection.getInstance().getConnection()
        consulta = "SELECT TOP(1) viaje.Km_Final, Valor = ISNULL([reset].Valor, '') FROM DatosViaje viaje (NOLOCK) LEFT JOIN DatosResetViaje [reset] ON viaje.Id_Num_Viaje = [reset].Id_Num_Viaje AND [reset].Id_Num_DatoReset = 15 WHERE Unidad = '" & Me.gridMonitor.Rows(indice).Cells("Tracto").Value.ToString() & "' ORDER BY viaje.Fec_Movto DESC"
        comando = New SqlCommand(consulta, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000

        Try

            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables(0).Rows.Count > 0 Then

                Me.gridMonitor.Rows(indice).Cells("Kilometraje").Value = dS.Tables(0).Rows(0)("Km_Final").ToString()
                Me.gridMonitor.Rows(indice).Cells("HrsMotor").Value = dS.Tables(0).Rows(0)("Valor").ToString()
                Me.gridMonitor.Rows(indice).Cells("ProxServKM").Value = Convert.ToDouble(dS.Tables(0).Rows(0)("Km_Final").ToString()) + 24000.0

                If Me.gridMonitor.Rows(indice).Cells("UltServicio").Value Is Nothing Then

                    Me.gridMonitor.Rows(indice).Cells("UltServicio").Value = ""

                End If

                Me.gridMonitor.Rows(indice).Cells("ProxServHrs").Value = dS.Tables(0).Rows(0)("Valor").ToString().Replace(dS.Tables(0).Rows(0)("Valor").ToString().Split(":")(0), (Convert.ToInt32(dS.Tables(0).Rows(0)("Valor").ToString().Split(":")(0)) + 625) & "")
                
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar los datos de la unidad: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub marcarFilas()

        If Me.gridMonitor.Rows.Count > 0 Then
            For Each unidad As DataGridViewRow In Me.gridMonitor.Rows

                Me.gridMonitor.Update()
                Me.gridMonitor.UpdateCellValue(unidad.Cells("Kilometraje").ColumnIndex, unidad.Cells("ProxServKM").RowIndex)

                If Not String.IsNullOrEmpty(unidad.Cells("Kilometraje").Value.ToString()) AndAlso Not String.IsNullOrEmpty(unidad.Cells("ProxServKM").Value.ToString()) Then
                    If Convert.ToDecimal(unidad.Cells("Kilometraje").Value.ToString()) > Convert.ToDecimal(unidad.Cells("ProxServKM").Value.ToString()) Then

                        unidad.Cells("Kilometraje").Style.BackColor = Color.OrangeRed
                        unidad.Cells("ProxServKM").Style.BackColor = Color.OrangeRed
                        Me.gridMonitor.Update()
                        Me.gridMonitor.Refresh()
                        Exit For

                    Else

                        unidad.Cells("Kilometraje").Style.BackColor = Color.White
                        unidad.Cells("ProxServKM").Style.BackColor = Color.White

                    End If
                End If

                If Not String.IsNullOrEmpty(unidad.Cells("HrsMotor").Value.ToString()) AndAlso Not String.IsNullOrEmpty(unidad.Cells("ProxServHrs").Value.ToString()) Then
                    If Convert.ToInt32(unidad.Cells("HrsMotor").Value.ToString().Split(":")(0)) > Convert.ToInt32(unidad.Cells("ProxServHrs").Value.ToString().Split(":")(0)) Then

                        unidad.Cells("HrsMotor").Style.BackColor = Color.OrangeRed
                        unidad.Cells("ProxServHrs").Style.BackColor = Color.OrangeRed
                        Me.gridMonitor.Update()
                        Me.gridMonitor.Refresh()
                        Exit For

                    Else

                        unidad.Cells("HrsMotor").Style.BackColor = Color.White
                        unidad.Cells("ProxServHrs").Style.BackColor = Color.White

                    End If
                End If

                If Not String.IsNullOrEmpty(unidad.Cells("ProxServFecha").Value.ToString()) AndAlso Not String.IsNullOrEmpty(unidad.Cells("ProxServHrs").Value.ToString()) Then
                    If DateTime.Compare(DateTime.Today.ToString("dd/MM/yyyy"), Convert.ToDateTime(unidad.Cells("ProxServFecha").Value.ToString())) > 0 Then

                        unidad.Cells("ProxServFecha").Style.BackColor = Color.OrangeRed
                        unidad.Cells("ProxServHrs").Style.BackColor = Color.OrangeRed
                        Me.gridMonitor.Update()
                        Me.gridMonitor.Refresh()
                        Exit For

                    Else

                        unidad.Cells("ProxServFecha").Style.BackColor = Color.White
                        unidad.Cells("ProxServHrs").Style.BackColor = Color.White

                    End If
                End If
            Next
        End If
    End Sub

    Private Sub inicializarCeldasFila(ByVal indice As Integer)

        For index As Integer = 1 To Me.gridMonitor.ColumnCount - 1

            Me.gridMonitor.Rows(indice).Cells(index).Value = ""

        Next
    End Sub

    Private Sub gridMonitor_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridMonitor.CellDoubleClick

        If e.ColumnIndex = Me.gridMonitor.Columns("Tracto").Index Then

            Dim mtto As HistorialMttoUnidad = New HistorialMttoUnidad(Me.gridMonitor.CurrentRow.Cells("Tracto").Value.ToString())
            mtto.ShowDialog (me)

        End If
    End Sub

    Private Sub gridMonitor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridMonitor.CellContentClick

        Dim row As DataGridViewRow
        Dim motivo As String

        If e.ColumnIndex = Me.gridMonitor.Columns("colCalcular").Index Then

            row = Me.gridMonitor.Rows(e.RowIndex)

            If Not String.IsNullOrEmpty(row.Cells("Kilometraje").Value.ToString()) Then

                row.Cells("ProxServKM").Value = Convert.ToDouble(row.Cells("Kilometraje").Value.ToString()) + 24000.0

                If row.Cells("ProxServKM").Style.BackColor = Color.OrangeRed Then

                    motivo = "MANTENIMIENTO POR KILOMETRAJE"
                    insertarRegistroHistorial(row.Cells("Tracto").Value.ToString(), DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm"), motivo)

                End If
            End If

            If Not String.IsNullOrEmpty(row.Cells("HrsMotor").Value.ToString()) Then

                row.Cells("ProxServHrs").Value = row.Cells("HrsMotor").Value.ToString().Replace(row.Cells("HrsMotor").Value.ToString().Split(":")(0), (Convert.ToInt32(row.Cells("HrsMotor").Value.ToString().Split(":")(0)) + 625) & "")

                If row.Cells("ProxServHrs").Style.BackColor = Color.OrangeRed Then

                    motivo = "MANTENIMIENTO POR HORAS MOTOR"
                    insertarRegistroHistorial(row.Cells("Tracto").Value.ToString(), DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm"), motivo)

                End If
            End If

            If Not String.IsNullOrEmpty(row.Cells("UltServicio").Value.ToString()) Then

                row.Cells("ProxServFecha").Value = Convert.ToDateTime(row.Cells("UltServicio").Value.ToString()).AddMonths(6).ToString("dd/MM/yyyy")

                If row.Cells("ProxServFecha").Style.BackColor = Color.OrangeRed Then

                    motivo = "MANTENIMIENTO POR FECHA DE ÚLTIMO SERVICIO"
                    insertarRegistroHistorial(row.Cells("Tracto").Value.ToString(), DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm"), motivo)

                End If
            End If

            Me.marcarFilas()

        End If
    End Sub

    Private Sub insertarRegistroHistorial(ByVal unidad As String, ByVal fecha As String, ByVal hora As String, ByVal motivo As String)

        Dim comando As SqlCommand
        Dim conexion As SqlConnection

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Hisorial_MttoUnidades_Ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@unidad", unidad)
                .AddWithValue("@fecha", fecha)
                .AddWithValue("@hora", hora)
                .AddWithValue("@motivoMantenimiento", motivo)
                .AddWithValue("@observaciones", "")

            End With

            comando.ExecuteNonQuery()
            comando.Dispose()
            conexion.Close()
            conexion.Dispose()
            MessageBox.Show("El historial se guardó correctamente", "¡Guardado exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error al guardar el historial: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class