Imports System.Data
Imports System.Data.SqlClient

Public Class AgregarUnidad

    Private id As Integer
    Private placas As String
    Private celular As String
    Private operador As String
    Private economico As String
    Private fechaVencLic As Date
    Private fechaVencExMed As Date

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = 0
        Me.placas = ""
        Me.celular = ""
        Me.operador = ""
        Me.economico = ""
        Me.fechaVencLic = Date.Today
        Me.fechaVencExMed = Date.Today

    End Sub

    Public Sub New(ByVal id As Integer, ByVal placas As String, ByVal celular As String, ByVal operador As String, ByVal economico As String, ByVal fechaVencLic As Date, ByVal fechaVencExMed As Date)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        Me.placas = placas
        Me.celular = celular
        Me.operador = operador
        Me.economico = economico
        Me.fechaVencLic = fechaVencLic
        Me.fechaVencExMed = fechaVencExMed

    End Sub

    Private Sub AgregarUnidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.tBPlacas.Text = Me.placas
        Me.tBCelular.Text = Me.celular
        Me.tBOperador.Text = Me.operador
        Me.tBEconomico.Text = Me.economico
        Me.dTPLicencia.Value = Me.fechaVencLic
        Me.dTPExmaneMedico.Value = Me.fechaVencExMed

    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click

        Me.guardarInformación()

    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click

        Me.Close()

    End Sub

    Private Sub guardarInformación()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_CatalogoUnidades_Ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@economico", Me.tBEconomico.Text)
                .AddWithValue("@placas", Me.tBPlacas.Text)
                .AddWithValue("@operador", Me.tBOperador.Text)
                .AddWithValue("@celularAsignado", Me.tBCelular.Text)
                .AddWithValue("@fechaVencExamenMedico", Me.dTPExmaneMedico.Value)
                .AddWithValue("@fechaVencLicencia", Me.dTPLicencia.Value)
                
            End With

            comando.ExecuteNonQuery()
            MessageBox.Show("Los cambios se han guardado con éxito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception

            MessageBox.Show("Error al guardar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class