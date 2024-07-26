Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CityEntry
    Dim index As Integer

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dap As SqlDataAdapter
    Private Sub CityEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        con.Open()
        MsgBox("cnnection is open")
        DataClear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmd = New SqlCommand("insert into MNG_CITY values (@1,@2)", con)
        cmd.Parameters.AddWithValue("@1", txtCityName.Text)
        cmd.Parameters.AddWithValue("@2", txtPincode.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved")
        DataClear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataClear()
    End Sub
    Public Function DataClear() As Boolean
        txtCityName.Clear()
        txtPincode.Clear()

        btnSave.Visible = True
        btnUpdate.Visible = False

        cmd = New SqlCommand("select CITY_NAME,PINCODE, MNG_CITY_ID from MNG_CITY", con)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds, "datax")
        DataGridView1.DataMember = "datax"
        DataGridView1.DataSource = ds
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow = DataGridView1.Rows(index)
        txtCityName.Text = SelectedRow.Cells(0).Value.ToString()
        txtPincode.Text = SelectedRow.Cells(1).Value.ToString()
        lblID.Text = SelectedRow.Cells(2).Value.ToString()

        btnSave.Visible = False
        btnUpdate.Visible = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cmd = New SqlCommand("UPDATE MNG_CITY SET CITY_NAME=@1, PINCODE=@2 WHERE MNG_CITY_ID=@ID", con)
        cmd.Parameters.AddWithValue("@ID", lblID.Text)
        cmd.Parameters.AddWithValue("@1", txtCityName.Text)
        cmd.Parameters.AddWithValue("@2", txtPincode.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved")
        DataClear()
    End Sub

End Class