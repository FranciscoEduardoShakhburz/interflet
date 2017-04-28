Option Strict Off
Option Explicit On
Friend Class frmOrdenesCompra
	Inherits System.Windows.Forms.Form
	Dim cmdbuscar As New ADODB.Command
	Dim rec As Object
	Dim rec2 As ADODB.Recordset
	Dim sql As String
	Dim oLibro, oXls, Hoja As Object
	Dim i_Field As Short
	Dim iRec As Integer
	Dim Columna, Fila As Short
	Dim recArreglo As Object
	
	Private Sub cmdDetalle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDetalle.Click
		
		sql = "EXEC UP_Consulta_IndicadoresOrdenes_Det '" & dtFecIni.Value & "', '" & dtFecFin.Value & "', " & Val(txtCantDias.Text)
		cmdbuscar.CommandText = sql
		rec = cmdbuscar.Execute
		
		If Not rec.EOF Then
            rec.MoveFirst()

            oXls = CreateObject("Excel.Application")
            oLibro = oXls.Workbooks.Add

            Hoja = oLibro.Worksheets("Hoja1")

            i_Field = rec.Fields.Count
            For Columna = 1 To i_Field
                Hoja.Cells(1, Columna).Value = rec.Fields(Columna - 1).Name
            Next

            If Val(Mid(oXls.Version, 1, InStr(1, oXls.Version, ".") - 1)) > 8 Then
                rec.MoveFirst()
                Hoja.Cells(2, 1).CopyFromRecordset(rec)
            Else
                recArreglo = rec.GetRows
                iRec = UBound(recArreglo, 2) + 1
                For Columna = 0 To i_Field - 1
                    For Fila = 0 To iRec - 1
                        If IsDate(recArreglo(Columna, Fila)) Then
                            recArreglo(Columna, Fila) = VB6.Format(recArreglo(Columna, Fila))
                        ElseIf IsArray(recArreglo(Columna, Fila)) Then
                            recArreglo(Columna, Fila) = "Array Field"
                        End If
                    Next Fila
                Next Columna

                Hoja.Cells(2, 1).Resize(iRec, i_Field).Value = Pasar(recArreglo)
            End If
            oXls.Visible = True
            oXls.UserControl = True
            oXls.Selection.CurrentRegion.Columns.AutoFit()


            Hoja = Nothing
            oLibro = Nothing
            oXls = Nothing
        End If
		
	End Sub
	
	Private Sub cmdDetalle2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDetalle2.Click
		
		sql = "EXEC UP_Consulta_IndicadoresReparaciones_Det '" & dtFecIni.Value & "', '" & dtFecFin.Value & "', " & Val(txtCantDias.Text)
		cmdbuscar.CommandText = sql
		rec = cmdbuscar.Execute
		
        If Not rec.EOF Then
            rec.MoveFirst()

            oXls = CreateObject("Excel.Application")
            oLibro = oXls.Workbooks.Add

            Hoja = oLibro.Worksheets("Hoja1")

            i_Field = rec.Fields.Count
            For Columna = 1 To i_Field
                Hoja.Cells(1, Columna).Value = rec.Fields(Columna - 1).Name
            Next

            If Val(Mid(oXls.Version, 1, InStr(1, oXls.Version, ".") - 1)) > 8 Then
                rec.MoveFirst()
                Hoja.Cells(2, 1).CopyFromRecordset(rec)
            Else
                recArreglo = rec.GetRows
                iRec = UBound(recArreglo, 2) + 1
                For Columna = 0 To i_Field - 1
                    For Fila = 0 To iRec - 1
                        If IsDate(recArreglo(Columna, Fila)) Then
                            recArreglo(Columna, Fila) = VB6.Format(recArreglo(Columna, Fila))
                        ElseIf IsArray(recArreglo(Columna, Fila)) Then
                            recArreglo(Columna, Fila) = "Array Field"
                        End If
                    Next Fila
                Next Columna

                Hoja.Cells(2, 1).Resize(iRec, i_Field).Value = Pasar(recArreglo)
            End If
            oXls.Visible = True
            oXls.UserControl = True
            oXls.Selection.CurrentRegion.Columns.AutoFit()


            Hoja = Nothing
            oLibro = Nothing
            oXls = Nothing
        End If
		
	End Sub
	
	Private Sub cmdProcesar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProcesar.Click
		
        If cmbTipo.SelectedIndex = 1 Then
            sql = "EXEC UP_Consulta_IndicadoresOrdenes '" & dtFecIni.Value & "', '" & dtFecFin.Value & "', " & Val(txtCantDias.Text)
            cmdbuscar.CommandText = sql
            rec = cmdbuscar.Execute
            If Not rec.EOF Then
                Do While Not rec.EOF
                    txtEnTiempo.Text = Convert.ToString(rec.Fields("OK").Value)
                    txtTotEnTiempo.Text = Convert.ToString(rec.Fields("TotalOK").Value)
                    txtTotal.Text = Convert.ToString(rec.Fields("Total").Value)
                    rec.MoveNext()
                Loop
            End If
        Else
            If cmbTipo.SelectedIndex = 2 Then
                sql = "EXEC UP_Consulta_IndicadoresReparaciones '" & dtFecIni.Value & "', '" & dtFecFin.Value & "', " & Val(txtCantDias.Text)
                cmdbuscar.CommandText = sql
                rec2 = cmdbuscar.Execute
                If Not rec2.EOF Then
                    Do While Not rec.EOF
                        txtEnTiempo2.Text = Convert.ToString(rec2.Fields("OK").Value)
                        txtTotEnTiempo2.Text = Convert.ToString(rec2.Fields("TotalOK").Value)
                        txtTotal2.Text = Convert.ToString(rec2.Fields("Total").Value)
                        rec2.MoveNext()
                    Loop
                End If
            Else
                sql = "EXEC UP_Consulta_IndicadoresOrdenes '" & dtFecIni.Value & "', '" & dtFecFin.Value & "', " & Val(txtCantDias.Text)
                cmdbuscar.CommandText = sql
                rec = cmdbuscar.Execute
                If Not rec.EOF Then
                    Do While Not rec.EOF
                        txtEnTiempo.Text = Convert.ToString(rec.Fields("OK").Value)
                        txtTotEnTiempo.Text = Convert.ToString(rec.Fields("TotalOK").Value)
                        txtTotal.Text = Convert.ToString(rec.Fields("Total").Value)
                        rec.MoveNext()
                    Loop
                End If
                rec.Close()
                sql = "EXEC UP_Consulta_IndicadoresReparaciones '" & dtFecIni.Value & "', '" & dtFecFin.Value & "', " & Val(txtCantDias.Text)
                cmdbuscar.CommandText = sql
                rec2 = cmdbuscar.Execute
                If Not rec2.EOF Then
                    Do While Not rec2.EOF
                        txtEnTiempo2.Text = rec2.Fields("OK").Value
                        txtTotEnTiempo2.Text = rec2.Fields("TotalOK").Value
                        txtTotal2.Text = rec2.Fields("Total").Value
                        rec2.MoveNext()
                    Loop
                End If
            End If
        End If
        cmdDetalle.Enabled = True
        cmdDetalle2.Enabled = True

    End Sub

    Private Sub frmOrdenesCompra_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        cmbTipo.Items.Add("Ambos")
        cmbTipo.Items.Add("Ordenes de Compra")
        cmbTipo.Items.Add("Reparación de Piezas")
        cmbTipo.SelectedIndex = 0
        Conecta()
        cmdbuscar.let_ActiveConnection(Miconex)
        cmdbuscar.CommandType = ADODB.CommandTypeEnum.adCmdText
        dtFecIni.Value = Today
        dtFecFin.Value = Today
        txtCantDias.Text = CStr(0)
        cmdDetalle.Enabled = False
        cmdDetalle2.Enabled = False
        Cursor.Current = Cursors.Arrow

    End Sub
	
	Private Function Pasar(ByRef V As Object) As Object
		Dim xMax, X, Y, yMax As Integer
		Dim T As Object
		xMax = UBound(V, 2) : yMax = UBound(V, 1)
		ReDim T(xMax, yMax)
		For X = 0 To xMax
			For Y = 0 To yMax
                T(X, Y) = V(Y, X)
			Next Y
		Next X
        Pasar = T
	End Function
End Class