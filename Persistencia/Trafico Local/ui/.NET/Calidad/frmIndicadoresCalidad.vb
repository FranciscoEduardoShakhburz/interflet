Imports System.Data.SqlClient

Public Class frmIndicadoresCalidad

    Private area As Integer
    Public fecha As String

    Private Sub frmIndicadoresCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.getCiudades()
        Me.cmbArea.SelectedItem = "Altamira"
        Me.radio12Horas.Checked = True

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try

            Cursor = Cursors.WaitCursor
            Dim index, cellviaje, cellobs, celltarde, cellaccidente, cellObsAccidente, cellCP, cellHoraLlegada As Integer
            index = Me.grdIndicadores.Columns("Llegada con Cliente").Index
            cellviaje = Me.grdIndicadores.Columns("Viaje").Index
            cellCP = Me.grdIndicadores.Columns("CartasPorte").Index
            cellobs = Me.grdIndicadores.Columns("Observaciones").Index
            celltarde = Me.grdIndicadores.Columns("Tarde").Index
            cellaccidente = Me.grdIndicadores.Columns("Accidente").Index
            cellObsAccidente = Me.grdIndicadores.Columns("ObsAccidente").Index
            cellHoraLlegada = Me.grdIndicadores.Columns("Llegada con Cliente").Index

            For Each row As DataGridViewRow In Me.grdIndicadores.Rows
                If IsDBNull(row.Cells(cellHoraLlegada).Value) = False Then

                    Guardar(row.Cells(cellHoraLlegada).Value.ToString(), _
                            row.Cells(cellviaje).Value, _
                            row.Cells(cellCP).Value, _
                            IIf(IsDBNull(row.Cells(index).Value), DateTime.Now, row.Cells(index).Value), row.Cells(cellobs).Value.ToString(), IIf(IsDBNull(row.Cells(celltarde).Value), _
                            Nothing, _
                            row.Cells(celltarde).Value), _
                            IIf(IsDBNull(row.Cells(cellaccidente).Value), Nothing, row.Cells(cellaccidente).Value), _
                            row.Cells(cellObsAccidente).Value.ToString(), _
                            row.Cells("Llegada con Cliente").Value.ToString(), _
                            row.Cells("Salida con Cliente").Value.ToString(), _
                            row.Cells("Estancia").Value.ToString(), _
                            row.Cells("Guia").Value.ToString(), _
                            row.Cells("Pension").Value.ToString(), _
                            row.Cells("Desenlonada").Value.ToString(), _
                            row.Cells("Transito").Value.ToString(), _
                            row.Cells("Maniobras").Value.ToString(), _
                            row.Cells("Otros").Value.ToString())

                End If
            Next

            Cursor = Cursors.Arrow

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try
    End Sub

    Private Sub Guardar( _
                    ByVal HoraLlegada As String, _
                    ByVal Viaje As Integer, _
                    ByVal CartaPorte As String, _
                    ByVal ETAPlanta As Date, _
                    ByVal observaciones As String, _
                    ByVal Tarde As Boolean, _
                    ByVal Accidente As Boolean, _
                    ByVal ObsAccidente As String, _
                    ByVal llegadaCliente As String, _
                    ByVal salidaCliente As String, _
                    ByVal estancia As String, _
                    ByVal guia As String, _
                    ByVal pension As String, _
                    ByVal desenlonada As String, _
                    ByVal transito As String, _
                    ByVal maniobras As String, _
                    ByVal otros As String _
        )

        Cursor = Cursors.WaitCursor
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_IndicadoresCalidad", oConexion)
        Dim oParameter As SqlClient.SqlParameter

        oCommand.CommandType = CommandType.StoredProcedure

        Try

            oConexion.Open()

            With oCommand.Parameters

                .AddWithValue("@Viaje", Viaje)
                .AddWithValue("@CartaPorte", CartaPorte)
                .AddWithValue("@FecPlanta", ETAPlanta)
                .AddWithValue("@HoraLlegada", HoraLlegada)
                .AddWithValue("@Observaciones", observaciones)
                .AddWithValue("@Bit_Tarde", Tarde)
                .AddWithValue("@Bit_Accidente", Accidente)
                .AddWithValue("@ObsAccidente", ObsAccidente)
                .AddWithValue("@LLEGADACLIENTE", llegadaCliente)
                .AddWithValue("@SALIDACLIENTE", salidaCliente)
                .AddWithValue("@ESTANCIA", estancia)
                .AddWithValue("@GUIA", guia)
                .AddWithValue("@PENSION", pension)
                .AddWithValue("@DESENLONADA", desenlonada)
                .AddWithValue("@TRANSITO", transito)
                .AddWithValue("@MANIOBRAS", maniobras)
                .AddWithValue("@OTROS", otros)

            End With

            'oParameter = oCommand.Parameters.Add("@Viaje", SqlDbType.Int)
            'oParameter.Value = Viaje
            'oParameter = oCommand.Parameters.Add("@CartaPorte", SqlDbType.VarChar)
            'oParameter.Value = CartaPorte
            'oParameter = oCommand.Parameters.Add("@FecPlanta", SqlDbType.DateTime)
            'oParameter.Value = ETAPlanta
            'oParameter = oCommand.Parameters.Add("@HoraLlegada", SqlDbType.VarChar)
            'oParameter.Value = HoraLlegada
            'oParameter = oCommand.Parameters.Add("@Observaciones", SqlDbType.VarChar)
            'oParameter.Value = observaciones
            'oParameter = oCommand.Parameters.Add("@Bit_Tarde", SqlDbType.Bit)
            'oParameter.Value = Tarde
            'oParameter = oCommand.Parameters.Add("@Bit_Accidente", SqlDbType.Bit)
            'oParameter.Value = Accidente
            'oParameter = oCommand.Parameters.Add("@ObsAccidente", SqlDbType.VarChar)
            'oParameter.Value = ObsAccidente
            'oParameter = oCommand.Parameters.AddWithValue("@LLEGADACLIENTE", llegadaCliente)
            'oParameter = oCommand.Parameters.AddWithValue("@SALIDACLIENTE", salidaCliente)
            'oParameter = oCommand.Parameters.AddWithValue("@ESTANCIA", estancia)
            'oParameter = oCommand.Parameters.AddWithValue("@GUIA", guia)
            'oParameter = oCommand.Parameters.AddWithValue("@PENSION", pension)
            'oParameter = oCommand.Parameters.AddWithValue("@DESENLONADA", desenlonada)
            'oParameter = oCommand.Parameters.AddWithValue("@TRANSITO", transito)
            'oParameter = oCommand.Parameters.AddWithValue("@MANIOBRAS", maniobras)
            'oParameter = oCommand.Parameters.AddWithValue("@OTROS", otros)
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString)

        Finally

            Cursor = Cursors.Arrow

        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Cursor = Cursors.WaitCursor
        Me.getIndicadoresCalidad()
        Me.selectIndicador()
        Cursor = Cursors.Arrow

    End Sub

#Region "GUI"
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Excel.gridToExcel(Me.grdIndicadores)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub cmbArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArea.SelectedIndexChanged

        If Me.cmbArea.SelectedItem = "Altamira" Then

            Me.area = 1

        ElseIf Me.cmbArea.SelectedItem = "Manzanillo" Then

            Me.area = 2

        ElseIf Me.cmbArea.SelectedItem = "Veracruz" Then

            Me.area = 3

        End If
    End Sub

    Private Sub calcularGastos(ByVal fila As Integer)

        Dim filaActual As DataGridViewRow = Me.grdIndicadores.Rows(fila)
        Dim observaciones As String = filaActual.Cells("Observaciones").Value.ToString().ToUpper().Trim()
        Dim listaObservaciones() As String
        filaActual.Cells("Guia").Value = 0

        If String.IsNullOrEmpty(filaActual.Cells("Pension").Value.ToString().Trim) Then

            filaActual.Cells("Pension").Value = 0

        End If

        filaActual.Cells("Desenlonada").Value = 0

        If Not (String.IsNullOrEmpty(observaciones)) Then

            listaObservaciones = observaciones.Split(",")

            For i As Integer = 0 To listaObservaciones.Length - 1
                If listaObservaciones(i).Contains("NUEVA") Then

                    filaActual.Cells("Guia").Value = 200

                ElseIf listaObservaciones(i).Contains("REPARTO") Then

                    filaActual.Cells("Pension").Value = 200

                ElseIf listaObservaciones(i).Contains("CARGA") Then

                    filaActual.Cells("Desenlonada").Value = 100

                End If
            Next
        End If
    End Sub

    Private Sub calculaGastosPorFecha(ByVal fila As Integer)

        Dim filaActual As DataGridViewRow = Me.grdIndicadores.Rows(fila)
        Dim fechaLlegada As String = filaActual.Cells(13).Value.ToString().Trim()
        Dim fechaSalida As String = filaActual.Cells(14).Value.ToString().Trim()

        If String.IsNullOrEmpty(filaActual.Cells("Pension").Value.ToString().Trim) Then

            filaActual.Cells("Pension").Value = 0

        End If

        filaActual.Cells("Estancia").Value = 0

        If Not (String.IsNullOrEmpty(fechaLlegada) OrElse String.IsNullOrEmpty(fechaSalida)) Then

            Dim fechaLlegadaCliente As DateTime = Convert.ToDateTime(fechaLlegada)
            Dim fechaSalidaCliente As DateTime = Convert.ToDateTime(fechaSalida)
            Dim horasTotales As Integer = Convert.ToInt32(DateDiff(DateInterval.Hour, fechaLlegadaCliente, fechaSalidaCliente))
            Dim horasConvenio As Integer = IIf(filaActual.Cells(11).Value, 12, 24)
            Dim diasTotales As Integer = horasTotales / 24

            If horasConvenio = 12 Then
                If horasTotales >= 36 Then

                    filaActual.Cells("Pension").Value = 200
                    filaActual.Cells("Estancia").Value = diasTotales * 100

                End If
            Else

                If horasTotales >= 48 Then

                    filaActual.Cells("Pension").Value = 200
                    filaActual.Cells("Estancia").Value = diasTotales * 100

                End If
            End If
        End If
    End Sub

    Private Sub grdIndicadores_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdIndicadores.CellEndEdit

        If e.ColumnIndex = 15 Then

            Me.calcularGastos(e.RowIndex)

        End If

        If e.ColumnIndex = 13 OrElse e.ColumnIndex = 14 Then

            calculaGastosPorFecha(e.RowIndex)

        End If
    End Sub
#End Region

#Region "Acceso a Datos"
    Public Sub getIndicadoresCalidad()

        Dim viaje As Integer = Convert.ToInt32(Me.TxtViaje.Text)
        Dim cliente As String = Convert.ToString(Me.TxtCliente.Text)
        Dim fechaInicial As DateTime = Me.cmbFechaIni.Value.Date
        Dim fechaFinal As DateTime = Me.cmbFechaFin.Value.Date
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_Consulta_IndicadoresCalidad", conn)
        Dim param As SqlParameter
        Dim adapter As SqlDataAdapter
        Dim dataSet As DataSet = New DataSet()

        Try

            command.CommandType = CommandType.StoredProcedure
            conn.Open()

            With command.Parameters

                .AddWithValue("@Noviaje", viaje)
                .AddWithValue("@Cliente", cliente)
                .AddWithValue("@FechaIni", fechaInicial)
                .AddWithValue("@FechaFin", fechaFinal)
                .AddWithValue("@Area", Me.area)

            End With

            'param = command.Parameters.AddWithValue("@Noviaje", viaje)
            'param = command.Parameters.AddWithValue("@Cliente", cliente)
            'param = command.Parameters.AddWithValue("@FechaIni", fechaInicial)
            'param = command.Parameters.AddWithValue("@FechaFin", fechaFinal)
            'param = command.Parameters.AddWithValue("@Area", Me.area)

            adapter = New SqlDataAdapter(command)
            adapter.Fill(dataSet)
            Me.grdIndicadores.DataSource = dataSet.Tables(0)

            If Me.grdIndicadores.Rows.Count > 0 Then
                For i As Integer = 0 To Me.grdIndicadores.Rows.Count - 1

                    Me.grdIndicadores.Rows(i).Cells("Estancia").Value = 0.0
                    Me.grdIndicadores.Rows(i).Cells("Guia").Value = 0.0
                    Me.grdIndicadores.Rows(i).Cells("Pension").Value = 0.0
                    Me.grdIndicadores.Rows(i).Cells("Desenlonada").Value = 0.0
                    Me.calcularGastos(i)
                    Me.calculaGastosPorFecha(i)
                    Me.btnGuardar.Enabled = True

                Next
            End If
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub

    Public Sub getCiudades()

        Me.cmbArea.Items.Add("Altamira")
        Me.cmbArea.Items.Add("Manzanillo")
        Me.cmbArea.Items.Add("Veracruz")

    End Sub
#End Region

    Private Sub grdIndicadores_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdIndicadores.CellDoubleClick

        Cursor = Cursors.WaitCursor

        If e.ColumnIndex = 13 OrElse e.ColumnIndex = 14 Then

            Dim unidad As String = Me.grdIndicadores.CurrentRow.Cells(1).Value.ToString()
            Dim viaje As String = Me.grdIndicadores.CurrentRow.Cells(4).Value.ToString()
            Dim clientesSatelital As formHorarioCliente = New formHorarioCliente(unidad, viaje)
            clientesSatelital.ShowDialog()

            Me.grdIndicadores.CurrentRow.Cells(e.ColumnIndex).Value = Me.fecha
            Me.grdIndicadores.CurrentCell = Me.grdIndicadores.CurrentRow.Cells(e.ColumnIndex + 1)

        End If

        Cursor = Cursors.Arrow

    End Sub

    Private Sub radio12Horas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radio12Horas.CheckedChanged

        Me.selectIndicador()

    End Sub

    Private Sub selectIndicador()

        If Me.grdIndicadores.Rows.Count > 0 Then
            For i As Integer = 0 To Me.grdIndicadores.Rows.Count - 1
                If Me.radio12Horas.Checked Then

                    Me.grdIndicadores.Rows(i).Cells(11).Value = True
                    Me.grdIndicadores.Rows(i).Cells(12).Value = False

                Else

                    Me.grdIndicadores.Rows(i).Cells(12).Value = True
                    Me.grdIndicadores.Rows(i).Cells(11).Value = False

                End If
            Next
        End If
    End Sub

    Private Sub grdIndicadores_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdIndicadores.CellMouseClick

        If e.ColumnIndex = 11 Then

            Me.grdIndicadores.Rows(e.RowIndex).Cells(11).Value = True
            Me.grdIndicadores.Rows(e.RowIndex).Cells(12).Value = False

        ElseIf e.ColumnIndex = 12 Then

            Me.grdIndicadores.Rows(e.RowIndex).Cells(12).Value = True
            Me.grdIndicadores.Rows(e.RowIndex).Cells(11).Value = False

        End If

        Me.calculaGastosPorFecha(e.RowIndex)

    End Sub
End Class