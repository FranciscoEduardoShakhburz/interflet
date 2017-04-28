Imports System.Data
Imports System.Data.SqlClient

Public Class CapturaEstadias

    Private noViaje As Integer

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal noViaje As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.noViaje = noViaje

    End Sub

    Private Sub CapturaEstadias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Me.noViaje <> 0 Then

            Me.buscar(Me.noViaje)

        End If
    End Sub

    Private Sub consultar(ByVal noViaje As Integer)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim fila As DataRow
        Dim index As Integer

        Me.dGVContenedores.Rows.Clear()
        Me.dGVCP.Rows.Clear()

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Consulta_Estadia", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@noViaje", noViaje)

            End With

            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    fila = dS.Tables(0).Rows(0)
                    Me.txtEconomico.Text = fila("ECO").ToString()
                    Me.txtOperador.Text = fila("OPERADOR").ToString()
                    Me.txtPlacas.Text = fila("PLACAS").ToString()
                    Me.txtNoViaje.Text = fila("VIAJE").ToString()
                    Me.txtCliente1.Text = fila("CLIENTE1").ToString()
                    Me.txtCliente.Text = fila("CLIENTE").ToString()
                    Me.txtDestino.Text = fila("DESTINO").ToString()

                    For Each filas As DataRow In dS.Tables(0).Rows

                        index = Me.dGVCP.Rows.Add()
                        Me.dGVCP.Rows(index).Cells("colCP").Value = filas("CP").ToString()
                        index = Me.dGVContenedores.Rows.Add()
                        Me.dGVContenedores.Rows(index).Cells("colContenedor").Value = filas("CONTENEDOR").ToString()

                    Next

                    Me.txtTipoOper.Text = fila("TIPO DE OPERACION").ToString()

                    If String.IsNullOrEmpty(fila("LLEGADA CON CLIENTE").ToString().Split(" ")(0)) Then

                        Me.dTPLlegadaCliente.Value = DateTime.Now.ToString("dd/MM/yyyy")

                    Else

                        Me.dTPLlegadaCliente.Value = Convert.ToDateTime(fila("LLEGADA CON CLIENTE").ToString().Split(" ")(0))

                    End If

                    If String.IsNullOrEmpty(fila("LLEGADA CON CLIENTE").ToString()) Then

                        Me.mTBHoraLlegada.Text = "00:00"

                    Else

                        Me.mTBHoraLlegada.Text = Convert.ToDateTime(fila("LLEGADA CON CLIENTE").ToString().Split(" ")(1)).ToString("HH:mm")

                    End If

                    If String.IsNullOrEmpty(fila("SALIDA DE PLANTA").ToString()) Then

                        Me.mTBSalida.Text = "00:00"

                    Else

                        Me.mTBSalida.Text = Convert.ToDateTime(fila("SALIDA DE PLANTA").ToString().Split(" ")(1)).ToString("HH:mm")

                    End If

                    If String.IsNullOrEmpty(fila("SALIDA DE PLANTA").ToString()) Then

                        Me.dTPSalidaPlanta.Value = DateTime.Now

                    Else

                        Me.dTPSalidaPlanta.Value = Convert.ToDateTime(fila("SALIDA DE PLANTA").ToString().Split(" ")(0))

                    End If
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub buscar(ByVal noViaje As Integer)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim dT As DataTable
        Dim index As Integer

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Buscar_Estadias", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@tipoBusqueda", 2)
                .AddWithValue("@unidad", "")
                .AddWithValue("@noViaje", noViaje)
                .AddWithValue("@cliente", "")
                .AddWithValue("@fechaDesde", DateTime.Now)
                .AddWithValue("@fechaHasta", DateTime.Now)

            End With

            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    dT = dS.Tables(0)
                    Me.txtEconomico.Text = dT.Rows(0)("ECO").ToString()
                    Me.txtOperador.Text = dT.Rows(0)("OPERADOR").ToString()
                    Me.txtPlacas.Text = dT.Rows(0)("PLACAS").ToString()
                    Me.txtNoViaje.Text = dT.Rows(0)("VIAJE").ToString()
                    Me.txtCliente1.Text = dT.Rows(0)("CLIENTE1").ToString()
                    Me.txtCliente.Text = dT.Rows(0)("CLIENTE").ToString()
                    Me.txtDestino.Text = dT.Rows(0)("DESTINO").ToString()
                    Me.txtTipoOper.Text = dT.Rows(0)("TIPO DE OPER").ToString()
                    Me.dTPLlegadaCliente.Value = IIf(String.IsNullOrEmpty(dT.Rows(0)("LLEGADA CON CLIENTE").ToString().Split(" ")(0)), DateTime.Now, Convert.ToDateTime(dT.Rows(0)("LLEGADA CON CLIENTE").ToString().Split(" ")(0)))
                    Me.mTBSalida.Text = dT.Rows(0)("SALIDA DE PLANTA").ToString().Split(" ")(1)
                    Me.mTBHoraLlegada.Text = IIf(String.IsNullOrEmpty(dT.Rows(0)("LLEGADA CON CLIENTE").ToString()), "00:00", dT.Rows(0)("LLEGADA CON CLIENTE").ToString().Split(" ")(1))
                    Me.dTPSalidaPlanta.Value = Convert.ToDateTime(dT.Rows(0)("SALIDA DE PLANTA").ToString().Split(" ")(0))
                    Me.txtDias.Text = dT.Rows(0)("DIAS").ToString()
                    Me.txtHorasPlanta.Text = dT.Rows(0)("HRS EN PLANTA").ToString()
                    Me.txtHorasLibres.Text = dT.Rows(0)("HRS LIBRES").ToString()
                    Me.txtHorasDespues.Text = dT.Rows(0)("HRS DESPUES DE 12HRS").ToString()
                    Me.txtDiasEstadia.Text = dT.Rows(0)("DIAS DE ESTADIA").ToString()
                    Me.txtAutorizadas.Text = 0
                    Me.txtEnviadas.Text = 0
                    Me.txtCargo.Text = 0

                    For Each fila As DataRow In dT.Rows
                        If Not String.IsNullOrEmpty(fila("CP").ToString()) Then

                            index = Me.dGVCP.Rows.Add()
                            Me.dGVCP.Rows(index).Cells("colCP").Value = fila("CP").ToString()
                            index = Me.dGVContenedores.Rows.Add()
                            Me.dGVContenedores.Rows(index).Cells("colContenedor").Value = fila("CONTENEDOR").ToString()

                        End If
                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al buscar la informacion: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub txtNoViaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoViaje.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Cursor.Current = Cursors.WaitCursor
            Me.consultar(Convert.ToInt32(Me.txtNoViaje.Text))
            Cursor.Current = Cursors.Arrow

        End If
    End Sub

    Private Sub dTPSalidaPlanta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dTPSalidaPlanta.ValueChanged

        Me.txtDias.Text = (DateDiff(DateInterval.Hour, dTPLlegadaCliente.Value.AddHours(Convert.ToDouble(Me.mTBHoraLlegada.Text.Split(":")(0))).AddMinutes(Convert.ToDouble(Me.mTBHoraLlegada.Text.Split(":")(1))), dTPSalidaPlanta.Value.AddHours(Convert.ToDouble(Me.mTBSalida.Text.Split(":")(0))).AddMinutes(Convert.ToDouble(Me.mTBSalida.Text.Split(":")(1))))) / 24.0
        Me.txtHorasPlanta.Text = (DateDiff(DateInterval.Hour, dTPLlegadaCliente.Value.AddHours(Convert.ToDouble(Me.mTBHoraLlegada.Text.Split(":")(0))).AddMinutes(Convert.ToDouble(Me.mTBHoraLlegada.Text.Split(":")(1))), dTPSalidaPlanta.Value.AddHours(Convert.ToDouble(Me.mTBSalida.Text.Split(":")(0))).AddMinutes(Convert.ToDouble(Me.mTBSalida.Text.Split(":")(1))))) * 1.0
        Me.txtHorasLibres.Text = 12
        Me.txtHorasDespues.Text = IIf(Convert.ToDouble(Me.txtHorasPlanta.Text) > Convert.ToDouble(Me.txtHorasLibres.Text), Convert.ToDouble(Me.txtHorasPlanta.Text) - Convert.ToDouble(Me.txtHorasLibres.Text), 0)

    End Sub

    Private Sub guardarInfoViaje()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Estadia_Insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@economico", Me.txtEconomico.Text)
                .AddWithValue("@operador", Me.txtOperador.Text)
                .AddWithValue("@placas", Me.txtPlacas.Text)
                .AddWithValue("@noViaje", Convert.ToInt32(Me.txtNoViaje.Text))
                .AddWithValue("@cliente1", Me.txtCliente1.Text)
                .AddWithValue("@cliente", Me.txtCliente.Text)
                .AddWithValue("@destino", Me.txtDestino.Text)
                .AddWithValue("@tipoOper", Me.txtTipoOper.Text)
                .AddWithValue("@fechaEst", DateTime.Now)

            End With

            comando.ExecuteNonQuery()
            comando.Dispose()
            conexion.Dispose()
            conexion.Close()

        Catch ex As Exception

            MessageBox.Show("Error al guardar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub guardarInfoEstadia()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim indice As Integer = 0

        Try

            For Each contenedor As DataGridViewRow In Me.dGVContenedores.Rows
                If Not String.IsNullOrEmpty(contenedor.Cells("colContenedor").Value.ToString()) Then

                    conexion = Connection.getInstance().getConnection()
                    comando = New SqlCommand("UP_Estadia_Detalle_Insert", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 600
                    conexion.Open()

                    With comando.Parameters

                        .AddWithValue("@noViaje", Convert.ToInt32(Me.txtNoViaje.Text))
                        .AddWithValue("@cartaPorte", IIf(indice < Me.dGVCP.Rows.Count, Me.dGVCP.Rows(indice).Cells("colCP").Value.ToString(), ""))
                        .AddWithValue("@contenedor", contenedor.Cells("colContenedor").Value.ToString())
                        .AddWithValue("@fechaLleg", Me.dTPLlegadaCliente.Value)
                        .AddWithValue("@horaLleg", Me.mTBHoraLlegada.Text)
                        .AddWithValue("@fechaSal", Me.dTPSalidaPlanta.Value)
                        .AddWithValue("@horaSal", Me.mTBSalida.Text)
                        .AddWithValue("@dias", Convert.ToDecimal(Me.txtDias.Text))
                        .AddWithValue("@horasPlanta", Convert.ToDecimal(Me.txtHorasPlanta.Text))
                        .AddWithValue("@horasLibres", Convert.ToInt32(Me.txtHorasLibres.Text))
                        .AddWithValue("@horasD12", Convert.ToDecimal(Me.txtHorasDespues.Text))
                        .AddWithValue("@diasEstadia", Convert.ToInt32(Me.txtDiasEstadia.Text))

                    End With

                    comando.ExecuteNonQuery()
                    comando.Dispose()
                    conexion.Dispose()
                    conexion.Close()
                    indice += 1

                End If
            Next
        Catch ex As Exception

            MessageBox.Show("Error al guardar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor.Current = Cursors.WaitCursor

        Try

            Me.guardarInfoViaje()
            Me.guardarInfoEstadia()
            MessageBox.Show("El registro se ha guardado correctamente", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnCancelar_Click(sender, e)

        Catch ex As Exception

        End Try

        Cursor.Current = Cursors.Arrow

    End Sub
End Class