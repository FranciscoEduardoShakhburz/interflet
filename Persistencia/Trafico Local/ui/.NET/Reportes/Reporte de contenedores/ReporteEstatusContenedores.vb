Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Data.OleDb

Public Class ReporteEstatusContenedores

    ''' <summary>
    ''' Genera el reporte de los contenedores que estan por salir del patio con su respectivo estatus.
    ''' </summary>
    ''' <history>[Omar Alí V. Striever] 27/10/2015 Creación</history>

    Private sort As Boolean ' Atributo de la clase que permite identificar si el grid de contenedores vacíos está ordenado por alguna columna.

    Private filasEliminadas As List(Of DataGridViewRow) ' Atributo de la clase que permite repaldar las columnas eliminadas.

    ''' <summary>
    ''' Carga la forma con configuraciones predeterminadas en algunos controles.
    ''' </summary>    
    Private Sub ReporteEstatusContenedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.btnGuardar.Enabled = False
        'Me.btnExportar.Enabled = False
        Me.cargarGridLlenos()
        Me.cargarGridSalientes()
        Me.cargarGridVacios()
        Me.filasEliminadas = New List(Of DataGridViewRow)
        Me.gridSalientesVacios.AllowUserToAddRows = False
        Me.gridSalientesLlenos.AllowUserToAddRows = False

    End Sub

    ''' <summary>
    ''' Define en modo programático el ordenamiento del grid de contenedores vacíos.
    ''' </summary>
    Private Sub gridReporte_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gridContVacios.DataBindingComplete

        For Each columna As DataGridViewColumn In Me.gridContVacios.Columns

            columna.SortMode = DataGridViewColumnSortMode.Programmatic

        Next
    End Sub

    ''' <summary>
    ''' Obtiene la información de los contenedores con su estatus.
    ''' </summary>
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim dA, dA1 As SqlDataAdapter
        Dim dS, dS1 As DataSet
        Dim sql, unidad As String
        Dim cont As DataGridViewRow

        Try

            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            ' El programa verifica si ya existe un reporte guardado en la base de datos
            sql = "SELECT idReporte FROM trafico_reporte_estatus_contenedores WHERE fechaReporte = '" & Date.Today.ToString("dd/MM/yyyy") & "' SELECT idReporte FROM trafico_reporte_estatus_contenedores WHERE fechaReporte = '" & Date.Today.ToString("dd/MM/yyyy") & "'"
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            dA = New SqlDataAdapter(comando)
            dS = New DataSet()
            dA.Fill(dS)
            conexion.Close()
            conexion.Dispose()

            ' Si hay un reporte guardado previamente, se procede a consultar el detalle
            If dS.Tables(0).Rows.Count > 0 Then

                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                sql = "SELECT fechaReporteSalidas, MANIOBRA, TERMINAL, REFERENCIA, CLIENTE, CONTENEDOR, TIPO, llegada, DEMORA, [STATUS], NAVIERA, GRUPO, fechaPase, OBSERVACIONES FROM trafico_reporte_estatus_contenedores_detalle WHERE idReporte = " & Convert.ToInt32(dS.Tables(0).Rows(0).Item(0).ToString()) & " AND grupo = 'VACÍO' AND procesado = 0 "
                sql += "SELECT fechaReporteSalidas, MANIOBRA, TERMINAL, REFERENCIA, CLIENTE, CONTENEDOR, TIPO, llegada, DEMORA, [STATUS], NAVIERA, GRUPO, fechaPase, OBSERVACIONES FROM trafico_reporte_estatus_contenedores_detalle WHERE idReporte = " & Convert.ToInt32(dS.Tables(0).Rows(0).Item(0).ToString()) & " AND grupo = 'LLENO' AND procesado = 0 "
                sql += "SELECT fechaReporteSalidas, MANIOBRA, TERMINAL, REFERENCIA, CLIENTE, CONTENEDOR, TIPO, llegada, DEMORA, [STATUS], NAVIERA, GRUPO, fechaPase, OBSERVACIONES FROM trafico_reporte_estatus_contenedores_detalle WHERE idReporte = " & Convert.ToInt32(dS.Tables(0).Rows(0).Item(0).ToString()) & " AND grupo = 'VACÍO' AND procesado = 1 "
                sql += "SELECT fechaReporteSalidas, MANIOBRA, TERMINAL, REFERENCIA, CLIENTE, CONTENEDOR, TIPO, llegada, DEMORA, [STATUS], NAVIERA, GRUPO, fechaPase, OBSERVACIONES FROM trafico_reporte_estatus_contenedores_detalle WHERE idReporte = " & Convert.ToInt32(dS.Tables(0).Rows(0).Item(0).ToString()) & " AND grupo = 'LLENO' AND procesado = 1 "
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                dA = New SqlDataAdapter(comando)
                dS1 = New DataSet()
                dA.Fill(dS1)

                If dS1.Tables.Count > 0 Then
                    If dS1.Tables(0).Rows.Count > 0 Then
                        For Each carga As DataRow In dS1.Tables(0).Rows

                            Me.gridContVacios.Rows.Add()
                            cont = Me.gridContVacios.Rows(Me.gridContVacios.Rows.Count - 2)
                            cont.Cells("FECHA DE REPORTE").Value = carga(0).ToString()
                            cont.Cells("FOLIO").Value = carga(1).ToString()
                            cont.Cells("TERMINAL").Value = carga(2).ToString()
                            cont.Cells("REFERENCIA").Value = carga(3).ToString()
                            cont.Cells("CLIENTE").Value = carga(4).ToString()
                            cont.Cells("CONTENEDORES").Value = carga(5).ToString()
                            cont.Cells("TIPO").Value = carga(6).ToString()
                            cont.Cells("F. LLEGADA").Value = carga(7).ToString()
                            cont.Cells("DEMORA").Value = carga(8).ToString()
                            cont.Cells("STATUS").Value = carga(9).ToString()
                            cont.Cells("NAVIERA").Value = carga(10).ToString()
                            cont.Cells("GRUPO").Value = carga(11).ToString()
                            cont.Cells("F. PASE").Value = carga(12).ToString()
                            cont.Cells("OBSERVACIONES").Value = carga(13).ToString()

                        Next
                    End If

                    If dS1.Tables(1).Rows.Count > 0 Then
                        For Each carga As DataRow In dS1.Tables(1).Rows

                            Me.gridContLlenos.Rows.Add()
                            cont = Me.gridContLlenos.Rows(Me.gridContLlenos.Rows.Count - 2)
                            cont.Cells("FECHA DE REPORTE").Value = carga(0).ToString()
                            cont.Cells("FOLIO").Value = carga(1).ToString()
                            cont.Cells("TERMINAL").Value = carga(2).ToString()
                            cont.Cells("REFERENCIA").Value = carga(3).ToString()
                            cont.Cells("CLIENTE").Value = carga(4).ToString()
                            cont.Cells("CONTENEDORES").Value = carga(5).ToString()
                            cont.Cells("TIPO").Value = carga(6).ToString()
                            cont.Cells("F. LLEGADA").Value = carga(7).ToString()
                            cont.Cells("DEMORA").Value = carga(8).ToString()
                            cont.Cells("STATUS").Value = carga(9).ToString()
                            cont.Cells("NAVIERA").Value = carga(10).ToString()
                            cont.Cells("GRUPO").Value = carga(11).ToString()
                            cont.Cells("F. PASE").Value = carga(12).ToString()
                            cont.Cells("OBSERVACIONES").Value = carga(13).ToString()

                        Next
                    End If

                    If dS1.Tables(2).Rows.Count > 0 Then
                        For Each carga As DataRow In dS1.Tables(2).Rows

                            Me.gridSalientesVacios.Rows.Add()
                            cont = Me.gridSalientesVacios.Rows(Me.gridSalientesVacios.Rows.Count - 1)
                            cont.Cells("FECHA DE REPORTE").Value = carga(0).ToString()
                            cont.Cells("FOLIO").Value = carga(1).ToString()
                            cont.Cells("TERMINAL").Value = carga(2).ToString()
                            cont.Cells("REFERENCIA").Value = carga(3).ToString()
                            cont.Cells("CLIENTE").Value = carga(4).ToString()
                            cont.Cells("CONTENEDORES").Value = carga(5).ToString()
                            cont.Cells("TIPO").Value = carga(6).ToString()
                            cont.Cells("F. LLEGADA").Value = carga(7).ToString()
                            cont.Cells("DEMORA").Value = carga(8).ToString()
                            cont.Cells("STATUS").Value = carga(9).ToString()
                            cont.Cells("NAVIERA").Value = carga(10).ToString()
                            cont.Cells("GRUPO").Value = carga(11).ToString()
                            cont.Cells("F. PASE").Value = carga(12).ToString()
                            cont.Cells("OBSERVACIONES").Value = carga(13).ToString()

                        Next
                    End If

                    If dS1.Tables(3).Rows.Count > 0 Then
                        For Each carga As DataRow In dS1.Tables(3).Rows

                            Me.gridSalientesLlenos.Rows.Add()
                            cont = Me.gridSalientesLlenos.Rows(Me.gridSalientesLlenos.Rows.Count - 1)
                            cont.Cells("FECHA DE REPORTE").Value = carga(0).ToString()
                            cont.Cells("FOLIO").Value = carga(1).ToString()
                            cont.Cells("TERMINAL").Value = carga(2).ToString()
                            cont.Cells("REFERENCIA").Value = carga(3).ToString()
                            cont.Cells("CLIENTE").Value = carga(4).ToString()
                            cont.Cells("CONTENEDORES").Value = carga(5).ToString()
                            cont.Cells("TIPO").Value = carga(6).ToString()
                            cont.Cells("F. LLEGADA").Value = carga(7).ToString()
                            cont.Cells("DEMORA").Value = carga(8).ToString()
                            cont.Cells("STATUS").Value = carga(9).ToString()
                            cont.Cells("NAVIERA").Value = carga(10).ToString()
                            cont.Cells("GRUPO").Value = carga(11).ToString()
                            cont.Cells("F. PASE").Value = carga(12).ToString()
                            cont.Cells("OBSERVACIONES").Value = carga(13).ToString()

                        Next
                    End If
                End If

                conexion.Close()
                conexion.Dispose()
                Me.remarcarFilas(Me.gridContVacios)
                Me.remarcarFilas(Me.gridContLlenos)
                Me.btnGuardar.Enabled = True
                Me.btnExportar.Enabled = True

            End If
        Catch ex As Exception

            ' Si hay un error, se muestra un mensaje.
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Cursor.Current = Cursors.Arrow

    End Sub

    ''' <summary>
    ''' Por omisión, al escribir en las celdas del grid de contenedores llenos, la información se mostrará en mayúsculas.
    ''' </summary>    
    Private Sub gridContLlenos_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles gridContLlenos.CellFormatting

        If e.Value IsNot Nothing Then

            e.Value = e.Value.ToString().ToUpper()
            e.FormattingApplied = True

        End If
    End Sub

    ''' <summary>
    ''' Al generar una nueva fila, la leyenda "LLENO" se mostrará automáticamente en la celda de "GRUPO". Además, estará en modo "Sólo lectura".
    ''' </summary>    
    Private Sub gridContLlenos_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridContLlenos.RowEnter

        Me.gridContLlenos.Rows(e.RowIndex).Cells("GRUPO").Value = "LLENO"
        Me.gridContLlenos.Rows(e.RowIndex).Cells("GRUPO").ReadOnly = True

    End Sub

    ''' <summary>
    ''' En caso de que al pasar de una celda a otra en el grid de contenedores llenos usando la tecla "TAB", se agregará la cadena vacía a dicha celda con excepción de la celda correspondiente a la columna "GRUPO".
    ''' </summary>    
    Private Sub gridContLlenos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridContLlenos.KeyDown

        If e.KeyCode = Keys.Tab Then
            If Not Me.gridContLlenos.CurrentCell.ColumnIndex = 10 Then

                Me.gridContLlenos.Rows(Me.gridContLlenos.CurrentRow.Index).Cells(Me.gridContLlenos.CurrentCell.ColumnIndex).Value = ""

            End If
        End If
    End Sub

    ''' <summary>
    ''' Evento que ordena el grid al seleccionar una columna. 
    ''' </summary>
    Private Sub gridContVacios_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridContVacios.ColumnHeaderMouseClick

        If Me.sort Then

            Me.gridContVacios.Sort(Me.gridContVacios.Columns(e.ColumnIndex), ListSortDirection.Descending)
            Me.sort = False

        Else

            Me.gridContVacios.Sort(Me.gridContVacios.Columns(e.ColumnIndex), ListSortDirection.Ascending)
            Me.sort = True

        End If

        Me.remarcarFilas(Me.gridContVacios)

    End Sub

    ''' <summary>
    ''' Cierra la aplicación.
    ''' </summary>    
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    ''' <summary>
    ''' Colorea cada fila (que en este caso representa un contenedor) de acuerdo al dato de la columna "Demora", creando así un semáforo de alerta que permite al usuario visualizar los contenedores que estan a punto de causar demora. Los colores que se manejan son: Verde, Amarillo, Rojo y Azul Cielo.
    ''' </summary>
    Private Sub remarcarFilas(ByRef grid As DataGridView)

        Dim fecha As Date
        Dim diferencia As Int16
        Dim span As TimeSpan
        Dim item As DataGridViewRow

        Try

            For index As Int32 = 0 To grid.Rows.Count - 2

                item = grid.Rows.Item(index)

                If Not String.IsNullOrEmpty(item.Cells("F. LLEGADA").Value.ToString()) Then
                    If IsDate(item.Cells("F. LLEGADA").Value.ToString()) Then
                        If Not String.IsNullOrEmpty(item.Cells("DEMORA").Value.ToString()) Then

                            ' Repaldo de la fecha de demora del contenedor.
                            fecha = Convert.ToDateTime(item.Cells("DEMORA").Value.ToString())
                            span = fecha.Subtract(Date.Today)
                            ' Se obtiene la diferencia entre la fecha de demora del contenedor y la fecha actual.
                            diferencia = Convert.ToInt16(span.TotalDays)

                            ' Si ya se pasó la fecha de demora, la fila se colorea de rojo
                            If diferencia <= 0 Then

                                item.DefaultCellStyle.BackColor = Color.Red

                            End If
                        End If
                    End If
                End If
            Next
        Catch ex As Exception

            MessageBox.Show("Hubo un problema al colorear las filas: " + ex.Message + "." + vbCrLf + "Verifique si las fechas de demora o de cierre son correctas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ''' <summary>
    ''' Exporta la información de ambos grids a un archivo de Excel.
    ''' </summary>    
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim grid1, grid2 As DataGridView

        grid1 = New DataGridView()
        grid1.AllowUserToAddRows = False

        For Each columna As DataGridViewColumn In Me.gridContVacios.Columns

            grid1.Columns.Add(columna.Name, columna.HeaderText)

        Next

        For fila As Int32 = 0 To Me.gridContVacios.Rows.Count - 2
            If Me.gridContVacios.Rows(fila).Visible = True Then
                If String.IsNullOrEmpty(Me.gridContVacios.Rows(fila).Cells("FOLIO").Value.ToString()) Then

                    Continue For

                End If

                grid1.Rows.Add()

                For index As Integer = 0 To Me.gridContVacios.ColumnCount - 1

                    grid1.Rows(grid1.Rows.Count - 1).Cells(index).Value = Me.gridContVacios.Rows(fila).Cells(index).Value

                Next
            End If
        Next

        grid2 = New DataGridView()
        grid2.AllowUserToAddRows = False

        For Each columna As DataGridViewColumn In Me.gridContLlenos.Columns

            grid2.Columns.Add(columna.Name, columna.HeaderText)

        Next

        For fila As Int32 = 0 To Me.gridContLlenos.Rows.Count - 2
            If Me.gridContLlenos.Rows(fila).Visible = True Then
                If String.IsNullOrEmpty(Me.gridContLlenos.Rows(fila).Cells("FOLIO").Value.ToString()) Then

                    Continue For

                End If

                grid2.Rows.Add()

                For index As Integer = 0 To Me.gridContLlenos.ColumnCount - 1

                    grid2.Rows(grid2.Rows.Count - 1).Cells(index).Value = Me.gridContLlenos.Rows(fila).Cells(index).Value

                Next
            End If
        Next

        Me.dosGridsAExcel(grid1, grid2)
        Cursor.Current = Cursors.Arrow

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="grid1">Nombre del grid cuya información aparaecerá primero en el archivo de excel</param>
    ''' <param name="grid2">Nombre del grid cuya información aparaecerá al final en el archivo de excel</param>
    ''' <remarks></remarks>
    Private Sub dosGridsAExcel(ByVal grid1 As DataGridView, ByVal grid2 As DataGridView)

        If grid1.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim columnas As Integer = grid1.ColumnCount
            Dim filas As Integer = grid1.RowCount
            Dim filaColor As Microsoft.Office.Interop.Excel.Range
            Dim filaX As Integer = 0
            libro = App.Workbooks.Add()
            hoja = libro.Worksheets.Add()

            For i As Integer = 1 To columnas

                hoja.Cells.Item(1, i) = grid1.Columns(i - 1).Name.ToString()

            Next

            For fila As Integer = 0 To filas - 1
                For columna As Integer = 0 To columnas - 1

                    filaColor = hoja.Rows(fila + 2)

                    If grid1.Rows.Item(fila).DefaultCellStyle.BackColor = Color.Red Then

                        filaColor.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)

                    ElseIf grid1.Rows.Item(fila).DefaultCellStyle.BackColor = Color.Yellow Then

                        filaColor.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)

                    ElseIf grid1.Rows.Item(fila).DefaultCellStyle.BackColor = Color.Green Then

                        filaColor.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green)

                    Else

                        filaColor.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.SkyBlue)

                    End If

                    hoja.Cells.Item(fila + 2, columna + 1) = grid1.Rows(fila).Cells(columna).Value

                Next

                filaX = fila

            Next

            filaX += 3
            filas = grid2.Rows.Count
            columnas = grid2.Columns.Count

            If grid2.Rows.Count > 0 Then
                For i As Integer = 1 To columnas

                    hoja.Cells.Item(filaX, i) = grid2.Columns(i - 1).Name.ToString()

                Next

                hoja.Rows.Item(filaX).Font.Bold = 1
                hoja.Rows.Item(filaX).HorizontalAlignment = 3

                For fila As Integer = 0 To filas - 1
                    For columna As Integer = 0 To columnas - 1

                        hoja.Cells.Item(filaX + 1, columna + 1) = grid2.Rows(fila).Cells(columna).Value

                    Next

                    filaX += 1

                Next
            End If

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

    ''' <summary>
    ''' Genera las columnas del grid de contenedores llenos.
    ''' </summary>
    Private Sub cargarGridLlenos()

        With Me.gridContLlenos.Columns

            .Add("FECHA DE REPORTE", "FECHA DE REPORTE")
            .Add("FOLIO", "FOLIO")
            .Add("TERMINAL", "TERMINAL")
            .Add("REFERENCIA", "REFERENCIA")
            .Add("CLIENTE", "CLIENTE")
            .Add("CONTENEDORES", "CONTENEDORES")
            .Add("TIPO", "TIPO")
            .Add("F. LLEGADA", "F. LLEGADA")
            .Add("DEMORA", "CIERRE")
            .Add("STATUS", "STATUS")
            .Add("NAVIERA", "NAVIERA")
            .Add("GRUPO", "GRUPO")
            .Add("F. PASE", "FECHA DE PASE")
            .Add("OBSERVACIONES", "OBSERVACIONES")

        End With
    End Sub

    ''' <summary>
    ''' Genera las columnas del grid de contenedores vacíos.
    ''' </summary>
    Private Sub cargarGridVacios()

        With Me.gridContVacios.Columns

            .Add("FECHA DE REPORTE", "FECHA DE REPORTE")
            .Add("FOLIO", "FOLIO")
            .Add("TERMINAL", "TERMINAL")
            .Add("REFERENCIA", "REFERENCIA")
            .Add("CLIENTE", "CLIENTE")
            .Add("CONTENEDORES", "CONTENEDORES")
            .Add("TIPO", "TIPO")
            .Add("F. LLEGADA", "F. LLEGADA")
            .Add("DEMORA", "DEMORA")
            .Add("STATUS", "STATUS")
            .Add("NAVIERA", "NAVIERA")
            .Add("GRUPO", "GRUPO")
            .Add("F. PASE", "FECHA DE PASE")
            .Add("OBSERVACIONES", "OBSERVACIONES")

        End With
    End Sub

    ''' <summary>
    ''' Genera las columnas de los grid de contenedores salientes.
    ''' </summary>
    Private Sub cargarGridSalientes()

        With Me.gridSalientesVacios.Columns

            .Add("FECHA DE REPORTE", "FECHA DE REPORTE")
            .Add("FOLIO", "FOLIO")
            .Add("TERMINAL", "TERMINAL")
            .Add("REFERENCIA", "REFERENCIA")
            .Add("CLIENTE", "CLIENTE")
            .Add("CONTENEDORES", "CONTENEDORES")
            .Add("TIPO", "TIPO")
            .Add("F. LLEGADA", "F. LLEGADA")
            .Add("DEMORA", "DEMORA")
            .Add("STATUS", "STATUS")
            .Add("NAVIERA", "NAVIERA")
            .Add("GRUPO", "GRUPO")
            .Add("F. PASE", "FECHA DE PASE")
            .Add("OBSERVACIONES", "OBSERVACIONES")

        End With

        With Me.gridSalientesLlenos.Columns

            .Add("FECHA DE REPORTE", "FECHA DE REPORTE")
            .Add("FOLIO", "FOLIO")
            .Add("TERMINAL", "TERMINAL")
            .Add("REFERENCIA", "REFERENCIA")
            .Add("CLIENTE", "CLIENTE")
            .Add("CONTENEDORES", "CONTENEDORES")
            .Add("TIPO", "TIPO")
            .Add("F. LLEGADA", "F. LLEGADA")
            .Add("DEMORA", "CIERRE")
            .Add("STATUS", "STATUS")
            .Add("NAVIERA", "NAVIERA")
            .Add("GRUPO", "GRUPO")
            .Add("F. PASE", "FECHA DE PASE")
            .Add("OBSERVACIONES", "OBSERVACIONES")

        End With
    End Sub

    ''' <summary>
    ''' Guarda el reporte de contenedores en la base de datos.
    ''' </summary>
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim dA As SqlDataAdapter
        Dim dS As DataSet
        Dim carga As DataGridViewRow

        For Each Item As DataGridViewRow In Me.gridContVacios.Rows
            If Item.Visible = False Then

                Me.gridContVacios.Rows.Remove(Item)

            End If
        Next

        For Each Item As DataGridViewRow In Me.gridContLlenos.Rows
            If Item.Visible = False Then

                Me.gridContLlenos.Rows.Remove(Item)

            End If
        Next

        Try

            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            ' En primer lugar, se guarda la información general del reporte.
            comando = New SqlCommand("up_trafico_reporte_EstContenedores_insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 1000
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()

            ' Después, se procede a guardar la información de cada contenedor
            For i As Integer = 0 To Me.gridContVacios.Rows.Count - 2

                carga = Me.gridContVacios.Rows(i)
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand("up_trafico_reporte_EstContenedores_detalle_insert", conexion)

                With comando.Parameters

                    .AddWithValue("@referencia", carga.Cells("REFERENCIA").Value.ToString())
                    .AddWithValue("@contenedor", carga.Cells("CONTENEDORES").Value.ToString())
                    .AddWithValue("@maniobra", carga.Cells("FOLIO").Value.ToString())
                    .AddWithValue("@terminal", carga.Cells("TERMINAL").Value.ToString())
                    .AddWithValue("@cliente", carga.Cells("CLIENTE").Value.ToString())
                    .AddWithValue("@tipo", carga.Cells("TIPO").Value.ToString())
                    .AddWithValue("@llegada", carga.Cells("F. LLEGADA").Value.ToString())
                    .AddWithValue("@demora", carga.Cells("DEMORA").Value.ToString())
                    .AddWithValue("@status", carga.Cells("STATUS").Value.ToString())
                    .AddWithValue("@naviera", carga.Cells("NAVIERA").Value.ToString())
                    .AddWithValue("@grupo", carga.Cells("GRUPO").Value.ToString())
                    .AddWithValue("@fechaPase", carga.Cells("F. PASE").Value.ToString())
                    .AddWithValue("@observaciones", carga.Cells("OBSERVACIONES").Value.ToString())
                    .AddWithValue("@fechaRepSalidas", carga.Cells("FECHA DE REPORTE").Value.ToString())
                    .AddWithValue("@procesado", 0)

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()

            Next

            Me.gridContLlenos.AllowUserToAddRows = False

            For i As Integer = 0 To Me.gridContLlenos.Rows.Count - 1

                carga = Me.gridContLlenos.Rows(i)
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand("up_trafico_reporte_EstContenedores_detalle_insert", conexion)

                With comando.Parameters

                    .AddWithValue("@referencia", carga.Cells("REFERENCIA").Value.ToString())
                    .AddWithValue("@contenedor", carga.Cells("CONTENEDORES").Value.ToString())
                    .AddWithValue("@maniobra", carga.Cells("FOLIO").Value.ToString())
                    .AddWithValue("@terminal", carga.Cells("TERMINAL").Value.ToString())
                    .AddWithValue("@cliente", carga.Cells("CLIENTE").Value.ToString())
                    .AddWithValue("@tipo", carga.Cells("TIPO").Value.ToString())
                    .AddWithValue("@llegada", carga.Cells("F. LLEGADA").Value.ToString())
                    .AddWithValue("@demora", carga.Cells("DEMORA").Value.ToString())
                    .AddWithValue("@status", carga.Cells("STATUS").Value.ToString())
                    .AddWithValue("@naviera", carga.Cells("NAVIERA").Value.ToString())
                    .AddWithValue("@grupo", carga.Cells("GRUPO").Value.ToString())
                    .AddWithValue("@fechaPase", carga.Cells("F. PASE").Value.ToString())
                    .AddWithValue("@observaciones", carga.Cells("OBSERVACIONES").Value.ToString())
                    .AddWithValue("@fechaRepSalidas", carga.Cells("FECHA DE REPORTE").Value.ToString())
                    .AddWithValue("@procesado", 0)

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()

            Next

            For i As Integer = 0 To Me.gridSalientesVacios.Rows.Count - 1

                carga = Me.gridSalientesVacios.Rows(i)
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand("up_trafico_reporte_EstContenedores_detalle_insert", conexion)

                With comando.Parameters

                    .AddWithValue("@referencia", carga.Cells("REFERENCIA").Value.ToString())
                    .AddWithValue("@contenedor", carga.Cells("CONTENEDORES").Value.ToString())
                    .AddWithValue("@maniobra", carga.Cells("FOLIO").Value.ToString())
                    .AddWithValue("@terminal", carga.Cells("TERMINAL").Value.ToString())
                    .AddWithValue("@cliente", carga.Cells("CLIENTE").Value.ToString())
                    .AddWithValue("@tipo", carga.Cells("TIPO").Value.ToString())
                    .AddWithValue("@llegada", carga.Cells("F. LLEGADA").Value.ToString())
                    .AddWithValue("@demora", carga.Cells("DEMORA").Value.ToString())
                    .AddWithValue("@status", carga.Cells("STATUS").Value.ToString())
                    .AddWithValue("@naviera", carga.Cells("NAVIERA").Value.ToString())
                    .AddWithValue("@grupo", carga.Cells("GRUPO").Value.ToString())
                    .AddWithValue("@fechaPase", carga.Cells("F. PASE").Value.ToString())
                    .AddWithValue("@observaciones", carga.Cells("OBSERVACIONES").Value.ToString())
                    .AddWithValue("@fechaRepSalidas", carga.Cells("FECHA DE REPORTE").Value.ToString())
                    .AddWithValue("@procesado", 1)

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()

            Next

            For i As Integer = 0 To Me.gridSalientesLlenos.Rows.Count - 1

                carga = Me.gridSalientesLlenos.Rows(i)
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                comando = New SqlCommand("up_trafico_reporte_EstContenedores_detalle_insert", conexion)

                With comando.Parameters

                    .AddWithValue("@referencia", carga.Cells("REFERENCIA").Value.ToString())
                    .AddWithValue("@contenedor", carga.Cells("CONTENEDORES").Value.ToString())
                    .AddWithValue("@maniobra", carga.Cells("FOLIO").Value.ToString())
                    .AddWithValue("@terminal", carga.Cells("TERMINAL").Value.ToString())
                    .AddWithValue("@cliente", carga.Cells("CLIENTE").Value.ToString())
                    .AddWithValue("@tipo", carga.Cells("TIPO").Value.ToString())
                    .AddWithValue("@llegada", carga.Cells("F. LLEGADA").Value.ToString())
                    .AddWithValue("@demora", carga.Cells("DEMORA").Value.ToString())
                    .AddWithValue("@status", carga.Cells("STATUS").Value.ToString())
                    .AddWithValue("@naviera", carga.Cells("NAVIERA").Value.ToString())
                    .AddWithValue("@grupo", carga.Cells("GRUPO").Value.ToString())
                    .AddWithValue("@fechaPase", carga.Cells("F. PASE").Value.ToString())
                    .AddWithValue("@observaciones", carga.Cells("OBSERVACIONES").Value.ToString())
                    .AddWithValue("@fechaRepSalidas", carga.Cells("FECHA DE REPORTE").Value.ToString())
                    .AddWithValue("@procesado", 1)

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()

            Next

            Me.gridContLlenos.AllowUserToAddRows = True
            MessageBox.Show("El reporte ha sido guardado exitosamente", "¡Reporte guardado!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor.Current = Cursors.Arrow

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    ''' <summary>
    ''' Genera un reporte con la información generada en base a un rango de fechas.
    ''' </summary>    
    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click

        Dim rep As SeleccionarReporte
        rep = New SeleccionarReporte()
        rep.ShowDialog(Me)

    End Sub

    ''' <summary>
    ''' Elimina la información de ambos grids.
    ''' </summary>
    Private Sub limpiarGrids()

        Me.gridContVacios.Rows.Clear()
        Me.gridContVacios.Columns.Clear()
        Me.gridContLlenos.Rows.Clear()
        Me.gridContLlenos.Columns.Clear()
        Me.gridSalientesVacios.Rows.Clear()
        Me.gridSalientesVacios.Columns.Clear()
        Me.gridSalientesLlenos.Rows.Clear()
        Me.gridSalientesLlenos.Columns.Clear()

    End Sub

    Private Sub btnAgregarTramSencillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTramSencillo.Click

        Cursor.Current = Cursors.AppStarting
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook
        Dim APP As New Microsoft.Office.Interop.Excel.Application
        Dim cont As Integer = 1
        Dim i As Integer = 1
        Dim r As Microsoft.Office.Interop.Excel.Range
        Dim array(,) As Object
        Dim rangoEnY As Integer
        Dim fila As DataGridViewRow
        Dim archivo As String

        'Try

        archivo = ""
        Dim oFD As New OpenFileDialog

        With oFD

            .Filter = "Ficheros Excel (*.xlsx)|*.xlsx|Todos (*.*)|*.*|(*.xls)|*.xls"
            .FileName = ""

            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                ' El nombre del fichero
                archivo = .FileName

            Else

                Return

            End If
        End With

        workbook = APP.Workbooks.Open(archivo)
        worksheet = workbook.Worksheets("ALTAMIRA")
        worksheet.Cells.EntireRow.Hidden = False
        r = worksheet.UsedRange
        array = r.Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault)
        rangoEnY = array.GetUpperBound(0)

        While worksheet.Cells(i, 8).Value Is Nothing

            i += 1

        End While

        While worksheet.Cells(i, 6).Value IsNot Nothing
            If worksheet.Cells(i, 6).Value.ToString().Equals("NAVIERA") Then

                Exit While

            End If

            i += 1

        End While

        i += 1

        While cont <= rangoEnY
            If worksheet.Rows(i).Hidden = True Then

                i += 1
                cont += 1
                Continue While

            End If

            If worksheet.Cells(i, 11).Value IsNot Nothing Then
                If Me.tieneEIR(worksheet.Cells(i, 11).Value.ToString().TrimEnd().TrimStart()) Then

                    i += 1
                    cont += 1
                    Continue While

                End If

                If Not worksheet.Cells(i, 11).Value.ToString().TrimEnd().TrimStart().Length = 13 Then

                    i += 1
                    cont += 1
                    Continue While

                End If
            Else

                Exit While

            End If

            Me.gridContLlenos.Rows.Add()
            Me.gridContLlenos.Refresh()
            fila = Me.gridContLlenos.Rows.Item(Me.gridContLlenos.Rows.Count - 2)

            If worksheet.Cells(i, 13).Value IsNot Nothing Then

                fila.Cells("FECHA DE REPORTE").Value = Convert.ToDateTime(worksheet.Cells(i, 8).Value.ToString()).ToString("dd/MM/yyyy")
                fila.Cells("FECHA DE REPORTE").Value = ""
                fila.Cells("FOLIO").Value = ""
                fila.Cells("TERMINAL").Value = ""
                fila.Cells("REFERENCIA").Value = ""
                fila.Cells("CLIENTE").Value = worksheet.Cells(i, 9).Value.ToString()
                fila.Cells("CONTENEDORES").Value = worksheet.Cells(i, 11).Value.ToString()
                fila.Cells("TIPO").Value = ""
                fila.Cells("F. LLEGADA").Value = Me.buscarFechaLlegada(worksheet.Cells(i, 11).Value.ToString())
                'fila.Cells("DEMORA").Value = IIf(worksheet.Cells(i, 19).Value Is Nothing, "", worksheet.Cells(i, 19).Value)
                fila.Cells("DEMORA").Value = ""
                fila.Cells("STATUS").Value = ""
                fila.Cells("NAVIERA").Value = worksheet.Cells(i, 6).Value.ToString()
                fila.Cells("GRUPO").Value = "LLENO"
                fila.Cells("F. PASE").Value = ""
                fila.Cells("OBSERVACIONES").Value = ""

            End If

            i += 1
            cont += 1

        End While

        Me.establecerEstatus(Me.gridContVacios)
        Me.gridContVacios.Refresh()
        Cursor.Current = Cursors.Arrow
        MessageBox.Show("El archivo se cargó correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        r.Application.Quit()

        'Catch ex As Exception

        'Cursor.Current = Cursors.Arrow
        'MessageBox.Show("El archivo no se cargó debido al siguiente problema: " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'r.Application.Quit()

        'End Try
    End Sub

    Private Sub gridContVacios_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridContVacios.KeyDown

        If e.KeyCode = Keys.Tab Then
            If Not Me.gridContVacios.CurrentCell.ColumnIndex = 10 Then

                Me.gridContVacios.Rows(Me.gridContVacios.CurrentRow.Index).Cells(Me.gridContVacios.CurrentCell.ColumnIndex).Value = ""

            End If
        End If
    End Sub

    Private Sub gridContVacios_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridContVacios.RowEnter

        Me.gridContVacios.Rows(e.RowIndex).Cells("GRUPO").Value = "VACÍO"
        Me.gridContVacios.Rows(e.RowIndex).Cells("GRUPO").ReadOnly = True

    End Sub

    Private Sub gridContVacios_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles gridContVacios.CellFormatting

        If e.Value IsNot Nothing Then

            e.Value = e.Value.ToString().ToUpper()
            e.FormattingApplied = True

        End If
    End Sub

    Private Sub gridContVacios_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridContVacios.CellEndEdit

        If e.ColumnIndex = 8 Then

            Me.gridContLlenos.Refresh()
            Me.remarcarFilas(Me.gridContVacios)

        End If
    End Sub

    Private Sub establecerEstatus(ByRef ds As DataGridView)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim dA1 As SqlDataAdapter
        Dim dS1 As DataSet
        Dim sql, unidad As String
        Dim item1 As DataGridViewRow

        For index As Integer = 0 To ds.Rows.Count - 2

            item1 = ds.Rows(index)
            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            ' Se procede a consultar el número económico de la unidad a partir de la informacion del pedido generado en Lis Trafico.
            sql = "SELECT viaje.id_unidad, prog.No_Viaje, viaje.no_viaje, guia.no_viaje, prog.num_guia, guia.num_guia, prog.* FROM trafico_programa prog LEFT JOIN trafico_viaje viaje ON prog.No_viaje = viaje .no_viaje AND prog.Id_area = Viaje.id_area LEFT JOIN trafico_guia guia ON prog.No_viaje = guia.no_viaje AND prog.Num_Guia = guia.num_guia WHERE observaciones LIKE '%CONT.%" & item1.Cells(4).Value.ToString() & "' ORDER BY prog.FechaProg DESC"
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            dA1 = New SqlDataAdapter(comando)
            dS1 = New DataSet()
            dA1.Fill(dS1)

            If dS1.Tables(0).Rows.Count > 0 Then

                unidad = dS1.Tables(0).Rows(0)(0).ToString()

            Else

                unidad = "N/A" ' En caso de no encontrarse la unidad, se asigna la leyenda "N/A" (No Asignado)

            End If

            conexion.Close()
            conexion.Dispose()
            conexion = Connection.getInstance().getConnectionQFS()

            If Not unidad.Equals("N/A") Then

                conexion.Open()
                ' Se obtiene el estatus actual del contenedor (que es el mismo estatus de la unidad).
                comando = New SqlCommand("UP_CONSULTA_ESTATUS_UNIDAD", conexion)

                With comando.Parameters

                    .AddWithValue("@ID_UNIDAD", unidad)
                    .AddWithValue("@SALIDA", Date.Today.ToString("yyyy-dd-MM"))

                End With

                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 1000
                dA1 = New SqlDataAdapter(comando)
                dS1 = New DataSet()
                dA1.Fill(dS1)

                If ds.Rows.Count > 0 Then

                    item1.Cells("STATUS").Value = dS1.Tables(1).Rows.Item(0).Item(0).ToString()

                Else

                    conexion = Connection.getInstance().getConnectionQSP()
                    conexion.Open()
                    ' Se obtiene el estatus actual del contenedor (que es el mismo estatus de la unidad).
                    comando = New SqlCommand("UP_CONSULTA_ESTATUS_UNIDADQSP", conexion)

                    With comando.Parameters

                        .AddWithValue("@ID_UNIDAD", unidad)
                        .AddWithValue("@SALIDA", Date.Today.ToString("dd/MM/yyyy"))

                    End With

                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000
                    dA1 = New SqlDataAdapter(comando)
                    dS1 = New DataSet()
                    dA1.Fill(dS1)
                    item1.Cells("STATUS").Value = dS1.Tables(1).Rows.Item(0).Item(0).ToString()
                    'Item1.AcceptChanges()

                End If
            End If
        Next

        Dim item As DataGridViewRow

        If ds.Rows.Count > 0 Then
            For index As Integer = 0 To ds.Rows.Count - 2

                item = ds.Rows(index)
                conexion = Connection.getInstance().getConnection()
                conexion.Open()
                ' Se procede a consultar el número económico de la unidad a partir de la informacion del pedido generado en Lis Trafico.
                sql = "SELECT viaje.id_unidad, prog.No_Viaje, viaje.no_viaje, guia.no_viaje, prog.num_guia, guia.num_guia, prog.* FROM trafico_programa prog LEFT JOIN trafico_viaje viaje ON prog.No_viaje = viaje .no_viaje AND prog.Id_area = Viaje.id_area LEFT JOIN trafico_guia guia ON prog.No_viaje = guia.no_viaje AND prog.Num_Guia = guia.num_guia WHERE observaciones LIKE '%CONT.%" & item.Cells(4).Value.ToString() & "' ORDER BY prog.FechaProg DESC"
                comando = New SqlCommand(sql, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                dA1 = New SqlDataAdapter(comando)
                dS1 = New DataSet()
                dA1.Fill(dS1)

                If dS1.Tables(0).Rows.Count > 0 Then

                    unidad = dS1.Tables(0).Rows(0)(0).ToString()

                Else

                    unidad = "N/A" ' En caso de no encontrarse la unidad, se asigna la leyenda "N/A" (No Asignado)

                End If

                conexion.Close()
                conexion.Dispose()
                conexion = Connection.getInstance().getConnectionQFS()

                If Not unidad.Equals("N/A") Then

                    conexion.Open()
                    ' Se obtiene el estatus actual del contenedor (que es el mismo estatus de la unidad).
                    comando = New SqlCommand("UP_CONSULTA_ESTATUS_UNIDAD", conexion)

                    With comando.Parameters

                        .AddWithValue("@ID_UNIDAD", unidad)
                        .AddWithValue("@SALIDA", Date.Today.ToString("yyyy-dd-MM"))

                    End With

                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 1000
                    dA1 = New SqlDataAdapter(comando)
                    dS1 = New DataSet()
                    dA1.Fill(dS1)

                    If ds.Rows.Count > 0 Then

                        item.Cells("STATUS").Value = dS1.Tables(1).Rows.Item(0).Item(0).ToString()
                        'Item.AcceptChanges()

                    Else

                        conexion = Connection.getInstance().getConnectionQSP()
                        conexion.Open()
                        ' Se obtiene el estatus actual del contenedor (que es el mismo estatus de la unidad).
                        comando = New SqlCommand("UP_CONSULTA_ESTATUS_UNIDADQSP", conexion)

                        With comando.Parameters

                            .AddWithValue("@ID_UNIDAD", unidad)
                            .AddWithValue("@SALIDA", Date.Today.ToString("dd/MM/yyyy"))

                        End With

                        comando.CommandType = CommandType.StoredProcedure
                        comando.CommandTimeout = 1000
                        dA1 = New SqlDataAdapter(comando)
                        dS1 = New DataSet()
                        dA1.Fill(dS1)
                        item.Cells("STATUS").Value = dS1.Tables(1).Rows.Item(0).Item(0).ToString()
                        'Item.AcceptChanges()

                    End If
                End If
            Next
        End If
    End Sub

    Private Sub gridContLlenos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridContLlenos.CellEndEdit

        If e.ColumnIndex = 8 Then

            Me.gridContLlenos.Refresh()
            Me.remarcarFilas(Me.gridContLlenos)

        End If
    End Sub

    Private Sub btnRepSalidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepSalidas.Click

        Cursor.Current = Cursors.AppStarting
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook
        Dim APP As New Microsoft.Office.Interop.Excel.Application
        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sDA As SqlDataAdapter
        Dim ds As DataSet
        Dim oFD As New OpenFileDialog
        Dim cont As Integer = 1
        Dim i As Integer = 1
        Dim r As Microsoft.Office.Interop.Excel.Range
        Dim array(,) As Object
        Dim rangoEnY As Integer
        Dim fila As DataGridViewRow
        Dim archivo, fecha As String
        Dim ref As String
        Dim ar() As String
        Dim sql As String

        archivo = ""

        With oFD

            .Filter = "Ficheros Excel (*.xlsx)|*.xlsx|Todos (*.*)|*.*|(*.xls)|*.xls"
            .FileName = ""

            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                ' El nombre del fichero
                archivo = .FileName

            Else

                Return

            End If
        End With

        workbook = APP.Workbooks.Open(archivo)
        worksheet = workbook.Worksheets(Me.nombreHojaExcel(archivo))
        r = worksheet.UsedRange
        array = r.Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault)
        rangoEnY = array.GetUpperBound(0)

        While worksheet.Cells(i, 5).Value Is Nothing

            i += 1

        End While

        'While worksheet.Cells(i, 5).Value IsNot Nothing
        '    If worksheet.Cells(i, 5).Value.ToString().Equals("SALIDAS DEL DIA") Then

        '        fecha = worksheet.Cells(i, 6).Value.ToString()
        '        Exit While

        '    End If

        '    i += 1


        '    If i >= 1000 Then

        '        Exit Sub

        '    End If
        'End While

        fecha = worksheet.Range("F2").Value

        While worksheet.Cells(i, 2).Value Is Nothing

            i += 1

        End While

        i += 1

        Try
            While cont <= rangoEnY
                If worksheet.Cells(i, 5).Value IsNot Nothing AndAlso worksheet.Cells(i, 10).Value.ToString().Equals("IMPO") Then
                    If worksheet.Cells(i, 5).Value.ToString().Contains("REF.") Then

                        'ref = worksheet.Cells(i, 5).Value.ToString().Split(".")(1).Split(" ")(0)
                        ref = worksheet.Cells(i, 5).Value.ToString().Split(New String() {"REF."}, StringSplitOptions.None)(1).Split(" ")(0)

                    ElseIf worksheet.Cells(i, 5).Value.ToString().Contains("REF: ") Then

                        ref = worksheet.Cells(i, 5).Value.ToString().Split(": ")(1).Split(" ")(1)

                    ElseIf worksheet.Cells(i, 5).Value.ToString().Contains("REF:") Then

                        ref = worksheet.Cells(i, 5).Value.ToString().Split(":")(1).Split(" ")(0)

                    Else

                        ref = "SIN REFERENCIA"

                    End If

                    If Me.tieneEIR(worksheet.Cells(i, 9).Value.ToString().Split(" ")(0)) Then

                        i += 1
                        cont += 1
                        Continue While

                    End If

                    If Not worksheet.Cells(i, 9).Value.ToString().Split(" ")(0).TrimEnd().TrimStart().Length = 13 Then

                        i += 1
                        cont += 1
                        Continue While

                    End If

                    Me.gridContVacios.Rows.Add()
                    Me.gridContVacios.Refresh()
                    fila = Me.gridContVacios.Rows.Item(Me.gridContVacios.Rows.Count - 2)
                    sql = "IF (SELECT COUNT(*) FROM trafico_reporte_programacion WHERE CONTENEDOR = '" & worksheet.Cells(i, 9).Value.ToString().Split(" ")(0) & "' AND REFERENCIA = '" & ref & "') > 0 BEGIN SELECT ISNULL(TERMINAL, ''), ISNULL(TIPO, ''), ISNULL(DEMORA, ''), ISNULL(NAVIERA, '') FROM trafico_reporte_programacion WHERE CONTENEDOR = '" & worksheet.Cells(i, 9).Value.ToString().Split(" ")(0) & "' AND REFERENCIA = '" & ref & "' END ELSE BEGIN SELECT '', '', '', '' END"
                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand(sql, conexion)
                    comando.CommandType = CommandType.Text
                    comando.CommandTimeout = 1000
                    sDA = New SqlDataAdapter(comando)
                    ds = New DataSet()
                    sDA.Fill(ds)
                    conexion.Close()
                    conexion.Dispose()
                    comando.Dispose()

                    fila.Cells("FECHA DE REPORTE").Value = Convert.ToDateTime(fecha).ToString("dd/MM/yyyy")
                    fila.Cells("FOLIO").Value = ""
                    fila.Cells("TERMINAL").Value = ds.Tables(0).Rows(0)(0).ToString()
                    fila.Cells("REFERENCIA").Value = ref
                    fila.Cells("CLIENTE").Value = worksheet.Cells(i, 6).Value.ToString()
                    fila.Cells("CONTENEDORES").Value = worksheet.Cells(i, 9).Value.ToString().TrimEnd().TrimStart().Split(" ")(0)
                    fila.Cells("TIPO").Value = ""
                    fila.Cells("F. LLEGADA").Value = Me.buscarFechaLlegada(worksheet.Cells(i, 9).Value.ToString().Split(" ")(0))
                    fila.Cells("DEMORA").Value = ds.Tables(0).Rows(0)(2).ToString()
                    fila.Cells("STATUS").Value = ""
                    fila.Cells("NAVIERA").Value = ds.Tables(0).Rows(0)(3).ToString()
                    fila.Cells("GRUPO").Value = "VACÍO"
                    fila.Cells("F. PASE").Value = ""
                    fila.Cells("OBSERVACIONES").Value = ""

                End If

                If worksheet.Cells(i, 5).Value IsNot Nothing AndAlso worksheet.Cells(i, 10).Value.ToString().Equals("EXPO") Then
                    If worksheet.Cells(i, 5).Value.ToString().Contains("REF.") Then
                        For index As Integer = 0 To worksheet.Cells(i, 5).Value.ToString().Split(".").Length - 1
                            'If worksheet.Cells(i, 5).Value.ToString().Split(".")(index).Split(" ")(0).TrimEnd().TrimStart().Equals("REF") Then
                            If worksheet.Cells(i, 5).Value.ToString().Split(".")(index).TrimEnd().TrimStart().Contains("REF") Then

                                ref = worksheet.Cells(i, 5).Value.ToString().Split(".")(index + 1).Split(" ")(0)
                                Exit For

                            End If
                        Next
                    ElseIf worksheet.Cells(i, 5).Value.ToString().Contains("REF:") Then

                        ref = worksheet.Cells(i, 5).Value.ToString().Split(":")(1).Split(" ")(0)

                    Else

                        ref = "SIN REFERENCIA"

                    End If

                    If Me.tieneEIR(worksheet.Cells(i, 9).Value.ToString().Split(" ")(0)) Then

                        i += 1
                        cont += 1
                        Continue While

                    End If

                    Me.gridContLlenos.Rows.Add()
                    Me.gridContLlenos.Refresh()
                    fila = Me.gridContLlenos.Rows.Item(Me.gridContLlenos.Rows.Count - 2)
                    sql = "IF (SELECT COUNT(*) FROM trafico_reporte_programacion_expo WHERE contenedor LIKE '%" & worksheet.Cells(i, 9).Value.ToString().Split(" ")(0) & "%' AND referencia = '" & ref & "') > 0 BEGIN SELECT ISNULL(cierre, '') FROM trafico_reporte_programacion_expo WHERE contenedor LIKE '%" & worksheet.Cells(i, 9).Value.ToString().Split(" ")(0) & "%' AND referencia = '" & ref & "' END ELSE BEGIN SELECT '' END"
                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand(sql, conexion)
                    comando.CommandType = CommandType.Text
                    comando.CommandTimeout = 1000
                    sDA = New SqlDataAdapter(comando)
                    ds = New DataSet()
                    sDA.Fill(ds)
                    conexion.Close()
                    conexion.Dispose()
                    comando.Dispose()

                    fila.Cells("FECHA DE REPORTE").Value = Convert.ToDateTime(fecha).ToString("dd/MM/yyyy")
                    fila.Cells("FOLIO").Value = ""
                    fila.Cells("TERMINAL").Value = ""
                    fila.Cells("REFERENCIA").Value = ref
                    fila.Cells("CLIENTE").Value = worksheet.Cells(i, 6).Value.ToString()
                    fila.Cells("CONTENEDORES").Value = worksheet.Cells(i, 9).Value.ToString().TrimStart().TrimEnd().Split(" ")(0)
                    fila.Cells("TIPO").Value = ""
                    fila.Cells("F. LLEGADA").Value = Me.buscarFechaLlegada(worksheet.Cells(i, 9).Value.ToString().Split(" ")(0))
                    fila.Cells("DEMORA").Value = ds.Tables(0).Rows(0)(0).ToString()
                    fila.Cells("STATUS").Value = ""
                    fila.Cells("NAVIERA").Value = ""
                    fila.Cells("GRUPO").Value = "LLENO"
                    fila.Cells("F. PASE").Value = ""
                    fila.Cells("OBSERVACIONES").Value = ""

                End If

                i += 1
                cont += 1
                ref = ""

            End While

            Me.establecerEstatus(Me.gridContVacios)
            Cursor.Current = Cursors.Arrow
            MessageBox.Show("El archivo se cargó correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            r.Application.Quit()
            GC.Collect()

        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("El archivo no se cargó debido al siguiente problema: " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            r.Application.Quit()

        End Try
    End Sub

    Public Function buscarFechaLlegada(ByVal contenedor As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql, fecha As String

        fecha = ""

        Try

            sql = "SELECT CONVERT(VARCHAR(15), Fecha, 103) AS fecha, lugar FROM trafico_registros WHERE (REPLACE(REPLACE('" & contenedor.TrimStart().TrimEnd() & "', ' ', ''), '-', '') = REPLACE(REPLACE(Contenedor1, ' ', ''), '-', '') OR REPLACE(REPLACE('" & contenedor.TrimStart().TrimEnd() & "', ' ', ''), '-', '') = REPLACE(REPLACE(Contenedor2, ' ', ''), '-', '')) AND Tipo = 'E' AND lugar  = 'DA' ORDER BY FECHA DESC"
            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    If dS.Tables(0).Rows(0)("lugar").ToString().Equals("DA") Then

                        fecha = dS.Tables(0).Rows(0)("fecha").ToString()

                        If DateTime.Compare(Convert.ToDateTime(fecha), DateTime.Today.AddDays(-1)) < 0 Then

                            fecha = ""

                        End If
                    End If
                End If
            End If

            comando.Dispose()
            conexion.Close()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error: " + ex.Message)

        End Try

        Return fecha

    End Function

    Public Function buscarFechaSalida(ByVal contenedor As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sql, fecha As String

        fecha = ""

        Try

            sql = "SELECT TOP(1) ISNULL(CONVERT(VARCHAR(15), Fecha, 103), '') FROM trafico_registros WHERE (REPLACE(REPLACE('" & contenedor & "', ' ', ''), '-', '') = REPLACE(REPLACE(Contenedor1, ' ', ''), '-', '') OR REPLACE(REPLACE('" & contenedor & "', ' ', ''), '-', '') = REPLACE(REPLACE(Contenedor2, ' ', ''), '-', '')) AND Tipo = 'S' ORDER BY Fecha DESC"
            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            fecha = comando.ExecuteScalar()
            comando.Dispose()
            conexion.Close()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error: " + ex.Message)

        End Try

        Return fecha

    End Function

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click

        Me.eliminarFilasGrid(Me.gridContVacios)

    End Sub

    Private Sub eliminarFilasGrid(ByVal grid As DataGridView)

        For Each Item As DataGridViewRow In grid.SelectedRows

            'grid.Rows.Remove(Item)
            Me.filasEliminadas.Add(Item)
            Item.Visible = False

        Next

        grid.Refresh()

    End Sub

    Private Sub EliminarContenedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarContenedoresToolStripMenuItem.Click

        Me.eliminarFilasGrid(Me.gridContLlenos)

    End Sub

    Private Sub DeshacerEliminaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerEliminaciónToolStripMenuItem.Click

        If Me.filasEliminadas.Count > 0 Then

            Dim contenedor As DataGridViewRow
            Dim i As Int32 = Me.filasEliminadas.Count - 1

            While i >= 0

                contenedor = Me.filasEliminadas.Item(i)

                If contenedor.Cells("GRUPO").Value.ToString().Equals("VACÍO") Then
                    For Each Item As DataGridViewRow In Me.gridContVacios.Rows
                        If contenedor.Cells("REFERENCIA").Value.ToString().Equals(Item.Cells("REFERENCIA").Value.ToString()) AndAlso contenedor.Cells("CONTENEDORES").Value.ToString().Equals(Item.Cells("CONTENEDORES").Value.ToString()) Then

                            Item.Visible = True
                            Me.gridContVacios.Refresh()
                            Me.filasEliminadas.RemoveAt(i)
                            Exit Sub

                        End If
                    Next
                End If

                i -= 1

            End While
        End If
    End Sub

    Private Sub btnArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArribaGridVac.Click

        Me.MoveRowsUp(Me.gridContVacios)

    End Sub

    Private Sub btnAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbajoGridVac.Click

        Me.MoveRowsDn(Me.gridContVacios)

    End Sub

    Private Sub MoveRowsUp(ByRef grid As DataGridView)

        ' short ref
        Dim rows As DataGridViewRowCollection = grid.Rows
        ' row index
        Dim thisRow As DataGridViewRow
        ' put selection back
        Dim selectedRows As List(Of Integer)
        ' max rows
        Dim LastRow As Int32 = IIf(grid.AllowUserToAddRows, rows.Count - 2, rows.Count - 1)
        selectedRows = GetSelectedRows(grid)

        For n As Int32 = 0 To LastRow
            If rows(n).IsNewRow = False Then

                If (selectedRows.Contains(rows(n).GetHashCode)) AndAlso (n - 1 >= 0) AndAlso (selectedRows.Contains(rows(n - 1).GetHashCode) = False) Then

                    thisRow = rows(n)
                    rows.Remove(thisRow)
                    rows.Insert(n - 1, thisRow)

                End If
            End If
        Next

        SetSelectedRows(selectedRows, grid)

    End Sub

    Private Sub MoveRowsDn(ByRef grid As DataGridView)

        Dim rows As DataGridViewRowCollection = grid.Rows
        Dim thisRow As DataGridViewRow
        Dim selectedRows As New List(Of Integer)
        Dim LastRow As Int32 = IIf(grid.AllowUserToAddRows, rows.Count - 2, rows.Count - 1)

        selectedRows = GetSelectedRows(grid)

        For n As Int32 = LastRow To 0 Step -1

            If rows(n).IsNewRow = False Then
                If (selectedRows.Contains(rows(n).GetHashCode)) AndAlso (n + 1 <= LastRow) AndAlso (selectedRows.Contains(rows(n + 1).GetHashCode) = False) Then

                    thisRow = rows(n)
                    rows.Remove(thisRow)
                    rows.Insert(n + 1, thisRow)

                End If
            End If
        Next

        SetSelectedRows(selectedRows, grid)

    End Sub

    Private Function GetSelectedRows(ByRef grid As DataGridView) As List(Of Integer)

        Dim selR As New List(Of Integer)
        ' have to clear selected so the NEXT row 
        ' doesnt cause odd behavior
        For n As Integer = 0 To grid.Rows.Count - 1
            If grid.Rows(n).IsNewRow = False AndAlso grid.Rows(n).Selected Then

                selR.Add(grid.Rows(n).GetHashCode)
                grid.Rows(n).Selected = False

            End If
        Next

        Return selR

    End Function

    Private Sub SetSelectedRows(ByVal selRows As List(Of Integer), ByRef grid As DataGridView)

        For n As Integer = 0 To grid.Rows.Count - 1
            If grid.Rows(n).IsNewRow = False Then

                grid.Rows(n).Selected = selRows.Contains(grid.Rows(n).GetHashCode)
                ' reset Order col:
                'grid.Rows(n).Cells(0).Value = n + 1

            End If
        Next
    End Sub

    Private Sub btnArribaGridLle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArribaGridLle.Click

        Me.MoveRowsUp(Me.gridContLlenos)

    End Sub

    Private Sub btnAbajoGridLle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbajoGridLle.Click

        Me.MoveRowsDn(Me.gridContLlenos)

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        Dim contenedor As DataGridViewRow

        If Me.txtBusqueda.Text.Equals("") Then
            For index As Integer = 0 To Me.gridContVacios.Rows.Count - 2

                Me.gridContVacios.Rows(index).Visible = True

            Next

            For index As Integer = 0 To Me.gridContLlenos.Rows.Count - 2

                Me.gridContLlenos.Rows(index).Visible = True

            Next
            Exit Sub
        End If

        For index As Integer = 0 To Me.gridContVacios.Rows.Count - 2

            contenedor = Me.gridContVacios.Rows(index)

            If contenedor.Cells("CONTENEDORES").Value.ToString().Equals(Me.txtBusqueda.Text) Then

                Me.filtrarContenedores(contenedor.Cells("CONTENEDORES").Value.ToString())
                Exit Sub

            ElseIf contenedor.Cells("REFERENCIA").Value.ToString().Equals(Me.txtBusqueda.Text) Then

                Me.filtrarContenedores(contenedor.Cells("CONTENEDORES").Value.ToString())
                Exit Sub

            End If
        Next

        For index As Integer = 0 To Me.gridContLlenos.Rows.Count - 2

            contenedor = Me.gridContLlenos.Rows(index)

            If contenedor.Cells("CONTENEDORES").Value.ToString().Equals(Me.txtBusqueda.Text) Then

                Me.filtrarContenedores(contenedor.Cells("CONTENEDORES").Value.ToString())
                Exit Sub

            ElseIf contenedor.Cells("REFERENCIA").Value.ToString().Equals(Me.txtBusqueda.Text) Then

                Me.filtrarContenedores(contenedor.Cells("CONTENEDORES").Value.ToString())
                Exit Sub

            End If
        Next
    End Sub

    Private Sub filtrarContenedores(ByVal cont As String)

        Dim contenedor As DataGridViewRow

        For index As Integer = 0 To Me.gridContVacios.Rows.Count - 2

            contenedor = Me.gridContVacios.Rows(index)

            If contenedor.Cells("CONTENEDORES").Value.ToString().Equals(cont) Then

                Continue For

            End If

            contenedor.Visible = False

        Next

        For index As Integer = 0 To Me.gridContLlenos.Rows.Count - 2

            contenedor = Me.gridContLlenos.Rows(index)

            If contenedor.Cells("CONTENEDORES").Value.ToString().Equals(cont) Then

                Continue For

            End If

            contenedor.Visible = False

        Next
    End Sub

    Private Sub CambiarAContSalienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarAContSalienteToolStripMenuItem.Click

        Dim contSaliente As DataGridViewRow

        For Each contenedor As DataGridViewRow In Me.gridContVacios.SelectedRows

            Me.gridSalientesVacios.Rows.Add()
            contSaliente = Me.gridSalientesVacios.Rows(Me.gridSalientesVacios.Rows.Count - 1)

            For i As Integer = 0 To Me.gridContVacios.Columns.Count - 1

                contSaliente.Cells(i).Value = contenedor.Cells(i).Value

            Next

            Me.gridContVacios.Rows.Remove(contenedor)

        Next
    End Sub

    Private Sub MoverAContVacíosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAContVacíosToolStripMenuItem.Click

        Dim contVacio As DataGridViewRow

        For Each contenedor As DataGridViewRow In Me.gridSalientesVacios.SelectedRows

            Me.gridContVacios.Rows.Add()
            contVacio = Me.gridContVacios.Rows(Me.gridContVacios.Rows.Count - 2)

            For i As Integer = 0 To Me.gridContVacios.Columns.Count - 1

                contVacio.Cells(i).Value = contenedor.Cells(i).Value

            Next

            Me.gridSalientesVacios.Rows.Remove(contenedor)

        Next
    End Sub

    Private Sub DeshacerEliminaciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerEliminaciónToolStripMenuItem1.Click

        If Me.filasEliminadas.Count > 0 Then

            Dim contenedor As DataGridViewRow
            Dim i As Int32 = Me.filasEliminadas.Count - 1

            While i >= 0

                contenedor = Me.filasEliminadas.Item(i)

                If contenedor.Cells("GRUPO").Value.ToString().Equals("LLENO") Then
                    For Each Item As DataGridViewRow In Me.gridContLlenos.Rows
                        If contenedor.Cells("REFERENCIA").Value.ToString().Equals(Item.Cells("REFERENCIA").Value.ToString()) AndAlso contenedor.Cells("CONTENEDORES").Value.ToString().Equals(Item.Cells("CONTENEDORES").Value.ToString()) Then

                            Item.Visible = True
                            Me.gridContVacios.Refresh()
                            Me.filasEliminadas.RemoveAt(i)
                            Exit Sub

                        End If
                    Next
                End If

                i -= 1

            End While
        End If
    End Sub

    Private Sub MoverAContQueSalenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAContQueSalenToolStripMenuItem.Click

        Dim contSaliente As DataGridViewRow

        For Each contenedor As DataGridViewRow In Me.gridContLlenos.SelectedRows

            Me.gridSalientesLlenos.Rows.Add()
            contSaliente = Me.gridSalientesLlenos.Rows(Me.gridSalientesLlenos.Rows.Count - 1)

            For i As Integer = 0 To Me.gridContLlenos.Columns.Count - 1

                contSaliente.Cells(i).Value = contenedor.Cells(i).Value

            Next

            Me.gridContLlenos.Rows.Remove(contenedor)

        Next
    End Sub

    Private Sub MoverAContLlenosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAContLlenosToolStripMenuItem.Click

        Dim contLleno As DataGridViewRow

        For Each contenedor As DataGridViewRow In Me.gridSalientesLlenos.SelectedRows

            Me.gridContLlenos.Rows.Add()
            contLleno = Me.gridContLlenos.Rows(Me.gridContLlenos.Rows.Count - 2)

            For i As Integer = 0 To Me.gridContLlenos.Columns.Count - 1

                contLleno.Cells(i).Value = contenedor.Cells(i).Value

            Next

            Me.gridSalientesLlenos.Rows.Remove(contenedor)

        Next
    End Sub

    Public Function tieneEIR(ByVal contenedor As String) As Boolean

        Dim con As SqlConnection
        Dim com As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim query As String
        Dim tiene As Boolean

        tiene = False

        Try

            query = "SELECT contenedor FROM trafico_local_EIR WHERE fecha_eir >= DATEADD(DAY, -4, GETDATE()) AND (servicio = 'IMPO VACÍO' OR servicio = 'EXPO LLENO')"
            con = Connection.getInstance().getConnection()
            con.Open()
            com = New SqlCommand(query, con)
            com.CommandType = CommandType.Text
            com.CommandTimeout = 600
            sDA = New SqlDataAdapter(com)
            dS = New DataSet()
            sDA.Fill(dS)
            con.Close()
            con.Dispose()
            com.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each Item As DataRow In dS.Tables(0).Rows
                        If Item.Item(0).ToString().Replace("-", "").Equals(contenedor.Replace("-", "")) Then

                            tiene = True
                            Exit For

                        End If
                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error mientras se cargaban los contenedores: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return tiene

    End Function

    Private Sub MoverAContLlenosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAContLlenosToolStripMenuItem1.Click

        Dim contLleno As DataGridViewRow

        For Each contenedor As DataGridViewRow In Me.gridContVacios.SelectedRows

            Me.gridContLlenos.Rows.Add()
            contLleno = Me.gridContLlenos.Rows(Me.gridContLlenos.Rows.Count - 2)

            For i As Integer = 0 To Me.gridContLlenos.Columns.Count - 1

                contLleno.Cells(i).Value = contenedor.Cells(i).Value

            Next

            Me.gridContVacios.Rows.Remove(contenedor)

        Next
    End Sub

    Private Sub MoverAContVacíosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverAContVacíosToolStripMenuItem1.Click

        Dim contVacio As DataGridViewRow

        For Each contenedor As DataGridViewRow In Me.gridContLlenos.SelectedRows

            Me.gridContVacios.Rows.Add()
            contVacio = Me.gridContVacios.Rows(Me.gridContVacios.Rows.Count - 2)

            For i As Integer = 0 To Me.gridContVacios.Columns.Count - 1

                contVacio.Cells(i).Value = contenedor.Cells(i).Value

            Next

            Me.gridContLlenos.Rows.Remove(contenedor)

        Next
    End Sub

    Private Sub ordenarFilas(ByRef grid As DataGridView)

        Dim dT, source As DataTable
        Dim fila As DataGridViewRow
        Dim indice As Integer

        If grid.Rows.Count > 0 Then

            dT = New DataTable()
            source = New DataTable()

            For Each columna As DataGridViewColumn In grid.Columns

                source.Columns.Add(columna.Name)

            Next

            For fil As Integer = 0 To grid.Rows.Count - 2
                If grid.Rows.Item(fil).Visible = True Then

                    fila = grid.Rows.Item(fil)
                    source.Rows.Add()

                    For columna As Integer = 0 To grid.Columns.Count - 1

                        source.Rows(source.Rows.Count - 1)(columna) = fila.Cells(columna).Value

                    Next
                End If
            Next

            For Each columna As DataColumn In source.Columns

                dT.Columns.Add(columna.ColumnName)

            Next

            indice = 0

            Do While indice < source.Rows.Count
                If indice < source.Rows.Count Then
                    If source.Rows(indice)("STATUS") IsNot Nothing Then
                        If source.Rows(indice)("STATUS").ToString().ToUpper().Equals("DAH") Or source.Rows(indice)("STATUS").ToString().ToUpper().Equals("PATIO 2") Then

                            dT.Rows.Add()

                            For columna As Integer = 0 To source.Columns.Count - 1

                                dT.Rows(dT.Rows.Count - 1)(columna) = source.Rows(indice)(columna).ToString()

                            Next

                            source.Rows(indice).Delete()
                            source.AcceptChanges()
                            indice = 0

                        Else

                            indice += 1

                        End If
                    Else

                        indice += 1

                    End If
                Else

                    indice += 1

                End If
            Loop

            source.AcceptChanges()
            indice = 0

            Do While indice < source.Rows.Count
                If indice < source.Rows.Count Then
                    If source.Rows(indice)("FOLIO") IsNot Nothing Then
                        If Not String.IsNullOrEmpty(source.Rows(indice)("FOLIO").ToString()) Then

                            dT.Rows.Add()

                            For columna As Integer = 0 To source.Columns.Count - 1

                                dT.Rows(dT.Rows.Count - 1)(columna) = source.Rows(indice)(columna).ToString()

                            Next

                            source.Rows(indice).Delete()
                            source.AcceptChanges()
                            indice = 0

                        Else

                            indice += 1

                        End If
                    Else

                        indice += 1

                    End If
                Else

                    indice += 1

                End If
            Loop

            source.AcceptChanges()

            For index As Integer = 0 To source.Rows.Count - 1

                dT.Rows.Add()

                For columna As Integer = 0 To source.Columns.Count - 1

                    dT.Rows(dT.Rows.Count - 1)(columna) = source.Rows(index)(columna).ToString()

                Next

                source.Rows(index).Delete()

            Next

            source.AcceptChanges()

        End If

        grid.Rows.Clear()
        grid.Update()

        For filas As Integer = 0 To dT.Rows.Count - 1

            grid.Rows.Add()

            For columnas As Integer = 0 To dT.Columns.Count - 1

                grid.Rows(grid.Rows.Count - 2).Cells(columnas).Value = dT.Rows(filas)(columnas).ToString()

            Next
        Next
    End Sub

    Private Sub btnOrdenarGridVacios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenarGridVacios.Click

        Me.ordenarFilas(Me.gridContVacios)
        Me.generarRecuento()
        Me.remarcarFilas(Me.gridContVacios)
        Me.remarcarFilas(Me.gridContLlenos)

    End Sub

    Private Sub btnOrdenarGridLlenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenarGridLlenos.Click

        Me.ordenarFilas(Me.gridContLlenos)
        Me.generarRecuento()
        Me.remarcarFilas(Me.gridContVacios)
        Me.remarcarFilas(Me.gridContLlenos)

    End Sub

    Private Function nombreHojaExcel(ByVal fileName As String) As String

        Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
        Dim conn As New OleDbConnection(strconn)
        Dim listSheet As New List(Of String)
        Dim drSheet As DataRow

        conn.Open()
        Dim dtSheets As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

        For Each drSheet In dtSheets.Rows

            listSheet.Add(drSheet("TABLE_NAME").ToString())

        Next

        conn.Close()
        Return listSheet.Item(0).Replace("$", "").Replace("'", "")

    End Function

    Private Sub generarRecuento()

        Dim contVacDAH As Integer = 0
        Dim contVacDem As Integer = 0
        Dim contVacSinDem As Integer = 0
        Dim contVacTot As Integer = 0
        Dim contLlenDAH As Integer = 0
        Dim contLlenCierre As Integer = 0

        For index As Integer = 0 To Me.gridContVacios.Rows.Count - 1
            If Not String.IsNullOrEmpty(Me.gridContVacios.Rows(index).Cells(7).Value) Then
                If IsDate(Me.gridContVacios.Rows(index).Cells(7).Value) Then

                    contVacDAH += 1

                    If DateTime.Compare(Convert.ToDateTime(Me.gridContVacios.Rows(index).Cells(8).Value.ToString()), DateTime.Today) = 0 Or DateTime.Compare(Convert.ToDateTime(Me.gridContVacios.Rows(index).Cells(8).Value.ToString()), DateTime.Today) < 0 Then

                        contVacDem += 1

                    End If
                End If
            End If
        Next

        For index As Integer = 0 To Me.gridContLlenos.Rows.Count - 1
            If Not String.IsNullOrEmpty(Me.gridContLlenos.Rows(index).Cells(7).Value) Then
                If IsDate(Me.gridContLlenos.Rows(index).Cells("F. LLEGADA").Value) Then

                    contLlenDAH += 1

                    If DateTime.Compare(Convert.ToDateTime(Me.gridContLlenos.Rows(index).Cells("F. LLEGADA").Value.ToString()), DateTime.Today) < 0 Then

                        contLlenCierre += 1

                    End If
                End If
            End If
        Next

        Me.etqContVaciosDAH.Text = contVacDAH & ""
        Me.etqContVacDemorados.Text = contVacDem & ""
        contVacTot = Me.gridContVacios.Rows.Count - 1
        Me.etqContVacTot.Text = contVacTot & ""
        Me.etqConVacSinDemora.Text = (contVacTot - contVacDem) & ""
        Me.etqConLlenosDAH.Text = contLlenDAH & ""
        Me.etqConLlenosFecCierre.Text = contLlenCierre & ""

    End Sub

    Private Sub actualizarGrid(ByRef grid As DataGridView)

        Dim contenedor As DataGridViewRow

        If grid.Rows.Count > 0 Then
            For i As Integer = 0 To grid.Rows.Count - 2

                contenedor = grid.Rows(i)

                If Me.tieneEIR(contenedor.Cells("CONTENEDORES").Value.ToString()) Then

                    contenedor.Visible = False

                Else

                    contenedor.Cells("F. LLEGADA").Value = Me.buscarFechaLlegada(contenedor.Cells("CONTENEDORES").Value.ToString())

                End If

                grid.Update()

            Next
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Cursor.Current = Cursors.WaitCursor

        Try

            Me.actualizarGrid(Me.gridContVacios)
            Me.actualizarGrid(Me.gridContLlenos)
            Me.actualizarGrid(Me.gridSalientesVacios)
            Me.actualizarGrid(Me.gridSalientesLlenos)
            MessageBox.Show("¡Reporte actualizado!", "¡Actualización completa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            MessageBox.Show("Error al actualizar el reporte: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub EliminarSalVacToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarSalVacToolStripMenuItem.Click

        Try
            For Each carga As DataGridViewRow In Me.gridSalientesVacios.SelectedRows

                Me.gridSalientesVacios.Rows.Remove(carga)

            Next
        Catch ex As Exception

            MessageBox.Show("Error al eliminar los contenedores: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub EliminarSalLlenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarSalLlenToolStripMenuItem.Click

        Try
            For Each carga As DataGridViewRow In Me.gridSalientesLlenos.SelectedRows

                Me.gridSalientesLlenos.Rows.Remove(carga)

            Next
        Catch ex As Exception

            MessageBox.Show("Error al eliminar los contenedores: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class