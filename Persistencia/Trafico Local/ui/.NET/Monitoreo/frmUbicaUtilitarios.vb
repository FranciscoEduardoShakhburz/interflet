Public Class frmUbicaUtilitarios
    Public latitud, longitud, unidad As String
    Public Detalle As Boolean
    Public dtMapa As DataTable
    Const INTERVALO_EN_MINUTOS As Integer = 3

    Private Sub frmUbicaUtilitarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        CargaGrid()
        Detalle = False
    End Sub
    Private Sub CargaGrid()
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Me.grdUtilitarios.Columns.Clear()
        Me.grdUtilitarios.DataSource = Nothing

        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance.getConnectionQFS()



        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Consulta_UbicacionUtilitarios", oConexion)

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        Try
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            Me.grdUtilitarios.DataSource = oDs.Tables(0)
            dtMapa = oDs.Tables(0)

            Me.grdUtilitarios.Columns("latitude").Visible = False
            Me.grdUtilitarios.Columns("longitud").Visible = False
            Me.grdUtilitarios.Columns("Unidad").Width = 180
            Me.grdUtilitarios.Columns("Operador").Width = 260
            Me.grdUtilitarios.Columns("Fecha").Width = 160
            Me.grdUtilitarios.Columns("Ubicacion").Width = 480
            Me.grdUtilitarios.Columns("Vel").Width = 40

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static Temp_Seg As Long

        Temp_Seg = Temp_Seg + 1


        If (Temp_Seg * 60) >= (INTERVALO_EN_MINUTOS * 60) * 60 Then

            Temp_Seg = 0
            CargaGrid()
        End If
    End Sub

    Private Sub grdUtilitarios_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdUtilitarios.CellDoubleClick


        latitud = Me.grdUtilitarios.CurrentRow.Cells("latitude").Value.ToString()
        longitud = Me.grdUtilitarios.CurrentRow.Cells("longitud").Value.ToString()
        If e.ColumnIndex = grdUtilitarios.Columns.Item("Unidad").Index Then
            Detalle = True
            CargaRuta(Me.grdUtilitarios.CurrentRow.Cells("unidad").Value.ToString())
            frmMapaUtilitarios.ShowDialog()
            CargaGrid()
        Else

            Detalle = False
            frmMapaUtilitarios.ShowDialog()
        End If
    End Sub

    Private Sub CargaRuta(ByVal Unidad As String)
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Me.grdUtilitarios.Columns.Clear()
        Me.grdUtilitarios.DataSource = Nothing

        Dim oConexion As SqlClient.SqlConnection = Connection.getInstance().getConnection()



        Dim oCommand As SqlClient.SqlCommand = _
            New SqlClient.SqlCommand("UP_Consulta_RutaViaje", oConexion)

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()

        Dim oParameter As SqlClient.SqlParameter
        Try
            oParameter = oCommand.Parameters.Add("@Unidad", SqlDbType.VarChar)
            oParameter.Value = Unidad

            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New System.Data.DataSet()
            oDa.Fill(oDs)

            dtMapa = oDs.Tables(0)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class