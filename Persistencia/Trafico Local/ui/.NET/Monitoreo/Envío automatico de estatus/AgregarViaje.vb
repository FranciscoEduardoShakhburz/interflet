Imports System.Data
Imports System.Data.SqlClient

Public Class AgregarViaje

    Private dGVUnidades As DataGridView
    Private carga As DataGridViewRow
    ' 1.- Agregar 2.- Editar
    Private opcion As Integer

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef dGVUnidades As DataGridView, ByVal opcion As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dGVUnidades = dGVUnidades
        Me.opcion = opcion

    End Sub

    Public Sub New(ByRef carga As DataGridViewRow, ByVal opcion As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.carga = carga
        Me.opcion = opcion

    End Sub

    Private Sub AgregarViaje_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Me.opcion = 1 Then

            Me.Text = "Agregar viaje | Envío de status"
            Me.dGVCorreos.AllowUserToAddRows = True
            
        ElseIf Me.opcion = 2 Then

            Me.Text = "Editar viaje | Envío de status"
            Me.cargarInformacion()

        End If

        Me.cBTipoOper.SelectedIndex = 0
        Me.resultadosDeBusquedaOperadores()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Me.guardar()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click

        Dim sel As SeleccionarCliente = New SeleccionarCliente()
        Dim mail As DataGridViewRow

        sel.ShowDialog(Me)

        If Not String.IsNullOrEmpty(sel.cliente) Then

            Me.tBNumeroCliente.Text = sel.cliente.Split("*")(0)
            Me.tBCliente.Text = sel.cliente.Split("*")(1)

            For Each correo As String In sel.cliente.Split("*")(2).Trim().Split(";")

                mail = Me.dGVCorreos.Rows(Me.dGVCorreos.Rows.Add())
                mail.Cells("colCorreos").Value = correo

            Next
        End If
    End Sub

    Private Sub cargarInformacion()

        Dim mail As DataGridViewRow
        Me.tBUnidad.Text = Me.carga.Cells("colUnidad").Value.ToString()
        Me.tBOperador.Text = Me.carga.Cells("colOperador").Value.ToString()
        Me.tBPlacas.Text = Me.carga.Cells("colPlacas").Value.ToString()
        Me.tBViaje.Text = Me.carga.Cells("colViaje").Value.ToString()
        Me.tBNumeroCliente.Text = Me.carga.Cells("colNumeroCliente").Value.ToString()
        Me.tBCliente.Text = Me.carga.Cells("colCliente").Value.ToString()
        Me.tBDestino.Text = Me.carga.Cells("colDestino").Value.ToString()
        Me.tBCP.Text = Me.carga.Cells("colCartaPorte").Value.ToString()
        Me.cBTipoOper.SelectedItem = Me.carga.Cells("colTipoOper").Value.ToString()
        Me.tBDireccion.Text = Me.carga.Cells("colDireccion").Value.ToString()
        Me.tBObservaciones.Text = Me.carga.Cells("colObservaciones").Value.ToString()
        Me.tBContenedor.Text = Me.carga.Cells("colContenedores").Value.ToString()
        Me.rTBComentarios.Text = Me.carga.Cells("colComentarios").Value.ToString()

        If Me.carga.Cells("colCorreos").Value IsNot Nothing Then
            For Each correo As String In Me.carga.Cells("colCorreos").Value.ToString().Replace(" ", "").Split(";")

                mail = Me.dGVCorreos.Rows(Me.dGVCorreos.Rows.Add())
                mail.Cells("colCorreos").Value = correo

            Next
        Else

            Me.dGVCorreos.Rows.Add()

        End If
    End Sub

    Private Sub guardar()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim status As String
        Dim consulta As String
        Dim ubicacion As String

        status = ""
        ubicacion = ""

        Try

            consulta = "SELECT dbo.UDF_Estatus_Unidades_QSP('" & Me.tBUnidad.Text.Trim() & "')"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            dS = New DataSet()
            conexion.Open()
            status = comando.ExecuteScalar().ToString()
            conexion.Close()
            conexion.Dispose()
            status = status.Split("*")(0)

        Catch ex As Exception

            MessageBox.Show("Error al consultar el estatus: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Try

            consulta = "SELECT TOP(1) REPLACE(proximidadCiudad, ' ' + georeference + ' ', ' ' ) FROM QSP.dbo.TPosicion WHERE economico COLLATE SQL_Latin1_General_CP1_CI_AS = '" & Me.tBUnidad.Text.Trim() & "' ORDER BY fecha DESC"
            conexion = Connection.getInstance().getConnectionQSP()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            dS = New DataSet()
            conexion.Open()
            ubicacion = comando.ExecuteScalar().ToString()
            conexion.Close()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al consultar el estatus: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        If Me.opcion = 1 Then

            Dim car As DataGridViewRow
            car = Me.dGVUnidades.Rows(Me.dGVUnidades.Rows.Add())
            car.Cells("colUnidad").Value = IIf(String.IsNullOrEmpty(Me.tBUnidad.Text), "", Me.tBUnidad.Text)
            car.Cells("colOperador").Value = IIf(String.IsNullOrEmpty(Me.tBOperador.Text), "", Me.tBOperador.Text)
            car.Cells("colPlacas").Value = IIf(String.IsNullOrEmpty(Me.tBPlacas.Text), "", Me.tBPlacas.Text)
            car.Cells("colViaje").Value = IIf(String.IsNullOrEmpty(Me.tBViaje.Text), "", Me.tBViaje.Text)
            car.Cells("colNumeroCliente").Value = IIf(String.IsNullOrEmpty(Me.tBNumeroCliente.Text), "", Me.tBNumeroCliente.Text)
            car.Cells("colCliente").Value = IIf(String.IsNullOrEmpty(Me.tBCliente.Text), "", Me.tBCliente.Text)
            car.Cells("colDestino").Value = IIf(String.IsNullOrEmpty(Me.tBDestino.Text), "", Me.tBDestino.Text)
            car.Cells("colCartaPorte").Value = IIf(String.IsNullOrEmpty(Me.tBCP.Text), "", Me.tBCP.Text)
            car.Cells("colTipoOper").Value = IIf(String.IsNullOrEmpty(Me.cBTipoOper.SelectedItem.ToString()), "", Me.cBTipoOper.SelectedItem.ToString())
            car.Cells("colDireccion").Value = IIf(String.IsNullOrEmpty(Me.tBDireccion.Text), "", Me.tBDireccion.Text)
            car.Cells("colObservaciones").Value = IIf(String.IsNullOrEmpty(Me.tBObservaciones.Text), "", Me.tBObservaciones.Text)
            car.Cells("colContenedores").Value = IIf(String.IsNullOrEmpty(Me.tBContenedor.Text), "", Me.tBContenedor.Text)
            car.Cells("colComentarios").Value = IIf(String.IsNullOrEmpty(Me.rTBComentarios.Text), "", Me.rTBComentarios.Text)
            car.Cells("colStatus").Value = status
            car.Cells("colUbicacion").Value = ubicacion
            car.Cells("colCorreos").Value = ""

            For Each correo As DataGridViewRow In Me.dGVCorreos.Rows
                If correo.Cells("colCorreos").Value IsNot Nothing Then
                    If Not String.IsNullOrEmpty(correo.Cells("colCorreos").Value.ToString()) Then

                        car.Cells("colCorreos").Value += correo.Cells("colCorreos").Value.ToString() & "; "

                    Else

                        Continue For

                    End If
                End If
            Next
        ElseIf Me.opcion = 2 Then

            Me.carga.Cells("colUnidad").Value = IIf(String.IsNullOrEmpty(Me.tBUnidad.Text), "", Me.tBUnidad.Text)
            Me.carga.Cells("colOperador").Value = IIf(String.IsNullOrEmpty(Me.tBOperador.Text), "", Me.tBOperador.Text)
            Me.carga.Cells("colPlacas").Value = IIf(String.IsNullOrEmpty(Me.tBPlacas.Text), "", Me.tBPlacas.Text)
            Me.carga.Cells("colViaje").Value = IIf(String.IsNullOrEmpty(Me.tBViaje.Text), "", Me.tBViaje.Text)
            Me.carga.Cells("colNumeroCliente").Value = IIf(String.IsNullOrEmpty(Me.tBNumeroCliente.Text), "", Me.tBNumeroCliente.Text)
            Me.carga.Cells("colCliente").Value = IIf(String.IsNullOrEmpty(Me.tBCliente.Text), "", Me.tBCliente.Text)
            Me.carga.Cells("colDestino").Value = IIf(String.IsNullOrEmpty(Me.tBDestino.Text), "", Me.tBDestino.Text)
            Me.carga.Cells("colCartaPorte").Value = IIf(String.IsNullOrEmpty(Me.tBCP.Text), "", Me.tBCP.Text)
            Me.carga.Cells("colTipoOper").Value = IIf(String.IsNullOrEmpty(Me.cBTipoOper.SelectedItem.ToString()), "", Me.cBTipoOper.SelectedItem.ToString())
            Me.carga.Cells("colDireccion").Value = IIf(String.IsNullOrEmpty(Me.tBDireccion.Text), "", Me.tBDireccion.Text)
            Me.carga.Cells("colObservaciones").Value = IIf(String.IsNullOrEmpty(Me.tBObservaciones.Text), "", Me.tBObservaciones.Text)
            Me.carga.Cells("colContenedores").Value = IIf(String.IsNullOrEmpty(Me.tBContenedor.Text), "", Me.tBContenedor.Text)
            Me.carga.Cells("colComentarios").Value = IIf(String.IsNullOrEmpty(Me.rTBComentarios.Text), "", Me.rTBComentarios.Text)
            Me.carga.Cells("colStatus").Value = status
            Me.carga.Cells("colUbicacion").Value = ubicacion
            Me.carga.Cells("colCorreos").Value = ""

            For Each correo As DataGridViewRow In Me.dGVCorreos.Rows

                Me.carga.Cells("colCorreos").Value += correo.Cells("colCorreos").Value.ToString() & "; "

            Next
        End If
    End Sub

    Private Sub resultadosDeBusquedaOperadores()

        Dim autoCompletado = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre FROM personal_personal WHERE estado='A' and tipo_empleado='O'"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.tBOperador.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.tBOperador.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.tBOperador.AutoCompleteCustomSource = autoCompletado

    End Sub
End Class