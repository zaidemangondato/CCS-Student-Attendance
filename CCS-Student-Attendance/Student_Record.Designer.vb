<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Record))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sr_txtid = New System.Windows.Forms.TextBox()
        Me.sr_txtname = New System.Windows.Forms.TextBox()
        Me.sr_txtcourse = New System.Windows.Forms.TextBox()
        Me.sr_txtyear = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(370, 45)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'sr_txtid
        '
        Me.sr_txtid.BackColor = System.Drawing.Color.White
        Me.sr_txtid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sr_txtid.Location = New System.Drawing.Point(369, 211)
        Me.sr_txtid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sr_txtid.Name = "sr_txtid"
        Me.sr_txtid.ReadOnly = True
        Me.sr_txtid.Size = New System.Drawing.Size(150, 19)
        Me.sr_txtid.TabIndex = 2
        '
        'sr_txtname
        '
        Me.sr_txtname.BackColor = System.Drawing.Color.White
        Me.sr_txtname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sr_txtname.Location = New System.Drawing.Point(14, 54)
        Me.sr_txtname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sr_txtname.Name = "sr_txtname"
        Me.sr_txtname.ReadOnly = True
        Me.sr_txtname.Size = New System.Drawing.Size(350, 19)
        Me.sr_txtname.TabIndex = 3
        '
        'sr_txtcourse
        '
        Me.sr_txtcourse.BackColor = System.Drawing.Color.White
        Me.sr_txtcourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sr_txtcourse.Location = New System.Drawing.Point(14, 89)
        Me.sr_txtcourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sr_txtcourse.Name = "sr_txtcourse"
        Me.sr_txtcourse.ReadOnly = True
        Me.sr_txtcourse.Size = New System.Drawing.Size(350, 19)
        Me.sr_txtcourse.TabIndex = 4
        '
        'sr_txtyear
        '
        Me.sr_txtyear.BackColor = System.Drawing.Color.White
        Me.sr_txtyear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sr_txtyear.Location = New System.Drawing.Point(14, 124)
        Me.sr_txtyear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sr_txtyear.Name = "sr_txtyear"
        Me.sr_txtyear.ReadOnly = True
        Me.sr_txtyear.Size = New System.Drawing.Size(170, 19)
        Me.sr_txtyear.TabIndex = 5
        '
        'Student_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 416)
        Me.Controls.Add(Me.sr_txtyear)
        Me.Controls.Add(Me.sr_txtcourse)
        Me.Controls.Add(Me.sr_txtname)
        Me.Controls.Add(Me.sr_txtid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Student_Record"
        Me.Text = "Student_Record"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents sr_txtid As System.Windows.Forms.TextBox
    Friend WithEvents sr_txtname As System.Windows.Forms.TextBox
    Friend WithEvents sr_txtcourse As System.Windows.Forms.TextBox
    Friend WithEvents sr_txtyear As System.Windows.Forms.TextBox
End Class
