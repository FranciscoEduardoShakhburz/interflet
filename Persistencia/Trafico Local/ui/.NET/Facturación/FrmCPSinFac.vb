Imports System.Data.SqlClient

Public Class FrmCPSinFac
    Public myConnectionString As String
    Dim cn As New SqlConnection
    Dim plaza, pla As Integer
    Dim reg As SqlDataReader
    Dim tipo As String
    Public cartap As String

    Private Sub Button_ConsultaCP(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCP.Click

        Dim plaz As String

        plaz = cmdPlaza.SelectedItem
        If plaz.Equals("Altamira") Then
            plaza = 1
        End If
        If plaz.Equals("Manzanillo") Then
            plaza = 392
        End If
        If plaz.Equals("Veracruz") Then
            plaza = 11
        End If
        If plaz.Equals("Todas") Then
            plaza = 0
        End If

        If plaza = 0 Then 'EVALUAMOS PRIMERO SI VAN A HACER TODAS LAS PLAZAS O SOLO 1
            If cmb_tipo.SelectedIndex = 0 Then
                tipo = 4
            End If
            If cmb_tipo.SelectedIndex = 1 Then
                tipo = 6
            End If
            If cmb_tipo.SelectedIndex = 2 Then
                tipo = 3
            End If
        Else 'solo una area
            If cmb_tipo.SelectedIndex = 0 Then
                tipo = 2
            End If
            If cmb_tipo.SelectedIndex = 1 Then
                tipo = 5
            End If
            If cmb_tipo.SelectedIndex = 2 Then
                tipo = 1
            End If
        End If
        Me.TodasAreas()
        Me.SumaTotales()
    End Sub

    Public Sub SumaTotales()
        Dim totalFac, totalmont, cont As Integer
        totalFac = Grid.Rows.Count
        cont = 0
        totalmont = 0
        While cont < Grid.Rows.Count
            totalmont = (Grid.Rows(1).Cells(3).Value) + totalmont
            cont = cont + 1
        End While
        txtTotalFac.Text = totalFac
        txtTotalMonto.Text = totalmont

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmdPlaza.SelectedIndex = 0
        cmb_tipo.SelectedIndex = 0
        Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        cn = Connection.getInstance().getConnection()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellDoubleClick
        'Try
        If e.RowIndex = -1 Then
            MessageBox.Show("No existe ningun valor")
        Else
            cartap = Me.Grid.Rows(e.RowIndex).Cells(0).Value

            FrmCapturaObservaciones.ShowDialog()
        End If
       


        'Catch ex As Exception

        'End Try        

    End Sub


    Private Sub Button_Excel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Excel.gridToExcel(Me.Grid)

    End Sub

    Public Sub TodasAreas()
        Cursor = Cursors.WaitCursor
        Dim oDa As SqlDataAdapter
        Dim oDs As DataSet
        Dim command As SqlCommand = New SqlCommand("Get_Cp_pendientes_Fact", cn)
        command.CommandType = CommandType.StoredProcedure
        cn.Open()
        command.CommandTimeout = 600
        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@FECHAINICIAL", Me.FechaI.Value.Date)
        param = command.Parameters.AddWithValue("@FECHAFINAL", Me.FechaF.Value.Date)
        param = command.Parameters.AddWithValue("@Plaza", Me.plaza)
        param = command.Parameters.AddWithValue("@TipoBusqueda", tipo)
        oDa = New SqlDataAdapter(command)
        oDs = New DataSet()
        oDa.Fill(oDs)
        Me.Grid.DataSource = oDs.Tables(0)
        Me.gridtop.DataSource = oDs.Tables(1)
        cn.Close()
        Cursor = Cursors.Arrow
    End Sub



    Private Sub Button_Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class
