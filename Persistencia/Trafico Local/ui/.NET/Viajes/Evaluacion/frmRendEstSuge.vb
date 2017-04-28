Imports System.Data.SqlClient

Public Class frmRendEstSuge

    Public noviaje, destino, cliente, tipomotor, config, id As Integer
    Public peso As Double
    Public fec As Date
    Public rpeso, mes As Integer
    Public clin, dest, area As String

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click

        Me.Dispose()

    End Sub

    Private Sub frmRendEstSuge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cn As New SqlConnection
        Dim command As SqlCommand
        Dim reg As SqlDataReader
        Dim codigoArea As Integer
        rpeso = 5
        mes = 6

        If area.Equals("Altamira") Then

            codigoArea = 1

        ElseIf area.Equals("Manzanillo") Then

            codigoArea = 2

        ElseIf area.Equals("Veracruz") Then

            codigoArea = 3

        End If

        cn = Connection.getInstance().getConnection()
        command = New SqlCommand("SELECT ID_DESTINO,ID_CLIENTE,ID_TIPO_MOTOR,CONFIGVIAJE,FECINI_VIAJE,id_area FROM DATOSVIAJe WHERE ID_NUM_VIAJE = " & noviaje & " AND id_area = " & codigoArea, cn)
        command.CommandType = CommandType.Text
        command.CommandTimeout = 600
        cn.Open()
        reg = command.ExecuteReader

        If reg.HasRows Then

            reg.Read()
            destino = reg.GetValue(0)
            cliente = reg.GetValue(1)
            tipomotor = reg.GetValue(2)
            config = reg.GetValue(3)
            fec = reg.GetValue(4)
            id = reg.GetValue(5)
            Me.ejecutarSp()

        End If

        txt_cliente.Text = clin
        txt_destino.Text = dest
        grid.AutoResizeColumns()

    End Sub

    Public Sub ejecutarSp()

        Cursor = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        MessageBox.Show("Peso: " & peso & "  ranbgo:  " & rpeso & " configviaje: " & config & "  motor: " & tipomotor & " destino: " & destino & "  cliente:  " & cliente)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_REND_EST_SUGERIDO", conn)
        command.CommandType = CommandType.StoredProcedure
        command.CommandTimeout = 5000
        conn.Open()
        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@DESTINO", destino)
        param = command.Parameters.AddWithValue("@CLIENTE", cliente)
        param = command.Parameters.AddWithValue("@TMOTOR", tipomotor)
        param = command.Parameters.AddWithValue("@CONFIGVIAJE", config)
        param = command.Parameters.AddWithValue("@FECINI", fec)
        param = command.Parameters.AddWithValue("@PESO", peso)
        param = command.Parameters.AddWithValue("@ID_area", id)
        param = command.Parameters.AddWithValue("@Rpeso", rpeso)
        param = command.Parameters.AddWithValue("@mes", mes)
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.grid.DataSource = oDs.Tables(0)
        Me.Promedios()
        Cursor = Cursors.Arrow

    End Sub

    Private Sub bto_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_calcular.Click

        rpeso = txt_peso.Text
        mes = txt_mes.Text
        Me.ejecutarSp()

    End Sub

    Public Sub Promedios()

        Dim promlitros, promrend, promkm As Double
        Dim cont As Integer = 0

        While cont < Me.grid.Rows.Count

            promlitros = Me.grid.Rows(cont).Cells.Item("Lts_Viaje").Value + (promlitros)
            promrend = Me.grid.Rows(cont).Cells.Item("RendCalc").Value + (promrend)
            promkm = Me.grid.Rows(cont).Cells.Item("km_reales").Value + (promkm)
            cont = cont + 1

        End While

        promlitros = Math.Round((promlitros / cont), 2)
        promrend = Math.Round((promrend / cont), 2)
        promkm = Math.Round((promkm / cont), 2)
        txt_litros.Text = promlitros
        txt_rend.Text = promrend
        txt_km.Text = promkm
        txt_plaza.Text = area
        Dim command As SqlCommand
        Dim reg As SqlDataReader
        Dim con As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "select tr.desc_ruta from trafico_viaje tv, trafico_ruta tr where tv.no_viaje = " & noviaje & " and tv.id_area = " & id & "and tr.id_ruta = tv.id_ruta"
        con.Open()
        command = New SqlCommand(sql, con)
        command.CommandType = CommandType.Text
        reg = command.ExecuteReader
        reg.Read()
        txt_ruta.Text = reg.GetValue(0).ToString
        lbl_id.Text = cliente
        con.Close()

    End Sub

    Private Sub RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs) Handles grid.RowsRemoved

        Me.Promedios()

    End Sub


    Private Sub Grid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles grid.ColumnHeaderMouseClick

        Me.Promedios()

    End Sub
End Class