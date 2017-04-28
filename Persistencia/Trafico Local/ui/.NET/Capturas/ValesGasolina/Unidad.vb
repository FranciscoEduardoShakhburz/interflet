Imports System.Data
Imports System.Data.SqlClient

Public Class Unidad

    Private economico As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal economico As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.economico = economico

    End Sub



    Private Sub txtEconomico_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEconomico.KeyDown, txtSerie.KeyDown, txtModelo.KeyDown, txtMarca.KeyDown, txtAño.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If String.IsNullOrEmpty(Me.txtEconomico.Text) Or String.IsNullOrEmpty(Me.txtMarca.Text) Or String.IsNullOrEmpty(Me.txtModelo.Text) Or String.IsNullOrEmpty(Me.txtSerie.Text) Or String.IsNullOrEmpty(Me.txtAño.Text) Then

            MessageBox.Show("Algunos campos estan vacíos. Por favor, llénelos y vuelva a intentarlo", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else

            Me.guardarInfo()

        End If
    End Sub

    Private Sub Unidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not String.IsNullOrEmpty(Me.economico) Then

            Me.consultarInfoUnidad()

        End If
    End Sub

    Private Sub guardarInfo()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("up_Trafico_Unidad_Agencia_insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@economico", Me.txtEconomico.Text)
                .AddWithValue("@marca", Me.txtMarca.Text)
                .AddWithValue("@modelo", Me.txtModelo.Text)
                .AddWithValue("@numSerie", Me.txtSerie.Text)
                .AddWithValue("@año", Me.txtAño.Text)

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

    Private Sub consultarInfoUnidad()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        Try

            consulta = "SELECT TOP(1) economico, marca, modelo, numSerie, año FROM Trafico_Unidad_Agencia WHERE economico = '" & Me.economico & "'"
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

                Me.txtEconomico.Text = dS.Tables(0).Rows(0)("economico").ToString()
                Me.txtMarca.Text = dS.Tables(0).Rows(0)("marca").ToString()
                Me.txtModelo.Text = dS.Tables(0).Rows(0)("modelo").ToString()
                Me.txtSerie.Text = dS.Tables(0).Rows(0)("numSerie").ToString()
                Me.txtAño.Text = dS.Tables(0).Rows(0)("año").ToString()

            End If
        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error al consultar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class