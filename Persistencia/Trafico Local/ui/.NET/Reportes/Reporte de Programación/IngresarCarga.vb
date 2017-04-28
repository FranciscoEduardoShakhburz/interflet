Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class IngresarCarga

    Public generar As GenerarPrograma

    Public Sub New(ByRef generar As GenerarPrograma)

        Me.InitializeComponent()
        Me.generar = generar

    End Sub


    Private Sub IngresarCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.resultadosDeBusquedaTerminal()
        Me.resultadosDeBusquedaAgencia()
        Me.resultadosDeBusquedaCliente()
        Me.resultadosDeBusquedaDestino()
        Me.cmbViaja.SelectedIndex = 0
        Me.cmbDesc.SelectedIndex = 0
        Me.cmbTipo1.SelectedIndex = 0

    End Sub

    Private Sub resultadosDeBusquedaAgencia()

        Dim autoCompletado As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre_agencia_aduanal FROM trafico_local_agencia_aduanal"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtAgencia.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAgencia.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAgencia.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub resultadosDeBusquedaTerminal()

        Dim autoCompletado As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre_terminal FROM trafico_local_terminal"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtTerminal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtTerminal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtTerminal.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub resultadosDeBusquedaCliente()

        Dim autoCompletado As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre FROM trafico_cliente"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCliente.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub resultadosDeBusquedaDestino()

        Dim autoCompletado As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT desc_plaza FROM trafico_plaza"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtDestino.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtDestino.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtDestino.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim contenedor As DataGridViewRow
        Dim info As List(Of String)

        For i As Integer = 0 To Me.gridContenedores.Rows.Count - 2

            contenedor = Me.gridContenedores.Rows(i)

            If contenedor.Cells(0).Value IsNot Nothing And contenedor.Cells(1).Value IsNot Nothing And contenedor.Cells(2).Value IsNot Nothing Then

                info = New List(Of String)
                info.Add(Me.txtTipoProg.Text)
                info.Add(Me.txtTerminal.Text)
                info.Add(Me.txtAgencia.Text)
                info.Add(Me.txtCliente.Text)
                info.Add(contenedor.Cells(1).Value)
                info.Add(contenedor.Cells(0).Value)
                info.Add(contenedor.Cells(2).Value)
                info.Add(Me.cmbViaja.SelectedItem.ToString())
                info.Add(Me.cmbDesc.SelectedItem.ToString())
                info.Add(Me.cmbTipo1.SelectedItem.ToString())
                info.Add(Me.txtEntrega2.Text)
                info.Add(Me.txtDestino.Text)
                info.Add(Me.dteDemora.Value.ToString("dd/MM/yyyy"))
                info.Add(Me.dteAlmacenaje.Value.ToString("dd/MM/yyyy"))
                info.Add(Me.dtePTA.Value.ToString("dd/MM/yyyy"))
                info.Add(Me.rTxtObservaciones.Text)
                Me.generar.fijarInfoAgenciaExt(info)

            End If
        Next

        Me.resetControles()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub txtTipoProg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoProg.KeyDown, txtTerminal.KeyDown, txtEntrega2.KeyDown, txtDestino.KeyDown, txtCliente.KeyDown, txtAgencia.KeyDown, rTxtObservaciones.KeyDown, dtePTA.KeyDown, dteDemora.KeyDown, dteAlmacenaje.KeyDown, cmbViaja.KeyDown, cmbTipo1.KeyDown, cmbDesc.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub

    Private Sub resetControles()

        Me.txtTipoProg.Text = ""
        Me.txtTerminal.Text = ""
        Me.txtAgencia.Text = ""
        Me.txtCliente.Text = ""
        Me.cmbViaja.SelectedIndex = 0
        Me.cmbDesc.SelectedIndex = 0
        Me.cmbTipo1.SelectedIndex = 0
        Me.txtEntrega2.Text = ""
        Me.txtDestino.Text = ""
        Me.dteDemora.Value = Date.Today
        Me.dteAlmacenaje.Value = Date.Today
        Me.dtePTA.Value = Date.Today
        Me.rTxtObservaciones.Text = ""
        Me.gridContenedores.Rows.Clear()

    End Sub
End Class