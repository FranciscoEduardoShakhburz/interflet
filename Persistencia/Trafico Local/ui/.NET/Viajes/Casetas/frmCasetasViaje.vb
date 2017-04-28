Imports System.Data.SqlClient

Public Class frmCasetasViaje

    Private ruta As Integer
    Private bit_full As Boolean
    Private noEjes As Integer

    Private Sub frmCasetasViaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor = Cursors.AppStarting
        Me.getCasetas()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor.Current = Cursors.WaitCursor

        Try
            Dim idCaseta As Integer = 0
            Dim direccion As Integer = 0
            Dim noViaje As Integer = 0
            Dim transitada As Byte = 0
            Dim iaveEfectivo As Byte = 0

            'Guarda las casetas para conciliación de Sistema LIS
            For i As Integer = 0 To Me.grdCasetas.RowCount - 1
                If CDbl(grdCasetas.Rows(i).Cells(4).Value) <> 0 Then
                    If IsDBNull(grdCasetas.Rows(i).Cells(8).Value) Then

                        grdCasetas.Rows(i).Cells(8).Value = False

                    End If

                    If IsDBNull(grdCasetas.Rows(i).Cells(10).Value) Then

                        grdCasetas.Rows(i).Cells(10).Value = False

                    End If

                    noViaje = Convert.ToInt32(Me.TxtNoViaje.Text)
                    idCaseta = Convert.ToInt32(grdCasetas.Rows(i).Cells(0).Value)
                    transitada = CByte(grdCasetas.Rows(i).Cells(8).Value)
                    direccion = Convert.ToInt32(grdCasetas.Rows(i).Cells(1).Value)
                    iaveEfectivo = Convert.ToByte(Me.grdCasetas.Rows(i).Cells(10).Value)
                    GuardaCasetas(noViaje, idCaseta, transitada, direccion, iaveEfectivo)

                End If
            Next

            'Guarda las casetas para conciliación de Tarjetas IAVE
            noViaje = Convert.ToInt32(Me.TxtNoViaje.Text)
            Dim unidad As String = frmDatosViaje.TxtUnidad.Text.Trim()
            Dim tarjeta_iave As String = ""
            Dim fecha As DateTime
            Dim aceptado As Integer = 0
            Dim id_area As Integer = frmDatosViaje.Area
            Dim caseta As String = ""
            Dim id_tarjeta As Integer = 0
            Dim observaciones As String = ""

            For i As Integer = 0 To Me.gridCasetasIAVE.RowCount - 1

                aceptado = CByte(Me.gridCasetasIAVE.Rows(i).Cells("Aceptado").Value)
                tarjeta_iave = Convert.ToString(Me.gridCasetasIAVE.Rows(i).Cells("Tarjeta IAVE").Value)
                fecha = Convert.ToDateTime(Me.gridCasetasIAVE.Rows(i).Cells("Fecha").Value)
                caseta = Convert.ToString(Me.gridCasetasIAVE.Rows(i).Cells("Caseta").Value)
                id_tarjeta = Convert.ToInt32(Me.gridCasetasIAVE.Rows(i).Cells("ID Tarjeta").Value)
                observaciones = Convert.ToString(Me.gridCasetasIAVE.Rows(i).Cells("Observaciones").Value)
                guardaCasetasIAVE(noViaje, unidad, tarjeta_iave, fecha, aceptado, id_area, caseta, id_tarjeta, observaciones)

            Next

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Datos guardados exitosamente")
            Me.Dispose()

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)
            Cursor.Current = Cursors.Arrow

        End Try
    End Sub

    Private Sub GuardaCasetas(ByVal NoViaje As Integer, ByVal IdCaseta As Integer, ByVal Transitada As Boolean, ByVal Direccion As Integer, ByVal iaveEfectivo As Boolean)

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_CasetasViaje", oConexion)
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        Dim oParameter As SqlClient.SqlParameter

        Try

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = NoViaje
            oParameter = oCommand.Parameters.Add("@IdCaseta", SqlDbType.Int)
            oParameter.Value = IdCaseta
            oParameter = oCommand.Parameters.Add("@Transitada", SqlDbType.Bit)
            oParameter.Value = Transitada
            oParameter = oCommand.Parameters.Add("@NoEjes", SqlDbType.Int)
            oParameter.Value = noEjes
            oParameter = oCommand.Parameters.Add("@Direccion", SqlDbType.Int)
            oParameter.Value = Direccion
            oParameter = oCommand.Parameters.Add("@iave_efectivo", SqlDbType.Bit)
            oParameter.Value = iaveEfectivo
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oParameter.ResetSqlDbType()
            oConexion.Close()

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub


    Private Sub guardaCasetasIAVE(ByVal noViaje As Integer, ByVal id_unidad As String, ByVal tarjeta_iave As String, ByVal fecha As DateTime, ByVal aceptado As Byte, ByVal id_area As Integer, ByVal caseta As String, ByVal id_tarjeta As Integer, ByVal observaciones As String)

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim command2 As SqlCommand
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_GUARDA_CASETASIAVE", oConexion)

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        Dim oParameter As SqlClient.SqlParameter

        Try

            oParameter = oCommand.Parameters.Add("@NO_VIAJE", SqlDbType.Int)
            oParameter.Value = noViaje
            oParameter = oCommand.Parameters.Add("@ID_UNIDAD", SqlDbType.VarChar)
            oParameter.Value = id_unidad
            oParameter = oCommand.Parameters.Add("@TARJETA_IAVE", SqlDbType.VarChar)
            oParameter.Value = tarjeta_iave
            oParameter = oCommand.Parameters.Add("@FECHA", SqlDbType.DateTime)
            oParameter.Value = fecha
            oParameter = oCommand.Parameters.Add("@ACEPTADO", SqlDbType.Bit)
            oParameter.Value = aceptado
            oParameter = oCommand.Parameters.Add("@ID_AREA", SqlDbType.Int)
            oParameter.Value = id_area
            oParameter = oCommand.Parameters.Add("@CASETA", SqlDbType.VarChar)
            oParameter.Value = caseta
            oParameter = oCommand.Parameters.Add("@ID_TARJETA", SqlDbType.Int)
            oParameter.Value = id_tarjeta
            oParameter = oCommand.Parameters.Add("@OBSERVACIONES", SqlDbType.VarChar)
            oParameter.Value = observaciones
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Borra_CasetasViaje", oConexion)

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Dim oParameter As SqlClient.SqlParameter

        Try

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = Convert.ToInt32(Me.TxtNoViaje.Text)
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oParameter.ResetSqlDbType()
            MessageBox.Show("Datos borrados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
            Me.Dispose()

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Public Sub getCasetas()

        Me.ruta = frmDatosViaje.IdRuta
        Me.TxtNoViaje.Text = frmDatosViaje.TxtNoViaje.Text
        Me.TxtOrigen.Text = frmDatosViaje.origen
        Me.TxtDestino.Text = frmDatosViaje.destino

        If CType(frmDatosViaje.cmbConfViaje.SelectedItem, TipoViaje).Tipo = "Sencillo" Then

            bit_full = False
            noEjes = 5

        Else

            bit_full = True
            noEjes = 9

        End If

        If frmDatosViaje.Bit_Nuevo = False Then

            Me.btnBorrar.Enabled = True

        Else

            Me.btnBorrar.Enabled = False

        End If

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("UP_Consulta_Casetas2", oConexion)
        Dim oParameter As SqlClient.SqlParameter

        oCommand.CommandTimeout = 3000
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        With oCommand.Parameters

            .AddWithValue("@IdViaje", Me.TxtNoViaje.Text)
            .AddWithValue("@IdRuta", ruta)
            .AddWithValue("@Bit_Full", bit_full)
            .AddWithValue("@Bit_Camioneta", frmDatosViaje.Bit_Camioneta)

        End With
        
        oDa = New SqlClient.SqlDataAdapter(oCommand)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)

        Me.grdCasetas.DataSource = oDs.Tables(0)

        oCommand = New SqlClient.SqlCommand("UP_CONSULTA_CASETASIAVE", oConexion)
        oCommand.CommandType = CommandType.StoredProcedure

        With oCommand.Parameters

            .AddWithValue("@UNIDAD", frmDatosViaje.TxtUnidad.Text)
            .AddWithValue("@FECHA_INICIAL", Convert.ToDateTime(frmDatosViaje.TxtFecIni.Text))
            .AddWithValue("@FECHA_FINAL", Convert.ToDateTime(frmDatosViaje.TxtFecFin.Text))
            .AddWithValue("@VIAJE", Convert.ToInt32(frmDatosViaje.TxtNoViaje.Text.Trim))

        End With
        
        oDa = New SqlClient.SqlDataAdapter(oCommand)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        Me.gridCasetasIAVE.DataSource = oDs.Tables(0)
        oConexion.Close()
        oConexion = Connection.getInstance().getConnectionQFS()
        oCommand = New SqlClient.SqlCommand("UP_Consulta_CasetasSatelital", oConexion)
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        oCommand.CommandTimeout = 600

        With oCommand.Parameters

            .AddWithValue("@Unidad", frmDatosViaje.TxtUnidad.Text)
            .AddWithValue("@FecIniViaje", Convert.ToDateTime(frmDatosViaje.TxtFecIni.Text))
            .AddWithValue("@FecFinViaje", Convert.ToDateTime(frmDatosViaje.TxtFecFin.Text))

        End With

        oDa = New SqlClient.SqlDataAdapter(oCommand)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        oConexion.Close()

        If oDs.Tables(0).Rows.Count > 0 Then

            Me.grdCasetasSatelital.DataSource = oDs.Tables(0)
            Me.sumaCasetas()

        Else

            oConexion = Connection.getInstance().getConnectionQSP()
            oCommand = New SqlClient.SqlCommand("UP_Consulta_CasetasSatelitalQSP", oConexion)
            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
            oCommand.CommandTimeout = 600

            With oCommand.Parameters

                .AddWithValue("@Unidad", frmDatosViaje.TxtUnidad.Text)
                .AddWithValue("@FecIniViaje", (Convert.ToDateTime(frmDatosViaje.TxtFecIni.Text)).ToString("dd/MM/yyyy"))
                .AddWithValue("@FecFinViaje", Convert.ToDateTime(frmDatosViaje.TxtFecFin.Text).ToString("dd/MM/yyyy"))

            End With

            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            Me.grdCasetasSatelital.DataSource = oDs.Tables(0)
            Me.sumaCasetas()
            oConexion.Close()

        End If
    End Sub

    Private Sub grdCasetas_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCasetas.CellEndEdit

        If e.ColumnIndex = 8 Then

            Me.sumaCasetas()

        End If

        ' @ 12/07/2016 OAVS Se agrega que al modificar la tarifa de las casetas se guarde en BD como tarifa alternativa

        If e.ColumnIndex = 4 Then

            Me.grdCasetas.Update()
            Dim viaje As Integer = Convert.ToInt32(Me.TxtNoViaje.Text)
            Dim caseta As Integer = Convert.ToInt32(Me.grdCasetas.CurrentRow.Cells("Id_Caseta").Value.ToString())
            Dim direccion As Integer = Convert.ToInt32(Me.grdCasetas.CurrentRow.Cells("Direccion").Value.ToString())
            Me.actualizarTarifaCaseta(viaje, caseta, direccion, Convert.ToDecimal(Me.grdCasetas.CurrentRow.Cells("tarifas").Value.ToString()))
            Me.getCasetas()

        End If
    End Sub


#Region "Suma de costos en base a casetas seleccionadas"
    Private Sub sumaCasetas()

        If Me.grdCasetas.Rows.Count > 0 Then

            Dim costoCasetasCruzadas As Double = 0.0
            Dim costoCasetasTotales As Double = 0.0
            frmDatosViaje.cruzoTodas = False
            Me.checkCruzoTodas.Checked = False

            For i As Integer = 0 To Me.grdCasetas.RowCount - 1

                costoCasetasTotales += Convert.ToDouble(grdCasetas.Rows(i).Cells(4).Value)

                If grdCasetas.Rows(i).Cells(8).Value Then

                    costoCasetasCruzadas += Convert.ToDouble(grdCasetas.Rows(i).Cells(4).Value)

                End If
            Next

            If costoCasetasCruzadas = costoCasetasTotales Then

                Me.checkCruzoTodas.Checked = True
                frmDatosViaje.cruzoTodas = True

            End If

            Me.TxtSuma.Text = costoCasetasCruzadas

        End If
    End Sub
#End Region
#Region "Cambios pendientes como mejora"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        formCasetasNuevas.ShowDialog()

    End Sub
    Private Sub frmCasetasViaje_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Me.getCasetas()
    End Sub
#End Region

    Private Sub btnActualizarIAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarIAVE.Click

        Cursor = Cursors.WaitCursor

        If Me.gridCasetasIAVE.Rows.Count > 0 Then
            If Convert.ToInt32(Me.gridCasetasIAVE.Rows(0).Cells("ID Tarjeta").Value()) <> 0 Then

                Dim viaje As Integer = Convert.ToInt32(Me.TxtNoViaje.Text.Trim)
                Dim sql As String = "DELETE FROM TRAFICO_TARJETA_IAVE WHERE NO_VIAJE = " & viaje
                Dim conn As SqlConnection = Connection.getInstance().getConnection()
                conn.Open()
                Dim command As SqlCommand = New SqlCommand(sql, conn)
                command.ExecuteNonQuery()
                conn.Close()
                Me.getCasetas()

            End If
        End If

        Cursor = Cursors.Arrow

    End Sub

    Private Sub checkCruzoTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCruzoTodas.CheckedChanged

        If Me.grdCasetas.Rows.Count > 0 Then
            For i As Integer = 0 To Me.grdCasetas.Rows.Count - 1

                Me.grdCasetas.Rows(i).Cells("Transitada").Value = Me.checkCruzoTodas.Checked

            Next
        End If

        If Me.gridCasetasIAVE.Rows.Count > 0 Then
            For i As Integer = 0 To Me.gridCasetasIAVE.Rows.Count - 1

                Me.gridCasetasIAVE.Rows(i).Cells("Aceptado").Value = Me.checkCruzoTodas.Checked

            Next
        End If
    End Sub

    Private Sub actualizarTarifaCaseta(ByVal viaje As Integer, ByVal caseta As Integer, ByVal direccion As Integer, ByVal valor As Decimal)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            consulta = "UPDATE CasetasViaje SET tarifaAlternativa = " & valor & " WHERE Id_Num_Viaje = " & viaje & " AND Id_Caseta = " & caseta & " AND Direccion = " & direccion
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            comando.Dispose()
            conexion.Dispose()
            conexion.Close()

        Catch ex As Exception

            MessageBox.Show("Error al actualizar la tarifa: " & ex.Message & ". " & ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class