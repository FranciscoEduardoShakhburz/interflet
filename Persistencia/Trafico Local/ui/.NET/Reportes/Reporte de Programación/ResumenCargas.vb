Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class ResumenCargas

    Private Sub ResumenCargas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.inicializarGrid()

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Dim viajesTotales As Integer
        Dim viajesFull As Integer
        Dim viajesSencillo As Integer

        viajesTotales = Me.gridResumen.Rows.Count

        For Each viaje As DataGridViewRow In Me.gridResumen.Rows
            If viaje.Cells("TIPO1").Value.ToString().Contains("F") Then

                viajesFull += 1

            End If

            If viaje.Cells("TIPO1").Value.ToString().Contains("S") Then

                viajesSencillo += 1

            End If
        Next

        'Me.gridAExcel(viajesTotales, viajesFull, viajesSencillo)
        Me.expotarReporteConFormato(viajesTotales, viajesFull, viajesSencillo)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Me.guardar()
        Me.guardarColaEspera()

    End Sub

    Private Sub MoverAColaDeEsperaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAColaDeEsperaToolStripMenuItem.Click

        Dim cargaCola As DataGridViewRow

        For Each carga As DataGridViewRow In Me.gridResumen.SelectedRows

            cargaCola = Me.dGVCola.Rows(Me.dGVCola.Rows.Add())
            cargaCola.Cells("colNo").Value = 0
            cargaCola.Cells("colContenedor").Value = carga.Cells("CONTENEDOR").Value.ToString()
            cargaCola.Cells("colTipo").Value = carga.Cells("TIPO").Value.ToString()
            cargaCola.Cells("colReferencia").Value = carga.Cells("REFERENCIA").Value.ToString()
            cargaCola.Cells("colCliente").Value = carga.Cells("CLIENTE").Value.ToString()
            cargaCola.Cells("colTipo1").Value = carga.Cells("TIPO1").Value.ToString()
            cargaCola.Cells("colEntregarEn").Value = carga.Cells("ENTREGA2").Value.ToString()
            cargaCola.Cells("colDestino").Value = carga.Cells("DESTINO").Value.ToString()
            cargaCola.Cells("colTerminal").Value = carga.Cells("TERMINAL").Value.ToString()
            cargaCola.Cells("colStatus").Value = carga.Cells("STATUS").Value.ToString()
            cargaCola.Cells("colDemora").Value = carga.Cells("DEMORAS").Value.ToString()
            cargaCola.Cells("colNaviera").Value = carga.Cells("NAVIERA").Value.ToString()
            cargaCola.Cells("colOperacion").Value = carga.Cells("OPERACION").Value.ToString()
            cargaCola.Cells("colCargaPeligrosa").Value = carga.Cells("CARGA PELIGROSA").Value.ToString()
            cargaCola.Cells("colPlanta").Value = carga.Cells("PLANTA").Value.ToString()
            cargaCola.Cells("colCita").Value = carga.Cells("CITA").Value.ToString()
            Me.gridResumen.Rows.Remove(carga)

        Next
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click

        For Each carga As DataGridViewRow In Me.gridResumen.SelectedRows

            Me.gridResumen.Rows.Remove(carga)

        Next
    End Sub

    Private Sub MovarAResumenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovarAResumenToolStripMenuItem.Click

        Dim cargaResumen As DataGridViewRow

        For Each cargaCola As DataGridViewRow In Me.dGVCola.SelectedRows

            cargaResumen = Me.gridResumen.Rows(Me.gridResumen.Rows.Add())
            cargaResumen.Cells("No").Value = cargaCola.Cells("colNo").Value.ToString()
            cargaResumen.Cells("CONTENEDOR").Value = cargaCola.Cells("colContenedor").Value.ToString()
            cargaResumen.Cells("TIPO").Value = cargaCola.Cells("colTipo").Value.ToString()
            cargaResumen.Cells("REFERENCIA").Value = cargaCola.Cells("colReferencia").Value.ToString()
            cargaResumen.Cells("CLIENTE").Value = cargaCola.Cells("colCliente").Value.ToString()
            cargaResumen.Cells("TIPO1").Value = cargaCola.Cells("colTipo1").Value.ToString()
            cargaResumen.Cells("ENTREGA2").Value = cargaCola.Cells("colEntregarEn").Value.ToString()
            cargaResumen.Cells("DESTINO").Value = cargaCola.Cells("colDestino").Value.ToString()
            cargaResumen.Cells("TERMINAL").Value = cargaCola.Cells("colTerminal").Value.ToString()
            cargaResumen.Cells("STATUS").Value = cargaCola.Cells("colStatus").Value.ToString()
            cargaResumen.Cells("DEMORAS").Value = cargaCola.Cells("colDemora").Value.ToString()
            cargaResumen.Cells("NAVIERA").Value = cargaCola.Cells("colNaviera").Value.ToString()
            cargaResumen.Cells("OPERACION").Value = cargaCola.Cells("colOperacion").Value.ToString()
            cargaResumen.Cells("CARGA PELIGROSA").Value = cargaCola.Cells("colCargaPeligrosa").Value.ToString()
            cargaResumen.Cells("PLANTA").Value = cargaCola.Cells("colplanta").Value.ToString()
            cargaResumen.Cells("CITA").Value = cargaCola.Cells("colCita").Value.ToString()
            Me.dGVCola.Rows.Remove(cargaCola)

        Next
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem1.Click

        For Each cargaCola As DataGridViewRow In Me.dGVCola.SelectedRows

            Me.dGVCola.Rows.Remove(cargaCola)

        Next
    End Sub

    Private Sub ArmarFullToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArmarFullToolStripMenuItem.Click

        Me.armarFull()

    End Sub

    Private Sub CombinarEnUnaSolaCargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombinarEnUnaSolaCargaToolStripMenuItem.Click

        Me.combinarCargas()

    End Sub

    Private Sub DuplicarCargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuplicarCargaToolStripMenuItem.Click

        Me.duplicarCargas()

    End Sub

    Public Sub inicializarGrid()

        Dim cargaN As DataGridViewRow
        Dim dSCola As DataSet
        Dim dS As DataSet

        dS = Me.consultarResumenGuardado()

        If dS.Tables.Count > 0 Then
            If dS.Tables(0).Rows.Count > 0 Then

                dSCola = Me.consultarColaEspera()

                For Each columna As DataColumn In dS.Tables(0).Columns

                    Me.gridResumen.Columns.Add(columna.ColumnName, columna.ColumnName)

                Next

                For Each fila As DataRow In dS.Tables(0).Rows

                    cargaN = Me.gridResumen.Rows(Me.gridResumen.Rows.Add())

                    For columna As Integer = 0 To cargaN.Cells.Count - 1

                        cargaN.Cells(columna).Value = fila(columna).ToString()

                    Next
                Next

                Me.gridResumen.DataSource = dS.Tables(0)
                Me.dGVCola = New DataGridView()
                Me.dGVCola.DataSource = dSCola.Tables(0)
                Exit Sub

            End If
        End If

        dS = Me.consultarImpo()

        If dS.Tables.Count > 0 Then
            If dS.Tables(0).Rows.Count > 1 Then

                Me.contarContenedores(dS)

            End If

            Me.agregarCargasExpo(dS)

            For Each carga As DataRow In dS.Tables(0).Rows

                carga("No") = 0

            Next

            For Each columna As DataColumn In dS.Tables(0).Columns

                Me.gridResumen.Columns.Add(columna.ColumnName, columna.ColumnName)

            Next

            For Each fila As DataRow In dS.Tables(0).Rows

                cargaN = Me.gridResumen.Rows(Me.gridResumen.Rows.Add())

                For columna As Integer = 0 To cargaN.Cells.Count - 1

                    cargaN.Cells(columna).Value = fila(columna).ToString()

                Next
            Next

            'Me.gridResumen.DataSource = dS.Tables(0)
            'Me.gridResumen.Columns("PLANTA").Visible = False
            Me.gridResumen.Sort(Me.gridResumen.Columns("No"), System.ComponentModel.ListSortDirection.Ascending)
            Me.gridResumen.Refresh()

        End If
    End Sub

    Private Function consultarImpo() As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Dim desde As String
        Dim hasta As String
        desde = "15/04/2017"
        hasta = "16/04/2017"

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("up_resumen_cargasImpo", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 1000

            With comando.Parameters

                '.AddWithValue("@desde", DateTime.Today.ToString("dd/MM/yyyy"))
                '.AddWithValue("@hasta", DateTime.Today.ToString("dd/MM/yyyy"))
                .AddWithValue("@desde", desde)
                .AddWithValue("@hasta", hasta)
                
            End With

            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            conexion.Open()
            sDA.Fill(dS)
            Return dS

        Catch ex As Exception

            MessageBox.Show("Error al consultar la información del resumen: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return Nothing

    End Function

    Private Sub contarContenedores(ByRef dS As DataSet)

        Dim index1, index2 As Integer
        Dim contenedor As String
        Dim dTAux As DataTable
        Dim empatado As Boolean = True

        index1 = 0
        index2 = 1
        dTAux = New DataTable()
        
        For Each columna As DataColumn In dS.Tables(0).Columns

            dTAux.Columns.Add(columna.ColumnName)

        Next

        While index1 < dS.Tables(0).Rows.Count
            While index2 < dS.Tables(0).Rows.Count
                If dS.Tables(0).Rows(0)("CONTENEDOR").ToString().Trim().Length <> 13 Then

                    empatado = False
                    Exit While

                End If

                If dS.Tables(0).Rows(index1)("CLIENTE").ToString().TrimEnd().TrimStart().Equals(dS.Tables(0).Rows(index2)("CLIENTE").ToString().TrimEnd().TrimStart()) AndAlso dS.Tables(0).Rows(index1)("REFERENCIA").ToString().TrimEnd().TrimStart().Equals(dS.Tables(0).Rows(index2)("REFERENCIA").ToString().TrimEnd().TrimStart()) AndAlso dS.Tables(0).Rows(index1)("DESTINO").ToString().Equals(dS.Tables(0).Rows(index2)("DESTINO").ToString()) AndAlso dS.Tables(0).Rows(index2)("CONTENEDOR").ToString().Trim().Length = 13 Then

                    dTAux.Rows.Add()

                    For index As Integer = 0 To dS.Tables(0).Columns.Count - 1

                        dTAux.Rows(dTAux.Rows.Count - 1)(index) = dS.Tables(0).Rows(index1)(index).ToString()

                    Next

                    dTAux.Rows(dTAux.Rows.Count - 1)("CONTENEDOR") = "2 X " & dS.Tables(0).Rows(index1)("TIPO").ToString()
                    dTAux.Rows(dTAux.Rows.Count - 1)("TIPO1") = "F"
                    dS.Tables(0).Rows(index2).Delete()
                    dS.Tables(0).Rows(index1).Delete()
                    dS.Tables(0).AcceptChanges()
                    dS.AcceptChanges()
                    index2 = 1
                    empatado = True
                    Exit While

                Else

                    empatado = False
                    index2 += 1

                End If
            End While

            If Not empatado Then

                dTAux.Rows.Add()

                For index As Integer = 0 To dS.Tables(0).Columns.Count - 1

                    dTAux.Rows(dTAux.Rows.Count - 1)(index) = dS.Tables(0).Rows(index1)(index).ToString()

                Next

                dTAux.Rows(dTAux.Rows.Count - 1)("CONTENEDOR") = "1 X " & dS.Tables(0).Rows(index1)("TIPO").ToString()
                dS.Tables(0).Rows(index1).Delete()
                dS.Tables(0).AcceptChanges()
                index2 = 1

            End If

            If dS.Tables(0).Rows.Count = 1 Then

                dTAux.Rows.Add()

                For index As Integer = 0 To dS.Tables(0).Columns.Count - 1

                    dTAux.Rows(dTAux.Rows.Count - 1)(index) = dS.Tables(0).Rows(index1)(index).ToString()

                Next

                dTAux.Rows(dTAux.Rows.Count - 1)("CONTENEDOR") = "1 X " & dS.Tables(0).Rows(index1)("TIPO").ToString()
                dS.Tables(0).Rows(index1).Delete()
                dS.Tables(0).AcceptChanges()
                Exit While

            End If
        End While

        dS.Tables(0).Rows.Clear()

        For Each fila As DataRow In dTAux.Rows

            dS.Tables(0).Rows.Add()

            For columna As Integer = 0 To dTAux.Columns.Count - 1

                dS.Tables(0).Rows(dS.Tables(0).Rows.Count - 1)(columna) = fila(columna).ToString()

            Next
        Next
    End Sub

    Private Sub guardarResumenCargas()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ResumenCargas_Ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("Error al guardar el resumen: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub guardarResumenCargasDetalle(ByVal numero As Integer, ByVal contendor As String, ByVal tipo As String, ByVal referencia As String, ByVal cliente As String, ByVal tipo1 As String, ByVal entrega2 As String, ByVal destino As String, ByVal terminal As String, ByVal status As String, ByVal demoras As String, ByVal naviera As String, ByVal fechaPlanta As String, ByVal operacion As String, ByVal esPeligrosa As Integer, ByVal cita As String)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ResumenCargas_Detalle_Ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@numero", numero)
                .AddWithValue("@contenedor", contendor)
                .AddWithValue("@tipo", tipo)
                .AddWithValue("@referencia", referencia)
                .AddWithValue("@cliente", cliente)
                .AddWithValue("@tipo1", tipo1)
                .AddWithValue("@entrega2", entrega2)
                .AddWithValue("@destino", destino)
                .AddWithValue("@terminal", terminal)
                .AddWithValue("@status", status)
                .AddWithValue("@demoras", demoras)
                .AddWithValue("@planta", fechaPlanta)
                .AddWithValue("@naviera", naviera)
                .AddWithValue("@operacion", operacion)
                .AddWithValue("@esPeligrosa", IIf(esPeligrosa.Equals("SI"), 1, 0))
                .AddWithValue("@cita", cita)

            End With

            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al guardar el resumen: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub guardar()

        Cursor.Current = Cursors.WaitCursor

        Try

            Me.guardarResumenCargas()

            For Each carga As DataGridViewRow In Me.gridResumen.Rows

                Me.guardarResumenCargasDetalle(Convert.ToInt32(carga.Cells("No").Value.ToString()), carga.Cells("CONTENEDOR").Value.ToString(), carga.Cells("TIPO").Value.ToString(), carga.Cells("REFERENCIA").Value.ToString(), carga.Cells("CLIENTE").Value.ToString(), carga.Cells("TIPO1").Value.ToString(), carga.Cells("ENTREGA2").Value.ToString(), carga.Cells("DESTINO").Value.ToString(), carga.Cells("TERMINAL").Value.ToString(), carga.Cells("STATUS").Value.ToString(), carga.Cells("DEMORAS").Value.ToString(), carga.Cells("NAVIERA").Value.ToString(), carga.Cells("PLANTA").Value.ToString(), carga.Cells("OPERACION").Value.ToString(), IIf(carga.Cells("CARGA PELIGROSA").Value.ToString().Equals("SI"), 1, 0), carga.Cells("CITA").Value.ToString())

            Next

            MessageBox.Show("El resumen se ha guardado correctamente.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error al guardar los registros: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub gridAExcel(ByVal viajesTotales As Integer, ByVal viajesFull As Integer, ByVal viajesSencillo As Integer)

        If gridResumen.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()

            Dim columnas As Integer = gridResumen.ColumnCount
            Dim filas As Integer = gridResumen.RowCount

            For i As Integer = 1 To columnas

                'hoja.Cells.Item(1, i) = grid.Columns(i - 1).Name.ToString()
                hoja.Cells.Item(1, i) = gridResumen.Columns(i - 1).HeaderText

            Next

            For fila As Integer = 0 To filas - 1
                For columna As Integer = 0 To columnas - 1

                    hoja.Cells.Item(fila + 2, columna + 1) = gridResumen.Rows(fila).Cells(columna).Value

                Next
            Next

            hoja.Cells.Item(filas + 2, 3) = "Viajes totales: " & viajesTotales & vbCrLf & "Full: " & viajesFull & vbCrLf & "Sencillo: " & viajesSencillo
            hoja.Rows.Item(1).Font.Bold = 1
            hoja.Rows.Item(1).HorizontalAlignment = 3
            hoja.Columns.AutoFit()
            App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()

        End If
    End Sub

    Private Sub agregarCargasExpo(ByRef dSBase As DataSet)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim cargaExpo As DataRow
        Dim contador As Integer
        Dim dT As DataTable
        Dim dS As DataSet

        dT = New DataTable()

        For Each columna As DataColumn In dSBase.Tables(0).Columns

            dT.Columns.Add(columna.ColumnName)

        Next

        Try
            If dSBase.Tables(0).Rows.Count > 0 Then

                contador = Convert.ToInt32(dSBase.Tables(0).Rows(dSBase.Tables(0).Rows.Count - 1)("No").ToString())

            End If

            contador += 1
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Resumen_CargasExpo", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each carga As DataRow In dS.Tables(0).Rows
                        If Convert.ToInt32(carga("contenedor").ToString().Trim().Split("X")(0)) > 2 Then
                            For index As Integer = 1 To Convert.ToInt32(carga("contenedor").ToString().Trim().Split("X")(0)) / 2

                                dSBase.Tables(0).Rows.Add()
                                cargaExpo = dSBase.Tables(0).Rows(dSBase.Tables(0).Rows.Count - 1)
                                'cargaExpo("No") = contador
                                cargaExpo("No") = 0
                                cargaExpo("CONTENEDOR") = "2 X " & carga("contenedor").ToString().Split("X")(1)
                                cargaExpo("TIPO") = carga("contenedor").ToString().Split("X")(1)
                                cargaExpo("REFERENCIA") = ""
                                cargaExpo("CLIENTE") = carga("cliente").ToString()
                                cargaExpo("TIPO1") = carga("tipo").ToString()
                                cargaExpo("ENTREGA2") = ""
                                cargaExpo("DESTINO") = ""
                                cargaExpo("TERMINAL") = carga("terminal").ToString()
                                cargaExpo("STATUS") = carga("status").ToString()
                                cargaExpo("DEMORAS") = carga("demoras").ToString()
                                cargaExpo("NAVIERA") = carga("naviera").ToString()
                                cargaExpo("OPERACION") = carga("tipoOp").ToString()
                                cargaExpo("CARGA PELIGROSA") = ""
                                cargaExpo("PLANTA") = carga("fechaPlanta").ToString()
                                cargaExpo("CITA") = carga("cita").ToString()
                                cargaExpo.AcceptChanges()
                                dSBase.AcceptChanges()
                                contador += 1

                            Next

                            For index As Integer = 1 To Convert.ToInt32(carga("contenedor").ToString().Trim().Split("X")(0)) Mod 2

                                dSBase.Tables(0).Rows.Add()
                                cargaExpo = dSBase.Tables(0).Rows(dSBase.Tables(0).Rows.Count - 1)
                                'cargaExpo("No") = contador
                                cargaExpo("No") = 0
                                cargaExpo("CONTENEDOR") = "1 X " & carga("contenedor").ToString().Split("X")(1)
                                cargaExpo("TIPO") = carga("contenedor").ToString().Split("X")(1)
                                cargaExpo("REFERENCIA") = ""
                                cargaExpo("CLIENTE") = carga("cliente").ToString()
                                cargaExpo("TIPO1") = carga("tipo").ToString()
                                cargaExpo("ENTREGA2") = ""
                                cargaExpo("DESTINO") = ""
                                cargaExpo("TERMINAL") = carga("terminal").ToString()
                                cargaExpo("STATUS") = carga("status").ToString()
                                cargaExpo("DEMORAS") = carga("demoras").ToString()
                                cargaExpo("NAVIERA") = carga("naviera").ToString()
                                cargaExpo("OPERACION") = carga("tipoOp").ToString()
                                cargaExpo("CARGA PELIGROSA") = ""
                                cargaExpo("PLANTA") = carga("fechaPlanta").ToString()
                                cargaExpo("CITA") = carga("cita").ToString()
                                cargaExpo.AcceptChanges()
                                dSBase.AcceptChanges()
                                contador += 1

                            Next

                            Continue For

                        Else

                            dSBase.Tables(0).Rows.Add()
                            cargaExpo = dSBase.Tables(0).Rows(dSBase.Tables(0).Rows.Count - 1)
                            'cargaExpo("No") = contador
                            cargaExpo("No") = 0
                            cargaExpo("CONTENEDOR") = carga("contenedor").ToString()
                            cargaExpo("TIPO") = carga("contenedor").ToString().Split("X")(1)
                            cargaExpo("REFERENCIA") = ""
                            cargaExpo("CLIENTE") = carga("cliente").ToString()
                            cargaExpo("TIPO1") = carga("tipo").ToString()
                            cargaExpo("ENTREGA2") = ""
                            cargaExpo("DESTINO") = ""
                            cargaExpo("TERMINAL") = carga("terminal").ToString()
                            cargaExpo("STATUS") = carga("status").ToString()
                            cargaExpo("DEMORAS") = carga("demoras").ToString()
                            cargaExpo("NAVIERA") = carga("naviera").ToString()
                            cargaExpo("OPERACION") = carga("tipoOp").ToString()
                            cargaExpo("CARGA PELIGROSA") = ""
                            cargaExpo("PLANTA") = carga("fechaPlanta").ToString()
                            cargaExpo("CITA") = carga("cita").ToString()
                            cargaExpo.AcceptChanges()
                            dSBase.AcceptChanges()
                            contador += 1

                        End If
                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al cargar la información de cargas expo: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub expotarReporteConFormato(ByVal viajesTotales As Integer, ByVal viajesFull As Integer, ByVal viajesSencillo As Integer)

        If Me.gridResumen.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim borders As Microsoft.Office.Interop.Excel.Borders
            Dim style1 As Microsoft.Office.Interop.Excel.Style
            Dim style2 As Microsoft.Office.Interop.Excel.Style
            Dim columnas As Integer = Me.gridResumen.ColumnCount
            Dim filas As Integer = Me.gridResumen.RowCount
            Dim filaTotal = 0

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()
            hoja.Cells(1, 1) = "PROGRAMA " & DateTime.Now.ToString("dd/MM/yyyy")
            hoja.Cells(2, 1) = "B"
            hoja.Cells(2, 2) = "CONT."
            hoja.Cells(2, 3) = "CLIENTE"
            hoja.Cells(2, 4) = "TIPO"
            hoja.Cells(2, 5) = "DESTINO"
            hoja.Cells(2, 6) = "STATUS"
            hoja.Cells(2, 7) = ""
            hoja.Cells(2, 8) = "TERMINAL"
            hoja.Cells(2, 9) = "STATUS1"
            hoja.Cells(2, 10) = "DEMORAS"
            hoja.Cells(2, 11) = "NAVIERA"
            hoja.Cells(2, 12) = "OPERACIÓN"

            For fila As Integer = 0 To filas - 1

                hoja.Cells.Item(fila + 3, 1) = Me.gridResumen.Rows(fila).Cells("No").Value
                hoja.Cells.Item(fila + 3, 2) = Me.gridResumen.Rows(fila).Cells("CONTENEDOR").Value
                hoja.Cells.Item(fila + 3, 3) = Me.gridResumen.Rows(fila).Cells("CLIENTE").Value
                hoja.Cells.Item(fila + 3, 4) = Me.gridResumen.Rows(fila).Cells("TIPO1").Value
                hoja.Cells.Item(fila + 3, 5) = Me.gridResumen.Rows(fila).Cells("DESTINO").Value
                hoja.Cells.Item(fila + 3, 6) = Me.gridResumen.Rows(fila).Cells("STATUS").Value
                hoja.Cells.Item(fila + 3, 7) = ""
                hoja.Cells.Item(fila + 3, 8) = Me.gridResumen.Rows(fila).Cells("TERMINAL").Value
                hoja.Cells.Item(fila + 3, 9) = Me.gridResumen.Rows(fila).Cells("STATUS").Value
                hoja.Cells.Item(fila + 3, 10) = Me.gridResumen.Rows(fila).Cells("DEMORAS").Value
                hoja.Cells.Item(fila + 3, 11) = Me.gridResumen.Rows(fila).Cells("NAVIERA").Value
                hoja.Cells.Item(fila + 3, 12) = Me.gridResumen.Rows(fila).Cells("OPERACION").Value
                filaTotal += 1

            Next

            filaTotal += 3
            hoja.Range("C" & filaTotal).Value = "Viajes totales: " & viajesTotales & vbCrLf & "Full: " & viajesFull & vbCrLf & "Sencillo: " & viajesSencillo
            hoja.Range("C" & filaTotal).Font.Bold = 1

            borders = hoja.Range("A1", "M" & filaTotal).Borders
            borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            borders.Weight = 2.0R
            hoja.Range("A1", "M1").MergeCells = True
            hoja.Range("A1", "M2").Interior.Color = ColorTranslator.ToOle(Color.DarkCyan)
            hoja.Range("A1", "M2").Font.Size = 8
            hoja.Range("A1", "M2").Font.Color = ColorTranslator.ToOle(Color.White)
            hoja.Range("A1", "M2").Font.Bold = 1
            hoja.Range("A1", "M" & filaTotal).WrapText = True
            hoja.Range("A1", "M" & filaTotal).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Range("A1", "M" & filaTotal).VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            hoja.Range("A3", "M" & filaTotal).Font.Size = 6
            hoja.Range("C" & filaTotal).Font.Size = 8
            hoja.Range("A3", "B" & filaTotal).Font.Size = 8
            hoja.Range("D3", "D" & filaTotal).Font.Bold = 1
            hoja.Range("D3", "D" & filaTotal).Font.Size = 8
            hoja.Columns.AutoFit()
            App.Application.Visible = True
            hoja = Nothing
            libro = Nothing
            App = Nothing
            GC.Collect()

        End If
    End Sub

    Private Sub guardarColaEspera()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try
            If Me.dGVCola.Rows.Count <= 0 Then

                Exit Try

            End If

            consulta = "DELETE FROM Trafico_ResumenCargas_ColaEspera"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            For Each carga As DataGridViewRow In Me.dGVCola.Rows

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("UP_ResumenCargasCola_Ins", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 600
                conexion.Open()

                With comando.Parameters

                    .AddWithValue("@contenedor", carga.Cells("colContenedor").Value.ToString())
                    .AddWithValue("@tipo", carga.Cells("colTipo").Value.ToString())
                    .AddWithValue("@referencia", carga.Cells("colReferencia").Value.ToString())
                    .AddWithValue("@cliente", carga.Cells("colCliente").Value.ToString())
                    .AddWithValue("@tipo1", carga.Cells("colTipo1").Value.ToString())
                    .AddWithValue("@entrega2", carga.Cells("colEntregarEn").Value.ToString())
                    .AddWithValue("@destino", carga.Cells("colDestino").Value.ToString())
                    .AddWithValue("@terminal", carga.Cells("colTerminal").Value.ToString())
                    .AddWithValue("@status", carga.Cells("colStatus").Value.ToString())
                    .AddWithValue("@demoras", carga.Cells("colDemora").Value.ToString())
                    .AddWithValue("@naviera", carga.Cells("colNaviera").Value.ToString())
                    .AddWithValue("@operacion", carga.Cells("colOperacion").Value.ToString())
                    .AddWithValue("@esPeligrosa", IIf(carga.Cells("colCargaPeligrosa").Value.ToString().Equals("SI"), 1, 0))
                    .AddWithValue("@planta", carga.Cells("colPlanta").Value.ToString())
                    .AddWithValue("@cita", carga.Cells("colCita").Value.ToString())

                End With

                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            Next
        Catch ex As Exception

            MessageBox.Show("Error al guardar la cola de espera: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function consultarResumenGuardado() As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        dS = New DataSet()

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ConsultarResumen_Cargas", conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al consultar el resúmen: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dS

    End Function

    Private Function consultarColaEspera() As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        dS = New DataSet()

        Try

            consulta = "SELECT * FROM Trafico_ResumenCargas_ColaEspera"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            dS = New DataSet
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al consultar la cola de espera: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dS

    End Function

    Private Sub armarFull()

        If Me.gridResumen.SelectedRows.Count = 2 Then
            If Me.gridResumen.SelectedRows(0).Cells("CLIENTE").Value.ToString().Equals(Me.gridResumen.SelectedRows(1).Cells("CLIENTE").Value.ToString()) AndAlso Me.gridResumen.SelectedRows(0).Cells("DESTINO").Value.ToString().Equals(Me.gridResumen.SelectedRows(1).Cells("DESTINO").Value.ToString()) AndAlso Me.gridResumen.SelectedRows(0).Cells("TIPO1").Value.ToString().Equals("S") AndAlso Me.gridResumen.SelectedRows(1).Cells("TIPO1").Value.ToString().Equals("S") Then
                If Me.gridResumen.SelectedRows(0).Cells("CONTENEDOR").Value.ToString().Contains("-00") Then

                    Me.gridResumen.SelectedRows(0).Cells("CONTENEDOR").Value = Me.gridResumen.SelectedRows(0).Cells("CONTENEDOR").Value.ToString().Replace("1 X", "2 X")
                    Me.gridResumen.SelectedRows(0).Cells("TIPO1").Value = "F"
                    Me.gridResumen.Rows.Remove(Me.gridResumen.SelectedRows(1))

                Else

                    Me.gridResumen.SelectedRows(1).Cells("CONTENEDOR").Value = Me.gridResumen.SelectedRows(1).Cells("CONTENEDOR").Value.ToString().Replace("1 X", "2 X")
                    Me.gridResumen.SelectedRows(1).Cells("TIPO1").Value = "F"
                    Me.gridResumen.Rows.Remove(Me.gridResumen.SelectedRows(0))

                End If
            Else

                MessageBox.Show("Para poder armar el Full ambas cargas deben ser de tipo sencillo y del mismo cliente y tener el mismo destino", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else

            MessageBox.Show("Debe seleccionar solo dos cargas en sencillo para poder armar un full.", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub combinarCargas()

        Dim cantidad As Integer
        Dim i As Integer

        cantidad = 0

        For Each carga As DataGridViewRow In Me.gridResumen.SelectedRows

            cantidad += Convert.ToInt32(carga.Cells("CONTENEDOR").Value.ToString().Split(" X ")(0))

        Next

        Me.gridResumen.SelectedRows(0).Cells("CONTENEDOR").Value = cantidad & " X" & Me.gridResumen.SelectedRows(0).Cells("CONTENEDOR").Value.ToString().Split("X")(1)

        i = Me.gridResumen.SelectedRows.Count - 1

        While i > 0

            Me.gridResumen.Rows.Remove(Me.gridResumen.SelectedRows(i))
            i -= 1

        End While
    End Sub

    Private Sub duplicarCargas()

        Dim cargaDuplicada As DataGridViewRow

        For Each carga As DataGridViewRow In Me.gridResumen.SelectedRows

            cargaDuplicada = Me.gridResumen.Rows(Me.gridResumen.Rows.Add())

            For index As Integer = 0 To carga.Cells.Count - 1

                cargaDuplicada.Cells(index).Value = carga.Cells(index).Value

            Next
        Next
    End Sub
End Class