Imports System.Data
Imports System.Data.SqlClient

Public Class AnticiposEspeciales

    Private Sub AnticiposEspeciales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.txtNoViaje.Text = "0"
        Me.cmBArea.SelectedIndex = 0
        Me.txtNombre.Text = ""
        Me.txtTransferencia.Text = "0.00"
        Me.txtDiesel1.Text = "0.00"
        Me.txtDiesel2.Text = "0.00"
        Me.txtTotal.Text = "0.00"
        Me.txtSaldoComprobado.Text = "0.00"
        Me.txtDiferencia.Text = "0.00"
        Me.txtDiferencia.ReadOnly = True
        Me.txtIdOperador.ReadOnly = True
        Me.resultadosDeBusqueda()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Not String.IsNullOrEmpty(Me.txtNoViaje.Text) Then
            If Not Me.txtNoViaje.Text.Equals("0") And Not String.IsNullOrEmpty(Me.txtNombre.Text) Then

                Me.guardarDatos()
                Me.AnticiposEspeciales_Load(sender, e)

            Else

                MessageBox.Show("El viaje no puede ser cero o  que el campo esté vacío", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            End If
        Else

            MessageBox.Show("El viaje no puede ser cero o  que el campo esté vacío", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub txtTransferencia_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransferencia.Leave

        Me.txtTransferencia.Text = IIf(Not String.IsNullOrEmpty(Me.txtTransferencia.Text), Format(Convert.ToDecimal(Me.txtTransferencia.Text), "######0.00"), "0.00")

    End Sub

    Private Sub txtDiesel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiesel1.Leave

        Me.txtDiesel1.Text = IIf(Not String.IsNullOrEmpty(Me.txtDiesel1.Text), Format(Convert.ToDecimal(Me.txtDiesel1.Text), "######0.00"), "0.00")
        Me.txtTotal.Text = (Convert.ToDecimal(Me.txtDiesel1.Text) + Convert.ToDecimal(Me.txtDiesel2.Text)) & ""

    End Sub

    Private Sub txtSaldoComprobado_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaldoComprobado.Leave

        Me.txtSaldoComprobado.Text = IIf(Not String.IsNullOrEmpty(Me.txtSaldoComprobado.Text), Format(Convert.ToDecimal(Me.txtSaldoComprobado.Text), "######0.00"), "0.00")
        Me.txtDiferencia.Text = Format((Convert.ToDecimal(Me.txtTotal.Text) - Convert.ToDecimal(Me.txtSaldoComprobado.Text)), "######0.00")

    End Sub

    Private Sub txtNoViaje_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoViaje.Leave

        Me.consultarInformación()

    End Sub

    Private Sub txtNoViaje_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoViaje.KeyDown, txtTransferencia.KeyDown, txtSaldoComprobado.KeyDown, txtDiferencia.KeyDown, txtDiesel1.KeyDown, txtNombre.KeyDown, cmBArea.KeyDown

        If e.KeyCode = Keys.Enter Then

            SendKeys.Send("{TAB}")
            e.Handled = True

        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

        Me.txtIdOperador.Text = Me.consultarId() & ""

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim area As Integer

        If Me.cmBArea.SelectedItem.ToString().Contains("Alta") Then

            area = 1

        ElseIf Me.cmBArea.SelectedItem.ToString().Contains("Manza") Then

            area = 2

        ElseIf Me.cmBArea.SelectedItem.ToString().Contains("Vera") Then

            area = 3

        End If

        Me.eliminarViaje(Convert.ToInt32(Me.txtNoViaje.Text), area, Convert.ToInt32(Me.txtIdOperador.Text))

    End Sub

    Private Sub txtDiesel2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiesel2.Leave

        Me.txtDiesel2.Text = IIf(Not String.IsNullOrEmpty(Me.txtDiesel2.Text), Format(Convert.ToDecimal(Me.txtDiesel2.Text), "######0.00"), "0.00")
        Me.txtTotal.Text = (Convert.ToDecimal(Me.txtDiesel1.Text) + Convert.ToDecimal(Me.txtDiesel2.Text)) & ""

    End Sub

    Private Sub txtTotal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.Leave

        Me.txtTotal.Text = IIf(Not String.IsNullOrEmpty(Me.txtTotal.Text), Format(Convert.ToDecimal(Me.txtTotal.Text), "######0.00"), "0.00")

    End Sub

    Private Sub consultarInformación()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        Try

            consulta = "SELECT area, nombreOperador, transferencia, dieselSiVale, comprobado FROM Trafico_Anticipos_Especiales WHERE numeroViaje = " & Convert.ToInt32(Me.txtNoViaje.Text)
            conexion = Connection.getInstance().getConnection()
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
                    If Convert.ToInt32(dS.Tables(0).Rows(0)("area").ToString()) = 1 Then

                        Me.cmBArea.SelectedIndex = 0

                    ElseIf Convert.ToInt32(dS.Tables(0).Rows(0)("area").ToString()) = 2 Then

                        Me.cmBArea.SelectedIndex = 1

                    ElseIf Convert.ToInt32(dS.Tables(0).Rows(0)("area").ToString()) = 3 Then

                        Me.cmBArea.SelectedIndex = 2

                    End If

                    Me.txtNombre.Text = dS.Tables(0).Rows(0)("nombreOperador").ToString()
                    Me.txtTransferencia.Text = Format(Convert.ToDecimal(dS.Tables(0).Rows(0)("transferencia").ToString()), "######0.00")
                    Me.txtDiesel1.Text = Format(Convert.ToDecimal(dS.Tables(0).Rows(0)("dieselSiVale").ToString()), "######0.00")
                    'Me.txtDiesel2.Text = Format(Convert.ToDecimal(dS.Tables(0).Rows(0)("dieselSiVale2").ToString()), "######0.00")
                    Me.txtTotal.Text = Format(Convert.ToDecimal(dS.Tables(0).Rows(0)("dieselSiVale").ToString()), "######0.00") '+ Format(Convert.ToDecimal(dS.Tables(0).Rows(0)("dieselSiVale2").ToString()), "######0.00")) & ""
                    Me.txtSaldoComprobado.Text = Format(Convert.ToDecimal(dS.Tables(0).Rows(0)("comprobado").ToString()), "######0.00")
                    Me.txtDiferencia.Text = Format(Convert.ToDecimal(Me.txtTotal.Text) - Convert.ToDecimal(dS.Tables(0).Rows(0)("comprobado").ToString()), "######0.00")

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub guardarDatos()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_AnticiposEspeciales_Ins", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@numeroViaje", Convert.ToInt32(Me.txtNoViaje.Text))

                If Me.cmBArea.SelectedItem.ToString().Contains("Alta") Then

                    .AddWithValue("@area", 1)

                ElseIf Me.cmBArea.SelectedItem.ToString().Contains("Manza") Then

                    .AddWithValue("@area", 2)

                ElseIf Me.cmBArea.SelectedItem.ToString().Contains("Vera") Then

                    .AddWithValue("@area", 3)

                End If

                .AddWithValue("@idOperador", Convert.ToInt32(Me.txtIdOperador.Text))
                .AddWithValue("@nombreOperador", Me.txtNombre.Text)
                .AddWithValue("@transferencia", Convert.ToDecimal(Me.txtTransferencia.Text))
                .AddWithValue("@dieselSiVale", Convert.ToDecimal(Me.txtDiesel1.Text))
                .AddWithValue("@comprobado", Convert.ToDecimal(Me.txtSaldoComprobado.Text))
                '.AddWithValue("@dieselSiVale2", Convert.ToDecimal(Me.txtDiesel2.Text))

            End With

            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
            MessageBox.Show("Los datos se han guardado exitosamente", "¡Datos guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error al guardar los anticipos: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub resultadosDeBusqueda()

        Dim autoCompletado = New AutoCompleteStringCollection()
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

        Me.txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtNombre.AutoCompleteCustomSource = autoCompletado

    End Sub

    Private Function consultarId() As Integer

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String
        Dim id As Integer

        Try
            If Not String.IsNullOrEmpty(Me.txtNombre.Text.Trim()) Then

                consulta = "SELECT TOP(1) id_personal FROM personal_personal WHERE nombre LIKE '%" & Me.txtNombre.Text & "%'"
                conexion = Connection.getInstance().getConnection()
                comando = New SqlCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 600
                conexion.Open()
                id = Convert.ToInt32(comando.ExecuteScalar())
                conexion.Close()
                conexion.Dispose()
                comando.Dispose()

            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar el ID del operador: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return id

    End Function

    Private Sub eliminarViaje(ByVal viaje As Integer, ByVal area As Integer, ByVal idOperador As Integer)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            consulta = "DELETE FROM Trafico_Anticipos_Especiales WHERE numeroViaje = " & viaje & " AND area = " & area & " AND idOperador = " & idOperador
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al eliminar el viaje: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class