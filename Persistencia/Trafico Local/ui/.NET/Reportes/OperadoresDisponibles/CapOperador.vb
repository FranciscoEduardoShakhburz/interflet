Imports System.Data
Imports System.Data.SqlClient

Public Class CapOperador

    Private asig As DataGridView

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef asig As DataGridView)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.asig = asig

    End Sub

    Private Sub CapOperador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.busquedaOperador()
        Me.cmBEstatus.SelectedIndex = 0

    End Sub

    Private Sub txtOperador_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOperador.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.cmBTipoOp.SelectedItem = Me.consultarOperador(Me.txtOperador.Text)
            Me.mTBHora.Text = DateTime.Now.ToString("hh:mm")

        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Me.guardar()

    End Sub

    Private Sub busquedaOperador()

        Dim autoCompletado As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre FROM personal_personal"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtOperador.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Sub guardar()

        Dim index As Integer
        Dim operador As DataGridViewRow

        index = Me.asig.Rows.Add()
        operador = Me.asig.Rows(index)
        operador.Cells("colOperador").Value = Me.txtOperador.Text
        operador.Cells("colTipoOper").Value = Me.cmBTipoOp.SelectedItem
        operador.Cells("colHoraEntrada").Value = Me.mTBHora.Text
        operador.Cells("colHoraManiobra").Value = Me.mTBEntregaManiobra.Text
        operador.Cells("colHoraAsignacion").Value = Me.mTBAsignacion.Text
        operador.Cells("colEstatus").Value = Me.cmBEstatus.SelectedItem
        operador.Cells("colEstatus").Style.BackColor = Color.GreenYellow
        operador.Cells("colEstatus").Style.Font = New Font("Ubuntu", 10)
        Me.Close()

    End Sub

    Private Function consultarOperador(ByVal nombre As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String
        Dim tipo As String

        tipo = ""

        Try

            consulta = "SELECT TOP(1) CASE cat.descripcion WHEN 'OPERADOR LOCAL' THEN 'Local' ELSE 'Foráneo' END AS [Tipo de operador] FROM personal_personal per LEFT JOIN personal_catalogo_categoria cat ON per.id_categoria = cat.id_categoria WHERE per.estado = 'A' AND per.tipo_empleado = 'O' AND per.nombre = '" & nombre & "'"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            tipo = IIf(String.IsNullOrEmpty(comando.ExecuteScalar().ToString()), "", comando.ExecuteScalar().ToString())

        Catch ex As Exception

            MessageBox.Show("Error al consultar el tipo de operador: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return tipo

    End Function
End Class