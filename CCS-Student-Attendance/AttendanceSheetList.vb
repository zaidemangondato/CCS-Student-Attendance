Imports MySql.Data.MySqlClient

Public Class AttendanceSheetList
    Dim constr As String = "data source=localhost;database=dbattendanceforcs;user id=root;password=;"
    Dim con As MySqlConnection = New MySqlConnection(constr)
    Dim query As String
    Dim da As MySqlDataAdapter

    Public Sub loadEventList()
        Dim sql As MySqlCommand = New MySqlCommand("select * from tbl_event", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_events.DataSource = ds
        dgv_events.DataMember = "rec"
    End Sub

    Private Sub AttendanceSheetList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadEventList()

    End Sub

    Private Sub dgv_events_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_events.CellContentClick
        TextBox2.Enabled = True
        TextBox3.Enabled = True


        Dim i As Integer
        i = dgv_events.CurrentRow.Index
        TextBox1.Text = "v_" + dgv_events.Item(0, i).Value

        lbleventname.Text = dgv_events.Item(1, i).Value
        lbleventdate.Text = dgv_events.Item(3, i).Value
        lbldesc.Text = dgv_events.Item(2, i).Value


    End Sub
    Public Sub loadtotal()
        Dim sql As MySqlCommand = New MySqlCommand("select id_no, full_name, (am_login + am_logout + pm_login + pm_logout)'Total' from " & TextBox1.Text & " group by full_name asc", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_event_att2.DataSource = ds
        dgv_event_att2.DataMember = "rec"
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim sql As MySqlCommand = New MySqlCommand("select * from " & TextBox1.Text & " group by full_name asc", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_event_att.DataSource = ds
        dgv_event_att.DataMember = "rec"

        loadtotal()

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Dim sql As MySqlCommand = New MySqlCommand("select * from " & TextBox1.Text & " group by full_name asc", con)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter
            Dim ds As DataSet = New DataSet
            da.SelectCommand = sql
            da.Fill(ds, "rec")
            dgv_event_att.DataSource = ds
            dgv_event_att.DataMember = "rec"
        Else
            Dim sql As MySqlCommand = New MySqlCommand("select * from " & TextBox1.Text & " where id_no like '%" & TextBox2.Text & "%' or full_name like '%" & TextBox2.Text & "%' ", con)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter
            Dim ds As DataSet = New DataSet
            da.SelectCommand = sql
            da.Fill(ds, "rec")
            dgv_event_att.DataSource = ds
            dgv_event_att.DataMember = "rec"
        End If

        
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgv_event_att_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_event_att.CellContentClick

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class