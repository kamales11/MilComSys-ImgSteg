Imports System.Data.SqlClient

Public Class login
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim conn As SqlConnection
        Dim sql = "SELECT mid, pass FROM reg WHERE mid = '" & Me.TextBox1.Text & "' AND pass = '" & Me.TextBox2.Text & "'"
        conn = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=military; Integrated Security=True")
        conn.Open()
        cmd = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read = False Then
            MsgBox("Try Again")
        Else
            Dim a As New home
            a.ShowDialog()
        End If
    End Sub
End Class