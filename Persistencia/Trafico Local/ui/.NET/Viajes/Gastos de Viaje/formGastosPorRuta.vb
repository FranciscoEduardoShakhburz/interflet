Imports System.Data.SqlClient


Public Class formGastosPorRuta
    Public id_ruta As Integer
    Public vehiculo, ruta, config, pension, maniobras As Integer
    Public tablaGastos As DataTable
    Public cliente, unidad, operador, rutta, vale As String
    Public casetasIave As New ArrayList
    Public costosIave As New ArrayList
    Public casetas As New ArrayList
    Public costos As New ArrayList
    Public casetaEfectivo, anticipo, transfer, complemento, costoD As New Double
    Dim objeto As New Email

    Private Sub formGastosPorRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.getConfigViaje()
        Me.radioTracto.Checked = True
        Me.tablaGastos = New DataTable()
        Me.txtManiobras.Text = "130.00"
        Me.txtPension.Text = "200.00"
        Me.txtCantidadViajes.Focus()
    End Sub

    Private Sub TextBox1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRuta.MouseDoubleClick
        formRutas.Show()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRuta.KeyDown
        If e.KeyCode = Keys.F2 Then
            formRutas.Show()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitud.Click
        Me.getCasetasIave()
        Me.getCasetasNoIave()
        'Me.getDatosExtras()
        Me.escribirExcel()
    End Sub

    Private Sub getConfigViaje()
        For Each configViaje As TipoViaje In TipoViajeDAO.getListTiposViaje()
            Me.comboConfigViaje.Items.Add(configViaje)
        Next
        Me.comboConfigViaje.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Cursor = Cursors.WaitCursor

        If Not (String.IsNullOrEmpty(Me.txtRuta.Text.Trim) _
                OrElse String.IsNullOrEmpty(Me.txtCantidadViajes.Text.Trim) _
                OrElse String.IsNullOrEmpty(Me.txtPension.Text.Trim) _
                OrElse String.IsNullOrEmpty(Me.txtManiobras.Text.Trim)) Then
            Dim configViaje As Integer = DirectCast(Me.comboConfigViaje.SelectedItem, TipoViaje).IdTipo
            Dim cantidadViajes As Integer = IIf(String.IsNullOrEmpty(Me.txtCantidadViajes.Text.Trim), 1, Convert.ToInt32(Me.txtCantidadViajes.Text.Trim))

            Dim pension As Decimal = Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.txtPension.Text.Trim), "0.00", Convert.ToDecimal(Me.txtPension.Text.Trim)))

            Dim maniobras As Decimal = Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.txtManiobras.Text.Trim), "0.00", Convert.ToDecimal(Me.txtManiobras.Text.Trim)))

            Dim conn As SqlConnection = Connection.getInstance.getConnection()
            Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_GASTOS_POR_RUTA", conn)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@ID_RUTA", Me.id_ruta)
            command.Parameters.AddWithValue("@ID_CONFIG_VIAJE", configViaje)
            command.Parameters.AddWithValue("@VEHICULO", Me.vehiculo)
            command.Parameters.AddWithValue("@CANTIDAD_VIAJES", cantidadViajes)
            command.Parameters.AddWithValue("@PENSION", pension)
            command.Parameters.AddWithValue("@MANIOBRAS", maniobras)

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            Me.tablaGastos.Merge(table)
            Me.gridGastosRuta.DataSource = tablaGastos
        Else
            MessageBox.Show("Escriba todos los campos")
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub radioTracto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioTracto.CheckedChanged
        If Me.radioTracto.Checked Then
            Me.vehiculo = 1
        Else
            Me.vehiculo = 2
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Cursor = Cursors.WaitCursor
        Excel.gridToExcel(Me.gridGastosRuta)
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnSobres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSobres.Click
        Cursor = Cursors.WaitCursor
        If Me.gridGastosRuta.Rows.Count > 0 Then
            Dim word As Word = New Word()
            Dim word2 As Word = New Word()
            Dim sql As String = "select top (1) id from trafico_gastos_vales order by id desc"
            Dim sql2 As String = "INSERT INTO trafico_gastos_vales (FECHA) VALUES (GETDATE ())"
            Dim reg As SqlDataReader
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            For i As Integer = 0 To Me.gridGastosRuta.Rows.Count - 2
                Dim command As SqlCommand = New SqlCommand(sql, conn)
                Dim command2 As SqlCommand = New SqlCommand(sql2, conn)
                Dim gasto As GastosRuta = New GastosRuta()
                conn.Open()
                reg = command.ExecuteReader
                reg.Read()
                gasto.id = reg.GetValue(0) + 1
                reg.Close()
                gasto.ruta = Me.gridGastosRuta.Rows(i).Cells(0).Value.ToString()
                gasto.viaje = Me.gridGastosRuta.Rows(i).Cells(1).Value.ToString()
                gasto.unidad = Me.gridGastosRuta.Rows(i).Cells(2).Value.ToString()
                gasto.operador = Me.gridGastosRuta.Rows(i).Cells(3).Value.ToString()
                gasto.configviaje = Me.gridGastosRuta.Rows(i).Cells(4).Value.ToString()
                gasto.cliente = Me.gridGastosRuta.Rows(i).Cells(5).Value.ToString()
                gasto.efectivo_casetas = Me.gridGastosRuta.Rows(i).Cells(6).Value.ToString()
                gasto.efectivo_iave = Me.gridGastosRuta.Rows(i).Cells(7).Value.ToString()
                gasto.litros_diesel = Me.gridGastosRuta.Rows(i).Cells(10).Value.ToString()
                gasto.costo_diesel = Me.gridGastosRuta.Rows(i).Cells(9).Value.ToString()
                gasto.pension = Me.gridGastosRuta.Rows(i).Cells(10).Value.ToString()
                gasto.maniobras = Me.gridGastosRuta.Rows(i).Cells(11).Value.ToString()
                gasto.anticipo = Me.gridGastosRuta.Rows(i).Cells(15).Value.ToString()
                gasto.transferencia = (Me.gridGastosRuta.Rows(i).Cells(17).Value.ToString()) - (Me.gridGastosRuta.Rows(i).Cells(16).Value.ToString())
                gasto.total_gastos = Me.gridGastosRuta.Rows(i).Cells(18).Value.ToString()
                gasto.transferencia_sig_dia = Me.gridGastosRuta.Rows(i).Cells(19).Value.ToString()
                gasto.cantidad_viaje = Me.gridGastosRuta.Rows(i).Cells(16).Value.ToString()
                word.valeDeCaja(gasto)
                command2.ExecuteNonQuery()
                conn.Close()
            Next

          

        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Cursor = Cursors.WaitCursor
        Dim sql As String = ""
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        If Me.gridGastosRuta.Rows.Count > 0 Then
            For i As Integer = 0 To Me.gridGastosRuta.Rows.Count - 1

                'command.CommandType = CommandType.Text
                If gridGastosRuta.ColumnCount = 22 Then
                    sql = "insert into trafico_gastos_ruta2 values (@ruta,@viaje,@unidad,@operador,@configviaje,@cliente,@efectivo_casetas,@efectivo_iave,@total_caseta,@kilometros,@litros_diesel,@complemento,@costo_diesel,@transferencia_proveedor,@pension,@maniobras,@anticipo,@transferencia,@total_gastos,@transferencia_sig_dia,@fecha_movimiento,@gasto_extra)"
                Else
                    sql = " update trafico_gastos_ruta2 set ruta = @ruta, viaje=@viaje, operador = @operador,unidad= @unidad, configviaje = @configviaje, cliente = @cliente, @efectivo_casetas = @efectivo_casetas, efectivo_iave = @efectivo_iave, total_casetas = @total_caseta, kilimetros = @kilometros, litros_diesel = @litros_diesel, complemento = @complemento, costo_diesel = @costo_diesel, transferencia_proveedor = @transferencia_proveedor, pension = @pension, maniobras = @maniobras, anticipo = @anticipo, transferencia = @transferencia, total_gastos = @total_gastos, transferencia_sig_dia = @transferencia_sig_dia, fecha_movimiento = @fecha_movimiento, gasto_extra = @gasto_extra where id = @id"

                End If
                Dim command As SqlCommand = New SqlCommand(sql, conn)
                conn.Open()

                If gridGastosRuta.ColumnCount > 20 Then
                    command.Parameters.AddWithValue("@id", Me.gridGastosRuta.Rows(i).Cells(21).Value.ToString())
                End If
                command.Parameters.AddWithValue("@ruta", Me.gridGastosRuta.Rows(i).Cells(0).Value.ToString())
                command.Parameters.AddWithValue("@viaje", Me.gridGastosRuta.Rows(i).Cells(1).Value.ToString())
                command.Parameters.AddWithValue("@unidad", Me.gridGastosRuta.Rows(i).Cells(2).Value.ToString())
                command.Parameters.AddWithValue("@operador", Me.gridGastosRuta.Rows(i).Cells(3).Value.ToString())
                command.Parameters.AddWithValue("@configviaje", Me.gridGastosRuta.Rows(i).Cells(4).Value.ToString())
                command.Parameters.AddWithValue("@cliente", Me.gridGastosRuta.Rows(i).Cells(5).Value.ToString())

                command.Parameters.AddWithValue("@efectivo_casetas", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(6).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(6).Value.ToString())))

                command.Parameters.AddWithValue("@efectivo_iave", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(7).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(7).Value.ToString())))

                command.Parameters.AddWithValue("@total_caseta", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(8).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(8).Value.ToString())))

                command.Parameters.AddWithValue("@kilometros", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(9).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(9).Value.ToString())))

                command.Parameters.AddWithValue("@litros_diesel", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(10).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(10).Value.ToString())))

                command.Parameters.AddWithValue("@complemento", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(11).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(11).Value.ToString())))

                command.Parameters.AddWithValue("@costo_diesel", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(12).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(12).Value.ToString())))

                command.Parameters.AddWithValue("@transferencia_proveedor", Me.gridGastosRuta.Rows(i).Cells(13).Value.ToString())

                command.Parameters.AddWithValue("@pension", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(14).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(14).Value.ToString())))

                command.Parameters.AddWithValue("@maniobras", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(15).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(15).Value.ToString())))

                command.Parameters.AddWithValue("@anticipo", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(16).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(16).Value.ToString())))

                command.Parameters.AddWithValue("@transferencia", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(17).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(17).Value.ToString())))

                command.Parameters.AddWithValue("@total_gastos", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(18).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(18).Value.ToString())))

                command.Parameters.AddWithValue("@transferencia_sig_dia", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(19).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(19).Value.ToString())))

                command.Parameters.AddWithValue("@fecha_movimiento", DateTime.Now)

                command.Parameters.AddWithValue("@gasto_extra", Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.gridGastosRuta.Rows(i).Cells(19).Value.ToString()), 0.0, Me.gridGastosRuta.Rows(0).Cells(20).Value.ToString())))

                command.ExecuteNonQuery()
            Next
            conn.Close()
            conn.Dispose()
        End If
        Cursor = Cursors.Arrow
        MessageBox.Show("¡Gastos guardados!")
    End Sub


    Public Sub getCasetasIave()
        Dim reg As SqlDataReader
        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        Dim command As SqlCommand = New SqlCommand("up_get_caseta_tarifa", conn) 'Solo nos traemos las que son de caseta IAVE
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@nruta", gridGastosRuta.CurrentRow.Cells(0).Value.ToString)
        If gridGastosRuta.CurrentRow.Cells(4).Value.ToString = "full" Then
            command.Parameters.AddWithValue("no_ejes", 9)
        Else
            command.Parameters.AddWithValue("no_ejes", 5)
        End If
        conn.Open()
        reg = command.ExecuteReader
        While reg.Read
            casetasIave.Add(reg.GetValue(0))
            costosIave.Add(reg.GetValue(1))
        End While
        conn.Close()
    End Sub

    Public Sub getCasetasNoIave()
        Dim reg As SqlDataReader
        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        Dim command As SqlCommand = New SqlCommand("up_get_caseta_tarifa_NoIave", conn) 'Solo nos traemos las que no son de caseta IAVE
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@nruta", gridGastosRuta.CurrentRow.Cells(0).Value.ToString)
        If gridGastosRuta.CurrentRow.Cells(4).Value.ToString = "full" Then
            command.Parameters.AddWithValue("no_ejes", 9)
        Else
            command.Parameters.AddWithValue("no_ejes", 5)
        End If
        conn.Open()
        reg = command.ExecuteReader
        While reg.Read
            casetas.Add(reg.GetValue(0))
            costos.Add(reg.GetValue(1))
        End While
        conn.Close()
    End Sub

    Public Sub getDatosExtras()
        If Not (String.IsNullOrEmpty(Me.txtRuta.Text.Trim) _
                        OrElse String.IsNullOrEmpty(Me.txtCantidadViajes.Text.Trim) _
                        OrElse String.IsNullOrEmpty(Me.txtPension.Text.Trim) _
                        OrElse String.IsNullOrEmpty(Me.txtManiobras.Text.Trim)) Then
            Dim configViaje As Integer = DirectCast(Me.comboConfigViaje.SelectedItem, TipoViaje).IdTipo
            Dim cantidadViajes As Integer = IIf(String.IsNullOrEmpty(Me.txtCantidadViajes.Text.Trim), 1, Convert.ToInt32(Me.txtCantidadViajes.Text.Trim))

            Dim pension As Decimal = Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.txtPension.Text.Trim), "0.00", Convert.ToDecimal(Me.txtPension.Text.Trim)))

            Dim maniobras As Decimal = Convert.ToDecimal(IIf(String.IsNullOrEmpty(Me.txtManiobras.Text.Trim), "0.00", Convert.ToDecimal(Me.txtManiobras.Text.Trim)))
            Dim reg As SqlDataReader
            Dim conn As SqlConnection = Connection.getInstance.getConnection()
            Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_GASTOS_POR_RUTA", conn)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@ID_RUTA", Me.id_ruta)
            command.Parameters.AddWithValue("@ID_CONFIG_VIAJE", configViaje)
            command.Parameters.AddWithValue("@VEHICULO", Me.vehiculo)
            command.Parameters.AddWithValue("@CANTIDAD_VIAJES", 1)
            command.Parameters.AddWithValue("@PENSION", pension)
            command.Parameters.AddWithValue("@MANIOBRAS", maniobras)
            conn.Open()
            reg = command.ExecuteReader
            reg.Read()
            rutta = reg.GetValue(0)
            casetaEfectivo = reg.GetValue(6)
            maniobras = reg.GetValue(15)
            anticipo = reg.GetValue(16)
            transfer = reg.GetValue(17)
            complemento = reg.GetValue(11)
            costoD = reg.GetValue(12)
            conn.Close()
        Else
            MessageBox.Show("Escriba todos los campos")
        End If

    End Sub
    Public Sub escribirExcel()
        Dim App As New Microsoft.Office.Interop.Excel.Application
        Dim libro As Microsoft.Office.Interop.Excel.Workbook
        Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim r As Microsoft.Office.Interop.Excel.Range
        Dim fileName As String = "H:\Sica\LisRep\Reportes Interflet\log.jpg"
        libro = App.Workbooks.Add


        hoja = libro.Worksheets.Add
        hoja.Cells(1, 5) = "PLAN DE RUTA"
        hoja.Range("D1:F1").Font.Bold = True
        hoja.Range("D1:F1").Font.Size = 16
        hoja.Cells(2, 2) = "CIA INTERNACIONAL DE FLETAMIENTOS, S.A DE C.V"
        hoja.Range("B2:K2").Font.Bold = True
        hoja.Range("B2:K2").Font.Size = 16
        hoja.Cells(3, 4) = txtRuta.Text
        hoja.Range("D3:H3").Font.Bold = True
        hoja.Range("D3:H3").Font.Size = 14
        hoja.Cells(4, 3) = "  Casetas IAVE"
        hoja.Range("B4:K4").Font.Bold = True
        hoja.Range("B4:K4").Font.Size = 14
        hoja.Cells(5, 2) = "Caseta"
        hoja.Range("B5:J5").Font.Bold = True
        hoja.Range("B5:J5").Font.Size = 14
        hoja.Cells(5, 5) = "Costo"

        hoja.Cells(4, 8) = "Gastos Operador"
        hoja.Cells(5, 7) = "Concepto"
        hoja.Cells(5, 10) = "Monto"


        Dim i As Integer = 0
        Dim totalIave As Integer = 0
        While i < casetasIave.Count  'Imprimimos las CasetasIAVE
            hoja.Cells(6 + i, 2) = casetasIave.Item(i).ToString
            hoja.Cells(6 + i, 5) = costosIave.Item(i).ToString
            totalIave = totalIave + costosIave.Item(i)
            i = i + 1
        End While
        hoja.Cells((6 + casetasIave.Count), 2) = "TOTAL"
        hoja.Cells((6 + casetasIave.Count), 5) = totalIave
        hoja.Cells((7 + casetasIave.Count), 3) = "Casetas Efectivo" 'Encabezados de la 
        hoja.Cells((8 + casetasIave.Count), 2) = "Caseta"
        hoja.Cells((8 + casetasIave.Count), 5) = "Costo"
        Dim rango1 As String = "B" & (7 + casetasIave.Count) & ":E" & ((7 + casetasIave.Count))
        Dim rango2 As String = "B" & (8 + casetasIave.Count) & ":E" & ((8 + casetasIave.Count))
        hoja.Range(rango1).Font.Bold = True
        hoja.Range(rango1).Font.Size = 16
        hoja.Range(rango2).Font.Bold = True
        hoja.Range(rango2).Font.Size = 14

        Dim J As Integer = 0
        Dim totalCaseta As Integer = 0
        While J < casetas.Count 'Imprimimos las Casetas No IAVE
            hoja.Cells((9 + casetasIave.Count) + J, 2) = casetas.Item(J).ToString
            hoja.Cells((9 + casetasIave.Count) + J, 5) = costos.Item(J).ToString
            totalCaseta = totalCaseta + costos.Item(J)
            J = J + 1
        End While
        hoja.Cells((9 + casetasIave.Count + casetas.Count), 2) = "TOTAL"
        hoja.Cells((9 + casetasIave.Count + casetas.Count), 5) = totalCaseta
        hoja.Cells((10 + casetasIave.Count + casetas.Count), 1) = "*Debe seguir el plan de ruta, el no seguirlo puede afectar"
        hoja.Cells((11 + casetasIave.Count + casetas.Count), 1) = "sus tiempos de viaje y rendimientos"
        Dim rango3 As String = "A" & (10 + casetasIave.Count + casetas.Count) & ":F" & (11 + casetasIave.Count + casetas.Count)
        hoja.Range(rango3).Font.Bold = True
        'Imprimir Gastos de Operadors 
        hoja.Cells(6, 7) = "Pension"
        hoja.Cells(6, 10) = Me.gridGastosRuta.Rows(0).Cells(14).Value.ToString()
        hoja.Cells(7, 7) = "Casetas en Efectivo"
        hoja.Cells(7, 10) = Me.gridGastosRuta.Rows(0).Cells(6).Value.ToString()
        hoja.Cells(8, 7) = "Anticipo de Comision"
        hoja.Cells(8, 10) = Me.gridGastosRuta.Rows(0).Cells(16).Value.ToString()
        hoja.Cells(9, 7) = "Maniobras"
        hoja.Cells(9, 10) = Me.gridGastosRuta.Rows(0).Cells(15).Value.ToString()
        hoja.Cells(10, 7) = "Diesel"
        hoja.Cells(10, 10) = Me.gridGastosRuta.Rows(0).Cells(12).Value.ToString() '"---"
        hoja.Cells(11, 7) = "Total de Gastos"
        hoja.Cells(11, 10) = "" & ((Me.gridGastosRuta.Rows(0).Cells(14).Value) + (Me.gridGastosRuta.Rows(0).Cells(6).Value) + (Me.gridGastosRuta.Rows(0).Cells(16).Value) + (Me.gridGastosRuta.Rows(0).Cells(15).Value))
        hoja.Cells(12, 7) = "Anticipo"
        hoja.Cells(12, 10) = Me.gridGastosRuta.Rows(0).Cells(16).Value.ToString()
        hoja.Cells(13, 7) = "Transeferencia Sig. Dia"
        hoja.Cells(13, 10) = Me.gridGastosRuta.Rows(0).Cells(19).Value.ToString()


        If Me.gridGastosRuta.Rows(0).Cells(11).Value > 0 Then
            hoja.Cells(15, 7) = "Carga de Combustible Diesel"
            hoja.Range("G15:H15").Font.Bold = True
            hoja.Range("G15:H15").Font.Size = 14
            hoja.Range("G15:J15").Merge(True)
            hoja.Range("G15:J15").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Cells(17, 7) = "Cantidad"
            hoja.Cells(17, 9) = "Precio"
            hoja.Cells(17, 11) = "Total"
            hoja.Range("G17:K17").Font.Bold = True
            hoja.Cells(18, 7) = Me.gridGastosRuta.Rows(0).Cells(11).Value
            hoja.Cells(18, 9) = 14.2
            hoja.Cells(18, 11) = ((Me.gridGastosRuta.Rows(0).Cells(11).Value) * (14.2))
            hoja.Range("G17:K17").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight


            If Me.gridGastosRuta.Rows(0).Cells(13).Value.ToString = "NO" Then 'Validamos si ay proveedor de combustible (no, es si) 
                Dim conn As SqlConnection = Connection.getInstance().getConnection()
                Dim reg As SqlDataReader
                Dim sql As String = "Select nombre_proveedor,nombre_contacto,observaciones_proveedor from trafico_proveedor_ruta where id_ruta = " & id_ruta
                Dim command As SqlCommand = New SqlCommand(sql, conn)
                conn.Open()
                reg = command.ExecuteReader
                reg.Read()
                hoja.Cells(20, 7) = reg.GetValue(0)
                hoja.Cells(21, 7) = reg.GetValue(1)
                hoja.Cells(22, 7) = reg.GetValue(2)
                hoja.Range("G22:J25").MergeCells = True
                hoja.Range("G22:J25").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                hoja.Range("G22:J25").WrapText = True
                hoja.Cells(27, 7) = "*Debe Entregar factura,ticket de la bomba, y voucher de pago de tarjeta, todos con firma de operador, para su pronto pago"
                conn.Close()
                hoja.Range("G27:J28").MergeCells = True
                hoja.Range("G27:J28").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                hoja.Range("G27:J28").WrapText = True
                hoja.Range("G27:J28").Font.Bold = True
            Else
                hoja.Cells(27, 7) = "*Debe entregar factura, ticket de la bomba, y voucher de pago de tarjeta, todos con firma de operador, para su pago"
                hoja.Range("G27:J28").MergeCells = True
                hoja.Range("G27:J28").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                hoja.Range("G27:J28").Font.Bold = True
                hoja.Range("G27:J30").WrapText = True
            End If

        End If
        If Me.gridGastosRuta.Rows(0).Cells(1).Value.ToString = "" Then
            MessageBox.Show("Ingrese Numero de Viaje")
        Else
            Dim con As SqlConnection = Connection.getInstance().getConnection()
            Dim command1 As SqlCommand
            Dim reg1 As SqlDataReader
            Dim sql3 As String = "select tc.desc_convenio from trafico_guia tg, desp_pedido dp,trafico_convenio tc where tg.no_viaje = " & Me.gridGastosRuta.Rows(0).Cells(1).Value & "and dp.no_guia = tg.no_guia and tc.id_convenio = dp.id_convenio group by desc_convenio"
            command1 = New SqlCommand(sql3, con)
            command1.CommandType = CommandType.Text
            con.Open()
            reg1 = command1.ExecuteReader
            reg1.Read()
            hoja.Cells(30, 7) = "Convenio: " & reg1.GetValue(0)
            hoja.Cells(32, 7) = "Cliente: " & Me.gridGastosRuta.Rows(0).Cells(5).Value
            r = hoja.Cells(1, 11)
            'hoja.Shapes.AddPicture(fileName, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoTrue, r.Left, r.Top, 68, 64)

            con.Close()
        End If
        casetasIave.Clear()
        costosIave.Clear()
        costos.Clear()
        casetas.Clear()
        MessageBox.Show(casetasIave.Count & costosIave.Count & costos.Count & casetas.Count)
        App.Application.Visible = True
    End Sub

    Private Sub bto_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_consultar.Click
        Cursor = Cursors.WaitCursor
        Dim cn As SqlConnection = Connection.getInstance.getConnection()
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim command As SqlCommand = New SqlCommand("up_consulta_trafico_gastos", cn)
        command.CommandType = CommandType.StoredProcedure
        cn.Open()
        command.CommandTimeout = 600
        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@FECHAINI", Me.FechaI.Value.Date)
        param = command.Parameters.AddWithValue("@FECHAFIN", Me.FechaF.Value.Date)
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        gridGastosRuta.DataSource = oDs.Tables(0)
        grid_totales.DataSource = oDs.Tables(1)
        cn.Close()
        Cursor = Cursors.Arrow

        gridGastosRuta.Columns(2).ReadOnly = True
        gridGastosRuta.Columns(3).ReadOnly = True
        gridGastosRuta.Columns(4).ReadOnly = True
        gridGastosRuta.Columns(5).ReadOnly = True
        gridGastosRuta.Columns(6).ReadOnly = True
        gridGastosRuta.Columns(7).ReadOnly = True
        gridGastosRuta.Columns(8).ReadOnly = True
        gridGastosRuta.Columns(9).ReadOnly = True
        gridGastosRuta.Columns(10).ReadOnly = True
        gridGastosRuta.Columns(11).ReadOnly = True
        gridGastosRuta.Columns(12).ReadOnly = True
        gridGastosRuta.Columns(13).ReadOnly = True
        gridGastosRuta.Columns(14).ReadOnly = True
        gridGastosRuta.Columns(15).ReadOnly = True
        gridGastosRuta.Columns(16).ReadOnly = True
        gridGastosRuta.Columns(17).ReadOnly = True
        gridGastosRuta.Columns(18).ReadOnly = True
        gridGastosRuta.Columns(19).ReadOnly = True
        gridGastosRuta.Columns(20).ReadOnly = True
        gridGastosRuta.Columns(21).ReadOnly = True

    End Sub
    Private Sub txtRuta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuta.Leave
        Dim bandera As Integer
        Dim sql As String = "select autorizada from trafico_ruta_autorizada where id_ruta = " & Me.id_ruta
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim reg As SqlDataReader
        conn.Open()
        reg = command.ExecuteReader
        reg.Read()
        If reg.HasRows Then
            bandera = reg.GetValue(0)
        Else
            bandera = 2
        End If
        If bandera > 1 Then
            MessageBox.Show("Ruta NO Autorizada")
        End If
        conn.Close()
    End Sub
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String
        Dim cuerpo As String '= "No.Unidad   Operador            Configuracion   Litros  Costo   $Cantidad   Ruta        Contacto        Proveedor           Datos"
        Dim correos(1) As String
        Dim costo As Double = 14.2
        Dim cont As Integer = 0
        'correos(0) = "cesar.herver@hinojosa.com.mx"
        'correos(1) = "guadalupe.izaguirre@hinojosa.com.mx"

        Dim dominio As String = "@hinojosa.com.mx"

        Dim usuarioPara As String
        Dim idPersonalPara As Integer
        'Prueba
        idPersonalPara = 6942 'Omar
        usuarioPara = ObtenerDatosCorreo.nombreUsuario(idPersonalPara)
        usuarioPara = usuarioPara & dominio

        correos(0) = usuarioPara

        While cont < gridGastosRuta.Rows.Count 'se obtienen las rutas que tienen proveedores
            If Me.gridGastosRuta.Rows(cont).Cells(13).Value.ToString = "NO" Then
                sql = "select a.nombre_proveedor,a.nombre_contacto,a.observaciones_proveedor from trafico_proveedor_ruta a,trafico_ruta b where b.desc_ruta =  '" & Me.gridGastosRuta.Rows(cont).Cells(0).Value.ToString & "' and  a.id_ruta = b.id_ruta"
                Dim command As SqlCommand = New SqlCommand(sql, conn)
                Dim reg As SqlDataReader
                conn.Open()
                reg = command.ExecuteReader
                reg.Read()
                cuerpo = "Unidad: " & Me.gridGastosRuta.Rows(cont).Cells(2).Value.ToString & "    Operador: " & Me.gridGastosRuta.Rows(cont).Cells(3).Value.ToString & vbCr & vbCr & "Configuracion: " & Me.gridGastosRuta.Rows(cont).Cells(4).Value.ToString & "    Litros: " & Me.gridGastosRuta.Rows(cont).Cells(11).Value.ToString & vbCr & vbCr & "Costo Diesel:  " & costo & "   $Cantidad:  " & Me.gridGastosRuta.Rows(cont).Cells(12).Value.ToString & "   Ruta:   " & Me.gridGastosRuta.Rows(cont).Cells(0).Value.ToString & vbCr & vbCr & "Contacto:   " & reg.GetValue(0) & " Proveedor:  " & reg.GetValue(1) & vbCr & vbCr & "Datos:  " & reg.GetValue(2)
                reg.Close()
                conn.Close()
            End If
            cont = cont + 1

        End While
        If cont = 0 Then
            MessageBox.Show("No existen proveedores en las Rutas Ingresadas")
        Else
            objeto.sendEmail("Solicitud de Transferencia", cuerpo, correos)
            MessageBox.Show("Correo Enviado con Exito")
        End If

    End Sub

    Private Sub gridGastosRuta_RowLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles gridGastosRuta.CellEndEdit


        If e.ColumnIndex = 1 Then
            Dim viaje As Integer = Me.gridGastosRuta.Rows(0).Cells(1).Value
            Dim sql As String = "select a.id_unidad,b.nombre,c.nombre from trafico_guia a join personal_personal b on a.id_personal = b.id_personal join trafico_cliente c on a.id_cliente = c.id_cliente where a.no_viaje = " & Viaje & " group by a.id_unidad,b.nombre,c.nombre"
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            Dim reg As SqlDataReader
            conn.Open()
            reg = command.ExecuteReader
            reg.Read()
            If reg.HasRows Then
                Me.gridGastosRuta.Rows(0).Cells(2).Value = reg.GetValue(0)
                Me.gridGastosRuta.Rows(0).Cells(3).Value = reg.GetValue(1)
                Me.gridGastosRuta.Rows(0).Cells(5).Value = reg.GetValue(2)
            End If
        End If

    End Sub

End Class