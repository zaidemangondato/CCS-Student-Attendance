Imports MySql.Data.MySqlClient

Public Class TimeIntervalChanger
    Dim constr As String = "data source=localhost;database=dbattendanceforcs;user id=root;password=;"
    Dim con As MySqlConnection = New MySqlConnection(constr)
    Dim query As String
    Dim da As MySqlDataAdapter
    Dim compTime As String
    Public Sub loadtimeintervals()
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
            txt_li_AM_o.Text = datardr("li_am_o")
            txt_li_AM_c.Text = datardr("li_am_c")
            txt_lo_AM_o.Text = datardr("lo_am_o")
            txt_lo_AM_c.Text = datardr("lo_am_c")

            txt_li_PM_o.Text = datardr("li_PM_o")
            txt_li_PM_c.Text = datardr("li_PM_c")
            txt_lo_PM_o.Text = datardr("lo_PM_o")
            txt_lo_PM_c.Text = datardr("lo_PM_c")
        End If
    End Sub

    Private Sub TimeIntervalChanger_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadtimeintervals()





    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        Dim cmd As MySqlCommand = New MySqlCommand(query, con)
        con.Open()
        query = "update tbl_time_interv set li_AM_o = '" & txt_li_AM_o.Text & "', li_AM_c = '" & txt_li_AM_c.Text & "', lo_AM_o = '" & txt_lo_AM_o.Text & "', lo_AM_c = '" & txt_lo_AM_c.Text & "', li_PM_o = '" & txt_li_PM_o.Text & "', li_PM_c = '" & txt_li_PM_c.Text & "', lo_PM_o = '" & txt_lo_PM_o.Text & "', lo_PM_c = '" & txt_lo_PM_c.Text & "' where ti_id = 'TI101'   "
        cmd = New MySqlCommand(query, con)
        Dim i As Integer = cmd.ExecuteNonQuery()
        MsgBox("Successfully updated!")
        con.Close()

        Form1.loadtimeinterv()
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "1 AM" Then
            ta.Text = "1"
        ElseIf ComboBox1.Text = "2 AM" Then
            ta.Text = "2"
        ElseIf ComboBox1.Text = "3 AM" Then
            ta.Text = "3"
        ElseIf ComboBox1.Text = "4 AM" Then
            ta.Text = "4"
        ElseIf ComboBox1.Text = "5 AM" Then
            ta.Text = "5"
        ElseIf ComboBox1.Text = "6 AM" Then
            ta.Text = "6"
        ElseIf ComboBox1.Text = "7 AM" Then
            ta.Text = "7"
        ElseIf ComboBox1.Text = "8 AM" Then
            ta.Text = "8"
        ElseIf ComboBox1.Text = "9 AM" Then
            ta.Text = "9"
        ElseIf ComboBox1.Text = "10 AM" Then
            ta.Text = "10"
        ElseIf ComboBox1.Text = "11 AM" Then
            ta.Text = "11"
        ElseIf ComboBox1.Text = "12 PM" Then
            ta.Text = "12"
        ElseIf ComboBox1.Text = "1 PM" Then
            ta.Text = "13"
        ElseIf ComboBox1.Text = "2 PM" Then
            ta.Text = "14"
        ElseIf ComboBox1.Text = "3 PM" Then
            ta.Text = "15"
        ElseIf ComboBox1.Text = "4 PM" Then
            ta.Text = "16"
        ElseIf ComboBox1.Text = "5 PM" Then
            ta.Text = "17"
        ElseIf ComboBox1.Text = "6 PM" Then
            ta.Text = "18"
        ElseIf ComboBox1.Text = "7 PM" Then
            ta.Text = "19"
        ElseIf ComboBox1.Text = "8 PM" Then
            ta.Text = "20"
        ElseIf ComboBox1.Text = "9 PM" Then
            ta.Text = "21"
        ElseIf ComboBox1.Text = "10 PM" Then
            ta.Text = "22"
        ElseIf ComboBox1.Text = "11 PM" Then
            ta.Text = "23"
        ElseIf ComboBox1.Text = "12 AM" Then
            ta.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        compTime = ta.Text + tb.Text + tc.Text + td.Text + te.Text
        txt_li_AM_o.Text = compTime

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        compTime = ta.Text + tb.Text + tc.Text + td.Text + te.Text
        txt_li_AM_c.Text = compTime
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        compTime = ta.Text + tb.Text + tc.Text + td.Text + te.Text
        txt_lo_AM_o.Text = compTime
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        compTime = ta.Text + tb.Text + tc.Text + td.Text + te.Text
        txt_lo_AM_c.Text = compTime
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        compTime = ta.Text + tb.Text + tc.Text + td.Text + te.Text
        txt_li_PM_o.Text = compTime
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        compTime = ta.Text + tb.Text + tc.Text + td.Text + te.Text
        txt_li_PM_c.Text = compTime
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        compTime = ta.Text + tb.Text + tc.Text + td.Text + te.Text
        txt_lo_PM_o.Text = compTime
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        compTime = ta.Text + tb.Text + tc.Text + td.Text + te.Text
        txt_lo_PM_c.Text = compTime
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class