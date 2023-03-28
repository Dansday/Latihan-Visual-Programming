Public Class Form1
    Dim total, bayar, kembali As Double
    Dim c As CheckBox()
    Dim h As TextBox()
    Dim j As TextBox()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c = New CheckBox() {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12}
        h = New TextBox() {h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, h11, h12}
        j = New TextBox() {j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12}
    End Sub

    Private Sub tb_TextChanged(sender As Object, e As EventArgs) Handles tb.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        total = 0
        For i = 0 To 11
            If c(i).Checked = True Then
                total = total + (Val(h(i).Text) * Val(j(i).Text))
            End If
        Next
        tt.Text = "Rp." & Format(total, "#,#.##")
    End Sub
    Private Sub tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb.KeyPress
        If e.KeyChar = Chr(13) Then
            bayar = Val(tb.Text)
            kembali = bayar - total
            tk.Text = "Rp." & Format(kembali, "#,#.##")
        End If
    End Sub
End Class
