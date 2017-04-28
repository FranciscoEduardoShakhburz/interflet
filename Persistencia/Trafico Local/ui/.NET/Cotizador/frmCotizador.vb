Public Class frmCotizador
    Dim ctodieselsiniva, FactorKM, FactorDias, FactorKMFull, FactorDiasFull As Decimal
    Dim CtoDieConsuSen, CtoDieConsuFull, SobreCosto As Decimal
    Dim Bit_Full, Bit_Porc As Boolean
    Dim Tipo_Cotizacion, Tipo_Remolque, incremento As Integer

    Private Sub frmCotizador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        Me.Trafico_plazaTableAdapter.Fill(Me.ProduccionInterfletdbDataSet2.trafico_plaza)
        Me.DieselTableAdapter.Fill(Me.ProduccionInterfletdbDataSet4.UP_Consulta_CostoDiesel)
        Me.ctodieselsiniva = Me.ProduccionInterfletdbDataSet4.Tables(0).Rows(0).Item("CtoSinIVA").ToString()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Limpiar()
        Me.cmbOrigen.SelectedItem = 0
        Me.cmbDestino.SelectedItem = 0
        Me.TxtCliente.Text = ""
        Me.cmbTipoViaje.SelectedItem = 0
        Me.cmbTipoRemolque.SelectedItem = 0
        Me.MaskedTextBox1.Text = ""
        Me.TxtKm.Text = ""
        Me.TxtTiempo.Text = ""
        Me.TxtCasetas.Text = ""
        Me.TxtRendDiesel.Text = ""
        Me.TxtCtoDiesel.Text = ""
        Me.TxtCtoDieConsumo.Text = ""
        Me.TxtManiobras.Text = ""
        Me.grdResultado.Rows.Clear()
        Me.grdResultadoFull.Rows.Clear()
    End Sub

    Private Sub CmbOrigen_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigen.Leave
        Me.Cat_DestinoTableAdapter.FillBy(Me.ProduccionInterfletdbDataSet1.Cat_Destino, Me.cmbOrigen.SelectedValue)
    End Sub

    Private Sub cmbDestino_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDestino.Leave
        Me.TxtKm.Text = Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("Cant_KM").ToString()
        Me.TxtTiempo.Text = Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("Cant_DiasViaje").ToString()

        Me.TxtCasetas.Text = Format(CDbl(Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("Monto_Casetas").ToString()) / 1.16, "#,###,##0.#0")
        Me.TxtCtoDiesel.Text = Format(ctodieselsiniva, "###,##0.#0")
        Me.TxtCliente.Focus()
    End Sub

    Private Function ValidaDatos() As Boolean
        If Me.cmbTipoCotizacion.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar el tipo de Cotización", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.cmbTipoCotizacion.Focus()
            Return False
        End If

        If Me.TxtManiobras.Text = "" Then
            MessageBox.Show("Debe capturar el importe de las Maniobras", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.TxtManiobras.Focus()
            Return False
        End If

        If Me.TxtIncremento.Text = "" Then
            MessageBox.Show("Debe capturar el incremento en la tarifa del contenedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.TxtIncremento.Focus()
            Return False
        End If

        If Me.cmbTipoRemolque.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar el Tipo de Remolque", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.cmbTipoRemolque.Focus()
            Return False
        End If

        If Me.TxtUtilMax.Text = "" And Me.TxtUtilMin.Text = "" And Me.TxtMtoUtilMin.Text = "" And Me.TxtMtoUtilMax.Text = "" Then
            MsgBox("Debe capturar un intervalo de utilidad a revisar", MsgBoxStyle.Exclamation, "Cotizador Interflet")
            Me.TabControl1.Focus()
            Return False
        Else
            If Me.TxtUtilMax.Text = "" And Me.TxtUtilMin.Text <> "" Then
                MsgBox("Debe capturar el porcentaje de utilidad maxima", MsgBoxStyle.Exclamation, "Cotizador Interflet")
                Me.TxtUtilMax.Focus()
                Return False
            End If
            If Me.TxtUtilMax.Text <> "" And Me.TxtUtilMin.Text = "" Then
                MsgBox("Debe capturar el porcentaje de utilidad minima", MsgBoxStyle.Exclamation, "Cotizador Interflet")
                Me.TxtUtilMin.Focus()
                Return False
            End If
            If Me.TxtMtoUtilMin.Text = "" And Me.TxtMtoUtilMax.Text <> "" Then
                MsgBox("Debe capturar el monto de utilidad maxima", MsgBoxStyle.Exclamation, "Cotizador Interflet")
                Me.TxtMtoUtilMin.Focus()
                Return False
            End If
            If Me.TxtMtoUtilMin.Text <> "" And Me.TxtMtoUtilMax.Text = "" Then
                MsgBox("Debe capturar el monto de utilidad minima", MsgBoxStyle.Exclamation, "Cotizador Interflet")
                Me.TxtMtoUtilMax.Focus()
                Return False
            End If
        End If

        If Me.TxtSobrecosto.Text <> "" Then
            SobreCosto = CDbl(Me.TxtSobrecosto.Text) / 100
        Else
            SobreCosto = 0
        End If

        Return True

    End Function

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim gastos, tarifa, utilidad, comision, sueldo, porcentaje As Decimal
        Dim UtilMin, UtilMax As Decimal
        Dim i As Integer

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        If ValidaDatos() Then
            If Me.cmbTipoViaje.SelectedItem = "Full" Then
                Bit_Full = True
            Else
                Bit_Full = False
            End If


            If Me.cmbTipoCotizacion.SelectedItem = "Sencillo" Then
                Tipo_Cotizacion = 1
            Else
                If Me.cmbTipoCotizacion.SelectedItem = "Full" Then
                    Tipo_Cotizacion = 2
                Else
                    Tipo_Cotizacion = 3
                End If
            End If

            If Me.cmbTipoRemolque.SelectedItem = "Chasis Fijo de 24'" Then
                Tipo_Remolque = 1
            Else
                If Me.cmbTipoRemolque.SelectedItem = "Chasis de 40'" Then
                    Tipo_Remolque = 2
                Else
                    Tipo_Remolque = 3
                End If
            End If

            If Me.TxtUtilMin.Text <> "" Then
                Bit_Porc = True
            Else
                Bit_Porc = False
            End If

            Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()


            Dim oCommand As SqlClient.SqlCommand = _
                New SqlClient.SqlCommand("UP_Calcula_Cotizacion", oConexion)

            Dim oParameter As SqlClient.SqlParameter
            Try
                oParameter = oCommand.Parameters.Add("@Origen", SqlDbType.Int)
                oParameter.Value = Convert.ToInt32(Me.cmbOrigen.SelectedValue)
                oParameter = oCommand.Parameters.Add("@TipoViaje", SqlDbType.Bit)
                oParameter.Value = Convert.ToBoolean(Bit_Full)
                oParameter = oCommand.Parameters.Add("@TipoRemolque", SqlDbType.Int)
                oParameter.Value = Convert.ToInt32(Tipo_Remolque)
                oParameter = oCommand.Parameters.Add("@Bit_Seguro", SqlDbType.Bit)
                oParameter.Value = Convert.ToBoolean(Me.CheckBox1.Checked)
                oParameter = oCommand.Parameters.Add("@TipoCotizacion", SqlDbType.Int)
                oParameter.Value = Tipo_Cotizacion

                oCommand.CommandType = CommandType.StoredProcedure
                oConexion.Open()

                oDa = New SqlClient.SqlDataAdapter(oCommand)
                oDs = New System.Data.DataSet()
                oDa.Fill(oDs)

                FactorKM = CDbl(oDs.Tables(0).Rows(0).Item("FactorKM").ToString())
                FactorDias = oDs.Tables(0).Rows(0).Item("FactorDia").ToString()

                FactorKMFull = CDbl(oDs.Tables(0).Rows(0).Item("FactorKMFull").ToString())
                FactorDiasFull = oDs.Tables(0).Rows(0).Item("FactorDiaFull").ToString()

            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString)
            End Try

            Try
                comision = CDbl(TxtComision.Text) / 100
                incremento = CInt(TxtIncremento.Text)
                sueldo = Convert.ToDecimal(TxtSueldoOper.Text) / 100
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.grdResultado.Rows.Clear()
            Me.grdResultadoFull.Rows.Clear()

            If Tipo_Cotizacion = 1 Then
                tarifa = 2400
                utilidad = 0
                porcentaje = 0
                i = 0
                gastos = -CtoDieConsuSen - Convert.ToDecimal(TxtManiobras.Text) - Convert.ToDecimal(Me.TxtCasetas.Text) - (FactorKM * Convert.ToDecimal(TxtKm.Text)) - (FactorDias * Convert.ToDecimal(TxtTiempo.Text))

                If Bit_Porc = True Then
                    UtilMin = Convert.ToDecimal(TxtUtilMin.Text) / 100
                    UtilMax = Convert.ToDecimal(TxtUtilMax.Text) / 100

                    While porcentaje <= UtilMax
                        utilidad = tarifa - (tarifa * comision + tarifa * sueldo) - (tarifa * SobreCosto) + gastos
                        porcentaje = utilidad / tarifa
                        If porcentaje >= UtilMin Then
                            i = Me.grdResultado.Rows.Add()
                            Me.grdResultado.Rows(i).Cells("Tarifa").Value = Format(tarifa, "$ ###,###,##0.#0")
                            Me.grdResultado.Rows(i).Cells("MtoUtil").Value = Format(utilidad, "$ ###,###,##0.#0")
                            Me.grdResultado.Rows(i).Cells("PorcUtil").Value = Format(porcentaje, "##0.#0 %")
                        End If
                        tarifa = tarifa + incremento
                    End While
                Else
                    UtilMin = Convert.ToDecimal(Me.TxtMtoUtilMin.Text)
                    UtilMax = Convert.ToDecimal(Me.TxtMtoUtilMax.Text)

                    While tarifa <= UtilMax
                        utilidad = tarifa - (tarifa * comision + tarifa * sueldo) - (tarifa * SobreCosto) + gastos
                        porcentaje = utilidad / tarifa
                        If tarifa >= UtilMin Then
                            i = Me.grdResultado.Rows.Add()
                            Me.grdResultado.Rows(i).Cells("Tarifa").Value = Format(tarifa, "$ ###,###,##0.#0")
                            Me.grdResultado.Rows(i).Cells("MtoUtil").Value = Format(utilidad, "$ ###,###,##0.#0")
                            Me.grdResultado.Rows(i).Cells("PorcUtil").Value = Format(porcentaje, "##0.#0 %")
                        End If
                        tarifa = tarifa + incremento
                    End While
                    tarifa = tarifa + incremento
                End If
            Else
                If Tipo_Cotizacion = 2 Then
                    tarifa = 2400
                    utilidad = 0
                    porcentaje = 0
                    i = 0
                    gastos = -CtoDieConsuFull - Convert.ToDecimal(TxtManiobras.Text) - Convert.ToDecimal(Me.TxtCasetas.Text) - (FactorKM * Convert.ToDecimal(TxtKm.Text)) - (FactorDias * Convert.ToDecimal(TxtTiempo.Text))

                    If Bit_Porc = True Then
                        UtilMin = Convert.ToDecimal(TxtUtilMin.Text) / 100
                        UtilMax = Convert.ToDecimal(TxtUtilMax.Text) / 100

                        While porcentaje <= UtilMax
                            utilidad = (tarifa * 2) - ((tarifa * 2) * comision + (tarifa * 2) * sueldo) - (tarifa * SobreCosto) + gastos
                            porcentaje = utilidad / (tarifa * 2)
                            If porcentaje >= UtilMin Then
                                i = Me.grdResultadoFull.Rows.Add()
                                Me.grdResultadoFull.Rows(i).Cells("TarifaFull").Value = Format(tarifa, "$ ###,###,##0.#0")
                                Me.grdResultadoFull.Rows(i).Cells("MtoUtilFull").Value = Format(utilidad, "$ ###,###,##0.#0")
                                Me.grdResultadoFull.Rows(i).Cells("PorcUtilFull").Value = Format(porcentaje, "##0.#0 %")
                            End If
                            tarifa = tarifa + incremento
                        End While
                    Else
                        UtilMin = Convert.ToDecimal(Me.TxtMtoUtilMin.Text)
                        UtilMax = Convert.ToDecimal(Me.TxtMtoUtilMax.Text)

                        While tarifa <= UtilMax
                            utilidad = (tarifa * 2) - ((tarifa * 2) * comision + (tarifa * 2) * sueldo) - (tarifa * SobreCosto) + gastos
                            porcentaje = utilidad / (tarifa * 2)
                            If tarifa >= UtilMin Then
                                i = Me.grdResultadoFull.Rows.Add()
                                Me.grdResultadoFull.Rows(i).Cells("TarifaFull").Value = Format(tarifa, "$ ###,###,##0.#0")
                                Me.grdResultadoFull.Rows(i).Cells("MtoUtilFull").Value = Format(utilidad, "$ ###,###,##0.#0")
                                Me.grdResultadoFull.Rows(i).Cells("PorcUtilFull").Value = Format(porcentaje, "##0.#0 %")
                            End If
                            tarifa = tarifa + incremento
                        End While
                        tarifa = tarifa + incremento
                    End If
                Else
                    tarifa = 2400
                    utilidad = 0
                    porcentaje = 0
                    i = 0
                    gastos = -CtoDieConsuSen - Convert.ToDecimal(TxtManiobras.Text) - Convert.ToDecimal(Me.TxtCasetas.Text) - (FactorKM * Convert.ToDecimal(TxtKm.Text)) - (FactorDias * Convert.ToDecimal(TxtTiempo.Text))

                    If Bit_Porc = True Then
                        UtilMin = Convert.ToDecimal(TxtUtilMin.Text) / 100
                        UtilMax = Convert.ToDecimal(TxtUtilMax.Text) / 100

                        While porcentaje <= UtilMax
                            utilidad = tarifa - (tarifa * comision + tarifa * sueldo) - (tarifa * SobreCosto) + gastos
                            porcentaje = utilidad / tarifa
                            If porcentaje >= UtilMin Then
                                i = Me.grdResultado.Rows.Add()
                                Me.grdResultado.Rows(i).Cells("Tarifa").Value = Format(tarifa, "$ ###,###,##0.#0")
                                Me.grdResultado.Rows(i).Cells("MtoUtil").Value = Format(utilidad, "$ ###,###,##0.#0")
                                Me.grdResultado.Rows(i).Cells("PorcUtil").Value = Format(porcentaje, "##0.#0 %")
                            End If
                            tarifa = tarifa + incremento
                        End While
                    Else
                        UtilMin = Convert.ToDecimal(Me.TxtMtoUtilMin.Text)
                        UtilMax = Convert.ToDecimal(Me.TxtMtoUtilMax.Text)

                        While tarifa <= UtilMax
                            utilidad = tarifa - (tarifa * comision + tarifa * sueldo) - (tarifa * SobreCosto) + gastos
                            porcentaje = utilidad / tarifa
                            If tarifa >= UtilMin Then
                                i = Me.grdResultado.Rows.Add()
                                Me.grdResultado.Rows(i).Cells("Tarifa").Value = Format(tarifa, "$ ###,###,##0.#0")
                                Me.grdResultado.Rows(i).Cells("MtoUtil").Value = Format(utilidad, "$ ###,###,##0.#0")
                                Me.grdResultado.Rows(i).Cells("PorcUtil").Value = Format(porcentaje, "##0.#0 %")
                            End If
                            tarifa = tarifa + incremento
                        End While
                        tarifa = tarifa + incremento
                    End If

                    gastos = -CtoDieConsuFull - Convert.ToDecimal(TxtManiobras.Text) - Convert.ToDecimal(Me.TxtCasetas.Text) - (FactorKM * Convert.ToDecimal(TxtKm.Text)) - (FactorDias * Convert.ToDecimal(TxtTiempo.Text))
                    If Bit_Porc = True Then
                        tarifa = 2400
                        utilidad = 0
                        porcentaje = 0
                        i = 0

                        UtilMin = Convert.ToDecimal(TxtUtilMin.Text) / 100
                        UtilMax = Convert.ToDecimal(TxtUtilMax.Text) / 100

                        While porcentaje <= UtilMax
                            utilidad = (tarifa * 2) - ((tarifa * 2) * comision + (tarifa * 2) * sueldo) - (tarifa * SobreCosto) + gastos
                            porcentaje = utilidad / (tarifa * 2)
                            If porcentaje >= UtilMin Then
                                i = Me.grdResultadoFull.Rows.Add()
                                Me.grdResultadoFull.Rows(i).Cells("TarifaFull").Value = Format(tarifa, "$ ###,###,##0.#0")
                                Me.grdResultadoFull.Rows(i).Cells("MtoUtilFull").Value = Format(utilidad, "$ ###,###,##0.#0")
                                Me.grdResultadoFull.Rows(i).Cells("PorcUtilFull").Value = Format(porcentaje, "##0.#0 %")
                            End If
                            tarifa = tarifa + incremento
                        End While
                    Else
                        UtilMin = Convert.ToDecimal(Me.TxtMtoUtilMin.Text)
                        UtilMax = Convert.ToDecimal(Me.TxtMtoUtilMax.Text)

                        While tarifa <= UtilMax
                            utilidad = (tarifa * 2) - ((tarifa * 2) * comision + (tarifa * 2) * sueldo) - (tarifa * SobreCosto) + gastos
                            porcentaje = utilidad / (tarifa * 2)
                            If tarifa >= UtilMin Then
                                i = Me.grdResultadoFull.Rows.Add()
                                Me.grdResultadoFull.Rows(i).Cells("TarifaFull").Value = Format(tarifa, "$ ###,###,##0.#0")
                                Me.grdResultadoFull.Rows(i).Cells("MtoUtilFull").Value = Format(utilidad, "$ ###,###,##0.#0")
                                Me.grdResultadoFull.Rows(i).Cells("PorcUtilFull").Value = Format(porcentaje, "##0.#0 %")
                            End If
                            tarifa = tarifa + incremento
                        End While
                        tarifa = tarifa + incremento
                    End If
                End If
            End If
            Me.btnExportar.Enabled = True
            Me.BtnGuardar.Enabled = True
        End If
    End Sub

    Private Sub TabControl1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Leave
        If Me.TxtUtilMax.Text = "" And Me.TxtUtilMin.Text = "" And Me.TxtMtoUtilMin.Text = "" And Me.TxtMtoUtilMax.Text = "" Then
            MsgBox("Debe capturar un intervalo de utilidad a revisar", MsgBoxStyle.Exclamation, "Cotizador Interflet")
            Me.TabControl1.Focus()
        Else
            If Me.TxtUtilMax.Text = "" And Me.TxtUtilMin.Text <> "" Then
                MsgBox("Debe capturar el porcentaje de utilidad maxima", MsgBoxStyle.Exclamation, "Cotizador Interflet")
                Me.TxtUtilMax.Focus()
            End If
            If Me.TxtUtilMax.Text <> "" And Me.TxtUtilMin.Text = "" Then
                MsgBox("Debe capturar el porcentaje de utilidad minima", MsgBoxStyle.Exclamation, "Cotizador Interflet")
                Me.TxtUtilMin.Focus()
            End If
            If Me.TxtMtoUtilMin.Text = "" And Me.TxtMtoUtilMax.Text <> "" Then
                MsgBox("Debe capturar el monto de utilidad maxima", MsgBoxStyle.Exclamation, "Cotizador Interflet")
                Me.TxtMtoUtilMin.Focus()
            End If
            If Me.TxtMtoUtilMin.Text <> "" And Me.TxtMtoUtilMax.Text = "" Then
                MsgBox("Debe capturar el monto de utilidad minima", MsgBoxStyle.Exclamation, "Cotizador Interflet")
                Me.TxtMtoUtilMax.Focus()
            End If
        End If
    End Sub

    Private Sub TxtSueldoOper_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSueldoOper.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) _
        And e.KeyChar <> "." Then
            e.Handled = True
        End If


        If e.KeyChar = "." And Me.Text.Contains(".") Then
            e.Handled = False
        End If




        If e.KeyChar = "." And Me.Text.Length < 1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtComision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComision.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) _
        And e.KeyChar <> "." Then
            e.Handled = True
        End If


        If e.KeyChar = "." And Me.TxtComision.Text.Contains(".") Then
            e.Handled = False
        End If




        If e.KeyChar = "." And Me.TxtComision.Text.Length < 1 Then
            e.Handled = False
        End If
    End Sub


    Private Sub MaskedTextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.Leave
        Dim rendiesen, rendiefull As Decimal

        If Me.cmbTipoViaje.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar el tipo de viaje", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.cmbTipoViaje.Focus()
        Else
            If Me.MaskedTextBox1.Text = "" Then
                MessageBox.Show("Debe capturar el PESO de la mercancia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
                Me.MaskedTextBox1.Focus()
            Else
                If cmbTipoViaje.SelectedItem = "Sencillo" Then
                    If CDbl(MaskedTextBox1.Text) >= 0 And CDbl(MaskedTextBox1.Text) <= 10.99 Then
                        Me.TxtRendDiesel.Text = Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("RendDieselSen_00_10").ToString()
                    Else
                        If CDbl(MaskedTextBox1.Text) >= 11 Then
                            Me.TxtRendDiesel.Text = Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("RendDieselSen_11_27").ToString()
                        End If
                    End If
                Else
                    If CDbl(MaskedTextBox1.Text) >= 0 And CDbl(MaskedTextBox1.Text) <= 27.99 Then
                        Me.TxtRendDiesel.Text = Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("RendDieselFull_00_27").ToString()
                    Else
                        If CDbl(MaskedTextBox1.Text) >= 28 Then
                            Me.TxtRendDiesel.Text = Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("RendDieselFull_28_54").ToString()
                        End If
                    End If
                End If

                If Convert.ToDecimal(Me.TxtRendDiesel.Text) = 0 Then
                    MessageBox.Show("El rendimiento del diesel debe ser mayor a Cero. Favor de captura en el Catalogo de Destinos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
                    Me.TxtRendDiesel.Focus()
                Else

                    Me.TxtCtoDieConsumo.Text = Format((Convert.ToDecimal(Me.TxtKm.Text) / Convert.ToDecimal(Me.TxtRendDiesel.Text)) * CDbl(Me.TxtCtoDiesel.Text), "###,###,##0.#0")
                    If cmbTipoViaje.SelectedItem = "Sencillo" Then
                        If CDbl(MaskedTextBox1.Text) >= 0 And CDbl(MaskedTextBox1.Text) <= 27.99 Then
                            rendiefull = CDbl(Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("RendDieselFull_00_27").ToString())
                        Else
                            rendiefull = CDbl(Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("RendDieselFull_28_54").ToString())
                        End If

                        CtoDieConsuSen = CDbl(Me.TxtCtoDieConsumo.Text)
                        If rendiefull = 0 Then
                            rendiefull = Convert.ToDecimal(Me.TxtRendDiesel.Text)
                        End If
                        CtoDieConsuFull = (Convert.ToDecimal(Me.TxtKm.Text) / rendiefull) * CDbl(Me.TxtCtoDiesel.Text)
                    Else
                        If CDbl(MaskedTextBox1.Text) >= 0 And CDbl(MaskedTextBox1.Text) <= 10.99 Then
                            rendiesen = CDbl(Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("RendDieselSen_00_10").ToString())
                        Else
                            rendiesen = CDbl(Me.ProduccionInterfletdbDataSet1.Tables(0).Rows(cmbDestino.SelectedIndex).Item("RendDieselSen_11_27").ToString())
                        End If
                        CtoDieConsuFull = CDbl(Me.TxtCtoDieConsumo.Text)
                        If rendiesen = 0 Then
                            rendiesen = Convert.ToDecimal(Me.TxtRendDiesel.Text)
                        End If
                        CtoDieConsuSen = (Convert.ToDecimal(Me.TxtKm.Text) / rendiesen) * CDbl(Me.TxtCtoDiesel.Text)
                    End If
                    Me.TxtManiobras.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub cmbTipoViaje_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoViaje.Leave
        If Me.cmbTipoViaje.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar el tipo de viaje", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0)
            Me.cmbTipoViaje.Focus()
        End If
    End Sub

    Private Sub TxtCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCliente.Leave
        Me.cmbTipoViaje.Focus()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If (((grdResultado.Columns.Count = 0) Or (grdResultado.Rows.Count = 0)) And ((grdResultadoFull.Columns.Count = 0) Or (grdResultadoFull.Rows.Count = 0))) Then
            Exit Sub
        End If

        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim bit_hojanueva As Boolean
        wBook = excel.Workbooks.Add()

        bit_hojanueva = False

        If ((grdResultado.Columns.Count <> 0) Or (grdResultado.Rows.Count <> 0)) Then

            Dim dset As New DataSet

            dset.Tables.Add()

            For i As Integer = 0 To grdResultado.ColumnCount - 1
                If grdResultado.Columns(i).Visible = True Then
                    dset.Tables(0).Columns.Add(grdResultado.Columns(i).HeaderText)
                End If
            Next

            Dim dr1 As DataRow
            For i As Integer = 0 To grdResultado.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To grdResultado.Columns.Count - 1
                    If grdResultado.Columns(j).Visible = True Then
                        dr1(j) = grdResultado.Rows(i).Cells(j).Value
                    End If
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next

            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next
            wSheet.Name = "Sencillo"
            wSheet.Columns.AutoFit()
            bit_hojanueva = True
        End If

        If ((grdResultadoFull.Columns.Count <> 0) Or (grdResultadoFull.Rows.Count <> 0)) Then

            Dim dsetf As New DataSet

            dsetf.Tables.Add()

            For i As Integer = 0 To grdResultadoFull.ColumnCount - 1
                If grdResultadoFull.Columns(i).Visible = True Then
                    dsetf.Tables(0).Columns.Add(grdResultadoFull.Columns(i).HeaderText)
                End If
            Next

            Dim dr2 As DataRow
            For i As Integer = 0 To grdResultadoFull.RowCount - 1
                dr2 = dsetf.Tables(0).NewRow
                For j As Integer = 0 To grdResultadoFull.Columns.Count - 1
                    If grdResultadoFull.Columns(j).Visible = True Then
                        dr2(j) = grdResultadoFull.Rows(i).Cells(j).Value
                    End If
                Next
                dsetf.Tables(0).Rows.Add(dr2)
            Next


            If bit_hojanueva = True Then
                wSheet = wBook.Sheets.Add()
            Else
                wSheet = wBook.ActiveSheet()
            End If


            Dim dt As System.Data.DataTable = dsetf.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next
            wSheet.Name = "Full"
            wSheet.Columns.AutoFit()
        End If
        excel.Visible = True
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Dim oConexion As SqlClient.SqlConnection = _
            New SqlClient.SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProduccionInterfletdb;Data Source=ARCHIVOS")
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_Cotizacion", oConexion)

        Dim oParameter As SqlClient.SqlParameter
        Try
            oParameter = oCommand.Parameters.Add("@Origen", SqlDbType.Int)
            oParameter.Value = Convert.ToInt32(Me.cmbOrigen.SelectedValue)
            oParameter = oCommand.Parameters.Add("@Destino", SqlDbType.Int)
            oParameter.Value = Convert.ToInt32(Me.cmbDestino.SelectedValue)
            oParameter = oCommand.Parameters.Add("@Cliente", SqlDbType.VarChar)
            oParameter.Value = Trim(Me.TxtCliente.Text)
            oParameter = oCommand.Parameters.Add("@TipoViaje", SqlDbType.Bit)
            oParameter.Value = Convert.ToBoolean(Bit_Full)
            oParameter = oCommand.Parameters.Add("@TipoRemolque", SqlDbType.Int)
            oParameter.Value = Convert.ToInt32(Tipo_Remolque)
            oParameter = oCommand.Parameters.Add("@Peso", SqlDbType.Decimal)
            oParameter.Value = CDbl(Me.MaskedTextBox1.Text)
            oParameter = oCommand.Parameters.Add("@CtoDiesel", SqlDbType.Money)
            oParameter.Value = CDbl(Me.TxtCtoDiesel.Text)
            oParameter = oCommand.Parameters.Add("@MontoManiobras", SqlDbType.Money)
            oParameter.Value = CDbl(Me.TxtManiobras.Text)
            oParameter = oCommand.Parameters.Add("@PorcComision", SqlDbType.Decimal)
            oParameter.Value = CDbl(Me.TxtComision.Text) / 100
            oParameter = oCommand.Parameters.Add("@PorcSueldoOper", SqlDbType.Decimal)
            oParameter.Value = CDbl(Me.TxtSueldoOper.Text) / 100
            oParameter = oCommand.Parameters.Add("@Bit_Seguro", SqlDbType.Bit)
            oParameter.Value = Convert.ToBoolean(Me.CheckBox1.Checked)
            oParameter = oCommand.Parameters.Add("@Volumen", SqlDbType.Decimal)
            If Me.TxtVolumen.Text = "" Then
                oParameter.Value = 0
            Else
                oParameter.Value = CDbl(Me.TxtVolumen.Text)
            End If
            oParameter = oCommand.Parameters.Add("@Frecuencia", SqlDbType.VarChar)
            oParameter.Value = Me.TxtFrecuencia.Text
            oParameter = oCommand.Parameters.Add("@PorcSobrecosto", SqlDbType.Decimal)
            oParameter.Value = SobreCosto
            oParameter = oCommand.Parameters.Add("@Incrementos", SqlDbType.Int)
            oParameter.Value = incremento
            oParameter = oCommand.Parameters.Add("@TipoCotizacion", SqlDbType.Int)
            oParameter.Value = Tipo_Cotizacion

            If Bit_Porc = True Then
                oParameter = oCommand.Parameters.Add("@PorcUtilMin", SqlDbType.Decimal)
                oParameter.Value = CDbl(Me.TxtUtilMin.Text) / 100
                oParameter = oCommand.Parameters.Add("@PorcUtilMax", SqlDbType.Decimal)
                oParameter.Value = CDbl(Me.TxtUtilMax.Text) / 100
                oParameter = oCommand.Parameters.Add("@MontoUtilMin", SqlDbType.Money)
                oParameter.Value = 0
                oParameter = oCommand.Parameters.Add("@MontoUtilMax", SqlDbType.Money)
                oParameter.Value = 0
            Else
                oParameter = oCommand.Parameters.Add("@PorcUtilMin", SqlDbType.Decimal)
                oParameter.Value = 0
                oParameter = oCommand.Parameters.Add("@PorcUtilMax", SqlDbType.Decimal)
                oParameter.Value = 0
                oParameter = oCommand.Parameters.Add("@MontoUtilMin", SqlDbType.Money)
                oParameter.Value = CDbl(Me.TxtMtoUtilMin.Text)
                oParameter = oCommand.Parameters.Add("@MontoUtilMax", SqlDbType.Money)
                oParameter.Value = CDbl(Me.TxtMtoUtilMax.Text)
            End If

            If Tipo_Cotizacion = 1 Then
                oParameter = oCommand.Parameters.Add("@PorcUtilSencillo", SqlDbType.Decimal)
                oParameter.Value = CDbl(Me.TxtPorcCotSen.Text) / 100
                oParameter = oCommand.Parameters.Add("@MontoUtilSencillo", SqlDbType.Money)
                oParameter.Value = CDbl(Me.TxtCotizacionSen.Text)
                oParameter = oCommand.Parameters.Add("@PorcUtilFull", SqlDbType.Decimal)
                oParameter.Value = 0
                oParameter = oCommand.Parameters.Add("@MontoUtilFull", SqlDbType.Money)
                oParameter.Value = 0
            Else
                oParameter = oCommand.Parameters.Add("@PorcUtilSencillo", SqlDbType.Decimal)
                oParameter.Value = 0
                oParameter = oCommand.Parameters.Add("@MontoUtilSencillo", SqlDbType.Money)
                oParameter.Value = 0
                oParameter = oCommand.Parameters.Add("@PorcUtilFull", SqlDbType.Decimal)
                oParameter.Value = CDbl(Me.TxtPorcCotFull.Text) / 100
                oParameter = oCommand.Parameters.Add("@MontoUtilFull", SqlDbType.Money)
                oParameter.Value = CDbl(Me.TxtCotizacionFull.Text)
            End If

            oParameter = oCommand.Parameters.Add("@Observaciones", SqlDbType.Text)
            oParameter.Value = Me.TxtObservaciones.Text

            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()

            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            Me.TxtNoCotizacion.Text = oDs.Tables(0).Rows(0).Item("Id_Num_Cotizacion").ToString()

            Me.Label30.Visible = True
            Me.TxtNoCotizacion.Visible = True

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdResultado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdResultado.CellContentClick
        Me.TxtCotizacionSen.Text = CDbl(Convert.ToString(Me.grdResultado.CurrentRow.Cells("Tarifa").Value).Replace("$ ", ""))
        Me.TxtPorcCotSen.Text = CDbl(Convert.ToString(Me.grdResultado.CurrentRow.Cells("PorcUtil").Value).Replace(" %", ""))
    End Sub

    Private Sub grdResultadoFull_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdResultadoFull.CellContentClick
        Me.TxtCotizacionFull.Text = CDbl(Convert.ToString(Me.grdResultadoFull.CurrentRow.Cells("TarifaFull").Value).Replace("$ ", ""))
        Me.TxtPorcCotFull.Text = CDbl(Convert.ToString(Me.grdResultadoFull.CurrentRow.Cells("PorcUtilFull").Value).Replace(" %", ""))
    End Sub
End Class