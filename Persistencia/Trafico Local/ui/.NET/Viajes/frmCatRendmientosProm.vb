Public Class frmCatRendmientosProm
    Private Origen, Destino, Cliente As Integer
    Private exitsub As Boolean
    Public plaza, client, dest As Integer
    Public lol As Integer = 1

    Private Sub frmCatRendmientosProm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProduccionInterfletdbDataSet9.trafico_tipo_viaje' table. You can move, or remove it, as needed.
        Cursor.Current = Cursors.AppStarting
        Me.Trafico_tipo_viajeTableAdapter.Fill(Me.ProduccionInterfletdbDataSet9.trafico_tipo_viaje)
        Me.Trafico_clienteTableAdapter.Fill(Me.PI_Clientes.trafico_cliente)
        Me.Trafico_motorTableAdapter.Fill(Me.PI_TipoMotor.trafico_motor)
        Me.Trafico_plazaTableAdapter.Fill(Me.ProduccionInterfletdbDataSet2.trafico_plaza)
        PI_Rendimientos.EnforceConstraints = False
        Me.PI_Ruta.EnforceConstraints = False
        exitsub = False

        If lol = 2 Then

            Me.Ejecutar()

        End If

        Cursor.Current = Cursors.Arrow

    End Sub

#Region "Combos Principales"
    Private Sub cmbOrigen_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigen.Leave
        Me.Trafico_rutaTableAdapter.FillBy(Me.PI_Ruta.trafico_ruta, Me.cmbOrigen.SelectedValue)
    End Sub

    Private Sub cmbOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigen.SelectedIndexChanged
        Me.Cat_DestinoTableAdapter.FillBy(Me.ProduccionInterfletdbDataSet1.Cat_Destino, Me.cmbOrigen.SelectedValue)
        Me.Trafico_rutaTableAdapter.FillBy(Me.PI_Ruta.trafico_ruta, Me.cmbOrigen.SelectedValue)
    End Sub

    Private Sub cmbDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDestino.SelectedIndexChanged
        Me.ClienteTableAdapter.Fill(Me.PI_Clientes.cliente)
    End Sub
#End Region

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        plaza = Me.cmbOrigen.SelectedValue
        client = Me.cmbCliente.SelectedValue
        dest = Me.cmbDestino.SelectedValue

        Me.Consultar()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        CatRendimientosEstBindingSource.CurrencyManager.Position = 0
        CatRendimientosEstBindingSource = New BindingSource()
        CatRendimientosEstBindingSource.DataSource = PI_Rendimientos.Tables("Cat_RendimientosEst")
        BindingNavigator1.BindingSource = CatRendimientosEstBindingSource
        If CatRendimientosEstBindingSource.Count = 0 Then
            CatRendimientosEstBindingSource.CurrencyManager.AddNew()
        End If
        Me.cmbOrigen.Enabled = False
        Me.cmbDestino.Enabled = False
        Me.cmbCliente.Enabled = False
        Me.btnGuardar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Validar() Then
            Try
                Me.grdRendimientos.Enabled = False
                Origen = Me.cmbOrigen.SelectedValue
                Destino = Me.cmbDestino.SelectedValue
                Cliente = Me.cmbCliente.SelectedValue
                Dim tipoViaje As Integer = 0

                For Each row As DataGridViewRow In grdRendimientos.Rows
                    If IsDBNull(row.Cells("RangoPesoIni").Value) = False Then

                        tipoViaje = CInt(row.Cells("TipoViaje").Value)

                        Guardar(CInt(row.Cells("Id_Tipo_Motor").Value), tipoViaje, CInt(row.Cells("RangoPesoIni").Value), CInt(row.Cells("RangoPesoFin").Value), _
                        CDbl(row.Cells("KmPromedio").Value), CDbl(row.Cells("LtsPromedio").Value), CDbl(row.Cells("RendPromedio").Value), CInt(row.Cells("CantViajes").Value))
                    End If
                Next

                MessageBox.Show("Datos guardados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
                Me.grdRendimientos.Enabled = True
                Me.cmbOrigen.Enabled = True
                Me.cmbDestino.Enabled = True
                Me.cmbCliente.Enabled = True
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString)
            End Try
        End If
    End Sub


    Private Sub Guardar(ByVal TipoMotor As Integer, ByVal TipoViaje As Integer, ByVal PesoIni As Integer, _
ByVal PesoFin As Integer, ByVal KmProm As Decimal, ByVal LtsProm As Decimal, ByVal RendProm As Decimal, ByVal CantViajes As Integer)
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()
        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Guarda_CatRendimientosEst", oConexion)

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Dim oParameter As SqlClient.SqlParameter
        Try
            oParameter = oCommand.Parameters.Add("@Id_Num_Origen", SqlDbType.Int)
            oParameter.Value = Origen
            oParameter = oCommand.Parameters.Add("@Id_Num_Destino", SqlDbType.Int)
            oParameter.Value = Destino
            oParameter = oCommand.Parameters.Add("@Id_Cliente", SqlDbType.Int)
            oParameter.Value = Cliente
            oParameter = oCommand.Parameters.Add("@Id_Tipo_Motor", SqlDbType.Int)
            oParameter.Value = TipoMotor
            oParameter = oCommand.Parameters.Add("@TipoViaje", SqlDbType.Int)
            oParameter.Value = TipoViaje
            oParameter = oCommand.Parameters.Add("@RangoPesoIni", SqlDbType.Int)
            oParameter.Value = PesoIni
            oParameter = oCommand.Parameters.Add("@RangoPesoFin", SqlDbType.Int)
            oParameter.Value = PesoFin
            oParameter = oCommand.Parameters.Add("@KmPromedio", SqlDbType.Decimal)
            oParameter.Value = KmProm
            oParameter = oCommand.Parameters.Add("@LtsPromedio", SqlDbType.Decimal)
            oParameter.Value = LtsProm
            oParameter = oCommand.Parameters.Add("@RendPromedio", SqlDbType.Decimal)
            oParameter.Value = RendProm
            oParameter = oCommand.Parameters.Add("@CantViajes", SqlDbType.Int)
            oParameter.Value = CantViajes
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)
        Catch ex As Exception
            If ex.Message.Contains("null") Then
                System.Windows.Forms.MessageBox.Show("Agrega el cliente de manera correcta")
            End If
        End Try
    End Sub

    Private Sub grdRendimientos_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRendimientos.CellLeave
        Dim tipoviaje As Integer
        If e.ColumnIndex = Me.grdRendimientos.Columns.Item("TipoMotor").Index Then
            Me.grdRendimientos.CurrentRow.Cells("Id_Num_Origen").Value = plaza 'Me.cmbOrigen.SelectedValue
            Me.grdRendimientos.CurrentRow.Cells("Id_Num_Destino").Value = dest 'Me.cmbDestino.SelectedValue
            Me.grdRendimientos.CurrentRow.Cells("Id_Cliente").Value = client 'Me.cmbCliente.SelectedValue
        End If
        If e.ColumnIndex = Me.grdRendimientos.Columns.Item("TipoViaje2").Index Then
            If IsNothing(Me.grdRendimientos.CurrentRow.Cells("TipoMotor").Value) Then
                MessageBox.Show("Debe seleccionar el Tipo de Motor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
                Exit Sub
            Else
                Me.grdRendimientos.CurrentRow.Cells("Id_Tipo_Motor").Value = Me.grdRendimientos.CurrentRow.Cells("TipoMotor").Value
            End If
        End If
        If e.ColumnIndex = Me.grdRendimientos.Columns.Item("RangoPesoIni").Index Then
            If IsNothing(Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value) Then
                MessageBox.Show("Debe seleccionar el Tipo de Viaje", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
                Exit Sub
            Else
                'If Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value = "Sencillo" Then
                '    tipoviaje = 1
                'Else
                '    If Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value = "Full" Then
                '        tipoviaje = 2
                '    Else
                '        tipoviaje = 3
                '    End If
                'End If

                If Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value = "Full" Then
                    tipoviaje = 1
                ElseIf Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value = "Sencillo" Then
                    tipoviaje = 2
                ElseIf Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value = "Full-Reparto" Then
                    tipoviaje = 3
                ElseIf Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value = "Tramo Sencillo (F)" Then
                    tipoviaje = 4
                ElseIf Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value = "Tramo Sencillo (S)" Then
                    tipoviaje = 5
                ElseIf Me.grdRendimientos.CurrentRow.Cells("TipoViaje2").Value = "Sencillo Reparto" Then
                    tipoviaje = 6
                End If

                Me.grdRendimientos.CurrentRow.Cells("TipoViaje").Value = tipoviaje
            End If
        End If

    End Sub


    Private Function Validar() As Boolean
        For Each row As DataGridViewRow In grdRendimientos.Rows
            If IsDBNull(row.Cells("RangoPesoIni").Value) Then
                MessageBox.Show("Debe capturar el peso inicial", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
                Me.grdRendimientos.CurrentCell = row.Cells("RangoPesoIni")
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub grdRendimientos_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRendimientos.RowLeave
        Dim tipomotor, tipoviaje As Integer
        If Me.grdRendimientos.CurrentRow.Cells("RangoPesoIni").Value > Me.grdRendimientos.CurrentRow.Cells("RangoPesoFin").Value Then
            MessageBox.Show("El peso inicial es mayor que el peso final", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
        Else
            tipomotor = Me.grdRendimientos.CurrentRow.Cells("TipoMotor").Value
            tipoviaje = Me.grdRendimientos.CurrentRow.Cells("TipoViaje").Value
            For i As Integer = 0 To e.RowIndex - 1
                If Me.grdRendimientos.Rows(i).Cells("Id_Tipo_Motor").Value = tipomotor Then
                    If Me.grdRendimientos.Rows(i).Cells("TipoViaje").Value = tipoviaje Then
                        If Me.grdRendimientos.CurrentRow.Cells("RangoPesoIni").Value < Me.grdRendimientos.Rows(i).Cells("RangoPesoFin").Value Then
                            MessageBox.Show("El peso inicial capturado se empalma con uno anterior", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0)
                            grdRendimientos.CurrentCell = Me.grdRendimientos(Me.grdRendimientos.Columns("RangoPesoIni").Index, Me.grdRendimientos.CurrentCell.RowIndex)
                            Exit Sub
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub CortarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripButton.Click
        Me.Cat_RendimientosEstTableAdapter.Delete(Me.grdRendimientos.CurrentRow.Cells("Id_Num_Origen").Value, Me.grdRendimientos.CurrentRow.Cells("Id_Num_Destino").Value, Me.grdRendimientos.CurrentRow.Cells("Id_Cliente").Value, Me.grdRendimientos.CurrentRow.Cells("Id_Tipo_Motor").Value, _
        Me.grdRendimientos.CurrentRow.Cells("TipoViaje").Value, Me.grdRendimientos.CurrentRow.Cells("RangoPesoIni").Value, Me.grdRendimientos.CurrentRow.Cells("RangoPesoFin").Value, Me.grdRendimientos.CurrentRow.Cells("KmPromedio").Value, Me.grdRendimientos.CurrentRow.Cells("LtsPromedio").Value, _
Me.grdRendimientos.CurrentRow.Cells("RendPromedio").Value, Me.grdRendimientos.CurrentRow.Cells("CantViajes").Value)

        Me.btnConsultar_Click(sender, e)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Excel.gridToExcel(Me.grdRendimientos)
    End Sub

    Public Sub Consultar()

        Me.Cat_RendimientosEstTableAdapter.FillBy(Me.PI_Rendimientos.Cat_RendimientosEst, plaza, client, dest)

        For Each row As DataGridViewRow In grdRendimientos.Rows
            row.Cells("TipoMotor").Value = row.Cells("Id_Tipo_Motor").Value
            row.Cells("Id_Cliente").Value = client 'Me.cmbCliente.SelectedValue

            If row.Cells("TipoViaje").Value = 1 Then
                row.Cells("TipoViaje2").Value = "Full"

            ElseIf row.Cells("TipoViaje").Value = 2 Then
                row.Cells("TipoViaje2").Value = "Sencillo"

            ElseIf row.Cells("TipoViaje").Value = 3 Then
                row.Cells("TipoViaje2").Value = "Full-Reparto"

            ElseIf row.Cells("TipoViaje").Value = 4 Then
                row.Cells("TipoViaje2").Value = "Tramo Sencillo (F)"

            ElseIf row.Cells("TipoViaje").Value = 5 Then
                row.Cells("TipoViaje2").Value = "Tramo Sencillo (S)"

            ElseIf row.Cells("TipoViaje").Value = 6 Then
                row.Cells("TipoViaje2").Value = "Sencillo Reparto"
            End If

            row.Cells("TipoMotor").ReadOnly = True
            row.Cells("TipoViaje2").ReadOnly = True
            row.Cells("RangoPesoIni").ReadOnly = True
        Next
        Me.btnExportar.Enabled = True
    End Sub
    Public Sub Ejecutar()
        Me.Consultar()
    End Sub
End Class