Imports MySql.Data.MySqlClient

Public Class StudentList
    Dim constr As String = "data source=localhost;database=dbattendanceforcs;user id=root;password=;"
    Dim con As MySqlConnection = New MySqlConnection(constr)
    Dim query As String
    Dim da As MySqlDataAdapter
    Public Sub loadlist()
        Dim sql As MySqlCommand = New MySqlCommand("select * from v_studrec", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_list.DataSource = ds
        dgv_list.DataMember = "rec"
    End Sub
    Private Sub StudentList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadlist()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged
        Dim sql As MySqlCommand = New MySqlCommand("select * from v_studrec where full_name like '%" & txtsearch.Text & "%' ", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_list.DataSource = ds
        dgv_list.DataMember = "rec"
    End Sub

    Private Sub dgv_list_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_list.CellContentClick
        Dim i As Integer
        i = dgv_list.CurrentRow.Index
        Student_Record.sr_txtid.Text = dgv_list.Item(0, i).Value
        Student_Record.ShowDialog()


    End Sub
End Class