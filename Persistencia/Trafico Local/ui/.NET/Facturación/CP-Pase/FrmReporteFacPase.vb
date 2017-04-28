Imports System.Data.SqlClient
Public Class FrmReporteFacPase
    Dim cn As New SqlConnection
    Dim command As SqlCommand

    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click
        Me.Close()
    End Sub

    Private Sub bto_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_consultar.Click       
        Me.Consultar()
    End Sub

    Private Sub FrmReporteFacPase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = Connection.getInstance().getConnection()
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub bto_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_Excel.Click
        Excel.gridToExcel(Me.grid)
    End Sub

    Public Sub Consultar()
        Cursor = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim parfecIni As String = dt_fecIni.Value.Date.ToString("dd/MM/yyyy") & " 00:00:00"
        Dim parfecFin As String = dt_fecFin.Value.Date.ToString("dd/MM/yyyy") & " 23:59:00"
        Dim sql As String

        sql = "select a.num_guia,b.fecha_guia,a.fecreg as 'Fecha Rechazo',a.observaciones,a.usuario from trafico_cp_pendientes_factura a,         trafico_guia b where a.fecreg between '" & parfecIni & "' and '" & parfecFin & "' and a.num_guia = b.num_guia and a.id = 2"
        
        command = New SqlCommand(sql, cn)
        command.CommandType = CommandType.Text
        command.CommandTimeout = 2000
        command.Connection = cn
        cn.Open()
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.grid.DataSource = oDs.Tables(0)
        cn.Close()
        Cursor = Cursors.Arrow
    End Sub
End Class