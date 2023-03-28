Public Class Form1
    Dim akhir As Double
    Dim status As String

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Label6.Text = "Tombol untuk menghitung nilai akhir mahasiswa"
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Label6.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        akhir = Val(TextBox1.Text) * Val(0.3) + Val(TextBox2.Text) * Val(0.15) + Val(TextBox3.Text) * Val(0.25) + Val(TextBox4.Text) * Val(0.3)

        If akhir >= 50 Then
            status = "Lulus"
        Else
            status = "Tidak Lulus"
        End If

        Select Case akhir
            Case 80 To 100
                TextBox5.Text = "Nilai Akhir = " & akhir & Environment.NewLine & "Grade = A" & Environment.NewLine & "Mutu = 4" & Environment.NewLine & status
            Case 75 To 80
                TextBox5.Text = "Nilai Akhir = " & akhir & Environment.NewLine & "Grade = B+" & Environment.NewLine & "Mutu = 3.5" & Environment.NewLine & status
            Case 70 To 75
                TextBox5.Text = "Nilai Akhir = " & akhir & Environment.NewLine & "Grade = B" & Environment.NewLine & "Mutu = 3" & Environment.NewLine & status
            Case 65 To 70
                TextBox5.Text = "Nilai Akhir = " & akhir & Environment.NewLine & "Grade = C+" & Environment.NewLine & "Mutu = 2.5" & Environment.NewLine & status
            Case 60 To 65
                TextBox5.Text = "Nilai Akhir = " & akhir & Environment.NewLine & "Grade = C" & Environment.NewLine & "Mutu = 2" & Environment.NewLine & status
            Case 55 To 60
                TextBox5.Text = "Nilai Akhir = " & akhir & Environment.NewLine & "Grade = D+" & Environment.NewLine & "Mutu = 1.5" & Environment.NewLine & status
            Case 50 To 55
                TextBox5.Text = "Nilai Akhir = " & akhir & Environment.NewLine & "Grade = D" & Environment.NewLine & "Mutu = 1" & Environment.NewLine & status
            Case 0 To 50
                TextBox5.Text = "Nilai Akhir = " & akhir & Environment.NewLine & "Grade = E" & Environment.NewLine & "Mutu = 0" & Environment.NewLine & status
            Case Else
                TextBox5.Text = "Anda salah inputkan nilai!!!"
        End Select
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Label6.Text = "Tombol untuk menghapus inputan"
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Label6.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class
