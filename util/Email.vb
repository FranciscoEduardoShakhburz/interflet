Imports Microsoft.Office

Public Class Email

    Private Shared instance As Email = Nothing

    Public Sub New()
    End Sub

    Public Shared Function getInstance() As Email

        If instance Is Nothing Then

            instance = New Email()

        End If

        Return instance

    End Function

    Public Function sendEmail(ByVal asunto As String, ByVal mensaje As String, ByVal listaCorreos As String()) As Boolean

        Dim enviado As Boolean = False
        Dim Maildb As Object
        Dim MailDoc As Object
        Dim Session As Object = CreateObject("Notes.NotesSession")

        Try

            Dim UserName As String
            Dim MailDbName As String

            UserName = Session.UserName
            MailDbName = ""
            Maildb = Session.GETDATABASE("", MailDbName)

            If Maildb.IsOpen = True Then

            Else

                Maildb.OPENMAIL()

            End If

            MailDoc = Maildb.CREATEDOCUMENT
            MailDoc.Form = "Memo"
            MailDoc.sendto = listaCorreos
            MailDoc.DeliveryPriority = "H"
            MailDoc.Subject = asunto
            MailDoc.Body = mensaje
            MailDoc.SAVEMESSAGEONSEND = 1
            MailDoc.PostedDate = Now()
            MailDoc.SEND(False)
            enviado = True

            Return enviado

        Catch ex As Exception

            Return enviado

        Finally

            Maildb = Nothing
            MailDoc = Nothing
            Session = Nothing

        End Try
    End Function

    Public Function sendMailOutlook(ByVal sSubject As String, ByVal sBody As String, ByVal sTo As String, ByVal sCC As String, ByVal sFilename As String, ByVal sDisplayname As String)

        Dim oApp As Interop.Outlook._Application
        Dim oMsg As Interop.Outlook._MailItem
        Dim strS As String = sFilename
        Dim strN As String = sDisplayname
        Dim sBodyLen As Integer = Int(sBody.Length)
        Dim oAttachs As Interop.Outlook.Attachments = oMsg.Attachments
        Dim oAttach As Interop.Outlook.Attachment

        oApp = New Interop.Outlook.Application
        oMsg = oApp.CreateItem(Interop.Outlook.OlItemType.olMailItem)
        oMsg.Subject = sSubject
        oMsg.Body = sBody
        oMsg.To = sTo
        oMsg.CC = sCC

        If sFilename <> "" Then

            oAttach = oAttachs.Add(strS, , sBodyLen, strN)

        End If

        oMsg.Send()
        MessageBox.Show("Email Send", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        KillOutLookProcess()

    End Function

    Private Sub KillOutLookProcess()

        Try

            Dim Xcel() As Process = Process.GetProcessesByName("OUTLOOK")

            For Each Process As Process In Xcel

                Process.Kill()

            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Function AppPath()

        Return System.AppDomain.CurrentDomain.BaseDirectory

    End Function
End Class