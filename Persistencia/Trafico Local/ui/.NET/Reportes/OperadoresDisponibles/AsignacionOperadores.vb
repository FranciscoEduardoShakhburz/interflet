Imports System.Data
Imports System.Data.SqlClient
Imports Sy


Public Class AsignacionOperadores

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OperadoresDisponibles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.rBPorOperador.Checked = True
        Me.consultarOperadores()
        Me.dGVMovimientos.DefaultCellStyle.Font = New Font("Ubuntu", 10)

    End Sub

    Private Sub consultarOperadores()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS, dS1 As DataSet
        Dim operador As DataGridViewRow
        Dim index As Integer
        Dim consulta As String

        Try

            conexion = New SqlConnection("Data Source=dah-291; Initial Catalog=dctime;User ID=sa; Password=sa;Persist Security Info=True")
            consulta = "SELECT trab.nombres + ' ' + trab.apellido_paterno + ' ' + trab.apellido_materno AS [Nombre], SUBSTRING(CONVERT(VARCHAR(20), reg.fecha, 108), 0, 6) AS [Hora] FROM cat_registro reg LEFT JOIN cat_trabajadores trab ON reg.trabajador = trab.trabajador WHERE CONVERT(VARCHAR(10), reg.fecha, 112) = '" & Me.dTPFecha.Value.ToString("yyyyMMdd") & "' AND trab.Puesto LIKE '%Operador%'  ORDER BY fecha DESC"
            
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each registro As DataRow In dS.Tables(0).Rows

                        conexion = Connection.getInstance().getConnection()
                        consulta = "SELECT TOP(1) per.nombre AS [Operador], CASE cat.descripcion WHEN 'OPERADOR LOCAL' THEN 'Local' ELSE 'Foráneo' END AS [Tipo de operador] FROM personal_personal per LEFT JOIN personal_catalogo_categoria cat ON per.id_categoria = cat.id_categoria WHERE per.estado = 'A' AND per.tipo_empleado = 'O' AND per.nombre LIKE '%" & registro("Nombre") & "%' ORDER BY per.nombre"
                        comando = New SqlCommand(consulta, conexion)
                        comando.CommandType = CommandType.Text
                        comando.CommandTimeout = 600
                        conexion.Open()
                        sDA = New SqlDataAdapter(comando)
                        dS1 = New DataSet()
                        sDA.Fill(dS1)
                        conexion.Close()
                        conexion.Dispose()
                        comando.Dispose()

                        If dS1.Tables.Count > 0 Then
                            If dS1.Tables(0).Rows.Count > 0 Then

                                index = Me.dGVOperadores.Rows.Add()
                                operador = Me.dGVOperadores.Rows(index)
                                operador.Cells("colOperador").Value = registro("Nombre").ToString()
                                operador.Cells("colTipoOper").Value = dS1.Tables(0).Rows(0)("Tipo de operador").ToString()
                                operador.Cells("colHoraEntrada").Value = registro("Hora").ToString()
                                operador.Cells("colEstatus").Value = "Disponible"
                                operador.Cells("colEstatus").Style.BackColor = Color.GreenYellow
                                operador.Cells("colEstatus").Style.Font = New Font("Ubuntu", 10)

                            End If
                        End If
                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub consultarMovsOperador(ByVal opcion As Integer, ByVal fechaDesde As Date, ByVal fechaHasta As Date, ByVal nombreOperador As String)

        Dim comando As SqlCommand
        Dim conexion As SqlConnection
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim movimiento As DataGridViewRow

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Consulta_MovsPatio", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue ("@opcion", opcion)
                .AddWithValue("@desde", fechaDesde)
                .AddWithValue("@hasta", fechaHasta)
                .AddWithValue("@operador", nombreOperador)

            End With

            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each registro As DataRow In dS.Tables(0).Rows

                        movimiento = Me.dGVMovimientos.Rows(Me.dGVMovimientos.Rows.Add())
                        movimiento.Cells("colUnidad").Value = registro("Unidad").ToString()
                        movimiento.Cells("colMovimiento").Value = registro("Movimiento").ToString()
                        movimiento.Cells("colHora").Value = registro("Hora").ToString()
                        movimiento.Cells("colUbicacion").Value = registro("Ubicacion").ToString()
                        movimiento.Cells("colLugar").Value = registro("Lugar").ToString()
                        movimiento.Cells("colRemolque1").Value = registro("Remolque1").ToString()
                        movimiento.Cells("colDolly").Value = registro("Dolly").ToString()
                        movimiento.Cells("colRemolque2").Value = registro("Remolque2").ToString()
                        movimiento.Cells("colContenedor1").Value = registro("Contenedor1").ToString()
                        movimiento.Cells("colContenedor2").Value = registro("Contenedor2").ToString()
                        movimiento.Cells("colContenedor11").Value = registro("Contenedor11").ToString()
                        movimiento.Cells("colContenedor22").Value = registro("Contenedor22").ToString()

                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar los movimientos del operador: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub consultarPor()

        If Me.rBPorOperador.Checked Then
            If Me.dGVOperadores.Rows.Count > 0 Then

                Me.consultarMovsOperador(1, Me.dTPFecha.Value, Me.dTPFecha.Value, Me.dGVOperadores.SelectedRows(0).Cells("colOperador").Value.ToString())

            End If
        ElseIf Me.rBTodosOperadores.Checked Then

            Me.consultarMovsOperador(2, Me.dTPFecha.Value, Me.dTPFecha.Value, "")

        End If
    End Sub

    Private Sub tSBCatOperadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBCatOperadores.Click

        Dim cat As CatalogoPersonal = New CatalogoPersonal()
        cat.ShowDialog(Me)

    End Sub

    Private Sub tSBCatEquipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBCatEquipo.Click

        Dim cat As CatalogoEquipos = New CatalogoEquipos()
        cat.ShowDialog(Me)

    End Sub

    Private Sub tSBReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBReporte.Click

    End Sub

    Private Sub tSBSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSBSalir.Click

        Me.Close()

    End Sub

    Private Sub dGVOperadores_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dGVOperadores.CellMouseClick

        If Me.rBPorOperador.Checked Then

            Me.dGVMovimientos.Rows.Clear()
            Me.consultarMovsOperador(1, Me.dTPFecha.Value, Me.dTPFecha.Value, Me.dGVOperadores.SelectedRows(0).Cells("colOperador").Value.ToString())

        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim cap As CapOperador = New CapOperador(Me.dGVOperadores)
        cap.ShowDialog(Me)

    End Sub

    Private Sub AsignacionOperadores_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        Me.gBMovimientos.Location = New Point((Me.Width / 2) + 10, Me.gBMovimientos.Location.Y)
        Me.gBOperadores.Width = (Me.Width / 2) - 10
        Me.gBMovimientos.Width = (Me.Width / 2) - 20

    End Sub

    Private Sub rBPorOperador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBPorOperador.CheckedChanged, rBTodosOperadores.CheckedChanged

        Me.consultarPor()

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

    End Sub
End Class