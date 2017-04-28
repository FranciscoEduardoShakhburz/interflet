Imports System.Data.SqlClient


Public Class formIngresoEIR

    Public idTerminal As Integer
    Public idAgencia As Integer
    Public fechaActual As String


    Private Sub formIngresoEIR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.AppStarting
        Me.getServicios()
        Me.getEIR()
        Me.llenarComboAgencias()
        Me.llenarComboTerminales()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim folio As String = Me.txtFolio.Text.Trim
        Dim contenedor As String = Me.txtContenedor.Text.Trim
        Dim terminal As String = Me.cmbTerminales.SelectedValue.ToString
        Dim agenciaAduanal As String = Me.cmbAgencias.SelectedValue.ToString

        If String.IsNullOrEmpty(folio) OrElse String.IsNullOrEmpty(contenedor) _
           OrElse String.IsNullOrEmpty(terminal) _
           OrElse String.IsNullOrEmpty(agenciaAduanal) Then

            MessageBox.Show("Todos los campos son obligatorios")
        Else
            If (StringValidator.isContainer(contenedor)) Then
                Dim conn As SqlConnection = Connection.getInstance.getConnection()
                Dim command As SqlCommand = New SqlCommand("UP_GUARDA_LOCAL_EIR", conn)
                command.CommandType = CommandType.StoredProcedure

                If Not Me.labelFolioInterno.Text = "10000000000" Then
                    command.Parameters.AddWithValue("@ID", Me.labelFolioInterno.Text)
                End If
                command.Parameters.AddWithValue("@FECHA_EIR", Me.dateFechaEIR.Value)
                command.Parameters.AddWithValue("@FECHA_ENTREGA_AA", Me.dateFechaEntregaAA.Value)
                command.Parameters.AddWithValue("@FOLIO_EIR", folio)
                command.Parameters.AddWithValue("@CONTENEDOR", contenedor)
                command.Parameters.AddWithValue("@TERMINAL", terminal)
                command.Parameters.AddWithValue("@AGENCIA_ADUANAL", agenciaAduanal)
                command.Parameters.AddWithValue("@SERVICIO", Me.cmbServicio.SelectedItem.ToString())
                conn.Open()
                command.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()
                Me.getEIR()
                Me.limpiar()
            Else
                MessageBox.Show("El contenedor no es válido")
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub getServicios()
        Me.cmbServicio.Items.Add("IMPO VACÍO")
        Me.cmbServicio.Items.Add("IMPO LLENO")
        Me.cmbServicio.Items.Add("EXPO VACÍO")
        Me.cmbServicio.Items.Add("EXPO LLENO")
        Me.cmbServicio.SelectedIndex = 0
    End Sub

    Private Sub getEIR()
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_LOCALES_EIR", conn)
        command.CommandType = CommandType.StoredProcedure
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridEIR.DataSource = table
        conn.Close()
        conn.Dispose()
        command.Dispose()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub getEIR(ByVal contenedor As String)
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim command As SqlCommand = New SqlCommand("UP_CONSULTA_LOCALES_EIR", conn)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@CONTENEDOR", Me.txtBusquedaContenedor.Text.Trim)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        Me.gridEIR.DataSource = table
        conn.Close()
        conn.Dispose()
        command.Dispose()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub txtTerminal_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Tab Then

            Dim terminal As String = Me.cmbTerminales.SelectedItem.ToString

            If Not String.IsNullOrEmpty(terminal) AndAlso Integer.TryParse(terminal, 0) Then

                Dim conn As SqlConnection = Connection.getInstance().getConnection()
                Dim sql As String = "SELECT ID_TERMINAL FROM TRAFICO_LOCAL_TERMINAL WHERE ID_TERMINAL = @NOMBRE_TERMINAL"
                Dim command As SqlCommand = New SqlCommand(sql, conn)
                conn.Open()
                command.Parameters.AddWithValue("@NOMBRE_TERMINAL", terminal)
                'Me.idTerminal = Convert.ToInt32(terminal)
                'Me.txtTerminal.Text = command.ExecuteScalar().ToString()
                Me.cmbTerminales.SelectedValue = Convert.ToInt32(command.ExecuteScalar().ToString())
                Me.idTerminal = Me.cmbTerminales.SelectedIndex
                conn.Close()
                conn.Dispose()
                command.Dispose()

            End If
        End If
    End Sub

    Private Sub txtAgenciaAduanal_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Tab Then

            Dim agenciaAduanal As String = Me.cmbAgencias.SelectedItem.ToString

            If Not String.IsNullOrEmpty(agenciaAduanal) AndAlso Integer.TryParse(agenciaAduanal, 0) Then

                Dim conn As SqlConnection = Connection.getInstance().getConnection()
                Dim sql As String = "SELECT ID_AGENCIA_ADUANAL FROM TRAFICO_LOCAL_AGENCIA_ADUANAL WHERE NOMBRE_AGENCIA_ADUANAL = @NOMBRE_AGENCIA"
                Dim command As SqlCommand = New SqlCommand(sql, conn)
                conn.Open()
                command.Parameters.AddWithValue("@NOMBRE_AGENCIA", agenciaAduanal)
                'Me.idAgencia = Convert.ToInt32(agenciaAduanal)
                'Me.txtAgenciaAduanal.Text = command.ExecuteScalar().ToString()
                Me.cmbAgencias.SelectedValue = Convert.ToInt32(command.ExecuteScalar().ToString())
                Me.idAgencia = Me.cmbAgencias.SelectedIndex
                conn.Close()
                conn.Dispose()
                command.Dispose()

            End If
        End If
    End Sub

    Private Sub limpiar()
        Me.txtFolio.Text = ""
        Me.txtContenedor.Text = ""
        'Me.txtTerminal.Text = ""
        'Me.txtAgenciaAduanal.Text = ""
        Me.llenarComboAgencias()
        Me.llenarComboTerminales()
        Me.labelFolioInterno.Text = "10000000000"
        Me.dateFechaEIR.Focus()
    End Sub

    Private Sub txtContenedor_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContenedor.DoubleClick
        Me.showContenedores()
    End Sub

    Private Sub txtContenedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContenedor.KeyDown
        If e.KeyCode = Keys.F2 Then

            Me.showContenedores()

        End If
    End Sub

    Private Sub showContenedores()

        Me.fechaActual = Me.dateFechaEIR.Value.ToString("dd/MM/yyyy")
        formContenedores.Show()

    End Sub

    Private Sub txtAgenciaAduanal_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim agencia As formAgenciaAduanal = New formAgenciaAduanal("BUSCAR")
        agencia.Show()

    End Sub

    Private Sub txtTerminal_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim terminal As formTerminales = New formTerminales("BUSCAR")
        terminal.Show()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim contenedor As String = Me.txtBusquedaContenedor.Text.Trim
        If Not String.IsNullOrEmpty(contenedor) Then

            Me.getEIR(contenedor)
            limpiar()

        Else

            Me.getEIR()

        End If
    End Sub

    Private Sub gridEIR_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridEIR.DoubleClick
        If Not String.IsNullOrEmpty(Me.txtBusquedaContenedor.Text) AndAlso Me.gridEIR.Rows.Count > 0 Then
            Me.labelFolioInterno.Text = Me.gridEIR.CurrentRow.Cells("ID").Value.ToString()
            Me.dateFechaEntregaAA.Value = Me.gridEIR.CurrentRow.Cells("FECHA DE ENTREGA").Value.ToString()
            Me.dateFechaEIR.Value = Me.gridEIR.CurrentRow.Cells("FECHA EIR").Value.ToString()
            Me.txtFolio.Text = Me.gridEIR.CurrentRow.Cells("FOLIO").Value.ToString()
            Me.txtContenedor.Text = Me.gridEIR.CurrentRow.Cells("CONTENEDOR").Value.ToString()
            'Me.txtTerminal.Text = Me.gridEIR.CurrentRow.Cells("TERMINAL").Value.ToString()
            'Me.txtAgenciaAduanal.Text = Me.gridEIR.CurrentRow.Cells("AGENCIA ADUANAL").Value.ToString()

            'FIJAMOS LA AGENCIA DEL CONTENEDOR SELECCIONADO EN EL COMBOBOX DE AGENCIAS

            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim sql As String = "SELECT ID_AGENCIA_ADUANAL FROM TRAFICO_LOCAL_AGENCIA_ADUANAL WHERE NOMBRE_AGENCIA_ADUANAL = @NOMBRE_AGENCIA"
            Dim command As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim agenciaAduanal As String = Me.gridEIR.CurrentRow.Cells("AGENCIA ADUANAL").Value.ToString()
            command.Parameters.AddWithValue("@NOMBRE_AGENCIA", agenciaAduanal)
            Me.cmbAgencias.SelectedValue = Convert.ToInt32(command.ExecuteScalar().ToString())
            Me.idAgencia = cmbAgencias.SelectedIndex 'Convert.ToInt32(agenciaAduanal)
            conn.Close()
            conn.Dispose()
            command.Dispose()

            'FIJAMOS LA TERMINAL DEL CONTENEDOR SELECCIONADO EN EL COMBOBOX DE TERMINALES

            sql = "SELECT ID_TERMINAL FROM TRAFICO_LOCAL_TERMINAL WHERE NOMBRE_TERMINAL = @NOMBRE_TERMINAL"
            Dim conn2 As SqlConnection = Connection.getInstance().getConnection()
            command = New SqlCommand(sql, conn2)
            conn2.Open()
            Dim terminal As String = Me.gridEIR.CurrentRow.Cells("TERMINAL").Value.ToString()
            command.Parameters.AddWithValue("@NOMBRE_TERMINAL", terminal)
            Me.cmbTerminales.SelectedValue = Convert.ToInt32(command.ExecuteScalar().ToString())
            Me.idTerminal = cmbTerminales.SelectedIndex 'Convert.ToInt32(agenciaAduanal)
            conn2.Close()
            conn2.Dispose()
            command.Dispose()

            Dim servicio As String = Me.gridEIR.CurrentRow.Cells("SERVICIO").Value.ToString()
            If servicio = "IMPO VACÍO" Then

                Me.cmbServicio.SelectedIndex = 0

            ElseIf servicio = "IMPO LLENO" Then

                Me.cmbServicio.SelectedIndex = 1

            ElseIf servicio = "EXPO VACÍO" Then

                Me.cmbServicio.SelectedIndex = 2

            Else

                Me.cmbServicio.SelectedIndex = 3

            End If

            Me.idTerminal = Me.gridEIR.CurrentRow.Cells("ID TERMINAL").Value.ToString()
            Me.idAgencia = Me.gridEIR.CurrentRow.Cells("ID AGENCIA ADUANAL").Value.ToString()
            Me.txtBusquedaContenedor.Text = ""

        End If
    End Sub

    Private Sub llenarComboAgencias()

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT id_agencia_aduanal, nombre_agencia_aduanal FROM TRAFICO_LOCAL_AGENCIA_ADUANAL WHERE ELIMINADO = 0 ORDER BY nombre_agencia_aduanal"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        conn.Open()
        Dim adapter As SqlDataReader = command.ExecuteReader
        Dim table As DataTable = New DataTable()
        table.Load(adapter)
        cmbAgencias.ValueMember = "id_agencia_aduanal"
        cmbAgencias.DisplayMember = "nombre_agencia_aduanal"
        cmbAgencias.DataSource = table
        conn.Close()
        
    End Sub

    Private Sub llenarComboTerminales()

        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Dim sql As String = "SELECT id_terminal, nombre_terminal FROM TRAFICO_LOCAL_TERMINAL WHERE ELIMINADO = 0 ORDER BY nombre_terminal"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        conn.Open()
        Dim adapter As SqlDataReader = command.ExecuteReader
        Dim table As DataTable = New DataTable()
        table.Load(adapter)
        cmbTerminales.ValueMember = "id_terminal"
        cmbTerminales.DisplayMember = "nombre_terminal"
        cmbTerminales.DataSource = table
        conn.Close()
        
    End Sub

    Private Sub cmbTerminales_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTerminales.KeyUp

        Me.AutoCompleteCombo_KeyUp(Me.cmbTerminales, e)

        If Not IsNothing(Me.cmbTerminales.SelectedValue) Then

            Me.txtIdTerminal.Text = Me.cmbTerminales.SelectedValue.ToString()

        End If
    End Sub

    Private Sub cmbAgencias_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAgencias.KeyUp

        Me.AutoCompleteCombo_KeyUp(Me.cmbAgencias, e)

        If Not IsNothing(Me.cmbAgencias.SelectedValue) Then

            Me.txtIdAgencia.Text = Me.cmbAgencias.SelectedValue.ToString()

        End If
    End Sub

    Public Sub AutoCompleteCombo_KeyUp(ByVal cbo As ComboBox, ByVal e As KeyEventArgs)

        Dim sTypedText As String
        Dim iFoundIndex As Integer
        Dim oFoundItem As Object
        Dim sFoundText As String
        Dim sAppendText As String

        'Allow select keys without Autocompleting
        Select Case e.KeyCode
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down, Keys.End, Keys.Shift, Keys.Home, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey, Keys.ControlKey, Keys.RControlKey, Keys.LControlKey

                Return

        End Select

        'Get the Typed Text and Find it in the list
        sTypedText = cbo.Text
        iFoundIndex = cbo.FindString(sTypedText)

        'If we found the Typed Text in the list then Autocomplete
        If iFoundIndex >= 0 Then

            'Get the Item from the list (Return Type depends if Datasource was bound 
            ' or List Created)
            oFoundItem = cbo.Items(iFoundIndex)
            'Use the ListControl.GetItemText to resolve the Name in case the Combo 
            ' was Data bound
            sFoundText = cbo.GetItemText(oFoundItem)
            'Append then found text to the typed text to preserve case
            sAppendText = sFoundText.Substring(sTypedText.Length)
            cbo.Text = sTypedText & sAppendText
            'Select the Appended Text
            cbo.SelectionStart = sTypedText.Length
            cbo.SelectionLength = sAppendText.Length

        End If
    End Sub

    Private Sub txtIdTerminal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdTerminal.KeyPress

        If Convert.ToInt32(e.KeyChar) = Keys.Enter Then
            If Not String.IsNullOrEmpty(Me.txtIdTerminal.Text) Then
                If Not IsNumeric(Me.txtIdTerminal.Text) Then

                    MessageBox.Show("Sólo se admiten números")
                    Me.txtIdTerminal.Text = ""

                ElseIf esta(Convert.ToInt32(Me.txtIdTerminal.Text), 1) Then

                    Me.cmbTerminales.SelectedValue = Convert.ToInt32(Me.txtIdTerminal.Text)

                Else

                    MessageBox.Show("No existe el identificador")

                End If
            End If
        End If
    End Sub

    Private Sub cmbAgencias_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


    End Sub

    Private Function esta(ByVal indice As Int32, ByVal combo As Int32) As Boolean

        If combo = 1 Then
            For index As Integer = 0 To Me.cmbTerminales.Items.Count - 1
                If indice = Convert.ToInt32(Me.cmbTerminales.Items.Item(index).row.itemarray(0)) Then

                    Return True
                    Exit Function

                End If
            Next
        Else
            For index As Integer = 0 To Me.cmbAgencias.Items.Count - 1
                If indice = Convert.ToInt32(Me.cmbAgencias.Items.Item(index).row.itemarray(0)) Then

                    Return True
                    Exit Function

                End If
            Next
        End If

        Return False

    End Function

    Private Sub cmbTerminales_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTerminales.SelectionChangeCommitted

        Me.txtIdTerminal.Text = Me.cmbTerminales.SelectedValue.ToString()

    End Sub

    Private Sub txtIdAgencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdAgencia.KeyPress

        If Convert.ToInt32(e.KeyChar) = Keys.Enter Then

            If Not String.IsNullOrEmpty(Me.txtIdAgencia.Text) Then
                If Not IsNumeric(Me.txtIdAgencia.Text) Then

                    MessageBox.Show("Sólo se admiten números")
                    Me.txtIdAgencia.Text = ""

                ElseIf esta(Convert.ToInt32(Me.txtIdAgencia.Text), 2) Then

                    Me.cmbAgencias.SelectedValue = Convert.ToInt32(Me.txtIdAgencia.Text)

                Else

                    MessageBox.Show("No existe el identificador")

                End If
            End If
        End If
    End Sub
End Class