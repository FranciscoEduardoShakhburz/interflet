Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail

Public Class EnvioStatus

    Private Sub EnvioStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.consultarInformacion()
        Me.tSPBProgreso.Visible = False
        Me.chBMarcarTodos.Checked = True

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim aV As AgregarViaje = New AgregarViaje(Me.dGVUnidades, 1)
        aV.ShowDialog(Me)

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Dim aV As AgregarViaje = New AgregarViaje(Me.dGVUnidades.SelectedRows(0), 2)
        aV.ShowDialog(Me)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Me.eliminarInformacion()

    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click

        Cursor.Current = Cursors.AppStarting
        Me.enviarCorreos()
        Me.guardarDatos()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub chBMarcarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chBMarcarTodos.CheckedChanged

        If Me.chBMarcarTodos.Checked Then

            Me.seleccionarCasillas(True)

        Else

            Me.seleccionarCasillas(False)

        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Me.dGVUnidades.Rows.Clear()
        Me.consultarInformacion()

    End Sub

    Public Sub consultarInformacion()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim fila As DataGridViewRow

        Dim dominio As String = "@hinojosa.com.mx"

        Dim usuarioPara As String
        Dim idPersonalPara As Integer
        'Prueba
        idPersonalPara = 6942 'Omar
        usuarioPara = ObtenerDatosCorreo.nombreUsuario(idPersonalPara)
        usuarioPara = usuarioPara & dominio

        Dim idPersonalParaFrancisco As Integer
        Dim usuarioParaFrancisco As String
        Dim idPersonalParaJuan As Integer
        Dim usuarioParaJuan As String
        Dim idPersonalParaEdith As Integer
        Dim usuarioParaEdith As String
        Dim idPersonalParaServCliente As Integer
        Dim usuarioParaServCliente As String

        idPersonalParaFrancisco = 12 'Francisco
        usuarioParaFrancisco = ObtenerDatosCorreo.nombreUsuario(idPersonalParaFrancisco)
        usuarioParaFrancisco = usuarioParaFrancisco & dominio & "; "

        idPersonalParaJuan = 10000 'Juan
        usuarioParaJuan = ObtenerDatosCorreo.nombreUsuario(idPersonalParaJuan)
        usuarioParaJuan = usuarioParaJuan & dominio & "; "

        idPersonalParaEdith = 7187 'Edith
        usuarioParaEdith = ObtenerDatosCorreo.nombreUsuario(idPersonalParaEdith)
        usuarioParaEdith = usuarioParaEdith & dominio & "; "

        idPersonalParaServCliente = 10001 'Servicio a Clientes
        usuarioParaServCliente = ObtenerDatosCorreo.nombreUsuario(idPersonalParaServCliente)
        usuarioParaServCliente = usuarioParaServCliente & dominio & "; "


        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_UnidadesEnViaje", conexion)
            comando.CommandType = CommandType.StoredProcedure
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
                    For Each unidad As DataRow In dS.Tables(0).Rows
                        If Me.dGVUnidades.Rows.Count > 0 Then
                            If Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colUnidad").Value.ToString().Equals(unidad("unidad").ToString()) And Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colViaje").Value.ToString().Equals(unidad("viaje").ToString()) Then

                                Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colCartaPorte").Value = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colCartaPorte").Value.ToString() & " /  " & unidad("cartaPorte").ToString()
                                Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colContenedores").Value = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colContenedores").Value.ToString() & " /  " & unidad("contenedores").ToString()
                                Continue For

                            End If
                        End If

                        fila = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Add())
                        fila.Cells("colUnidad").Value = unidad("unidad").ToString()
                        fila.Cells("colOperador").Value = unidad("operador").ToString()
                        fila.Cells("colPlacas").Value = unidad("placas").ToString()
                        fila.Cells("colViaje").Value = unidad("viaje").ToString()
                        fila.Cells("colObservaciones").Value = unidad("observaciones").ToString()
                        fila.Cells("colNumeroCliente").Value = unidad("numeroCliente").ToString()
                        fila.Cells("colCliente").Value = unidad("cliente").ToString()
                        fila.Cells("colDestino").Value = unidad("destino").ToString()
                        fila.Cells("colCartaPorte").Value = unidad("cartaPorte").ToString()
                        fila.Cells("colContenedores").Value = unidad("contenedores").ToString()
                        fila.Cells("colTipoOper").Value = unidad("tipoOper").ToString()
                        fila.Cells("colDireccion").Value = unidad("direccionEntrega").ToString()
                        fila.Cells("colCorreos").Value = unidad("correos").ToString() & usuarioParaFrancisco & usuarioParaJuan & usuarioParaEdith & usuarioParaServCliente
                        fila.Cells("colComentarios").Value = ""
                        fila.Cells("colStatus").Value = unidad("status").ToString()
                        fila.Cells("colUbicacion").Value = unidad("ubicacion").ToString()
                        fila.Cells("colSeleccionado").Value = True

                    Next
                End If

                If dS.Tables(1).Rows.Count > 0 Then
                    For Each unidad As DataRow In dS.Tables(1).Rows
                        If Me.dGVUnidades.Rows.Count > 0 Then
                            If Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colUnidad").Value.ToString().Equals(unidad("unidad").ToString()) And Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colViaje").Value.ToString().Equals(unidad("viaje").ToString()) Then

                                Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colCartaPorte").Value = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colCartaPorte").Value.ToString() & " /  " & unidad("cartaPorte").ToString()
                                Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colContenedores").Value = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Count - 1).Cells("colContenedores").Value.ToString() & " /  " & unidad("contenedores").ToString()
                                Continue For

                            End If
                        End If

                        fila = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Add())
                        fila.Cells("colUnidad").Value = unidad("unidad").ToString()
                        fila.Cells("colOperador").Value = unidad("operador").ToString()
                        fila.Cells("colPlacas").Value = unidad("placas").ToString()
                        fila.Cells("colViaje").Value = unidad("viaje").ToString()
                        fila.Cells("colObservaciones").Value = unidad("observaciones").ToString()
                        fila.Cells("colNumeroCliente").Value = unidad("numeroCliente").ToString()
                        fila.Cells("colCliente").Value = unidad("cliente").ToString()
                        fila.Cells("colDestino").Value = unidad("destino").ToString()
                        fila.Cells("colCartaPorte").Value = unidad("cartaPorte").ToString()
                        fila.Cells("colContenedores").Value = unidad("contenedores").ToString()
                        fila.Cells("colTipoOper").Value = unidad("tipoOper").ToString()
                        fila.Cells("colDireccion").Value = unidad("direccionEntrega").ToString()
                        fila.Cells("colCorreos").Value = unidad("correos").ToString() & " FRANCISCO.DELATORRE@hinojosa.com.mx; JUAN.AQUINO@hinojosa.com.mx; Edith.Ponce@hinojosa.com.mx; ServicioaClientes@hinojosa.com.mx;"
                        fila.Cells("colComentarios").Value = ""
                        fila.Cells("colStatus").Value = unidad("status").ToString()
                        fila.Cells("colUbicacion").Value = unidad("ubicacion").ToString()
                        fila.Cells("colSeleccionado").Value = True

                    Next
                End If
            End If

            Me.dGVUnidades.Sort(Me.dGVUnidades.Columns("colUnidad"), System.ComponentModel.ListSortDirection.Ascending)

        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub enviarCorreos()

        Dim mensaje As MailMessage
        Dim smtp As SmtpClient

        Dim dominio As String = "@hinojosa.com.mx"

        Dim usuarioDe As String
        Dim contrasena As String
        Dim idPersonalDe As Integer
        
        idPersonalDe = 7187 'Edith
        usuarioDe = ObtenerDatosCorreo.nombreUsuario(idPersonalDe)
        contrasena = ObtenerDatosCorreo.contrasena(idPersonalDe)
        usuarioDe = usuarioDe & dominio

        Dim idPersonalPara As Integer
        Dim usuarioPara As String

        idPersonalPara = 6942 'Omar
        usuarioPara = ObtenerDatosCorreo.nombreUsuario(idPersonalPara)
        usuarioPara = usuarioPara & dominio

        Dim men As String = ""

        Me.tSPBProgreso.Minimum = 1
        Me.tSPBProgreso.Step = 1
        Me.tSPBProgreso.Visible = True

        Try
            For Each carga As DataGridViewRow In Me.dGVUnidades.Rows
                If carga.Cells("colSeleccionado").Value = True Then

                    Me.tSSLEstado.Text = "Armando correo..."
                    Me.Refresh()
                    men = ""
                    men += "<table style='border: 1px solid;'>"
                    men += "<tr style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>NUM. ECO.</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>OPERADOR</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>PLACAS</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>VIAJE</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>OBSERVACIONES</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>CLIENTE</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>DESTINO</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>NUM DE TALÓN CP</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>NÚMERO DE CONTENEDOR/S CAJA O PLANA</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>TIPO DE OPER</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>DIRECCIÓN DE ENTREGA</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>STATUS</th>"
                    men += "<th style='border: 1px solid black; background-color: #0000FF; font-family: ""Calibri""; font-size: 11px;'>UBICACION</th></tr>"
                    men += "<tr style='border: 1px solid black;'>" & "<th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colUnidad").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colOperador").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colPlacas").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colViaje").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colObservaciones").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colCliente").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colDestino").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colCartaPorte").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colContenedores").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colTipoOper").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colDireccion").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colStatus").Value.ToString() & "</th><th style='border: 1px solid black; font-family: ""Calibri""; font-size: 11px;'>" & carga.Cells("colUbicacion").Value.ToString() & "</th></tr>"
                    men += "</table>"
                    mensaje = New MailMessage()
                    smtp = New SmtpClient()
                    mensaje.From = New MailAddress(usuarioDe, "")

                    For Each correo As String In carga.Cells("colCorreos").Value.ToString().Trim().Split(";")
                        If Not String.IsNullOrEmpty(correo.Trim()) Then

                            Me.tSSLEstado.Text = "Agregando contactos..."
                            Me.Refresh()
                            mensaje.To.Add(correo.Trim().TrimStart().TrimEnd())

                        End If
                    Next

                    mensaje.Bcc.Add(usuarioPara)
                    mensaje.Subject = Me.consultarProcedencia(carga.Cells("colUnidad").Value.ToString()) & " // " & carga.Cells("colUnidad").Value.ToString() & " // " & carga.Cells("colCliente").Value.ToString() & " // " & carga.Cells("colDestino").Value.ToString() & " // " & carga.Cells("colViaje").Value.ToString()
                    mensaje.Body = "<h4 style='font-family: ""Century Gothic""; font-size: 13px;'>Estimado Cliente,</h4><br /><h4 style='font-family: ""Century Gothic""; font-size: 11px;'>En seguida encontrará el status referente a su embarque como sigue:</h4><br />" & men & "<br />" & IIf(String.IsNullOrEmpty(carga.Cells("colComentarios").Value.ToString()), "", "<h4 style='font-family: ""Century Gothic""; font-size: 11px;'>Comentarios: " & carga.Cells("colComentarios").Value.ToString()) & "<h4>"
                    mensaje.IsBodyHtml = True
                    mensaje.Priority = MailPriority.Normal
                    smtp.EnableSsl = True
                    smtp.Port = 587
                    smtp.Host = "smtp.office365.com"
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network
                    smtp.Credentials = New NetworkCredential(usuarioDe, contrasena)

                    Try

                        Me.tSSLEstado.Text = "Enviando..."
                        Me.Refresh()
                        smtp.Send(mensaje)
                        Me.tSSLEstado.Text = "Correo enviado a " & carga.Cells("colCliente").Value.ToString()
                        Me.Refresh()

                    Catch ex As Exception

                        Me.tSSLEstado.Text = "Error al enviar el correo."
                        Me.tSPBProgreso.Step = 1
                        Me.tSPBProgreso.Value = 1
                        Me.tSPBProgreso.Visible = False
                        MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try
                End If

                Me.Refresh()
                Me.tSPBProgreso.PerformStep()
                Me.Refresh()

            Next
        Catch ex As Exception

            MessageBox.Show("Error al enviar los correos: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Me.tSPBProgreso.Step = 1
        Me.tSPBProgreso.Value = 1
        Me.tSPBProgreso.Visible = False
        Me.tSSLEstado.Text = "Listo!"
        Me.Refresh()

    End Sub

    Private Sub guardarDatos()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_EnvioStatus_Insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            For Each carga As DataGridViewRow In Me.dGVUnidades.Rows

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("UP_EnvioStatus_Detalle_Insert", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 600
                conexion.Open()

                With comando.Parameters

                    .AddWithValue("@unidad", carga.Cells("colUnidad").Value.ToString())
                    .AddWithValue("@operador", carga.Cells("colOperador").Value.ToString())
                    .AddWithValue("@placas", carga.Cells("colPlacas").Value.ToString())
                    .AddWithValue("@viaje", Convert.ToInt32(carga.Cells("colViaje").Value.ToString()))
                    .AddWithValue("@observaciones", carga.Cells("colObservaciones").Value.ToString())
                    .AddWithValue("@numeroCliente", carga.Cells("colNumeroCliente").Value.ToString())
                    .AddWithValue("@cliente", carga.Cells("colCliente").Value.ToString())
                    .AddWithValue("@destino", carga.Cells("colDestino").Value.ToString())
                    .AddWithValue("@cartaPorte", carga.Cells("colCartaPorte").Value.ToString())
                    .AddWithValue("@contenedor", carga.Cells("colContenedores").Value.ToString())
                    .AddWithValue("@tipoOper", carga.Cells("colTipoOper").Value.ToString())
                    .AddWithValue("@direccion", carga.Cells("colDireccion").Value.ToString())
                    .AddWithValue("@correos", carga.Cells("colCorreos").Value.ToString().Replace(" FRANCISCO.DELATORRE@hinojosa.com.mx; JUAN.AQUINO@hinojosa.com.mx; Edith.Ponce@hinojosa.com.mx; ServicioaClientes@hinojosa.com.mx;", ""))
                    .AddWithValue("@comentarios", carga.Cells("colComentarios").Value.ToString())
                    .AddWithValue("@status", carga.Cells("colStatus").Value.ToString())
                    .AddWithValue("@ubicacion", carga.Cells("colUbicacion").Value.ToString())
                    .AddWithValue("@seleccionado", IIf(Convert.ToBoolean(carga.Cells("colSeleccionado").Value.ToString()), 1, 0))

                End With

                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            Next
        Catch ex As Exception

            MessageBox.Show("Error al guardar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub eliminarInformacion()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try
            For Each carga As DataGridViewRow In Me.dGVUnidades.SelectedRows

                consulta = "DELETE FROM Trafico_EnvioStatus_Correo_Detalle WHERE unidad = '" & carga.Cells("colUnidad").Value.ToString() & "' AND viaje = " & Convert.ToInt32(carga.Cells("colViaje").Value.ToString()) & " AND cartaPorte = '" & carga.Cells("colCartaPorte").Value.ToString() & "'"
                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()
                Me.dGVUnidades.Rows.Remove(carga)

            Next
        Catch ex As Exception

            MessageBox.Show("Error al eliminar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub seleccionarCasillas(ByVal marcar As Boolean)

        For Each carga As DataGridViewRow In Me.dGVUnidades.Rows
            If marcar Then

                carga.Cells("colSeleccionado").Value = True

            Else

                carga.Cells("colSeleccionado").Value = False

            End If
        Next
    End Sub

    Private Function consultarProcedencia(ByVal unidad As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String
        Dim proc As String

        proc = ""

        Try

            consulta = "SELECT CASE id_area WHEN 1 THEN 'ALT' WHEN 2 THEN 'MZLLO' ELSE 'VER' END AS [area] FROM mtto_unidades WHERE id_unidad = '" & unidad & "'"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            proc = comando.ExecuteScalar().ToString()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al consultar la procedencia: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return proc

    End Function


End Class