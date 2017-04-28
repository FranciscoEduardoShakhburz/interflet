Imports System.Data.SqlClient

Public Class formOperadores
    Dim conn As SqlConnection
    Dim sql As String
    Dim command As SqlCommand
    Dim adapter As SqlDataAdapter

    Private Sub txtOperador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperador.TextChanged
        Me.sql = "select id_personal, nombre from personal_personal where nombre like +'" + Me.txtOperador.Text.Trim() + "' + '%'"
        command = New SqlCommand(Me.sql, Me.conn)
        command.CommandType = CommandType.Text
        adapter = New SqlDataAdapter(command)
        Dim dataset As DataSet = New DataSet()
        adapter.Fill(dataset)
        Me.gridOperadores.DataSource = dataset.Tables(0)
    End Sub

    Private Sub formOperadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn = Connection.getInstance().getConnection()
        Me.conn.Open()
    End Sub

    Private Sub txtOperador_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOperador.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.setOperador()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.conn.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Me.setOperador()
    End Sub

    Private Sub setOperador()
        If Not String.IsNullOrEmpty(Me.gridOperadores.CurrentRow.Cells("id_personal").Value.ToString()) Then
            Dim idPersonal As Integer = Convert.ToInt32(Me.gridOperadores.CurrentRow.Cells(0).Value.ToString())
            frmDatosViaje.id_personal = idPersonal
            frmDatosViaje.TxtOperador.Text = Me.gridOperadores.CurrentRow.Cells("nombre").Value.ToString()
        End If
    End Sub
End Class