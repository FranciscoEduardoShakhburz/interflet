Imports System.Data.SqlClient
Public Class PaseFacturacion
    Public usuario, cp As String
    Dim cn As New SqlConnection
    Dim reg As SqlDataReader
    Dim tipoB, validador As Integer
    Private Sub PaseFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = Connection.getInstance().getConnection()
        If Acceso.tipo = 1 Then
            bto_rechazar.Hide()
            txt_observaciones.Enabled = False
            tipoB = 1
            bto_guardar.Hide()
        Else
            tipoB = 2
            bto_rechazar.Hide()
            bto_guardar.Hide()
        End If
        'myConnectionString = "Initial Catalog=ProduccionInterfletdb;Data Source=175.50.5.46;" & _
        '"User ID=sa;Password=sa;"
        usuario = Acceso.usuario
        Me.ControlBox = False
    End Sub
    Private Sub bto_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_salir.Click
        Me.Close()
        Acceso.Close()
    End Sub

    Public Sub ConsultarCp()

        Dim command As SqlCommand = New SqlCommand("Get_Facturas_Pase", cn)
        command.CommandType = CommandType.StoredProcedure
        cn.Open()
        command.CommandTimeout = 600
        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@num_guia", Me.txt_Guia.Text)
        param = command.Parameters.AddWithValue("@tipoB", tipoB)
        reg = command.ExecuteReader
        reg.Read()


        If reg.HasRows Then 'Valida si Hay Valores
            If tipoB = 2 Then 'Evalua si fue un Adm o usuario quien mando la consulta
                txt_fec_guia.Text = reg.GetValue(1)
                txt_fec_pase.Text = reg.GetValue(2)
                txt_cliente.Text = reg.GetValue(3)
                txt_observaciones.Text = reg.GetValue(4)

            Else 'Este es para Usuario

                txt_fec_guia.Text = ""
                txt_fec_pase.Text = ""
                txt_cliente.Text = ""
                txt_observaciones.Text = reg.GetValue(1)

            End If

            validador = 2 'Variable varilador en 2 quiere decir que si hubo exito al consultar la BD

        Else
            If tipoB = 2 Then 'En caso de que no existan registros entramos a las excepciones 
                MessageBox.Show("C.P mal Capturada o sin Fecha de Pase")
                validador = 1
                bto_rechazar.Hide()
            Else
                MessageBox.Show("C.P mal Capturada o sin Rechazar")
            End If

        End If


        cn.Close()



    End Sub

    Private Sub bto_rechazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_rechazar.Click
        Me.Insertar()

    End Sub
    
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Guia.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.ConsultarCp()

            If tipoB = 2 Then
                If validador = 2 Then
                    cp = txt_Guia.Text
                    txt_observaciones.Enabled = True
                    bto_rechazar.Show()
                End If
            Else
                If validador = 2 Then
                    cp = txt_Guia.Text
                    txt_observaciones.Enabled = True
                    bto_guardar.Show()
                End If
            End If


        End If

    End Sub
    Public Sub Limpia()
        txt_Guia.Text = ""
        txt_cliente.Text = ""
        txt_fec_pase.Text = ""
        txt_fec_guia.Text = ""
        txt_observaciones.Text = ""
        txt_observaciones.Enabled = False
        bto_rechazar.Hide()
    End Sub

    Private Sub bto_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bto_guardar.Click
        Me.Insertar()
    End Sub

    Public Sub Insertar()
        'Me.ConsultarCp()
        Dim command As SqlCommand = New SqlCommand("insert_facturas_pase_historial", cn)
        command.CommandType = CommandType.StoredProcedure
        command.CommandTimeout = 600
        Dim param As SqlParameter
        param = command.Parameters.AddWithValue("@num_guia", Me.cp)
        param = command.Parameters.AddWithValue("@observaciones", Me.txt_observaciones.Text)
        param = command.Parameters.AddWithValue("@id", 2)
        param = command.Parameters.AddWithValue("@usuario", usuario)
        command.Connection = cn
        cn.Open()

        If validador = 1 Then

        Else
            command.ExecuteNonQuery()

            MessageBox.Show("Guardado con Exito")
        End If




        cn.Close()

        Me.Limpia()
    End Sub
End Class
