Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class formEmails
    Private idCliente As Integer
    Private nombreCliente As String
    Private rfcCliente As String

    Public Sub New()
        Me.idCliente = 0
        Me.nombreCliente = ""
        Me.rfcCliente = ""
    End Sub

    Public Sub New(ByVal idCliente As String, ByVal nombreCliente As String, ByVal rfcCliente As String)
        InitializeComponent()
        Me.idCliente = idCliente
        Me.nombreCliente = nombreCliente
        Me.rfcCliente = rfcCliente
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Cursor = Cursors.WaitCursor
        If Me.gridEmails.Rows.Count > 1 Then
            Dim email As String = ""
            Dim sql As String = ""
            Dim conn As SqlConnection = Connection.getInstance().getConnection()
            Dim command As SqlCommand
            conn.Open()
            For i As Integer = 0 To Me.gridEmails.Rows.Count - 2
                If Not Me.gridEmails.Rows(i).Cells("Email").Value = Nothing Then
                    email = Me.gridEmails.Rows(i).Cells("Email").Value.ToString()
                    If Not String.IsNullOrEmpty(email) Then
                        If Me.isValidEmail(email) Then
                            sql = "INSERT INTO trafico_cliente_email (idCliente, email) VALUES ('" & Me.idCliente.ToString & "' , '" & email & "')"
                            command = New SqlCommand(sql, conn)
                            command.CommandType = CommandType.Text
                            command.ExecuteNonQuery()
                        Else
                            MessageBox.Show("El correo: " & email & " no es válido")
                            Exit For
                        End If
                    End If
                End If
            Next
            conn.Dispose()
            conn.Close()
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub


#Region "Utilerías"
    Private Function isValidEmail(ByVal email As String) As Boolean
        Try
            Dim mailAddress As MailAddress = New MailAddress(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class