Imports Microsoft.VisualBasic.Interaction
Imports System.Data.SqlClient

Public Class frmUbicaViajes
    Public latitud, longitud, unidad As String
    Public dtMapa As DataTable
    Public Detalle As Boolean
    Const INTERVALO_EN_MINUTOS As Integer = 3
    Public upward As Boolean = False

    Private Sub frmUbicaViajes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gridViajesClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdUbicaViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer1.Interval = 3500
        Timer2.Interval = 3500
        Detalle = False
        CargaGrid()
        CargarViajeCliente()
    End Sub

#Region "Carga de Clientes"

    Private Sub CargaGrid()
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet


        Me.grdUbicaViajes.Columns.Clear()
        Me.grdUbicaViajes.DataSource = Nothing

        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnectionQFS()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("EJEMPLO_VIAJE", conn)

        oCommand.CommandType = CommandType.StoredProcedure
        oCommand.CommandTimeout = 0
        conn.Open()
        Try
            Dim oParameter As SqlClient.SqlParameter
            oParameter = oCommand.Parameters.AddWithValue("@TipoViaje", 0)
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            Me.grdUbicaViajes.DataSource = oDs.Tables(0)
            dtMapa = oDs.Tables(0)


            Me.grdUbicaViajes.Columns("latitude").Visible = False
            Me.grdUbicaViajes.Columns("longitud").Visible = False
            Me.grdUbicaViajes.Columns("Marca").Visible = False

            Me.setObservaciones(Me.grdUbicaViajes)
            Me.obtenerDescansos(Me.grdUbicaViajes)


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub



    Private Sub CargarViajeCliente()
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Me.gridViajesClientes.Columns.Clear()
        Me.gridViajesClientes.DataSource = Nothing

        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnectionQFS()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("EJEMPLO_VIAJE", conn)

        oCommand.CommandType = CommandType.StoredProcedure
        oCommand.CommandTimeout = 0
        conn.Open()
        Try

            Dim oParameter As SqlClient.SqlParameter
            oParameter = oCommand.Parameters.AddWithValue("@TipoViaje", 7)
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            Me.gridViajesClientes.DataSource = oDs.Tables(0)
            dtMapa = oDs.Tables(0)


            Me.gridViajesClientes.Columns("latitude").Visible = False
            Me.gridViajesClientes.Columns("longitud").Visible = False
            Me.gridViajesClientes.Columns("Marca").Visible = False

            Me.setObservaciones(Me.gridViajesClientes)
            Me.obtenerDescansos(Me.gridViajesClientes)


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub

    Private Sub CargaRuta(ByVal Unidad As String)
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnectionQFS()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("UP_Consulta_RutaViaje", conn)

        oCommand.CommandType = CommandType.StoredProcedure
        conn.Open()

        Dim oParameter As SqlClient.SqlParameter
        Try
            oParameter = oCommand.Parameters.Add("@Unidad", SqlDbType.VarChar)
            oParameter.Value = Unidad

            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            dtMapa = oDs.Tables(0)


        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)
        Finally
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
#End Region

#Region "Requerimientos de Seguridad"

    Private Function estaFuera(ByVal status As String) As Boolean
        Dim fuera As Boolean = False
        If status.Equals("EN RUTA IDA") OrElse status.Equals("EN RUTA REGRESO") Then
            fuera = True
        End If
        Return fuera
    End Function

    Private Sub obtenerDescansos(ByVal grid As DataGridView)

        If grid.Rows.Count > 0 Then

            Dim horaSalida As DateTime
            Dim ultimoDescanso As DateTime
            Dim proximoDescanso As DateTime
            Dim horaActual As DateTime = DateTime.Now
            Dim ultimoInicio As DateTime
            Dim ultimaEntrada As String
            Dim estatus As String = ""

            Dim lapsoInicioViaje As Integer = 5
            Dim horasDescanso As Integer = 1
            Dim totalHoras As Double
            Dim horas As Integer
            Dim tiempoResultante As TimeSpan
            Dim promedioVelocidad As Double = 0.0
            Dim inputDialog As New InputDialog
            Dim correo As DateTime

            For i As Integer = 0 To grid.Rows.Count - 1
                If Not String.IsNullOrEmpty(Convert.ToString(grid.Rows(i).Cells("SALIDA").Value)) Then
                    horaSalida = Convert.ToDateTime(grid.Rows(i).Cells("SALIDA").Value.ToString())
                    tiempoResultante = horaActual.Subtract(horaSalida)
                    totalHoras = tiempoResultante.TotalHours
                    horas = (totalHoras \ lapsoInicioViaje) * lapsoInicioViaje
                    ultimoInicio = horaSalida.AddHours(horas)
                    ultimoDescanso = ultimoInicio.AddHours(-(horasDescanso))
                    proximoDescanso = ultimoInicio.AddHours(lapsoInicioViaje - horasDescanso)
                    promedioVelocidad = Convert.ToDouble(grid.Rows(i).Cells("Vel. Promedio - Últimas 4 Horas").Value)

                    grid.Rows(i).Cells("ULTIMO DESCANSO").Value = ultimoDescanso
                    grid.Rows(i).Cells("TERMINO DE DESCANSO").Value = ultimoInicio
                    grid.Rows(i).Cells("SIGUIENTE DESCANSO").Value = proximoDescanso

                    ultimaEntrada = Convert.ToString(grid.Rows(i).Cells("UBICACION1").Value).Trim()
                    estatus = Convert.ToString(grid.Rows(i).Cells("Estatus").Value).Trim()

                    Dim operador As String = grid.Rows(i).Cells("Operador").Value.ToString()

                    If (estaFuera(estatus)) AndAlso (ultimaEntrada.Equals("FUERA")) Then

                        If horaActual.AddMinutes(-5) <= proximoDescanso AndAlso proximoDescanso <= horaActual.AddMinutes(5) AndAlso promedioVelocidad > 0 Then

                            inputDialog.Viaje = Convert.ToInt32(grid.Rows(i).Cells("Viaje").Value.ToString())
                            inputDialog.NombreOperador = grid.Rows(i).Cells("Operador").Value.ToString()
                            inputDialog.IdUnidad = grid.Rows(i).Cells("Unidad").Value.ToString()
                            inputDialog.Alerta = horaActual
                            inputDialog.ShowDialog()
                        End If

                        correo = horaSalida
                        While correo <= horaActual.AddMinutes(10)
                            correo = correo.AddHours(2)
                            If horaActual.AddMinutes(-5) <= correo AndAlso correo <= horaActual.AddMinutes(5) AndAlso promedioVelocidad > 0 Then
                                Dim idCliente As Integer = Convert.ToInt32(grid.Rows(i).Cells("id_cliente").Value)
                                Dim nombreCliente As String = grid.Rows(i).Cells("Cliente").Value.ToString()
                                Dim viaje As String = grid.Rows(i).Cells("Viaje").Value.ToString()
                                Dim unidad As String = grid.Rows(i).Cells("Unidad").Value.ToString()
                                Dim destino As String = grid.Rows(i).Cells("Destino").Value.ToString()
                                Dim referencias As String = grid.Rows(i).Cells("Referencia").Value.ToString()
                                Dim observaciones As String = grid.Rows(i).Cells("Observaciones").Value.ToString()
                                Dim placas As String = grid.Rows(i).Cells("PLACAS").Value.ToString()

                                Dim correo2 As formEnviarCorreo = New formEnviarCorreo(idCliente, nombreCliente, viaje, unidad, operador, destino, referencias, observaciones, placas, "")
                                correo2.ShowDialog()
                            End If
                        End While
                        

                        If promedioVelocidad < 1 Then

                            Dim mensaje As String = "El operador " & operador & Environment.NewLine & "tiene un promedio de velocidad dentro de la unidad " & unidad & " igual a cero." & Environment.NewLine & "Favor de localizarlo."
                            Dim alerta As formAlerta = New formAlerta(mensaje)
                            alerta.ShowDialog()
                        End If
                    End If
                End If
            Next
        End If
    End Sub
#End Region

#Region "Eventos"
    Private Sub btnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click
        Dim config As formConfiguracion = New formConfiguracion()
        config.Show()
    End Sub

    Private Sub gridViajesClientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridViajesClientes.CellDoubleClick

        latitud = Me.gridViajesClientes.CurrentRow.Cells("latitude").Value.ToString()
        longitud = Me.gridViajesClientes.CurrentRow.Cells("longitud").Value.ToString()
        If e.ColumnIndex = gridViajesClientes.Columns.Item("Unidad").Index Then
            Detalle = True
            Timer2.Enabled = False
            CargaRuta(Me.gridViajesClientes.CurrentRow.Cells(0).Value.ToString())
            frmMapaUbica.ShowDialog()
            CargarViajeCliente()
            Timer2.Enabled = True
        Else
            Detalle = False
            frmMapaUbica.ShowDialog()
        End If
    End Sub

    Private Sub grdUbicaViajes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdUbicaViajes.CellDoubleClick

        latitud = Me.grdUbicaViajes.CurrentRow.Cells("latitude").Value.ToString()
        longitud = Me.grdUbicaViajes.CurrentRow.Cells("longitud").Value.ToString()
        If e.ColumnIndex = grdUbicaViajes.Columns.Item("Unidad").Index Then
            Detalle = True
            Timer2.Enabled = False
            CargaRuta(Me.grdUbicaViajes.CurrentRow.Cells(0).Value.ToString())
            frmMapaUbica.ShowDialog()
            CargaGrid()
            Timer2.Enabled = True
        Else

            Detalle = False
            frmMapaUbica.ShowDialog()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static Temp_Seg As Long
        Temp_Seg = Temp_Seg + 1
        If (Temp_Seg * 60) >= (INTERVALO_EN_MINUTOS * 60) * 20 Then
            Temp_Seg = 0
            CargaGrid()
            CargarViajeCliente()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Static Temp_Seg As Long
        Temp_Seg = Temp_Seg + 1
        If (Temp_Seg * 60) >= (INTERVALO_EN_MINUTOS * 60) * 20 Then
            Temp_Seg = 0
            CargaGrid()
            CargarViajeCliente()
        End If
    End Sub
#End Region
#Region "Utilidades"

    Private Sub setObservaciones(ByVal dataGrid As DataGridView)
        Dim index As Integer
        index = dataGrid.Columns("Marca").Index
        Dim contador As Integer = 1
        While contador < dataGrid.Rows.Count

            If dataGrid.Rows(contador).Cells(index).Value = 1 Then
                dataGrid.Rows(contador).DefaultCellStyle.BackColor = Color.Tomato
            End If

            If dataGrid.Rows(contador).Cells("Viaje").Value.ToString.Equals(dataGrid.Rows(contador - 1).Cells("Viaje").Value.ToString()) Then

                dataGrid.Rows(contador).Cells("Referencia").Value = dataGrid.Rows(contador).Cells("Referencia").Value.ToString & " | " & dataGrid.Rows(contador - 1).Cells("Referencia").Value.ToString
                dataGrid.Rows(contador).Cells("Observaciones").Value = dataGrid.Rows(contador).Cells("Observaciones").Value.ToString & " | " & dataGrid.Rows(contador - 1).Cells("Observaciones").Value.ToString

                dataGrid.Rows.Remove(dataGrid.Rows(contador - 1))
            End If
            contador += 1
        End While
    End Sub

    Private Function perteneceRango(ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime, ByVal fechaIntermedia As DateTime) As Boolean
        Dim resultado As Boolean = False
        If fechaInicio <= fechaIntermedia AndAlso fechaIntermedia <= fechaFinal Then
            resultado = True
        End If
        Return resultado
    End Function
#End Region
End Class