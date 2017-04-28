Imports System.Xml
Imports System.IO
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Math
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports System.DateTime
Imports System.Globalization
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Outlook
Imports System.IO.File

Public Class frmDatosViaje

    'Dim objeto As New Email
    'Dim objeto2 As New Email
    Public arra As New ArrayList
    Public cp As New ArrayList
    Public operadores As New ArrayList
    Dim IdPersonal As Integer
    Public origen, destino, motor, unidadc As String
    Public IdRuta, IdCombustible As Integer
    Private tipotracto, id_cliente, id_destino, id_origen As Integer
    Public Bit_Camioneta, Bit_Nuevo As Boolean
    Private fecguia As Date
    Private TipoFecha, ViajeReparto As Integer
    Private IdComb As Integer
    Private MaxLitrosDif As Decimal
    Public Area As Integer
    Dim m_Excel As Microsoft.Office.Interop.Excel.Application
    Dim TipoViaje As Integer
    Private fechaReset As String
    Public id_personal As Integer
    Private listaCartasPorte As New List(Of CartaPorte)
    Public cruzoTodas As Boolean

#Region "Constructor"
    Private Sub frmDatosViaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        Me.gbDias.Enabled = False
        Me.gbRemolques.Enabled = False
        Me.gbCartasPorte.Enabled = False
        Me.btnCasetas.Enabled = False
        Me.btnGastos.Enabled = False
        Me.gbReset.Enabled = False
        Me.gbContenedores.Enabled = False
        Me.gbMovimientos.Visible = False
        Bit_Camioneta = False
        TipoFecha = 0
        ViajeReparto = 0
        Bit_Nuevo = True
        IdComb = 0
        Me.Button1.Enabled = True
        MaxLitrosDif = 50
        Me.Area = 1
        Me.cmbArea.SelectedItem = "Altamira"
        Me.TxtFecIni.Text = DateTime.Now.AddDays(-2.0).ToString()
        Me.TxtFecFin.Text = DateTime.Now.ToString()
        Me.getConfiguracionViaje()
        Me.cruzoTodas = True
        Cursor.Current = Cursors.Arrow

    End Sub
#End Region
#Region "TxtNoViaje_Leave | Carga Datos"

    Private Sub TxtNoViaje_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNoViaje.Leave

        Cursor.Current = Cursors.WaitCursor

        If TxtNoViaje.Text = "" Then

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Debe capturar el numero de viaje.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.TxtNoViaje.Focus()

        Else

            Dim oDa As SqlClient.SqlDataAdapter
            Dim oDs As System.Data.DataSet
            Dim index As Integer
            Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
            Dim oCommand As SqlClient.SqlCommand = _
                New SqlClient.SqlCommand("UP_Consulta_DatosViaje", oConexion)
            Dim oParameter As SqlClient.SqlParameter

            Try

                oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
                oParameter.Value = CInt(TxtNoViaje.Text)
                oParameter = oCommand.Parameters.Add("@Area", SqlDbType.Int)
                oParameter.Value = Me.Area
                oCommand.CommandType = CommandType.StoredProcedure
                oConexion.Open()
                oDa = New SqlClient.SqlDataAdapter(oCommand)
                oDs = New System.Data.DataSet()
                oDa.Fill(oDs)

                oConexion.Close()

                If oDs.Tables(0).Rows.Count = 0 Then

                    MessageBox.Show("No se encontro información para el viaje capturado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
                    Me.TxtNoViaje.Focus()

                    Exit Sub
                End If

                Me.TxtUnidad.Text = oDs.Tables(0).Rows(0).Item("id_unidad").ToString()
                unidadc = oDs.Tables(0).Rows(0).Item("id_unidadC").ToString()
                IdRuta = CInt(oDs.Tables(0).Rows(0).Item("id_ruta"))
                origen = oDs.Tables(0).Rows(0).Item("Origen").ToString()
                destino = oDs.Tables(0).Rows(0).Item("Destino").ToString()
                id_personal = CInt(oDs.Tables(0).Rows(0).Item("id_personal"))
                id_cliente = CInt(oDs.Tables(0).Rows(0).Item("id_cliente"))
                id_destino = CInt(oDs.Tables(0).Rows(0).Item("id_destino"))
                id_origen = CInt(oDs.Tables(0).Rows(0).Item("id_origen"))
                fecguia = Convert.ToDateTime(oDs.Tables(0).Rows(0).Item("fecha_guia").ToString())
                Me.TxtSemana.Text = oDs.Tables(0).Rows(0).Item("semana").ToString()
                Me.TxtOperador.Text = oDs.Tables(0).Rows(0).Item("Operador").ToString()
                Me.TxtLitrosLis.Text = oDs.Tables(0).Rows(0).Item("litros").ToString()

                If Me.TxtLitrosLis.Text = "" Then

                    Me.TxtLitrosLis.Enabled = True

                Else

                    If CInt(Me.TxtLitrosLis.Text) = 0 Then

                        Me.TxtLitrosLis.Enabled = True

                    End If
                End If

                'En esta parte se debe de traer lo que hay en la tabla y mostrarlo en el combobox
                '*************************************************************************
                If oDs.Tables(0).Rows(0).Item("ConfigViaje").ToString() <> "" Then

                    'DTconfigviaje = Convert.ToString(objReaderconfigviaje.GetValue(0))
                    Me.cmbConfViaje.SelectedIndex = CInt(oDs.Tables(0).Rows(0).Item("ConfigViaje").ToString())

                End If
                '**********************************************************

                Me.TxtTotDias.Text = oDs.Tables(0).Rows(0).Item("CantDias").ToString()

                If IsDBNull(oDs.Tables(0).Rows(0).Item("fec_ini")) Then

                    Me.TxtFecIni.Enabled = True

                Else

                    Me.TxtFecIni.Text = oDs.Tables(0).Rows(0).Item("fec_ini").ToString()
                    Me.TxtFecIni.Enabled = True

                End If

                If IsDBNull(oDs.Tables(0).Rows(0).Item("fec_fin")) Then

                    Me.TxtFecFin.Enabled = True

                Else

                    Me.TxtFecFin.Text = oDs.Tables(0).Rows(0).Item("fec_fin").ToString()
                    Me.TxtFecFin.Enabled = True
                    Me.TxtTotDias.Text = oDs.Tables(0).Rows(0).Item("CantDias").ToString()

                End If

                If IsDBNull(oDs.Tables(0).Rows(0).Item("km_inicial")) Then

                    Me.TxtKmInicial.Enabled = True
                    Me.TxtKmInicial.TabIndex = 3
                    Me.TxtKmInicial.Focus()

                Else

                    Me.TxtKmInicial.Text = oDs.Tables(0).Rows(0).Item("km_inicial").ToString()

                End If

                If Convert.ToBoolean(oDs.Tables(0).Rows(0).Item("Bit_local").ToString()) = True Then

                    Me.cmbTipoViaje.SelectedItem = "Local"
                    Me.TxtKmFinal.Text = "0"

                    If Me.grdUnidades.Rows.Count = 0 Then
                        If oDs.Tables(2).Rows.Count = 0 Then

                            MessageBox.Show("No existen registros de Vales de Combustible", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
                            Limpiar()

                            Exit Sub
                        Else

                            For i As Integer = 0 To oDs.Tables(2).Rows.Count - 1

                                index = Me.grdUnidades.Rows.Add()
                                Me.grdUnidades.Rows(index).Cells("Id_Combustible").Value = CInt(oDs.Tables(2).Rows(i).Item("Id_Combustible"))
                                Me.grdUnidades.Rows(index).Cells("Id_Vale").Value = CInt(oDs.Tables(2).Rows(i).Item("Id_Vale"))
                                Me.grdUnidades.Rows(index).Cells("Unidad").Value = oDs.Tables(2).Rows(i).Item("Unidad").ToString()
                                Me.grdUnidades.Rows(index).Cells("id_unidadC").Value = oDs.Tables(2).Rows(i).Item("UnidadC").ToString()
                                Me.grdUnidades.Rows(index).Cells("litros").Value = oDs.Tables(2).Rows(i).Item("litros").ToString()

                            Next
                        End If
                    End If

                    Me.TxtLitrosLis.Text = oDs.Tables(0).Rows(0).Item("litros").ToString()
                    Me.gbDias.Visible = False
                    Me.gbEquipos.Visible = True

                Else

                    Me.cmbTipoViaje.SelectedItem = "Foraneo"
                    Me.gbDias.Visible = True
                    Me.gbDias.Enabled = True
                    Me.gbEquipos.Visible = False

                    If CInt(oDs.Tables(0).Rows(0).Item("id_combustible")) <> 0 Then

                        IdComb = CInt(oDs.Tables(0).Rows(0).Item("id_combustible"))

                    Else
                        For i As Integer = 0 To oDs.Tables(2).Rows.Count - 1
                            If CDbl(oDs.Tables(2).Rows(i).Item("litros")) > 0 Then

                                IdComb = CInt(oDs.Tables(2).Rows(i).Item("Id_Combustible"))

                            End If
                        Next
                    End If

                    If IsDBNull(oDs.Tables(0).Rows(0).Item("Km_Final")) = False Then

                        'IdComb = CInt(oDs.Tables(0).Rows(0).Item("id_combustible"))
                        Me.TxtKmFinal.Text = oDs.Tables(0).Rows(0).Item("Km_Final").ToString()
                        Me.TxtObservaciones.Text = oDs.Tables(0).Rows(0).Item("Observaciones").ToString()
                        Me.TxtComplemento.Text = oDs.Tables(0).Rows(0).Item("Complemento").ToString()
                        Me.TxtManiobras.Text = oDs.Tables(0).Rows(0).Item("Maniobras").ToString()
                        Me.gbCartasPorte.Enabled = False
                        Me.gbContenedores.Enabled = False
                        Me.TxtKmViaje.Text = Convert.ToString(CDbl(Me.TxtKmFinal.Text) - CDbl(Me.TxtKmInicial.Text))
                        Me.cmbTipoViaje_Leave(sender, e)
                        Bit_Nuevo = False
                        Me.Button1.Enabled = True

                    End If
                End If

                'C A R T A S   P O R T E
                '#######################################################################################
                Me.grdCartasPorte.DataSource = Nothing

                If oDs.Tables(1).Rows.Count > 0 Then

                    Me.grdCartasPorte.DataSource = oDs.Tables(1)

                End If
                '#######################################################################################

                Me.grdContenedores.Rows.Clear()

                If oDs.Tables(3).Rows.Count > 0 Then
                    For i As Integer = 0 To oDs.Tables(3).Rows.Count - 1

                        index = Me.grdContenedores.Rows.Add()
                        Me.grdContenedores.Rows(index).Cells("Contenedor").Value = oDs.Tables(3).Rows(i).Item("Contenedor").ToString()
                        Me.grdContenedores.Rows(index).Cells("TipoCont").Value = oDs.Tables(3).Rows(i).Item("Tipo").ToString()

                    Next
                End If

                Me.grdRemolques.Rows.Clear()

                If oDs.Tables(4).Rows.Count > 0 Then
                    For i As Integer = 0 To oDs.Tables(4).Rows.Count - 1

                        index = Me.grdRemolques.Rows.Add()
                        Me.grdRemolques.Rows(index).Cells("Remolque").Value = oDs.Tables(4).Rows(i).Item("Remolque").ToString()
                        Me.grdRemolques.Rows(index).Cells("TipoRem").Value = oDs.Tables(4).Rows(i).Item("Tipo").ToString()

                    Next
                End If

            Catch ex As System.Exception

                Cursor.Current = Cursors.Arrow
                MessageBox.Show("hola  " & ex.Message.ToString)
                Exit Sub

            End Try

        End If

        Me.getOperadores()
        Cursor.Current = Cursors.Arrow

    End Sub
#End Region
#Region "cmbTipoViaje_Leave | btnCargar_Click"
    Private Sub cmbTipoViaje_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoViaje.Leave

        If Not Me.cmbTipoViaje.SelectedItem = "Almacen" Then
            If Me.cmbTipoViaje.SelectedItem = "" Then

                MessageBox.Show("Debe seleccionar el tipo de viaje", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
                Me.cmbTipoViaje.Focus()

            Else

                If Me.cmbTipoViaje.SelectedItem = "Foraneo" Then

                    Me.gbDias.Enabled = True
                    Me.gbDias.Visible = True
                    Me.gbRemolques.Enabled = True
                    Me.gbCartasPorte.Enabled = True
                    Me.btnCasetas.Enabled = True
                    Me.btnGastos.Enabled = True
                    Me.gbReset.Enabled = True
                    Me.gbContenedores.Enabled = True
                    Me.gbEquipos.Enabled = False
                    Me.gbEquipos.Visible = False
                    btnCargar_Click(sender, e)

                Else

                    Me.gbDias.Enabled = False
                    Me.gbDias.Visible = False
                    Me.gbRemolques.Enabled = False
                    Me.gbCartasPorte.Enabled = False
                    Me.btnCasetas.Enabled = False
                    Me.btnGastos.Enabled = False
                    Me.gbReset.Enabled = False
                    Me.gbContenedores.Enabled = False
                    Me.gbEquipos.Enabled = True
                    Me.gbEquipos.Visible = True
                    btnCargar_Click(sender, e)

                End If
            End If
        End If
    End Sub
#End Region
#Region "Gastos & Casetas"
    Private Sub btnGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGastos.Click

        frmGastosViaje.ShowDialog()

    End Sub

    Private Sub btnCasetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCasetas.Click

        frmCasetasViaje.ShowDialog()

    End Sub
#End Region

#Region "Guardado General"

#Region "Botón Guardar"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor = Cursors.WaitCursor
        Dim ki, kf As Integer
        ki = TxtKmInicial.Text
        kf = TxtKmFinal.Text

        If ki > kf Then

            MessageBox.Show("Kilometraje Inicial Mayor a Final")

        Else

            Me.ObtenerIdPersonal()
            Me.ObtenerTodasLasCp()
            Me.CompararIdPersonales()
            'Me.ArmarCorreo2()
            Me.enviarCorreo2()
            Me.guardaDatosViaje(sender, e)
            arra.Clear()

        End If

        Cursor = Cursors.Arrow

    End Sub
#End Region

#Region "Guarda Datos Viaje"
    Private Sub guardaDatosViaje(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not Me.checkLitros.Checked Then 'el mismo reset para todos los vales

            Dim oDa As SqlClient.SqlDataAdapter
            Dim oDs As System.Data.DataSet

            If Not CInt(Me.cmbConfViaje.SelectedIndex) = 0 Then 'Checas si la opcion de configuración de viaje es != 0
                If Not String.IsNullOrEmpty(Me.TxtLitrosLis.Text.Trim()) Then
                    If Convert.ToDouble(Me.TxtLitrosLis.Text.Trim()) > 0.0 Then
                        If Valida() Then

                            Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
                            Dim oCommand As SqlClient.SqlCommand = _
                                New SqlClient.SqlCommand("UP_Guarda_DatosViaje", oConexion)
                            Dim oParameter As SqlClient.SqlParameter

                            oCommand.CommandType = CommandType.StoredProcedure
                            oConexion.Open()

                            Try

                                oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
                                oParameter.Value = CInt(Me.TxtNoViaje.Text)
                                oParameter = oCommand.Parameters.Add("@TipoViaje", SqlDbType.TinyInt)
                                oParameter.Value = Me.TipoViaje
                                '********************Se anade esta linea para el guardo de Config Viaje
                                oParameter = oCommand.Parameters.Add("@ConfigViaje", SqlDbType.Int)
                                oParameter.Value = CInt(Me.cmbConfViaje.SelectedIndex)
                                '*************************************************************
                                oParameter = oCommand.Parameters.Add("@Unidad", SqlDbType.VarChar)
                                oParameter.Value = Me.TxtUnidad.Text
                                oParameter = oCommand.Parameters.Add("@Semana", SqlDbType.Int)
                                oParameter.Value = CInt(Me.TxtSemana.Text)

                                If Me.TipoViaje = 2 Then

                                    oParameter = oCommand.Parameters.Add("@FecIni_Viaje", SqlDbType.DateTime)
                                    oParameter.Value = DBNull.Value
                                    oParameter = oCommand.Parameters.Add("@FecFin_Viaje", SqlDbType.DateTime)
                                    oParameter.Value = DBNull.Value

                                Else

                                    oParameter = oCommand.Parameters.Add("@FecIni_Viaje", SqlDbType.DateTime)
                                    oParameter.Value = Convert.ToDateTime(Me.TxtFecIni.Text)
                                    oParameter = oCommand.Parameters.Add("@FecFin_Viaje", SqlDbType.DateTime)
                                    oParameter.Value = Convert.ToDateTime(Me.TxtFecFin.Text)

                                End If

                                oParameter = oCommand.Parameters.Add("@Km_Inicial", SqlDbType.Decimal)
                                oParameter.Value = CDbl(Me.TxtKmInicial.Text)
                                oParameter = oCommand.Parameters.Add("@Km_Final", SqlDbType.Decimal)
                                oParameter.Value = CDbl(Me.TxtKmFinal.Text)
                                oParameter = oCommand.Parameters.Add("@LitrosDiesel", SqlDbType.Decimal)
                                oParameter.Value = CDbl(IIf(Me.TxtLitrosLis.Text = "", 0, Me.TxtLitrosLis.Text))
                                oParameter = oCommand.Parameters.Add("@Complemento", SqlDbType.Decimal)
                                oParameter.Value = CDbl(Me.TxtComplemento.Text)
                                oParameter = oCommand.Parameters.Add("@Id_Personal", SqlDbType.Int)
                                oParameter.Value = id_personal
                                oParameter = oCommand.Parameters.Add("@Id_Cliente", SqlDbType.Int)
                                oParameter.Value = id_cliente
                                oParameter = oCommand.Parameters.Add("@Id_Origen", SqlDbType.Int)
                                oParameter.Value = id_origen
                                oParameter = oCommand.Parameters.Add("@Id_Destino", SqlDbType.Int)
                                oParameter.Value = id_destino

                                If Bit_Camioneta = False Then

                                    oParameter = oCommand.Parameters.Add("@Motor", SqlDbType.VarChar)

                                    If motor = Nothing Then

                                        oParameter.Value = DBNull.Value

                                    Else

                                        oParameter.Value = motor

                                    End If
                                Else

                                    oParameter = oCommand.Parameters.Add("@Motor", SqlDbType.VarChar)
                                    oParameter.Value = DBNull.Value

                                End If

                                oParameter = oCommand.Parameters.Add("@Observaciones", SqlDbType.Text)
                                oParameter.Value = Me.TxtObservaciones.Text
                                oParameter = oCommand.Parameters.Add("@Bit_Urgente", SqlDbType.Bit)
                                oParameter.Value = Convert.ToBoolean(Me.ckbUrgente.Checked)
                                oParameter = oCommand.Parameters.Add("@Maniobras", SqlDbType.Money)
                                oParameter.Value = Convert.ToDecimal(Me.TxtManiobras.Text)
                                '#################### VALE DE COMBUSTIBLE ########################
                                '#################################################################
                                '#################################################################
                                oParameter = oCommand.Parameters.Add("@IdComb", SqlDbType.Int)
                                oParameter.Value = IdComb
                                '#################################################################
                                '#################################################################
                                oParameter = oCommand.Parameters.Add("@Movimientos", SqlDbType.Int)
                                oParameter.Value = Convert.ToInt32(Me.txtMovimientos.Text.Trim())
                                oParameter = oCommand.Parameters.Add("@Area", SqlDbType.Int)
                                oParameter.Value = Me.Area
                                oParameter = oCommand.Parameters.Add("@CRUZO_TODAS", SqlDbType.Bit)
                                oParameter.Value = Me.cruzoTodas
                                oDa = New SqlClient.SqlDataAdapter(oCommand)
                                oDs = New System.Data.DataSet()
                                oDa.Fill(oDs)
                                oParameter.ResetSqlDbType()
                                'GUARDA CARTAS PORTE
                                Me.enlazaCartasPorteAlViaje()

                                If Me.grdResetCAT.Rows.Count > 0 Or Me.grdReset.Rows.Count > 0 Then
                                    If tipotracto = 1 Then
                                        For i As Integer = 0 To Me.grdResetCAT.RowCount - 1

                                            GuardaReset(Me.grdResetCAT.Rows(i).Cells(0).Value.ToString().Replace(",", "."), Me.grdResetCAT.Rows(i).Cells(1).Value.ToString().Replace(",", "."), IdComb)

                                        Next
                                    Else

                                        If Me.grdReset.Rows.Count > 0 Then
                                            For i As Integer = 0 To Me.grdReset.RowCount - 1

                                                GuardaReset(Me.grdReset.Rows(i).Cells(0).Value.ToString().Replace(",", "."), Me.grdReset.Rows(i).Cells(1).Value.ToString().Replace(",", "."), IdComb)

                                            Next
                                        End If
                                    End If
                                End If

                                If Me.grdContenedores.Rows.Count > 0 Then
                                    For i As Integer = 0 To Me.grdContenedores.Rows.Count - 1
                                        If Me.grdContenedores.Rows(i).Cells(0).Value.ToString() <> "" Then

                                            GuardaContenedores(Me.grdContenedores.Rows(i).Cells(0).Value.ToString(), Me.grdContenedores.Rows(i).Cells(1).Value.ToString())

                                        End If
                                    Next
                                End If

                                If Me.grdRemolques.Rows.Count > 0 Then
                                    For i As Integer = 0 To Me.grdRemolques.Rows.Count - 1
                                        If Me.grdRemolques.Rows(i).Cells(0).Value.ToString() <> "" Then

                                            GuardaRemolques(Me.grdRemolques.Rows(i).Cells(0).Value.ToString(), Me.grdRemolques.Rows(i).Cells(1).Value.ToString())

                                        End If
                                    Next
                                End If

                                'Si es foráneo
                                If TipoViaje = 1 Then

                                    ValidaLitros()
                                    'Valida si es local     se acaba de añadir este codigo

                                ElseIf TipoViaje = 2 Then

                                    ValidaLitros()

                                Else

                                    'Si existe reseteo
                                    If Me.grdReset.Rows.Count > 1 OrElse Me.grdResetCAT.Rows.Count > 1 Then

                                    End If
                                End If

                                MessageBox.Show("Datos guardados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)

                                If Bit_Nuevo = False Then

                                    Me.Button1_Click(sender, e)

                                End If

                                If TipoViaje = 1 Then

                                    Limpiar()
                                    Me.TxtNoViaje.Focus()

                                Else

                                    If Me.grdUnidades.Rows.Count > 1 Then

                                        Limpiar()
                                        Me.cmbArea.Focus()

                                    Else

                                        Limpiar()
                                        Me.cmbArea.Focus()

                                    End If
                                End If
                            Catch ex As System.Exception

                                MessageBox.Show(ex.ToString)
                                Exit Sub

                            End Try
                        End If
                    Else

                        MessageBox.Show("Los litros no han sido capturados dentro de LIS. No.Viaje: " & Me.TxtNoViaje.Text)
                        Me.TxtNoViaje.Focus()

                    End If
                Else

                    MessageBox.Show("El valor de litros esta vacio. Favor de capturar en LIS. No.Viaje: " & Me.TxtNoViaje.Text)
                    Me.TxtNoViaje.Focus()

                End If
            Else

                MessageBox.Show("Escoge una configuración de viaje válida")

            End If
        Else

            Dim combustible As String = ""

            If Me.grdUnidades.Rows.Count > 1 Then

                Dim oDa As SqlClient.SqlDataAdapter
                Dim oDs As System.Data.DataSet
                Dim oConexion As SqlClient.SqlConnection
                Dim oCommand As SqlClient.SqlCommand
                Dim oParameter As SqlClient.SqlParameter

                For x1 As Integer = 0 To Me.grdUnidades.Rows.Count - 1

                    combustible = Convert.ToString(Me.grdUnidades.Rows(x1).Cells("id_combustible").Value())

                    If Not CInt(Me.cmbConfViaje.SelectedIndex) = 0 Then 'Checas si la opcion de configuración de viaje es != 0
                        If Not String.IsNullOrEmpty(Me.TxtLitrosLis.Text.Trim()) Then
                            If Convert.ToDouble(Me.TxtLitrosLis.Text.Trim()) > 0.0 Then
                                If Valida() Then

                                    oConexion = Connection.getInstance().getConnection()
                                    oCommand = New SqlClient.SqlCommand("UP_Guarda_DatosViaje", oConexion)
                                    oCommand.CommandType = CommandType.StoredProcedure
                                    oConexion.Open()

                                    Try

                                        oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
                                        oParameter.Value = CInt(Me.TxtNoViaje.Text)
                                        oParameter = oCommand.Parameters.Add("@TipoViaje", SqlDbType.TinyInt)
                                        oParameter.Value = Me.TipoViaje
                                        '********************Se anade esta linea para el guardo de Config Viaje
                                        oParameter = oCommand.Parameters.Add("@ConfigViaje", SqlDbType.Int)
                                        oParameter.Value = CInt(Me.cmbConfViaje.SelectedIndex)
                                        '*************************************************************
                                        oParameter = oCommand.Parameters.Add("@Unidad", SqlDbType.VarChar)
                                        oParameter.Value = Me.TxtUnidad.Text
                                        oParameter = oCommand.Parameters.Add("@Semana", SqlDbType.Int)
                                        oParameter.Value = CInt(Me.TxtSemana.Text)

                                        If Me.TipoViaje = 2 Then

                                            oParameter = oCommand.Parameters.Add("@FecIni_Viaje", SqlDbType.DateTime)
                                            oParameter.Value = DBNull.Value
                                            oParameter = oCommand.Parameters.Add("@FecFin_Viaje", SqlDbType.DateTime)
                                            oParameter.Value = DBNull.Value

                                        Else

                                            oParameter = oCommand.Parameters.Add("@FecIni_Viaje", SqlDbType.DateTime)
                                            oParameter.Value = Convert.ToDateTime(Me.TxtFecIni.Text)
                                            oParameter = oCommand.Parameters.Add("@FecFin_Viaje", SqlDbType.DateTime)
                                            oParameter.Value = Convert.ToDateTime(Me.TxtFecFin.Text)

                                        End If

                                        oParameter = oCommand.Parameters.Add("@Km_Inicial", SqlDbType.Decimal)
                                        oParameter.Value = CDbl(Me.TxtKmInicial.Text)
                                        oParameter = oCommand.Parameters.Add("@Km_Final", SqlDbType.Decimal)
                                        oParameter.Value = CDbl(Me.TxtKmFinal.Text)
                                        oParameter = oCommand.Parameters.Add("@LitrosDiesel", SqlDbType.Decimal)
                                        oParameter.Value = CDbl(IIf(Me.TxtLitrosLis.Text = "", 0, Me.TxtLitrosLis.Text))
                                        oParameter = oCommand.Parameters.Add("@Complemento", SqlDbType.Decimal)
                                        oParameter.Value = CDbl(Me.TxtComplemento.Text)
                                        oParameter = oCommand.Parameters.Add("@Id_Personal", SqlDbType.Int)
                                        oParameter.Value = id_personal
                                        oParameter = oCommand.Parameters.Add("@Id_Cliente", SqlDbType.Int)
                                        oParameter.Value = id_cliente
                                        oParameter = oCommand.Parameters.Add("@Id_Origen", SqlDbType.Int)
                                        oParameter.Value = id_origen
                                        oParameter = oCommand.Parameters.Add("@Id_Destino", SqlDbType.Int)
                                        oParameter.Value = id_destino

                                        If Bit_Camioneta = False Then

                                            oParameter = oCommand.Parameters.Add("@Motor", SqlDbType.VarChar)

                                            If motor = Nothing Then

                                                oParameter.Value = DBNull.Value

                                            Else

                                                oParameter.Value = motor

                                            End If
                                        Else

                                            oParameter = oCommand.Parameters.Add("@Motor", SqlDbType.VarChar)
                                            oParameter.Value = DBNull.Value

                                        End If

                                        oParameter = oCommand.Parameters.Add("@Observaciones", SqlDbType.Text)
                                        oParameter.Value = Me.TxtObservaciones.Text
                                        oParameter = oCommand.Parameters.Add("@Bit_Urgente", SqlDbType.Bit)
                                        oParameter.Value = Convert.ToBoolean(Me.ckbUrgente.Checked)
                                        oParameter = oCommand.Parameters.Add("@Maniobras", SqlDbType.Money)
                                        oParameter.Value = Convert.ToDecimal(Me.TxtManiobras.Text)
                                        '#################### VALE DE COMBUSTIBLE ########################
                                        '#################################################################
                                        '#################################################################
                                        oParameter = oCommand.Parameters.Add("@IdComb", SqlDbType.Int)
                                        oParameter.Value = combustible
                                        '#################################################################
                                        '#################################################################
                                        oParameter = oCommand.Parameters.Add("@Movimientos", SqlDbType.Int)
                                        oParameter.Value = Convert.ToInt32(Me.txtMovimientos.Text.Trim())
                                        oParameter = oCommand.Parameters.Add("@Area", SqlDbType.Int)
                                        oParameter.Value = Me.Area
                                        oParameter = oCommand.Parameters.Add("@CRUZO_TODAS", SqlDbType.Bit)
                                        oParameter.Value = Me.cruzoTodas
                                        oDa = New SqlClient.SqlDataAdapter(oCommand)
                                        oDs = New System.Data.DataSet()
                                        oDa.Fill(oDs)
                                        oParameter.ResetSqlDbType()
                                        'GUARDA CARTAS PORTE
                                        Me.enlazaCartasPorteAlViaje()

                                        If Me.grdResetCAT.Rows.Count > 0 Or Me.grdReset.Rows.Count > 0 Then
                                            If tipotracto = 1 Then
                                                For i As Integer = 0 To Me.grdResetCAT.RowCount - 1

                                                    GuardaReset(Me.grdResetCAT.Rows(i).Cells(0).Value.ToString().Replace(",", "."), Me.grdResetCAT.Rows(i).Cells(1).Value.ToString().Replace(",", "."), Convert.ToUInt32(combustible))

                                                Next
                                            Else
                                                If Me.grdReset.Rows.Count > 0 Then
                                                    For i As Integer = 0 To Me.grdReset.RowCount - 1

                                                        GuardaReset(Me.grdReset.Rows(i).Cells(0).Value.ToString().Replace(",", "."), Me.grdReset.Rows(i).Cells(1).Value.ToString().Replace(",", "."), Convert.ToUInt32(combustible))

                                                    Next
                                                End If
                                            End If
                                        End If

                                        If Me.grdContenedores.Rows.Count > 0 Then
                                            For i As Integer = 0 To Me.grdContenedores.Rows.Count - 1
                                                If Me.grdContenedores.Rows(i).Cells(0).Value.ToString() <> "" Then

                                                    GuardaContenedores(Me.grdContenedores.Rows(i).Cells(0).Value.ToString(), Me.grdContenedores.Rows(i).Cells(1).Value.ToString())

                                                End If
                                            Next
                                        End If

                                        If Me.grdRemolques.Rows.Count > 0 Then
                                            For i As Integer = 0 To Me.grdRemolques.Rows.Count - 1
                                                If Me.grdRemolques.Rows(i).Cells(0).Value.ToString() <> "" Then

                                                    GuardaRemolques(Me.grdRemolques.Rows(i).Cells(0).Value.ToString(), Me.grdRemolques.Rows(i).Cells(1).Value.ToString())

                                                End If
                                            Next
                                        End If

                                        'Si es foráneo
                                        If TipoViaje = 1 Then

                                            ValidaLitros()
                                            'Valida si es local     se acaba de añadir este codigo

                                        ElseIf TipoViaje = 2 Then

                                            ValidaLitros()

                                        Else

                                            'Si existe reseteo
                                            If Me.grdReset.Rows.Count > 1 OrElse Me.grdResetCAT.Rows.Count > 1 Then

                                            End If
                                        End If

                                        MessageBox.Show("Datos guardados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)

                                        If Bit_Nuevo = False Then

                                            Me.Button1_Click(sender, e)

                                        End If

                                        If TipoViaje = 1 Then

                                            'Limpiar()
                                            Me.TxtNoViaje.Focus()

                                        Else

                                            If Me.grdUnidades.Rows.Count > 1 Then

                                                'Limpiar()
                                                Me.cmbArea.Focus()

                                            Else

                                                'Limpiar()
                                                Me.cmbArea.Focus()

                                            End If
                                        End If

                                    Catch ex As System.Exception

                                        MessageBox.Show(ex.ToString)
                                        Exit Sub

                                    End Try
                                End If
                            Else

                                MessageBox.Show("Los litros no han sido capturados dentro de LIS. No.Viaje: " & Me.TxtNoViaje.Text)
                                Me.TxtNoViaje.Focus()

                            End If
                        Else

                            MessageBox.Show("El valor de litros esta vacio. Favor de capturar en LIS. No.Viaje: " & Me.TxtNoViaje.Text)
                            Me.TxtNoViaje.Focus()

                        End If
                    Else

                        MessageBox.Show("Escoge una configuración de viaje válida")

                    End If
                Next

                Me.Limpiar()

            End If 'termina if de la tabla de unidades
        End If
    End Sub
#End Region

#Region "Guarda Contenedores"
    Private Sub GuardaContenedores(ByVal Contenedor As String, ByVal Tipo As String)

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_ContenedoresViaje", oConexion)
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        Dim oParameter As SqlClient.SqlParameter

        Try

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtNoViaje.Text)
            oParameter = oCommand.Parameters.Add("@Contenedor", SqlDbType.VarChar)
            oParameter.Value = Contenedor
            oParameter = oCommand.Parameters.Add("@Tipo", SqlDbType.VarChar)
            oParameter.Value = Tipo
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oParameter.ResetSqlDbType()

        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub
#End Region

#Region "Guardar Remolques"
    Private Sub GuardaRemolques(ByVal Remolque As String, ByVal Tipo As String)

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_RemolquesViaje", oConexion)
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        Dim oParameter As SqlClient.SqlParameter

        Try

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtNoViaje.Text)
            oParameter = oCommand.Parameters.Add("@Remolque", SqlDbType.VarChar)
            oParameter.Value = Remolque
            oParameter = oCommand.Parameters.Add("@Tipo", SqlDbType.VarChar)
            oParameter.Value = Tipo
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oParameter.ResetSqlDbType()

        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub
#End Region

#Region "Guarda Reset"
    Private Sub GuardaReset(ByVal Parametro As String, ByVal Valor As String, ByVal IdComb As String)

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_ResetViaje", oConexion)
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        Dim oParameter As SqlClient.SqlParameter

        Try

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtNoViaje.Text)
            oParameter = oCommand.Parameters.Add("@IdComb", SqlDbType.Int)
            oParameter.Value = IdComb
            oParameter = oCommand.Parameters.Add("@Parametro", SqlDbType.VarChar)
            oParameter.Value = Parametro
            oParameter = oCommand.Parameters.Add("@Valor", SqlDbType.VarChar)
            oParameter.Value = Valor
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oParameter.ResetSqlDbType()
            oConexion.Close()

        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try

    End Sub
#End Region

#End Region
#Region "Útiles: Excel, Limpiar, Validaciones, Correo"
#Region "Impresión (Excel) Archivos de Reseteo"
#Region "Botón imprimir reseteo"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If tipotracto = 1 Then

            ImpResetCaterpillar()

        Else

            ImpResetCummins()

        End If
    End Sub
#End Region
#Region "Impresión Caterpillar"
    Private Sub ImpResetCaterpillar()

        Dim oDa As SqlClient.SqlDataAdapter
        Dim CategoryName As Integer
        Dim objLibroExcel As Workbook
        Dim objHojaExcel As Worksheet
        Dim objDataSet As New DataSet("ExcelTest")
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_ReporteReset_Caterpillar", oConexion)
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        Dim oParameter As SqlClient.SqlParameter

        Try

            oParameter = oCommand.Parameters.Add("@Viaje", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtNoViaje.Text)
            oParameter = oCommand.Parameters.Add("@Unidad", SqlDbType.VarChar)
            oParameter.Value = Me.TxtUnidad.Text
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            objDataSet = New System.Data.DataSet()
            oDa.Fill(objDataSet)
            m_Excel = New Microsoft.Office.Interop.Excel.Application
            Dim OldCultureInfo As System.Globalization.CultureInfo = _
            System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = _
            New System.Globalization.CultureInfo("en-US")
            objLibroExcel = m_Excel.Workbooks.Add()
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible
            objHojaExcel.Activate()
            Dim objCelda As Range = objHojaExcel.Range("A3", Type.Missing)
            objCelda.Value = "Resumen de Viaje"
            objHojaExcel.Range("H1:I1").Merge()
            objHojaExcel.Range("H1:I1").Value = "RESETEO"
            objHojaExcel.Range("H1:I1").Font.Bold = True
            objHojaExcel.Range("H1:I1").Font.Size = 15
            objHojaExcel.Range("J1:K1").Merge()
            objHojaExcel.Range("J1:K1").Value = "CONSUMO"
            objHojaExcel.Range("J1:K1").Font.Bold = True
            objHojaExcel.Range("J1:K1").Font.Size = 15
            objHojaExcel.Range("H6:J6").Merge()
            objHojaExcel.Range("H6:J6").Value = "DIFERENCIA"
            objHojaExcel.Range("H6:J6").Font.Bold = True
            objHojaExcel.Range("H6:J6").Font.Size = 15
            objCelda = objHojaExcel.Range("H2", Type.Missing)
            objCelda.Value = "RESET 1"
            objCelda = objHojaExcel.Range("H3", Type.Missing)
            objCelda.Value = "RESET 2"
            objCelda = objHojaExcel.Range("H4", Type.Missing)
            objCelda.Value = "TOTAL"
            objCelda = objHojaExcel.Range("J2", Type.Missing)
            objCelda.Value = "CONSUMO 1"
            objCelda = objHojaExcel.Range("J3", Type.Missing)
            objCelda.Value = "CONSUMO 2"
            objCelda = objHojaExcel.Range("J4", Type.Missing)
            objCelda.Value = "TOTAL"
            Dim xlCenter As Integer = -4108
            objHojaExcel.Range("A17:A17").Value = "____________________"
            objHojaExcel.Range("A17:A17").Font.Bold = True
            objHojaExcel.Range("A17:A17").HorizontalAlignment = xlCenter
            objHojaExcel.Range("A18:A18").Value = "REVISO"
            objHojaExcel.Range("A18:A18").Font.Bold = True
            objHojaExcel.Range("A18:A18").HorizontalAlignment = xlCenter
            objHojaExcel.Range("D17:D17").Value = "____________________"
            objHojaExcel.Range("D17:D17").Font.Bold = True
            objHojaExcel.Range("D17:D17").HorizontalAlignment = xlCenter
            objHojaExcel.Range("D18:D18").Value = "AUTORIZO"
            objHojaExcel.Range("D18:D18").Font.Bold = True
            objHojaExcel.Range("D18:D18").HorizontalAlignment = xlCenter
            objHojaExcel.Range("A14:D14").Merge()
            objHojaExcel.Range("A14:D14").Value = "IMPRESIÓN ELECTRÓNICA ORIGINAL"
            objHojaExcel.Range("A14:D14").Font.Bold = True
            objHojaExcel.Range("A14:D14").HorizontalAlignment = xlCenter
            Dim litrosReset As Double = 0.0

            If Not String.IsNullOrEmpty(Me.TxtLtsReset.Text.Trim()) Then

                litrosReset = Convert.ToDouble(Me.TxtLtsReset.Text.Trim)

            End If

            Dim litrosLis As Double = 0.0
            Dim complemento As Double = 0.0

            If Not String.IsNullOrEmpty(Me.TxtLitrosLis.Text.Trim) Then

                litrosLis = Convert.ToDouble(Me.TxtLitrosLis.Text)

            End If

            If Not String.IsNullOrEmpty(Me.TxtComplemento.Text.Trim) Then

                complemento = Convert.ToDouble(Me.TxtComplemento.Text.Trim)

            End If

            Dim reset As Double = litrosReset
            Dim litros As Double = litrosLis + complemento
            objCelda = objHojaExcel.Range("I2", Type.Missing)
            objCelda.Value = reset.ToString()
            objCelda = objHojaExcel.Range("I3", Type.Missing)
            objCelda.Value = "0"
            objCelda = objHojaExcel.Range("I4", Type.Missing)
            objCelda.Value = reset.ToString()
            objCelda = objHojaExcel.Range("K2", Type.Missing)
            objCelda.Value = litros.ToString()
            objCelda = objHojaExcel.Range("K3", Type.Missing)
            objCelda.Value = "0"
            objCelda = objHojaExcel.Range("K4", Type.Missing)
            objCelda.Value = litros.ToString()
            objCelda = objHojaExcel.Range("K6", Type.Missing)
            objCelda.Value = Convert.ToString(litros - reset)
            objCelda = objHojaExcel.Range("I2", Type.Missing)
            objCelda.Value = reset.ToString()
            objCelda = objHojaExcel.Range("I3", Type.Missing)
            objCelda.Value = "0"
            objCelda = objHojaExcel.Range("I4", Type.Missing)
            objCelda.Value = reset.ToString()
            objCelda = objHojaExcel.Range("K2", Type.Missing)
            objCelda.Value = litros.ToString()
            objCelda = objHojaExcel.Range("K3", Type.Missing)
            objCelda.Value = "0"
            objCelda = objHojaExcel.Range("K4", Type.Missing)
            objCelda.Value = litros.ToString()
            objCelda = objHojaExcel.Range("K6", Type.Missing)
            objCelda.Value = Convert.ToString(litros - reset)
            objCelda = objHojaExcel.Range("C4", Type.Missing)
            objCelda.Value = "LTS"
            objCelda = objHojaExcel.Range("C5", Type.Missing)
            objCelda.Value = ""
            objCelda = objHojaExcel.Range("C6", Type.Missing)
            objCelda.Value = "HRS"
            objCelda = objHojaExcel.Range("C7", Type.Missing)
            objCelda.Value = "LTS"
            objCelda = objHojaExcel.Range("C9", Type.Missing)
            objCelda.Value = "KM"
            objCelda = objHojaExcel.Range("F4", Type.Missing)
            objCelda.Value = "LTS"
            objCelda = objHojaExcel.Range("F5", Type.Missing)
            objCelda.Value = "LTS"
            objCelda = objHojaExcel.Range("F6", Type.Missing)
            objCelda.Value = "LTS"
            objCelda = objHojaExcel.Range("F8", Type.Missing)
            objCelda.Value = "KM/H"
            objCelda = objHojaExcel.Range("F9", Type.Missing)
            objCelda.Value = "KM/H"
            objHojaExcel.Range("A1:B1").Merge()
            objHojaExcel.Range("A1:B1").Value = "REPORTE DE RESET DE UNIDAD"
            objHojaExcel.Range("A1:F1").Font.Bold = True
            objHojaExcel.Range("A1:F1").Font.Size = 15
            objHojaExcel.Range("C1:F1").Merge()
            objHojaExcel.Range("C1:F1").Value = "Nombre de Operador"
            objHojaExcel.Range("D2:F2").Merge()
            objHojaExcel.Range("A2:A2").Value = "Numero de Unidad"
            objHojaExcel.Range("C2:F2").Merge()
            objHojaExcel.Range("C2:F2").Value = Me.TxtOperador.Text()
            objHojaExcel.Cells(2, 2) = Me.TxtUnidad.Text()
            objHojaExcel.Range("A2:D2").Font.Bold = True
            objHojaExcel.Range("A2:D2").Font.Size = 13
            objCelda = objHojaExcel.Range("B3", Type.Missing)
            objCelda.Value = "Valor"
            objCelda = objHojaExcel.Range("C3", Type.Missing)
            objCelda.Value = "Unidades"
            objCelda = objHojaExcel.Range("F3", Type.Missing)
            objCelda.Value = "Unidades"
            objCelda = objHojaExcel.Range("D3", Type.Missing)
            objCelda.Value = "Combustible Utilizado"
            objCelda = objHojaExcel.Range("E3", Type.Missing)
            objCelda.Value = "Valor"
            objCelda.EntireColumn.NumberFormat = "###,###,###.00"
            objCelda.EntireColumn.Font.Bold = True
            CategoryName = 1
            Dim i As Integer = 4
            Dim j As Integer = 4

            For Each objRow As DataRow In objDataSet.Tables(0).Rows
                If CategoryName.ToString().Length > 0 AndAlso CategoryName <> objRow.Item(2) Then
                    If objRow.Item(2) = 2 Then

                        objHojaExcel.Cells(i, 1) = "Distancia"
                        objHojaExcel.Cells(i, 2) = "Valor"

                    End If

                    If objRow.Item(2) = 3 Then

                        i = i - 7

                    End If

                    If objRow.Item(2) = 4 Then

                        objHojaExcel.Cells(i, 4) = "Velocidad"
                        objHojaExcel.Cells(i, 5) = "Valor"

                    End If

                    j = i

                    If i = 11 And CategoryName < 3 Then

                        i = 3

                    End If

                    i += 1

                End If

                CategoryName = objRow.Item(2)

                If CategoryName = 1 Or CategoryName = 2 Then

                    objHojaExcel.Cells(i, "A") = objRow.Item(0)
                    objHojaExcel.Cells(i, "B") = objRow.Item(1)

                End If

                If CategoryName > 2 Then

                    objHojaExcel.Cells(i, "D") = objRow.Item(0)
                    objHojaExcel.Cells(i, "E") = objRow.Item(1)

                End If

                If i = 11 And CategoryName < 3 Then

                    i = 3

                End If

                i += 1

            Next

            Dim objRango As Range = objHojaExcel.Range("A1:F11")
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.AutoFormat(11, Alignment:=False)
            objHojaExcel.Range("A10:B10").Font.Bold = True
            objHojaExcel.Range("D7:E7").Font.Bold = True
            objCelda = objHojaExcel.Range("D12", Type.Missing)
            objCelda.Font.Bold = True
            objCelda.Value = "FECHA DE RESET: " & Me.fechaReset
            objRango = objHojaExcel.Range("H1:K6")
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.AutoFormat(11, Alignment:=False)
            m_Excel.Visible = True
            objLibroExcel.PrintPreview()

        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub
#End Region
#Region "Impresión Cummins"
    Private Sub ImpResetCummins()

        Dim oDa As SqlClient.SqlDataAdapter
        Dim CategoryName As Integer
        Dim objLibroExcel As Workbook
        Dim objHojaExcel As Worksheet
        Dim objDataSet As New DataSet("ExcelTest")
        Dim index As Integer
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_ReporteReset_Cummins", oConexion)
        Dim oParameter As SqlClient.SqlParameter
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Try

            oParameter = oCommand.Parameters.Add("@Viaje", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtNoViaje.Text)
            oParameter = oCommand.Parameters.Add("@Unidad", SqlDbType.VarChar)
            oParameter.Value = Me.TxtUnidad.Text
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            objDataSet = New System.Data.DataSet()
            oDa.Fill(objDataSet)

            If objDataSet.Tables(0).Rows.Count = 25 Then

                index = 17

            Else

                index = 16

            End If

            m_Excel = New Microsoft.Office.Interop.Excel.Application
            Dim OldCultureInfo As System.Globalization.CultureInfo = _
            System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = _
            New System.Globalization.CultureInfo("en-US")
            objLibroExcel = m_Excel.Workbooks.Add()
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible
            objHojaExcel.Activate()
            objHojaExcel.PageSetup.PrintArea = "A1:F26"
            objHojaExcel.PageSetup.PaperSize = XlPaperSize.xlPaperA4
            objHojaExcel.PageSetup.Orientation = XlPageOrientation.xlLandscape
            objHojaExcel.Range("A1:B1").Merge()
            objHojaExcel.Range("A1:B1").Value = "REPORTE DE RESET DE UNIDAD"
            objHojaExcel.Range("A1:D1").Font.Bold = True
            objHojaExcel.Range("A1:D1").Font.Size = 15
            objHojaExcel.Range("C1:D1").Merge()
            objHojaExcel.Range("C1:D1").Value = "NOMBRE DEL OPERADOR"
            objHojaExcel.Range("C1:D1").Font.Bold = True
            objHojaExcel.Range("C1:D1").Font.Size = 15
            objHojaExcel.Range("C2:D2").Merge()
            objHojaExcel.Range("A2:A2").Value = "Numero de Unidad"
            objHojaExcel.Cells(2, 2) = Me.TxtUnidad.Text()
            objHojaExcel.Cells(2, 3) = Me.TxtOperador.Text()
            objHojaExcel.Range("A2:D2").Font.Bold = True
            objHojaExcel.Range("A2:D2").Font.Size = 13
            Dim xlCenter As Integer = -4108
            objHojaExcel.Range("A24:A24").Value = "____________________"
            objHojaExcel.Range("A24:A24").Font.Bold = True
            objHojaExcel.Range("A24:A24").HorizontalAlignment = xlCenter
            objHojaExcel.Range("A25:A25").Value = "REVISO"
            objHojaExcel.Range("A25:A25").Font.Bold = True
            objHojaExcel.Range("A25:A25").HorizontalAlignment = xlCenter
            objHojaExcel.Range("D24:D24").Value = "____________________"
            objHojaExcel.Range("D24:D24").Font.Bold = True
            objHojaExcel.Range("D24:D24").HorizontalAlignment = xlCenter
            objHojaExcel.Range("D25:D25").Value = "AUTORIZO"
            objHojaExcel.Range("D25:D25").Font.Bold = True
            objHojaExcel.Range("D25:D25").HorizontalAlignment = xlCenter
            objHojaExcel.Range("A21:D21").Merge()
            objHojaExcel.Range("A21:D21").Value = "COPIA FIEL DE LA ORIGINAL-"
            objHojaExcel.Range("A21:D21").Font.Bold = True
            objHojaExcel.Range("A21:D21").HorizontalAlignment = xlCenter
            Dim objCelda As Range = objHojaExcel.Range("A3", Type.Missing)
            objCelda.Value = "Resumen de Viaje"
            objCelda = objHojaExcel.Range("B3", Type.Missing)
            objCelda.Value = "Valor"
            objCelda = objHojaExcel.Range("C3", Type.Missing)
            objCelda.Value = "Unidades"
            objCelda = objHojaExcel.Range("D3", Type.Missing)
            objCelda.Value = "Datos de Combustible"
            objCelda = objHojaExcel.Range("E3", Type.Missing)
            objCelda.Value = "Valor"
            objCelda.EntireColumn.NumberFormat = "###,###,###.00"
            objCelda.EntireColumn.Font.Bold = True
            objCelda = objHojaExcel.Range("F3", Type.Missing)
            objCelda.Value = "Unidades"
            objHojaExcel.Range("H1:I1").Merge()
            objHojaExcel.Range("H1:I1").Value = "RESETEO"
            objHojaExcel.Range("H1:I1").Font.Bold = True
            objHojaExcel.Range("H1:I1").Font.Size = 15
            objHojaExcel.Range("J1:K1").Merge()
            objHojaExcel.Range("J1:K1").Value = "CONSUMO"
            objHojaExcel.Range("J1:K1").Font.Bold = True
            objHojaExcel.Range("J1:K1").Font.Size = 15
            objHojaExcel.Range("H6:J6").Merge()
            objHojaExcel.Range("H6:J6").Value = "DIFERENCIA"
            objHojaExcel.Range("H6:J6").Font.Bold = True
            objHojaExcel.Range("H6:J6").Font.Size = 15
            objCelda = objHojaExcel.Range("H2", Type.Missing)
            objCelda.Value = "RESET 1"
            objCelda = objHojaExcel.Range("H3", Type.Missing)
            objCelda.Value = "RESET 2"
            objCelda = objHojaExcel.Range("H4", Type.Missing)
            objCelda.Value = "TOTAL"
            objCelda = objHojaExcel.Range("J2", Type.Missing)
            objCelda.Value = "CONSUMO 1"
            objCelda = objHojaExcel.Range("J3", Type.Missing)
            objCelda.Value = "CONSUMO 2"
            objCelda = objHojaExcel.Range("J4", Type.Missing)
            objCelda.Value = "TOTAL"
            Dim litrosReset As Double = 0.0

            If Not String.IsNullOrEmpty(Me.TxtLtsReset.Text.Trim()) Then

                litrosReset = Convert.ToDouble(Me.TxtLtsReset.Text.Trim)

            End If

            Dim litrosLis As Double = 0.0
            Dim complemento As Double = 0.0

            If Not String.IsNullOrEmpty(Me.TxtLitrosLis.Text.Trim) Then

                litrosLis = Convert.ToDouble(Me.TxtLitrosLis.Text)

            End If

            If Not String.IsNullOrEmpty(Me.TxtComplemento.Text.Trim) Then

                complemento = Convert.ToDouble(Me.TxtComplemento.Text.Trim)

            End If

            Dim reset As Double = litrosReset
            Dim litros As Double = litrosLis + complemento
            objCelda = objHojaExcel.Range("I2", Type.Missing)
            objCelda.Value = reset.ToString()
            objCelda = objHojaExcel.Range("I3", Type.Missing)
            objCelda.Value = "0"
            objCelda = objHojaExcel.Range("I4", Type.Missing)
            objCelda.Value = reset.ToString()
            objCelda = objHojaExcel.Range("K2", Type.Missing)
            objCelda.Value = litros.ToString()
            objCelda = objHojaExcel.Range("K3", Type.Missing)
            objCelda.Value = "0"
            objCelda = objHojaExcel.Range("K4", Type.Missing)
            objCelda.Value = litros.ToString()
            objCelda = objHojaExcel.Range("K6", Type.Missing)
            objCelda.Value = Convert.ToString(litros - reset)
            objCelda = objHojaExcel.Range("I2", Type.Missing)
            objCelda.Value = reset.ToString()
            objCelda = objHojaExcel.Range("I3", Type.Missing)
            objCelda.Value = "0"
            objCelda = objHojaExcel.Range("I4", Type.Missing)
            objCelda.Value = reset.ToString()
            objCelda = objHojaExcel.Range("K2", Type.Missing)
            objCelda.Value = litros.ToString()
            objCelda = objHojaExcel.Range("K3", Type.Missing)
            objCelda.Value = "0"
            objCelda = objHojaExcel.Range("K4", Type.Missing)
            objCelda.Value = litros.ToString()
            objCelda = objHojaExcel.Range("K6", Type.Missing)
            objCelda.Value = Convert.ToString(litros - reset)
            objCelda = objHojaExcel.Range("C4", Type.Missing)
            objCelda.Value = "KMS"
            objCelda = objHojaExcel.Range("C5", Type.Missing)
            objCelda.Value = "KM/LT"
            objCelda = objHojaExcel.Range("C11", Type.Missing)
            objCelda.Value = "HRS"
            objCelda = objHojaExcel.Range("C13", Type.Missing)
            objCelda.Value = "HRS"
            objCelda = objHojaExcel.Range("C14", Type.Missing)
            objCelda.Value = "HRS"
            objCelda = objHojaExcel.Range("C15", Type.Missing)
            objCelda.Value = "HRS"
            objCelda = objHojaExcel.Range("F15", Type.Missing)
            objCelda.Value = "KM/HR"
            objCelda = objHojaExcel.Range("F16", Type.Missing)
            objCelda.Value = "RPM"
            objCelda = objHojaExcel.Range("F5", Type.Missing)
            objCelda.Value = "LITROS"
            objCelda = objHojaExcel.Range("F6", Type.Missing)
            objCelda.Value = "LITROS"
            objCelda = objHojaExcel.Range("F7", Type.Missing)
            objCelda.Value = "LITROS"
            objCelda = objHojaExcel.Range("F8", Type.Missing)
            objCelda.Value = "LITROS"
            objCelda = objHojaExcel.Range("F9", Type.Missing)
            objCelda.Value = "LITROS"
            objCelda = objHojaExcel.Range("D19", Type.Missing)
            objCelda.Font.Bold = True
            objCelda.Value = "FECHA DE RESET: " & Me.fechaReset
            CategoryName = 1
            Dim i As Integer = 4
            Dim j As Integer = 4

            For Each objRow As DataRow In objDataSet.Tables(0).Rows
                If CategoryName.ToString().Length > 0 AndAlso CategoryName <> objRow.Item(2) Then
                    If objRow.Item(2) = 2 Then

                        objHojaExcel.Cells(i, 1) = "Distancia"
                        objHojaExcel.Cells(i, 2) = "Valor"

                    End If

                    If objRow.Item(2) = 3 Then

                        i = i - 1

                    End If

                    If objRow.Item(2) = 4 Then

                        objHojaExcel.Cells(i, 4) = "Cuenta"
                        objHojaExcel.Cells(i, 5) = "Valor"

                    End If

                    If objRow.Item(2) = 5 Then

                        objHojaExcel.Cells(i, 4) = "Velocidades Máximas"
                        objHojaExcel.Cells(i, 5) = "Valor"

                    End If

                    j = i

                    If i = index And CategoryName < 3 Then

                        i = 3

                    End If

                    i += 1

                End If

                CategoryName = objRow.Item(2)

                If CategoryName = 1 Or CategoryName = 2 Then

                    objHojaExcel.Cells(i, "A") = objRow.Item(0)
                    objHojaExcel.Cells(i, "B") = objRow.Item(1)

                End If

                If CategoryName > 2 Then

                    objHojaExcel.Cells(i, "D") = objRow.Item(0)
                    objHojaExcel.Cells(i, "E") = objRow.Item(1)

                End If

                If i = index And CategoryName < 3 Then

                    i = 3

                End If

                i += 1

            Next

            Dim objRango As Range = objHojaExcel.Range("A1:F18")
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.AutoFormat(11, Alignment:=False)
            objRango = objHojaExcel.Range("H1:K6")
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.AutoFormat(11, Alignment:=False)

            If index = 17 Then

                objHojaExcel.Range("A16:B16").Font.Bold = True

            Else

                objHojaExcel.Range("A16:B16").Font.Bold = True

            End If

            objHojaExcel.Range("D9:E9").Font.Bold = True
            objHojaExcel.Range("D13:E13").Font.Bold = True
            m_Excel.Visible = True
            objLibroExcel.PrintPreview()

        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show("Hubo un problema: " & ex.Message.ToString & " Rastro de pila: " & ex.StackTrace)

        Catch ex1 As SEHException

            System.Windows.Forms.MessageBox.Show("Hubo un problema: " & ex1.Message.ToString & " Codigo E: " & ex1.ErrorCode)



        End Try
    End Sub
#End Region
#End Region
#Region "Limpiar"

    Public Sub Limpiar()

        Me.gbDias.Enabled = False
        Me.gbRemolques.Enabled = False
        Me.gbCartasPorte.Enabled = False
        Me.btnCasetas.Enabled = False
        Me.btnGastos.Enabled = False
        Me.gbReset.Enabled = False
        Me.gbContenedores.Enabled = False
        Me.TxtUnidad.Text = ""
        Me.cmbTipoViaje.SelectedIndex = -1
        Me.cmbConfViaje.SelectedIndex = 1
        Me.TxtUnidad.Text = ""
        Me.TxtSemana.Text = ""
        Me.TxtOperador.Text = ""
        Me.TxtKmInicial.Text = ""
        Me.TxtKmFinal.Text = ""
        Me.TxtKmViaje.Text = ""
        Me.TxtKmReset.Text = ""
        Me.grdUnidades.Rows.Clear()
        Me.grdCartasPorte.DataSource = Nothing
        Me.grdContenedores.Rows.Clear()
        Me.TxtNoViaje.Text = ""
        Me.cmbFechaIni.Text = ""
        Me.TxtFecIni.Text = ""
        Me.TxtFecFin.Text = ""
        Me.TxtTotDias.Text = ""
        Me.grdRemolques.Rows.Clear()
        Me.TxtLitrosLis.Text = ""
        Me.TxtLtsReset.Text = ""
        Me.TxtComplemento.Text = "0"
        Me.TxtObservaciones.Text = ""
        Me.grdReset.Rows.Clear()
        Me.grdResetCAT.Rows.Clear()
        Me.grdResetCAT.Columns.Clear()
        Me.TxtManiobras.Text = ""
        Me.TxtCPReparto.Text = "CP"
        origen = ""
        destino = ""
        motor = ""
        unidadc = ""
        IdRuta = 0
        IdCombustible = 0
        tipotracto = 0
        id_personal = 0
        id_cliente = 0
        id_destino = 0
        id_origen = 0
        Bit_Camioneta = False
        Bit_Nuevo = False
        fecguia = Today
        TipoFecha = 0
        ViajeReparto = 0
        IdComb = 0
        cruzoTodas = True

    End Sub
#End Region
#Region "Valida captura de km inicial"
    Private Function Valida() As Boolean

        If Me.TxtKmInicial.Text = "" Then

            MessageBox.Show("Debe capturar el Km Inicial", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.TxtKmInicial.Focus()
            Return False

        End If

        If Me.TxtKmFinal.Text = "" Then

            MessageBox.Show("Debe capturar el Km Final", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.TxtKmFinal.Focus()
            Return False

        End If
        Return True
    End Function
#End Region
#Region "Valida Litros"
    Private Sub ValidaLitros()

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Consulta_Evaluacion", oConexion)
        Dim oParameter As SqlClient.SqlParameter

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Try

            oParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtNoViaje.Text)      '111529
            oParameter = oCommand.Parameters.Add("@Cliente", SqlDbType.VarChar)
            oParameter.Value = ""
            oParameter = oCommand.Parameters.Add("Semana", SqlDbType.Int)
            oParameter.Value = 0
            oParameter = oCommand.Parameters.Add("@FecIni", SqlDbType.DateTime)
            oParameter.Value = DateTime.Today                '05-08-2014
            oParameter = oCommand.Parameters.Add("@FecFin", SqlDbType.DateTime)
            oParameter.Value = DateTime.Today
            oParameter = oCommand.Parameters.Add("@Operador", SqlDbType.VarChar)
            oParameter.Value = ""
            oParameter = oCommand.Parameters.Add("@Area", SqlDbType.Int)
            oParameter.Value = Me.Area
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            If TipoViaje = 1 Then ' Se comprueba tipo de viaje foraneo
                If oDs.Tables(0).Rows.Count > 0 Then  'pregunta si el gried se encuentra lleno
                    If IsDBNull(oDs.Tables(0).Rows(0).Item("Lts Estandar")) = False Then
                        If Abs(oDs.Tables(0).Rows(0).Item("Lts Viaje") - oDs.Tables(0).Rows(0).Item("Lts Estandar")) >= MaxLitrosDif Then

                            'MandaCorreo(oDs.Tables(0).Rows(0).Item("Lts Viaje"), oDs.Tables(0).Rows(0).Item("Lts Estandar"), Abs(oDs.Tables(0).Rows(0).Item("Lts Viaje") - oDs.Tables(0).Rows(0).Item("Lts Estandar")))

                        End If
                    Else
                        If IsDBNull(oDs.Tables(0).Rows(0).Item("Faltante con Ajuste")) = False Then
                            If oDs.Tables(0).Rows(0).Item("Faltante con Ajuste") >= MaxLitrosDif Then

                                'MandaCorreo(oDs.Tables(0).Rows(0).Item("Lts Viaje"), 0, oDs.Tables(0).Rows(0).Item("Faltante con Ajuste"))

                            End If
                        Else

                            MessageBox.Show("No existe dato de litros estandar y faltante con ajuste", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)

                        End If
                    End If
                End If
            ElseIf TipoViaje = 2 Then
                If Abs(Me.TxtLitrosLis.Text - Me.TxtLtsReset.Text) Then

                    MandaCorreo(CDbl(Me.TxtLitrosLis.Text), CDbl(Me.TxtLtsReset.Text), Abs(CDbl(Me.TxtLitrosLis.Text) - (CDbl(Me.TxtLtsReset.Text))))

                End If
            End If  'fin del if donde compara el tipo de viaje
        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub
#End Region
#Region "Valida Km final"
    Private Sub TxtKmFinal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKmFinal.Leave

        If Me.TxtKmFinal.Text = "" Then

            MessageBox.Show("Debe capturar el Km Final", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.TxtKmFinal.Focus()

        Else

            Me.TxtKmViaje.Text = Convert.ToString(CDbl(Me.TxtKmFinal.Text) - CDbl(Me.TxtKmInicial.Text))

        End If
    End Sub
#End Region
#Region "Solo valores númericos"
    Private Sub TxtComplemento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComplemento.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) _
        And e.KeyChar <> "." Then

            e.Handled = True

        End If

        If e.KeyChar = "." And Me.TxtComplemento.Text.Contains(".") Then

            e.Handled = False

        End If

        If e.KeyChar = "." And Me.TxtComplemento.Text.Length < 1 Then

            e.Handled = False

        End If
    End Sub

    Private Sub TxtKmFinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKmFinal.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) _
        And e.KeyChar <> "." Then

            e.Handled = True

        End If

        If e.KeyChar = "." And Me.TxtKmFinal.Text.Contains(".") Then

            e.Handled = False

        End If

        If e.KeyChar = "." And Me.TxtKmFinal.Text.Length < 1 Then

            e.Handled = False

        End If
    End Sub

#End Region
#Region "Interacción de Enter o Tab"
    Private Sub frmDatosViaje_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim tecla = e.KeyCode

        If tecla = 40 Or tecla = 13 Then

            e.Handled = True
            SendKeys.Send("{TAB}")

        End If

        If tecla = 38 Then

            e.Handled = True
            SendKeys.Send("+{TAB}")

        End If
    End Sub
#End Region
#Region "Semana Habilitada"
    Private Sub TxtSemana_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSemana.DoubleClick

        Me.TxtSemana.Enabled = True

    End Sub

    Private Sub Label12_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.DoubleClick

        Me.TxtSemana.Enabled = True

    End Sub
#End Region
#Region "Envío de Correos"
    Private Sub MandaCorreo(ByVal Ltsviaje As Decimal, ByVal LtsEstandar As Decimal, ByVal difLts As Decimal)

        Dim Maildb As Object
        Dim UserName As String
        Dim MailDbName As String
        Dim MailDoc As Object
        Dim Session As Object
        Session = CreateObject("Notes.NotesSession")
        UserName = Session.UserName
        MailDbName = ""
        Maildb = Session.GETDATABASE("", MailDbName)

        If Maildb.IsOpen = True Then

        Else

            Maildb.OPENMAIL()

        End If

        MailDoc = Maildb.CREATEDOCUMENT
        MailDoc.Form = "Memo"
        'MailDoc.sendto = "pablo.montalvo@hinojosa.com.mx"
        MailDoc.sendto = "jose.mata@hinojosa.com.mx"
        MailDoc.copyto = "diesel.liquidaciones@hinojosa.com.mx"
        MailDoc.blindcopyto = "laura.reyes@hinojosa.com.mx"
        MailDoc.blindcopyto = "pilar.medina@hinojosa.com.mx"
        MailDoc.DeliveryPriority = "H"
        MailDoc.Subject = "Alerta de Viaje " + Me.TxtNoViaje.Text
        MailDoc.Body = "El viaje " + Me.TxtNoViaje.Text + Environment.NewLine + "de la unidad " + Me.TxtUnidad.Text + _
        Environment.NewLine + "con el operador " + Me.TxtOperador.Text + Environment.NewLine + _
        "tiene una diferencia en litros de: " + difLts.ToString() + Environment.NewLine + Environment.NewLine + _
        Environment.NewLine + "SISTEMA INTEGRAL INTERFLET"
        MailDoc.SAVEMESSAGEONSEND = 1
        MailDoc.PostedDate = Now()
        MailDoc.SEND(False)
        Maildb = Nothing
        MailDoc = Nothing
        Session = Nothing

    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim Maildb As Object
    '    Dim UserName As String
    '    Dim MailDbName As String
    '    Dim MailDoc As Object

    '    Dim Session As Object
    '    Dim EmbedObj As Object

    '    Session = CreateObject("Notes.NotesSession")
    '    UserName = Session.UserName
    '    MailDbName = "barrañag.nsf" 
    '    Maildb = Session.GETDATABASE("", MailDbName)
    '    If Maildb.IsOpen = True Then

    '    Else
    '        Maildb.OPENMAIL()
    '    End If

    '    MailDoc = Maildb.CREATEDOCUMENT
    '    MailDoc.Form = "Memo"
    '    MailDoc.sendto = "jose.mata@hinojosa.com.mx"
    '    MailDoc.copyto = "diesel.liquidaciones@hinojosa.com.mx"
    '    MailDoc.DeliveryPriority = "H"
    '    MailDoc.Subject = "Alerta de Viaje " + Me.TxtNoViaje.Text
    '    MailDoc.Body = "El viaje " + Me.TxtNoViaje.Text + " tiene una diferencia en litros de: "
    '    MailDoc.SAVEMESSAGEONSEND = 1

    '    MailDoc.PostedDate = Now()
    '    MailDoc.SEND(0, "jose.mata@hinojosa.com.mx")

    '    Maildb = Nothing
    '    MailDoc = Nothing

    '    Session = Nothing
    '    EmbedObj = Nothing
    'End Sub
#End Region
#Region "Salir"
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub
#End Region
#Region "Otros"
    Private Sub cmbArea_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.Leave

        Me.TxtNoViaje.Focus()

    End Sub

    Private Sub Label2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.DoubleClick

        Me.TxtKmInicial.Enabled = True

    End Sub
#End Region
#End Region

#Region "Cargado de Reset's"
    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ciudad As String = Me.cmbArea.SelectedItem.ToString.Trim
        Me.getReset(ciudad)

    End Sub
#Region "Cummins"
    Private Sub cargaresetCummins(ByVal archivo As String)

        Dim linea As String = ""
        Dim DatosTabla As Boolean = False
        Dim i, ini, pre, comienzo, fin As Integer

        Try

            If File.Exists(archivo) Then 'el archivo existe como html? si no lo busca como xml 

                FileOpen(1, archivo, OpenMode.Input)

                While (EOF(1) = False)

                    linea = LineInput(1)
                    'MessageBox.Show(archivo)

                    If (linea.Contains("Report Date")) Then

                        Me.fechaReset = linea.Substring(109, 24)

                    End If

                    If (InStr(UCase(linea), "ENGINE TYPE")) Then

                        ini = linea.IndexOf("Engine Type")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Engine Type"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "ECM CODE")) Then

                        ini = linea.IndexOf("ECM Code")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "ECM Code"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "LAST TOOL USED")) Then

                        ini = linea.IndexOf("Last Tool Used")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Last Tool Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "ENGINE SERIAL NUMBER")) Then

                        ini = linea.IndexOf("Engine Serial Number")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Engine Serial Number"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "SOFTWARE PHASE")) Then

                        ini = linea.IndexOf("Software Phase")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Software Phase"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "CUSTOMER NAME")) Then

                        ini = linea.IndexOf("Customer Name")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Customer Name"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "UNIT NUMBER")) Then

                        ini = linea.IndexOf("Unit Number")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Unit Number"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "ECM RUNTIME")) Then

                        ini = linea.IndexOf("ECM Runtime")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "ECM Runtime"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "POWERSPEC VERSION")) Then

                        ini = linea.IndexOf("PowerSpec Version")
                        pre = linea.IndexOf("spc2", ini)
                        comienzo = linea.IndexOf(">", pre) + 1
                        fin = linea.IndexOf("<", comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PowerSpec Version"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), ">AVERAGE FUEL ECONOMY")) Then

                        ini = linea.IndexOf("Average Fuel Economy")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Average Fuel Economy"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "DRIVE AVERAGE FUEL ECONOMY")) Then

                        ini = linea.IndexOf("Drive Average Fuel Economy")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Drive Average Fuel Economy"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "% IDLE TIME")) Then

                        ini = linea.IndexOf("% Idle Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% Idle Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "% PTO TIME")) Then

                        ini = linea.IndexOf("% PTO Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% PTO Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "% PTO NON-MOVING TIME")) Then

                        ini = linea.IndexOf("% PTO Non-Moving Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% PTO Non-Moving Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "% TOP GEAR DISTANCE")) Then

                        ini = linea.IndexOf("% Top Gear Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% Top Gear Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "% GEAR DOWN DISTANCE")) Then

                        ini = linea.IndexOf("% Gear Down Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% Gear Down Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "% CRUISE DISTANCE")) Then

                        ini = linea.IndexOf("% Cruise Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% Cruise Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "MAXIMUM VEHICLE SPEED")) Then

                        ini = linea.IndexOf("Maximum Vehicle Speed")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Vehicle Speed"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "NUMBER OF SUDDEN DECELERATIONS")) Then

                        ini = linea.IndexOf("Number of Sudden Decelerations")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Number of Sudden Decelerations"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TRIP DISTANCE")) Then

                        ini = linea.IndexOf("Trip Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Trip Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)
                        Me.TxtKmReset.Text = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOTAL ENGINE HOURS")) Then

                        ini = linea.IndexOf("Total Engine Hours")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total Engine Hours"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TRIP TIME")) Then

                        ini = linea.IndexOf("Trip Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Trip Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "DRIVE DISTANCE")) Then

                        ini = linea.IndexOf("Drive Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Drive Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "CRUISE DISTANCE")) Then

                        ini = linea.IndexOf("Cruise Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Cruise Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOP GEAR DISTANCE")) Then

                        ini = linea.IndexOf("Top Gear Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Top Gear Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "GEAR DOWN DISTANCE")) Then

                        ini = linea.IndexOf("Gear Down Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Gear Down Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "PTO MOVING DISTANCE")) Then

                        ini = linea.IndexOf("PTO Moving Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "VEHICLE OVERSPEED 1 DISTANCE")) Then

                        ini = linea.IndexOf("Vehicle Overspeed 1 Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "VEHICLE OVERSPEED 2 DISTANCE")) Then

                        ini = linea.IndexOf("Vehicle Overspeed 2 Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOP GEAR TIME")) Then

                        ini = linea.IndexOf("Top Gear Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Top Gear Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "GEAR DOWN TIME")) Then

                        ini = linea.IndexOf("Gear Down Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Gear Down Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "PTO MOVING TIME")) Then

                        ini = linea.IndexOf("PTO Moving Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "PTO NON-MOVING TIME")) Then

                        ini = linea.IndexOf("PTO Non-Moving Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Non-Moving Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "IDLE TIME")) Then

                        ini = linea.IndexOf("Idle Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Idle Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "VEHICLE OVERSPEED 1 TIME")) Then

                        ini = linea.IndexOf("Vehicle Overspeed 1 Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "VEHICLE OVERSPEED 2 TIME")) Then

                        ini = linea.IndexOf("Vehicle Overspeed 2 Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "COAST TIME OUT OF GEAR")) Then

                        ini = linea.IndexOf("Coast Time Out of Gear")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Coast Time Out of Gear"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "FAN ON TIME DUE TO MANUAL SWITCH")) Then

                        ini = linea.IndexOf("Fan On Time due to Manual Switch")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Fan On Time due to Manual Switch"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TRIP FUEL USED")) Then

                        ini = linea.IndexOf("Trip Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Trip Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)
                        Me.TxtLtsReset.Text = linea.Substring(comienzo, fin - comienzo).ToString()

                    End If

                    If (InStr(UCase(linea), "DRIVE FUEL USED")) Then

                        ini = linea.IndexOf("Drive Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Drive Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "PTO MOVING FUEL USED")) Then

                        ini = linea.IndexOf("PTO Moving Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "PTO NON-MOVING FUEL USED")) Then

                        ini = linea.IndexOf("PTO Non-Moving Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Non-Moving Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), ">IDLE FUEL USED")) Then

                        ini = linea.IndexOf("Idle Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Idle Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "VEHICLE OVERSPEED 1 FUEL USED")) Then

                        ini = linea.IndexOf("Vehicle Overspeed 1 Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "VEHICLE OVERSPEED 2 FUEL USED")) Then

                        ini = linea.IndexOf("Vehicle Overspeed 2 Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "SERVICE BRAKE ACTUATIONS / 1K")) Then

                        ini = linea.IndexOf("Service Brake Actuations / 1K")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Service Brake Actuations/1K"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "NUMBER OF COASTS OUT OF GEAR")) Then

                        ini = linea.IndexOf("Number of Coasts Out of Gear")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Number of Coasts Out of Gear"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "MAXIMUM ENGINE SPEED")) Then

                        ini = linea.IndexOf("Maximum Engine Speed")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Engine Speed"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "MAXIMUM VEHICLE SPEED")) Then

                        ini = linea.IndexOf("Maximum Vehicle Speed")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Vehicle Speed"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOTAL ENGINE DISTANCE")) Then

                        ini = linea.IndexOf("Total Engine Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total Engine Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "ENGINE DISTANCE OFFSET")) Then

                        ini = linea.IndexOf("Engine Distance Offset")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Engine Distance Offset"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOTAL ECM DISTANCE")) Then

                        ini = linea.IndexOf("Total ECM Distance")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total ECM Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOTAL FUEL USED")) Then

                        ini = linea.IndexOf("Total Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOTAL IDLE FUEL USED")) Then

                        ini = linea.IndexOf("Total Idle Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total Idle Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOTAL PTO FUEL USED")) Then

                        ini = linea.IndexOf("Total PTO Fuel Used")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total PTO Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If

                    If (InStr(UCase(linea), "TOTAL PTO TIME")) Then

                        ini = linea.IndexOf("Total PTO Time")
                        pre = linea.IndexOf("isMetric", ini)
                        comienzo = linea.IndexOf(Chr(34), pre) + 1
                        fin = linea.IndexOf(Chr(34), comienzo)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total PTO Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

                    End If
                End While

                FileClose(1)

            Else

                archivo = archivo.Replace("htm", "xls")

                If File.Exists(archivo) Then

                    Dim app As New Microsoft.Office.Interop.Excel.Application
                    Dim libro As Microsoft.Office.Interop.Excel.Workbook
                    Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
                    app = New Microsoft.Office.Interop.Excel.Application
                    libro = app.Workbooks.Open(archivo)
                    hoja = libro.Worksheets("Sheet1")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(0).Cells("desc").Value = "Report Date"
                    Me.grdReset.Rows(0).Cells("val").Value = hoja.Range("H5").Value.ToString().Replace("AM", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(1).Cells("desc").Value = "Engine Type"
                    Me.grdReset.Rows(1).Cells("val").Value = hoja.Range("B3").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(2).Cells("desc").Value = "ECM Code"
                    Me.grdReset.Rows(2).Cells("val").Value = hoja.Range("H3").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(3).Cells("desc").Value = "Last Tool Used"""
                    Me.grdReset.Rows(3).Cells("val").Value = "-"
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(4).Cells("desc").Value = "Engine Serial Number"
                    Me.grdReset.Rows(4).Cells("val").Value = hoja.Range("B4").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(5).Cells("desc").Value = "Software Phase"
                    Me.grdReset.Rows(5).Cells("val").Value = hoja.Range("H4").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(6).Cells("desc").Value = "Customer Name"
                    Me.grdReset.Rows(6).Cells("val").Value = "INTERFLET"
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(7).Cells("desc").Value = "Unit Number"
                    Me.grdReset.Rows(7).Cells("val").Value = hoja.Range("B5").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(8).Cells("desc").Value = "ECM Runtime"
                    Me.grdReset.Rows(8).Cells("val").Value = hoja.Range("H3").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(9).Cells("desc").Value = "PowerSpec Version"
                    Me.grdReset.Rows(9).Cells("val").Value = "-"
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(10).Cells("desc").Value = "Average Fuel Economy"
                    Me.grdReset.Rows(10).Cells("val").Value = hoja.Range("C13").Value.ToString().Replace("km/L", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(11).Cells("desc").Value = "Drive Average Fuel Economy"
                    Me.grdReset.Rows(11).Cells("val").Value = hoja.Range("C14").Value.ToString().Replace("km/L", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(12).Cells("desc").Value = "% Idle Time"
                    Me.grdReset.Rows(12).Cells("val").Value = hoja.Range("I13").Value.ToString().Replace("%", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(13).Cells("desc").Value = "% PTO Time"
                    Me.grdReset.Rows(13).Cells("val").Value = hoja.Range("C26").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(14).Cells("desc").Value = "% PTO Non-Moving Time"
                    Me.grdReset.Rows(14).Cells("val").Value = hoja.Range("C27").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(15).Cells("desc").Value = "% Top Gear Distance"
                    Me.grdReset.Rows(15).Cells("val").Value = hoja.Range("C23").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(16).Cells("desc").Value = "% Gear Down Distance"
                    Me.grdReset.Rows(16).Cells("val").Value = hoja.Range("C24").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(17).Cells("desc").Value = "% Cruise Distance"
                    Me.grdReset.Rows(17).Cells("val").Value = hoja.Range("C22").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(18).Cells("desc").Value = "Maximum Vehicle Speed"
                    Me.grdReset.Rows(18).Cells("val").Value = hoja.Range("F60").Value.ToString().Replace("km/h", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(19).Cells("desc").Value = "Number of Sudden Decelerations"
                    Me.grdReset.Rows(19).Cells("val").Value = hoja.Range("F46").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(20).Cells("desc").Value = "Trip Distance"
                    Me.grdReset.Rows(20).Cells("val").Value = hoja.Range("F20").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(21).Cells("desc").Value = "Total Engine Hours"
                    Me.grdReset.Rows(21).Cells("val").Value = hoja.Range("F65").Value.ToString().Replace("hh:mm:ss", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(22).Cells("desc").Value = "Trip Time"
                    Me.grdReset.Rows(22).Cells("val").Value = hoja.Range("D20").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(23).Cells("desc").Value = "Drive Distance"
                    Me.grdReset.Rows(23).Cells("val").Value = hoja.Range("F21").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(24).Cells("desc").Value = "Cruise Distance"
                    Me.grdReset.Rows(24).Cells("val").Value = hoja.Range("F22").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(25).Cells("desc").Value = "Top Gear Distance"
                    Me.grdReset.Rows(25).Cells("val").Value = hoja.Range("F23").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(26).Cells("desc").Value = "Gear Down Distance"
                    Me.grdReset.Rows(26).Cells("val").Value = hoja.Range("F24").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(27).Cells("desc").Value = "PTO Moving Distance"
                    Me.grdReset.Rows(27).Cells("val").Value = hoja.Range("F27").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(28).Cells("desc").Value = "Vehicle Overspeed 1 Distance"
                    Me.grdReset.Rows(28).Cells("val").Value = hoja.Range("F30").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(29).Cells("desc").Value = "Vehicle Overspeed 2 Distance"
                    Me.grdReset.Rows(29).Cells("val").Value = hoja.Range("F31").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(30).Cells("desc").Value = "Top Gear Time"
                    Me.grdReset.Rows(30).Cells("val").Value = hoja.Range("D23").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(31).Cells("desc").Value = "Gear Down Time"
                    Me.grdReset.Rows(31).Cells("val").Value = hoja.Range("D24").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(32).Cells("desc").Value = "PTO Moving Time"
                    Me.grdReset.Rows(32).Cells("val").Value = hoja.Range("D27").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(33).Cells("desc").Value = "PTO Non-Moving Time"
                    Me.grdReset.Rows(33).Cells("val").Value = hoja.Range("D28").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(34).Cells("desc").Value = "Idle Time"
                    Me.grdReset.Rows(34).Cells("val").Value = hoja.Range("C29").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(35).Cells("desc").Value = "Vehicle Overspeed 1 Time"
                    Me.grdReset.Rows(35).Cells("val").Value = hoja.Range("D30").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(36).Cells("desc").Value = "Vehicle Overspeed 2 Time"
                    Me.grdReset.Rows(36).Cells("val").Value = hoja.Range("D31").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(37).Cells("desc").Value = "Coast Time Out of Gear"
                    Me.grdReset.Rows(37).Cells("val").Value = hoja.Range("F47").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(38).Cells("desc").Value = "Fan On Time due to Manual Switch"
                    Me.grdReset.Rows(38).Cells("val").Value = hoja.Range("D32").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(39).Cells("desc").Value = "Trip Fuel Used"
                    Me.grdReset.Rows(39).Cells("val").Value = hoja.Range("C12").Value.ToString().Replace("L", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(40).Cells("desc").Value = "Drive Fuel Used"
                    Me.grdReset.Rows(40).Cells("val").Value = hoja.Range("I21").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(41).Cells("desc").Value = "PTO Moving Fuel Used"
                    Me.grdReset.Rows(41).Cells("val").Value = hoja.Range("I27").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(42).Cells("desc").Value = "PTO Non-Moving Fuel Used"
                    Me.grdReset.Rows(42).Cells("val").Value = hoja.Range("I26").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(43).Cells("desc").Value = "Idle Fuel Used"
                    Me.grdReset.Rows(43).Cells("val").Value = hoja.Range("I29").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(44).Cells("desc").Value = "Vehicle Overspeed 1 Fuel Used"
                    Me.grdReset.Rows(44).Cells("val").Value = hoja.Range("I30").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(45).Cells("desc").Value = "Vehicle Overspeed 2 Fuel Used"
                    Me.grdReset.Rows(45).Cells("val").Value = hoja.Range("I31").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(46).Cells("desc").Value = "Service Brake Actuations/1K"
                    Me.grdReset.Rows(46).Cells("val").Value = hoja.Range("F45").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(47).Cells("desc").Value = "Number of Coasts Out of Gear"
                    Me.grdReset.Rows(47).Cells("val").Value = hoja.Range("F47").Value.ToString()
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(48).Cells("desc").Value = "Maximum Engine Speed"
                    Me.grdReset.Rows(48).Cells("val").Value = hoja.Range("F59").Value.ToString().Replace("rpm", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(49).Cells("desc").Value = "Maximum Vehicle Speed"
                    Me.grdReset.Rows(49).Cells("val").Value = hoja.Range("F60").Value.ToString().Replace("km/h", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(50).Cells("desc").Value = "Total Engine Distance"
                    Me.grdReset.Rows(50).Cells("val").Value = hoja.Range("F63").Value.ToString().Replace("km", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(51).Cells("desc").Value = "Engine Distance Offset"
                    Me.grdReset.Rows(51).Cells("val").Value = hoja.Range("F64").Value.ToString().Replace("km", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(52).Cells("desc").Value = "Total ECM Distance"
                    Me.grdReset.Rows(52).Cells("val").Value = hoja.Range("F66").Value.ToString().Replace("km", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(53).Cells("desc").Value = "Total Fuel Used"
                    Me.grdReset.Rows(53).Cells("val").Value = hoja.Range("C12").Value.ToString().Replace("L", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(54).Cells("desc").Value = "Total Idle Fuel Used"
                    Me.grdReset.Rows(54).Cells("val").Value = hoja.Range("F68").Value.ToString().Replace("L", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(55).Cells("desc").Value = "Total PTO Fuel Used"
                    Me.grdReset.Rows(55).Cells("val").Value = hoja.Range("F69").Value.ToString().Replace("L", "")
                    Me.grdReset.Rows.Add()
                    Me.grdReset.Rows(56).Cells("desc").Value = "Total PTO Time"
                    Me.grdReset.Rows(56).Cells("val").Value = hoja.Range("F70").Value.ToString().Replace("hh:mm:ss", "")
                    libro.Close()
                    hoja = Nothing
                    libro = Nothing
                    app = Nothing
                    GC.Collect()

                End If
            End If
        Catch ex As System.Exception

            Dim form As New formEscogerCiudad()
            form.ShowDialog()
            MessageBox.Show(ex.Message.ToString())

        Finally

            FileClose(1)

        End Try
    End Sub
#End Region
#Region "Caterpillar"
    Private Sub cargaresetCat(ByVal ruta As String)
        Try

            Dim dsReset As New DataSet("reset")
            Dim indexhead, indexvalue, j, i, distancia, combustible As Integer
            j = 0
            i = 0
            dsReset.ReadXml(ruta)
            indexhead = dsReset.Tables(9).Columns("Heading_Text").Ordinal
            indexvalue = dsReset.Tables(12).Columns("Value_Text").Ordinal

            With grdResetCAT
                For Each row As DataRow In dsReset.Tables(9).Rows
                    If i >= 2 Then

                        .Columns.Add("column" & j, row(indexhead).ToString())
                        j = j + 1

                    End If

                    i = i + 1

                Next
            End With

            j = 0
            i = 0

            For Each row As DataRow In dsReset.Tables(4).Rows

                Me.fechaReset = row(2).ToString()

            Next

            For Each row As DataRow In dsReset.Tables(12).Rows
                If i <= 6 Then
                    If j Mod 2 = 0 Then

                        i = grdResetCAT.Rows.Add()
                        j = 0

                    End If

                    grdResetCAT.Rows(i).Cells(j).Value = row(indexvalue).ToString()
                    j = j + 1

                Else
                    If j Mod 3 = 0 Then

                        i = grdResetCAT.Rows.Add()
                        j = 0

                    End If

                    grdResetCAT.Rows(i).Cells(j).Value = row(indexvalue).ToString()
                    j = j + 1

                    If UCase(row(indexvalue).ToString()) = "DISTANCIA" Then

                        distancia = i

                    End If

                    If UCase(row(indexvalue).ToString()) = "COMBUSTIBLE" Then

                        combustible = i

                    End If
                End If
            Next

            Me.TxtKmReset.Text = grdResetCAT.Rows(distancia).Cells(1).Value.ToString()
            Me.TxtLtsReset.Text = grdResetCAT.Rows(combustible).Cells(1).Value.ToString()

        Catch ex As System.Exception

            Dim form As New formEscogerCiudad()
            form.ShowDialog()

        End Try
    End Sub
#End Region
#End Region
#Region "Reseteos"
    Public Sub getReset(ByVal ciudad As String)

        Dim openFileDialog1 As New OpenFileDialog()
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim ruta As String
        Dim unidad As String = ""
        Dim RutaPC As String
        Me.grdReset.Rows.Clear()
        Me.grdResetCAT.Rows.Clear()
        Me.grdResetCAT.Columns.Clear()

        Try

            'El programa se sale cuando entra a ejecutar esta rutina
            If Me.TxtUnidad.Text.Substring(0, 1) = "C" Then

                Bit_Camioneta = True
                Exit Sub

            ElseIf Me.TxtUnidad.Text.Substring(0, 1) = "P" Then
                If Me.TxtUnidad.Text.Contains("0") AndAlso Me.TxtUnidad.Text.Trim.Substring(0, 3).Contains("0") Then

                    Dim unidadx As String = Me.TxtUnidad.Text.Trim
                    unidadx = unidadx.Remove(2, 1)
                    unidad = unidadx
                    unidadc = unidadx

                Else

                    unidad = Me.TxtUnidad.Text.Trim().Insert(2, "0")
                    unidadc = Me.TxtUnidad.Text.Trim() '.Insert(2, "0") modificacion del 05/06/2015

                End If
            Else

                unidad = Me.TxtUnidad.Text.Trim()

            End If

            If ciudad = "Altamira" Then

                RutaPC = "\\175.50.5.191"


            ElseIf ciudad = "Manzanillo" Then

                RutaPC = "\\192.168.5.107"

            ElseIf ciudad = "Veracruz" Then

                RutaPC = "\\192.168.10.101"

            End If

            Dim nuevoFormato As Boolean '@OAVS 26/04/2016

            If Me.TxtNoViaje.Text <> "" Then
                If Me.TxtUnidad.Text <> "" Then

                    Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
                    Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT M.desc_motor, U.no_motor FROM mtto_unidades U (NOLOCK) JOIN trafico_motor M (NOLOCK) ON U.id_tipo_motor = M.id_tipo_motor WHERE U.id_unidad = '" + unidad + "'", oConexion)
                    oCommand.CommandType = CommandType.Text
                    oConexion.Open()
                    oDa = New SqlClient.SqlDataAdapter(oCommand)
                    oDs = New System.Data.DataSet()
                    oDa.Fill(oDs)

                    If oDs.Tables(0).Rows.Count > 0 Then

                        ruta = ""
                        motor = oDs.Tables(0).Rows(0).Item("desc_motor").ToString()

                        If Me.cmbTipoViaje.SelectedItem = "Foraneo" Then

                            unidad = TxtUnidad.Text

                            If oDs.Tables(0).Rows(0).Item("desc_motor").ToString().Contains("CATERPILLAR") Then

                                ruta = RutaPC & "\Reports\CAT\" & Trim(unidad) & " Segmento de viaje - Flota " & Convert.ToString(CInt(TxtNoViaje.Text)) & ".xml"
                                tipotracto = 1

                            Else

                                If oDs.Tables(0).Rows(0).Item("desc_motor").ToString().Contains("CUMMINS") Then

                                    ruta = RutaPC & "\Reports\Cummins\unit-" & Trim(unidad) & "-Trip " & Convert.ToString(CInt(TxtNoViaje.Text)) & ".htm"

                                    If Not File.Exists(ruta) Then

                                        nuevoFormato = True
                                        ruta = RutaPC & "\Reports\Cummins\ISX 07_" & Trim(unidad) & "_" & Convert.ToString(CInt(TxtNoViaje.Text)) & ".html"
                                        'ruta = "C:\Documents and Settings\pablo.montalvo\Escritorio\reseteos\ISX 07_" & Trim(unidad) & "_" & Convert.ToString(CInt(TxtNoViaje.Text)) & ".html"

                                    End If

                                    tipotracto = 2

                                End If
                            End If
                        Else

                            If oDs.Tables(0).Rows(0).Item("desc_motor").ToString().Contains("CATERPILLAR") Then

                                ruta = RutaPC & "\Reports\CAT\" & Trim(unidadc) & " Segmento de viaje - FlotaV " & Convert.ToString(IdCombustible) & ".xml"
                                tipotracto = 1

                            Else

                                If oDs.Tables(0).Rows(0).Item("desc_motor").ToString().Contains("CUMMINS") Then

                                    ruta = RutaPC & "\Reports\Cummins\unit-" & Trim(unidadc) & "-TripV " & Convert.ToString(IdCombustible) & ".htm"

                                    If Not File.Exists(ruta) Then

                                        nuevoFormato = True
                                        ruta = RutaPC & "\Reports\Cummins\ISX 07_" & Trim(unidadc) & "_TripV " & Convert.ToString(IdCombustible) & ".html"
                                        'ruta = "C:\Documents and Settings\pablo.montalvo\Escritorio\reseteos\ISX 07_" & Trim(unidadc) & "_TripV " & Convert.ToString(IdCombustible) & ".html"

                                    End If

                                    tipotracto = 2

                                End If
                            End If
                        End If

                        If tipotracto = 1 Then

                            Me.grdResetCAT.Visible = True
                            Me.grdReset.Visible = False
                            cargaresetCat(ruta)

                        Else

                            Me.grdReset.Visible = True
                            Me.grdResetCAT.Visible = False

                            If Not nuevoFormato Then

                                cargaresetCummins(ruta)

                            Else

                                cargarResetCummins2(ruta)

                            End If
                        End If

                        If Me.TxtLtsReset.Text = "" Or Me.TxtLitrosLis.Text = "" Then

                            MessageBox.Show("La información del Reset")

                        Else

                            If TipoViaje = 1 Then  'Se agrega esta comparacion para validar si es mayor que 25
                                If Abs(CDbl(Me.TxtLtsReset.Text) - CDbl(IIf(Me.TxtLitrosLis.Text = "", 0, Me.TxtLitrosLis.Text))) > 25 Then

                                    MessageBox.Show("La diferencia en litros de SAM y Reset es mayor a 25", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)

                                End If
                            Else
                                If Abs(CDbl(Me.TxtLtsReset.Text) - CDbl(IIf(Me.TxtLitrosLis.Text = "", 0, Me.TxtLitrosLis.Text))) > 20 Then  'Se hace la comparacion para saber si es menor que 20

                                    MessageBox.Show("La diferencia en litros de SAM y Reset es mayor a 20", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)

                                End If
                            End If
                        End If
                    Else

                        MessageBox.Show("El viaje capturado no existe.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
                        Me.TxtNoViaje.Focus()

                    End If
                Else

                    MessageBox.Show("Debe capturar el numero de viaje.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
                    Me.TxtNoViaje.Focus()

                End If
            End If

        Catch ex As System.Exception

            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub

#End Region
#Region "Acciones con el grid de Movimientos"
    Private Sub TxtFecIni_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFecIni.DoubleClick

        If Not String.IsNullOrEmpty(Me.TxtFecIni.Text) Then
            'If Me.cmbArea.SelectedItem = "Veracruz" Then
            '    Dim con As SqlConnection = Connection.getInstance().getConnectionQFS()
            '    Dim command As SqlCommand = New SqlCommand("UP_Consulta_PatioVeracruz", con)
            '    command.CommandType = CommandType.StoredProcedure
            '    con.Open()

            '    Dim parametro As SqlParameter

            '    parametro = command.Parameters.Add("@Unidad", SqlDbType.VarChar)
            '    parametro.Value = Me.TxtUnidad.Text.Trim()

            '    parametro = command.Parameters.Add("@FecIniViaje", SqlDbType.DateTime)
            '    parametro.Value = Me.TxtFecIni.Text.Trim()

            '    parametro = command.Parameters.Add("@FecFinViaje", SqlDbType.DateTime)
            '    parametro.Value = Me.TxtFecFin.Text.Trim()

            '    Dim adaptador As SqlDataAdapter = New SqlDataAdapter(command)
            '    Dim dataSet As DataSet = New DataSet()
            '    adaptador.Fill(dataSet)

            '    Me.gbMovimientos.Visible = True
            '    Me.gbMovimientos.Enabled = True

            '    Dim fechaAnterior As DateTime
            '    Dim fechaActual As DateTime
            '    Dim fechaAux As DateTime

            '    For i As Integer = 1 To dataSet.Tables(0).Rows.Count - 1
            '        fechaAnterior = Convert.ToDateTime(dataSet.Tables(0).Rows(i - 1).Item(0))
            '        fechaActual = Convert.ToDateTime(dataSet.Tables(0).Rows(i).Item(0))
            '        If (fechaActual <= fechaAnterior.AddMinutes(6.0)) Then
            '            dataSet.Tables(0).Rows(i).Item(2) = ""
            '        Else
            '            dataSet.Tables(0).Rows(i - 1).Item(2) = "S"
            '        End If
            '    Next

            '    For i As Integer = 0 To dataSet.Tables(0).Rows.Count - 1
            '        If dataSet.Tables(0).Rows(i).Item(2).Equals("") Then
            '            dataSet.Tables(0).Rows(i).Delete()
            '        End If
            '    Next

            '    Me.grdMovimientos.DataSource = dataSet.Tables(0)
            '    Me.grdMovimientos.Visible = True
            '    Me.gbReset.Visible = False
            '    TipoFecha = 1

            'Else

            Dim unidad As String = ""
            Dim con As SqlConnection = Connection.getInstance().getConnection()
            Dim command As SqlCommand = New SqlCommand("UP_Consulta_Movimientos", con)
            command.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim parametro As SqlParameter

            If Me.TxtUnidad.Text.Substring(0, 1) = "P" Then

                unidad = Me.TxtUnidad.Text.Trim().Insert(2, "0")

            Else

                unidad = Me.TxtUnidad.Text.Trim()

            End If

            parametro = command.Parameters.Add("@Unidad", SqlDbType.VarChar)
            parametro.Value = unidad
            parametro = command.Parameters.Add("@Fecha", SqlDbType.DateTime)
            parametro.Value = fecguia
            Dim adaptador As SqlDataAdapter = New SqlDataAdapter(command)
            Dim dataSet As DataSet = New DataSet()
            adaptador.Fill(dataSet)
            Me.grdMovimientos.DataSource = dataSet.Tables(0)
            Me.gbMovimientos.Visible = True
            Me.gbMovimientos.Enabled = True
            Me.grdMovimientos.Visible = True
            Me.gbReset.Visible = False
            TipoFecha = 1
            'End If
            Me.grdMovimientos.AutoResizeColumns()

        Else

            MessageBox.Show("Ingresa un Rango de Fechas")

        End If
    End Sub

    Private Sub TxtFecFin_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFecFin.DoubleClick

        If Not String.IsNullOrEmpty(Me.TxtFecFin.Text) Then
            'Programación de accesos cuando Veracruz no tenia pistoleos.
            'If Me.cmbArea.SelectedItem = "Veracruz" Then
            '    Dim con As SqlConnection = Connection.getInstance().getConnectionQFS()
            '    Dim command As SqlCommand = New SqlCommand("UP_Consulta_PatioVeracruz", con)
            '    command.CommandType = CommandType.StoredProcedure
            '    con.Open()

            '    Dim parametro As SqlParameter

            '    parametro = command.Parameters.Add("@Unidad", SqlDbType.VarChar)
            '    parametro.Value = Me.TxtUnidad.Text.Trim()

            '    parametro = command.Parameters.Add("@FecIniViaje", SqlDbType.DateTime)
            '    parametro.Value = Me.TxtFecIni.Text.Trim()

            '    parametro = command.Parameters.Add("@FecFinViaje", SqlDbType.DateTime)
            '    parametro.Value = Me.TxtFecFin.Text.Trim()

            '    Dim adaptador As SqlDataAdapter = New SqlDataAdapter(command)
            '    Dim dataSet As DataSet = New DataSet()
            '    adaptador.Fill(dataSet)

            '    Me.gbMovimientos.Visible = True
            '    Me.gbMovimientos.Enabled = True

            '    Dim fechaAnterior As DateTime
            '    Dim fechaActual As DateTime
            '    Dim fechaAux As DateTime

            '    For i As Integer = 1 To dataSet.Tables(0).Rows.Count - 1
            '        fechaAnterior = Convert.ToDateTime(dataSet.Tables(0).Rows(i - 1).Item(0))
            '        fechaActual = Convert.ToDateTime(dataSet.Tables(0).Rows(i).Item(0))
            '        If (fechaActual <= fechaAnterior.AddMinutes(6.0)) Then
            '            dataSet.Tables(0).Rows(i).Item(2) = ""
            '        Else
            '            dataSet.Tables(0).Rows(i - 1).Item(2) = "S"
            '        End If
            '    Next

            '    For i As Integer = 0 To dataSet.Tables(0).Rows.Count - 1
            '        If dataSet.Tables(0).Rows(i).Item(2).Equals("") Then
            '            dataSet.Tables(0).Rows(i).Delete()
            '        End If
            '    Next

            '    Me.grdMovimientos.DataSource = dataSet.Tables(0)
            '    Me.grdMovimientos.Visible = True
            '    Me.gbReset.Visible = False
            '    TipoFecha = 2

            'Else
            Dim con As SqlConnection = Connection.getInstance().getConnection()
            Dim command As SqlCommand = New SqlCommand("UP_Consulta_Movimientos", con)
            Dim unidad As String = ""
            Dim parametro As SqlParameter

            command.CommandType = CommandType.StoredProcedure
            con.Open()

            If Me.TxtUnidad.Text.Substring(0, 1) = "P" Then

                unidad = Me.TxtUnidad.Text.Trim().Insert(2, "0")

            Else

                unidad = Me.TxtUnidad.Text.Trim()

            End If

            parametro = command.Parameters.Add("@Unidad", SqlDbType.VarChar)
            parametro.Value = unidad
            parametro = command.Parameters.Add("@Fecha", SqlDbType.DateTime)
            parametro.Value = fecguia
            Dim adaptador As SqlDataAdapter = New SqlDataAdapter(command)
            Dim dataSet As DataSet = New DataSet()
            adaptador.Fill(dataSet)
            Me.grdMovimientos.DataSource = dataSet.Tables(0)
            Me.gbMovimientos.Visible = True
            Me.gbMovimientos.Enabled = True
            Me.grdMovimientos.Visible = True
            Me.gbReset.Visible = False
            TipoFecha = 2
            'End If
            Me.grdMovimientos.AutoResizeColumns()

        Else

            MessageBox.Show("Ingresa un Rango de Fechas")

        End If
    End Sub

    Private Sub grdMovimientos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMovimientos.CellDoubleClick

        Dim fecfin As Date
        Dim horas As Integer
        Dim index As Integer

        If TipoFecha = 1 Then

            Me.TxtFecIni.Text = grdMovimientos.CurrentRow.Cells("Movim").Value.ToString()
            Me.grdContenedores.Rows.Clear()

            If grdMovimientos.CurrentRow.Cells("Contenedor1").Value.ToString() <> "" Then

                index = Me.grdContenedores.Rows.Add()
                Me.grdContenedores.Rows(index).Cells("Contenedor").Value = grdMovimientos.CurrentRow.Cells("Contenedor1").Value.ToString()
                Me.grdContenedores.Rows(index).Cells("TipoCont").Value = grdMovimientos.CurrentRow.Cells("Tamano1").Value.ToString()

            End If

            If grdMovimientos.CurrentRow.Cells("Contenedor2").Value.ToString() <> "" Then

                index = Me.grdContenedores.Rows.Add()
                Me.grdContenedores.Rows(index).Cells("Contenedor").Value = grdMovimientos.CurrentRow.Cells("Contenedor2").Value.ToString()
                Me.grdContenedores.Rows(index).Cells("TipoCont").Value = grdMovimientos.CurrentRow.Cells("Tamano2").Value.ToString()

            End If

            If grdMovimientos.CurrentRow.Cells("Contenedor11").Value.ToString() <> "" Then

                index = Me.grdContenedores.Rows.Add()
                Me.grdContenedores.Rows(index).Cells("Contenedor").Value = grdMovimientos.CurrentRow.Cells("Contenedor11").Value.ToString()
                Me.grdContenedores.Rows(index).Cells("TipoCont").Value = grdMovimientos.CurrentRow.Cells("Tamano11").Value.ToString()

            End If

            If grdMovimientos.CurrentRow.Cells("Contenedor22").Value.ToString() <> "" Then

                index = Me.grdContenedores.Rows.Add()
                Me.grdContenedores.Rows(index).Cells("Contenedor").Value = grdMovimientos.CurrentRow.Cells("Contenedor22").Value.ToString()
                Me.grdContenedores.Rows(index).Cells("TipoCont").Value = grdMovimientos.CurrentRow.Cells("Tamano22").Value.ToString()

            End If

            Me.grdRemolques.Rows.Clear()

            If grdMovimientos.CurrentRow.Cells("Remolque1").Value.ToString() <> "" Then

                index = Me.grdRemolques.Rows.Add()
                Me.grdRemolques.Rows(index).Cells("Remolque").Value = grdMovimientos.CurrentRow.Cells("Remolque1").Value.ToString()
                Me.grdRemolques.Rows(index).Cells("TipoRem").Value = grdMovimientos.CurrentRow.Cells("TipoRem1").Value.ToString()

            End If

            If grdMovimientos.CurrentRow.Cells("Remolque2").Value.ToString() <> "" Then

                index = Me.grdRemolques.Rows.Add()
                Me.grdRemolques.Rows(index).Cells("Remolque").Value = grdMovimientos.CurrentRow.Cells("Remolque2").Value.ToString()
                Me.grdRemolques.Rows(index).Cells("TipoRem").Value = grdMovimientos.CurrentRow.Cells("TipoRem2").Value.ToString()

            End If

            If Me.TxtFecFin.Text <> "" Then

                horas = DateDiff(DateInterval.Hour, Convert.ToDateTime(Me.TxtFecIni.Text), Convert.ToDateTime(Me.TxtFecFin.Text))

                If horas Mod 24 < 12 Then
                    If horas / 24 > 0 Then

                        Me.TxtTotDias.Text = CInt(horas \ 24)

                    Else

                        Me.TxtTotDias.Text = 1

                    End If
                Else

                    Me.TxtTotDias.Text = CInt((horas \ 24) + 1)

                End If
            End If
        End If

        If TipoFecha = 2 Then

            Me.TxtFecFin.Text = grdMovimientos.CurrentRow.Cells("Movim").Value.ToString()
            fecfin = Convert.ToDateTime(Me.TxtFecFin.Text)

            If fecfin.DayOfWeek = DayOfWeek.Friday Then
                If fecfin.Hour < 8 Then

                    Me.TxtSemana.Text = DatePart(DateInterval.WeekOfYear, fecfin, FirstDayOfWeek.Friday) - 1

                Else

                    Me.TxtSemana.Text = DatePart(DateInterval.WeekOfYear, fecfin, FirstDayOfWeek.Friday)

                End If
            Else

                Me.TxtSemana.Text = DatePart(DateInterval.WeekOfYear, fecfin, FirstDayOfWeek.Friday)

            End If

            horas = DateDiff(DateInterval.Hour, Convert.ToDateTime(Me.TxtFecIni.Text), Convert.ToDateTime(Me.TxtFecFin.Text))

            If horas Mod 24 < 12 Then
                If horas / 24 > 0 Then

                    Me.TxtTotDias.Text = CInt(horas \ 24)

                Else

                    Me.TxtTotDias.Text = 1

                End If
            Else

                Me.TxtTotDias.Text = CInt((horas \ 24) + 1)

            End If

            If Me.grdContenedores.Rows.Count = 0 Then
                If grdMovimientos.CurrentRow.Cells("Contenedor1").Value.ToString() <> "" Then

                    index = Me.grdContenedores.Rows.Add()
                    Me.grdContenedores.Rows(index).Cells("Contenedor").Value = grdMovimientos.CurrentRow.Cells("Contenedor1").Value.ToString()
                    Me.grdContenedores.Rows(index).Cells("TipoCont").Value = grdMovimientos.CurrentRow.Cells("Tamano1").Value.ToString()

                End If

                If grdMovimientos.CurrentRow.Cells("Contenedor2").Value.ToString() <> "" Then

                    index = Me.grdContenedores.Rows.Add()
                    Me.grdContenedores.Rows(index).Cells("Contenedor").Value = grdMovimientos.CurrentRow.Cells("Contenedor2").Value.ToString()
                    Me.grdContenedores.Rows(index).Cells("TipoCont").Value = grdMovimientos.CurrentRow.Cells("Tamano2").Value.ToString()

                End If

                If grdMovimientos.CurrentRow.Cells("Contenedor11").Value.ToString() <> "" Then

                    index = Me.grdContenedores.Rows.Add()
                    Me.grdContenedores.Rows(index).Cells("Contenedor").Value = grdMovimientos.CurrentRow.Cells("Contenedor11").Value.ToString()
                    Me.grdContenedores.Rows(index).Cells("TipoCont").Value = grdMovimientos.CurrentRow.Cells("Tamano11").Value.ToString()

                End If

                If grdMovimientos.CurrentRow.Cells("Contenedor22").Value.ToString() <> "" Then

                    index = Me.grdContenedores.Rows.Add()
                    Me.grdContenedores.Rows(index).Cells("Contenedor").Value = grdMovimientos.CurrentRow.Cells("Contenedor22").Value.ToString()
                    Me.grdContenedores.Rows(index).Cells("TipoCont").Value = grdMovimientos.CurrentRow.Cells("Tamano22").Value.ToString()

                End If
            End If

            If Me.grdRemolques.Rows.Count = 0 Then

                Me.grdRemolques.Rows.Clear()

                If grdMovimientos.CurrentRow.Cells("Remolque1").Value.ToString() <> "" Then

                    index = Me.grdRemolques.Rows.Add()
                    Me.grdRemolques.Rows(index).Cells("Remolque").Value = grdMovimientos.CurrentRow.Cells("Remolque1").Value.ToString()
                    Me.grdRemolques.Rows(index).Cells("TipoRem").Value = grdMovimientos.CurrentRow.Cells("TipoRem1").Value.ToString()

                End If

                If grdMovimientos.CurrentRow.Cells("Remolque2").Value.ToString() <> "" Then

                    index = Me.grdRemolques.Rows.Add()
                    Me.grdRemolques.Rows(index).Cells("Remolque").Value = grdMovimientos.CurrentRow.Cells("Remolque2").Value.ToString()
                    Me.grdRemolques.Rows(index).Cells("TipoRem").Value = grdMovimientos.CurrentRow.Cells("TipoRem2").Value.ToString()

                End If
            End If
        End If

        Me.gbMovimientos.Visible = False
        Me.gbReset.Visible = True

    End Sub
#End Region

    Private Sub grdUnidades_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdUnidades.CellDoubleClick

        Me.TxtUnidad.Text = Me.grdUnidades.Rows(e.RowIndex).Cells("Unidad").Value.ToString()
        unidadc = Me.grdUnidades.Rows(e.RowIndex).Cells("id_unidadC").Value.ToString()
        Me.TxtLitrosLis.Text = Me.grdUnidades.Rows(e.RowIndex).Cells("litros").Value.ToString()
        'Me.grdUnidades.Enabled = False 'wtf?
        IdCombustible = CInt(Me.grdUnidades.Rows(e.RowIndex).Cells("Id_Vale").Value.ToString())
        IdComb = CInt(Me.grdUnidades.Rows(e.RowIndex).Cells("id_combustible").Value.ToString())
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Consulta_KmsViajeLocal", oConexion)
        Dim oParameter As SqlClient.SqlParameter

        Try

            oParameter = oCommand.Parameters.Add("@Viaje", SqlDbType.Int)
            oParameter.Value = CInt(Me.TxtNoViaje.Text)
            oParameter = oCommand.Parameters.Add("@Unidad", SqlDbType.VarChar)
            oParameter.Value = Me.TxtUnidad.Text
            oParameter = oCommand.Parameters.Add("@IdComb", SqlDbType.Int)
            oParameter.Value = IdComb
            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            If CDbl(oDs.Tables(0).Rows(0).Item("km_inicial")) = -1 Then

                Me.TxtKmInicial.Enabled = True
                Me.TxtKmInicial.Focus()
                Me.TxtKmFinal.Text = ""

            Else

                Me.TxtKmInicial.Text = oDs.Tables(0).Rows(0).Item("km_inicial").ToString()
                Me.TxtKmFinal.Enabled = True
                Me.TxtManiobras.Enabled = True
                Me.TxtComplemento.Enabled = True
                Me.TxtObservaciones.Enabled = True

                If oDs.Tables(0).Columns.Count > 1 Then

                    Me.TxtKmFinal.Text = oDs.Tables(0).Rows(0).Item("Km_Final").ToString()
                    Me.TxtKmViaje.Text = Convert.ToString(CDbl(Me.TxtKmFinal.Text) - CDbl(Me.TxtKmInicial.Text))
                    Me.TxtManiobras.Text = oDs.Tables(0).Rows(0).Item("Monto_Maniobras").ToString()
                    Me.TxtLitrosLis.Text = oDs.Tables(0).Rows(0).Item("LitrosLIS").ToString()
                    Me.TxtComplemento.Text = oDs.Tables(0).Rows(0).Item("Complemento").ToString()
                    Me.TxtObservaciones.Text = oDs.Tables(0).Rows(0).Item("Observaciones").ToString()
                    Me.TxtKmFinal.Enabled = False
                    Me.TxtManiobras.Enabled = False
                    Me.TxtComplemento.Enabled = False
                    Me.TxtObservaciones.Enabled = False

                End If
            End If

            btnCargar_Click(sender, e)

        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

#Region "Acciones Combos"
    Private Sub cmbTipoViaje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoViaje.SelectedIndexChanged

        If Me.cmbTipoViaje.SelectedItem = "Foraneo" Then

            Me.TipoViaje = 1

        ElseIf Me.cmbTipoViaje.SelectedItem = "Local" Then

            Me.TipoViaje = 2

        Else

            Me.TipoViaje = 3

        End If
    End Sub

    Private Sub cmbArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.SelectedIndexChanged

        If Me.cmbArea.SelectedItem = "Altamira" Then

            Me.Area = 1

        ElseIf Me.cmbArea.SelectedItem = "Manzanillo" Then

            Me.Area = 2

        ElseIf Me.cmbArea.SelectedItem = "Veracruz" Then

            Me.Area = 3

        End If
    End Sub

    Private Sub cmbConfViaje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConfViaje.SelectedIndexChanged

        If Me.cmbConfViaje.SelectedIndex > 0 Then
            If CType(Me.cmbConfViaje.SelectedItem, TipoViaje).Tipo = "Full-Reparto" AndAlso Me.Area = 2 Then

                Me.ViajeReparto = CInt(TxtNoViaje.Text)

            End If
        End If
    End Sub

    Private Sub getConfiguracionViaje()

        Dim mensaje As TipoViaje = New TipoViaje()
        mensaje.IdTipo = 0
        mensaje.Tipo = "Selecciona un viaje disponible"
        Me.cmbConfViaje.Items.Add(mensaje)

        For Each configViaje As TipoViaje In TipoViajeDAO.getListTiposViaje()

            Me.cmbConfViaje.Items.Add(configViaje)

        Next

        Me.cmbConfViaje.SelectedIndex = 0

    End Sub
#End Region
#Region "Cajas de Texto de Unidad, KM final y Operadores habilitadas"
    Private Sub Label11_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.DoubleClick

        If Me.TxtUnidad.Enabled Then

            Me.TxtUnidad.Enabled = False

        Else

            Me.TxtUnidad.Enabled = True

        End If
    End Sub

    Private Sub Label13_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.DoubleClick

        If Not String.IsNullOrEmpty(Me.TxtNoViaje.Text) Then

            formOperadores.Show()

        Else

            MessageBox.Show("No se puede hacer un cambio de operador si no hay un viaje cargado")

        End If
    End Sub

    Private Sub Label3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.DoubleClick

        Me.TxtKmFinal.Enabled = True

    End Sub
#End Region


#Region "Funciones para Cartas Porte"
    Private Sub btnCPReparto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCPReparto.Click

        Me.addCartasPorte()

    End Sub

    Private Sub btnEliminarCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCP.Click

        If Me.grdCartasPorte.Rows.Count > 0 Then

            Me.deleteCartasPorte(Me.grdCartasPorte.CurrentRow.Cells(0).Value.ToString())
            Me.refreshCartasPorte()

        End If
    End Sub

    Private Sub addCartasPorte()

        If Me.TxtCPReparto.Text <> "" Then

            Dim oDa As SqlClient.SqlDataAdapter
            Dim oDs As System.Data.DataSet
            Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
            Dim oCommand As SqlClient.SqlCommand = _
                New SqlClient.SqlCommand("SELECT DP.observaciones_pedido as [Observaciones],TG.id_area as [Area CP] FROM trafico_guia TG (NOLOCK) JOIN Desp_Pedido DP (NOLOCK) ON TG.id_area = DP.id_area_guia AND TG.no_guia = DP.no_guia  WHERE TG.num_guia ='" + Me.TxtCPReparto.Text + "'", oConexion)
            oCommand.CommandType = CommandType.Text
            oConexion.Open()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then

                Dim dataTable As System.Data.DataTable

                If Me.grdCartasPorte.DataSource Is Nothing Then

                    dataTable = New System.Data.DataTable
                    Dim columnaCP As New DataColumn()
                    columnaCP.ColumnName = "Carta Porte"
                    Dim observaciones As New DataColumn()
                    observaciones.ColumnName = "Observaciones"
                    Dim areaCP As New DataColumn()
                    areaCP.ColumnName = "Area CP"
                    dataTable.Columns.Add(columnaCP)
                    dataTable.Columns.Add(observaciones)
                    dataTable.Columns.Add(areaCP)

                Else

                    dataTable = DirectCast(Me.grdCartasPorte.DataSource, System.Data.DataTable)

                End If

                Dim row As DataRow = dataTable.NewRow()
                row.Item(0) = Me.TxtCPReparto.Text
                row.Item(1) = oDs.Tables(0).Rows(0).Item("Observaciones").ToString()
                row.Item(2) = oDs.Tables(0).Rows(0).Item("Area CP").ToString()
                dataTable.Rows.Add(row)
                Me.grdCartasPorte.DataSource = dataTable
                Me.TxtCPReparto.Text = "CP-"

            Else

                MessageBox.Show("La Carta Porte capturada no existe")
                Me.TxtCPReparto.Focus()

            End If
        Else

            MessageBox.Show("Debe capturar la Carta Porte", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.TxtCPReparto.Focus()

        End If
    End Sub

    Private Sub enlazaCartasPorteAlViaje()

        Me.getCartasPorte()
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("UP_Guarda_CartasPorte", conn)
        oCommand.CommandType = CommandType.StoredProcedure
        conn.Open()
        Dim oParameter As SqlClient.SqlParameter

        For i As Integer = 0 To Me.listaCartasPorte.Count - 1

            oParameter = oCommand.Parameters.Add("@NO_VIAJE", SqlDbType.Int)
            oParameter.Value = Convert.ToInt32(Me.TxtNoViaje.Text.Trim())
            oParameter = oCommand.Parameters.Add("@ID_AREA", SqlDbType.Int)
            oParameter.Value = Me.Area
            oParameter = oCommand.Parameters.Add("@NUM_GUIA", SqlDbType.VarChar)
            oParameter.Value = Me.listaCartasPorte.Item(i).CartaPorte
            oParameter = oCommand.Parameters.Add("@ID_AREACP", SqlDbType.Int)
            oParameter.Value = Me.listaCartasPorte.Item(i).AreaDeCartaPorte
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            oCommand.Parameters.Clear()

        Next

        conn.Close()

    End Sub

    Private Sub getCartasPorte()

        If Me.grdCartasPorte.Rows.Count > 0 Then
            For i As Integer = 0 To Me.grdCartasPorte.Rows.Count - 1

                Dim cartaPorte As New CartaPorte()
                cartaPorte.CartaPorte = Me.grdCartasPorte.Rows(i).Cells(0).Value.ToString()
                cartaPorte.AreaDeCartaPorte = Me.grdCartasPorte.Rows(i).Cells(2).Value.ToString()
                Me.listaCartasPorte.Add(cartaPorte)

            Next
        End If
    End Sub

    Private Sub deleteCartasPorte(ByVal cartaPorte As String)

        Dim consulta As String = "DELETE FROM datosviaje_cartasporte WHERE num_guia = '" & cartaPorte & "' and id_num_viaje = " & Me.TxtNoViaje.Text.Trim() & " and id_area = " & Me.Area.ToString()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand(consulta, conn)
        command.ExecuteNonQuery()
        conn.Close()

    End Sub

    Private Sub refreshCartasPorte()

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim consulta As String = "SELECT DVCP.NUM_GUIA AS [Carta Porte], " & _
                            "DP.OBSERVACIONES_PEDIDO AS [Observaciones], " & _
                            "DVCP.ID_AREACP AS [Area CP] " & _
                            "FROM " & _
                            "DATOSVIAJE_CARTASPORTE DVCP (NOLOCK) " & _
                            "JOIN " & _
                            "TRAFICO_GUIA TG (NOLOCK) " & _
                            "on DVCP.NUM_GUIA = TG.NUM_GUIA and DVCP.ID_AREACP = TG.ID_AREA " & _
                            "JOIN " & _
                            "DESP_PEDIDO DP(NOLOCK) " & _
                            "on TG.NO_GUIA = DP.NO_GUIA and dvcp.id_areacp = dp.id_Area " & _
                            "WHERE " & _
                            "DVCP.ID_NUM_VIAJE =" & Me.TxtNoViaje.Text.Trim() & " AND DVCP.id_areaCP = " & Me.Area.ToString()
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(consulta, conn)
        oCommand.CommandType = CommandType.Text
        conn.Open()
        oDa = New SqlClient.SqlDataAdapter(oCommand)
        oDs = New System.Data.DataSet()
        oDa.Fill(oDs)
        Me.grdCartasPorte.DataSource = oDs.Tables(0)

    End Sub

#End Region
    Private Sub checkLitros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkLitros.CheckedChanged

        If Me.grdUnidades.Rows.Count > 0 Then
            If checkLitros.Checked Then

                Dim litrosTotales As Double = 0.0

                For i As Integer = 0 To Me.grdUnidades.Rows.Count - 1

                    litrosTotales += Convert.ToDouble(Me.grdUnidades.Rows(i).Cells("litros").Value())
                    Me.TxtLitrosLis.Text = Convert.ToString(litrosTotales)

                Next
            Else

                Me.TxtLitrosLis.Text = Convert.ToString(Me.grdUnidades.CurrentRow.Cells("litros").Value())

            End If
        End If
    End Sub

    Private Sub grdUnidades_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdUnidades.SelectionChanged

        If Not Me.checkLitros.Checked Then

            Me.TxtLitrosLis.Text = Convert.ToString(Me.grdUnidades.CurrentRow.Cells("litros").Value())

        End If
    End Sub

    Private Sub Label17_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.DoubleClick

        Me.TxtLitrosLis.Enabled = True

    End Sub

    Private Sub Label18_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.DoubleClick

        Me.TxtLtsReset.Enabled = True

    End Sub

    Private Sub Label19_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.DoubleClick

        Me.TxtComplemento.Enabled = True

    End Sub

    Private Sub Label16_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.DoubleClick

        Me.TxtKmReset.Enabled = True

    End Sub

    Public Sub ObtenerIdPersonal() 'Obtenemos el ID del operador del viaje

        Dim ar As Integer = cmbArea.SelectedIndex + 1
        Dim reg As SqlDataReader
        Dim sql As String = "SELECT id_personal FROM trafico_guia  WHERE no_viaje = " & TxtNoViaje.Text & " AND id_area = " & ar & " GROUP BY id_personal"
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, conn)
        conn.Open()
        oCommand.CommandType = CommandType.Text
        reg = oCommand.ExecuteReader
        oCommand.CommandTimeout = 600

        If reg.HasRows Then

            reg.Read()
            IdPersonal = reg.GetValue(0)

        End If

        conn.Close()

    End Sub

    Public Sub ObtenerTodasLasCp() 'Aqui  obtenemos la relacion de todas las Cp del viaje

        Dim reg As SqlDataReader
        Dim sql As String = "SELECT num_guia from datosviaje_cartasporte WHERE id_num_viaje = " & TxtNoViaje.Text & " AND id_areaCP = " & Me.Area.ToString()
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, conn)
        conn.Open()
        reg = oCommand.ExecuteReader

        While reg.Read

            arra.Add(reg.GetValue(0))

        End While

        conn.Close()

    End Sub

    Public Sub CompararIdPersonales() 'Realizaremos la Validacion si existe un Operador diferente al del viaje

        Dim cont As Integer = 0
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim reg As SqlDataReader
        Dim aux As Integer
        Dim sql As String
        Dim oCommand As SqlClient.SqlCommand
        conn.Open()

        While cont < arra.Count

            sql = "SELECT id_personal FROM trafico_guia WHERE num_guia = '" & arra.Item(cont) & "'"
            oCommand = New SqlClient.SqlCommand(sql, conn)
            reg = oCommand.ExecuteReader
            reg.Read()
            aux = reg.GetValue(0)

            If aux = IdPersonal Then

            Else

                operadores.Add(aux)
                cp.Add(arra.Item(cont))

            End If

            cont = cont + 1
            reg.Close()

        End While

        conn.Close()

        If operadores.Count > 0 Then

            'Me.ArmarCorreo()
            Me.enviarCorreo1()

        End If
    End Sub

    Public Sub ArmarCorreo() 'Envia Correo de C.P Mal asignadas

        Dim cont As Integer = 0
        Dim cont2 As Integer = 0
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim reg As SqlDataReader
        Dim aux As String
        Dim sql As String
        Dim cuerpo As String = "Operador:  " & TxtOperador.Text & vbCr & vbCr & "Viaje: " & TxtNoViaje.Text & vbCr & vbCr & "Entrega C.P:  "
        Dim correos(14) As String
        Dim oCommand As SqlClient.SqlCommand

        correos(0) = "cesar.herver@hinojosa.com.mx"
        correos(1) = "jose.mata@hinojosa.com.mx"
        correos(2) = "diesel.liquidaciones@hinojosa.com.mx"
        correos(3) = "juan.roses@hinojosa.com.mx"
        correos(4) = "laura.reyes@hinojosa.com.mx"
        correos(5) = "ana.perez@hinojosa.com.mx"
        correos(6) = "documentacion.interflet@hinojosa.com.mx"
        correos(7) = "inplant@hinojosa.com.mx"
        correos(8) = "diana.garcia@hinojosa.com.mx"
        correos(9) = "carolina.resendiz@hinojosa.com.mx"
        correos(10) = "Roberto.Hernandez@hinojosa.com.mx"
        correos(11) = "Omar.Velasco@hinojosa.com.mx"
        correos(12) = "Jose.Mata@interflettransport.com"
        correos(13) = "Maciel.DelAngel@hinojosa.com.mx"
        conn.Open()

        While cont2 < arra.Count

            cuerpo = cuerpo & arra.Item(cont2) & "   "
            cont2 = cont2 + 1

        End While

        cuerpo = cuerpo & vbCr & vbCr & "El siguiente(s) operadores esta incorrecto en las siguientes C.P " & vbCr & vbCr

        While cont < operadores.Count

            sql = "SELECT nombre FROM personal_personal WHERE id_personal = " & operadores.Item(cont)
            oCommand = New SqlClient.SqlCommand(sql, conn)
            reg = oCommand.ExecuteReader
            reg.Read()
            aux = reg.GetValue(0)
            cuerpo = cuerpo & "Operador: " & aux & "  Guia: " & cp.Item(cont) & vbCr & vbCr 'Chr(9) &
            cont = cont + 1
            reg.Close()

        End While

        cuerpo = cuerpo & "Liquidaciones Sistema Interflet"
        'objeto.sendEmail("C.P mal asignadas", cuerpo, correos)
        cp.Clear()
        operadores.Clear()

    End Sub

    Public Sub ArmarCorreo2() 'Envia correo de C.P de Valor 0

        Dim enviar As Boolean = False
        Dim cont As Integer = 0
        Dim cont2 As Integer = 0
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim reg As SqlDataReader
        Dim aux As String
        Dim sql As String = ""
        Dim cuerpo As String = "Operador:  " & TxtOperador.Text & vbCr & vbCr & "Viaje: " & TxtNoViaje.Text & vbCr & vbCr & "Entrega C.P:  "
        Dim correos(13) As String
        Dim oCommand As SqlClient.SqlCommand

        correos(0) = "cesar.herver@hinojosa.com.mx"
        correos(1) = "jose.mata@hinojosa.com.mx"
        correos(2) = "diesel.liquidaciones@hinojosa.com.mx"
        correos(3) = "juan.roses@hinojosa.com.mx"
        correos(4) = "laura.reyes@hinojosa.com.mx"
        correos(5) = "ana.perez@hinojosa.com.mx"
        correos(6) = "documentacion.interflet@hinojosa.com.mx"
        correos(7) = "inplant@hinojosa.com.mx"
        correos(8) = "diana.garcia@hinojosa.com.mx"
        correos(9) = "carolina.resendiz@hinojosa.com.mx"
        correos(10) = "Roberto.Hernandez@hinojosa.com.mx"
        correos(11) = "Omar.Velasco@hinojosa.com.mx"
        correos(12) = "Jose.Mata@interflettransport.com"
        conn.Open()

        While cont2 < arra.Count

            cuerpo = cuerpo & arra.Item(cont2) & "   "
            cont2 = cont2 + 1

        End While

        cuerpo = cuerpo & vbCr & vbCr & "Las siguiente(s) C.P se encuentran con Valor de $0.00 " & vbCr & vbCr

        While cont < arra.Count

            sql = "SELECT subtotal FROM trafico_guia WHERE num_guia = '" & arra.Item(cont) & "' AND subtotal = 0"
            oCommand = New SqlClient.SqlCommand(sql, conn)
            reg = oCommand.ExecuteReader
            reg.Read()

            If reg.HasRows Then

                aux = reg.GetValue(0)
                cuerpo = cuerpo & "  Guia: " & arra.Item(cont) & vbCr & vbCr 'Chr(9) &
                enviar = True

            End If

            cont = cont + 1
            reg.Close()

        End While

        conn.Close()
        cuerpo = cuerpo & "Liquidaciones Sistema Interflet"

        If enviar Then

            'objeto2.sendEmail("C.P con Valor 0", cuerpo, correos)

        End If
    End Sub

    Public Sub getOperadores()

        Dim count As Integer = 0
        Dim cp As New ArrayList
        Dim reg As SqlDataReader
        Dim command As SqlCommand
        Dim command2 As SqlCommand
        Dim con As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim sql As String = "SELECT num_guia FROM datosviaje_cartasporte WHERE id_num_viaje = " & TxtNoViaje.Text & " AND id_areaCP = " & Me.Area.ToString()
        con.Open()
        command = New SqlCommand(sql, con)
        reg = command.ExecuteReader

        If reg.HasRows Then

            sql = "('"

            While reg.Read

                sql = sql & reg.GetValue(0) & "','"

            End While

            reg.Close()
            sql = "SELECT pp.nombre FROM trafico_guia tg, personal_personal pp WHERE tg.num_guia in " & sql & "')" & "  and pp.id_personal = tg.id_personal"
            command2 = New SqlCommand(sql, con)
            command2.CommandType = CommandType.Text
            oDa = New SqlClient.SqlDataAdapter(command2)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            grid_operador.DataSource = oDs.Tables(0)

        Else

            reg.Close()
            sql = "SELECT pp.nombre from trafico_guia tg, personal_personal pp WHERE tg.no_viaje = " & TxtNoViaje.Text & " AND tg.id_personal = pp.id_personal"
            command = New SqlCommand(sql, con)
            command.CommandType = CommandType.Text
            oDa = New SqlClient.SqlDataAdapter(command)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            grid_operador.DataSource = oDs.Tables(0)

        End If

        grid_operador.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'grid_operador.AutoResizeColumns = DataGridViewAutoSizeColumnsMode.AllCells
        grid_operador.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        con.Close()

    End Sub

    Public Sub enviarCorreo1() 'Envia Correo de C.P Mal asignadas

        Dim cont As Integer = 0
        Dim cont2 As Integer = 0
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim reg As SqlDataReader
        Dim aux As String
        Dim sql As String
        Dim cuerpo As String = "Operador:  " & TxtOperador.Text & vbCr & vbCr & "Viaje: " & TxtNoViaje.Text & vbCr & vbCr & "Entrega C.P:  "
        Dim oCommand As SqlClient.SqlCommand

        Dim dominio As String = "@hinojosa.com.mx"

        Dim usuarioPara As String
        Dim idPersonalPara As Integer
        'Prueba
        idPersonalPara = 6942 'Omar
        usuarioPara = ObtenerDatosCorreo.nombreUsuario(idPersonalPara)
        usuarioPara = usuarioPara & dominio

        Dim correos As String

        Dim idPersonalParaDiesel As Integer
        Dim usuarioParaDiesel As String
        Dim idPersonalParaMaciel As Integer
        Dim usuarioParaMaciel As String
        Dim idPersonalParaEduardo As Integer
        Dim usuarioParaEduardo As String
        Dim idPersonalParaJuan As Integer
        Dim usuarioParaJuan As String
        Dim idPersonalParaCaro As Integer
        Dim usuarioParaCaro As String
        Dim idPersonalParaDoc As Integer
        Dim usuarioParaDoc As String
        Dim idPersonalParaAna As Integer
        Dim usuarioParaAna As String
        Dim idPersonalParaInplant As Integer
        Dim usuarioParaInplant As String
        Dim idPersonalParaLaura As Integer
        Dim usuarioParaLaura As String

        idPersonalParaDiesel = 10002 'Diesel
        usuarioParaDiesel = ObtenerDatosCorreo.nombreUsuario(idPersonalParaDiesel)
        usuarioParaDiesel = usuarioParaDiesel & dominio

        idPersonalParaMaciel = 10003 'Maciel
        usuarioParaMaciel = ObtenerDatosCorreo.nombreUsuario(idPersonalParaMaciel)
        usuarioParaMaciel = usuarioParaMaciel & dominio

        idPersonalParaEduardo = 10004 'Eduardo
        usuarioParaEduardo = ObtenerDatosCorreo.nombreUsuario(idPersonalParaEduardo)
        usuarioParaEduardo = usuarioParaEduardo & dominio

        idPersonalParaJuan = 10005 'Juan
        usuarioParaJuan = ObtenerDatosCorreo.nombreUsuario(idPersonalParaJuan)
        usuarioParaJuan = usuarioParaJuan & dominio

        idPersonalParaCaro = 283 'Caro
        usuarioParaCaro = ObtenerDatosCorreo.nombreUsuario(idPersonalParaCaro)
        usuarioParaCaro = usuarioParaCaro & dominio

        idPersonalParaDoc = 10007 'Documentación
        usuarioParaDoc = ObtenerDatosCorreo.nombreUsuario(idPersonalParaDoc)
        usuarioParaDoc = usuarioParaDoc & dominio

        idPersonalParaAna = 10008 'Ana
        usuarioParaAna = ObtenerDatosCorreo.nombreUsuario(idPersonalParaAna)
        usuarioParaAna = usuarioParaAna & dominio

        idPersonalParaInplant = 10009 'Implant
        usuarioParaInplant = ObtenerDatosCorreo.nombreUsuario(idPersonalParaInplant)
        usuarioParaInplant = usuarioParaInplant & dominio

        idPersonalParaLaura = 10010 'Laura
        usuarioParaLaura = ObtenerDatosCorreo.nombreUsuario(idPersonalParaLaura)
        usuarioParaLaura = usuarioParaLaura & dominio

        correos = usuarioPara & ";"
        correos += usuarioParaDiesel & "; "
        correos += usuarioParaMaciel & "; "
        correos += usuarioParaEduardo & "; "
        correos += usuarioParaJuan & "; "
        correos += usuarioParaCaro & "; "
        correos += usuarioParaDoc & "; "
        correos += usuarioParaAna & "; "
        correos += usuarioParaInplant & "; "
        correos += usuarioParaLaura & "; "

        'correos = "diesel.liquidaciones@hinojosa.com.mx;"
        'correos += "Maciel.DelAngel@hinojosa.com.mx;"
        'correos += "Eduardo.Gonzalez@hinojosa.com.mx;"
        'correos += "Juan.Hernandez@hinojosa.com.mx;"
        'correos += "carolina.resendiz@hinojosa.com.mx;"
        'correos += "documentacion.interflet@hinojosa.com.mx;"
        'correos += "ana.perez@hinojosa.com.mx;"
        'correos += "Omar.Velasco@hinojosa.com.mx;"
        'correos += "inplant@hinojosa.com.mx;"
        'correos += "laura.reyes@hinojosa.com.mx;"

        conn.Open()

        While cont2 < arra.Count

            cuerpo = cuerpo & arra.Item(cont2) & "   "
            cont2 = cont2 + 1

        End While

        cuerpo = cuerpo & vbCr & vbCr & "El siguiente(s) operadores esta incorrecto en las siguientes C.P " & vbCr & vbCr

        While cont < operadores.Count

            sql = "SELECT nombre FROM personal_personal WHERE id_personal = " & operadores.Item(cont)
            oCommand = New SqlClient.SqlCommand(sql, conn)
            reg = oCommand.ExecuteReader
            reg.Read()
            aux = reg.GetValue(0)
            cuerpo = cuerpo & "Operador: " & aux & "  Guia: " & cp.Item(cont) & vbCr & vbCr 'Chr(9) &
            cont = cont + 1
            reg.Close()

        End While

        cuerpo = cuerpo & "Liquidaciones Sistema Interflet"
        'objeto.sendEmail("C.P mal asignadas", cuerpo, correos)
        Me.setEmailSend("C.P mal asignadas", cuerpo, correos, "", Nothing, Nothing)
        cp.Clear()
        operadores.Clear()

    End Sub

    Public Sub enviarCorreo2() 'Envia correo de C.P de Valor 0

        Dim enviar As Boolean = False
        Dim cont As Integer = 0
        Dim cont2 As Integer = 0
        Dim conn As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim reg As SqlDataReader
        Dim aux As String
        Dim sql As String = ""
        Dim cuerpo As String = "Operador:  " & TxtOperador.Text & vbCr & vbCr & "Viaje: " & TxtNoViaje.Text & vbCr & vbCr & "Entrega C.P:  "
        Dim oCommand As SqlClient.SqlCommand

        Dim dominio As String = "@hinojosa.com.mx"

        Dim usuarioPara As String
        Dim idPersonalPara As Integer
        'Prueba
        idPersonalPara = 6942 'Omar
        usuarioPara = ObtenerDatosCorreo.nombreUsuario(idPersonalPara)
        usuarioPara = usuarioPara & dominio

        Dim correos As String

        Dim idPersonalParaDiesel As Integer
        Dim usuarioParaDiesel As String
        Dim idPersonalParaMaciel As Integer
        Dim usuarioParaMaciel As String
        Dim idPersonalParaEduardo As Integer
        Dim usuarioParaEduardo As String
        Dim idPersonalParaJuan As Integer
        Dim usuarioParaJuan As String
        Dim idPersonalParaCaro As Integer
        Dim usuarioParaCaro As String
        Dim idPersonalParaDoc As Integer
        Dim usuarioParaDoc As String
        Dim idPersonalParaAna As Integer
        Dim usuarioParaAna As String
        Dim idPersonalParaInplant As Integer
        Dim usuarioParaInplant As String
        Dim idPersonalParaLaura As Integer
        Dim usuarioParaLaura As String

        idPersonalParaDiesel = 10002 'Diesel
        usuarioParaDiesel = ObtenerDatosCorreo.nombreUsuario(idPersonalParaDiesel)
        usuarioParaDiesel = usuarioParaDiesel & dominio

        idPersonalParaMaciel = 10003 'Maciel
        usuarioParaMaciel = ObtenerDatosCorreo.nombreUsuario(idPersonalParaMaciel)
        usuarioParaMaciel = usuarioParaMaciel & dominio

        idPersonalParaEduardo = 10004 'Eduardo
        usuarioParaEduardo = ObtenerDatosCorreo.nombreUsuario(idPersonalParaEduardo)
        usuarioParaEduardo = usuarioParaEduardo & dominio

        idPersonalParaJuan = 10005 'Juan
        usuarioParaJuan = ObtenerDatosCorreo.nombreUsuario(idPersonalParaJuan)
        usuarioParaJuan = usuarioParaJuan & dominio

        idPersonalParaCaro = 283 'Caro
        usuarioParaCaro = ObtenerDatosCorreo.nombreUsuario(idPersonalParaCaro)
        usuarioParaCaro = usuarioParaCaro & dominio

        idPersonalParaDoc = 10007 'Documentación
        usuarioParaDoc = ObtenerDatosCorreo.nombreUsuario(idPersonalParaDoc)
        usuarioParaDoc = usuarioParaDoc & dominio

        idPersonalParaAna = 10008 'Ana
        usuarioParaAna = ObtenerDatosCorreo.nombreUsuario(idPersonalParaAna)
        usuarioParaAna = usuarioParaAna & dominio

        idPersonalParaInplant = 10009 'Implant
        usuarioParaInplant = ObtenerDatosCorreo.nombreUsuario(idPersonalParaInplant)
        usuarioParaInplant = usuarioParaInplant & dominio

        idPersonalParaLaura = 10010 'Laura
        usuarioParaLaura = ObtenerDatosCorreo.nombreUsuario(idPersonalParaLaura)
        usuarioParaLaura = usuarioParaLaura & dominio

        correos = usuarioPara & ";"
        correos += usuarioParaDiesel & ";"
        correos += usuarioParaMaciel & ";"
        correos += usuarioParaEduardo & ";"
        correos += usuarioParaJuan & ";"
        correos += usuarioParaCaro & ";"
        correos += usuarioParaDoc & ";"
        correos += usuarioParaAna & ";"
        correos += usuarioParaInplant & ";"
        correos += usuarioParaLaura & ";"

        'correos = "diesel.liquidaciones@hinojosa.com.mx;"
        'correos += "Roberto.Hernandez@hinojosa.com.mx;"
        'correos += "juan.roses@hinojosa.com.mx;"
        'correos += "Juan.Hernandez@hinojosa.com.mx;"
        'correos += "carolina.resendiz@hinojosa.com.mx;"
        'correos += "documentacion.interflet@hinojosa.com.mx;"
        'correos += "ana.perez@hinojosa.com.mx;"
        'correos += "diana.garcia@hinojosa.com.mx;"
        'correos += "Omar.Velasco@hinojosa.com.mx;"
        'correos += "inplant@hinojosa.com.mx;"
        'correos += "laura.reyes@hinojosa.com.mx;"
        conn.Open()

        While cont2 < arra.Count

            cuerpo = cuerpo & arra.Item(cont2) & "   "
            cont2 = cont2 + 1

        End While

        cuerpo = cuerpo & vbCr & vbCr & "Las siguiente(s) C.P se encuentran con Valor de $0.00 " & vbCr & vbCr

        While cont < arra.Count

            sql = "SELECT subtotal FROM trafico_guia WHERE num_guia = '" & arra.Item(cont) & "' AND subtotal = 0"
            oCommand = New SqlClient.SqlCommand(sql, conn)
            reg = oCommand.ExecuteReader
            reg.Read()

            If reg.HasRows Then

                aux = reg.GetValue(0)
                cuerpo = cuerpo & "  Guia: " & arra.Item(cont) & vbCr & vbCr 'Chr(9) &
                enviar = True

            End If

            cont = cont + 1
            reg.Close()

        End While

        conn.Close()
        cuerpo = cuerpo & "Liquidaciones Sistema Interflet"

        If enviar Then

            'objeto2.sendEmail("C.P con Valor 0", cuerpo, correos)
            Me.setEmailSend("C.P con Valor 0", cuerpo, correos, "", Nothing, Nothing)

        End If
    End Sub

    Private Sub setEmailSend(ByVal sSubject As String, ByVal sBody As String, _
    ByVal sTo As String, ByVal sCC As String, _
    ByVal sFilename As String(), ByVal sDisplayname As String())

        Dim oApp As Microsoft.Office.Interop.Outlook._Application
        Dim oMsg As _MailItem
        'Dim strS As String = sFilename
        'Dim strN As String = sDisplayname

        oApp = New Microsoft.Office.Interop.Outlook.Application
        oMsg = oApp.CreateItem(OlItemType.olMailItem)
        oMsg.Subject = sSubject
        oMsg.Body = sBody
        oMsg.To = sTo
        oMsg.CC = sCC

        If sFilename IsNot Nothing AndAlso sFilename.Length > 0 Then

            Dim sBodyLen As Integer = Int(sBody.Length)
            Dim oAttachs As Attachments = oMsg.Attachments
            Dim oAttach As Attachment

            For index As Integer = 0 To sFilename.Length - 2

                oAttach = oAttachs.Add(sFilename(index), , sBodyLen, sDisplayname(index))

            Next
        End If

        oMsg.Send()
        'MessageBox.Show("Email Send", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'KillOutLookProcess()

    End Sub

    Private Sub KillOutLookProcess()

        'Try

        Dim Xcel() As Process = Process.GetProcessesByName("OUTLOOK")

        For Each Process As Process In Xcel

            Process.Kill()

        Next

        'Catch ex As 

        'End Try
    End Sub

    Public Function AppPath()

        Return System.AppDomain.CurrentDomain.BaseDirectory

    End Function

    '@OAVS 26/04/2016

    Private Sub cargarResetCummins2(ByVal archivo As String)

        Dim linea As String = ""
        Dim DatosTabla As Boolean = False
        Dim i, ini, pre, comienzo, fin As Integer

        Try

            If File.Exists(archivo) Then 'el archivo existe como html? si no lo busca como xml 

                FileOpen(1, archivo, OpenMode.Input)

                While (EOF(1) = False)

                    linea = LineInput(1)
                    'MessageBox.Show(archivo)

                    If (InStr(linea, "Engine Type")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Engine Type"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()

                    End If

                    If (InStr(linea, "Ecm Code")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "ECM Code"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Engine Serial Number")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Engine Serial Number"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Software Phase")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Software Phase"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Unit Number")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Unit Number"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (linea.Contains("Extraction Date")) Then

                        linea = LineInput(1)
                        'Me.fechaReset = linea.Substring(109, 24)
                        Me.fechaReset = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    'If (InStr(UCase(linea), ">AVERAGE FUEL ECONOMY")) Then
                    If (InStr(linea, "Overall Fuel Economy")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Average Fuel Economy"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Drive Fuel Economy")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Drive Average Fuel Economy"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Trip Distance")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Trip Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        Me.TxtKmReset.Text = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "% Top Gear Distance")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% Top Gear Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Top Gear Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "% Gear Down Distance")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% Gear Down Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Gear Down Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "% Cruise Control Distance")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% Cruise Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Cruise Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Trip Time")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Trip Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "% Idle Time")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% Idle Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()

                    End If

                    If (InStr(linea, "% Idle Time")) Then

                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Idle Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "% PTOTime")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% PTO Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Maximum Vehicle Speed")) Then

                        linea = LineInput(1)
                        'linea = LineInput(1)
                        'linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Vehicle Speed"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Vehicle Speed"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Maximum Engine Speed")) Then

                        linea = LineInput(1)
                        'linea = LineInput(1)
                        'linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Engine Speed"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Number of Coasts Out of Gear")) Then

                        linea = LineInput(1)
                        'linea = LineInput(1)
                        'linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Number of Coasts Out of Gear"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Sudden Deceleration Counts")) Then

                        linea = LineInput(1)
                        'linea = LineInput(1)
                        'linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Number of Sudden Decelerations"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "Service Brake Actuations / 1Kkm")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Service Brake Actuations/1K"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If
                End While

                FileClose(1)

            End If
        Catch ex As System.Exception

            FileClose(1)

        End Try

        Try

            If File.Exists(archivo.Replace(".html", "") & "_1.html") Then 'el archivo existe como html? si no lo busca como xml 

                FileOpen(1, archivo.Replace(".html", "") & "_1.html", OpenMode.Input)

                While (EOF(1) = False)

                    linea = LineInput(1)

                    'If (InStr(linea, ">Fuel<")) Then

                    '    linea = LineInput(1)
                    '    i = Me.grdReset.Rows.Add()
                    '    Me.grdReset.Rows(i).Cells("desc").Value = "Total Fuel Used"
                    '    Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                    '    linea = LineInput(1)

                    'End If

                    If (InStr(linea, ">Idle Fuel<")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Idle Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Trip<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Trip Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        Me.TxtLtsReset.Text = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Driving<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Drive Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Drive Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Cruise<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Cruise Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Top Gear<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Top Gear Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Top Gear Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Gear Down<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Gear Down Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Gear Down Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">PTO<")) Then

                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "% PTO Non-Moving Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Non-Moving Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()

                    End If

                    If (InStr(linea, ">PTO Moving<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Coast<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Coast Time Out of Gear"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Idle<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Idle Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Trip Vehicle Overspeed 1<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Trip Vehicle Overspeed 2<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Fan On Time Manual Switch<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Fan On Time due to Manual Switch"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Total Engine Distance<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total Engine Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Engine Distance Offset<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Engine Distance Offset"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Total ECM Distance<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total ECM Distance"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Total Fuel Used<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Total Idle Fuel Used<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total Idle Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Total PTO Fuel Used<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total PTO Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Total PTO Fuel Used<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total PTO Fuel Used"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, ">Total PTO Time<")) Then

                        linea = LineInput(1)
                        linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total PTO Time"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split(" ")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If
                End While

                FileClose(1)

            End If
        Catch ex As System.Exception

            FileClose(1)

        End Try

        Try

            If File.Exists(archivo.Replace(".html", "") & "_2.html") Then

                FileOpen(1, archivo.Replace(".html", "") & "_2.html", OpenMode.Input)

                While (EOF(1) = False)

                    linea = LineInput(1)

                    If (InStr(linea, ">Total Engine Hours<")) Then

                        'linea = LineInput(1)
                        'linea = LineInput(1)
                        linea = LineInput(1)
                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "Total Engine Hours"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split("&")(0).TrimEnd().TrimStart().Split(" ")(0)
                        linea = LineInput(1)

                    End If

                    If (InStr(linea, "PowerSpec")) Then

                        i = Me.grdReset.Rows.Add()
                        Me.grdReset.Rows(i).Cells("desc").Value = "PowerSpec Version"
                        Me.grdReset.Rows(i).Cells("val").Value = linea.Split(">")(1).Split("<")(0).Split("v")(1).TrimEnd().TrimStart()
                        linea = LineInput(1)

                    End If
                End While

                FileClose(1)

            End If
        Catch ex As System.Exception

            FileClose(1)

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'If (InStr(UCase(linea), "ENGINE TYPE")) Then

        '    ini = linea.IndexOf("Engine Type")
        '    pre = linea.IndexOf("spc2", ini)
        '    comienzo = linea.IndexOf(">", pre) + 1
        '    fin = linea.IndexOf("<", comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Engine Type"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "ECM CODE")) Then

        '    ini = linea.IndexOf("ECM Code")
        '    pre = linea.IndexOf("spc2", ini)
        '    comienzo = linea.IndexOf(">", pre) + 1
        '    fin = linea.IndexOf("<", comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "ECM Code"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        ''If (InStr(UCase(linea), "LAST TOOL USED")) Then

        ''    ini = linea.IndexOf("Last Tool Used")
        ''    pre = linea.IndexOf("spc2", ini)
        ''    comienzo = linea.IndexOf(">", pre) + 1
        ''    fin = linea.IndexOf("<", comienzo)
        ''    i = Me.grdReset.Rows.Add()
        ''    Me.grdReset.Rows(i).Cells("desc").Value = "Last Tool Used"
        ''    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        ''End If

        'If (InStr(UCase(linea), "ENGINE SERIAL NUMBER")) Then

        '    ini = linea.IndexOf("Engine Serial Number")
        '    pre = linea.IndexOf("spc2", ini)
        '    comienzo = linea.IndexOf(">", pre) + 1
        '    fin = linea.IndexOf("<", comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Engine Serial Number"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "SOFTWARE PHASE")) Then

        '    ini = linea.IndexOf("Software Phase")
        '    pre = linea.IndexOf("spc2", ini)
        '    comienzo = linea.IndexOf(">", pre) + 1
        '    fin = linea.IndexOf("<", comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Software Phase"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        ''If (InStr(UCase(linea), "CUSTOMER NAME")) Then

        ''    ini = linea.IndexOf("Customer Name")
        ''    pre = linea.IndexOf("spc2", ini)
        ''    comienzo = linea.IndexOf(">", pre) + 1
        ''    fin = linea.IndexOf("<", comienzo)
        ''    i = Me.grdReset.Rows.Add()
        ''    Me.grdReset.Rows(i).Cells("desc").Value = "Customer Name"
        ''    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        ''End If

        'If (InStr(UCase(linea), "UNIT NUMBER")) Then

        '    ini = linea.IndexOf("Unit Number")
        '    pre = linea.IndexOf("spc2", ini)
        '    comienzo = linea.IndexOf(">", pre) + 1
        '    fin = linea.IndexOf("<", comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Unit Number"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        ''If (InStr(UCase(linea), "ECM RUNTIME")) Then

        ''    ini = linea.IndexOf("ECM Runtime")
        ''    pre = linea.IndexOf("spc2", ini)
        ''    comienzo = linea.IndexOf(">", pre) + 1
        ''    fin = linea.IndexOf("<", comienzo)
        ''    i = Me.grdReset.Rows.Add()
        ''    Me.grdReset.Rows(i).Cells("desc").Value = "ECM Runtime"
        ''    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        ''End If

        'If (InStr(UCase(linea), "POWERSPEC VERSION")) Then

        '    ini = linea.IndexOf("PowerSpec Version")
        '    pre = linea.IndexOf("spc2", ini)
        '    comienzo = linea.IndexOf(">", pre) + 1
        '    fin = linea.IndexOf("<", comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "PowerSpec Version"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), ">AVERAGE FUEL ECONOMY")) Then

        '    ini = linea.IndexOf("Average Fuel Economy")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Average Fuel Economy"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "DRIVE AVERAGE FUEL ECONOMY")) Then

        '    ini = linea.IndexOf("Drive Average Fuel Economy")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Drive Average Fuel Economy"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "% IDLE TIME")) Then

        '    ini = linea.IndexOf("% Idle Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "% Idle Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "% PTO TIME")) Then

        '    ini = linea.IndexOf("% PTO Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "% PTO Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "% PTO NON-MOVING TIME")) Then

        '    ini = linea.IndexOf("% PTO Non-Moving Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "% PTO Non-Moving Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "% TOP GEAR DISTANCE")) Then

        '    ini = linea.IndexOf("% Top Gear Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "% Top Gear Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "% GEAR DOWN DISTANCE")) Then

        '    ini = linea.IndexOf("% Gear Down Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "% Gear Down Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "% CRUISE DISTANCE")) Then

        '    ini = linea.IndexOf("% Cruise Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "% Cruise Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "MAXIMUM VEHICLE SPEED")) Then

        '    ini = linea.IndexOf("Maximum Vehicle Speed")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Vehicle Speed"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "NUMBER OF SUDDEN DECELERATIONS")) Then

        '    ini = linea.IndexOf("Number of Sudden Decelerations")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Number of Sudden Decelerations"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TRIP DISTANCE")) Then

        '    ini = linea.IndexOf("Trip Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Trip Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)
        '    Me.TxtKmReset.Text = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOTAL ENGINE HOURS")) Then

        '    ini = linea.IndexOf("Total Engine Hours")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Total Engine Hours"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TRIP TIME")) Then

        '    ini = linea.IndexOf("Trip Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Trip Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "DRIVE DISTANCE")) Then

        '    ini = linea.IndexOf("Drive Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Drive Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "CRUISE DISTANCE")) Then

        '    ini = linea.IndexOf("Cruise Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Cruise Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOP GEAR DISTANCE")) Then

        '    ini = linea.IndexOf("Top Gear Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Top Gear Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "GEAR DOWN DISTANCE")) Then

        '    ini = linea.IndexOf("Gear Down Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Gear Down Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "PTO MOVING DISTANCE")) Then

        '    ini = linea.IndexOf("PTO Moving Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "VEHICLE OVERSPEED 1 DISTANCE")) Then

        '    ini = linea.IndexOf("Vehicle Overspeed 1 Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "VEHICLE OVERSPEED 2 DISTANCE")) Then

        '    ini = linea.IndexOf("Vehicle Overspeed 2 Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOP GEAR TIME")) Then

        '    ini = linea.IndexOf("Top Gear Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Top Gear Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "GEAR DOWN TIME")) Then

        '    ini = linea.IndexOf("Gear Down Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Gear Down Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "PTO MOVING TIME")) Then

        '    ini = linea.IndexOf("PTO Moving Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        ''If (InStr(UCase(linea), "PTO NON-MOVING TIME")) Then

        ''    ini = linea.IndexOf("PTO Non-Moving Time")
        ''    pre = linea.IndexOf("isMetric", ini)
        ''    comienzo = linea.IndexOf(Chr(34), pre) + 1
        ''    fin = linea.IndexOf(Chr(34), comienzo)
        ''    i = Me.grdReset.Rows.Add()
        ''    Me.grdReset.Rows(i).Cells("desc").Value = "PTO Non-Moving Time"
        ''    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        ''End If

        'If (InStr(UCase(linea), "IDLE TIME")) Then

        '    ini = linea.IndexOf("Idle Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Idle Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "VEHICLE OVERSPEED 1 TIME")) Then

        '    ini = linea.IndexOf("Vehicle Overspeed 1 Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "VEHICLE OVERSPEED 2 TIME")) Then

        '    ini = linea.IndexOf("Vehicle Overspeed 2 Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "COAST TIME OUT OF GEAR")) Then

        '    ini = linea.IndexOf("Coast Time Out of Gear")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Coast Time Out of Gear"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "FAN ON TIME DUE TO MANUAL SWITCH")) Then

        '    ini = linea.IndexOf("Fan On Time due to Manual Switch")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Fan On Time due to Manual Switch"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TRIP FUEL USED")) Then

        '    ini = linea.IndexOf("Trip Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Trip Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)
        '    Me.TxtLtsReset.Text = linea.Substring(comienzo, fin - comienzo).ToString()

        'End If

        'If (InStr(UCase(linea), "DRIVE FUEL USED")) Then

        '    ini = linea.IndexOf("Drive Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Drive Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "PTO MOVING FUEL USED")) Then

        '    ini = linea.IndexOf("PTO Moving Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "PTO Moving Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        ''If (InStr(UCase(linea), "PTO NON-MOVING FUEL USED")) Then

        ''    ini = linea.IndexOf("PTO Non-Moving Fuel Used")
        ''    pre = linea.IndexOf("isMetric", ini)
        ''    comienzo = linea.IndexOf(Chr(34), pre) + 1
        ''    fin = linea.IndexOf(Chr(34), comienzo)
        ''    i = Me.grdReset.Rows.Add()
        ''    Me.grdReset.Rows(i).Cells("desc").Value = "PTO Non-Moving Fuel Used"
        ''    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        ''End If

        'If (InStr(UCase(linea), ">IDLE FUEL USED")) Then

        '    ini = linea.IndexOf("Idle Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Idle Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "VEHICLE OVERSPEED 1 FUEL USED")) Then

        '    ini = linea.IndexOf("Vehicle Overspeed 1 Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 1 Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "VEHICLE OVERSPEED 2 FUEL USED")) Then

        '    ini = linea.IndexOf("Vehicle Overspeed 2 Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Vehicle Overspeed 2 Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "SERVICE BRAKE ACTUATIONS / 1K")) Then

        '    ini = linea.IndexOf("Service Brake Actuations / 1K")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Service Brake Actuations/1K"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "NUMBER OF COASTS OUT OF GEAR")) Then

        '    ini = linea.IndexOf("Number of Coasts Out of Gear")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Number of Coasts Out of Gear"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "MAXIMUM ENGINE SPEED")) Then

        '    ini = linea.IndexOf("Maximum Engine Speed")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Engine Speed"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "MAXIMUM VEHICLE SPEED")) Then

        '    ini = linea.IndexOf("Maximum Vehicle Speed")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Maximum Vehicle Speed"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOTAL ENGINE DISTANCE")) Then

        '    ini = linea.IndexOf("Total Engine Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Total Engine Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "ENGINE DISTANCE OFFSET")) Then

        '    ini = linea.IndexOf("Engine Distance Offset")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Engine Distance Offset"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOTAL ECM DISTANCE")) Then

        '    ini = linea.IndexOf("Total ECM Distance")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Total ECM Distance"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOTAL FUEL USED")) Then

        '    ini = linea.IndexOf("Total Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Total Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOTAL IDLE FUEL USED")) Then

        '    ini = linea.IndexOf("Total Idle Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Total Idle Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOTAL PTO FUEL USED")) Then

        '    ini = linea.IndexOf("Total PTO Fuel Used")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Total PTO Fuel Used"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If

        'If (InStr(UCase(linea), "TOTAL PTO TIME")) Then

        '    ini = linea.IndexOf("Total PTO Time")
        '    pre = linea.IndexOf("isMetric", ini)
        '    comienzo = linea.IndexOf(Chr(34), pre) + 1
        '    fin = linea.IndexOf(Chr(34), comienzo)
        '    i = Me.grdReset.Rows.Add()
        '    Me.grdReset.Rows(i).Cells("desc").Value = "Total PTO Time"
        '    Me.grdReset.Rows(i).Cells("val").Value = linea.Substring(comienzo, fin - comienzo)

        'End If
        '        End While

        '        FileClose(1)

        '    End If
        'Catch ex As System.Exception

        '    FileClose(1)

        'End Try
    End Sub

    
End Class