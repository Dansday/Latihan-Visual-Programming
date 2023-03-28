Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For a = 1 To 100
            ListBox2.Items.Add(a)
        Next a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start1 As Integer
        Dim start2 As Integer
        start1 = TextBox1.Text
        start2 = TextBox2.Text
        For a = start1 To start2
            ListBox1.Items.Add(a)
        Next a
    End Sub
End Class
