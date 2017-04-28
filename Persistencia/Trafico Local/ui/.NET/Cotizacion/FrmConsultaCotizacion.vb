Public Class FrmConsultaCotizacion

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        If Validar() Then

            Dim NoCotizacion As Integer

            If Me.TxtNoCotizacion.Text = "" Then

                NoCotizacion = 0

            Else

                NoCotizacion = Convert.ToInt32(Me.TxtNoCotizacion.Text)

            End If

            Me.UP_Consulta_CotizacionTableAdapter.Fill(Me.PI_ConsultaCotizacion.UP_Consulta_Cotizacion, NoCotizacion, Trim(Me.TxtCliente.Text), Me.cmbFecIni.Value, Me.cmbFecFin.Value)

        End If
    End Sub

    Private Sub FrmConsultaCotizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Limpiar()

    End Sub

    Private Sub Limpiar()

        Me.TxtNoCotizacion.Text = ""
        Me.TxtCliente.Text = ""
        Me.cmbFecIni.Value = DateTime.Today
        Me.cmbFecFin.Value = DateTime.Today
        'Me.DataGridView1.Rows.Clear()

    End Sub
    Private Function Validar() As Boolean

        If Me.cmbFecIni.Value > Me.cmbFecFin.Value Then

            MsgBox("La fecha final no puede ser anterior a la fecha inicial", MsgBoxStyle.Exclamation, "Cotizador Interflet")
            Me.cmbFecFin.Focus()
            Return False

        End If

        Return True

    End Function

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Dim aux As Int32
        'verfying the datagridview having data or not
        If ((DataGridView1.Columns.Count = 0) Or (DataGridView1.Rows.Count = 0)) Then

            Exit Sub

        End If

        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            If DataGridView1.Columns(i).Visible = True Then

                dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)

            End If
        Next
        'add rows to the table
        Dim dr1 As DataRow

        For i As Integer = 0 To DataGridView1.RowCount - 1

            dr1 = dset.Tables(0).NewRow
            aux = 0

            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                If DataGridView1.Columns(j).Visible = True Then

                    dr1(aux) = DataGridView1.Rows(i).Cells(j).Value
                    aux = aux + 1

                End If
            Next

            dset.Tables(0).Rows.Add(dr1)

        Next

        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

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
End Class