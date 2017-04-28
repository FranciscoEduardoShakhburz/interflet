Imports System.Data.SqlClient

Public Class formReporteEIR

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If Me.gridEIR.Rows.Count > 0 Then
            Excel.gridToExcel(Me.gridEIR)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim cn As SqlConnection = Connection.getInstance.getConnection

        Try

            Dim sql As String

            If String.IsNullOrEmpty(Me.txtContenedor.Text) Then

                sql = "SELECT * FROM trafico_local_EIR WHERE fecha_EIR >= '" & Me.dateFechaInicial.Value & "' AND fecha_entrega_aa <= '" & Me.dateFechaFinal.Value & "'"

            Else

                sql = "SELECT * FROM trafico_local_EIR WHERE contenedor = '" & Me.txtContenedor.Text & "'"

            End If

            Dim command As New SqlCommand(sql, cn)
            command.CommandType = CommandType.Text
            cn.Open()
            oDa = New SqlClient.SqlDataAdapter(command)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
            Me.gridEIR.DataSource = oDs.Tables(0)
            cn.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            cn.Close()

        End Try
    End Sub
End Class