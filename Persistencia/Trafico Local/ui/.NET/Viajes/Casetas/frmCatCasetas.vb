Public Class frmCatCasetas

    Private Sub frmCatCasetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Trafico_plazaTableAdapter.Fill(Me.ProduccionInterfletdbDataSet2.trafico_plaza)
    End Sub

    Private Sub cmbOrigen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrigen.SelectedIndexChanged
        Me.Cat_DestinoTableAdapter.FillBy(Me.ProduccionInterfletdbDataSet1.Cat_Destino, CType(Me.cmbOrigen.SelectedValue, Integer))
    End Sub

    Private Sub cmbDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDestino.SelectedIndexChanged
        Me.Cat_CasetasTableAdapter.FillBy(Me.PI_CatCasetas.Cat_Casetas, CType(Me.cmbOrigen.SelectedValue, Integer), CType(Me.cmbDestino.SelectedValue, Integer))
    End Sub

    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Dim origen, destino As Integer

        origen = CType(Me.cmbOrigen.SelectedValue, Integer)
        destino = CType(Me.cmbDestino.SelectedValue, Integer)

        For i As Integer = 0 To Me.grdCasetas.Rows.Count - 2
            If IsDBNull(Me.grdCasetas.Rows(i).Cells(2).Value) Then
                Me.Cat_CasetasTableAdapter.Guardar(origen, destino, 0, grdCasetas.Rows(i).Cells(3).Value.ToString(), CDbl(grdCasetas.Rows(i).Cells(4).Value), CByte(grdCasetas.Rows(i).Cells(6).Value))
            Else
                Me.Cat_CasetasTableAdapter.Guardar(origen, destino, CInt(grdCasetas.Rows(i).Cells(2).Value), grdCasetas.Rows(i).Cells(3).Value.ToString(), CDbl(grdCasetas.Rows(i).Cells(4).Value), CByte(grdCasetas.Rows(i).Cells(6).Value))
            End If
        Next

        Cargar()
    End Sub

    Private Sub Cargar()
        Me.grdCasetas.Refresh()

        Me.Cat_CasetasTableAdapter.FillBy(Me.PI_CatCasetas.Cat_Casetas, CType(Me.cmbOrigen.SelectedValue, Integer), CType(Me.cmbDestino.SelectedValue, Integer))
    End Sub
    Private Sub grdCasetas_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdCasetas.CurrentCellDirtyStateChanged
        If grdCasetas.IsCurrentCellDirty Then
            grdCasetas.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub cmbDestino_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDestino.Leave
        Me.Cat_CasetasTableAdapter.FillBy(Me.PI_CatCasetas.Cat_Casetas, CType(Me.cmbOrigen.SelectedValue, Integer), CType(Me.cmbDestino.SelectedValue, Integer))
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim aux As Int32

        If ((grdCasetas.Columns.Count = 0) Or (grdCasetas.Rows.Count = 0)) Then
            Exit Sub
        End If


        Dim dset As New DataSet

        dset.Tables.Add()

        For i As Integer = 0 To grdCasetas.ColumnCount - 1
            If grdCasetas.Columns(i).Visible = True Then
                dset.Tables(0).Columns.Add(grdCasetas.Columns(i).HeaderText)
            End If
        Next

        Dim dr1 As DataRow
        For i As Integer = 0 To grdCasetas.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            aux = 0
            For j As Integer = 0 To grdCasetas.Columns.Count - 1
                If grdCasetas.Columns(j).Visible = True Then
                    dr1(aux) = grdCasetas.Rows(i).Cells(j).Value
                    aux = aux + 1
                End If
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
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

        wSheet.Columns.AutoFit()
        excel.Visible = True
    End Sub

    Private Sub grdCasetas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCasetas.CellContentClick

    End Sub
End Class