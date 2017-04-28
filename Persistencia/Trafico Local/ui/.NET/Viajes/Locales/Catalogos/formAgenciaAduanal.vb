Imports System.Data.SqlClient

Public Class formAgenciaAduanal

    Private isNewAgencia As Boolean

    Public Sub New()
        InitializeComponent()
        Me.isNewAgencia = True
    End Sub

    Public Sub New(ByVal modo As String)
        InitializeComponent()
        If modo = "NUEVA" Then
            Me.isNewAgencia = True
        Else
            Me.isNewAgencia = False
        End If
    End Sub

    Private Sub gridAgenciasAduanales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridAgenciasAduanales.DoubleClick
        If Not Me.isNewAgencia Then
            'formIngresoEIR.idAgencia = Convert.ToInt32(Me.gridAgenciasAduanales.CurrentRow.Cells(0).Value.ToString())
            'formIngresoEIR.txtAgenciaAduanal.Text = Me.gridAgenciasAduanales.CurrentRow.Cells(1).Value.ToString()
        End If
    End Sub


    Private Sub formAgenciaAduanal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getAgenciasAduanales()
        If Not Me.isNewAgencia Then
            Me.btnGuardar.Text = "Buscar"
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.isNewAgencia Then
            Me.guardarAgenciaAduanal()
        Else
            Me.getAgenciaAduanalByNombre(Me.txtNombreAgencia.Text.Trim)
        End If
    End Sub

    Private Sub txtNombreAgencia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreAgencia.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Me.isNewAgencia Then
            Me.guardarAgenciaAduanal()
        End If
    End Sub

    Private Sub gridAgenciasAduanales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridAgenciasAduanales.KeyDown
        Cursor = Cursors.WaitCursor
        If e.KeyCode = Keys.Delete AndAlso Me.isNewAgencia Then
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim sql As String = "UPDATE TRAFICO_LOCAL_AGENCIA_ADUANAL SET ELIMINADO = 1 WHERE ID_AGENCIA_ADUANAL = @ID_AGENCIA"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@ID_AGENCIA", Me.gridAgenciasAduanales.CurrentRow.Cells(0).Value.ToString())
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()
            command.Dispose()
            MessageBox.Show("¡La agencia fue borrada!")
            Me.getAgenciasAduanales()
        End If
        Cursor = Cursors.Arrow
    End Sub

#Region "Base de datos"
    Private Sub getAgenciasAduanales()
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT id_agencia_aduanal, nombre_agencia_aduanal FROM TRAFICO_LOCAL_AGENCIA_ADUANAL WHERE ELIMINADO = 0"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        conn.Open()
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridAgenciasAduanales.DataSource = table
        conn.Close()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub getAgenciaAduanalByNombre(ByVal agente As String)
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT id_agencia_aduanal, nombre_agencia_aduanal FROM TRAFICO_LOCAL_AGENCIA_ADUANAL WHERE NOMBRE_AGENCIA_ADUANAL LIKE '%'+ @AGENTE +'%' AND ELIMINADO = 0"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@AGENTE", agente)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        conn.Open()
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridAgenciasAduanales.DataSource = table
        conn.Close()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub guardarAgenciaAduanal()
        Cursor = Cursors.WaitCursor
        Dim agenciaAduanal As String = Me.txtNombreAgencia.Text.Trim.ToUpper
        If Not String.IsNullOrEmpty(agenciaAduanal) And Me.isNewAgencia Then
            Dim conn As SqlConnection = Connection.getInstance.getConnection()
            Dim sql As String = "INSERT INTO TRAFICO_LOCAL_AGENCIA_ADUANAL (NOMBRE_AGENCIA_ADUANAL, ELIMINADO) VALUES(@NOMBRE_AGENCIA, 0)"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@NOMBRE_AGENCIA", agenciaAduanal)
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()
            'MessageBox.Show("¡Agencia Guardada!")
            Me.getAgenciasAduanales()
        Else
            MessageBox.Show("Escribe una agencia aduanal")
        End If
        Cursor = Cursors.Arrow
        Me.txtNombreAgencia.Focus()
        Me.txtNombreAgencia.Text = ""
    End Sub
#End Region

End Class