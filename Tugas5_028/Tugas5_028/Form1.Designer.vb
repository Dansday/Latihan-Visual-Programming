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
        Me.boxNim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxNama = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioP = New System.Windows.Forms.RadioButton()
        Me.radioL = New System.Windows.Forms.RadioButton()
        Me.boxTampil = New System.Windows.Forms.TextBox()
        Me.btnBaca = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'boxNim
        '
        Me.boxNim.Location = New System.Drawing.Point(149, 42)
        Me.boxNim.Name = "boxNim"
        Me.boxNim.Size = New System.Drawing.Size(229, 20)
        Me.boxNim.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis Kelamin"
        '
        'boxNama
        '
        Me.boxNama.Location = New System.Drawing.Point(150, 91)
        Me.boxNama.Name = "boxNama"
        Me.boxNama.Size = New System.Drawing.Size(228, 20)
        Me.boxNama.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioP)
        Me.GroupBox1.Controls.Add(Me.radioL)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(150, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 49)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'radioP
        '
        Me.radioP.AutoSize = True
        Me.radioP.Location = New System.Drawing.Point(119, 19)
        Me.radioP.Name = "radioP"
        Me.radioP.Size = New System.Drawing.Size(90, 19)
        Me.radioP.TabIndex = 1
        Me.radioP.TabStop = True
        Me.radioP.Text = "Perempuan"
        Me.radioP.UseVisualStyleBackColor = True
        '
        'radioL
        '
        Me.radioL.AutoSize = True
        Me.radioL.Location = New System.Drawing.Point(6, 19)
        Me.radioL.Name = "radioL"
        Me.radioL.Size = New System.Drawing.Size(81, 19)
        Me.radioL.TabIndex = 0
        Me.radioL.TabStop = True
        Me.radioL.Text = "Laki - Laki"
        Me.radioL.UseVisualStyleBackColor = True
        '
        'boxTampil
        '
        Me.boxTampil.Location = New System.Drawing.Point(36, 202)
        Me.boxTampil.Multiline = True
        Me.boxTampil.Name = "boxTampil"
        Me.boxTampil.Size = New System.Drawing.Size(275, 167)
        Me.boxTampil.TabIndex = 6
        '
        'btnBaca
        '
        Me.btnBaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaca.Location = New System.Drawing.Point(328, 200)
        Me.btnBaca.Name = "btnBaca"
        Me.btnBaca.Size = New System.Drawing.Size(86, 32)
        Me.btnBaca.TabIndex = 7
        Me.btnBaca.Text = "Baca"
        Me.btnBaca.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(328, 251)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(86, 33)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 392)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBaca)
        Me.Controls.Add(Me.boxTampil)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.boxNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxNim)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "028"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents boxNim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents boxNama As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioL As RadioButton
    Friend WithEvents radioP As RadioButton
    Friend WithEvents boxTampil As TextBox
    Friend WithEvents btnBaca As Button
    Friend WithEvents btnHapus As Button
End Class
