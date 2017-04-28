Imports System.Data.SqlClient

Public Class formKilometraje

    Private Sub formKilometraje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Cursor = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("select ISNULL(unidad, 'SIN UNIDAD') as Unidad, TV.ID_REMOLQUE1, TV.ID_REMOLQUE2, TV.ID_DOLLY,  fecfin_viaje as FechaFin_Viaje, km_final as KM_Final from datosviaje DV JOIN TRAFICO_VIAJE TV ON DV.ID_NUM_VIAJE = TV.NO_VIAJE where fecfin_viaje between @fechaInicial and @fechaFinal order by unidad, fecfin_viaje asc", conn)
        conn.Open()

        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@fechaInicial", Me.dtpFechaInicial.Value)
        param = command.Parameters.AddWithValue("@fechaFinal", Me.dtpFechaFinal.Value)

        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)

        Dim tabla As DataTable = oDs.Tables(0)

        If tabla.Rows.Count > 0 Then
            Dim contador As Integer = 1
            Dim unidadAnterior As String = ""
            Dim unidadActual As String = ""

            While contador < tabla.Rows.Count
                unidadActual = tabla.Rows(contador).Item("Unidad").ToString()
                unidadAnterior = tabla.Rows(contador - 1).Item("Unidad").ToString()
                If unidadActual = unidadAnterior Then
                    tabla.Rows.RemoveAt(contador - 1)
                    tabla.AcceptChanges()
                    contador = 1
                Else
                    contador += 1
                End If

            End While
        End If

        Me.gridResultado.DataSource = tabla

        oDa.Dispose()
        oDs.Dispose()
        command.Dispose()
        conn.Close()
        Cursor = Cursors.Arrow
             
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Excel.gridToExcel(Me.gridResultado)
    End Sub
End Class