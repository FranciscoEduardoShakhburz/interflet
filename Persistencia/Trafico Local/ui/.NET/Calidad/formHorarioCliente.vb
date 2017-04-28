Imports System.Data.SqlClient

Public Class formHorarioCliente

    Private viaje As String


    Public Sub New(ByVal unidad As String, ByVal viaje As String)
        InitializeComponent()
        Me.viaje = viaje
        Me.lblUnidad.Text = unidad

        Dim conn As SqlConnection = Connection.getInstance().getConnectionQFS()
        conn.Open()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_ULTIMOS_CLIENTES", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@UNIDAD", unidad)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable
        adapter.Fill(table)
        conn.Close()
        Me.gridClientes.DataSource = table
    End Sub

    Private Sub gridClientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridClientes.CellDoubleClick
        frmIndicadoresCalidad.fecha = Me.gridClientes.CurrentRow.Cells(0).Value.ToString()
        Me.Dispose()
    End Sub
End Class