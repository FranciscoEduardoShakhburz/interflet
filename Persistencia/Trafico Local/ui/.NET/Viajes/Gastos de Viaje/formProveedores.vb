Imports System.Data.SqlClient


Public Class formProveedores
    Public id_ruta As Integer
    Private Sub formProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.buscarRuta("")
        gridProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        gridProveedores.DefaultCellStyle.WrapMode = DataGridViewTriState.True

    End Sub

    

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim autorizada As Integer = 0
        If ch_autorizada.Checked Then
            autorizada = 1
        End If
        If Me.gridProveedores.Rows.Count > 1 Then

            conn.Open()
            For i As Integer = 0 To Me.gridProveedores.Rows.Count - 2

                Dim command As SqlCommand = New SqlCommand("UP_GUARDA_PROVEEDORES_RUTA", conn)
                command.CommandType = CommandType.StoredProcedure

                Dim configuracionViaje As Integer = IIf(Me.gridProveedores.Rows(i).Cells("configuracion").Value.ToString().Contains("FULL"), 1, 2) 'Me.gridProveedores.Rows(i).Cells("configuracion").Value
                IIf(Me.gridProveedores.Rows(i).Cells("configuracion").Value.ToString().Contains("FULL"), 1, 2)

                command.Parameters.AddWithValue("@ID_PROVEEDOR_RUTA", Me.gridProveedores.Rows(i).Cells("id_proveedor_ruta").Value.ToString())
                command.Parameters.AddWithValue("@NOMBRE_PROVEEDOR", Me.gridProveedores.Rows(i).Cells("nombre_proveedor").Value.ToString())
                command.Parameters.AddWithValue("@NOMBRE_CONTACTO", Me.gridProveedores.Rows(i).Cells("nombre_contacto").Value.ToString())
                command.Parameters.AddWithValue("@DIRECCION_PROVEEDOR ", Me.gridProveedores.Rows(i).Cells("direccion_proveedor").Value.ToString())

                command.Parameters.AddWithValue("@OBSERVACIONES_PROVEEDOR", _
                Me.gridProveedores.Rows(i).Cells("observaciones_proveedor").Value.ToString())

                command.Parameters.AddWithValue("@ID_RUTA", Me.gridRutas.CurrentRow.Cells("ID_RUTA").Value.ToString())
                command.Parameters.AddWithValue("@ID_CONFIG_VIAJE", configuracionViaje)
                command.Parameters.AddWithValue("@litros", Me.gridProveedores.Rows(i).Cells("litros").Value.ToString())
                command.Parameters.AddWithValue("@autorizada", autorizada)
                'MessageBox.Show("Id Proveedor: " & Me.gridProveedores.Rows(i).Cells("id_proveedor_ruta").Value.ToString() & "  id_ruta" & Me.gridRutas.CurrentRow.Cells("ID_RUTA").Value.ToString() & " configuracion  " & configuracionViaje & "  litros " & Me.gridProveedores.CurrentRow.Cells("litros").Value.ToString())
                Try
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Next
            conn.Close()
            MessageBox.Show("Proveedores Guardados")
        Else

            conn.Open()
            Dim command As SqlCommand = New SqlCommand("up_ruta_autorizada", conn)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@ID_RUTA", Me.gridRutas.CurrentRow.Cells("ID_RUTA").Value.ToString())
            command.Parameters.AddWithValue("@autorizada", autorizada)
            MessageBox.Show("Ruta Autorizada")
            command.ExecuteNonQuery()
        End If
        Cursor = Cursors.Arrow


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub txtRuta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRuta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.buscarRuta(Me.txtRuta.Text.Trim)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.buscarRuta(Me.txtRuta.Text.Trim)
    End Sub

    Private Sub buscarRuta(ByVal ruta As String)
        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        Dim sql As String = "SELECT ID_RUTA, DESC_RUTA FROM TRAFICO_RUTA WHERE DESC_RUTA LIKE '%'+@RUTA+'%'"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.Parameters.AddWithValue("@RUTA", ruta)
        conn.Open()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridRutas.DataSource = table
    End Sub

 
    
    Private Sub gridRutas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridRutas.SelectionChanged
        If Me.gridRutas.Rows.Count > 0 Then
            Dim conn As SqlConnection = Connection.getInstance.getConnection()
            Dim sql As String = "SELECT id_proveedor_ruta, case when id_config_viaje = 1 then 'FULL' else 'SENCILLO' end as configuracion,litros,nombre_proveedor, nombre_contacto, direccion_proveedor, observaciones_proveedor FROM trafico_proveedor_ruta WHERE id_ruta = @id_ruta"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@id_ruta", Me.gridRutas.CurrentRow.Cells(0).Value.ToString())
            conn.Open()
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            Me.gridProveedores.DataSource = table
            conn.Close()
            Me.getKilometros()

            Dim sql2 As String = "select autorizada FROM trafico_ruta_autorizada WHERE id_ruta = @id_ruta"
            Dim reg As SqlDataReader
            Dim command2 As SqlCommand = New SqlCommand(sql2, conn)
            command2.Parameters.AddWithValue("@id_ruta", Me.gridRutas.CurrentRow.Cells(0).Value.ToString())
            conn.Open()
            reg = command2.ExecuteReader
            reg.Read()
            If reg.HasRows Then

                If reg.GetValue(0) = 1 Then
                    ch_autorizada.Checked = True
                Else
                    ch_autorizada.Checked = False
                End If
            Else
                ch_autorizada.Checked = False
            End If
            conn.Close()

        End If


    End Sub

    Private Sub gridProveedores_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridProveedores.KeyDown
        If e.KeyCode = Keys.Delete AndAlso Me.gridProveedores.Rows.Count > 0 Then
            Dim conn As SqlConnection = Connection.getInstance.getConnection()
            Dim sql As String = "DELETE FROM TRAFICO_PROVEEDOR_RUTA WHERE ID_PROVEEDOR_RUTA = @ID_PROVEEDOR_RUTA"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@ID_PROVEEDOR_RUTA", Me.gridProveedores.CurrentRow.Cells(0).Value.ToString())
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("¡Proveedor borrado!")
            Me.buscarRuta("")
        End If
    End Sub

    Private Sub gridProveedores_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridProveedores.SelectionChanged
        Dim capLitros As Integer = 0
        Dim rend As Double = 0
        Dim complemento As Double = 0
        If Me.gridProveedores.Rows.Count > 0 Then
            If Me.gridProveedores.CurrentRow.Cells(1).Value.ToString().Equals("FULL") Then
                capLitros = 800
                rend = 1.7
                complemento = ((txt_kilometros.Text) / rend) - (capLitros)
                txt_comp.Text = complemento

            Else
                capLitros = 800
                rend = 2.2
                complemento = (capLitros) - ((txt_kilometros.Text) / rend)
                txt_comp.Text = complemento
            End If
        Else
            txt_comp.Text = ""
        End If
    End Sub


    Public Sub getKilometros()
        Dim idruta As Integer = Me.gridRutas.CurrentRow.Cells(0).Value.ToString()
        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        Dim sql As String = "select kms_ruta from TRAFICO_RUTA where id_ruta = " & idruta
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim reg As SqlDataReader
        conn.Open()
        reg = command.ExecuteReader
        If reg.HasRows Then
            reg.Read()
            txt_kilometros.Text = reg.GetValue(0)
        Else

        End If
        conn.Close()
    End Sub
    
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim res As Double
        res = ((txt_kilometros.Text) / cmb_rendimiento.Text) - 800
        txt_comp.Text = res
    End Sub

    Private Sub gridRutas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRutas.CellDoubleClick
        id_ruta = Me.gridRutas.Rows(e.RowIndex).Cells(0).Value
        FrmCasetasGastos.Show()
    End Sub


End Class