Imports System.Data
Imports System.Data.SqlClient

Public Class AccoountCreateEntry
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dap As SqlDataAdapter

    Private Sub AccoountCreateEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        con.Open()
        MsgBox("cnnection is open")
        DataClear()
    End Sub

    

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmd = New SqlCommand("insert into MNG_LEDGER values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11)", con)
        cmd.Parameters.AddWithValue("@1", txtUniqueCode.Text)
        cmd.Parameters.AddWithValue("@2", txtLedgerName.Text)
        cmd.Parameters.AddWithValue("@3", ddlLedgerType.Text)
        cmd.Parameters.AddWithValue("@4", txtMobileNo.Text)
        cmd.Parameters.AddWithValue("@5", txtAddress.Text)
        cmd.Parameters.AddWithValue("@6", ddlCity.Text)
        cmd.Parameters.AddWithValue("@7", txtGSTINNo.Text)
        cmd.Parameters.AddWithValue("@8", txtAdharNo.Text)
        cmd.Parameters.AddWithValue("@9", txtPanNo.Text)
        cmd.Parameters.AddWithValue("@10", txtOpeningBal.Text)
        cmd.Parameters.AddWithValue("@11", txtNarration.Text)

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

        txtUniqueCode.Clear()
        txtLedgerName.Clear()
        txtMobileNo.Clear()
        txtAddress.Clear()
        txtGSTINNo.Clear()
        txtAdharNo.Clear()
        txtPanNo.Clear()
        txtOpeningBal.Clear()
        txtNarration.Clear()
        btnSave.Visible = True
        btnUpdate.Visible = False
       
    End Function

End Class