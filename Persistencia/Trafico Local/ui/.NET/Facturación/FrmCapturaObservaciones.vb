Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class FrmCapturaObservaciones
    Dim cartap, myConnectionString As String
    Dim cn As New SqlConnection
    Dim command As SqlCommand
    Dim param As SqlParameter
    Dim reg As SqlDataReader

    Private Sub FrmCapturaObservaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cartap = FrmCPSinFac.cartap
        Me.Textcp.Text = cartap
        cn = Connection.getInstance().getConnection()
        cmd_errores.SelectedIndex = 0
        'Obtenemos los valores de la carta Porte
        command = New SqlCommand("select observaciones from trafico_cp_pendientes_factura where num_guia = '" & cartap & "'", cn)
        command.CommandType = CommandType.Text
        command.CommandTimeout = 600
        command.Connection = cn

        cn.Open()
        reg = command.ExecuteReader
        If reg.HasRows Then
            reg.Read()
            txtObsev.Text = reg.GetValue(0)
        Else
            txtObsev.Text = ""
        End If
        cn.Close()        

    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub B_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Guardar.Click
        ' Checamos en que estatus esta el boton
        If B_Guardar.Text = "MODIFICAR" Then
            ' Cambiamos el boton
            B_Guardar.Text = "GUARDAR"
            cmd_errores.Enabled = True
            txtObsev.Enabled = True
            Me.Textcp.Enabled = True

        Else
            'Buscamos si no se guardo con anterioridad la informacion
            command = New SqlCommand("select observaciones from trafico_cp_pendientes_factura where num_guia = '" & cartap & "'", cn)
            cn.Open()
            reg = command.ExecuteReader
            If reg.HasRows Then
                'Alguien me gano en el guardado de la observacion
                'sustraemos y guardamos la informacion
                'reg.Read()
                'txtObsev.Text = reg.GetValue(0) + Chr(13) + txtObsev.Text
                'Actualizamos los registros
                command = New SqlCommand("Update trafico_cp_pendientes_factura set  observaciones ='" & _
                Me.txtObsev.Text & "',TipoError ='" & Me.cmd_errores.SelectedItem & "',fecreg = getdate()  where " & _
                "num_guia = '" & Me.cartap & "'")

                command.Connection = cn
                reg.Close()
                command.ExecuteNonQuery()
                MessageBox.Show("Guardado con Exito")
                cn.Close()
            Else
                'No existe por lo tanto es solo un insert
                command = New SqlCommand("Insert into trafico_cp_pendientes_factura (num_guia, observaciones, TipoError,fecreg,id) values ('" & _
                Me.cartap & "','" & Me.txtObsev.Text & "','" & Me.cmd_errores.SelectedItem & "',getdate(),1)")
                command.Connection = cn
                reg.Close()
                command.ExecuteNonQuery()

                MessageBox.Show("Guardado con Exito")
                cn.Close()
            End If
            Me.Dispose()
        End If
    End Sub

End Class
