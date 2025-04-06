Imports System.Data.SqlClient

Public Class profile
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim connetionString As String
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim sql As String
        Dim reader As SqlDataReader
        connetionString = "Data Source=.\sqlexpress;Initial Catalog=military;Integrated Security=True"
        sql = "Select * from reg where mid='" & Me.TextBox1.Text & "'"
        cnn = New SqlConnection(connetionString)
        Try
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                Me.TextBox2.Text = reader.Item(1)
                Me.ComboBox1.Text = reader.Item(2)
                Me.TextBox3.Text = reader.Item(3)
                Me.TextBox4.Text = reader.Item(4)
                Me.TextBox5.Text = reader.Item(5)
                Me.TextBox6.Text = reader.Item(6)
                Me.TextBox7.Text = reader.Item(7)
                Me.TextBox8.Text = reader.Item(8)
                Me.TextBox9.Text = reader.Item(9)
            End While
            reader.Close()
            cmd.Dispose()
            cnn.Close()
        Catch ex As Exception
            MsgBox("Can not open connection!")
        End Try
    End Sub
End Class