Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class formSeguimiento
    Public myConnectionString, unidad As String
    Private folio_solicitud_viaje As String
    Public cnn As SqlConnection

    Private Sub gridSolicitudes_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridSolicitudes.SelectionChanged
        Try
            Me.folio_solicitud_viaje = Me.gridSolicitudes.CurrentRow.Cells("folio_solicitud_viaje").Value.ToString()
            Me.getContenedoresBySolicitud(Me.folio_solicitud_viaje)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnTraslado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraslado.Click
        
        Me.insertData()
    End Sub

    Private Sub btnReexpedicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReexpedicion.Click
        Me.insertData()
    End Sub

    Private Sub btnDirecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDirecto.Click
        Me.insertData()
    End Sub

    Private Sub btnPlanta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanta.Click
        Me.insertData()
    End Sub

    Private Sub btnEntregaVacio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntregaVacio.Click
        Me.insertData()
    End Sub

    Private Sub getSolicitudes()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT folio_solicitud_viaje,referencia,pedido_cliente,id_terminal_origen,id_terminal_reexpedicion,fecha_pago_pedimento,fecha_demoras,fecha_almacenaje,tipo_viaje,destino FROM TRAFICO_LOCAL_SOLICITUD_VIAJE2"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridSolicitudes.DataSource = table
    End Sub

    Private Sub insertData()
        Cursor = Cursors.WaitCursor
        Me.insertSeguimiento()
        Me.insertTraslado()
        Me.insertReexpedicion()
        Me.insertDirecto()
        Me.insertPlanta()
        Me.insertEntrega()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub insertSeguimiento()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_GUARDA_SEGUIMIENTO_LOCAL", conn)
        command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.folio_solicitud_viaje)
        command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("contenedor").Value.ToString())

        'FECHAS DE LA PESTAÑA DE TRASLADO
        command.Parameters.AddWithValue("@FECHA_SOLICITUD_PASE_AA", Convert.ToDateTime(Me.fecha_solicitud_pase_aa.Value))
        command.Parameters.AddWithValue("@FECHA_SOLICITUD_PASE_AA_TER", Convert.ToDateTime(Me.fecha_solicitud_pase_aa_ter.Value))
        command.Parameters.AddWithValue("@FECHA_RESPUESTA_TERMINAL", Convert.ToDateTime(Me.fecha_respuesta_terminal.Value))
        command.Parameters.AddWithValue("@FECHA_ENTREGA_PASE_OPERADOR", Convert.ToDateTime(Me.fecha_entrega_pase_operador.Value))
        command.Parameters.AddWithValue("@FECHA_SALIDA_A_TERMINAL", Convert.ToDateTime(Me.fecha_salida_a_terminal.Value))
        command.Parameters.AddWithValue("@FECHA_INGRESO_TERMINAL", Convert.ToDateTime(Me.fecha_ingreso_terminal.Value))
        command.Parameters.AddWithValue("@FECHA_SALIDA_TERMINAL", Convert.ToDateTime(Me.fecha_salida_a_terminal.Value))
        command.Parameters.AddWithValue("@FECHA_INGRESO_CARGA_DAH", Convert.ToDateTime(Me.fecha_ingreso_carga_dah.Value))

        'FECHAS DE LA PESTAÑA REEXPEDICION    
        command.Parameters.AddWithValue("@FECHA_PAGO_PEDIMENTO", Convert.ToDateTime(Me.fecha_pago_pedimento.Value))
        command.Parameters.AddWithValue("@FECHA_ENTREGA_BOLETA_SALIDA", Convert.ToDateTime(Me.fecha_entrega_boleta_salida.Value))
        command.Parameters.AddWithValue("@FECHA_SALIDA_DAH_PISTOLA", Convert.ToDateTime(Me.fecha_salida_dah_pistola.Value))
        command.Parameters.AddWithValue("@FECHA_MODULO", Convert.ToDateTime(Me.fecha_modulo.Value))
        command.Parameters.AddWithValue("@FECHA_ENTRADA_PATIO_2", Convert.ToDateTime(Me.fecha_entrega_patio_2.Value))
        command.Parameters.AddWithValue("@FECHA_RECEPCION_OPERADOR", Convert.ToDateTime(Me.fecha_recepcion_operador.Value))
        command.Parameters.AddWithValue("@FECHA_FIN_DOCUMENTACION", Convert.ToDateTime(Me.fecha_fin_documentacion.Value))

        'FECHAS DE LA PESTAÑA PLANTA
        command.Parameters.AddWithValue("@FECHA_INICIO_VIAJE", Convert.ToDateTime(Me.fecha_inicio_viaje.Value))
        command.Parameters.AddWithValue("@FECHA_LLEGADA_CLIENTE", Convert.ToDateTime(Me.fecha_llegada_cliente.Value))
        command.Parameters.AddWithValue("@FECHA_SALIDA_CLIENTE", Convert.ToDateTime(Me.fecha_salida_cliente.Value))
        command.Parameters.AddWithValue("@FECHA_LLEGADA_BASE", Convert.ToDateTime(Me.fecha_llegada_base.Value))

        'FECHAS DE LA PESTAÑA ENTREGA DE VACIO
        command.Parameters.AddWithValue("@FECHA_SOL_REVISION_VACIO", Convert.ToDateTime(Me.fecha_sol_revision_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_RESPUESTA_REVISION_VACIO", Convert.ToDateTime(Me.fecha_respuesta_revision_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_SOLICITUD_PASE_AA_VACIO", Convert.ToDateTime(Me.fecha_solicitud_pase_aa_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_SOLICITUD_PASE_AA_TERMINAL_VACIO", Convert.ToDateTime(Me.fecha_solicitud_pase_aa_terminal_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_RESPUESTA_TERMINAL_VACIO", Convert.ToDateTime(Me.fecha_respuesta_terminal_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_ENTREGA_PASE_OPERADOR_VACIO", Convert.ToDateTime(Me.fecha_entrega_pase_operador_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_SALIDA_UNIDAD_TERMINAL_VACIO", Convert.ToDateTime(Me.fecha_salida_unidad_terminal_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_INGRESO_TERMINAL_VACIO", Convert.ToDateTime(Me.fecha_ingreso_terminal_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_SALIDA_TERMINAL_VACIO", Convert.ToDateTime(Me.fecha_salida_terminal_vacio.Value))
        command.Parameters.AddWithValue("@FECHA_INGRESO_BASE_VACIO", Convert.ToDateTime(Me.fecha_ingreso_base_vacio.Value))

        'FECHAS DE LA PESTAÑA DE DIRECTO
        command.Parameters.AddWithValue("@fecha_pago_pedimento_directo", Convert.ToDateTime(Me.fecha_pago_pedimento_directo.Value))
        command.Parameters.AddWithValue("@fecha_solicitud_pase_aa_directo", Convert.ToDateTime(Me.fecha_solicitud_pase_aa_directo.Value))
        command.Parameters.AddWithValue("@fecha_solicitud_pase_aa_ter_directo", Convert.ToDateTime(Me.fecha_solicitud_pase_aa_ter_directo.Value))
        command.Parameters.AddWithValue("@fecha_respuesta_terminal_directo", Convert.ToDateTime(Me.fecha_respuesta_terminal_directo.Value))
        command.Parameters.AddWithValue("@fecha_entrega_pase_operador_directo", Convert.ToDateTime(Me.fecha_entrega_pase_operador_directo.Value))
        command.Parameters.AddWithValue("@fecha_salida_a_terminal_directo", Convert.ToDateTime(Me.fecha_salida_a_terminal_directo.Value))
        command.Parameters.AddWithValue("@fecha_ingreso_terminal_directo", Convert.ToDateTime(Me.fecha_ingreso_terminal_directo.Value))
        command.Parameters.AddWithValue("@fecha_salida_terminal_directo", Convert.ToDateTime(Me.fecha_salida_terminal_directo.Value))
        command.Parameters.AddWithValue("@fecha_entrada_patio_2_directo", Convert.ToDateTime(Me.fecha_entrada_patio_2_directo.Value))
        command.Parameters.AddWithValue("@fecha_recepcion_operador_directo", Convert.ToDateTime(Me.fecha_recepcion_operador_directo.Value))
        command.Parameters.AddWithValue("@fecha_fin_documentacion_directo", Convert.ToDateTime(Me.fecha_fin_documentacion_directo.Value))


        command.CommandType = CommandType.StoredProcedure
        conn.Open()
        command.ExecuteNonQuery()
    End Sub

    Private Sub insertTraslado()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_GUARDA_OTROS_DATOS_TRASLADO", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.folio_solicitud_viaje)
        command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("contenedor").Value.ToString())
        command.Parameters.AddWithValue("@UNIDAD_TRASLADO", Me.txtTrasladoUnidad.Text)
        'command.Parameters.AddWithValue("@UNIDAD_ORIGINAL_TRASLADO", Me.txtTrasladoUnidad.Text)
        'command.Parameters.AddWithValue("@UNIDAD_NUEVO_TRASLADO", Me.txtTrasladoUnidadNuevo.Text)
        'command.Parameters.AddWithValue("@UNIDAD_NUEVO_2_TRASLADO", Me.txtTrasladoUnidadNuevo2.Text)
        command.Parameters.AddWithValue("@OPERADOR_TRASLADO", Me.txtTrasladoOperador.Text)
        command.Parameters.AddWithValue("@OPERADOR_ORIGINAL_TRASLADO", Me.txtTrasladoOperadorOriginal.Text)
        command.Parameters.AddWithValue("@OPERADOR_NUEVO_TRASLADO", Me.txtTrasladoOperadorNuevo.Text)
        ' command.Parameters.AddWithValue("@OPERADOR_NUEVO_2_TRASLADO", Me.txtTrasladoOperadorNuevo2.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_TRASLADO", Me.txtTrasladoFolioPase.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_ORIGINAL_TRASLADO", Me.txtTrasladoFolioPaseOriginal.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_NUEVO_TRASLADO", Me.txtTrasladoFolioPaseNuevo.Text)
        'command.Parameters.AddWithValue("@FOLIO_PASE_NUEVO_2_TRASLADO", Me.txtTrasladoFolioPaseNuevo2.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_TRASLADO", Me.txtTrasladoFolioBoleta.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_ORIGINAL_TRASLADO", Me.txtTrasladoFolioBoletaOriginal.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_NUEVA_TRASLADO", Me.txtTrasladoFolioBoletaNuevo.Text)
        'command.Parameters.AddWithValue("@FOLIO_BOLETA_NUEVA_2_TRASLADO", Me.txtTrasladoFolioBoletaNuevo2.Text)
        conn.Open()
        command.ExecuteNonQuery()
    End Sub

    Private Sub insertReexpedicion()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_GUARDA_OTROS_DATOS_REEXPEDICION", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.folio_solicitud_viaje)
        command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("contenedor").Value.ToString())
        command.Parameters.AddWithValue("@UNIDAD_REEXPEDICION", Me.txtReexpedicionUnidad.Text)
        command.Parameters.AddWithValue("@OPERADOR_REEXPEDICION", Me.txtReexpedicionOperador.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_REEXPEDICION", Me.txtReexpedicionFolio.Text)
        conn.Open()
        command.ExecuteNonQuery()
    End Sub

    Private Sub insertDirecto()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_GUARDA_OTROS_DATOS_DIRECTO", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.folio_solicitud_viaje)
        command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("contenedor").Value.ToString())
        command.Parameters.AddWithValue("@UNIDAD_DIRECTO", Me.txtDirectoUnidad.Text)
        command.Parameters.AddWithValue("@UNIDAD_ORIGINAL_DIRECTO", Me.txtDirectoUnidadOriginal.Text)
        command.Parameters.AddWithValue("@UNIDAD_NUEVO_DIRECTO", Me.txtDirectoUnidadNuevo.Text)
        command.Parameters.AddWithValue("@UNIDAD_NUEVO_2_DIRECTO", Me.txtDirectoUnidadNuevo2.Text)
        command.Parameters.AddWithValue("@OPERADOR_DIRECTO", Me.txtDirectoOperador.Text)
        command.Parameters.AddWithValue("@OPERADOR_ORIGINAL_DIRECTO", Me.txtDirectoOperadorOriginal.Text)
        command.Parameters.AddWithValue("@OPERADOR_NUEVO_DIRECTO", Me.txtDirectoOperadorNuevo.Text)
        command.Parameters.AddWithValue("@OPERADOR_NUEVO_2_DIRECTO", Me.txtDirectoOperadorNuevo2.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_DIRECTO", Me.txtDirectoFolioPase.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_ORIGINAL_DIRECTO", Me.txtDirectoFolioPaseOriginal.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_NUEVO_DIRECTO", Me.txtDirectoFolioPaseNuevo.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_NUEVO_2_DIRECTO", Me.txtDirectoFolioPaseNuevo2.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_DIRECTO", Me.txtDirectoFolioBoleta.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_ORIGINAL_DIRECTO", Me.txtDirectoFolioBoletaOriginal.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_NUEVA_DIRECTO", Me.txtDirectoFolioBoletaNuevo.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_NUEVA_2_DIRECTO", Me.txtDirectoFolioBoletaNuevo2.Text)
        conn.Open()
        command.ExecuteNonQuery()
    End Sub

    Private Sub insertPlanta()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_GUARDA_OTROS_DATOS_PLANTA", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.folio_solicitud_viaje)
        command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("contenedor").Value.ToString())
        command.Parameters.AddWithValue("@UNIDAD_PLANTA", Me.txtPlantaUnidad.Text)
        command.Parameters.AddWithValue("@OPERADOR_PLANTA", Me.txtPlantaOperador.Text)
        conn.Open()
        command.ExecuteNonQuery()
    End Sub

    Private Sub insertEntrega()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_GUARDA_OTROS_DATOS_VACIO", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.folio_solicitud_viaje)
        command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("contenedor").Value.ToString())
        command.Parameters.AddWithValue("@UNIDAD_LOCAL", Me.txtEntregaUnidad.Text)
        command.Parameters.AddWithValue("@LUGAR_DE_LAVADO_LOCAL", Me.txtEntregaLugarLavado.Text)
        command.Parameters.AddWithValue("@UNIDAD_ORIGINAL_LOCAL", Me.txtEntregaUnidadOriginal.Text)
        command.Parameters.AddWithValue("@UNIDAD_NUEVO_LOCAL", Me.txtEntregaUnidadNuevo.Text)
        command.Parameters.AddWithValue("@UNIDAD_NUEVO_2_LOCAL", Me.txtEntregaUnidadNuevo2.Text)
        command.Parameters.AddWithValue("@OPERADOR_LOCAL", Me.txtEntregaOperador.Text)
        command.Parameters.AddWithValue("@OPERADOR_ORIGINAL_LOCAL", Me.txtEntregaOperadorOriginal.Text)
        command.Parameters.AddWithValue("@OPERADOR_NUEVO_LOCAL", Me.txtEntregaOperadorNuevo.Text)
        command.Parameters.AddWithValue("@OPERADOR_NUEVO_2_LOCAL", Me.txtEntregaOperadorNuevo2.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_LOCAL", Me.txtEntregaFolioPase.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_ORIGINAL_LOCAL", Me.txtEntregaFolioPaseOriginal.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_NUEVO_LOCAL", Me.txtEntregaFolioPaseNuevo.Text)
        command.Parameters.AddWithValue("@FOLIO_PASE_NUEVO_2_LOCAL", Me.txtEntregaFolioPaseNuevo2.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_LOCAL", Me.txtEntregaFolioBoleta.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_ORIGINAL_LOCAL", Me.txtEntregaFolioBoletaOriginal.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_NUEVA_LOCAL", Me.txtEntregaFolioBoletaNuevo.Text)
        command.Parameters.AddWithValue("@FOLIO_BOLETA_NUEVA_2_LOCAL", Me.txtEntregaFolioBoletaNuevo2.Text)
        conn.Open()
        command.ExecuteNonQuery()
    End Sub

    Private Sub getContenedoresBySolicitud(ByVal solicitud As String)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT * FROM TRAFICO_LOCAL_CONTENEDOR WHERE ID_SOLICITUD = @ID_SOLICITUD"
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@ID_SOLICITUD", solicitud)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridContenedores.DataSource = table
    End Sub

    Private Sub formSeguimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getSolicitudes()
        myConnectionString = "Initial Catalog=QFS;Data Source=175.50.5.46;" & _
        "User ID=sa;Password=sa;"

        'Llenado de catalogos de unidades
        Me.txtTrasladoUnidad.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTrasladoUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        Me.getData(DataCollection)
        Me.txtTrasladoUnidad.AutoCompleteCustomSource = DataCollection

        'Llenado de catalogos de operadores 
        Me.txtTrasladoOperador.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTrasladoOperador.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection2 As New AutoCompleteStringCollection()
        Me.getData2(DataCollection2)
        Me.txtTrasladoOperador.AutoCompleteCustomSource = DataCollection2

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub gridContenedores_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridContenedores.SelectionChanged

        Dim sql As String = "select * from TRAFICO_LOCAL_SEGUIMIENTO2 where folio_solicitud_viaje = '" & gridSolicitudes.CurrentRow.Cells(0).Value.ToString & "'  "  '" SELECT * FROM " & _
        '" TRAFICO_LOCAL_SEGUIMIENTO TLS " & _
        '" JOIN " & _
        '" TRAFICO_LOCAL_TRASLADO_OTROSDATOS TLT " & _
        '" ON TLS.FOLIO_SOLICITUD_VIAJE = TLT.FOLIO_SOLICITUD_VIAJE " & _
        '" AND TLS.CONTENEDOR = TLT.CONTENEDOR " & _
        '" JOIN " & _
        '" TRAFICO_LOCAL_VACIO_OTROSDATOS TLV " & _
        '" ON TLS.FOLIO_SOLICITUD_VIAJE = TLV.FOLIO_SOLICITUD_VIAJE " & _
        '" AND TLS.CONTENEDOR = TLV.CONTENEDOR " & _
        '" JOIN " & _
        '" TRAFICO_LOCAL_DIRECTO_OTROSDATOS TLD " & _
        '" ON TLS.FOLIO_SOLICITUD_VIAJE = TLD.FOLIO_SOLICITUD_VIAJE " & _
        '" AND TLS.CONTENEDOR = TLD.CONTENEDOR" & _
        '" JOIN " & _
        '" TRAFICO_LOCAL_PLANTA_OTROSDATOS TLP " & _
        '" ON TLS.FOLIO_SOLICITUD_VIAJE = TLP.FOLIO_SOLICITUD_VIAJE " & _
        '" AND TLS.CONTENEDOR = TLP.CONTENEDOR " & _
        '" JOIN " & _
        '" TRAFICO_LOCAL_REEXPEDICION_OTROSDATOS TLR " & _
        '" ON TLS.FOLIO_SOLICITUD_VIAJE = TLR.FOLIO_SOLICITUD_VIAJE " & _
        '" AND TLS.CONTENEDOR = TLR.CONTENEDOR " & _
        '" WHERE " & _
        '" TLS.CONTENEDOR = @CONTENEDOR AND TLS.FOLIO_SOLICITUD_VIAJE = @FOLIO"

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(sql, conn)

        'command.Parameters.AddWithValue("@FOLIO", Me.gridSolicitudes.CurrentRow.Cells("folio_solicitud_viaje").Value.ToString())
        'command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("contenedor").Value.ToString())
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read Then

            Me.fecha_solicitud_pase_aa.Value = Convert.ToDateTime(reader("fecha_solicitud_pase_aa"))
            Me.fecha_solicitud_pase_aa_ter.Value = Convert.ToDateTime(reader("fecha_solicitud_pase_aa_ter"))
            Me.fecha_respuesta_terminal.Value = Convert.ToDateTime(reader("fecha_respuesta_terminal"))
            Me.fecha_entrega_pase_operador.Value = Convert.ToDateTime(reader("fecha_entrega_pase_operador"))
            Me.fecha_salida_a_terminal.Text = Convert.ToDateTime(reader("fecha_salida_a_terminal")) 'ttt
            Me.fecha_ingreso_terminal.Value = Convert.ToDateTime(reader("fecha_ingreso_terminal"))
            Me.fecha_salida_a_terminal.Value = Convert.ToDateTime(reader("fecha_salida_terminal"))
            Me.fecha_ingreso_carga_dah.Value = Convert.ToDateTime(reader("fecha_ingreso_carga_dah"))
            Me.fecha_pago_pedimento.Value = Convert.ToDateTime(reader("fecha_pago_pedimento"))
            Me.fecha_entrega_boleta_salida.Value = Convert.ToDateTime(reader("fecha_entrega_boleta_salida"))
            Me.fecha_salida_dah_pistola.Value = Convert.ToDateTime(reader("fecha_salida_dah_pistola"))
            Me.fecha_modulo.Value = Convert.ToDateTime(reader("fecha_modulo"))
            Me.fecha_entrega_patio_2.Value = Convert.ToDateTime(reader("fecha_entrada_patio_2"))
            Me.fecha_recepcion_operador.Value = Convert.ToDateTime(reader("fecha_recepcion_operador"))
            Me.fecha_fin_documentacion.Value = Convert.ToDateTime(reader("fecha_fin_documentacion"))
            Me.fecha_inicio_viaje.Value = Convert.ToDateTime(reader("fecha_inicio_viaje"))
            Me.fecha_llegada_cliente.Value = Convert.ToDateTime(reader("fecha_llegada_cliente"))
            Me.fecha_salida_cliente.Value = Convert.ToDateTime(reader("fecha_salida_cliente"))
            Me.fecha_llegada_base.Value = Convert.ToDateTime(reader("fecha_llegada_base"))
            Me.fecha_sol_revision_vacio.Value = Convert.ToDateTime(reader("fecha_sol_revision_vacio"))
            Me.fecha_respuesta_revision_vacio.Value = Convert.ToDateTime(reader("fecha_respuesta_revision_vacio"))
            Me.fecha_solicitud_pase_aa_vacio.Value = Convert.ToDateTime(reader("fecha_solicitud_pase_aa_vacio"))
            Me.fecha_solicitud_pase_aa_terminal_vacio.Value = Convert.ToDateTime(reader("fecha_solicitud_pase_aa_terminal_vacio"))
            Me.fecha_respuesta_terminal_vacio.Value = Convert.ToDateTime(reader("fecha_respuesta_terminal_vacio"))
            Me.fecha_entrega_pase_operador_vacio.Value = Convert.ToDateTime(reader("fecha_entrega_pase_operador_vacio"))
            Me.fecha_salida_unidad_terminal_vacio.Value = Convert.ToDateTime(reader("fecha_salida_unidad_terminal_vacio"))
            Me.fecha_ingreso_terminal_vacio.Value = Convert.ToDateTime(reader("fecha_ingreso_terminal_vacio"))
            Me.fecha_salida_terminal_vacio.Value = Convert.ToDateTime(reader("fecha_salida_terminal_vacio"))
            'Me.fecha_ingreso_base_vacio.Value = Convert.ToDateTime(reader("fecha_ingreso_base_vacio"))

            Me.txtTrasladoUnidad.Text = reader("unidad").ToString()
            'Me.txtTrasladoUnidadOriginal.Text = reader("unidad_original_traslado").ToString()
            'Me.txtTrasladoUnidadNuevo.Text = reader("unidad_nuevo_traslado").ToString()
            'Me.txtTrasladoUnidadNuevo2.Text = reader("unidad_nuevo_2_traslado").ToString()
            'Me.txtTrasladoOperador.Text = reader("operador_traslado").ToString()
            'Me.txtTrasladoOperadorOriginal.Text = reader("operador_original_traslado").ToString()
            'Me.txtTrasladoOperadorNuevo.Text = reader("operador_nuevo_traslado").ToString()
            'Me.txtTrasladoOperadorNuevo2.Text = reader("operador_nuevo_2_traslado").ToString()
            'Me.txtTrasladoFolioPase.Text = reader("folio_pase_traslado").ToString()
            'Me.txtTrasladoFolioPaseOriginal.Text = reader("folio_pase_original_traslado").ToString()
            'Me.txtTrasladoFolioPaseNuevo.Text = reader("folio_pase_nuevo_traslado").ToString()
            'Me.txtTrasladoFolioPaseNuevo2.Text = reader("folio_pase_nuevo_2_traslado").ToString()
            'Me.txtTrasladoFolioBoleta.Text = reader("folio_boleta_traslado").ToString()
            'Me.txtTrasladoFolioBoletaOriginal.Text = reader("folio_boleta_original_traslado").ToString()
            'Me.txtTrasladoFolioBoletaNuevo.Text = reader("folio_boleta_nueva_traslado").ToString()
            'Me.txtTrasladoFolioBoletaNuevo2.Text = reader("folio_boleta_nueva_2_traslado").ToString()

            'Me.txtReexpedicionUnidad.Text = reader("unidad_reexpedicion").ToString()
            'Me.txtReexpedicionOperador.Text = reader("operador_reexpedicion").ToString()
            'Me.txtReexpedicionFolio.Text = reader("folio_boleta_reexpedicion").ToString()

            'Me.txtDirectoUnidad.Text = reader("unidad_directo").ToString()
            'Me.txtDirectoUnidadOriginal.Text = reader("unidad_original_directo").ToString()
            'Me.txtDirectoUnidadNuevo.Text = reader("unidad_nuevo_directo").ToString()
            'Me.txtDirectoUnidadNuevo2.Text = reader("unidad_nuevo_2_directo").ToString()
            'Me.txtDirectoOperador.Text = reader("operador_directo").ToString()
            'Me.txtDirectoOperadorOriginal.Text = reader("operador_original_directo").ToString()
            'Me.txtDirectoOperadorNuevo.Text = reader("operador_nuevo_directo").ToString()
            'Me.txtDirectoOperadorNuevo2.Text = reader("operador_nuevo_2_directo").ToString()
            'Me.txtDirectoFolioPase.Text = reader("folio_pase_directo").ToString()
            'Me.txtDirectoFolioPaseOriginal.Text = reader("folio_pase_original_directo").ToString()
            'Me.txtDirectoFolioPaseNuevo.Text = reader("folio_pase_nuevo_directo").ToString()
            'Me.txtDirectoFolioPaseNuevo2.Text = reader("folio_pase_nuevo_2_directo").ToString()
            'Me.txtDirectoFolioBoleta.Text = reader("folio_boleta_directo").ToString()
            'Me.txtDirectoFolioBoletaOriginal.Text = reader("folio_boleta_original_directo").ToString()
            'Me.txtDirectoFolioBoletaNuevo.Text = reader("folio_boleta_nueva_directo").ToString()
            'Me.txtDirectoFolioBoletaNuevo2.Text = reader("folio_boleta_nueva_2_directo").ToString()
            'Me.txtPlantaUnidad.Text = reader("unidad_planta").ToString()
            'Me.txtPlantaOperador.Text = reader("operador_planta").ToString()

            'Me.txtEntregaUnidad.Text = reader("unidad_local").ToString()
            'Me.txtEntregaLugarLavado.Text = reader("lugar_de_lavado_local").ToString()
            'Me.txtEntregaUnidadOriginal.Text = reader("unidad_original_local").ToString()
            'Me.txtEntregaUnidadNuevo.Text = reader("unidad_nuevo_local").ToString()
            'Me.txtEntregaUnidadNuevo2.Text = reader("unidad_nuevo_2_local").ToString()
            'Me.txtEntregaOperador.Text = reader("operador_local").ToString()
            'Me.txtEntregaOperadorOriginal.Text = reader("operador_original_local").ToString()
            'Me.txtEntregaOperadorNuevo.Text = reader("operador_nuevo_local").ToString()
            'Me.txtEntregaOperadorNuevo2.Text = reader("operador_nuevo_2_local").ToString()
            'Me.txtEntregaFolioPase.Text = reader("folio_pase_local").ToString()
            'Me.txtEntregaFolioPaseOriginal.Text = reader("folio_pase_original_local").ToString()
            'Me.txtEntregaFolioPaseNuevo.Text = reader("folio_pase_nuevo_local").ToString()
            'Me.txtEntregaFolioPaseNuevo2.Text = reader("folio_pase_nuevo_2_local").ToString()
            'Me.txtEntregaFolioBoleta.Text = reader("folio_boleta_local").ToString()
            'Me.txtEntregaFolioBoletaOriginal.Text = reader("folio_boleta_original_local").ToString()
            'Me.txtEntregaFolioBoletaNuevo.Text = reader("folio_boleta_nueva_local").ToString()
            'Me.txtEntregaFolioBoletaNuevo2.Text = reader("folio_boleta_nueva_2_local").ToString()
        End If
    End Sub

    'EVENTOS DE LOS CHECK LIST
    Private Sub Ch_fecha_solicitud_pase_aa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_solicitud_pase_aa.CheckedChanged

        fecha_solicitud_pase_aa.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_solicitud_pase_aa_ter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_solicitud_pase_aa_ter.CheckedChanged

        fecha_solicitud_pase_aa_ter.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_respuesta_terminal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_respuesta_terminal.CheckedChanged

        fecha_respuesta_terminal.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_entrega_pase_operador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_entrega_pase_operador.CheckedChanged

        fecha_entrega_pase_operador.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_salida_a_terminal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_salida_a_terminal.CheckedChanged

        cnn.ConnectionString = myConnectionString
        Dim reg As SqlDataReader
        Dim sql2 As String = "SELECT select TOP(1) FECHA from trafico_registros where unidad = '" & txtTrasladoUnidad.Text & "' and fecha = '" & fecha_entrega_pase_operador.Value.Date & "' and tipo = 'S'"
        Dim command As SqlCommand = New SqlCommand(sql2, cnn)
        command.CommandType = CommandType.Text
        cnn.Open()
        command.CommandTimeout = 600
        reg = command.ExecuteReader
        reg.Read()

        If reg.HasRows Then

            fecha_salida_a_terminal.Text = reg.GetValue(0)

        End If
    End Sub

    Private Sub Ch_fecha_ingreso_terminal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_ingreso_terminal.CheckedChanged

    End Sub

    Private Sub Ch_fecha_salida_terminal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_salida_terminal.CheckedChanged

    End Sub

    Private Sub Ch_fecha_ingreso_carga_dah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_ingreso_carga_dah.CheckedChanged

    End Sub

    Private Sub Ch_fecha_pago_pedimento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_pago_pedimento.CheckedChanged

        fecha_pago_pedimento.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_entrega_boleta_salida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_entrega_boleta_salida.CheckedChanged

        fecha_entrega_boleta_salida.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_salida_dah_pistola_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_salida_dah_pistola.CheckedChanged

        fecha_salida_dah_pistola.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_modulo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_modulo.CheckedChanged

        fecha_modulo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_entrega_patio_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_entrega_patio_2.CheckedChanged

        fecha_entrega_patio_2.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_recepcion_operador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_recepcion_operador.CheckedChanged

        fecha_recepcion_operador.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_fin_documentacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_fin_documentacion.CheckedChanged

        fecha_fin_documentacion.Text = DateTime.Now()

    End Sub


    Private Sub Ch_fecha_pago_pedimento_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_pago_pedimento_directo.CheckedChanged

        fecha_pago_pedimento_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_solicitud_pase_aa_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_solicitud_pase_aa_directo.CheckedChanged

        fecha_solicitud_pase_aa_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_solicitud_pase_aa_ter_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_solicitud_pase_aa_ter_directo.CheckedChanged

        fecha_solicitud_pase_aa_ter_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_respuesta_terminal_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_respuesta_terminal_directo.CheckedChanged

        fecha_respuesta_terminal_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_entrega_pase_operador_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_entrega_pase_operador_directo.CheckedChanged

        fecha_entrega_pase_operador_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_salida_a_terminal_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_salida_a_terminal_directo.CheckedChanged

        fecha_salida_a_terminal_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_ingreso_terminal_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_ingreso_terminal_directo.CheckedChanged

        fecha_ingreso_terminal_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_salida_terminal_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_salida_terminal_directo.CheckedChanged

        fecha_salida_terminal_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_entrada_patio_2_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_entrada_patio_2_directo.CheckedChanged

        fecha_entrada_patio_2_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_recepcion_operador_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_recepcion_operador_directo.CheckedChanged

        fecha_recepcion_operador_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_fin_documentacion_directo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_fin_documentacion_directo.CheckedChanged

        fecha_fin_documentacion_directo.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_inicio_viaje_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_inicio_viaje.CheckedChanged

        fecha_inicio_viaje.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_llegada_cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_llegada_cliente.CheckedChanged

        fecha_llegada_cliente.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_salida_cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_salida_cliente.CheckedChanged

        fecha_salida_cliente.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_llegada_base_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_llegada_base.CheckedChanged

        fecha_llegada_base.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_sol_revision_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_sol_revision_vacio.CheckedChanged

        fecha_sol_revision_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_respuesta_revision_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_respuesta_revision_vacio.CheckedChanged

        fecha_respuesta_revision_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_solicitud_pase_aa_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_solicitud_pase_aa_vacio.CheckedChanged

        fecha_solicitud_pase_aa_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_solicitud_pase_aa_terminal_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_solicitud_pase_aa_terminal_vacio.CheckedChanged

        fecha_solicitud_pase_aa_terminal_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_respuesta_terminal_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_respuesta_terminal_vacio.CheckedChanged

        fecha_respuesta_terminal_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_entrega_pase_operador_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_entrega_pase_operador_vacio.CheckedChanged

        fecha_entrega_pase_operador_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_salida_unidad_terminal_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_salida_unidad_terminal_vacio.CheckedChanged

        fecha_salida_unidad_terminal_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_salida_terminal_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_salida_terminal_vacio.CheckedChanged

        fecha_salida_terminal_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_ingreso_terminal_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_ingreso_terminal_vacio.CheckedChanged

        fecha_ingreso_terminal_vacio.Text = DateTime.Now()

    End Sub

    Private Sub Ch_fecha_ingreso_base_vacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch_fecha_ingreso_base_vacio.CheckedChanged

        fecha_ingreso_base_vacio.Text = DateTime.Now()

    End Sub

    Private Sub getData(ByVal dataCollection As AutoCompleteStringCollection) 'AUTO COMPLETADO PARA UNIDADES

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = "select id_unidad from mtto_unidades where id_unidad like 't%' union all select  id_unidad from mtto_unidades  where id_unidad like 'p%'"

        Try

            conn.Open()
            command = New SqlCommand(Sql, conn)
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
    Private Sub getData2(ByVal dataCollection As AutoCompleteStringCollection) 'AUTO COMPLETADO PARA UNIDADES

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql2 As String = "SELECT nombre FROM PERSONAL_PERSONAL WHERE ID_CATEGORIA = 3"

        Try

            conn.Open()
            command = New SqlCommand(sql2, conn)
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
    Public Sub insertSeguimientoTraslado()

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_GUARDA_SEGUIMIENTO_LOCAL", conn)
        command.Parameters.AddWithValue("@FOLIO_SOLICITUD_VIAJE", Me.folio_solicitud_viaje)
        command.Parameters.AddWithValue("@CONTENEDOR", Me.gridContenedores.CurrentRow.Cells("contenedor").Value.ToString())
        command.Parameters.AddWithValue("@FECHA_SOLICITUD_PASE_AA", Convert.ToDateTime(Me.fecha_solicitud_pase_aa.Value))
        command.Parameters.AddWithValue("@FECHA_SOLICITUD_PASE_AA_TER", Convert.ToDateTime(Me.fecha_solicitud_pase_aa_ter.Value))
        command.Parameters.AddWithValue("@FECHA_RESPUESTA_TERMINAL", Convert.ToDateTime(Me.fecha_respuesta_terminal.Value))
        command.Parameters.AddWithValue("@FECHA_ENTREGA_PASE_OPERADOR", Convert.ToDateTime(Me.fecha_entrega_pase_operador.Value))
        command.Parameters.AddWithValue("@UNIDAD", txtTrasladoUnidad.Text)

    End Sub

    Private Sub bto_accion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_accion.Click

        Cursor = Cursors.WaitCursor

        If (txtTrasladoUnidad.Equals("")) Then

            MessageBox.Show("Falta Unidad")

        Else

            Me.insertSeguimientoTraslado()
            Me.insertTraslado()
            MessageBox.Show("Solicitud Puesta en Accion Automatica")

        End If

        Cursor = Cursors.Arrow

    End Sub
End Class