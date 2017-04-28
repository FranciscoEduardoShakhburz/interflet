Imports System.Data.Sqlclient
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms

Public Class formSolicitudTransporte
    Private id_agencia As Integer
    Private id_terminal_origen As Integer
    Private id_terminal_reexpedicion As Integer
    Private id_tipo_programacion As Integer
    Private tipo_viaje As String
    Dim viaje_de As String
    Dim sConn As String


#Region "Eventos"
    Private Sub formSolicitudTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Llena Datos AutoCompletados de Destino
        Me.TxtDestino.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.TxtDestino.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        Me.getData(DataCollection)
        Me.TxtDestino.AutoCompleteCustomSource = DataCollection

        'Llena Datos AutoCompletados de Clientes
        Me.txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection2 As New AutoCompleteStringCollection()
        Me.getData2(DataCollection2)
        Me.txtCliente.AutoCompleteCustomSource = DataCollection2

        'Llena Datos AutoCompletados de Agencias
        Me.txtAgenciaAduanal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAgenciaAduanal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection3 As New AutoCompleteStringCollection()
        Me.getData3(DataCollection3)
        Me.txtAgenciaAduanal.AutoCompleteCustomSource = DataCollection3

        'Llena Datos AutoCompletados de ejecutivos
        Me.txtEjecutivo.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtEjecutivo.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection4 As New AutoCompleteStringCollection()
        Me.getData4(DataCollection4)
        Me.txtEjecutivo.AutoCompleteCustomSource = DataCollection4

        'Llena Datos Autocompletados de TerminalOrigen
        Me.txtTerminalOrigen.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTerminalOrigen.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection5 As New AutoCompleteStringCollection()
        Me.getData5(DataCollection5)
        Me.txtTerminalOrigen.AutoCompleteCustomSource = DataCollection5

        'Llena Datos Autocompletados de Terminal de Reexpediciones
        Me.txtTerminalReexpedicion.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTerminalReexpedicion.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtTerminalReexpedicion.AutoCompleteCustomSource = DataCollection5

        'Llena Datos Autocmpletados de Navieras
        Me.txtNaviera.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtNaviera.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection6 As New AutoCompleteStringCollection()
        Me.getData6(DataCollection6)
        Me.txtNaviera.AutoCompleteCustomSource = DataCollection6


        Me.cmbMovimiento.DataSource = TipoMovimientoDAO.getTiposMovimiento()
        Me.cmbMercancia.DataSource = TipoMercanciaDAO.getTiposMercancia()
        ' Me.cmbTipoContenedores.DataSource = TipoContenedorDAO.getTiposContenedor()
        Me.siguiente_folio()
        Me.cmbMovimiento.SelectedIndex = 0
        Me.cmbMercancia.SelectedIndex = 0
        'Me.cmbTipoContenedores.SelectedIndex = 0
        Me.radioLocal.Checked = True
        Me.rnoche.Checked = True
    End Sub

    'Private Sub txtAgenciaAduanal_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtAgenciaAduanal.PreviewKeyDown
    'If Not String.IsNullOrEmpty(Me.txtAgenciaAduanal.Text.Trim) AndAlso e.KeyCode = Keys.Tab Then
    ' Me.getAgenciaById(Me.txtAgenciaAduanal.Text.Trim)
    'End If
    'End Sub

    Private Sub txtTerminalOrigen_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtTerminalOrigen.PreviewKeyDown
        If Not String.IsNullOrEmpty(Me.txtTerminalOrigen.Text.Trim) AndAlso e.KeyCode = Keys.Tab Then
            ' Me.getTerminalById(Me.txtTerminalOrigen.Text.Trim, "Origen")
        End If
    End Sub

    Private Sub txtTerminalReexpedicion_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtTerminalReexpedicion.PreviewKeyDown
        If Not String.IsNullOrEmpty(Me.txtTerminalReexpedicion.Text.Trim) AndAlso e.KeyCode = Keys.Tab Then
            'Me.getTerminalById(Me.txtTerminalReexpedicion.Text.Trim, "Reexpedicion")
        End If
    End Sub

    Private Sub txtTipoProgramacion_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtTipoProgramacion.PreviewKeyDown
        If Not String.IsNullOrEmpty(Me.txtTipoProgramacion.Text.Trim) AndAlso e.KeyCode = Keys.Tab Then
            'Me.getTipoProgramacion(Me.txtTipoProgramacion.Text.Trim)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
#End Region

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim referencia, ejecutivo, cliente, pedido_cliente, proveedor, buque, mercancia, estatus, naviera, booking, imo, un, no_contenedores, observaciones As String

        referencia = Me.txtReferencia.Text.Trim
        ejecutivo = Me.txtEjecutivo.Text.Trim
        cliente = Me.txtCliente.Text.Trim
        pedido_cliente = Me.txtPedidoCliente.Text.Trim
        proveedor = Me.txtProveedor.Text.Trim
        buque = Me.txtBuque.Text.Trim
        mercancia = Me.txtMercancia.Text.Trim
        estatus = Me.txtEstatus.Text.Trim
        naviera = Me.txtNaviera.Text.Trim
        booking = Me.txtBooking.Text.Trim
        imo = Me.txtIMO.Text.Trim
        un = Me.txtUN.Text.Trim
        no_contenedores = 1 'Me.txtNoContenedores.Text.Trim
        observaciones = Me.txtObservaciones.Text.Trim

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand("UP_GUARDA_LOCAL_SOLICITUD_VIAJE", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.lblFolio.Text)
        command.Parameters.AddWithValue("@REFERENCIA", referencia)
        command.Parameters.AddWithValue("@EJECUTIVO", ejecutivo)
        command.Parameters.AddWithValue("@CLIENTE", cliente)
        command.Parameters.AddWithValue("@PEDIDO_CLIENTE", pedido_cliente)
        command.Parameters.AddWithValue("@PROVEEDOR", proveedor)
        command.Parameters.AddWithValue("@BUQUE", buque)
        command.Parameters.AddWithValue("@MERCANCIA", mercancia)
        command.Parameters.AddWithValue("@ESTATUS", estatus)
        command.Parameters.AddWithValue("@NAVIERA", naviera)
        command.Parameters.AddWithValue("@BOOKING", booking)
        command.Parameters.AddWithValue("@IMO", imo)
        command.Parameters.AddWithValue("@UN", un)
        command.Parameters.AddWithValue("@NO_CONTENEDORES", no_contenedores)
        command.Parameters.AddWithValue("@OBSERVACIONES", observaciones)
        command.Parameters.AddWithValue("@MOVIMIENTO", DirectCast(Me.cmbMovimiento.SelectedItem, TipoMovimiento).id_movimiento)
        command.Parameters.AddWithValue("@ID_AGENCIA_ADUANAL", Me.txtAgenciaAduanal.Text)
        command.Parameters.AddWithValue("@ID_TIPO_MERCANCIA", DirectCast(Me.cmbMercancia.SelectedItem, TipoMercancia).id_mercancia)
        command.Parameters.AddWithValue("@ID_TERMINAL_ORIGEN", "TER - " & Me.txtTerminalOrigen.Text)
        command.Parameters.AddWithValue("@ID_TIPO_PROGRAMACION", 1) 'Me.txtTipoProgramacion.Text)
        command.Parameters.AddWithValue("@ID_TERMINAL_REEXPEDICION", "TER - " & Me.txtTerminalOrigen.Text)
        command.Parameters.AddWithValue("@ID_TIPO_CONTENEDOR", 1) 'DirectCast(Me.cmbTipoContenedores.SelectedItem, TipoContenedor).id_tipo_contenedor)
        command.Parameters.AddWithValue("@FECHA_SOLICITUD", Me.cmbFechaSolicitud.Value)
        command.Parameters.AddWithValue("@ETA", Me.cmbETA.Value)
        command.Parameters.AddWithValue("@FECHA_PAGO_PEDIMENTO", Me.cmbFechaPagoPedimento.Value)
        command.Parameters.AddWithValue("@FECHA_DEMORAS", Me.cmbFechaDemoras.Value)
        command.Parameters.AddWithValue("@FECHA_ALMACENAJE", Me.cmbFechaAlmacenaje.Value)
        command.Parameters.AddWithValue("@FECHA_ZARPE", Me.cmbFechaZarpe.Value)
        command.Parameters.AddWithValue("@FECHA_ARRIBO", Me.cmbFechaArribo.Value)
        command.Parameters.AddWithValue("@FECHA_CIERRE_DOCUMENTOS", Me.cmbCierreDocumentos.Value)
        command.Parameters.AddWithValue("@FECHA_CIERRE_DESPACHO", Me.cmbCierreDespacho.Value)
        command.Parameters.AddWithValue("@TIPO_VIAJE", Me.tipo_viaje)
        command.Parameters.AddWithValue("@SUBCLIENTE", Me.TxtSubCliente.Text)
        command.Parameters.AddWithValue("@DESTINO", Me.TxtDestino.Text)
        command.Parameters.AddWithValue("@VIAJEDE", Me.viaje_de)
        command.ExecuteNonQuery()
        Me.InsertarBaseSeguimiento() 'Insertamos los etatus y fchas BASE para el seguimiento de la unidad
        MessageBox.Show("Solicitud de viaje guardada")
        Me.limpiar()
    End Sub

    Private Sub siguiente_folio()
        Dim folio As String = ""
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "SELECT FOLIO_SOLICITUD_VIAJE FROM TRAFICO_LOCAL_SOLICITUD_VIAJE2 ORDER BY ID_SOLICITUD DESC"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        folio = command.ExecuteScalar().ToString()
        Dim folio_array() As String = folio.Split("-")
        folio_array(1) = (Convert.ToInt32(folio_array(1)) + 1).ToString()
        Me.lblFolio.Text = folio_array(0) & "-" & folio_array(1)
    End Sub

    Private Sub limpiar()
        For Each control As Control In Me.groupSolicitud.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
        Me.txtObservaciones.Text = ""
        Me.siguiente_folio()
    End Sub

    Private Sub btnAnadirContenedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnadirContenedor.Click
        formGuardaContenedores.Show()
    End Sub

    Private Sub btnBorrarContenedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarContenedor.Click
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "DELETE FROM TRAFICO_LOCAL_CONTENEDOR WHERE CONTENEDOR = @CONTENEDOR AND ID_SOLICITUD = @ID_SOLICITUD"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("CONTENEDOR").Value.ToString())
        command.Parameters.AddWithValue("@ID_SOLICITUD", Me.lblFolio.Text)
        conn.Open()
        command.ExecuteNonQuery()
        Me.getContenedoresBySolicitud(Me.lblFolio.Text)
    End Sub

    Private Sub getContenedoresBySolicitud(ByVal folio As String)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT * FROM TRAFICO_LOCAL_CONTENEDOR WHERE ID_SOLICITUD = @ID_SOLICITUD"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@ID_SOLICITUD", folio)
        conn.Open()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridContenedores.DataSource = table
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Not String.IsNullOrEmpty(Me.txtSolicitud.Text.Trim) Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim sql As String = "SELECT * FROM TRAFICO_LOCAL_SOLICITUD_VIAJE2 WHERE FOLIO_SOLICITUD_VIAJE = @FOLIO_SOLICITUD_VIAJE"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.txtSolicitud.Text.Trim)
            conn.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Me.lblFolio.Text = Convert.ToString(reader("folio_solicitud_viaje"))
                Me.txtReferencia.Text = Convert.ToString(reader("referencia"))
                Me.txtEjecutivo.Text = Convert.ToString(reader("ejecutivo"))
                Me.txtCliente.Text = Convert.ToString(reader("cliente"))
                Me.txtPedidoCliente.Text = Convert.ToString(reader("pedido_cliente"))
                Me.txtProveedor.Text = Convert.ToString(reader("proveedor"))
                Me.txtBuque.Text = Convert.ToString(reader("buque"))
                Me.txtMercancia.Text = Convert.ToString(reader("mercancia"))
                Me.txtEstatus.Text = Convert.ToString(reader("estatus"))
                Me.txtNaviera.Text = Convert.ToString(reader("naviera"))
                Me.txtBooking.Text = Convert.ToString(reader("booking"))
                Me.txtIMO.Text = Convert.ToString(reader("imo"))
                Me.txtUN.Text = Convert.ToString(reader("un"))
                'Me.txtNoContenedores.Text = Convert.ToString(reader(""))
                Me.txtObservaciones.Text = Convert.ToString(reader("observaciones"))
                Me.txtAgenciaAduanal.Text = Convert.ToString(reader("ID_AGENCIA_ADUANAL"))
                Me.TxtDestino.Text = Convert.ToString(reader("DESTINO"))
                Me.txtTerminalOrigen.Text = Convert.ToString(reader("ID_TERMINAL_ORIGEN"))
                Me.txtTerminalReexpedicion.Text = Convert.ToString(reader("ID_TERMINAL_REEXPEDICION"))
                Me.txtTipoProgramacion.Text = Convert.ToString(reader("ID_TERMINAL_ORIGEN"))

                Dim id_movimiento As Integer = Convert.ToInt32(reader("movimiento"))
                Dim movimiento As TipoMovimiento = New TipoMovimiento()
                movimiento.id_movimiento = id_movimiento
                Me.cmbMovimiento.SelectedItem = movimiento

                'Me.getAgenciaById(Convert.ToString(reader("id_agencia_aduanal")))

                Dim id_mercancia As Integer = Convert.ToInt32(reader("id_tipo_mercancia"))
                Dim mercancia As TipoMercancia = New TipoMercancia()
                mercancia.id_mercancia = id_mercancia
                Me.cmbMercancia.SelectedItem = mercancia

                'Me.getTerminalById(Convert.ToString(reader("id_terminal_origen")), "Origen")

                'Me.getTipoProgramacion(Convert.ToString(reader("id_tipo_programacion")))

                'Me.getTerminalById(Convert.ToString(reader("id_terminal_reexpedicion")), "Reexpedicion")

                Dim tipo_contenedor As TipoContenedor = New TipoContenedor()
                tipo_contenedor.id_tipo_contenedor = Convert.ToString(reader("id_tipo_contenedor"))
                'falta contenedor

                Me.cmbFechaSolicitud.Value = Convert.ToDateTime(reader("fecha_solicitud"))
                Me.cmbETA.Value = Convert.ToDateTime(reader("eta"))
                Me.cmbFechaPagoPedimento.Value = Convert.ToDateTime(reader("fecha_pago_pedimento"))
                Me.cmbFechaDemoras.Value = Convert.ToDateTime(reader("fecha_demoras"))
                Me.cmbFechaAlmacenaje.Value = Convert.ToDateTime(reader("fecha_almacenaje"))
                Me.cmbFechaZarpe.Value = Convert.ToDateTime(reader("fecha_zarpe"))
                Me.cmbFechaArribo.Value = Convert.ToDateTime(reader("fecha_arribo"))
                Me.cmbCierreDocumentos.Value = Convert.ToDateTime(reader("fecha_cierre_documentos"))
                Me.cmbCierreDespacho.Value = Convert.ToDateTime(reader("fecha_cierre_despacho"))
                Me.tipo_viaje = Convert.ToString(reader("tipo_viaje"))
                Me.viaje_de = Convert.ToString(reader("ViajeDe"))
                getContenedoresBySolicitud(Me.txtSolicitud.Text.Trim)
            End While
        Else
            MessageBox.Show("Escribe un folio a buscar")
        End If
    End Sub

    Private Sub cmbMovimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMovimiento.SelectedIndexChanged
        If cmbMovimiento.SelectedIndex = 1 Then
            cmbFechaDemoras.Hide()
            txtBooking.Show()
            cmbFechaZarpe.Show()
            cmbCierreDocumentos.Show()
            cmbCierreDespacho.Show()
        Else
            cmbFechaDemoras.Show()
            txtBooking.Hide()
            cmbFechaZarpe.Hide()
            cmbCierreDocumentos.Hide()
            cmbCierreDespacho.Hide()
        End If

    End Sub
    Private Sub getData(ByVal dataCollection As AutoCompleteStringCollection) 'AUTO COMPLETADO PARA DESTINO

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = "SELECT DISTINCT desc_plaza FROM trafico_plaza"

        Try
            conn.Open()
            command = New SqlCommand(sql, conn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            conn.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub getData2(ByVal dataCollection As AutoCompleteStringCollection) 'AUTO COMPLETADO PARA CLIENTES
        Dim connetionString As String = Nothing
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = "SELECT DISTINCT NOMBRE FROM trafico_cliente"

        Try
            conn.Open()
            command = New SqlCommand(sql, conn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            conn.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub getData3(ByVal dataCollection As AutoCompleteStringCollection) 'AUTO COMPLETADO PARA Agencias 
        Dim connetionString As String = Nothing
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = "SELECT DISTINCT nombre_agencia_aduanal FROM TRAFICO_LOCAL_AGENCIA_ADUANAL"

        Try
            conn.Open()
            command = New SqlCommand(sql, conn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            conn.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub
    Private Sub getData4(ByVal dataCollection As AutoCompleteStringCollection) 'AUTO COMPLETADO PARA Ejecutivos
        Dim connetionString As String = Nothing
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = "SELECT DISTINCT Nombre FROM trafico_ejecutivos"

        Try
            conn.Open()
            command = New SqlCommand(sql, conn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            conn.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub
    Private Sub getData5(ByVal dataCollection As AutoCompleteStringCollection) 'AUTO COMPLETADO PARA Terminales
        Dim connetionString As String = Nothing
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = "SELECT nombre_terminal FROM TRAFICO_LOCAL_TERMINAL"

        Try
            conn.Open()
            command = New SqlCommand(sql, conn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            conn.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub
    Private Sub getData6(ByVal dataCollection As AutoCompleteStringCollection) 'AUTO COMPLETADO PARA Navieras
        Dim connetionString As String = Nothing
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = "SELECT naviera FROM trafico_local_navieras"

        Try
            conn.Open()
            command = New SqlCommand(sql, conn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            conn.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub rnoche_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rnoche.CheckedChanged
        Me.viaje_de = "NOCHE"
    End Sub
    Private Sub radioLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioLocal.CheckedChanged
        Me.tipo_viaje = "LOCAL"
    End Sub

    Private Sub radioForaneo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioForaneo.CheckedChanged
        Me.tipo_viaje = "FORANEO"
    End Sub

    Private Sub rdia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdia.CheckedChanged
        Me.viaje_de = "DIA"
    End Sub

    
    Private Sub bto_referencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_referencia.Click
        Me.datosGenerales()
        Me.datosPartidas()
        Me.GridContenedoresFox()
    End Sub
    Public Sub datosGenerales()


        Dim sSelect As String = "SELECT * FROM datosref.DBF where referencia like '" & txt_refer.Text & "'"


        sConn = "Provider=vfpoledb.1;Data Source=C:\pruebas\datosref.DBF;Mode=3;"
        Dim con As OleDbConnection = New OleDbConnection(sConn)
        Dim command As OleDbCommand
        con.Open()
        Try

            command = New System.Data.OleDb.OleDbCommand(sSelect, con)
            Dim reg As OleDbDataReader = command.ExecuteReader()
            If reg.HasRows Then
                reg.Read()
                cmbFechaSolicitud.Text = reg.GetValue(2)
                cmbMercancia.Text = reg.GetValue(4)
                txtTipoProgramacion.Text = Trim(reg.GetValue(5))
                txtTerminalReexpedicion.Text = Trim(reg.GetValue(6))
                cmbFechaDemoras.Text = reg.GetValue(7)
                cmbFechaAlmacenaje.Text = reg.GetValue(8)
                txtEjecutivo.Text = Trim(reg.GetValue(12))
                txtTerminalOrigen.Text = Trim(reg.GetValue(21))
                txtNaviera.Text = Trim(reg.GetValue(23))
                txtReferencia.Text = Trim(txt_refer.Text)
                txtReferencia.Enabled = False
            Else
                MessageBox.Show("NO HAY REGISTROS")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub datosPartidas()
        Dim sSelect As String = "SELECT * FROM datosrefp.DBF where referencia like '" & txt_refer.Text & "'"
        sConn = "Provider=vfpoledb.1;Data Source=C:\pruebas\datosrefp.DBF;Mode=3;"
        Dim con As OleDbConnection = New OleDbConnection(sConn)
        Dim command As OleDbCommand
        con.Open()
        Try
            command = New System.Data.OleDb.OleDbCommand(sSelect, con)
            Dim reg As OleDbDataReader = command.ExecuteReader()
            If reg.HasRows Then
                reg.Read()
                TxtDestino.Text = Trim(reg.GetValue(8))
            Else
                MessageBox.Show("No hay registros")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub InsertarBaseSeguimiento()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "insert into TRAFICO_LOCAL_SEGUIMIENTO2   values ('" & lblFolio.Text & "'" & ",getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),NULL,getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),getdate(),1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,NULL)"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        conn.Open()
        command.ExecuteNonQuery()
    End Sub
    Public Sub GridContenedoresFox()
        Dim sSelect As String = "SELECT contenedor FROM datosrefp.DBF where referencia like '" & txt_refer.Text & "'"
        sConn = "Provider=vfpoledb.1;Data Source=C:\pruebas\datosrefp.DBF;Mode=3;"
        Dim con As OleDbConnection = New OleDbConnection(sConn)
        con.Open()
        Try
            Dim da2 As New System.Data.OleDb.OleDbDataAdapter(sSelect, con)

            Dim dt As New DataTable

            da2.Fill(dt)
            Me.gridContenedores.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No existen contenedores")
        End Try

    End Sub
End Class