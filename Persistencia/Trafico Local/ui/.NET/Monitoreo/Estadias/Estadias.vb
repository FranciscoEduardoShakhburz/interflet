Imports System.Data
Imports System.Data.SqlClient

Public Class Estadias

    Private tTBotonAgregar As ToolTip
    Private tTBotonEliminar As ToolTip
    Private tTBotonEditar As ToolTip
    Private tTBotonRefrescar As ToolTip
    Private tTBotonExportar As ToolTip
    Private tTBotonSalir As ToolTip

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.tTBotonAgregar = New ToolTip()
        Me.tTBotonEliminar = New ToolTip()
        Me.tTBotonEditar = New ToolTip()
        Me.tTBotonRefrescar = New ToolTip()
        Me.tTBotonExportar = New ToolTip()
        Me.tTBotonSalir = New ToolTip()
        Me.tTBotonAgregar.Show("Agregar estadía", Me.btnAgregar)
        Me.tTBotonEliminar.Show("Eliminar estadía", Me.btnEliminar)
        Me.tTBotonEditar.Show("Editar estadía", Me.btnEditar)
        Me.tTBotonRefrescar.Show("Refrescar consulta", Me.btnRefrescar)
        Me.tTBotonExportar.Show("Exportar reporte", Me.btnExportar)
        Me.tTBotonSalir.Show("Salir", Me.btnSalir)

    End Sub

    Private Sub Estadias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.rBUnidad.Checked = True
        Me.consultarInformacion()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim capEstadias As CapturaEstadias = New CapturaEstadias()
        capEstadias.ShowDialog(Me)

    End Sub

    Private Sub rBUnidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBUnidad.CheckedChanged, rBViaje.CheckedChanged, rBFecha.CheckedChanged, rBCliente.CheckedChanged

        Me.consultarInformacion()

    End Sub

    Private Sub txtUnidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnidad.TextChanged, txtCliente.TextChanged

        Me.consultarInformacion()

    End Sub

    Private Sub dTPFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dTPFechaDesde.ValueChanged, dTPFechaHasta.ValueChanged

        Me.consultarInformacion()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Me.eliminarRegistro(Convert.ToInt32(Me.dGVEstadias.SelectedRows(0).Cells("VIAJE").Value.ToString()))
        Me.btnRefrescar_Click(sender, e)
        MessageBox.Show("El registro se ha eliminado correctamente", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        If Me.dGVEstadias.Rows.Count > 0 Then

            Dim capEstadia As CapturaEstadias = New CapturaEstadias(Convert.ToInt32(Me.dGVEstadias.SelectedRows(0).Cells("VIAJE").Value.ToString()))
            capEstadia.ShowDialog(Me)

        End If
    End Sub

    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click

        Me.consultarInformacion()

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Excel.gridToExcel(Me.dGVEstadias)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub mTBViaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTBViaje.TextChanged

        Me.consultarInformacion()

    End Sub

    Private Sub consultarInformacion()

        If Me.rBUnidad.Checked Then
            If String.IsNullOrEmpty(Me.txtUnidad.Text) Then

                Me.dGVEstadias.DataSource = Nothing

            Else

                Me.consultarPor(1, Me.txtUnidad.Text, 0, "", DateTime.Now, DateTime.Now)

            End If
        ElseIf Me.rBViaje.Checked Then
            If String.IsNullOrEmpty(Me.mTBViaje.Text) Then

                Me.dGVEstadias.DataSource = Nothing

            Else

                Me.consultarPor(2, "", Convert.ToInt32(Me.mTBViaje.Text), "", DateTime.Now, DateTime.Now)

            End If
        ElseIf Me.rBCliente.Checked Then
            If String.IsNullOrEmpty(Me.txtCliente.Text) Then

                Me.dGVEstadias.DataSource = Nothing

            Else

                Me.consultarPor(3, "", 0, Me.txtCliente.Text, DateTime.Now, DateTime.Now)

            End If
        ElseIf Me.rBFecha.Checked Then

            Me.consultarPor(4, "", 0, "", Me.dTPFechaDesde.Value, Me.dTPFechaHasta.Value)

        End If
    End Sub

    Private Sub eliminarRegistro(ByVal noViaje As Integer)

        Dim consulta As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try

            consulta = "DECLARE @estadia INT SET @estadia = (SELECT TOP(1) idEstadia FROM Trafico_Estadias WHERE noViaje = " & noViaje & ") DELETE FROM Trafico_Estadias WHERE idEstadia = @estadia DELETE FROM Trafico_Estadias_Detalle WHERE idEstadia = @estadia"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al eliminar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub consultarPor(ByVal opcion As Integer, ByVal unidad As String, ByVal numeroViaje As Integer, ByVal cliente As String, ByVal fechaDesde As Date, ByVal fechaHasta As Date)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Buscar_Estadias", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@tipoBusqueda", opcion)
                .AddWithValue("@unidad", unidad)
                .AddWithValue("@noViaje", numeroViaje)
                .AddWithValue("@cliente", cliente)
                .AddWithValue("@fechaDesde", fechaDesde)
                .AddWithValue("@fechaHasta", fechaHasta)

            End With

            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)
            Me.dGVEstadias.DataSource = dS.Tables(0)

        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class