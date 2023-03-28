Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FileNum As Integer = FreeFile()
        Dim TempS As String = ""
        Dim TempL As String
        FileOpen(FileNum, "Score.txt", OpenMode.Input)
        Do Until EOF(FileNum)
            TempL = LineInput(FileNum)
            TempS += TempL + vbCrLf
        Loop
        FileClose(FileNum)
        TextBox1.Text = TempS
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FileNum As Integer = FreeFile()
        FileOpen(FileNum, "Score.txt", OpenMode.Output)
        PrintLine(FileNum, TextBox1.Text)
        FileClose(FileNum)
    End Sub
End Class
