Imports System.Data.SqlClient
Public Class ReProgramacion

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click

        Me.Close()

    End Sub

    Private Sub ReProgramacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        Me.txt_contenedor.AutoCompleteMode = AutoCompleteMode.Suggest 'Autocompletado de Contenedor
        Me.txt_contenedor.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        Me.getData(DataCollection)
        Me.txt_contenedor.AutoCompleteCustomSource = DataCollection
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub getData(ByVal dataCollection As AutoCompleteStringCollection) 'Autocompletado de Contenedor

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim sql As String = "SELECT DISTINCT contenedor FROM trafico_reporte_programacion"

        Try

            conn.Open()
            command = New SqlCommand(sql, conn)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            conn.Close()

            For Each row As DataRow In ds.Tables(0).Rows

                dataCollection.Add(row(0).ToString())

            Next
        Catch ex As Exception

            MessageBox.Show("Can not open connection ! ")

        End Try
    End Sub

    Private Sub bto_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_agregar.Click

        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim reg As SqlDataReader
        cn.Open()

        If txt_referencia.Text = "" Then

            Dim command2 As New SqlCommand("select contenedor,cliente,referencia from trafico_reporte_programacion where contenedor = '" & txt_contenedor.Text & "'", cn)
            reg = command2.ExecuteReader

            While reg.Read

                grid.Rows.Add(reg.GetValue(0).ToString, reg.GetValue(1).ToString, reg.GetValue(2).ToString)

            End While

            reg.Close()

        Else

            Dim command As New SqlCommand("select contenedor,cliente,referencia from trafico_reporte_programacion where referencia = '" & txt_referencia.Text & "'", cn)
            command.CommandType = CommandType.Text
            reg = command.ExecuteReader

            While reg.Read

                grid.Rows.Add(reg.GetValue(0).ToString, reg.GetValue(1).ToString, reg.GetValue(2).ToString)

            End While

            reg.Close()

        End If

        cn.Close()

    End Sub

    Private Sub bto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_guardar.Click

        Cursor = Cursors.WaitCursor
        Dim i As Integer = 0
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        cn.Open()

        If grid.Rows.Count > 0 Then
            While grid.Rows.Count > i

                Dim command As New SqlCommand("up_insert_reprogramacion", cn)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@Contenedor", grid.Rows(i).Cells(0).Value.ToString)
                command.Parameters.AddWithValue("@referencia", grid.Rows(i).Cells(2).Value.ToString)
                command.Parameters.AddWithValue("@observaciones", txt_observaciones.Text)
                command.Parameters.AddWithValue("@re_fecha", cmb_fec.Value.Date)
                command.ExecuteNonQuery()
                i = i + 1

            End While

            MessageBox.Show("Terminado")

        End If

        Cursor = Cursors.Arrow

    End Sub

    
    Private Sub bto_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_quitar.Click

        Me.grid.Rows.RemoveAt(Me.grid.CurrentRow.Index)

    End Sub
End Class