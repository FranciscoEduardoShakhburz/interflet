Imports System.Data
Imports System.Data.SqlClient

Public Class UnidadesPatio

    Private Sub UnidadesPatio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarGrid()
        
    End Sub
    
    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.cargarGrid()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor.Current = Cursors.WaitCursor
        Excel.gridToExcel(Me.dGVUnidades)
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub cargarGrid()

        Dim uni As DataGridViewRow
        Dim dT As DataTable
        Dim ignicion As String
        Dim status As String
        Dim total As Integer

        dT = Me.consultarInformacion()
        Me.dGVUnidades.Rows.Clear()
        total = 0

        For Each unidad As DataRow In dT.Rows

            uni = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Add())
            uni.Cells("colUnidad").Value = unidad("unidad").ToString()
            uni.Cells("colRemolque1").Value = unidad("Equipo").ToString().Split("*")(0)
            uni.Cells("colDolly").Value = unidad("Equipo").ToString().Split("*")(1)
            uni.Cells("colRemolque2").Value = unidad("Equipo").ToString().Split("*")(2)
            uni.Cells("colSitio").Value = unidad("geocerca").ToString()
            uni.Cells("colIgnicion").Value = unidad("ignicion").ToString()
            uni.Cells("colTiempoEstacionada").Value = Me.unidadEstacionada(unidad("fechaEstacionada"))
            uni.Cells("colTiempoSitio").Value = Me.tiempoEnSitio(unidad("fechaEntradaSitio").ToString())
            total += 1

        Next

        If total < 10 Then

            Me.etqTractos.Text = "  " & total & " tractos"

        ElseIf total < 100 Then

            Me.etqTractos.Text = " " & total & " tractos"

        Else

            Me.etqTractos.Text = total & " tractos"

        End If
    End Sub

    Private Function consultarInformacion() As DataTable

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        dS = Nothing

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Consulta_Unidades_Patio", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Return dS.Tables(0)

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar las unidades: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Function

    Private Function unidadEstacionada(ByVal fechaEstacionada As String) As String

        Dim resultado As String

        Try

            Dim ts As TimeSpan = DateTime.Now.Subtract(Convert.ToDateTime(fechaEstacionada))
            Dim dias As Int32 = ts.Days
            Dim horas As Int32 = ts.Hours
            Dim minutos As Int32 = ts.Minutes
            Dim segundos As Int32 = ts.Seconds

            If minutos >= 5 And segundos >= 0 Then

                resultado = IIf(horas < 10, "0" & horas, horas) & ":" & IIf(minutos < 10, "0" & minutos, minutos) & ":" & IIf(segundos < 10, "0" & segundos, segundos)

            Else

                resultado = "00:00:00"

            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la unidad estacionada: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return resultado

    End Function

    Private Function tiempoEnSitio(ByVal fechaLlegadaSitio As String) As String

        Dim resultado As String

        Try

            Dim ts As TimeSpan = DateTime.Now.Subtract(fechaLlegadaSitio)
            Dim dias As Int32 = ts.Days
            Dim horas As Int32 = ts.Hours
            Dim minutos As Int32 = ts.Minutes
            Dim segundos As Int32 = ts.Seconds

            resultado = IIf(dias < 10, "0" & dias, dias) & " d " & IIf(horas < 10, "0" & horas, horas) & " h " & IIf(minutos < 10, "0" & minutos, minutos) & " m"

        Catch ex As Exception

            MessageBox.Show("Error al consultar el tiempo en sitio: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return resultado

    End Function
End Class