Imports System.Data.SqlClient

Public Class formTerminales

    Private isNewTerminal As Boolean

    Public Sub New()
        InitializeComponent()
        Me.isNewTerminal = True
    End Sub

    Public Sub New(ByVal modo As String)
        InitializeComponent()
        If modo = "NUEVA" Then
            Me.isNewTerminal = True
        Else
            Me.isNewTerminal = False
        End If
    End Sub

    Private Sub gridTerminales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridTerminales.DoubleClick
        If Not Me.isNewTerminal Then
            formIngresoEIR.idTerminal = Convert.ToInt32(Me.gridTerminales.CurrentRow.Cells(0).Value.ToString())
            formIngresoEIR.cmbTerminales.SelectedValue = Convert.ToInt32(Me.gridTerminales.CurrentRow.Cells(0).Value.ToString())
        End If
    End Sub

    Private Sub formTerminales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getTerminales()
        If Not Me.isNewTerminal Then
            Me.btnGuardar.Text = "Buscar"
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.isNewTerminal Then
            Me.guardarTerminal()
        Else
            Me.getTerminalByNombre(Me.txtNombreTerminal.Text.Trim)
        End If
    End Sub

    Private Sub txtNombreTerminal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreTerminal.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Me.isNewTerminal Then
            Me.guardarTerminal()
        End If
    End Sub

    Private Sub gridTerminales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridTerminales.KeyDown
        Cursor = Cursors.WaitCursor
        If e.KeyCode = Keys.Delete AndAlso Me.isNewTerminal Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim sql As String = "DELETE FROM TRAFICO_LOCAL_TERMINAL WHERE ID_TERMINAL = @ID_TERMINAL"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@ID_TERMINAL", Me.gridTerminales.CurrentRow.Cells(0).Value.ToString())
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()
            command.Dispose()
            MessageBox.Show("¡La terminal fue borrada!")
            Me.getTerminales()
        End If
        Cursor = Cursors.Arrow
    End Sub


#Region "Base de datos"
    Private Sub getTerminales()
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT id_terminal, nombre_terminal FROM TRAFICO_LOCAL_TERMINAL WHERE Eliminado = 0"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        conn.Open()
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridTerminales.DataSource = table
        conn.Close()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub getTerminalByNombre(ByVal terminal As String)
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT id_terminal, nombre_terminal FROM TRAFICO_LOCAL_TERMINAL WHERE NOMBRE_TERMINAL LIKE '%' + @TERMINAL + '%' AND ELIMINADO = 0"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@TERMINAL", terminal)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        conn.Open()
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridTerminales.DataSource = table
        conn.Close()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub guardarTerminal()
        Cursor = Cursors.WaitCursor
        Dim terminal As String = Me.txtNombreTerminal.Text.Trim.ToUpper
        If Not String.IsNullOrEmpty(terminal) Then
            Dim conn As SqlConnection = Connection.getInstance.getConnection()
            Dim sql As String = "INSERT INTO TRAFICO_LOCAL_TERMINAL (NOMBRE_TERMINAL, ELIMINADO) VALUES(@NOMBRE_TERMINAL, 0)"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@NOMBRE_TERMINAL", terminal)
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()
            MessageBox.Show("¡Terminal Guardada!")
            Me.getTerminales()
        Else
            MessageBox.Show("Escribe una terminal")
        End If
        Cursor = Cursors.Arrow
        Me.txtNombreTerminal.Focus()
        Me.txtNombreTerminal.Text = ""
    End Sub
#End Region
End Class