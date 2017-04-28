Imports System.Data
Imports System.Data.SqlClient

Public Class SellosContenedores

    Private Sub btnAgrgarReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrgarReg.Click

        Dim capt As CaptSellosContenedores = New CaptSellosContenedores()
        capt.ShowDialog(Me)

    End Sub

    Private Sub txtConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsulta.TextChanged

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance.getConnection()
            conexion.Open()
            comando = New SqlCommand("up_consulta_sellosContenedores", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 1000

            If Me.rdBtnContenedor.Checked Then
                With comando.Parameters

                    .AddWithValue("@contenedor", Me.txtConsulta.Text)
                    .AddWithValue("@referencia", "")
                    .AddWithValue("@fechaDesde", "")
                    .AddWithValue("@fechaHasta", "")
                    .AddWithValue("@tipoCons", 1)

                End With
            ElseIf Me.rdBtnReferencia.Checked Then
                With comando.Parameters

                    .AddWithValue("@contenedor", "")
                    .AddWithValue("@referencia", Me.txtConsulta.Text)
                    .AddWithValue("@fechaDesde", "")
                    .AddWithValue("@fechaHasta", "")
                    .AddWithValue("@tipoCons", 2)

                End With
            End If

            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Me.gridRegistros.DataSource = dS.Tables(0)

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub rdBtnRango_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBtnRango.CheckedChanged

        Me.gridRegistros.DataSource = Nothing
        Me.gridRegistros.Refresh()

        If Me.rdBtnRango.Checked Then

            Dim conexion As SqlConnection
            Dim comando As SqlCommand
            Dim sDA As SqlDataAdapter
            Dim dS As DataSet

            Try

                conexion = Connection.getInstance.getConnection()
                conexion.Open()
                comando = New SqlCommand("up_consulta_sellosContenedores", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000

                With comando.Parameters

                    .AddWithValue("@contenedor", "")
                    .AddWithValue("@referencia", "")
                    .AddWithValue("@fechaDesde", Me.dteDesde.Value.ToString("dd/MM/yyyy"))
                    .AddWithValue("@fechaHasta", Me.dteHasta.Value.ToString("dd/MM/yyyy"))
                    .AddWithValue("@tipoCons", 3)

                End With

                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables.Count > 0 Then
                    If dS.Tables(0).Rows.Count > 0 Then

                        Me.gridRegistros.DataSource = dS.Tables(0)

                    End If
                End If
            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

    Private Sub dteDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteHasta.ValueChanged, dteDesde.ValueChanged

        Me.rdBtnRango_CheckedChanged(sender, e)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub gridRegistros_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridRegistros.DoubleClick

        Dim capt As CaptSellosContenedores = New CaptSellosContenedores(Me.gridRegistros.SelectedRows(0).Cells(3).Value.ToString(), Me.gridRegistros.SelectedRows(0).Cells(0).Value.ToString())
        capt.ShowDialog(Me)

    End Sub

    Private Sub rdBtnReferencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBtnReferencia.CheckedChanged, rdBtnContenedor.CheckedChanged

        Me.gridRegistros.DataSource = Nothing
        Me.gridRegistros.Refresh()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sql As String

        Try

            For Each registro As DataGridViewRow In Me.gridRegistros.SelectedRows

                sql = "DELETE FROM trafico_sellos_contenedores WHERE contenedor = '" & registro.Cells(0).Value.ToString() & "' AND referencia = '" & registro.Cells(3).Value.ToString() & "'"
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                comando.ExecuteNonQuery()
                Me.gridRegistros.Rows.Remove(registro)
                Me.gridRegistros.Refresh()

            Next
        Catch ex As Exception

            MessageBox.Show("Hubo un problema al eliminar un registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub SellosContenedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.rdBtnContenedor.Checked = True
        Me.rdBtnPeriodo.Checked = True

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        Try
            If Me.rdBtnPeriodo.Checked Then

                sql = "SELECT fechaRegistro AS [Fecha], Contenedor, sello AS [No. Sello], Booking, Referencia, Cliente, Naviera, cartaPorte as [Carta porte], fechaPlanta AS [PLANTA], Observaciones FROM trafico_sellos_contenedores WHERE fechaRegistro BETWEEN '" & Me.dteDe.Value.ToString("dd/MM/yyyy") & "' AND '" & Me.dteA.Value.ToString("dd/MM/yyyy") & "'"

            ElseIf Me.rdBtnPorRefer.Checked Then

                sql = "SELECT fechaRegistro AS [Fecha], Contenedor, sello AS [No. Sello], Booking, Referencia, Cliente, Naviera, cartaPorte as [Carta porte], fechaPlanta AS [PLANTA], Observaciones FROM trafico_sellos_contenedores WHERE referencia = '" & Me.txtRepo.Text & "'"

            ElseIf Me.rdBtnPorBook.Checked Then

                sql = "SELECT fechaRegistro AS [Fecha], Contenedor, sello AS [No. Sello], Booking, Referencia, Cliente, Naviera, cartaPorte as [Carta porte], fechaPlanta AS [PLANTA], Observaciones FROM trafico_sellos_contenedores WHERE booking = '" & Me.txtRepo.Text & "'"

            ElseIf Me.rdBtnSinCPorte.Checked Then

                sql = "SELECT fechaRegistro AS [Fecha], Contenedor, sello AS [No. Sello], Booking, Referencia, Cliente, Naviera, cartaPorte as [Carta porte], fechaPlanta AS [PLANTA], Observaciones FROM trafico_sellos_contenedores WHERE cartaPorte = '' "

            End If

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Excel.datasetToExcel(dS)

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("El reporte no se generó debido al siguiente problema: " & ex.Message, "Problemas al generar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub rdBtnSinCP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBtnSinCP.CheckedChanged

        Me.gridRegistros.DataSource = Nothing
        Me.gridRegistros.Refresh()

        If Me.rdBtnSinCP.Checked Then

            Dim conexion As SqlConnection
            Dim comando As SqlCommand
            Dim sDA As SqlDataAdapter
            Dim dS As DataSet

            Try

                conexion = Connection.getInstance.getConnection()
                conexion.Open()
                comando = New SqlCommand("up_consulta_sellosContenedores", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000

                With comando.Parameters

                    .AddWithValue("@contenedor", "")
                    .AddWithValue("@referencia", "")
                    .AddWithValue("@fechaDesde", "")
                    .AddWithValue("@fechaHasta", "")
                    .AddWithValue("@tipoCons", 4)

                End With

                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables.Count > 0 Then
                    If dS.Tables(0).Rows.Count > 0 Then

                        Me.gridRegistros.DataSource = dS.Tables(0)

                    End If
                End If

                Me.gridRegistros.Refresh()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub
End Class