Imports System.Data
Imports System.Data.SqlClient

Public Class CatValeGasolina

    Private contraseñaCorrecta As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.contraseñaCorrecta = False

    End Sub

    Private Sub UnidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesToolStripMenuItem.Click

        Dim uni As CatUnidades = New CatUnidades()
        uni.ShowDialog(Me)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim vale As ValeGasolina = New ValeGasolina()
        vale.ShowDialog(Me)
        Me.cargarVales()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub cargarVales()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String
        Dim indice As Integer = 0

        Try

            Me.gridVales.Rows.Clear()
            Me.gridVales.Update()
            consulta = "SELECT economico, operador, fecha, numVale, cantidad, tipoCombustible, kilometraje FROM Trafico_Vales_Gasolina WHERE fechaVale >= '" & Me.dteDesde.Value.ToString("dd/MM/yyyy") & "' AND fecha <= '" & Me.dteHasta.Value.ToString("dd/MM/yyyy") & "'"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet
            sDA.Fill(dS)
            comando.Dispose()
            conexion.Dispose()
            conexion.Close()
            Me.gridVales.Rows.Clear()

            If dS.Tables(0).Rows.Count > 0 Then
                For Each vale As DataRow In dS.Tables(0).Rows

                    indice = Me.gridVales.Rows.Add()
                    Me.gridVales.Rows(indice).Cells("unidad").Value = vale("economico")
                    Me.gridVales.Rows(indice).Cells("operador").Value = vale("operador")
                    Me.gridVales.Rows(indice).Cells("fecha").Value = vale("fecha")
                    Me.gridVales.Rows(indice).Cells("vale").Value = vale("numVale")
                    Me.gridVales.Rows(indice).Cells("cantidad").Value = vale("cantidad")
                    Me.gridVales.Rows(indice).Cells("combustible").Value = vale("tipoCombustible")
                    Me.gridVales.Rows(indice).Cells("kilometraje").Value = vale("kilometraje")

                Next
            End If
        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error al consultar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub CatValeGasolina_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarVales()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Me.cargarVales()

    End Sub

    Private Sub gridVales_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridVales.CellDoubleClick

        Dim autorizar As AutorizarMovimiento = New AutorizarMovimiento(Me)
        autorizar.ShowDialog(Me)

        If Me.contraseñaCorrecta Then

            Dim vale As ValeGasolina = New ValeGasolina(Me.gridVales.Rows(e.RowIndex).Cells("unidad").Value.ToString(), Me.gridVales.Rows(e.RowIndex).Cells("vale").Value.ToString())
            vale.ShowDialog(Me)
            Me.cargarVales()
            Me.contraseñaCorrecta = False

        Else

            MessageBox.Show("La contraseña es incorrecta", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub eliminarRegistros()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String


        Try
            For Each vale As DataGridViewRow In Me.gridVales.SelectedRows

                consulta = "DELETE FROM Trafico_Vales_Gasolina WHERE economico = '" & vale.Cells("unidad").Value.ToString() & "' AND numVale = '" & vale.Cells("vale").Value.ToString() & "'"
                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                comando.ExecuteNonQuery()
                comando.Dispose()
                conexion.Dispose()
                conexion.Close()

            Next

            MessageBox.Show("Los registros se eliminaron satisfactoriamente", "¡Completado!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Ha ocurrido un error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim autorizar As AutorizarMovimiento = New AutorizarMovimiento(Me)
        autorizar.ShowDialog(Me)

        If Me.contraseñaCorrecta Then

            Me.eliminarRegistros()
            Me.cargarVales()
            Me.contraseñaCorrecta = False

        Else

            MessageBox.Show("La contraseña es incorrecta", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub txtBusqueda_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyUp

        If Not String.IsNullOrEmpty(Me.txtBusqueda.Text) Then

            Dim conexion As SqlConnection
            Dim comando As SqlCommand
            Dim sDA As SqlDataAdapter
            Dim dS As DataSet
            Dim consulta As String
            Dim indice As Integer = 0

            Try

                Me.gridVales.Rows.Clear()
                Me.gridVales.Update()
                consulta = "SELECT economico, operador, fecha, numVale, cantidad, tipoCombustible, kilometraje FROM Trafico_Vales_Gasolina WHERE numVale LIKE '" & Me.txtBusqueda.Text & "%'"
                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet
                sDA.Fill(dS)
                comando.Dispose()
                conexion.Dispose()
                conexion.Close()
                Me.gridVales.Rows.Clear()

                If dS.Tables(0).Rows.Count > 0 Then
                    For Each vale As DataRow In dS.Tables(0).Rows

                        indice = Me.gridVales.Rows.Add()
                        Me.gridVales.Rows(indice).Cells("unidad").Value = vale("economico")
                        Me.gridVales.Rows(indice).Cells("operador").Value = vale("operador")
                        Me.gridVales.Rows(indice).Cells("fecha").Value = vale("fecha")
                        Me.gridVales.Rows(indice).Cells("vale").Value = vale("numVale")
                        Me.gridVales.Rows(indice).Cells("cantidad").Value = vale("cantidad")
                        Me.gridVales.Rows(indice).Cells("combustible").Value = vale("tipoCombustible")
                        Me.gridVales.Rows(indice).Cells("kilometraje").Value = vale("kilometraje")

                    Next
                End If
            Catch ex As Exception

                MessageBox.Show("Ha ocurrido un error al consultar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else

            Me.cargarVales()

        End If
    End Sub

    Public Sub contraCorrecta()

        Me.contraseñaCorrecta = True

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Excel.gridToExcel(Me.gridVales)

    End Sub

    Private Sub LitrosConsumidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LitrosConsumidosToolStripMenuItem.Click

        Dim reportes As ReporteLtsConsumidos = New ReporteLtsConsumidos()
        reportes.ShowDialog(Me)

    End Sub
End Class