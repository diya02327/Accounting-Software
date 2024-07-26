Imports System.Data
Imports System.Data.SqlClient

Public Class CompanyCreate
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dap As SqlDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        con.Open()
        MsgBox("cnnection is open")
        DataClear()
    End Sub

    Private Sub txtCompanyName_TextChanged(sender As Object, e As EventArgs) Handles txtCompanyName.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmd = New SqlCommand("insert into MNG_COMPANY values (@1)", con)
        cmd.Parameters.AddWithValue("@1", txtCompanyName.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved")
        DataClear()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataClear()
    End Sub
    Public Function DataClear() As Boolean
        txtCompanyName.Clear()
        btnSave.Visible = True
        btnUpdate.Visible = False
        cmd = New SqlCommand("select COMPANY_NAME, MNG_COMPANY_ID from MNG_COMPANY", con)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds, "datax")
        DataGridView1.DataMember = "datax"
        DataGridView1.DataSource = ds
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        cmd = New SqlCommand("UPDATE MNG_COMPANY SET COMPANY_NAME=@1 WHERE MNG_COMPANY_ID=@ID", con)
        cmd.Parameters.AddWithValue("@ID", lblID.Text)
        cmd.Parameters.AddWithValue("@1", txtCompanyName.Text)

        cmd.ExecuteNonQuery()
        MsgBox("Data Saved")
        DataClear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
        
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow = DataGridView1.Rows(index)
        txtCompanyName.Text = SelectedRow.Cells(0).Value.ToString()
        lblID.Text = SelectedRow.Cells(1).Value.ToString()

        btnSave.Visible = False
        btnUpdate.Visible = True
    End Sub
End Class
