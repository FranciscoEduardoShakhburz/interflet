Imports System.Data
Imports System.Data.SqlClient

Public Class BitacoraViaje

    Private Sub BitacoraViaje_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarCombo()
        Me.rBForaneos.Checked = True
        Me.cBEstatusViaje.SelectedItem = 0

    End Sub

    Private Sub bCargarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCargarInfo.Click

        Me.dGVViajes.Rows.Clear()
        Me.dGVBitacora.Rows.Clear()
        Me.consultarInformacion()
        Me.filtrarInformacion()

    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click

        Me.Close()

    End Sub

    Private Sub dGVViajes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVViajes.CellContentClick

        Me.mostrarBitacora(Convert.ToInt32(Me.dGVViajes.SelectedRows(0).Cells("colViaje").Value.ToString()))

    End Sub

    Private Sub bRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRefrescar.Click

    End Sub

    Private Sub rBForaneos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBForaneos.CheckedChanged, rBTodos.CheckedChanged, rBLocales.CheckedChanged

        Me.filtrarInformacion()

    End Sub

    Private Sub cBEstatusViaje_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBEstatusViaje.SelectionChangeCommitted

        Me.filtrarInformacion()

    End Sub

    Private Sub bAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAgregar.Click

        Dim ab As AgregarBitacora = New AgregarBitacora(Me.dGVViajes.SelectedRows(0))
        ab.ShowDialog(Me)
        Me.mostrarBitacora(Convert.ToInt32(Me.dGVViajes.SelectedRows(0).Cells("colViaje").Value.ToString()))

    End Sub

    Public Sub consultarInformacion()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim fila As DataGridViewRow

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ConsultarSalidas", conexion)
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
                        If Me.dGVViajes.Rows.Count > 0 Then
                            If Me.dGVViajes.Rows(Me.dGVViajes.Rows.Count - 1).Cells("colUnidad").Value.ToString().Equals(unidad("unidad").ToString()) And Me.dGVViajes.Rows(Me.dGVViajes.Rows.Count - 1).Cells("colViaje").Value.ToString().Equals(unidad("viaje").ToString()) Then

                                Me.dGVViajes.Rows(Me.dGVViajes.Rows.Count - 1).Cells("colCP").Value = Me.dGVViajes.Rows(Me.dGVViajes.Rows.Count - 1).Cells("colCP").Value.ToString() & " / " & unidad("cartaPorte").ToString()
                                Me.dGVViajes.Rows(Me.dGVViajes.Rows.Count - 1).Cells("colContenedor").Value = Me.dGVViajes.Rows(Me.dGVViajes.Rows.Count - 1).Cells("colContenedor").Value.ToString() & " / " & unidad("contenedores").ToString()
                                Continue For

                            End If
                        End If

                        fila = Me.dGVViajes.Rows(Me.dGVViajes.Rows.Add())
                        fila.Cells("colStatusViaje").Value = "SV"
                        fila.Cells("colTipoUnidad").Value = unidad("tipoUnidad").ToString()
                        fila.Cells("colUnidad").Value = unidad("unidad").ToString()
                        fila.Cells("colOperador").Value = unidad("operador").ToString()
                        fila.Cells("colPlacas").Value = unidad("placas").ToString()
                        fila.Cells("colViaje").Value = unidad("viaje").ToString()
                        fila.Cells("colObservaciones").Value = unidad("observaciones").ToString()
                        fila.Cells("colNumeroCliente").Value = unidad("numeroCliente").ToString()
                        fila.Cells("colCliente").Value = unidad("cliente").ToString()
                        fila.Cells("colDestino").Value = unidad("Destino").ToString()
                        fila.Cells("colCP").Value = unidad("cartaPorte").ToString()
                        fila.Cells("colContenedor").Value = unidad("contenedores").ToString()
                        fila.Cells("colTipoOperacion").Value = unidad("tipoOper").ToString()
                        fila.Cells("colDireccionEntrega").Value = unidad("direccionEntrega").ToString()
                        fila.Cells("colStatus").Value = unidad("status").ToString()
                        fila.Cells("colUbicacion").Value = unidad("ubicacion").ToString()

                        If unidad("status").ToString().Contains("TRANS") Or unidad("status").ToString().Contains("REGRE") Or unidad("status").ToString().Contains("CLIENTE") Then

                            fila.Cells("colStatusViaje").Value = "VI"
                            fila.Cells("colStatusViaje").Style.BackColor = Color.GreenYellow

                        End If

                        Me.guardarBitacora(fila)
                        Me.guardarSucesosSistema(fila)

                    Next
                End If
            End If

        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub cargarCombo()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        Try

            consulta = "SELECT id, nombre + ' (' + abreviatura + ')' AS statusViaje FROM SistemaInterflet_EstatusViaje"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then

                Me.cBEstatusViaje.DataSource = dS.Tables(0)
                Me.cBEstatusViaje.ValueMember = "id"
                Me.cBEstatusViaje.DisplayMember = "statusViaje"

            End If
        Catch ex As Exception

            MessageBox.Show("Error al cargar los estatus: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub guardarBitacora(ByVal bitacora As DataGridViewRow)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_BitacoraViaje_Ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@numeroViaje", Convert.ToInt32(bitacora.Cells("colViaje").Value.ToString()))
                .AddWithValue("@unidad", bitacora.Cells("colUnidad").Value.ToString())
                .AddWithValue("@operador", bitacora.Cells("colOperador").Value.ToString())
                .AddWithValue("@numeroCliente", Convert.ToInt32(bitacora.Cells("colNumeroCliente").Value.ToString()))
                .AddWithValue("@destino", bitacora.Cells("colDestino").Value.ToString())
                .AddWithValue("@cartaPorte", bitacora.Cells("colCP").Value.ToString())
                .AddWithValue("@contenedor", bitacora.Cells("colContenedor").Value.ToString())

            End With

            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al guardar la bitácora: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub guardarSucesosSistema(ByVal bitacora As DataGridViewRow)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        Try

            consulta = "SELECT idSuceso FROM SistemaInterflet_CatSucesos WHERE tipoSuceso = 1"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each tipo As DataRow In dS.Tables(0).Rows

                        conexion = Connection.getInstance().getConnection()
                        comando = New SqlCommand("UP_SucesoSistema_Ins", conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.CommandTimeout = 600
                        conexion.Open()

                        With comando.Parameters

                            .AddWithValue("@unidad", bitacora.Cells("colUnidad").Value.ToString())
                            .AddWithValue("@status", bitacora.Cells("colStatus").Value.ToString())
                            .AddWithValue("@numeroViaje", Convert.ToInt32(bitacora.Cells("colViaje").Value.ToString()))
                            .AddWithValue("@sucesoId", Convert.ToInt32(tipo("idSuceso").ToString()))

                        End With

                        comando.ExecuteNonQuery()
                        conexion.Close()
                        conexion.Dispose()
                        comando.Dispose()

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al guardar los sucesos: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub mostrarBitacora(ByVal noViaje As Integer)

        Dim bitacora As DataGridViewRow
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        Try

            Me.dGVBitacora.Rows.Clear()
            Me.dGVViajes.Refresh()
            consulta = "SELECT suc.idBitacora, CASE (SELECT tipoSuceso FROM SistemaInterflet_CatSucesos WHERE idSuceso = suc.idTipoSuceso) WHEN 1 THEN 'SISTEMA' WHEN 2 THEN 'USUARIO' END AS tipoSuc, suc.suceso, suc.observaciones FROM SistemaInterflet_BitacoraViaje_Sucesos suc WHERE numeroViaje = " & noViaje
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each suceso As DataRow In dS.Tables(0).Rows

                        bitacora = Me.dGVBitacora.Rows(Me.dGVBitacora.Rows.Add())
                        bitacora.Cells("colNumero").Value = suceso("idBitacora").ToString()
                        bitacora.Cells("colTipoSuceso").Value = suceso("tipoSuc").ToString()
                        bitacora.Cells("colSuceso").Value = suceso("suceso").ToString()
                        bitacora.Cells("colObservacionesSuc").Value = suceso("observaciones").ToString()

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al mostrar la bitácora: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub filtrarInformacion()

        For Each viajes As DataGridViewRow In Me.dGVViajes.Rows
            If Me.rBForaneos.Checked = True Then
                If Me.cBEstatusViaje.SelectedValue = 1 Then
                    If viajes.Cells("colUnidad").Value.ToString().Contains("T-") And viajes.Cells("colStatusViaje").Value.ToString().Contains("VI") Then

                        viajes.Visible = True

                    Else

                        viajes.Visible = False

                    End If
                ElseIf Me.cBEstatusViaje.SelectedValue = 1 Then

                End If
            ElseIf Me.rBLocales.Checked = True Then

            End If
        Next
    End Sub

    Private Sub guardarSucesosUsuario(ByVal bitacora As DataGridViewRow)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        Try

            consulta = "SELECT idSuceso FROM SistemaInterflet_CatSucesos WHERE tipoSuceso = 1"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each tipo As DataRow In dS.Tables(0).Rows

                        conexion = Connection.getInstance().getConnection()
                        comando = New SqlCommand("UP_SucesoSistema_Ins", conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.CommandTimeout = 600
                        conexion.Open()

                        With comando.Parameters

                            .AddWithValue("@unidad", bitacora.Cells("colUnidad").Value.ToString())
                            .AddWithValue("@status", bitacora.Cells("colStatus").Value.ToString())
                            .AddWithValue("@numeroViaje", Convert.ToInt32(bitacora.Cells("colViaje").Value.ToString()))
                            .AddWithValue("@sucesoId", Convert.ToInt32(tipo("idSuceso").ToString()))

                        End With

                        comando.ExecuteNonQuery()
                        conexion.Close()
                        conexion.Dispose()
                        comando.Dispose()

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al guardar los sucesos: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class