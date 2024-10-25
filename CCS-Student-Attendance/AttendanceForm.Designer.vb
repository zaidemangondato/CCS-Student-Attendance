<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceForm))
        Me.lblmode = New System.Windows.Forms.Label()
        Me.lblev_id = New System.Windows.Forms.Label()
        Me.lblev_name = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtid_no = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcourse = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttracecode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgv_select = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_select, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmode.ForeColor = System.Drawing.Color.Teal
        Me.lblmode.Location = New System.Drawing.Point(423, 35)
        Me.lblmode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(83, 25)
        Me.lblmode.TabIndex = 0
        Me.lblmode.Text = "[mode]"
        '
        'lblev_id
        '
        Me.lblev_id.AutoSize = True
        Me.lblev_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblev_id.Location = New System.Drawing.Point(130, 35)
        Me.lblev_id.Name = "lblev_id"
        Me.lblev_id.Size = New System.Drawing.Size(77, 16)
        Me.lblev_id.TabIndex = 1
        Me.lblev_id.Text = "[event_id]"
        '
        'lblev_name
        '
        Me.lblev_name.AutoSize = True
        Me.lblev_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblev_name.Location = New System.Drawing.Point(130, 64)
        Me.lblev_name.Name = "lblev_name"
        Me.lblev_name.Size = New System.Drawing.Size(102, 16)
        Me.lblev_name.TabIndex = 2
        Me.lblev_name.Text = "[event_name]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Event Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Event ID"
        '
        'txtid_no
        '
        Me.txtid_no.BackColor = System.Drawing.Color.White
        Me.txtid_no.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtid_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtid_no.Location = New System.Drawing.Point(15, 452)
        Me.txtid_no.Name = "txtid_no"
        Me.txtid_no.ReadOnly = True
        Me.txtid_no.Size = New System.Drawing.Size(133, 17)
        Me.txtid_no.TabIndex = 7
        Me.txtid_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfullname
        '
        Me.txtfullname.BackColor = System.Drawing.Color.White
        Me.txtfullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Location = New System.Drawing.Point(249, 326)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.ReadOnly = True
        Me.txtfullname.Size = New System.Drawing.Size(286, 17)
        Me.txtfullname.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Full Name"
        '
        'txtcourse
        '
        Me.txtcourse.BackColor = System.Drawing.Color.White
        Me.txtcourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcourse.Location = New System.Drawing.Point(249, 354)
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.ReadOnly = True
        Me.txtcourse.Size = New System.Drawing.Size(148, 17)
        Me.txtcourse.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(163, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Course"
        '
        'txtyear
        '
        Me.txtyear.BackColor = System.Drawing.Color.White
        Me.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.Location = New System.Drawing.Point(249, 382)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.ReadOnly = True
        Me.txtyear.Size = New System.Drawing.Size(148, 17)
        Me.txtyear.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(163, 387)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Year"
        '
        'txttracecode
        '
        Me.txttracecode.BackColor = System.Drawing.Color.White
        Me.txttracecode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttracecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttracecode.Location = New System.Drawing.Point(249, 422)
        Me.txttracecode.Name = "txttracecode"
        Me.txttracecode.ReadOnly = True
        Me.txttracecode.Size = New System.Drawing.Size(205, 17)
        Me.txttracecode.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(163, 427)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tracecode"
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(7, 497)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(555, 32)
        Me.btnsubmit.TabIndex = 17
        Me.btnsubmit.Text = "Submit Attendance"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 22)
        Me.TextBox1.TabIndex = 21
        '
        'dgv_select
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_select.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_select.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_select.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_select.Location = New System.Drawing.Point(15, 146)
        Me.dgv_select.Name = "dgv_select"
        Me.dgv_select.ReadOnly = True
        Me.dgv_select.Size = New System.Drawing.Size(543, 167)
        Me.dgv_select.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Search"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(570, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 319)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'AttendanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(570, 533)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgv_select)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txttracecode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcourse)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtid_no)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblev_name)
        Me.Controls.Add(Me.lblev_id)
        Me.Controls.Add(Me.lblmode)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AttendanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttendanceForm"
        CType(Me.dgv_select, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents lblev_id As System.Windows.Forms.Label
    Friend WithEvents lblev_name As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtid_no As System.Windows.Forms.TextBox
    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcourse As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttracecode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgv_select As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
