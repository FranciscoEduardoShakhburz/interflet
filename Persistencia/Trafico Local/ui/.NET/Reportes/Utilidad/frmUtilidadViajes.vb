Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Threading
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.IO

Public Class frmUtilidadViajes

    Dim bandera As Boolean = False
    Public ciudad As Integer = 0
    Dim t As Thread

#Region "Constructor"
    Private Sub frmUtilidadViajes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Limpiar()
        Me.cmbOficina.SelectedItem = "Oficina Altamira"
        Me.grdUtilidadViaje.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.getConfiguracionViaje()

    End Sub
#End Region

#Region "Exportar"
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor.Current = Cursors.WaitCursor
        Excel.gridToExcel(Me.grdUtilidadViaje)
        Cursor.Current = Cursors.Arrow

    End Sub
#End Region

    Private Sub Limpiar()

        Me.TxtViaje.Text = "0"
        Me.TxtCliente.Text = ""
        Me.cmbFecIni.Value = DateTime.Today
        Me.cmbFecFin.Value = DateTime.Today
        Me.TxtSemana.Text = "0"

    End Sub

    Private Sub cmbOficina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOficina.SelectedIndexChanged

        If Me.cmbOficina.SelectedItem = "Oficina Altamira" Then

            Me.ciudad = 1

        ElseIf cmbOficina.SelectedItem = "Oficina Manzanillo" Then

            Me.ciudad = 2

        ElseIf cmbOficina.SelectedItem = "Oficina Veracruz" Then

            Me.ciudad = 3

        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.Cursor = Cursors.WaitCursor
        Me.grdUtilidadViaje.DataSource = Nothing
        Dim oConexion As SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlCommand = New SqlCommand("UP_Consulta_UtilidadReal", oConexion)
        oCommand.CommandTimeout = 1000
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Try

            Dim oParameter As SqlParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = Conversions.ToInteger(Me.TxtViaje.Text)
            oParameter = oCommand.Parameters.Add("@Cliente", SqlDbType.VarChar)
            oParameter.Value = Me.TxtCliente.Text
            oParameter = oCommand.Parameters.Add("@Semana", SqlDbType.Int)
            oParameter.Value = Conversions.ToInteger(Me.TxtSemana.Text)
            oParameter = oCommand.Parameters.Add("@FecIni", SqlDbType.DateTime)
            oParameter.Value = Me.cmbFecIni.Value
            oParameter = oCommand.Parameters.Add("@FecFin", SqlDbType.DateTime)
            oParameter.Value = Me.cmbFecFin.Value
            oParameter = oCommand.Parameters.Add("@Operador", SqlDbType.VarChar)
            oParameter.Value = Me.TxtOperador.Text
            oParameter = oCommand.Parameters.Add("@Area", SqlDbType.Int)
            oParameter.Value = Me.ciudad
            oParameter = oCommand.Parameters.Add("@CartaPorte", SqlDbType.VarChar)
            oParameter.Value = Me.txtCartaPorte.Text.Trim()
            oParameter = oCommand.Parameters.Add("@CONFIGVIAJE", SqlDbType.Int)
            oParameter.Value = DirectCast(Me.cmbConfigViaje.SelectedItem(), TipoViaje).IdTipo
            oParameter = oCommand.Parameters.Add("@JUSTIFICACION", SqlDbType.VarChar)
            oParameter.Value = Me.txtJustificacion.Text.Trim
            oParameter = oCommand.Parameters.Add("@TIPO_BUSQUEDA", SqlDbType.Int)
            oParameter.Value = 1
            Dim oDa As SqlDataAdapter = New SqlDataAdapter(oCommand)
            Dim oDs As DataSet = New DataSet()
            oDa.Fill(oDs)
            Me.grdUtilidadViaje.DataSource = oDs.Tables(0)
            Me.grdUtilidadViaje.Columns(8).Visible = True

            For i As Integer = 10 To 21

                Me.grdUtilidadViaje.Columns(i).Visible = True

            Next

            Me.grdUtilidadViaje.AutoResizeColumns()
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString())

        End Try

        Cursor.Current = Cursors.Arrow

    End Sub

#Region "Configuración de Viaje"
    Private Sub getConfiguracionViaje()
        Dim mensaje As TipoViaje = New TipoViaje()
        mensaje.IdTipo = 0
        mensaje.Tipo = "Todos"
        Me.cmbConfigViaje.Items.Add(mensaje)
        For Each configViaje As TipoViaje In TipoViajeDAO.getListTiposViaje()
            Me.cmbConfigViaje.Items.Add(configViaje)
        Next
        Me.cmbConfigViaje.SelectedIndex = 0
    End Sub
#End Region

    Private Sub btnGlobalMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlobalMap.Click
        Cursor = Cursors.WaitCursor
        If Me.grdUtilidadViaje.Rows.Count > 0 Then

            Dim conn As SqlConnection = Connection.getInstance().getConnectionQFS()

            Dim unidad As String = ""
            Dim fechaInicial As DateTime
            Dim fechaFinal As DateTime

            conn.Open()

            For i As Integer = 0 To Me.grdUtilidadViaje.Rows.Count - 1
                Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_LATITUD_LONGITUD", conn)
                command.CommandType = CommandType.StoredProcedure

                unidad = Me.grdUtilidadViaje.Rows(i).Cells(0).Value.ToString()
                fechaInicial = Convert.ToDateTime(Me.grdUtilidadViaje.Rows(i).Cells(2).Value)
                fechaFinal = Convert.ToDateTime(Me.grdUtilidadViaje.Rows(i).Cells(3).Value)

                command.Parameters.AddWithValue("@UNIDAD", unidad)
                command.Parameters.AddWithValue("@FECHA_INICIAL", fechaInicial)
                command.Parameters.AddWithValue("@FECHA_FINAL", fechaFinal)

                Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
                Dim table As DataTable = New DataTable()
                adapter.Fill(table)

                Excel.gridToExcel(table, Me.grdUtilidadViaje.Rows(i).Cells(5).Value.ToString())

            Next
            conn.Close()
            MessageBox.Show("Viajes Exportados")
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumen.Click

        Cursor = Cursors.WaitCursor

        If Me.grdUtilidadViaje.Rows.Count > 0 Then

            Dim command As SqlCommand
            Dim conn As SqlConnection
            'conn.Open()
            Dim dataset_principal As DataSet = New DataSet()
            Dim dataset_viaje As DataSet
            Dim adapter As SqlDataAdapter
            Dim contador As Integer = 0
            For Each row As DataGridViewRow In Me.grdUtilidadViaje.Rows

                conn = Connection.getInstance().getConnection()
                command = New SqlCommand("UP_CONSULTA_RESUMEN_UTILIDAD", conn)
                command.CommandTimeout = 1000
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@ID_VIAJE", row.Cells("Viaje").Value.ToString())
                command.Parameters.AddWithValue("@ID_AREA", Me.ciudad)
                adapter = New SqlDataAdapter(command)
                conn.Open()
                dataset_viaje = New DataSet()
                adapter.Fill(dataset_viaje)
                dataset_principal.Merge(dataset_viaje)
                conn.Close()
                conn.Dispose()
                command.Dispose()
                
            Next

            '2017/03/04 @OAVS Se eliminan los viajes duplicados antes de exportar a excel.
            Me.eliminarFilasDuplicadas(dataset_principal.Tables(0), "PROM. UTILIDAD SIN DESCTO")
            Me.eliminarFilasDuplicadas(dataset_principal.Tables(1), "ID_NUM_VIAJE")
            Excel.datasetToExcelUtilidad(dataset_principal)

        End If

        Cursor = Cursors.Arrow

    End Sub


    Public Sub metodo()

        Dim cliente As String = ""
        Dim configuracion As String = ""
        Dim destino As String = ""
        Dim value1 As String = ""
        Dim value2 As String = ""
        Dim value3 As String = ""
        Dim fil As Integer
        Dim fil2 As Integer = 0
        Dim array As New ArrayList

        fil = grdUtilidadViaje.Rows.Count

        fil = fil - 1

        For i As Integer = 0 To fil

            Me.grdUtilidadViaje.CurrentCell = grdUtilidadViaje.Rows(i).Cells(1)
            cliente = Me.grdUtilidadViaje.CurrentCell.Value
            Me.grdUtilidadViaje.CurrentCell = grdUtilidadViaje.Rows(i).Cells(4)
            configuracion = Me.grdUtilidadViaje.CurrentCell.Value
            Me.grdUtilidadViaje.CurrentCell = grdUtilidadViaje.Rows(i).Cells(8)
            destino = Me.grdUtilidadViaje.CurrentCell.Value

            For j As Integer = i + 1 To fil

                Me.grdUtilidadViaje.CurrentCell = grdUtilidadViaje.Rows(j).Cells(1)
                value1 = Me.grdUtilidadViaje.CurrentCell.Value
                Me.grdUtilidadViaje.CurrentCell = grdUtilidadViaje.Rows(j).Cells(4)
                value2 = Me.grdUtilidadViaje.CurrentCell.Value
                Me.grdUtilidadViaje.CurrentCell = grdUtilidadViaje.Rows(j).Cells(8)
                value3 = Me.grdUtilidadViaje.CurrentCell.Value
                If String.Equals(value1, cliente) And String.Equals(value2, configuracion) And String.Equals(value3, destino) Then
                    array.Add(i)


                    Exit For
                End If
            Next
        Next


        For x As Integer = array.Count - 1 To 0 Step -1

            Me.grdUtilidadViaje.Rows.RemoveAt(array.Item(x))

        Next
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bandera = True
        Me.Cursor = Cursors.WaitCursor
        Me.grdUtilidadViaje.DataSource = Nothing
        Dim oConexion As SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlCommand = New SqlCommand("UP_Consulta_UtilidadReal", oConexion)
        oCommand.CommandTimeout = 300
        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        Try
            Dim oParameter As SqlParameter = oCommand.Parameters.Add("@NoViaje", SqlDbType.Int)
            oParameter.Value = Conversions.ToInteger(Me.TxtViaje.Text)
            oParameter = oCommand.Parameters.Add("@Cliente", SqlDbType.VarChar)
            oParameter.Value = Me.TxtCliente.Text
            oParameter = oCommand.Parameters.Add("@Semana", SqlDbType.Int)
            oParameter.Value = Conversions.ToInteger(Me.TxtSemana.Text)
            oParameter = oCommand.Parameters.Add("@FecIni", SqlDbType.DateTime)
            oParameter.Value = Me.cmbFecIni.Value
            oParameter = oCommand.Parameters.Add("@FecFin", SqlDbType.DateTime)
            oParameter.Value = Me.cmbFecFin.Value
            oParameter = oCommand.Parameters.Add("@Operador", SqlDbType.VarChar)
            oParameter.Value = Me.TxtOperador.Text
            oParameter = oCommand.Parameters.Add("@Area", SqlDbType.Int)
            oParameter.Value = Me.ciudad
            oParameter = oCommand.Parameters.Add("@CartaPorte", SqlDbType.VarChar)
            oParameter.Value = Me.txtCartaPorte.Text.Trim()
            oParameter = oCommand.Parameters.Add("@CONFIGVIAJE", SqlDbType.Int)
            oParameter.Value = DirectCast(Me.cmbConfigViaje.SelectedItem(), TipoViaje).IdTipo
            oParameter = oCommand.Parameters.Add("@JUSTIFICACION", SqlDbType.VarChar)
            oParameter.Value = Me.txtJustificacion.Text.Trim

            Dim oDa As SqlDataAdapter = New SqlDataAdapter(oCommand)
            Dim oDs As DataSet = New DataSet()
            oDa.Fill(oDs)

            Me.grdUtilidadViaje.DataSource = oDs.Tables(0)
            Me.metodo()
            Me.grdUtilidadViaje.Columns(8).Visible = True
            For i As Integer = 10 To 21
                Me.grdUtilidadViaje.Columns(i).Visible = True
            Next
            Me.grdUtilidadViaje.AutoResizeColumns()

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception


        End Try
    End Sub


    Private Sub grdUtilidadViaje_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdUtilidadViaje.SelectionChanged

        If ch_historico.Checked Then
            Cursor = Cursors.WaitCursor
            Dim oDs As DataSet
            Dim oDa As SqlDataAdapter
            Dim cn As SqlConnection = Connection.getInstance.getConnection
            Dim command As New SqlCommand("UP_Consulta_UtilidadReal3", cn)
            command.CommandType = CommandType.StoredProcedure
            Dim viaje As String = Me.grdUtilidadViaje.CurrentRow.Cells("Viaje").Value.ToString()
            cn.Open()
            command.Parameters.AddWithValue("@NOVIAJE", viaje)
            command.Parameters.AddWithValue("@TIPO_BUSQUEDA", 1)
            command.Parameters.AddWithValue("@AREA", Me.ciudad)
            command.Parameters.AddWithValue("@FecIni", Me.cmbFecIni.Value)
            command.Parameters.AddWithValue("@FecFin", Me.cmbFecFin.Value)
            command.CommandTimeout = 600
            oDa = New SqlClient.SqlDataAdapter(command)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            Me.grid.DataSource = oDs.Tables(0)
            Cursor = Cursors.Arrow
        End If

    End Sub

    Private Sub grdUtilidadViaje_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdUtilidadViaje.CellContentDoubleClick
        Cursor = Cursors.WaitCursor

        Dim viaje As String = Me.grdUtilidadViaje.Rows(e.RowIndex).Cells("Viaje").Value.ToString()
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_Consulta_UtilidadReal", conn)
        conn.Open()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@NOVIAJE", viaje)
        command.Parameters.AddWithValue("@TIPO_BUSQUEDA", 1)
        command.Parameters.AddWithValue("@AREA", Me.ciudad)
        command.Parameters.AddWithValue("@FecIni", Me.cmbFecIni.Value)
        command.Parameters.AddWithValue("@FecFin", Me.cmbFecFin.Value)
        command.CommandTimeout = 600

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)

        Dim table As DataTable = New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            frmDetalleUtilidad.lblCliente.Text = table.Rows(0).Item("Cliente").ToString()
            frmDetalleUtilidad.lblConfiguracion.Text = table.Rows(0).Item("Config. de Viaje").ToString()
            frmDetalleUtilidad.lblDestino.Text = table.Rows(0).Item("Destino").ToString()
        Else
            frmDetalleUtilidad.lblCliente.Text = ""
            frmDetalleUtilidad.lblConfiguracion.Text = ""
            frmDetalleUtilidad.lblDestino.Text = ""
        End If


        frmDetalleUtilidad.gridHistorico.DataSource = table
        frmDetalleUtilidad.Show()
        Cursor = Cursors.Arrow

    End Sub


    Private Sub bto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_guardar.Click

        Cursor.Current = Cursors.WaitCursor

        If grdUtilidadViaje.Rows.Count > 0 Then

            Dim cn As SqlConnection = Connection.getInstance.getConnection
            Dim i As Integer = 0
            cn.Open()

            While grdUtilidadViaje.Rows.Count > i

                Dim command As New SqlCommand("up_insert_obsUtilidad", cn)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@viaje", grdUtilidadViaje.Rows(i).Cells(5).Value)
                command.Parameters.AddWithValue("@area", ciudad)
                command.Parameters.AddWithValue("@observaciones", grdUtilidadViaje.Rows(i).Cells(32).Value.ToString)
                command.Parameters.AddWithValue("@departamento", grdUtilidadViaje.Rows(i).Cells(33).Value.ToString)
                command.ExecuteNonQuery()
                i = i + 1

            End While

            cn.Close()
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Proceso Terminado")

        Else

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Debe Haber Datos En El Grid")

        End If
    End Sub

    Private Sub eliminarFilasDuplicadas(ByRef dT As DataTable, ByVal nomCol As String)

        Dim hT As Hashtable
        Dim duplicados As ArrayList

        hT = New Hashtable()
        duplicados = New ArrayList()

        For Each fila As DataRow In dT.Rows
            If hT.Contains(fila(nomCol)) Then

                duplicados.Add(fila)

            Else

                hT.Add(fila(nomCol), String.Empty)

            End If
        Next

        For Each fila As DataRow In duplicados

            dT.Rows.Remove(fila)

        Next
    End Sub
End Class