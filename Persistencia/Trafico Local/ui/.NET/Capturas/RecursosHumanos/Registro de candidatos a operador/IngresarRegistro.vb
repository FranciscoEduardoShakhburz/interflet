Imports System.Data
Imports System.Data.SqlClient

Public Class IngresarRegistro

    Private rfc As String
    Private nombre As String
    Private modoEdicion As Boolean
    Private registro As RegistroCandidatos

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.modoEdicion = False

    End Sub

    Public Sub New(ByVal rfc As String, ByVal nombre As String, ByRef registro As RegistroCandidatos)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.rfc = rfc
        Me.nombre = nombre
        Me.modoEdicion = True
        Me.registro = registro

    End Sub

    Public Sub New(ByRef registro As RegistroCandidatos)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.modoEdicion = False
        Me.registro = registro

    End Sub

    Private Sub IngresarRegistro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cmbPuesto.SelectedIndex = 0
        Me.cmbTipoOp.SelectedIndex = 0
        Me.cmbModalidad.SelectedIndex = 0
        Me.cmbEstatus.SelectedIndex = 0
        Me.resultadosDeBusqueda()

        If Me.modoEdicion Then

            Me.consultarRegistro()

        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Me.camposValidos() Then

            Me.guardarRegistro()
            Me.registro.checarTipoBusqueda()
            Me.Close()

        End If
    End Sub

    Private Sub txtNombre_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.Enter, txtTelefono2.Enter, txtTelefono1.Enter, txtRFC.Enter, txtRecomendado.Enter

        Me.quitarAdvertencias()

    End Sub

    Private Sub cmbPuesto_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPuesto.SelectionChangeCommitted

        If Not cmbPuesto.SelectedIndex = 0 Then

            Me.cmbTipoOp.Visible = False
            Me.cmbModalidad.Visible = False
            Me.Label10.Visible = False
            Me.Label11.Visible = False

        Else

            Me.cmbTipoOp.Visible = True
            Me.cmbModalidad.Visible = True
            Me.Label10.Visible = True
            Me.Label11.Visible = True

        End If
    End Sub

    Private Sub dteFechaNac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteFechaNac.ValueChanged

        Me.txtEdad.Text = Me.edad(Me.dteFechaNac.Value)

    End Sub

    Private Sub consultarRegistro()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_Consulta_RegistroCandidatos", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@tipoConsulta", 5)
                .AddWithValue("@fechaInicial", DateTime.Now)
                .AddWithValue("@fechaFinal", DateTime.Now)
                .AddWithValue("@nombre", Me.nombre)
                .AddWithValue("@estatus", "")
                .AddWithValue("@rfc", Me.rfc)

            End With

            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            comando.Dispose()
            conexion.Close()
            conexion.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Me.dteFecha.Value = Convert.ToDateTime(dS.Tables(0).Rows(0)("Fecha").ToString())
                    Me.txtNombre.Text = dS.Tables(0).Rows(0)("Nombre").ToString()
                    Me.dteFechaNac.Value = Convert.ToDateTime(dS.Tables(0).Rows(0)("Fecha de nacimiento").ToString())
                    Me.txtEdad.Text = Me.edad(Convert.ToDateTime(dS.Tables(0).Rows(0)("Fecha de nacimiento").ToString()))
                    Me.txtRFC.Text = dS.Tables(0).Rows(0)("R.F.C.").ToString()
                    Me.txtTelefono1.Text = dS.Tables(0).Rows(0)("Teléfono 1").ToString()
                    Me.txtTelefono2.Text = dS.Tables(0).Rows(0)("Teléfono 2").ToString()
                    Me.txtRecomendado.Text = dS.Tables(0).Rows(0)("Recomendado por").ToString()
                    Me.txtTipoLic.Text = dS.Tables(0).Rows(0)("Tipo de licencia").ToString()
                    Me.cmbPuesto.SelectedItem = dS.Tables(0).Rows(0)("Puesto").ToString()
                    Me.cmbTipoOp.SelectedItem = dS.Tables(0).Rows(0)("Tipo de operador").ToString()
                    Me.cmbModalidad.SelectedItem = dS.Tables(0).Rows(0)("Modalidad").ToString()
                    Me.cmbEstatus.SelectedItem = dS.Tables(0).Rows(0)("Estatus").ToString()
                    Me.txtObservaciones.Text = dS.Tables(0).Rows(0)("Observaciones").ToString()

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub guardarRegistro()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim fechaRegistro As DateTime
        Dim id As Integer = 0

        Dim consulta As String

        Try
            If Not Me.modoEdicion Then

                conexion = Connection.getInstance().getConnection()
                consulta = "SELECT COUNT(*) FROM RH_Registro_Candidatos_Detalle WHERE nombre = '" & Me.nombre & "' AND rfc = '" & Me.rfc & "'"
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()

                If Convert.ToInt32(comando.ExecuteScalar()) > 0 Then

                    conexion.Close()
                    conexion.Dispose()
                    comando.Dispose()
                    MessageBox.Show("El candidato que desea ingresar ya se existe en el sistema. Favor de realizar la consulta para verificar sus datos.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub

                End If

                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand("up_RegistroCandidatos_Insert", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandTimeout = 600
                conexion.Open()
                comando.ExecuteNonQuery()
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()
                fechaRegistro = DateTime.Now

            Else

                conexion = Connection.getInstance().getConnection()
                consulta = "SELECT enc.fechaRegistro, det.id FROM RH_Registro_Candidatos enc LEFT JOIN RH_Registro_Candidatos_Detalle det ON det.idRegistro = enc.id WHERE det.nombre = '" & Me.nombre & "' AND det.rfc = '" & Me.rfc & "'"
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                sDA = New SqlDataAdapter(comando)
                dS = New DataSet()
                sDA.Fill(dS)

                If dS.Tables.Count > 0 Then
                    If dS.Tables(0).Rows.Count > 0 Then

                        fechaRegistro = Convert.ToDateTime(dS.Tables(0).Rows(0)(0).ToString())
                        id = Convert.ToInt32(dS.Tables(0).Rows(0)(1).ToString())

                    End If
                End If
            End If

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("up_RegistroCandidatos_Detalle_Insert", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@fechaRegistro", fechaRegistro)
                .AddWithValue("@idPartida", id)
                .AddWithValue("@nombre", Me.txtNombre.Text)
                .AddWithValue("@fechaNacimiento", Me.dteFechaNac.Value.Date)
                .AddWithValue("@rfc", Me.txtRFC.Text)
                .AddWithValue("@telefono1", Me.txtTelefono1.Text)
                .AddWithValue("@telefono2", Me.txtTelefono2.Text)
                .AddWithValue("@recomendadoPor", Me.txtRecomendado.Text)
                .AddWithValue("@tipoLicencia", Me.txtTipoLic.Text)
                .AddWithValue("@puesto", Me.cmbPuesto.SelectedItem)
                .AddWithValue("@tipoOperador", IIf(Me.cmbPuesto.SelectedIndex = 0, Me.cmbTipoOp.SelectedItem, ""))
                .AddWithValue("@modalidad", IIf(Me.cmbPuesto.SelectedIndex = 0, Me.cmbModalidad.SelectedItem, ""))
                .AddWithValue("@estatus", Me.cmbEstatus.SelectedItem)
                .AddWithValue("@observaciones", Me.txtObservaciones.Text)

            End With

            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
            MessageBox.Show("El registro se guardó correctamente", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            MessageBox.Show("Error al guardar el registro: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub quitarAdvertencias()

        Me.txtNombre.BackColor = Color.White
        Me.txtEdad.BackColor = Color.White
        Me.txtRFC.BackColor = Color.White
        Me.txtTelefono1.BackColor = Color.White
        Me.txtTelefono2.BackColor = Color.White
        Me.txtRecomendado.BackColor = Color.White

    End Sub

    Private Sub resultadosDeBusqueda()

        Dim autoCompletado As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        conexion = Connection.getInstance().getConnection()
        conexion.Open()
        sql = "SELECT nombre FROM personal_personal"
        comando = New SqlCommand(sql, conexion)
        comando.CommandType = CommandType.Text
        comando.CommandTimeout = 1000
        sDA = New SqlDataAdapter(comando)
        dS = New DataSet()
        sDA.Fill(dS)

        For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

            autoCompletado.Add(dS.Tables(0).Rows(i)(0).ToString())

        Next

        Me.txtRecomendado.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtRecomendado.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtRecomendado.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Function camposValidos() As Boolean

        Dim camposVal As Boolean
        Dim cadena As Char()

        camposVal = True
        cadena = Me.txtNombre.Text.ToCharArray()

        If String.IsNullOrEmpty(cadena) Then

            Me.txtNombre.BackColor = Color.Red
            camposVal = False
            MessageBox.Show("El campo del nombre no puede estar vacío.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If


        If String.IsNullOrEmpty(Me.txtEdad.Text) Then

            Me.txtEdad.BackColor = Color.Red
            camposVal = False
            MessageBox.Show("Ingrese la edad del candidato.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Function

        End If

        If Convert.ToInt16(Me.txtEdad.Text) < 18 Then

            Me.txtEdad.BackColor = Color.Red
            camposVal = False
            MessageBox.Show("La edad no es válida. El candidato debe tener 18 años o más.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Function

        End If

        For Each caracter As Char In cadena
            If Char.IsDigit(caracter) Then

                Me.txtNombre.BackColor = Color.Red
                camposVal = False
                MessageBox.Show("El nombre no es válido. Asegúrese de que el nombre no contenga números o caracteres especiales.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function

            End If
        Next

        If Not String.IsNullOrEmpty(Me.txtRFC.Text) Then
            If Me.txtRFC.Text.Contains(" ") Or Me.txtRFC.Text.Length < 12 Or Me.txtRFC.Text.Length > 13 Then

                Me.txtRFC.BackColor = Color.Red
                camposVal = False
                MessageBox.Show("El RFC no es válido. Asegúrese de escribir todos los caracteres del R.F.C.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function

            End If
        End If

        If Not String.IsNullOrEmpty(Me.txtTelefono1.Text) Then

            cadena = Me.txtTelefono1.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToCharArray()

            For Each caracter As Char In cadena
                If Not Char.IsDigit(caracter) Then

                    Me.txtTelefono1.BackColor = Color.Red
                    camposVal = False
                    MessageBox.Show("El teléfono 1 no es válido. Los caracteres permitidos son: 0-9, (, ) y -.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Function

                End If
            Next
        End If

        If Not String.IsNullOrEmpty(Me.txtTelefono2.Text) Then

            cadena = Me.txtTelefono2.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToCharArray()

            For Each caracter As Char In cadena
                If Not Char.IsDigit(caracter) Then

                    Me.txtTelefono2.BackColor = Color.Red
                    camposVal = False
                    MessageBox.Show("El teléfono 2 no es válido. Los caracteres permitidos son: 0-9, (, ) y -.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Function

                End If
            Next
        End If

        cadena = Me.txtRecomendado.Text.ToCharArray()

        For Each caracter As Char In cadena
            If Char.IsDigit(caracter) Then

                Me.txtRecomendado.BackColor = Color.Red
                camposVal = False
                MessageBox.Show("El nombre no es válido. Asegúrese de que el nombre no contenga números o caracteres especiales.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function

            End If
        Next

        Return camposVal

    End Function

    Private Function edad(ByVal fecha As DateTime) As String

        Dim ts As TimeSpan = DateTime.Now.Subtract(fecha)
        Return ((ts.Days / 365) & "").Split(".")(0)

    End Function

    Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown, txtTipoLic.KeyDown, txtTelefono2.KeyDown, txtTelefono1.KeyDown, txtRFC.KeyDown, txtRecomendado.KeyDown, txtObservaciones.KeyDown, txtEdad.KeyDown, dteFechaNac.KeyDown, cmbTipoOp.KeyDown, cmbPuesto.KeyDown, cmbModalidad.KeyDown, cmbEstatus.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub
End Class