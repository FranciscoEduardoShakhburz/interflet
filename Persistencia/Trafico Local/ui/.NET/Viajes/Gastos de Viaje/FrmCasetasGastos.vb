Imports System.Data.SqlClient
Public Class FrmCasetasGastos
    Public id_ruta As Integer



    Public Sub getCasetasIaveF()
        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        Dim command As SqlCommand = New SqlCommand("up_get_caseta_tarifa", conn) 'Solo nos traemos las que son de caseta IAVE
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@IDRUTA", Me.id_ruta)
        command.Parameters.AddWithValue("no_ejes", 9)
        conn.Open()
        command.CommandTimeout = 600
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        gridF_iave.DataSource = oDs.Tables(0)
        conn.Close()
        Cursor = Cursors.Arrow
    End Sub

    Public Sub getCasetasIaveC()
        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        Dim command As SqlCommand = New SqlCommand("up_get_caseta_tarifa", conn) 'Solo nos traemos las que son de caseta IAVE
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@IDRUTA", Me.id_ruta)
        command.Parameters.AddWithValue("no_ejes", 5)
        conn.Open()
        command.CommandTimeout = 600
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        gridS_iave.DataSource = oDs.Tables(0)
        conn.Close()
        Cursor = Cursors.Arrow
    End Sub

    Public Sub getCasetasEfectivoF()

        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        Dim command As SqlCommand = New SqlCommand("up_get_caseta_tarifa_NoIave", conn) 'Solo nos traemos las que son de caseta IAVE
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@IDRUTA", Me.id_ruta)
        command.Parameters.AddWithValue("no_ejes", 9)
        conn.Open()
        command.CommandTimeout = 600
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        gridF_efectivo.DataSource = oDs.Tables(0)
        conn.Close()
        Cursor = Cursors.Arrow

    End Sub

    Public Sub getCasetasEfectivoS()
        Dim conn As SqlConnection = Connection.getInstance.getConnection()
        Dim command As SqlCommand = New SqlCommand("up_get_caseta_tarifa_NoIave", conn) 'Solo nos traemos las que son de caseta IAVE
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@IDRUTA", Me.id_ruta)
        command.Parameters.AddWithValue("no_ejes", 5)
        conn.Open()
        command.CommandTimeout = 600
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        gridS_efectivo.DataSource = oDs.Tables(0)
        conn.Close()
        Cursor = Cursors.Arrow
    End Sub
    Public Sub getTramos()
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim sql As String = "SELECT TT.DESC_TRAMO,tt.id_tramo FROM TRAFICO_RENGLON_RUTA A , TRAFICO_TRAMO TT WHERE A.ID_RUTA = " & id_ruta & "AND TT.ID_TRAMO = A.ID_TRAMO GROUP BY DESC_TRAMO,tt.id_tramo"
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim command As New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        cn.Open()
        command.CommandTimeout = 600
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet
        oDa.Fill(oDs)
        grid_tramos.DataSource = oDs.Tables(0)
        cn.Close()
    End Sub
    Public Sub getConvenio()
        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim sql As String = "select tc.nombre as 'Cliente',tf.id_convenio ,tf.desc_convenio  from trafico_convenio tf,trafico_cliente tc where tf.id_ruta = " & id_ruta & "and tc.id_cliente = tf.id_cliente"
        Dim command As New SqlCommand(sql, cn)
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        command.CommandType = CommandType.Text
        cn.Open()
        command.CommandTimeout = 600
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet
        oDa.Fill(oDs)
        grid_convenios.DataSource = oDs.Tables(0)
        cn.Close()
    End Sub


    Private Sub FrmCasetasGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        id_ruta = formProveedores.id_ruta
        grid_convenios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.getCasetasEfectivoF()
        Me.getCasetasEfectivoS()
        Me.getCasetasIaveF()
        Me.getCasetasIaveC()
        Me.getConvenio()
        Me.getTramos()
    End Sub

 
End Class