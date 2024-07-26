Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class SalesReportEntry
    Dim index As Integer
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dap As SqlDataAdapter

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SalesReportEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        con = New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("select * from View_1", con)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds, "datax")
        DataGridView1.DataMember = "datax"
        DataGridView1.DataSource = ds
    End Sub

    

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cmd = New SqlCommand("select * from View_1", con)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds, "datax")
        DataGridView1.DataMember = "datax"
        DataGridView1.DataSource = ds
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'cmd = New SqlCommand("select * from View_1 where INVOICE_DATE BETWEEN '' &, con)
        'dap = New SqlDataAdapter(cmd)
        'cmd.Parameters.AddWithValue("@1", DateTimePicker2.Text)
        'ds = New DataSet
        'dap.Fill(ds, "datax")
        'DataGridView1.DataMember = "datax"
        'DataGridView1.DataSource = ds
        cmd = New SqlCommand("select  * from MNG_SALE_PANEL where INVOICE_NO=@1 AND INVOICE_DATE between'" + DateTimePicker1.Value.ToString + "' and '" + DateTimePicker2.Value.ToString + "'", con)
    End Sub

    Private Sub btnDailySales_Click(sender As Object, e As EventArgs) Handles btnDailySales.Click
        cmd = New SqlCommand("select * from View_1 where INVOICE_DATE=@1", con)
        dap = New SqlDataAdapter(cmd)
        cmd.Parameters.AddWithValue("@1", DateTimePicker1.Text)
        ds = New DataSet
        dap.Fill(ds, "datax")
        DataGridView1.DataMember = "datax"
        DataGridView1.DataSource = ds
    End Sub

   
    
    Private Sub ddlPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPayment.SelectedIndexChanged
        cmd = New SqlCommand("select * from View_1 where PAYMENT_TYPE=@1", con)
        dap = New SqlDataAdapter(cmd)
        cmd.Parameters.AddWithValue("@1", ddlPayment.Text)
        ds = New DataSet
        dap.Fill(ds, "datax")
        DataGridView1.DataMember = "datax"
        DataGridView1.DataSource = ds
    End Sub
End Class