<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnTimmy = New System.Windows.Forms.Button()
        Me.btnTomy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(118, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class Average"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAverage.Location = New System.Drawing.Point(224, 73)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(163, 23)
        Me.lblAverage.TabIndex = 1
        Me.lblAverage.Text = " "
        '
        'btnTimmy
        '
        Me.btnTimmy.Location = New System.Drawing.Point(166, 132)
        Me.btnTimmy.Name = "btnTimmy"
        Me.btnTimmy.Size = New System.Drawing.Size(75, 32)
        Me.btnTimmy.TabIndex = 2
        Me.btnTimmy.Text = "Timmy"
        Me.btnTimmy.UseVisualStyleBackColor = True
        '
        'btnTomy
        '
        Me.btnTomy.Location = New System.Drawing.Point(262, 132)
        Me.btnTomy.Name = "btnTomy"
        Me.btnTomy.Size = New System.Drawing.Size(75, 32)
        Me.btnTomy.TabIndex = 3
        Me.btnTomy.Text = "Tomy"
        Me.btnTomy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTomy)
        Me.Controls.Add(Me.btnTimmy)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnTimmy As Button
    Friend WithEvents btnTomy As Button
End Class
