Imports System.Data
Imports System.Data.SqlClient

Public Class CaptSeguimientoEmbarques

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal unidad As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.txtEco.Text = unidad
        Me.consultarInformacion()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub CaptContenedoresEnViaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cmbStatus.SelectedIndex = 0
        Me.cmbMercancia.SelectedIndex = 0
        Me.resultadosDeBusquedaCliente()

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

        conexion.Close()
        conexion.Dispose()
        comando.Dispose()
        Me.txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCliente.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sql As String

        Try

            sql = "DECLARE @id INT SET @id = (SELECT TOP(1) idReporte FROM trafico_contenedores_viaje WHERE fechaReporte = CONVERT(VARCHAR(20),GETDATE(),103)) UPDATE trafico_contenedores_viaje_detalle SET eco = '" & Me.txtEco.Text & "', cel = '" & Me.txtCel.Text & "', operador = '" & Me.txtOperador.Text & "', cliente = '" & Me.txtCliente.Text & "', referencia = '" & Me.txtReferencia.Text & "', contenedor = '" & Me.txtContenedor.Text & "', destino = '" & Me.txtDestino.Text & "', [status] = '" & Me.cmbStatus.SelectedItem & "', comentarios = '" & Me.txtComentarios.Text & "' WHERE eco = '" & Me.txtEco.Text & "' AND idReporte = @id"
            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 500
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
            Me.inicializarControles()
            Me.deshabilitarControles()

        Catch ex As Exception

            MessageBox.Show("Hubo un problema al guardar el registro: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub txtEco_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEco.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.Handled = True
            Me.consultarInformacion()

        End If
    End Sub

    Private Sub habilitarControles()

        Me.txtCel.Enabled = True
        Me.txtOperador.Enabled = True
        Me.txtCliente.Enabled = True
        Me.txtReferencia.Enabled = True
        Me.txtContenedor.Enabled = True
        Me.txtDestino.Enabled = True
        Me.cmbStatus.Enabled = True
        Me.txtComentarios.Enabled = True

    End Sub

    Private Sub deshabilitarControles()

        Me.txtCel.Enabled = False
        Me.txtOperador.Enabled = False
        Me.txtCliente.Enabled = False
        Me.txtReferencia.Enabled = False
        Me.txtContenedor.Enabled = False
        Me.txtDestino.Enabled = False
        Me.cmbStatus.Enabled = False
        Me.txtComentarios.Enabled = False

    End Sub

    Private Sub inicializarControles()

        Me.txtCel.Text = ""
        Me.txtOperador.Text = ""
        Me.txtCliente.Text = ""
        Me.txtReferencia.Text = ""
        Me.txtContenedor.Text = ""
        Me.txtDestino.Text = ""
        Me.cmbStatus.SelectedIndex = 0
        Me.txtComentarios.Text = ""

    End Sub

    Private Sub txtCel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCel.KeyDown, txtReferencia.KeyDown, txtOperador.KeyDown, txtDestino.KeyDown, txtContenedor.KeyDown, txtComentarios.KeyDown, txtCliente.KeyDown, cmbStatus.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub

    Private Sub consultarInformacion()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        Try

            sql = "DECLARE @id INT SET @id = (SELECT TOP(1) idReporte FROM trafico_contenedores_viaje WHERE fechaReporte = CONVERT(VARCHAR(20),GETDATE(),103)) SELECT * FROM trafico_contenedores_viaje_detalle WHERE eco = '" & Me.txtEco.Text & "' AND idReporte = @id"
            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 500
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables(0).Rows.Count > 0 Then

                Me.txtCel.Text = dS.Tables(0).Rows(0)(3).ToString()
                Me.txtOperador.Text = dS.Tables(0).Rows(0)(4).ToString()
                Me.txtCliente.Text = dS.Tables(0).Rows(0)(5).ToString()
                Me.txtReferencia.Text = dS.Tables(0).Rows(0)(6).ToString()
                Me.txtContenedor.Text = dS.Tables(0).Rows(0)(7).ToString()
                Me.txtDestino.Text = dS.Tables(0).Rows(0)(8).ToString()
                Me.cmbStatus.SelectedValue = dS.Tables(0).Rows(0)(9).ToString()
                Me.txtComentarios.Text = dS.Tables(0).Rows(0)(10).ToString()
                Me.habilitarControles()

            End If
        Catch ex As Exception

            MessageBox.Show("Hubo un problema al cargar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class