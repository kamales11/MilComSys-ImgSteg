Imports System.Net.Mail

Public Class mail
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential()
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail.From = New MailAddress(Me.TextBox1.Text)
            e_mail.To.Add(Me.TextBox2.Text)
            e_mail.Subject = "Email Sending"
            Dim attachFile As New Attachment(Me.TextBox3.Text)
            e_mail.Attachments.Add(attachFile)
            e_mail.IsBodyHtml = False
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub
End Class