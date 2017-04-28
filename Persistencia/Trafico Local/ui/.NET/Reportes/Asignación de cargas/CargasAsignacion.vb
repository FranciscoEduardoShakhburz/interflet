Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class CargasAsignacion

    Private dTInventario As DataTable
    Private dTResumenCargas As DataTable

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dTInventario = New DataTable()
        Me.dTResumenCargas = New DataTable()

    End Sub

    Private Sub CargasAsignacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CargasAsignacion_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        Me.gBOperadores.Width = (Me.tPInfo.Width / 2) - 10
        Me.gBCargas.Location = New Point((Me.tPInfo.Width / 2) + 5, Me.gBCargas.Location.Y)
        Me.gBCargas.Width = (Me.tPInfo.Width / 2) - 10
        Me.dGVOperadores.Width = Me.gBOperadores.Width - 12
        Me.dGVCargas.Width = Me.gBCargas.Width - 12
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.gBColaCargas.Width = (Me.tPCola.Width / 2) - 10
        Me.gBColaOperadores.Width = (Me.tPCola.Width / 2) - 10
        Me.gBColaCargas.Location = New Point((Me.tPCola.Width / 2) + 5, Me.gBColaCargas.Location.Y)
        Me.gBColaCargas.Width = (Me.tPCola.Width / 2) - 10
        Me.dGVColaOperadores.Width = Me.gBColaOperadores.Width - 12
        Me.dGVColaCargas.Width = Me.gBColaCargas.Width - 12

    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.cargarInformacion()
        Me.pintarFilas()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click

        Me.crearAsignacion()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub dGVOperadores_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVOperadores.CellDoubleClick

        Dim editar As EditarOperador
        editar = New EditarOperador(Me.dGVOperadores.SelectedRows(0))
        editar.ShowDialog(Me)

    End Sub

    Private Sub dGVCargas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVCargas.CellDoubleClick

        Dim editar As EditarCarga
        editar = New EditarCarga(Me.dGVCargas.SelectedRows(0))
        editar.ShowDialog(Me)

    End Sub

    Private Sub tSMICambiarOperador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSMICambiarOperador.Click

        Dim cambio As CambioOperadorUnidad
        cambio = New CambioOperadorUnidad(Me.dGVAsignacion.SelectedRows(0).Cells("colNoOperador").Value.ToString(), Me.dGVAsignacion.SelectedRows(0).Cells("colOperadorAs").Value.ToString(), Me.dGVAsignacion.SelectedRows(0).Cells("colNumCarga").Value.ToString(), Me.dGVAsignacion.SelectedRows(0).Cells("colContenedor").Value.ToString())
        If cambio.ShowDialog(Me) = DialogResult.OK Then

            Me.cambiarOperador()

        End If
    End Sub

    Private Sub bExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExcel.Click

        Me.gridToExcel(Me.dGVAsignacion)

    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.guardarAsignacion()
        Me.guardarColas()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub bCargarInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCargarInfo.Click

        Me.dGVAsignacion.Rows.Clear()
        Me.dGVColaOperadores.Rows.Clear()
        Me.dGVColaCargas.Rows.Clear()
        Me.cargarAsignacionGuardada()
        Me.cargarColasEspera()
        MessageBox.Show("La información se cargó correctamente.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CambiarCargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarCargaToolStripMenuItem.Click

        If MessageBox.Show("¿Desea mover la carga seleccionada a la cola de espera?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.Yes Then

            Me.cambiarCarga()

        End If
    End Sub

    Private Sub bRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRefrescar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.refrescarStatusInventario()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub CambiarSóloOperadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarSóloOperadorToolStripMenuItem.Click

        Dim cambio As CambioOperador
        cambio = New CambioOperador(Me.dGVAsignacion.SelectedRows(0))
        cambio.ShowDialog(Me)

    End Sub

    Private Sub EmpatarCargasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpatarCargasToolStripMenuItem.Click

        Dim sel As SeleccionarPrioridadCargas = New SeleccionarPrioridadCargas(Me.dGVCargas.SelectedRows(0), Me.dGVCargas.SelectedRows(1))
        sel.ShowDialog(Me)
        Me.empatarCargas()

    End Sub

    Private Sub DesempatarCargasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesempatarCargasToolStripMenuItem.Click

        Me.desempatarCargas()

    End Sub

    Private Sub cargarInformacion()

        Dim operador As DataGridViewRow
        Dim carga As DataGridViewRow
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("up_asignacion_cargas", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            conexion.Open()
            sDA.Fill(dS)
            Me.dGVCargas.Rows.Clear()
            Me.dGVOperadores.Rows.Clear()

            If dS.Tables(0).Rows.Count = 0 Then

                MessageBox.Show("No se ha cargado el inventario de unidades en el sistema.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            ElseIf dS.Tables(1).Rows.Count = 0 Then

                MessageBox.Show("No se ha cargado el resúmen de cargas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            End If

            If dS.Tables.Count > 0 Then

                Me.dTInventario = dS.Tables(0)

                If Me.dTInventario.Rows.Count > 0 Then
                    For Each unidad As DataRow In Me.dTInventario.Rows

                        operador = Me.dGVOperadores.Rows(Me.dGVOperadores.Rows.Add())
                        operador.Cells("colFechaLleg").Value = unidad("FECHA LLEGADA").ToString()
                        operador.Cells("colUnidad").Value = unidad("ECO").ToString()
                        operador.Cells("colTelefono").Value = unidad("CEL").ToString()
                        operador.Cells("colNumOperador").Value = unidad("numOperador").ToString()
                        operador.Cells("colOperador").Value = unidad("OPERADOR").ToString()
                        operador.Cells("colStat").Value = unidad("status").ToString()
                        operador.Cells("colUbicacion").Value = unidad("ubicacion").ToString()
                        operador.Cells("colFechaVencLic").Value = unidad("fechaVencLic").ToString()
                        operador.Cells("colFechaVencSeg").Value = unidad("fechaVencSeguro").ToString()
                        operador.Cells("colManejaMatPeligroso").Value = unidad("Apto para carga peligrosa").ToString()
                        operador.Cells("colAutorizado").Value = Me.tieneAutorizacion(unidad("OPERADOR").ToString())
                        operador.Cells("colHoraLlegadaDA").Value = Me.consultarHoraLlegadaOperador(unidad("OPERADOR").ToString())

                    Next
                End If
            End If

            If dS.Tables.Count > 1 Then

                Me.dTResumenCargas = dS.Tables(1)

                If Me.dTResumenCargas.Rows.Count > 0 Then
                    For Each cargas As DataRow In Me.dTResumenCargas.Rows

                        carga = Me.dGVCargas.Rows(Me.dGVCargas.Rows.Add())
                        carga.Cells("colNumero").Value = cargas("numero").ToString()
                        carga.Cells("colContenedores").Value = cargas("contenedor").ToString()
                        carga.Cells("colReferencia").Value = cargas("referencia").ToString()
                        carga.Cells("colClienteCont").Value = cargas("cliente").ToString()
                        carga.Cells("colEntregarEn").Value = cargas("entrega2").ToString()
                        carga.Cells("colConfiguracion").Value = cargas("tipo1").ToString()
                        carga.Cells("colDestinoCont").Value = cargas("destino").ToString()
                        carga.Cells("colTerminal").Value = cargas("terminal").ToString()
                        carga.Cells("colStatusCont").Value = cargas("status").ToString()
                        carga.Cells("colDemoras").Value = cargas("demoras").ToString()
                        carga.Cells("colNaviera").Value = cargas("naviera").ToString()
                        carga.Cells("colOperacion").Value = cargas("operacion").ToString()
                        carga.Cells("colEsPeligrosa").Value = cargas("esPeligrosa")
                        Dim x As Date

                        If Not String.IsNullOrEmpty(cargas("planta").ToString()) And DateTime.TryParse(cargas("planta").ToString(), x) Then

                            carga.Cells("colFechaPlanta").Value = Convert.ToDateTime(cargas("planta").ToString()).ToString("dd/MM/yyyy")

                        Else

                            carga.Cells("colFechaPlanta").Value = cargas("planta").ToString()

                        End If
                    Next
                End If
            End If

            MessageBox.Show("La información ha sido cargada con éxito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error al cargar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub crearAsignacion()

        Me.dGVColaOperadores.Rows.Clear()
        Dim embarque As DataGridViewRow
        Dim operador As DataGridViewRow
        Me.dGVColaCargas.Rows.Clear()
        Dim carga As DataGridViewRow
        Me.dGVAsignacion.Rows.Clear()
        Dim unidadIndex As Integer
        Dim cargaIndex As Integer
        Dim indice As Int32

        Try

            cargaIndex = 0
            unidadIndex = 0

            If Me.dGVOperadores.Rows.Count > Me.dGVCargas.Rows.Count Then
                For index As Integer = 0 To Me.dGVOperadores.Rows.Count - 1
                    For index1 As Integer = cargaIndex To Me.dGVCargas.Rows.Count - 1

                        cargaIndex = index1

                        If Me.dGVCargas.Rows(index1).Visible = True Then

                            Exit For

                        Else

                            cargaIndex += 1

                        End If
                    Next

                    If cargaIndex < Me.dGVCargas.Rows.Count - 1 Then
                        If Me.dGVOperadores.Rows(index).DefaultCellStyle.BackColor = Color.HotPink Or Me.dGVOperadores.Rows(index).DefaultCellStyle.BackColor = Color.OrangeRed Then

                            Continue For

                        End If

                        embarque = Me.dGVAsignacion.Rows(Me.dGVAsignacion.Rows.Add())
                        embarque.Cells("colFechaLlegada").Value = Me.dGVOperadores.Rows(index).Cells("colFechaLleg").Value.ToString()
                        embarque.Cells("colEco").Value = Me.dGVOperadores.Rows(index).Cells("colUnidad").Value.ToString()
                        embarque.Cells("colCel").Value = Me.dGVOperadores.Rows(index).Cells("colTelefono").Value.ToString()
                        embarque.Cells("colNoOperador").Value = Me.dGVOperadores.Rows(index).Cells("colNumOperador").Value.ToString()
                        embarque.Cells("colOperadorAs").Value = Me.dGVOperadores.Rows(index).Cells("colOperador").Value.ToString()
                        embarque.Cells("colNumCarga").Value = Me.dGVCargas.Rows(cargaIndex).Cells("colNumero").Value.ToString()
                        embarque.Cells("colContenedor").Value = Me.dGVCargas.Rows(cargaIndex).Cells("colContenedores").Value.ToString()
                        embarque.Cells("colCliente").Value = Me.dGVCargas.Rows(cargaIndex).Cells("colClienteCont").Value.ToString()
                        embarque.Cells("colDestino").Value = Me.dGVCargas.Rows(cargaIndex).Cells("colDestinoCont").Value.ToString()
                        embarque.Cells("colStatus").Value = Me.dGVCargas.Rows(cargaIndex).Cells("colStatusCont").Value.ToString()
                        embarque.Cells("colHorario").Value = ""
                        embarque.Cells("colETA").Value = ""
                        embarque.Cells("colFechaPlantaAs").Value = Me.dGVCargas.Rows(cargaIndex).Cells("colFechaPlanta").Value.ToString()

                    Else

                        operador = Me.dGVColaOperadores.Rows(Me.dGVColaOperadores.Rows.Add())
                        operador.Cells("colFechaLlegCola").Value = Me.dGVOperadores.Rows(index).Cells("colFechaLleg").Value.ToString()
                        operador.Cells("colUnidadCola").Value = Me.dGVOperadores.Rows(index).Cells("colUnidad").Value.ToString()
                        operador.Cells("colTelefonoCola").Value = Me.dGVOperadores.Rows(index).Cells("colTelefono").Value.ToString()
                        operador.Cells("colNumOperadorCola").Value = Me.dGVOperadores.Rows(index).Cells("colNumOperador").Value.ToString()
                        operador.Cells("colOperadorCola").Value = Me.dGVOperadores.Rows(index).Cells("colOperador").Value.ToString()
                        operador.Cells("colStatCola").Value = Me.dGVOperadores.Rows(index).Cells("colStat").Value.ToString()
                        operador.Cells("colFechaVencLicCola").Value = Me.dGVOperadores.Rows(index).Cells("colFechaVencLic").Value.ToString()
                        operador.Cells("colFechaVencSegCola").Value = Me.dGVOperadores.Rows(index).Cells("colFechaVencSeg").Value.ToString()
                        operador.Cells("colManejaMatPeligrosoCola").Value = Me.dGVOperadores.Rows(index).Cells("colManejaMatPeligroso").Value.ToString()

                    End If

                    cargaIndex += 1

                Next
            ElseIf Me.dGVCargas.Rows.Count > Me.dGVOperadores.Rows.Count Then
                For index As Integer = 0 To Me.dGVCargas.Rows.Count - 1
                    If Me.dGVCargas.Rows(index).Visible = False Then

                        Continue For

                    End If

                    If unidadIndex < Me.dGVOperadores.Rows.Count - 1 Then
                        For i As Integer = unidadIndex To Me.dGVOperadores.Rows.Count - 1
                            If Me.dGVOperadores.Rows(i).DefaultCellStyle.BackColor = Color.HotPink Or Me.dGVOperadores.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed Then

                                unidadIndex += 1

                            Else

                                Exit For

                            End If
                        Next

                        embarque = Me.dGVAsignacion.Rows(Me.dGVAsignacion.Rows.Add())
                        embarque.Cells("colFechaLlegada").Value = Me.dGVOperadores.Rows(unidadIndex).Cells("colFechaLleg").Value.ToString()
                        embarque.Cells("colEco").Value = Me.dGVOperadores.Rows(unidadIndex).Cells("colUnidad").Value.ToString()
                        embarque.Cells("colCel").Value = Me.dGVOperadores.Rows(unidadIndex).Cells("colTelefono").Value.ToString()
                        embarque.Cells("colNoOperador").Value = Me.dGVOperadores.Rows(unidadIndex).Cells("colNumOperador").Value.ToString()
                        embarque.Cells("colOperadorAs").Value = Me.dGVOperadores.Rows(unidadIndex).Cells("colOperador").Value.ToString()
                        embarque.Cells("colNumCarga").Value = Me.dGVCargas.Rows(index).Cells("colNumero").Value.ToString()
                        embarque.Cells("colContenedor").Value = Me.dGVCargas.Rows(index).Cells("colContenedores").Value.ToString()
                        embarque.Cells("colCliente").Value = Me.dGVCargas.Rows(index).Cells("colClienteCont").Value.ToString()
                        embarque.Cells("colDestino").Value = Me.dGVCargas.Rows(index).Cells("colDestinoCont").Value.ToString()
                        embarque.Cells("colStatus").Value = Me.dGVCargas.Rows(index).Cells("colStatusCont").Value.ToString()
                        embarque.Cells("colHorario").Value = ""
                        embarque.Cells("colETA").Value = ""
                        embarque.Cells("colFechaPlantaAs").Value = Me.dGVCargas.Rows(index).Cells("colFechaPlanta").Value.ToString()

                    Else

                        carga = Me.dGVColaCargas.Rows(Me.dGVColaCargas.Rows.Add())
                        carga.Cells("colNumeroCola").Value = Me.dGVCargas.Rows(index).Cells("colNumero").Value.ToString()
                        carga.Cells("colContenedoresCola").Value = Me.dGVCargas.Rows(index).Cells("colContenedores").Value.ToString()
                        carga.Cells("colReferenciaCola").Value = Me.dGVCargas.Rows(index).Cells("colReferencia").Value.ToString()
                        carga.Cells("colClienteContCola").Value = Me.dGVCargas.Rows(index).Cells("colClienteCont").Value.ToString()
                        carga.Cells("colEntregarEnCola").Value = Me.dGVCargas.Rows(index).Cells("colEntregarEn").Value.ToString()
                        carga.Cells("colConfiguracionCola").Value = Me.dGVCargas.Rows(index).Cells("colConfiguracion").Value.ToString()
                        carga.Cells("colDestinoContCola").Value = Me.dGVCargas.Rows(index).Cells("colDestinoCont").Value.ToString()
                        carga.Cells("colTerminalCola").Value = Me.dGVCargas.Rows(index).Cells("colTerminal").Value.ToString()
                        carga.Cells("colStatusContCola").Value = Me.dGVCargas.Rows(index).Cells("colStatusCont").Value.ToString()
                        carga.Cells("colDemorasContCola").Value = Me.dGVCargas.Rows(index).Cells("colDemoras").Value.ToString()
                        carga.Cells("colNavieraCola").Value = Me.dGVCargas.Rows(index).Cells("colNaviera").Value.ToString()
                        carga.Cells("colOperacionCola").Value = Me.dGVCargas.Rows(index).Cells("colOperacion").Value.ToString()
                        carga.Cells("colEsPeligrosaCola").Value = Me.dGVCargas.Rows(index).Cells("colEsPeligrosa").Value.ToString()
                        carga.Cells("colFechaPlantaCola").Value = Me.dGVCargas.Rows(index).Cells("colFechaPlanta").Value.ToString()

                    End If

                    unidadIndex += 1

                Next
            End If

            MessageBox.Show("La asignación se ha realizado con éxito.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error al realizar la asignación: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub pintarFilas()

        Dim fechaVencLic As String
        Dim fechaVencSeg As String

        For Each fila As DataGridViewRow In Me.dGVOperadores.Rows
            If Not fila.Cells("colOperador").Value.ToString().Equals("S/O") And Not String.IsNullOrEmpty(fila.Cells("colOperador").Value.ToString()) Then

                If Not Convert.ToBoolean(fila.Cells("colAutorizado").Value.ToString()) Then

                    fechaVencLic = fila.Cells("colFechaVencLic").Value.ToString()
                    fechaVencSeg = fila.Cells("colFechaVencSeg").Value.ToString()

                    If Not fechaVencLic.Equals("S/F") Then
                        If DateTime.Compare(Convert.ToDateTime(fechaVencLic).ToString("dd/MM/yyyy"), DateTime.Today.AddDays(4).ToString("dd/MM/yyyy")) < 0 Then

                            fila.DefaultCellStyle().BackColor = Color.HotPink

                        End If
                    End If

                    If Not fechaVencSeg.Equals("S/F") Then
                        If DateTime.Compare(Convert.ToDateTime(fechaVencSeg).ToString("dd/MM/yyyy"), DateTime.Today.AddDays(4).ToString("dd/MM/yyyy")) < 0 Then

                            fila.DefaultCellStyle().BackColor = Color.OrangeRed

                        End If
                    End If
                Else

                    fila.DefaultCellStyle().BackColor = Color.GreenYellow

                End If
            End If
        Next
    End Sub

    Private Function tieneAutorizacion(ByVal nombreOperador As String) As Boolean

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim query As String

        Try

            conexion = Connection.getInstance().getConnection()
            query = "SELECT operador FROM trafico_autorizacion_operador WHERE fecha = '" & DateTime.Today.ToString("dd/MM/yyyy") & "'"
            comando = New SqlCommand(query, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each operador As DataRow In dS.Tables(0).Rows
                        If operador(0).ToString().Contains(nombreOperador.TrimEnd().TrimStart()) Then

                            Return True
                            Exit Function

                        End If
                    Next
                End If
            End If

            conexion.Close()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return False

    End Function

    Private Sub cambiarOperador()

        Dim operadorSel As DataGridViewRow
        Dim operadorCola As DataGridViewRow
        Dim operadorSustituto As DataGridViewRow

        Try
            If Me.dGVColaOperadores.Rows.Count <= 0 Then

                MessageBox.Show("No hay operadores en la cola de espera", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return

            End If

            For Each operador As DataGridViewRow In Me.dGVOperadores.Rows
                If operador.Cells("colNumOperador").Value.ToString().Equals(Me.dGVAsignacion.SelectedRows(0).Cells("colNoOperador").Value.ToString()) Then

                    operadorSel = operador
                    Exit For

                End If
            Next

            operadorSustituto = Me.dGVColaOperadores.Rows(0)
            operadorCola = Me.dGVColaOperadores.Rows(Me.dGVColaOperadores.Rows.Add())
            operadorCola.Cells("colFechaLlegCola").Value = operadorSel.Cells("colFechaLleg").Value.ToString()
            operadorCola.Cells("colUnidadCola").Value = operadorSel.Cells("colUnidad").Value.ToString()
            operadorCola.Cells("colTelefonoCola").Value = operadorSel.Cells("colTelefono").Value.ToString()
            operadorCola.Cells("colNumOperadorCola").Value = operadorSel.Cells("colNumOperador").Value.ToString()
            operadorCola.Cells("colOperadorCola").Value = operadorSel.Cells("colOperador").Value.ToString()
            operadorCola.Cells("colStatCola").Value = operadorSel.Cells("colStat").Value.ToString()
            operadorCola.Cells("colFechaVencLicCola").Value = operadorSel.Cells("colFechaVencLic").Value.ToString()
            operadorCola.Cells("colFechaVencSegCola").Value = operadorSel.Cells("colFechaVencSeg").Value.ToString()
            operadorCola.Cells("colManejaMatPeligrosoCola").Value = operadorSel.Cells("colManejaMatPeligroso").Value.ToString()
            operadorCola.Cells("colAutorizadoCola").Value = operadorSel.Cells("colAutorizado").Value.ToString()
            Me.dGVAsignacion.SelectedRows(0).Cells("colFechaLlegada").Value = operadorSustituto.Cells("colFechaLlegCola").Value.ToString()
            Me.dGVAsignacion.SelectedRows(0).Cells("colEco").Value = operadorSustituto.Cells("colUnidadCola").Value.ToString()
            Me.dGVAsignacion.SelectedRows(0).Cells("colCel").Value = operadorSustituto.Cells("colTelefonoCola").Value.ToString()
            Me.dGVAsignacion.SelectedRows(0).Cells("colNoOperador").Value = operadorSustituto.Cells("colNumOperadorCola").Value.ToString()
            Me.dGVAsignacion.SelectedRows(0).Cells("colOperadorAs").Value = operadorSustituto.Cells("colOperadorCola").Value.ToString()
            Me.dGVColaOperadores.Rows.Remove(Me.dGVColaOperadores.Rows(0))

        Catch ex As Exception

            MessageBox.Show("Error al cambiar el operador: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Shared Sub gridToExcel(ByVal grid As DataGridView)

        If grid.Rows.Count > 0 Then

            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim borders As Microsoft.Office.Interop.Excel.Borders
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim columnaExcel As Integer
            Dim columnas As Integer
            Dim filas As Integer

            columnaExcel = 1
            filas = grid.RowCount
            libro = App.Workbooks.Add()
            hoja = libro.Worksheets.Add()
            columnas = grid.ColumnCount

            For i As Integer = 0 To columnas - 1
                If grid.Columns(i).Visible = True Then

                    hoja.Cells.Item(1, columnaExcel) = grid.Columns(i).HeaderText
                    columnaExcel += 1

                End If
            Next

            columnaExcel = 0

            For fila As Integer = 0 To filas - 1
                For columna As Integer = 0 To columnas - 1
                    If grid.Columns(columna).Visible = True Then

                        hoja.Cells.Item(fila + 2, columnaExcel + 1) = grid.Rows(fila).Cells(columna).Value
                        columnaExcel += 1

                    End If
                Next

                columnaExcel = 0

            Next

            borders = hoja.Range("A1", "M" & filas).Borders
            borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            borders.Weight = 2.0R
            hoja.Range("A1", "J1").Interior.Color = ColorTranslator.ToOle(Color.Blue)
            hoja.Range("A1", "J1").Font.Color = ColorTranslator.ToOle(Color.White)
            hoja.Range("A1", "J1").Font.Size = 8
            hoja.Range("A1", "J1").Font.Bold = 1
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

    Private Sub guardarAsignacion()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try
            If Me.dGVAsignacion.Rows.Count > 0 Then

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("up_asignacion_cargas_insert", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 600
                conexion.Open()
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

                For Each carga As DataGridViewRow In Me.dGVAsignacion.Rows

                    conexion = Connection.getInstance().getConnection()
                    comando = New SqlCommand("up_asignacion_cargas_detalle_insert", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.CommandTimeout = 600
                    conexion.Open()

                    With comando.Parameters

                        .AddWithValue("@idUnidad", carga.Cells("colEco").Value.ToString())
                        .AddWithValue("@fechaLlegada", carga.Cells("colFechaLlegada").Value.ToString())
                        .AddWithValue("@numeroCelular", carga.Cells("colCel").Value.ToString())
                        .AddWithValue("@numeroOperador", carga.Cells("colNoOperador").Value.ToString())
                        .AddWithValue("@operador", carga.Cells("colOperadorAs").Value.ToString())
                        .AddWithValue("@numeroCarga", carga.Cells("colNumCarga").Value.ToString())
                        .AddWithValue("@contenedor", carga.Cells("colContenedor").Value.ToString())
                        .AddWithValue("@cliente", carga.Cells("colCliente").Value.ToString())
                        .AddWithValue("@destino", carga.Cells("colDestino").Value.ToString())
                        .AddWithValue("@status", carga.Cells("colStatus").Value.ToString())
                        .AddWithValue("@horario", carga.Cells("colHorario").Value.ToString())
                        .AddWithValue("@ETA", carga.Cells("colETA").Value.ToString())
                        .AddWithValue("@planta", carga.Cells("colFechaPlantaAs").Value.ToString())

                    End With

                    comando.ExecuteNonQuery()
                    conexion.Close()
                    conexion.Dispose()
                    comando.Dispose()

                Next
            End If
        Catch ex As Exception

            Cursor.Current = Cursors.Arrow
            MessageBox.Show("Error al guardar la asignación: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub guardarColas()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try
            For Each carga As DataGridViewRow In Me.dGVColaCargas.Rows

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("UP_ColaCargas_Insert", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 600
                conexion.Open()

                With comando.Parameters

                    .AddWithValue("@numeroCarga", Convert.ToInt32(carga.Cells("colNumeroCola").Value.ToString()))
                    .AddWithValue("@contenedor	", carga.Cells("colContenedoresCola").Value.ToString())
                    .AddWithValue("@referencia", carga.Cells("colReferenciaCola").Value.ToString())
                    .AddWithValue("@cliente", carga.Cells("colClienteContCola").Value.ToString())
                    .AddWithValue("@tipo1", carga.Cells("colConfiguracionCola").Value.ToString())
                    .AddWithValue("@entrega2", carga.Cells("colEntregarEnCola").Value.ToString())
                    .AddWithValue("@destino", carga.Cells("colDestinoContCola").Value.ToString())
                    .AddWithValue("@terminal", carga.Cells("colTerminalCola").Value.ToString())
                    .AddWithValue("@status", carga.Cells("colStatusContCola").Value.ToString())
                    .AddWithValue("@demoras", carga.Cells("colDemorasContCola").Value.ToString())
                    .AddWithValue("@naviera", carga.Cells("colNavieraCola").Value.ToString())
                    .AddWithValue("@operacion", carga.Cells("colOperacionCola").Value.ToString())
                    .AddWithValue("@esPeligrosa", carga.Cells("colEsPeligrosaCola").Value.ToString())
                    .AddWithValue("@fechaPlanta", carga.Cells("colFechaPlantaCola").Value.ToString())

                End With

                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            Next

            For Each unidad As DataGridViewRow In Me.dGVColaOperadores.Rows

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("UP_ColaUnidades_Insert", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 600
                conexion.Open()

                With comando.Parameters

                    .AddWithValue("@fechaLlegada", unidad.Cells("colFechaLlegCola").Value.ToString())
                    .AddWithValue("@unidad", unidad.Cells("colUnidadCola").Value.ToString())
                    .AddWithValue("@telefono", unidad.Cells("colTelefonoCola").Value.ToString())
                    .AddWithValue("@numeroOperador", Convert.ToInt32(unidad.Cells("colNumOperadorCola").Value.ToString()))
                    .AddWithValue("@operador", unidad.Cells("colOperadorCola").Value.ToString())
                    .AddWithValue("@status", unidad.Cells("colStatCola").Value.ToString())
                    .AddWithValue("@fecVenLic", unidad.Cells("colFechaVencLicCola").Value.ToString())
                    .AddWithValue("@fecVenSeg", unidad.Cells("colFechaVencSegCola").Value.ToString())
                    .AddWithValue("@aptoMatPel", unidad.Cells("colManejaMatPeligrosoCola").Value.ToString())

                End With

                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            Next

            MessageBox.Show("La información de la cola de espera ha sido guardada correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            MessageBox.Show("Error al guardar la cola de espera: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub cargarAsignacionGuardada()

        Dim embarque As DataGridViewRow
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_CargarAsignacion ", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each carga As DataRow In dS.Tables(0).Rows

                        embarque = Me.dGVAsignacion.Rows(Me.dGVAsignacion.Rows.Add())
                        embarque.Cells("colFechaLlegada").Value = carga("fechaLlegada").ToString()
                        embarque.Cells("colEco").Value = carga("IdUnidad").ToString()
                        embarque.Cells("colCel").Value = carga("numeroCelular").ToString()
                        embarque.Cells("colNoOperador").Value = carga("numeroOperador").ToString()
                        embarque.Cells("colOperadorAs").Value = carga("operador").ToString()
                        embarque.Cells("colNumCarga").Value = carga("numeroCarga").ToString()
                        embarque.Cells("colContenedor").Value = carga("contenedor").ToString()
                        embarque.Cells("colCliente").Value = carga("cliente").ToString()
                        embarque.Cells("colDestino").Value = carga("destino").ToString()
                        embarque.Cells("colStatus").Value = carga("status").ToString()
                        embarque.Cells("colHorario").Value = carga("horario").ToString()
                        embarque.Cells("colETA").Value = carga("ETA").ToString()
                        embarque.Cells("colFechaPlantaAs").Value = carga("planta").ToString()

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al cargar la asignación de cargas: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub cargarColasEspera()

        Dim operador As DataGridViewRow
        Dim carga As DataGridViewRow
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_CargarColas", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each unidad As DataRow In dS.Tables(0).Rows

                        operador = Me.dGVColaOperadores.Rows(Me.dGVColaOperadores.Rows.Add())
                        operador.Cells("colFechaLlegCola").Value = unidad("fechaLlegada").ToString()
                        operador.Cells("colUnidadCola").Value = unidad("unidad").ToString()
                        operador.Cells("colTelefonoCola").Value = unidad("telefono").ToString()
                        operador.Cells("colNumOperadorCola").Value = unidad("numeroOperador").ToString()
                        operador.Cells("colOperadorCola").Value = unidad("operador").ToString()
                        operador.Cells("colStatCola").Value = unidad("status").ToString()
                        operador.Cells("colFechaVencLicCola").Value = unidad("fecVenLic").ToString()
                        operador.Cells("colFechaVencSegCola").Value = unidad("fechaLlegada").ToString()
                        operador.Cells("colManejaMatPeligrosoCola").Value = unidad("fechaLlegada").ToString()

                    Next
                End If

                If dS.Tables(1).Rows.Count > 0 Then
                    For Each contenedor As String In dS.Tables(1).Rows

                        carga = Me.dGVColaCargas.Rows(Me.dGVColaCargas.Rows.Add())
                        carga.Cells("colNumeroCola").Value = contenedor("numeroCarga").ToString()
                        carga.Cells("colContenedoresCola").Value = contenedor("contenedor").ToString()
                        carga.Cells("colReferenciaCola").Value = contenedor("referencia").ToString()
                        carga.Cells("colClienteContCola").Value = contenedor("cliente").ToString()
                        carga.Cells("colEntregarEnCola").Value = contenedor("entrega2").ToString()
                        carga.Cells("colConfiguracionCola").Value = contenedor("tipo1").ToString()
                        carga.Cells("colDestinoContCola").Value = contenedor("destino").ToString()
                        carga.Cells("colTerminalCola").Value = contenedor("terminal").ToString()
                        carga.Cells("colStatusContCola").Value = contenedor("status").ToString()
                        carga.Cells("colDemorasContCola").Value = contenedor("demoras").ToString()
                        carga.Cells("colNavieraCola").Value = contenedor("naviera").ToString()
                        carga.Cells("colOperacionCola").Value = contenedor("operacion").ToString()
                        carga.Cells("colEsPeligrosaCola").Value = contenedor("esPeligrosa").ToString()
                        carga.Cells("colFechaPlantaCola").Value = contenedor("fechaPlanta").ToString()

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al cargar la cola de espera: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function consultarHoraLlegadaOperador(ByVal nombre As String) As String

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim resultado As String
        Dim dS As DataSet

        resultado = "---"

        Try

            conexion = Connection.getInstance().getConnectionDCTIME()
            comando = New SqlCommand("UP_HoraLlegada_Checador", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            dS = New DataSet()
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@nombre", nombre)

            End With

            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    resultado = dS.Tables(0).Rows(0)("horaLlegada").ToString()

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la hora de llegada del operador: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return resultado

    End Function

    Private Sub cambiarCarga()

        Dim cargaSel As DataGridViewRow
        Dim cargaCola As DataGridViewRow
        Dim cargaSustituta As DataGridViewRow

        Try
            If Me.dGVColaCargas.Rows.Count <= 0 Then

                MessageBox.Show("No hay cargas en la cola de espera", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return

            End If

            For Each carga As DataGridViewRow In Me.dGVCargas.Rows
                If carga.Cells("colNumero").Value.ToString().Equals(Me.dGVAsignacion.SelectedRows(0).Cells("colNumCarga").Value.ToString()) Then

                    cargaSel = carga
                    Exit For

                End If
            Next

            cargaSustituta = Me.dGVColaCargas.Rows(0)
            cargaCola = Me.dGVColaCargas.Rows(Me.dGVColaCargas.Rows.Add())
            cargaCola.Cells("colNumeroCola").Value = cargaSel.Cells("colNumero").Value.ToString()
            cargaCola.Cells("colContenedoresCola").Value = cargaSel.Cells("colContenedores").Value.ToString()
            cargaCola.Cells("colReferenciaCola").Value = cargaSel.Cells("colReferenciaCola").Value.ToString()
            cargaCola.Cells("colClienteContCola").Value = cargaSel.Cells("colClienteContCola").Value.ToString()
            cargaCola.Cells("colConfiguracionCola").Value = cargaSel.Cells("colConfiguracionCola").Value.ToString()
            cargaCola.Cells("colEntregarEnCola").Value = cargaSel.Cells("colEntregarEnCola").Value.ToString()
            cargaCola.Cells("colDestinoContCola").Value = cargaSel.Cells("colDestinoContCola").Value.ToString()
            cargaCola.Cells("colTerminalCola").Value = cargaSel.Cells("colTerminalCola").Value.ToString()
            cargaCola.Cells("colStatusContCola").Value = cargaSel.Cells("colStatusContCola").Value.ToString()
            cargaCola.Cells("colDemorasContCola").Value = cargaSel.Cells("colDemorasContCola").Value.ToString()
            cargaCola.Cells("colNavieraCola").Value = cargaSel.Cells("colNavieraCola").Value.ToString()
            cargaCola.Cells("colOperacionCola").Value = cargaSel.Cells("colOperacionCola").Value.ToString()
            cargaCola.Cells("colEsPeligrosaCola").Value = cargaSel.Cells("colEsPeligrosaCola").Value.ToString()
            cargaCola.Cells("colFechaPlantaCola").Value = cargaSel.Cells("colFechaPlantaCola").Value.ToString()

        Catch ex As Exception

            MessageBox.Show("Error al cambiar la carga: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub refrescarStatusInventario()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        Try
            For Each unidad As DataGridViewRow In Me.dGVOperadores.Rows

                consulta = "SELECT (SELECT dbo.UDF_Estatus_Unidades_QSP(economico)) AS [status], REPLACE(geocerca, 'null', 'N/I') AS [ubicacion] FROM Trafico_Auxiliar_Estatus WHERE economico = '" & unidad.Cells("colUnidad").Value.ToString() & "'"
                conexion = Connection.getInstance().getConnectionQSP()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                dS = New DataSet()
                sDA = New SqlDataAdapter(comando)
                sDA.Fill(dS)
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

                If dS.Tables.Count > 0 Then
                    If dS.Tables(0).Rows.Count > 0 Then

                        unidad.Cells("colStat").Value = dS.Tables(0).Rows(0)("status").ToString()
                        unidad.Cells("colUbicacion").Value = dS.Tables(0).Rows(0)("ubicacion").ToString()

                    End If
                End If
            Next
        Catch ex As Exception

            MessageBox.Show("Error al refrescar los status del inventario: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub refrescarStatusColaEsperaInventario()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        Try
            For Each unidad As DataGridViewRow In Me.dGVColaOperadores.Rows

                consulta = "SELECT (SELECT dbo.UDF_Estatus_Unidades_QSP(economico)) AS [status], REPLACE(geocerca, 'null', 'N/I') AS [ubicacion] FROM Trafico_Auxiliar_Estatus WHERE economico = '" & unidad.Cells("colUnidadCola").Value.ToString() & "'"
                conexion = Connection.getInstance().getConnectionQSP()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                dS = New DataSet()
                sDA = New SqlDataAdapter(comando)
                sDA.Fill(dS)
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

                If dS.Tables.Count > 0 Then
                    If dS.Tables(0).Rows.Count > 0 Then

                        unidad.Cells("colStatCola").Value = dS.Tables(0).Rows(0)("status").ToString()
                        
                    End If
                End If
            Next
        Catch ex As Exception

            MessageBox.Show("Error al refrescar los status del inventario: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub empatarCargas()

        If Me.dGVCargas.SelectedRows.Count = 2 AndAlso Me.dGVCargas.SelectedRows(0).Cells("colConfiguracion").Value.ToString().Equals("S") Then

            If Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value.ToString().Contains("(1)") Then

                Me.dGVCargas.SelectedRows(0).Cells("colContenedores").Value = Me.dGVCargas.SelectedRows(0).Cells("colContenedores").Value.ToString & " + " & Me.dGVCargas.SelectedRows(1).Cells("colContenedores").Value.ToString()
                Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value = Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value.ToString & " + " & Me.dGVCargas.SelectedRows(1).Cells("colClienteCont").Value.ToString()
                Me.dGVCargas.SelectedRows(0).Cells("colConfiguracion").Value = "F"
                Me.dGVCargas.SelectedRows(1).Visible = False

            Else

                Me.dGVCargas.SelectedRows(0).Cells("colContenedores").Value = Me.dGVCargas.SelectedRows(1).Cells("colContenedores").Value.ToString & " + " & Me.dGVCargas.SelectedRows(0).Cells("colContenedores").Value.ToString()
                Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value = Me.dGVCargas.SelectedRows(1).Cells("colClienteCont").Value.ToString & " + " & Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value.ToString()
                Me.dGVCargas.SelectedRows(0).Cells("colConfiguracion").Value = "F"
                Me.dGVCargas.SelectedRows(1).Visible = False

            End If

            Me.dGVCargas.Refresh()

        Else

            MessageBox.Show("Para poder realizar el empate debe selccionar solo dos cargas de tipo sencillo.", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub desempatarCargas()

        Dim contenedor, cliente As String

        If Me.dGVCargas.SelectedRows.Count = 1 AndAlso Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value.ToString().Contains("(1)") AndAlso Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value.ToString().Contains("(2)") Then

            contenedor = Me.dGVCargas.SelectedRows(0).Cells("colContenedores").Value.ToString().Split("+")(1).TrimStart().TrimEnd()
            cliente = Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value.ToString().Split("+")(1).Replace("(2)", "").TrimStart().TrimEnd()

            For Each fila As DataGridViewRow In Me.dGVCargas.Rows
                If fila.Cells("colContenedores").Value.ToString().Contains(contenedor) AndAlso fila.Cells("colClienteCont").Value.ToString().Contains(cliente) AndAlso fila.Visible = False Then

                    fila.Visible = True
                    Exit For

                End If
            Next

            Me.dGVCargas.SelectedRows(0).Cells("colContenedores").Value = Me.dGVCargas.SelectedRows(0).Cells("colContenedores").Value.ToString().Replace(" + " & contenedor, "")
            Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value = Me.dGVCargas.SelectedRows(0).Cells("colClienteCont").Value.ToString().Replace(" (1) + " & cliente & " (2)", "")
            Me.dGVCargas.SelectedRows(0).Cells("colConfiguracion").Value = "S"

        Else

            MessageBox.Show("Debe seleccionar una carga que previamente haya sido empatada.")

        End If
    End Sub
End Class