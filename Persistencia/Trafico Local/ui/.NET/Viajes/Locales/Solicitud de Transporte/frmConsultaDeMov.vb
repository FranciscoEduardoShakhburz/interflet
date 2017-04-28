Imports System.Data.SqlClient
Public Class frmConsultaDeMov
    Dim cn As New SqlConnection
    Private Sub bto_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_consultar.Click
        Time.Stop()

        If txt_unidad.Text = "0" Then

            Me.BuscarXFechas()

        Else

            Me.BuscarXUnidadXFecha()

        End If
    End Sub

    Private Sub frmConsultaDeMov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cn = Connection.getInstance().getConnection()
        cmb_movimiento.SelectedIndex = 0 ' 0 es traslado

    End Sub

    Public Sub BuscarXUnidadXFecha()

        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim sql As String = "SELECT fecha_salida_a_terminal,fecha_ingreso_terminal,fecha_salida_terminal,fecha_ingreso_carga_dah, unidad FROM trafico_local_seguimiento2 WHERE fecha_ingreso_terminal >= '" & dtp_de.Value.ToString() & "' AND " & " fecha_salida_terminal <= '" & DateTimePicker1.Value.ToString() & "' AND unidad = '" & txt_unidad.Text & "'"
        Dim command As SqlCommand = New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        command.CommandTimeout = 600
        cn.Open()
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.grid_datos.DataSource = oDs.Tables(0)
        cn.Close()

    End Sub

    Public Sub BuscarXFechas()

        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim sql As String = "SELECT fecha_salida_a_terminal,fecha_ingreso_terminal,fecha_salida_terminal,fecha_ingreso_carga_dah, unidad FROM trafico_local_seguimiento2 WHERE fecha_ingreso_terminal >= '" & dtp_de.Value.ToString() & "' AND " & " fecha_salida_terminal <= '" & DateTimePicker1.Value.ToString() & "'"
        Dim command As SqlCommand = New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        command.CommandTimeout = 600
        cn.Open()
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.grid_datos.DataSource = oDs.Tables(0)
        cn.Close()

    End Sub

    Private Sub bto_automatico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_automatico.Click

        Time.Start()

    End Sub

    Public Sub Automatico()

        Dim command As SqlCommand
        cn.Open()

        If cmb_movimiento.SelectedIndex = 0 Then

            command = New SqlCommand("up_busqueda_traslado_satelital", cn)
            command.CommandType = CommandType.StoredProcedure
            command.CommandTimeout = 6000
            command.ExecuteNonQuery()

        End If

        cn.Close()

    End Sub

    Private Sub Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time.Tick

        Me.Automatico()
        Me.GetTodosLosTrasaladosPendientes()

    End Sub

    Public Sub GetTodosLosTrasaladosPendientes()

        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim sql As String = "select fecha_salida_a_terminal,fecha_ingreso_terminal,fecha_salida_terminal,fecha_ingreso_carga_dah from trafico_local_seguimiento2 where estatus_general = 2 and est_fecha_ingreso_carga_dah = 1"
        Dim command As SqlCommand = New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        command.CommandTimeout = 600
        cn.Open()
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.grid_datos.DataSource = oDs.Tables(0)
        cn.Close()

    End Sub

    Private Sub bto_ahora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_ahora.Click

        Cursor = Cursors.WaitCursor
        Me.Automatico()
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim sql As String = "select fecha_salida_a_terminal,fecha_ingreso_terminal,fecha_salida_terminal,fecha_ingreso_carga_dah,unidad from trafico_local_seguimiento2 where estatus_general = 2 and est_fecha_ingreso_carga_dah = 1"
        Dim command As SqlCommand = New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        command.CommandTimeout = 600
        cn.Open()
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.grid_datos.DataSource = oDs.Tables(0)
        cn.Close()
        Cursor = Cursors.Arrow

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()

    End Sub
End Class