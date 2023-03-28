Public Class frmTomy

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            Dim grade As String
            Dim grade_conv As Double

            grade = InputBox("Type in Student gade", "Grade", "0")
            grade_conv = CDbl(grade)

            Form1.lblAverage.Text = mdlSample.average(grade_conv).ToString

            lstGrade.Items.Add("Assigment 1: " + grade_conv.ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)

        End Try
    End Sub
End Class