Imports System.Data
Imports System.Data.SqlClient

Public Class ValeGasolina

    Private unidad As String
    Private numVale As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal unidad As String, ByVal numVale As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.unidad = unidad
        Me.numVale = numVale

    End Sub

    Private Sub ValeGasolina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not String.IsNullOrEmpty(Me.unidad) And Not String.IsNullOrEmpty(Me.numVale) Then

            Me.consultarInfoVale()

        Else

            Me.cmbCombustible.SelectedIndex = 0
            Me.resultadosDeBusqueda()

        End If
    End Sub

    Private Sub resultadosDeBusqueda()

        Dim autoCompletado As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT economico FROM Trafico_Unidad_Agencia"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)
        comando.Dispose()
        conexion.Dispose()
        conexion.Close()

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtUnidad.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtUnidad.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub txtUnidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnidad.KeyDown, txtVale.KeyDown, txtOperador.KeyDown, txtKilometraje.KeyDown, txtCantidad.KeyDown, dteFecha.KeyDown, cmbCombustible.KeyDown, btnSalir.KeyDown, btnGuardar.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        If String.IsNullOrEmpty(Me.txtUnidad.Text) Or String.IsNullOrEmpty(Me.txtOperador.Text) Or String.IsNullOrEmpty(Me.txtVale.Text) Or String.IsNullOrEmpty(Me.txtCantidad.Text) Or String.IsNullOrEmpty(Me.txtKilometraje.Text) Then

            MessageBox.Show("Algunos campos estan vacíos. Por favor, llénelos y vuelva a intentarlo", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else

            Me.guardarVale()

        End If
    End Sub

    Private Sub guardarVale()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("up_Trafico_Vales_Gasolina_insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@economico", Me.txtUnidad.Text)
                .AddWithValue("@operador", Me.txtOperador.Text)
                .AddWithValue("@fecha", Me.dteFecha.Value.ToString("dd/MM/yyyy"))
                .AddWithValue("@numVale", Me.txtVale.Text)
                .AddWithValue("@cantidad", Me.txtCantidad.Text)
                .AddWithValue("@tipoCombustible", Me.cmbCombustible.SelectedItem)
                .AddWithValue("@kilometraje", Me.txtKilometraje.Text)

            End With

            comando.ExecuteNonQuery()
            comando.Dispose()
            conexion.Dispose()
            conexion.Close()
            MessageBox.Show("El registro se ha guardado correctamente.", "¡Registro guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error al guardar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub consultarInfoVale()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        Try

            consulta = "SELECT TOP(1) economico, operador, fecha, numVale, cantidad, tipoCombustible, kilometraje FROM Trafico_Vales_Gasolina WHERE economico = '" & Me.unidad & "' AND numVale = '" & Me.numVale & "'"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet
            sDA.Fill(dS)
            comando.Dispose()
            conexion.Dispose()
            conexion.Close()

            If dS.Tables(0).Rows.Count > 0 Then

                Me.txtUnidad.Text = dS.Tables(0).Rows(0)("economico").ToString()
                Me.txtOperador.Text = dS.Tables(0).Rows(0)("operador").ToString()
                Me.dteFecha.Value = dS.Tables(0).Rows(0)("fecha").ToString()
                Me.txtVale.Text = dS.Tables(0).Rows(0)("numVale").ToString()
                Me.txtCantidad.Text = dS.Tables(0).Rows(0)("cantidad").ToString()

                If dS.Tables(0).Rows(0)("tipoCombustible").ToString().Contains("MAGNA") Then

                    Me.cmbCombustible.SelectedIndex = 0

                ElseIf dS.Tables(0).Rows(0)("tipoCombustible").ToString().Contains("PREMIUM") Then

                    Me.cmbCombustible.SelectedIndex = 1

                Else

                    Me.cmbCombustible.SelectedIndex = 3

                End If

                Me.txtKilometraje.Text = dS.Tables(0).Rows(0)("kilometraje").ToString()

            End If
        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error al consultar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class