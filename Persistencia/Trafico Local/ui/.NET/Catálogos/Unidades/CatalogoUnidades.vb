Imports System.Data
Imports System.Data.SqlClient

Public Class CatalogoUnidades

    Private Sub CatalogoUnidades_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.rBEconomico.Checked = True
        Me.cargarInformacion()
        Me.dGVAltamira.Refresh()
        Me.aplicarFiltros()

    End Sub

    Private Sub tSBAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBAgregar.Click

        Dim agregar As AgregarUnidad
        agregar = New AgregarUnidad()
        agregar.ShowDialog(Me)

    End Sub
    
    Private Sub tSBEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBEliminar.Click

    End Sub

    Private Sub tSBSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBSalir.Click

        Me.Close()

    End Sub

    Private Sub dGVAltamira_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVAltamira.CellDoubleClick

        Dim id As Integer
        Dim placas As String
        Dim celular As String
        Dim operador As String
        Dim economico As String
        Dim fechaVencLic As Date
        Dim fechaVencExMed As Date
        Dim filaSel As DataGridViewRow
        Dim agregarUnidad As AgregarUnidad
        filaSel = Me.dGVAltamira.SelectedRows(0)

        id = Convert.ToInt32(filaSel.Cells("colId").Value.ToString())
        placas = filaSel.Cells("colPlacas").Value.ToString()
        celular = filaSel.Cells("colCel").Value.ToString()
        operador = filaSel.Cells("colOperador").Value.ToString()
        economico = filaSel.Cells("colEconomico").Value.ToString()

        If String.IsNullOrEmpty(filaSel.Cells("colFechaVencLicencia").Value.ToString()) Then

            fechaVencLic = Date.Today

        Else

            fechaVencLic = filaSel.Cells("colFechaVencLicencia").Value.ToString()

        End If

        If String.IsNullOrEmpty(filaSel.Cells("colFechaVencExamenMedico").Value.ToString()) Then

            fechaVencExMed = Date.Today

        Else

            fechaVencExMed = filaSel.Cells("colFechaVencExamenMedico").Value.ToString()

        End If

        agregarUnidad = New AgregarUnidad(id, placas, celular, operador, economico, fechaVencLic, fechaVencExMed)

        If agregarUnidad.ShowDialog(Me) = DialogResult.OK Then

            Me.dGVAltamira.Rows.Clear()
            Me.cargarInformacion()

        End If
    End Sub

    Private Sub dGVManzanillo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVManzanillo.CellDoubleClick

        Dim id As Integer
        Dim placas As String
        Dim celular As String
        Dim operador As String
        Dim economico As String
        Dim fechaVencLic As Date
        Dim fechaVencExMed As Date
        Dim filaSel As DataGridViewRow
        Dim agregarUnidad As AgregarUnidad
        filaSel = Me.dGVManzanillo.SelectedRows(0)

        id = Convert.ToInt32(filaSel.Cells("colIdMzo").Value.ToString())
        placas = filaSel.Cells("colPlacasMzo").Value.ToString()
        celular = filaSel.Cells("colCelMzo").Value.ToString()
        operador = filaSel.Cells("colOperadorMzo").Value.ToString()
        economico = filaSel.Cells("colEconomicoMzo").Value.ToString()

        If String.IsNullOrEmpty(filaSel.Cells("colFechaVencLicenciaMzo").Value.ToString()) Then

            fechaVencLic = Date.Today

        Else

            fechaVencLic = filaSel.Cells("colFechaVencLicenciaMzo").Value.ToString()

        End If

        If String.IsNullOrEmpty(filaSel.Cells("colFechaVencExamenMedicoMzo").Value.ToString()) Then

            fechaVencExMed = Date.Today

        Else

            fechaVencExMed = filaSel.Cells("colFechaVencExamenMedicoMzo").Value.ToString()

        End If

        agregarUnidad = New AgregarUnidad(id, placas, celular, operador, economico, fechaVencLic, fechaVencExMed)

        If agregarUnidad.ShowDialog(Me) = DialogResult.OK Then

            Me.dGVManzanillo.Rows.Clear()
            Me.cargarInformacion()

        End If
    End Sub

    Private Sub dGVVeracruz_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVVeracruz.CellDoubleClick

        Dim id As Integer
        Dim placas As String
        Dim celular As String
        Dim operador As String
        Dim economico As String
        Dim fechaVencLic As Date
        Dim fechaVencExMed As Date
        Dim filaSel As DataGridViewRow
        Dim agregarUnidad As AgregarUnidad
        filaSel = Me.dGVVeracruz.SelectedRows(0)

        id = Convert.ToInt32(filaSel.Cells("colIdVer").Value.ToString())
        placas = filaSel.Cells("colPlacasVer").Value.ToString()
        celular = filaSel.Cells("colCelVer").Value.ToString()
        operador = filaSel.Cells("colOperadorVer").Value.ToString()
        economico = filaSel.Cells("colEconomicoVer").Value.ToString()

        If String.IsNullOrEmpty(filaSel.Cells("colFechaVencLicenciaVer").Value.ToString()) Then

            fechaVencLic = Date.Today

        Else

            fechaVencLic = filaSel.Cells("colFechaVencLicenciaVer").Value.ToString()

        End If

        If String.IsNullOrEmpty(filaSel.Cells("colFechaVencExamenMedicoVer").Value.ToString()) Then

            fechaVencExMed = Date.Today

        Else

            fechaVencExMed = filaSel.Cells("colFechaVencExamenMedicoVer").Value.ToString()

        End If

        agregarUnidad = New AgregarUnidad(id, placas, celular, operador, economico, fechaVencLic, fechaVencExMed)

        If agregarUnidad.ShowDialog(Me) = DialogResult.OK Then

            Me.dGVVeracruz.Rows.Clear()
            Me.cargarInformacion()

        End If

    End Sub

    Private Sub tBFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tBFiltro.TextChanged

        Me.aplicarFiltros()

    End Sub

    Private Sub cargarInformacion()

        Dim unidad As DataGridViewRow
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        Try

            consulta = "SELECT * FROM SistemaInterflet_CatUnidades"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            dS = New DataSet()
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each uni As DataRow In dS.Tables(0).Rows
                        If uni("areaId").ToString().Equals("1") Then

                            unidad = Me.dGVAltamira.Rows(Me.dGVAltamira.Rows.Add())
                            unidad.Cells("colId").Value = uni("id").ToString()
                            unidad.Cells("colEconomico").Value = uni("economico").ToString()
                            unidad.Cells("colPlacas").Value = uni("placas").ToString()
                            unidad.Cells("colOperador").Value = uni("operador").ToString()
                            unidad.Cells("colCel").Value = uni("celularAsignado").ToString()
                            unidad.Cells("colFechaVencExamenMedico").Value = uni("fechaVencExamenMedico").ToString()
                            unidad.Cells("colFechaVencLicencia").Value = uni("fechaVencLicencia").ToString()

                        ElseIf uni("areaId").ToString().Equals("2") Then

                            unidad = Me.dGVManzanillo.Rows(Me.dGVManzanillo.Rows.Add())
                            unidad.Cells("colIdMzo").Value = uni("id").ToString()
                            unidad.Cells("colEconomicoMzo").Value = uni("economico").ToString()
                            unidad.Cells("colPlacasMzo").Value = uni("placas").ToString()
                            unidad.Cells("colOperadorMzo").Value = uni("operador").ToString()
                            unidad.Cells("colCelMzo").Value = uni("celularAsignado").ToString()
                            unidad.Cells("colFechaVencExamenMedicoMzo").Value = uni("fechaVencExamenMedico").ToString()
                            unidad.Cells("colFechaVencLicenciaMzo").Value = uni("fechaVencLicencia").ToString()

                        ElseIf uni("areaId").ToString().Equals("3") Then

                            unidad = Me.dGVVeracruz.Rows(Me.dGVVeracruz.Rows.Add())
                            unidad.Cells("colIdVer").Value = uni("id").ToString()
                            unidad.Cells("colEconomicoVer").Value = uni("economico").ToString()
                            unidad.Cells("colPlacasVer").Value = uni("placas").ToString()
                            unidad.Cells("colOperadorVer").Value = uni("operador").ToString()
                            unidad.Cells("colCelVer").Value = uni("celularAsignado").ToString()
                            unidad.Cells("colFechaVencExamenMedicoVer").Value = uni("fechaVencExamenMedico").ToString()
                            unidad.Cells("colFechaVencLicenciaVer").Value = uni("fechaVencLicencia").ToString()

                        End If
                    Next
                End If
            End If

            Me.dGVAltamira.Refresh()
            Me.dGVAltamira.Update()

        Catch ex As Exception

            MessageBox.Show("Error al cargar el catálogo de unidades: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub aplicarFiltros()

        For Each unidad As DataGridViewRow In Me.dGVAltamira.Rows
            If Me.rBEconomico.Checked Then
                If unidad.Cells("colEconomico").Value.ToString().Contains(Me.tBFiltro.Text.TrimEnd().TrimStart()) Then

                    unidad.Visible = True

                Else

                    unidad.Visible = False

                End If
            End If

            If Me.rBOperador.Checked Then
                If unidad.Cells("colOperador").Value.ToString().Contains(Me.tBFiltro.Text.TrimEnd().TrimStart()) Then

                    unidad.Visible = True

                Else

                    unidad.Visible = False

                End If
            End If

            If Me.tBFiltro.Text.Equals("") Then

                unidad.Visible = True

            End If
        Next
    End Sub

    Private Sub eliminarRegistro(ByVal id As Integer)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            consulta = "DELETE FROM "
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("", conexion)

        Catch ex As Exception

            MessageBox.Show("Error al eliminar el registro: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class