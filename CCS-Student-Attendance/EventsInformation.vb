Imports MySql.Data.MySqlClient

Public Class EventsInformation
    Dim constr As String = "data source=localhost;database=dbattendanceforcs;user id=root;password=;"
    Dim con As MySqlConnection = New MySqlConnection(constr)
    Dim query As String
    Dim da As MySqlDataAdapter
    Dim compTime As String
    Public Sub loadevents()
        Dim sql As MySqlCommand = New MySqlCommand("select * from tbl_event", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_event.DataSource = ds
        dgv_event.DataMember = "rec"
    End Sub
    Private Sub EventsInformation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadevents()

    End Sub
    Public Sub insertEvent()
        Try
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            con.Open()
            query = "insert into tbl_event(event_id,event_name,event_desc,dt_event,event_status)values('" & txtev_id.Text & "','" & txtev_name.Text & "','" & txtev_desc.Text & "','" & txtdt_event.Text & "','Active')"
            cmd = New MySqlCommand(query, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Event added.")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("The Following are the Errors. No Changes will be made.")


            con.Close()

            Me.Close()
        End Try
        
    End Sub
    Public Sub createEventTable()
        Try
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            con.Open()
            query = " create table " & txtev_id.Text & "( id_no varchar(45), am_login varchar(5), am_logout varchar(5), pm_login varchar(5), pm_logout varchar(5), event_id varchar(45) );  "
            cmd = New MySqlCommand(query, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Event table created.")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
        
    End Sub
    Public Sub insertStudentsInEventCreated()
        Try
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            con.Open()
            query = "insert into " & txtev_id.Text & "(id_no) select id_no from v_studrec "
            cmd = New MySqlCommand(query, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Event loaded with studentlist.")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
        
    End Sub
    Public Sub updateEventlogsToZERO()
        Try
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            con.Open()
            query = "update " & txtev_id.Text & " set am_login = '0', am_logout = '0', pm_login = '0', pm_logout = '0', event_id = '" & txtev_id.Text & "' "
            cmd = New MySqlCommand(query, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Event's logs are updated to Zero(0).")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
        
    End Sub
    Public Sub createEventView()
        Try
            Dim cmd As MySqlCommand = New MySqlCommand(query, con)
            con.Open()
            query = "  create view v_" & txtev_id.Text & " as select " & txtev_id.Text & ".id_no, v_studrec.full_name, " & txtev_id.Text & ".am_login, " & txtev_id.Text & ".am_logout, " & txtev_id.Text & ".pm_login, " & txtev_id.Text & ".pm_logout, " & txtev_id.Text & ".event_id, tbl_event.event_name from " & txtev_id.Text & ",v_studrec,tbl_event where " & txtev_id.Text & ".id_no = v_studrec.id_no and " & txtev_id.Text & ".event_id = tbl_event.event_id  "
            cmd = New MySqlCommand(query, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            MsgBox("Event View Created in the Database.")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
    End Sub
    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click

        insertEvent()
        createEventTable()
        insertStudentsInEventCreated()
        updateEventlogsToZERO()
        createEventView()

        loadevents()
        Form1.loadcurrentEvent()

        clearF()




    End Sub
    Public Sub clearF()
        txtev_id.Text = ""
        txtdt_event.Text = ""
        txtev_desc.Text = ""
        txtev_name.Text = ""
    End Sub
    Private Sub btnclear_Click(sender As System.Object, e As System.EventArgs) Handles btnclear.Click
       
        clearF()

    End Sub
End Class