Imports MySql.Data.MySqlClient

Public Class Form1
    Dim constr As String = "data source=localhost;database=dbattendanceforcs;user id=root;password=;"
    Dim con As MySqlConnection = New MySqlConnection(constr)
    Dim query As String
    Dim da As MySqlDataAdapter
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        time.Text = Format(Now, "H:mm:ss")
        time2.Text = Format(Now, "h:mm:")
        sec.Text = Format(Now, "ss")
        lbl12hc.Text = Format(Now, "tt")


       


    End Sub
    
    Public Sub loadtimeinterv()
        da = (New MySqlDataAdapter)
        Dim con As MySqlConnection = New MySqlConnection(constr)
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim datardr As MySqlDataReader
        Dim query As String

        con.Open()
        query = "select * from tbl_time_interv where ti_id = 'TI101'  "
        cmd.CommandText = query
        cmd.Connection = con
        da.SelectCommand = cmd
        datardr = cmd.ExecuteReader
        If datardr.HasRows Then
            datardr.Read()
            ' txt_client_id.Text = datardr("client_id")
            lb_li_AM_o.Text = datardr("li_am_o")
            lb_li_AM_c.Text = datardr("li_am_c")
            lb_lo_AM_o.Text = datardr("lo_am_o")
            lb_lo_AM_c.Text = datardr("lo_am_c")

            lb_li_PM_o.Text = datardr("li_PM_o")
            lb_li_PM_c.Text = datardr("li_PM_c")
            lb_lo_PM_o.Text = datardr("lo_PM_o")
            lb_lo_PM_c.Text = datardr("lo_PM_c")
        End If
    End Sub

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
     
        proceed()

    End Sub
    Public Sub loadcurrentEvent()
        da = (New MySqlDataAdapter)
        Dim con As MySqlConnection = New MySqlConnection(constr)
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim datardr As MySqlDataReader
        Dim query As String

        con.Open()
        query = "select * from tbl_event where dt_event = '" & dtpcurdate.Text & "'  "
        cmd.CommandText = query
        cmd.Connection = con
        da.SelectCommand = cmd
        datardr = cmd.ExecuteReader
        If datardr.HasRows Then
            datardr.Read()
            lblev_id.Text = datardr("event_id")
            lblev_name.Text = datardr("event_name")
        Else
            lblev_id.Text = "No Current Event . ."
            lblev_name.Text = "No Current Event . ."
        End If
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        loadtimeinterv()
        loadcurrentEvent()


        Dim timer As New Timer()
        timer.Interval = 500
        AddHandler timer.Tick, AddressOf timer_Tick
        timer.Start()


    End Sub
    Public Sub proceed()
        ''AM
        If time.Text = lb_li_AM_o.Text Then
            'MsgBox("Login AM is Open")
            AttendanceForm.lblmode.Text = "am_login"
            AttendanceForm.lblev_id.Text = Me.lblev_id.Text
            AttendanceForm.lblev_name.Text = Me.lblev_name.Text

            AttendanceForm.Show()

        ElseIf time.Text = lb_li_AM_c.Text Then
            'Msgbox("Login AM is Close")
            AttendanceForm.Close()

        ElseIf time.Text = lb_lo_AM_o.Text Then
            'MsgBox("Logout AM is Open")
            AttendanceForm.lblmode.Text = "am_logout"
            AttendanceForm.lblev_id.Text = Me.lblev_id.Text
            AttendanceForm.lblev_name.Text = Me.lblev_name.Text

            AttendanceForm.Show()
        ElseIf time.Text = lb_lo_AM_c.Text Then
            'MsgBox("Logout AM is Close")
            AttendanceForm.Close()


            '    'PM
        ElseIf time.Text = lb_li_PM_o.Text Then
            'MsgBox("Login PM is Open")
            AttendanceForm.lblmode.Text = "pm_login"
            AttendanceForm.lblev_id.Text = Me.lblev_id.Text
            AttendanceForm.lblev_name.Text = Me.lblev_name.Text

            AttendanceForm.Show()
        ElseIf time.Text = lb_li_PM_c.Text Then
            'MsgBox("Login PM is Close")
            AttendanceForm.Close()

        ElseIf time.Text = lb_lo_PM_o.Text Then
            ' MsgBox("Logout PM is Open")
            AttendanceForm.lblmode.Text = "pm_logout"
            AttendanceForm.lblev_id.Text = Me.lblev_id.Text
            AttendanceForm.lblev_name.Text = Me.lblev_name.Text

            AttendanceForm.Show()
        ElseIf time.Text = lb_lo_PM_c.Text Then
            ' MsgBox("Logout PM is Close")
            AttendanceForm.Close()

        Else

        End If

    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()


    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListToolStripMenuItem.Click
        StudentList.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TimeIntervalChanger.Show()

    End Sub

    Private Sub EventInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EventInformationToolStripMenuItem.Click
        EventsInformation.Show()


    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub ToolStripButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Created_Entities.ShowDialog()

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        AttendanceForm.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        AttendanceSheetList.Show()

    End Sub
End Class
