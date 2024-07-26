Imports System.Data
Imports System.Data.SqlClient
Public Class PaymentVoucherEntry
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dap As SqlDataAdapter

    Private Sub PaymentVoucherEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        con = New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        con.Open()
        MsgBox("cnnection is open")
        cmd = New SqlCommand("Select DISTINCT LEDGER_NAME from MNG_LEDGER where LEDGER_TYPE=@1 OR LEDGER_TYPE=@2", con)
        cmd.Parameters.AddWithValue("@1", "SUPPLIER")
        cmd.Parameters.AddWithValue("@2", "CUSTOMER")

        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds)
        For index = 0 To ds.Tables(0).Rows.Count - 1
            ddlCr.Items.Add(ds.Tables(0).Rows(index).Item(0).ToString)
        Next
        cmd = New SqlCommand("Select DISTINCT LEDGER_NAME from MNG_LEDGER where LEDGER_TYPE=@1 OR LEDGER_TYPE=@2", con)
        cmd.Parameters.AddWithValue("@1", "CUSTOMER")
        cmd.Parameters.AddWithValue("@2", "SUPPLIER")

        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds)
        For index = 0 To ds.Tables(0).Rows.Count - 1
            ddlDr.Items.Add(ds.Tables(0).Rows(index).Item(0).ToString)
        Next

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ddlCr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCr.SelectedIndexChanged
        cmd = New SqlCommand("select * from MNG_LEDGER where LEDGER_NAME=@2", con)
        cmd.Parameters.AddWithValue("@2", ddlCr.Text)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        If dap.Fill(ds) Then
            ddlCr.Text = ds.Tables(0).Rows(0).Item(2).ToString
            txtBalanceCr.Text = ds.Tables(0).Rows(0).Item(10).ToString
        End If
    End Sub

    Private Sub ddlDr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDr.SelectedIndexChanged
        cmd = New SqlCommand("select * from MNG_LEDGER where LEDGER_NAME=@2", con)
        cmd.Parameters.AddWithValue("@2", ddlDr.Text)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        If dap.Fill(ds) Then
            ddlDr.Text = ds.Tables(0).Rows(0).Item(2).ToString
            txtBalanceDr.Text = ds.Tables(0).Rows(0).Item(10).ToString
        End If
    End Sub

    'Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblNowBalanceCr.Click
    '    lblNowBalanceCr.Text() = Val(txtBalanceCr.Text) - Val(txtAmount.Text)
    'End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        lblNowBalanceCr.Text() = Val(txtBalanceCr.Text) - Val(txtAmount.Text)
        lblNowBalanceDr.Text() = Val(txtBalanceDr.Text) - Val(txtAmount.Text)
    End Sub
End Class