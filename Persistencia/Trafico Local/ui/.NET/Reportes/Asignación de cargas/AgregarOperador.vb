Imports System.Data
Imports System.Data.SqlClient

Public Class AgregarOperador

    Private oper As OperadoresDisponibles
    Private fila As DataGridViewRow

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef oper As OperadoresDisponibles)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.oper = oper

    End Sub

    Public Sub New(ByRef fila As DataGridViewRow)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.fila = fila

    End Sub

    Private Sub AgregarOperador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cmBDisponible.SelectedIndex = 0
        Me.cmBModalidad.SelectedIndex = 0
        Me.resultadosDeBusqueda()

        If Me.fila IsNot Nothing Then

            Me.txtIdOperador.Text = fila.Cells("colOperador").Value.ToString()
            Me.txtOperador.Text = fila.Cells("colNombreOperador").Value.ToString()
            Me.txtUnidad.Text = fila.Cells("colUnidadAsignada").Value.ToString()
            Me.cmBModalidad.SelectedItem = fila.Cells("colModalidad").Value.ToString()
            Me.cmBDisponible.SelectedIndex = IIf(Convert.ToBoolean(fila.Cells("colDisponible").Value), 0, 1)
            Me.rTBObservaciones.Text = fila.Cells("colObservaciones").Value.ToString()

        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Me.guardarUnidad()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub txtOperador_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOperador.KeyDown

        Me.consultarUnidadId()

    End Sub

    Private Sub guardarUnidad()

        Dim operador As DataGridViewRow

        If Me.fila IsNot Nothing Then

            operador = Me.fila

        Else

            operador = Me.oper.dGVOperadores.Rows(Me.oper.dGVOperadores.Rows.Add())

        End If

        operador.Cells("colOperador").Value = Me.txtIdOperador.Text
        operador.Cells("colNombreOperador").Value = Me.txtOperador.Text
        operador.Cells("colUnidadAsignada").Value = Me.txtUnidad.Text
        operador.Cells("colDisponible").Value = IIf(Me.cmBDisponible.SelectedItem.ToString().Equals("DISPONIBLE"), True, False)
        operador.Cells("colModalidad").Value = Me.cmBModalidad.SelectedItem.ToString()
        operador.Cells("colObservaciones").Value = Me.rTBObservaciones.Text

    End Sub

    Private Sub resultadosDeBusqueda()

        Dim autoCompletado = New AutoCompleteStringCollection()
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

    Private Sub consultarUnidadId()

        Dim sql As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        If Not String.IsNullOrEmpty(Me.txtOperador.Text) Then
            Try

                sql = "DECLARE @id INT , @unidad VARCHAR(20) SET @id = ISNULL((SELECT TOP(1) id_personal FROM personal_personal WHERE nombre = '" & Me.txtOperador.Text & "'), 0) SET @unidad = ISNULL((SELECT TOP(1) id_unidad FROM mtto_unidades WHERE id_operador = @id), '') SELECT @id AS idOperador, @unidad AS unidad"
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables(0).Rows.Count > 0 Then

                    Me.txtIdOperador.Text = dS.Tables(0).Rows(0).Item("idOperador").ToString()
                    Me.txtUnidad.Text = dS.Tables(0).Rows(0).Item("unidad").ToString()

                End If

                conexion.Dispose()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        Else

            Me.txtIdOperador.Text = ""
            Me.txtUnidad.Text = ""

        End If
    End Sub
End Class