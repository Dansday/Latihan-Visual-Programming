Public Class Form1

    Dim NoAwal As Long
    Dim Operation As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Layar.TextChanged

    End Sub

    Private Sub N1_Click(sender As Object, e As EventArgs) Handles N1.Click
        If Layar.Text = "0" Then
            Layar.Text = "1"
        Else
            Layar.Text = Layar.Text & "1"
        End If
    End Sub

    Private Sub N2_Click(sender As Object, e As EventArgs) Handles N2.Click
        If Layar.Text = "0" Then
            Layar.Text = "2"
        Else
            Layar.Text = Layar.Text & "2"
        End If
    End Sub

    Private Sub N3_Click(sender As Object, e As EventArgs) Handles N3.Click
        If Layar.Text = "0" Then
            Layar.Text = "3"
        Else
            Layar.Text = Layar.Text & "3"
        End If
    End Sub

    Private Sub N4_Click(sender As Object, e As EventArgs) Handles N4.Click
        If Layar.Text = "0" Then
            Layar.Text = "4"
        Else
            Layar.Text = Layar.Text & "4"
        End If
    End Sub

    Private Sub N5_Click(sender As Object, e As EventArgs) Handles N5.Click
        If Layar.Text = "0" Then
            Layar.Text = "5"
        Else
            Layar.Text = Layar.Text & "5"
        End If
    End Sub

    Private Sub N6_Click(sender As Object, e As EventArgs) Handles N6.Click
        If Layar.Text = "0" Then
            Layar.Text = "6"
        Else
            Layar.Text = Layar.Text & "6"
        End If
    End Sub

    Private Sub N7_Click(sender As Object, e As EventArgs) Handles N7.Click
        If Layar.Text = "0" Then
            Layar.Text = "7"
        Else
            Layar.Text = Layar.Text & "7"
        End If
    End Sub

    Private Sub N8_Click(sender As Object, e As EventArgs) Handles N8.Click
        If Layar.Text = "0" Then
            Layar.Text = "8"
        Else
            Layar.Text = Layar.Text & "8"
        End If
    End Sub

    Private Sub N9_Click(sender As Object, e As EventArgs) Handles N9.Click
        If Layar.Text = "0" Then
            Layar.Text = "9"
        Else
            Layar.Text = Layar.Text & "9"
        End If
    End Sub

    Private Sub N0_Click(sender As Object, e As EventArgs) Handles N0.Click
        If Layar.Text = "0" Then
            Layar.Text = "0"
        Else
            Layar.Text = Layar.Text & "0"
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Layar.Text = "0"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        NoAwal = Layar.Text
        Layar.Text = "0"
        Operation = "+"
    End Sub

    Private Sub Kurang_Click(sender As Object, e As EventArgs) Handles Kurang.Click
        NoAwal = Layar.Text
        Layar.Text = "0"
        Operation = "-"
    End Sub

    Private Sub Kali_Click(sender As Object, e As EventArgs) Handles Kali.Click
        NoAwal = Layar.Text
        Layar.Text = "0"
        Operation = "*"
    End Sub

    Private Sub Bagi_Click(sender As Object, e As EventArgs) Handles Bagi.Click
        NoAwal = Layar.Text
        Layar.Text = "0"
        Operation = "/"
    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        Dim NoKedua As Long
        Dim Result As Long

        NoKedua = Layar.Text

        If Operation = "+" Then
            Result = NoAwal + NoKedua
        ElseIf Operation = "-" Then
            Result = NoAwal - NoKedua
        ElseIf Operation = "*" Then
            Result = NoAwal * NoKedua
        ElseIf Operation = "/" Then
            Result = NoAwal / NoKedua
        End If

        NoAwal = Result
        Layar.Text = Result

    End Sub
End Class
