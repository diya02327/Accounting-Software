Imports System.Data
Imports System.Data.SqlClient

Public Class RegistrationEntry
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dap As SqlDataAdapter
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        
    End Sub

    Private Sub RegistrationEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        con.Open()
        MsgBox("cnnection is open")
        DataClear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmd = New SqlCommand("insert into ADM_REGI values (@1,@2,@3,@4,@5,@6)", con)
        cmd.Parameters.AddWithValue("@1", txtName.Text)
        cmd.Parameters.AddWithValue("@2", txtCompanyName.Text)
        cmd.Parameters.AddWithValue("@3", txtMobileNo.Text)
        cmd.Parameters.AddWithValue("@4", txtEmailId.Text)
        cmd.Parameters.AddWithValue("@5", txtUserId.Text)
        cmd.Parameters.AddWithValue("@6", txtPassword.Text)
        cmd.ExecuteNonQuery()

        MsgBox("Data Saved")
        DataClear()
    End Sub

    Public Function DataClear() As Boolean
        txtName.Clear()
        txtCompanyName.Clear()
        txtMobileNo.Clear()
        txtEmailId.Clear()
        txtUserId.Clear()
        txtPassword.Clear()

        btnSave.Visible = True
        btnUpdate.Visible = False

        cmd = New SqlCommand("select NAME, COMPANY_NAME, MOBILE_NO, EMAIL_ID, USER_ID, PASSWORD, ADM_REGI_ID from ADM_REGI", con)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds, "datax")
        DataGridView1.DataMember = "datax"
        DataGridView1.DataSource = ds
    End Function
    
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataClear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow = DataGridView1.Rows(index)
        txtName.Text = SelectedRow.Cells(0).Value.ToString()
        txtCompanyName.Text = SelectedRow.Cells(1).Value.ToString()
        txtMobileNo.Text = SelectedRow.Cells(2).Value.ToString()
        txtEmailId.Text = SelectedRow.Cells(3).Value.ToString()
        txtUserId.Text = SelectedRow.Cells(4).Value.ToString()
        txtPassword.Text = SelectedRow.Cells(5).Value.ToString()

        lblID.Text = SelectedRow.Cells(6).Value.ToString()

        btnSave.Visible = False
        btnUpdate.Visible = True
    End Sub
   
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cmd = New SqlCommand("UPDATE ADM_REGI SET NAME=@1, COMPANY_NAME=@2, MOBILE_NO=@3, EMAIL_ID=@4, USER_ID=@5, PASSWORD=@6 WHERE ADM_REGI_ID=@ID", con)
        cmd.Parameters.AddWithValue("@ID", lblID.Text)
        cmd.Parameters.AddWithValue("@1", txtName.Text)
        cmd.Parameters.AddWithValue("@2", txtCompanyName.Text)
        cmd.Parameters.AddWithValue("@3", txtMobileNo.Text)
        cmd.Parameters.AddWithValue("@4", txtEmailId.Text)
        cmd.Parameters.AddWithValue("@5", txtUserId.Text)
        cmd.Parameters.AddWithValue("@6", txtPassword.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved")
        DataClear()
    End Sub

    
End Class