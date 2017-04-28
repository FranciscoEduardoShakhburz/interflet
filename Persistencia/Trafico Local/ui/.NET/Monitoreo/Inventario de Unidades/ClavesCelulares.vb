Imports System.Data
Imports System.Data.SqlClient

Public Class ClavesCelulares

    Private guardado As Boolean

    Private Sub ClavesCelulares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.consultarClavesCelulares()
        Me.btnGuardar.Enabled = False
        Me.cmbTipo.SelectedIndex = 0
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub consultarClavesCelulares()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim dA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        Try

            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            sql = "SELECT Unidad, Clave, numero AS [Número] FROM trafico_claves_celular ORDER BY Unidad"
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            dA = New SqlDataAdapter(comando)
            dS = New DataSet()
            dA.Fill(dS)
            Me.gridCelulares.DataSource = dS.Tables(0)

        Catch ex As Exception

            MessageBox.Show("El catálogo de celulares no se pudo cargar debido al siguiente problema: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        If Me.guardado = False Then

            Dim res As DialogResult = MessageBox.Show("No se han guardado los cambios en el catálogo, ¿desea salir de la aplicación?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If res = DialogResult.Yes Then

                Me.Dispose()

            Else

                Return

            End If
        Else

            Me.Dispose()

        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor.Current = Cursors.WaitCursor
        Excel.gridToExcel(Me.gridCelulares)
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Try
            If Me.datosValidos() Then
                For Each fila As DataGridViewRow In Me.gridCelulares.Rows
                    If fila.Cells(0).Value IsNot Nothing Then

                        conexion = Connection.getInstance().getConnection()
                        conexion.Open()
                        comando = New SqlCommand("up_claves_celulares_insert", conexion)

                        With comando.Parameters

                            .AddWithValue("@unidad", fila.Cells(0).Value.ToString().ToUpper())
                            .AddWithValue("@clave", fila.Cells(1).Value.ToString().ToUpper())
                            .AddWithValue("@numero", fila.Cells(2).Value.ToString().ToUpper())

                        End With

                        comando.CommandType = CommandType.StoredProcedure
                        comando.CommandTimeout = 1000
                        comando.ExecuteNonQuery()
                        comando.Dispose()
                        conexion.Dispose()
                        conexion.Close()

                    End If
                Next

                Me.guardado = True
                MessageBox.Show("Los cambios se han guardado correctamente", "¡Guardado correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("No se pudo guardar el catálogo debido a que la unidad y/o la clave y/o el numero de teléfono están repetidos", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Catch ex As Exception

            MessageBox.Show("No se pudo guardar el catálogo debido al siguiente error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function datosValidos() As Boolean

        For index As Integer = 0 To Me.gridCelulares.Rows.Count - 2
            If Me.gridCelulares.Rows(index).Cells(0).Value Is Nothing Then

                Me.gridCelulares.Rows(index).DefaultCellStyle.BackColor = Color.Red
                Return False

            End If
        Next

        For index As Integer = 0 To Me.gridCelulares.Rows.Count - 3
            For index1 As Integer = index + 1 To Me.gridCelulares.Rows.Count - 2
                If Not Me.gridCelulares.Rows(index).Cells(0).Value.ToString().Equals("N/A") Then
                    If Me.gridCelulares.Rows(index).Cells(0).Value.ToString().Replace("-", "").Replace(" ", "").ToUpper().Equals(Me.gridCelulares.Rows(index1).Cells(0).Value.ToString().Replace("-", "").Replace(" ", "").ToUpper()) Then

                        Me.gridCelulares.Rows(index).DefaultCellStyle.BackColor = Color.Red
                        Me.gridCelulares.Rows(index1).DefaultCellStyle.BackColor = Color.Red
                        Return False

                    End If
                End If
            Next
        Next

        For index As Integer = 0 To Me.gridCelulares.Rows.Count - 3
            For index1 As Integer = index + 1 To Me.gridCelulares.Rows.Count - 2
                If Not Me.gridCelulares.Rows(index).Cells(0).Value.ToString().Equals("N/A") Then
                    If Me.gridCelulares.Rows(index).Cells(1).Value.ToString().Equals(Me.gridCelulares.Rows(index1).Cells(1).Value.ToString()) Then

                        Me.gridCelulares.Rows(index).DefaultCellStyle.BackColor = Color.Red
                        Me.gridCelulares.Rows(index1).DefaultCellStyle.BackColor = Color.Red
                        Return False

                    End If
                End If
            Next
        Next

        For index As Integer = 0 To Me.gridCelulares.Rows.Count - 3
            For index1 As Integer = index + 1 To Me.gridCelulares.Rows.Count - 2
                If Not Me.gridCelulares.Rows(index).Cells(0).Value.ToString().Equals("N/A") Then
                    If Me.gridCelulares.Rows(index).Cells(2).Value.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToUpper().Equals(Me.gridCelulares.Rows(index1).Cells(2).Value.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToUpper()) Then

                        Me.gridCelulares.Rows(index).DefaultCellStyle.BackColor = Color.Red
                        Me.gridCelulares.Rows(index1).DefaultCellStyle.BackColor = Color.Red
                        Return False

                    End If
                End If
            Next
        Next

        Return True

    End Function

    Private Sub gridCelulares_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles gridCelulares.CellFormatting

        If e.Value IsNot Nothing Then

            e.Value = e.Value.ToString().ToUpper()
            e.FormattingApplied = True

        End If
    End Sub

    Private Sub gridCelulares_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles gridCelulares.CellBeginEdit

        Me.btnGuardar.Enabled = True
        Me.guardado = False

        For Each fila As DataGridViewRow In Me.gridCelulares.Rows

            fila.DefaultCellStyle.BackColor = Color.White

        Next
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim sql As String

        If Me.txtBusqueda.Text.Equals("") Then

            sql = "SELECT Unidad, Clave, numero AS [Número] FROM trafico_claves_celular ORDER BY Unidad"

        ElseIf Me.cmbTipo.SelectedIndex = 0 Then

            sql = "SELECT Unidad, Clave, numero AS [Número] FROM trafico_claves_celular WHERE unidad like '%" & Me.txtBusqueda.Text.ToUpper() & "%' ORDER BY Unidad"

        ElseIf Me.cmbTipo.SelectedIndex = 1 Then

            sql = "SELECT Unidad, Clave, numero AS [Número] FROM trafico_claves_celular WHERE clave like '%" & Me.txtBusqueda.Text.ToUpper() & "%' ORDER BY Unidad"

        ElseIf Me.cmbTipo.SelectedIndex = 2 Then

            sql = "SELECT Unidad, Clave, numero AS [Número] FROM trafico_claves_celular WHERE replace(replace(replace(replace(numero, '-', ''), '(', ''), ')', ''), ' ', '') LIKE '%" & Me.txtBusqueda.Text.ToUpper().Replace("-", "").Replace("(", "").Replace(")", "") & "%' ORDER BY Unidad"

        End If

        Try

            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            sDA = New SqlDataAdapter(comando)
            dS = New DataSet()
            sDA.Fill(dS)
            Me.gridCelulares.DataSource = dS.Tables(0)
            conexion.Close()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click

        Dim res As DialogResult = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "¡Confirmar acción!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If res = DialogResult.Yes Then
            Try
                For index As Integer = 0 To Me.gridCelulares.SelectedRows.Count - 1

                    Dim sql As String = "DELETE FROM trafico_claves_celular WHERE unidad = '" & Me.gridCelulares.SelectedRows(index).Cells(0).Value.ToString() & "' AND clave = '" & Me.gridCelulares.SelectedRows(index).Cells(1).Value.ToString() & "'"
                    Dim conexion As SqlConnection
                    Dim comando As SqlCommand
                    conexion = Connection.getInstance().getConnection()
                    conexion.Open()
                    comando = New SqlCommand(sql, conexion)
                    comando.CommandType = CommandType.Text
                    comando.CommandTimeout = 1000
                    comando.ExecuteNonQuery()
                    conexion.Close()
                    conexion.Dispose()
                    Me.gridCelulares.Rows.Remove(Me.gridCelulares.SelectedRows(index))

                Next
            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        Else

            Return

        End If
    End Sub
End Class