Imports System.Data
Imports System.Data.SqlClient
Public Class ItemMasterEntry
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dap As SqlDataAdapter
    
    Private Sub ItemMasterEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        con.Open()
        MsgBox("cnnection is open")
        DataClear()
    End Sub

   

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmd = New SqlCommand("insert into MNG_ITEM_MASTER values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)", con)
        cmd.Parameters.AddWithValue("@1", txtItemCode.Text)
        cmd.Parameters.AddWithValue("@2", txtItemName.Text)
        cmd.Parameters.AddWithValue("@3", ddlCompanyName.Text)
        cmd.Parameters.AddWithValue("@4", ddlPack.Text)
        cmd.Parameters.AddWithValue("@5", txtHSNCode.Text)
        cmd.Parameters.AddWithValue("@6", txtMRP.Text)
        cmd.Parameters.AddWithValue("@7", txtLandingPrice.Text)
        cmd.Parameters.AddWithValue("@8", txtCompanyDisc.Text)
        cmd.Parameters.AddWithValue("@9", txtOpeningStock.Text)
        cmd.Parameters.AddWithValue("@10", txtCGST.Text)
        cmd.Parameters.AddWithValue("@11", txtSGST.Text)
        cmd.Parameters.AddWithValue("@12", txtSalesPrice.Text)
        cmd.Parameters.AddWithValue("@13", txtNarration.Text)
        cmd.ExecuteNonQuery()

        MsgBox("Data Saved")
        DataClear()
    End Sub

    Public Function DataClear() As Boolean
        txtItemCode.Clear()
        txtItemName.Clear()
        txtHSNCode.Clear()
        txtMRP.Clear()
        txtLandingPrice.Clear()
        txtCompanyDisc.Clear()
        txtOpeningStock.Clear()
        txtCGST.Clear()
        txtSGST.Clear()
        txtSalesPrice.Clear()
        txtNarration.Clear()
        btnSave.Visible = True
        btnUpdate.Visible = False
        cmd = New SqlCommand("select ITEM_CODE, ITEM_NAME, COMPANY_NAME, PACK, HSN_CODE, MRP,ITEM_LANDING_PRICE, COMPANY_DISC, OPENING_STOCK, CGST, SGST, SALES_PRICE, NARRATION , MNG_ITEM_MASTER_ID from MNG_ITEM_MASTER", con)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds, "datax")
        DataGridView1.DataMember = "datax"
        DataGridView1.DataSource = ds
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataClear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow = DataGridView1.Rows(index)
        txtItemCode.Text = SelectedRow.Cells(0).Value.ToString()
        txtItemName.Text = SelectedRow.Cells(1).Value.ToString()
        txtHSNCode.Text = SelectedRow.Cells(2).Value.ToString()
        txtMRP.Text = SelectedRow.Cells(3).Value.ToString()
        txtLandingPrice.Text = SelectedRow.Cells(4).Value.ToString()
        txtCompanyDisc.Text = SelectedRow.Cells(5).Value.ToString()
        txtOpeningStock.Text = SelectedRow.Cells(6).Value.ToString()
        txtCGST.Text = SelectedRow.Cells(7).Value.ToString()
        txtSGST.Text = SelectedRow.Cells(8).Value.ToString()
        txtSalesPrice.Text = SelectedRow.Cells(9).Value.ToString()
        txtNarration.Text = SelectedRow.Cells(10).Value.ToString()
        lblID.Text = SelectedRow.Cells(11).Value.ToString()
        btnSave.Visible = False
        btnUpdate.Visible = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cmd = New SqlCommand("UPDATE MNG_ITEM_MASTER SET ITEM_CODE=@1, ITEM_NAME=@2, COMPANY_NAME=@3, PACK=@4, HSN_CODE=@5, MRP=@6, ITEM_LANDING_PRICE=@7, COMPANY_DISC=@8, OPENING_STOCK=@9, CGST=@10, SGST=@11, SALES_PRICE=@12, NARRATION=@13 WHERE MNG_ITEM_MASTER_ID=@ID", con)
        cmd.Parameters.AddWithValue("@ID", lblID.Text)
        cmd.Parameters.AddWithValue("@1", txtItemCode.Text)
        cmd.Parameters.AddWithValue("@2", txtItemName.Text)
        cmd.Parameters.AddWithValue("@3", ddlCompanyName.Text)
        cmd.Parameters.AddWithValue("@4", ddlPack.Text)
        cmd.Parameters.AddWithValue("@5", txtHSNCode.Text)
        cmd.Parameters.AddWithValue("@6", txtMRP.Text)
        cmd.Parameters.AddWithValue("@7", txtLandingPrice.Text)
        cmd.Parameters.AddWithValue("@8", txtCompanyDisc.Text)
        cmd.Parameters.AddWithValue("@9", txtOpeningStock.Text)
        cmd.Parameters.AddWithValue("@10", txtCGST.Text)
        cmd.Parameters.AddWithValue("@11", txtSGST.Text)
        cmd.Parameters.AddWithValue("@12", txtSalesPrice.Text)
        cmd.Parameters.AddWithValue("@13", txtNarration.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved")
        DataClear()
    End Sub
End Class