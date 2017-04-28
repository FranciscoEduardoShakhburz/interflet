Imports System.Data
Imports System.Data.SqlClient

Public Class CaptSellosContenedores

    Private cont As String
    Private ref As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal referencia As String, ByVal contenedor As String)

        InitializeComponent()
        Me.cont = contenedor
        Me.ref = referencia
        Me.cargarCampos()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sql As String
        Dim existe As Boolean
        Cursor.Current = Cursors.WaitCursor

        Try

            sql = "SELECT COUNT(*) FROM trafico_sellos_contenedores WHERE contenedor = '" & Me.txtContenedor.Text & "' AND referencia = '" & Me.txtReferencia.Text & "'"
            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            existe = Convert.ToInt32(comando.ExecuteScalar().ToString()) > 0
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If existe Then

                Dim res As DialogResult
                res = MessageBox.Show("El contenedor " & Me.txtContenedor.Text & " con la referencia " & Me.txtReferencia.Text & " ya se encuentra registrado, ¿Desea actualizar el registro?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If res = Windows.Forms.DialogResult.No Then

                    Exit Sub

                End If
            End If

            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand("up_sellos_contenedores_ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 1000

            With comando.Parameters

                .AddWithValue("@contenedor", Me.txtContenedor.Text)
                .AddWithValue("@sello", Me.txtSello.Text)
                .AddWithValue("@booking", Me.txtBooking.Text)
                .AddWithValue("@referencia", Me.txtReferencia.Text)
                .AddWithValue("@cliente", Me.txtCliente.Text)
                .AddWithValue("@naviera", Me.txtNaviera.Text)
                .AddWithValue("@cartaPorte", Me.txtCP.Text)
                .AddWithValue("@fechaPlanta", Me.dtePlanta.Value.ToString("dd/MM/yyyy"))
                .AddWithValue("@observaciones", Me.txtObservaciones.Text)

            End With

            comando.ExecuteNonQuery()
            Me.Close()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
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

    Private Sub CaptSellosContenedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.resultadosDeBusquedaCliente()

    End Sub

    Private Sub txtContenedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContenedor.KeyDown, txtSello.KeyDown, txtReferencia.KeyDown, txtNaviera.KeyDown, txtCP.KeyDown, txtCliente.KeyDown, txtBooking.KeyDown, dtePlanta.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub

    Private Sub cargarCampos()

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        sql = "SELECT * FROM trafico_sellos_contenedores WHERE contenedor = '" & Me.cont & "' AND referencia = '" & Me.ref & "'"
        conexion = Connection.getInstance().getConnection()
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        If dS.Tables.Count > 0 Then
            If dS.Tables(0).Rows.Count > 0 Then

                Me.txtContenedor.Text = dS.Tables(0).Rows(0)(0).ToString()
                Me.txtSello.Text = dS.Tables(0).Rows(0)(1).ToString()
                Me.txtBooking.Text = dS.Tables(0).Rows(0)(2).ToString()
                Me.txtReferencia.Text = dS.Tables(0).Rows(0)(3).ToString()
                Me.txtCliente.Text = dS.Tables(0).Rows(0)(4).ToString()
                Me.txtNaviera.Text = dS.Tables(0).Rows(0)(5).ToString()
                Me.txtCP.Text = dS.Tables(0).Rows(0)(6).ToString()
                Me.dtePlanta.Value = dS.Tables(0).Rows(0)(7).ToString()
                Me.txtObservaciones.Text = dS.Tables(0).Rows(0)(9).ToString()

            End If
        End If

        conexion.Close()
        conexion.Dispose()
        comando.Dispose()

    End Sub
End Class