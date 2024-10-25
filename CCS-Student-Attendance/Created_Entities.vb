Imports MySql.Data.MySqlClient

Public Class Created_Entities
    Dim constr As String = "data source=localhost;database=dbattendanceforcs;user id=root;password=;"
    Dim con As MySqlConnection = New MySqlConnection(constr)
    Dim query As String
    Dim da As MySqlDataAdapter
    Public Sub loadentities()
        Dim sql As MySqlCommand = New MySqlCommand("show tables", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_entities.DataSource = ds
        dgv_entities.DataMember = "rec"
    End Sub
    Public Sub loadvalues()

    End Sub
    Private Sub Created_Entities_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgv_entities.RowHeadersVisible = False

        loadentities()

    End Sub

    Private Sub dgv_entities_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_entities.CellContentClick
        Dim i As Integer
        i = dgv_entities.CurrentRow.Index
        TextBox1.Text = dgv_entities.Item(0, i).Value.ToString


    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim sql As MySqlCommand = New MySqlCommand("select * from " & TextBox1.Text & " ", con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As DataSet = New DataSet
        da.SelectCommand = sql
        da.Fill(ds, "rec")
        dgv_values.DataSource = ds
        dgv_values.DataMember = "rec"
    End Sub
End Class