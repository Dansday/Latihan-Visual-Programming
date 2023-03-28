Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radioL.CheckedChanged

    End Sub

    Private Sub btnBaca_Click(sender As Object, e As EventArgs) Handles btnBaca.Click
        If radioL.Checked = True Then
            boxTampil.Text = "NIM :" & boxNim.Text & Environment.NewLine & "Nama :" & boxNama.Text & Environment.NewLine & "Jenis Kelamin :Laki - Laki"
        ElseIf radioP.Checked = True Then
            boxTampil.Text = "NIM :" & boxNim.Text & Environment.NewLine & "Nama :" & boxNama.Text & Environment.NewLine & "Jenis Kelamin :Perempuan"
        Else
            boxTampil.Text = "NIM :" & boxNim.Text & Environment.NewLine & "Nama :" & boxNama.Text & Environment.NewLine & "Jenis Kelamin :"
        End If
    End Sub

    Private Sub radioP_CheckedChanged(sender As Object, e As EventArgs) Handles radioP.CheckedChanged

    End Sub

    Private Sub boxTampil_TextChanged(sender As Object, e As EventArgs) Handles boxTampil.TextChanged

    End Sub

    Private Sub boxNim_TextChanged(sender As Object, e As EventArgs) Handles boxNim.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        boxTampil.Text = ""
    End Sub
End Class
