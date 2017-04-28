Imports System.Data.SqlClient

Public Class frmReporteCalidad

    Private area As Integer
    Private tipo As Integer
    Public oDsCalidad As System.Data.DataSet

    Private Sub frmReporteCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PI_Calidad.EnforceConstraints = False
        Me.area = 0
        Me.tipo = 0
        Me.btnExportar.Enabled = False
        Me.setCiudades()
        Me.setTipos()
        Me.cmbArea.SelectedItem = "Altamira"
        Me.cmbTipo.SelectedItem = "TODOS"

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Cursor = Cursors.WaitCursor
        Dim myDataset As New System.Data.DataSet

        If Me.cmbArea.SelectedItem = "" Then

            MessageBox.Show("Debe seleccionar el area", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)

        Else

            Limpiar()
            CargaResumen()
            Me.btnExportar.Enabled = True

        End If

        Cursor = Cursors.Arrow

    End Sub

    Private Sub CargaResumen()

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlCommand = New SqlCommand("UP_Consulta_ReporteCalidad_v2", oConexion)
        'Dim oParameter As SqlClient.SqlParameter
        oCommand.CommandType = CommandType.StoredProcedure
        oCommand.CommandTimeout = 5000

        Try

            oConexion.Open()

            With oCommand.Parameters

                .AddWithValue("@FechaIni", Me.cmbFechaIni.Value)
                .AddWithValue("@FechaFin", Me.cmbFechaFin.Value)
                .AddWithValue("@Area", Me.area)
                .AddWithValue("@tipo", Me.tipo)

            End With

            'oParameter = oCommand.Parameters.Add("@FechaIni", SqlDbType.DateTime)
            'oParameter.Value = Me.cmbFechaIni.Value
            'oParameter = oCommand.Parameters.Add("@FechaFin", SqlDbType.DateTime)
            'oParameter.Value = Me.cmbFechaFin.Value
            'oParameter = oCommand.Parameters.Add("@Area", SqlDbType.Int)
            'oParameter.Value = Me.area
            'oParameter = oCommand.Parameters.Add("@tipo", SqlDbType.Int)
            'oParameter.Value = Me.tipo
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDsCalidad = New System.Data.DataSet()
            oDa.Fill(oDsCalidad)
            'oParameter.ResetSqlDbType()
            Me.grdReporteGral.DataSource = oDsCalidad.Tables(0)
            Me.grdTotalXCliente.DataSource = oDsCalidad.Tables(1)
            Me.grdTotalDiasMes.DataSource = oDsCalidad.Tables(2)
            Me.grdTotalDiasSemana.DataSource = oDsCalidad.Tables(3)
            Me.grdTotalDiasSemana.Columns("Lunes").Width = 40
            Me.grdTotalDiasSemana.Columns("Martes").Width = 40
            Me.grdTotalDiasSemana.Columns("Miercoles").Width = 45
            Me.grdTotalDiasSemana.Columns("Jueves").Width = 40
            Me.grdTotalDiasSemana.Columns("Viernes").Width = 40
            Me.grdTotalDiasSemana.Columns("Sabado").Width = 40
            Me.grdTotalDiasSemana.Columns("Domingo").Width = 40
            Me.grdTotalDiasSemana.Columns("Total").Width = 45

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub Limpiar()

        Me.grdTotalDiasMes.DataSource = Nothing
        Me.grdTotalDiasSemana.DataSource = Nothing
        Me.grdTotalXCliente.DataSource = Nothing

    End Sub

    Private Sub setCiudades()

        Me.cmbArea.Items.Add("Altamira")
        Me.cmbArea.Items.Add("Manzanillo")
        Me.cmbArea.Items.Add("Veracruz")

    End Sub

    Private Sub setTipos()

        Me.cmbTipo.Items.Add("TODOS")
        Me.cmbTipo.Items.Add("IMPO")
        Me.cmbTipo.Items.Add("EXPO")

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor = Cursors.WaitCursor
        Dim valordeparametro As Date
        valordeparametro = Me.cmbFechaIni.Value
        Dim formreporte As New frmRepCalidad
        formreporte.RepView1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        formreporte.RepView1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        formreporte.parametro = Me.cmbFechaIni.Value.Date
        formreporte.parametro2 = Me.cmbFechaFin.Value.Date
        formreporte.area = area
        formreporte.tipo = Me.tipo
        formreporte.Show()
        Cursor = Cursors.Arrow

    End Sub

    Private Sub cmbArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.SelectedIndexChanged

        If Me.cmbArea.SelectedItem = "Altamira" Then

            Me.area = 1

        ElseIf Me.cmbArea.SelectedItem = "Manzanillo" Then

            Me.area = 2

        ElseIf Me.cmbArea.SelectedItem = "Veracruz" Then

            Me.area = 3

        End If
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged

        If Me.cmbTipo.SelectedItem = "TODOS" Then

            Me.tipo = 0

        ElseIf Me.cmbTipo.SelectedItem = "IMPO" Then

            Me.tipo = 1

        ElseIf Me.cmbTipo.SelectedItem = "EXPO" Then

            Me.tipo = 2

        End If
    End Sub
End Class