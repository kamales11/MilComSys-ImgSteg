Imports System.Data.SqlClient

Public Class officer
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim con As SqlConnection
        con = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=military;Integrated Security=True")
        Dim sql As String
        con.Open()
        sql = "insert into reg values('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.ComboBox1.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "','" & Me.TextBox7.Text & "','" & Me.TextBox8.Text & "', '" & Me.TextBox9.Text & "')"
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show(" saved")
        con.Close()
    End Sub
End Class