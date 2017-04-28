Imports System.Data.SqlClient
Public Class FormCasetasPendientesCaptura



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Cursor.Current = Cursors.WaitCursor

        If txtUnidad.Text = "0" Then
            Me.SinUnidad()
        Else
            Me.ConUnidad()
        End If

        Cursor.Current = Cursors.Arrow

    End Sub
    Public Sub SinUnidad()

        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_IAVE_PENDIENTES", conn)
        command.CommandType = CommandType.StoredProcedure
        conn.Open()
        command.CommandTimeout = 600
        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@FECHAINICIAL", Me.cmbFechaInicial.Value.Date)
        param = command.Parameters.AddWithValue("@FECHAFINAL", Me.cmbFechaFinal.Value.Date)
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.Grid.DataSource = oDs.Tables(0)
    End Sub
    Public Sub ConUnidad()
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_IAVE_PENDIENTES2", conn)
        command.CommandType = CommandType.StoredProcedure
        conn.Open()
        command.CommandTimeout = 600
        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@FECHAINICIAL", Me.cmbFechaInicial.Value.Date)
        param = command.Parameters.AddWithValue("@FECHAFINAL", Me.cmbFechaFinal.Value.Date)
        param = command.Parameters.AddWithValue("@UNIDAD", Me.txtUnidad.Text)
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.Grid.DataSource = oDs.Tables(0)
    End Sub
End Class