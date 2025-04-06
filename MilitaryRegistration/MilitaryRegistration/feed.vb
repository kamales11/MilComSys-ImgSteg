Imports System.Data.SqlClient

Public Class feed
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=military; Integrated Security=True")
        Dim sql As String
        con.Open()
        sql = "insert into compp values('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "')"
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Saved")
        con.Close()
    End Sub
End Class