Imports MySql.Data.MySqlClient

Public Class Select_student
    Dim constr As String = "data source=localhost;database=dbattendanceforcs;user id=root;password=;"
    Dim con As MySqlConnection = New MySqlConnection(constr)
    Dim query As String
    Dim da As MySqlDataAdapter

    Public Sub loadselectstudents()
        Dim sql As MySqlCommand = New MySqlCommand("select * from v_studrec", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_select.DataSource = ds
        dgv_select.DataMember = "rec"
    End Sub

    Private Sub Select_student_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadselectstudents()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim sql As MySqlCommand = New MySqlCommand("select * from v_studrec where id_no like '%" & TextBox1.Text & "%' or full_name like '%" & TextBox1.Text & "%' ", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_select.DataSource = ds
        dgv_select.DataMember = "rec"
    End Sub

    Private Sub dgv_select_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_select.CellContentClick
        Dim i As Integer
        i = dgv_select.CurrentRow.Index
        AttendanceForm.txtid_no.Text = dgv_select.Item(0, i).Value
        AttendanceForm.txtfullname.Text = dgv_select.Item(1, i).Value
        AttendanceForm.txtcourse.Text = dgv_select.Item(2, i).Value
        AttendanceForm.txtyear.Text = dgv_select.Item(3, i).Value

        Dim stracecode As String = AttendanceForm.lblev_id.Text + AttendanceForm.txtid_no.Text + AttendanceForm.lblmode.Text
        AttendanceForm.txttracecode.Text = stracecode

    End Sub
End Class