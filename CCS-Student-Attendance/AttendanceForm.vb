Imports MySql.Data.MySqlClient

Public Class AttendanceForm
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
        dgv_select.RowHeadersVisible = False

    End Sub
    Private Sub AttendanceForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadselectstudents()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Select_student.Show()

    End Sub
   
    Public Sub updateEventAttendance()
        Dim cmd As MySqlCommand = New MySqlCommand(query, con)

        query = "update " & lblev_id.Text & " set " & lblmode.Text & " = '1' where id_no = '" & txtid_no.Text & "'    "
        cmd = New MySqlCommand(query, con)
        Dim i As Integer = cmd.ExecuteNonQuery()
        MsgBox("Attendance Added on " & lblmode.Text & " of " & lblev_id.Text & " ")

    End Sub
    Private Sub btnsubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnsubmit.Click
        If txtid_no.Text = "" Or txttracecode.Text = "" Or lblev_id.Text = "[event_id]" Then
            MsgBox("Something went Wrong. Check your input.")
        Else
            Try
                Dim cmd As MySqlCommand = New MySqlCommand(query, con)
                con.Open()
                query = "insert into tbl_attendance_log(id_no,at_for,event_id,dt_log,tracecode)values('" & txtid_no.Text & "','" & lblmode.Text & "','" & lblev_id.Text & "',now(),'" & txttracecode.Text & "')      "
                cmd = New MySqlCommand(query, con)
                Dim i As Integer = cmd.ExecuteNonQuery()
                MsgBox("successfully Submitted to Attendance Log")
                updateEventAttendance()

                con.Close()
                txtid_no.Text = ""
                txtfullname.Text = ""
                txtcourse.Text = ""
                txtyear.Text = ""
                txttracecode.Text = ""

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()

            End Try

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim sql As MySqlCommand = New MySqlCommand("select * from v_studrec where id_no like '%" & TextBox1.Text & "%' or full_name like '%" & TextBox1.Text & "%'  ", con)
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
        txtid_no.Text = dgv_select.Item(0, i).Value
        txtfullname.Text = dgv_select.Item(1, i).Value
        txtcourse.Text = dgv_select.Item(2, i).Value
        txtyear.Text = dgv_select.Item(3, i).Value

        Dim stracecode As String = lblev_id.Text + txtid_no.Text + lblmode.Text
        txttracecode.Text = stracecode
    End Sub
End Class