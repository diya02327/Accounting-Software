Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class SalesEntry
    Dim index As Integer
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dap As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub SalesEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        con = New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        con.Open()
        MsgBox("cnnection is open")
        dataclear()
    End Sub

    Public Function dataclear() As Boolean
        btnUpdateandClear.Enabled = True

        txtGiven.Clear()
        txtReturn.Clear()
        txtItemCode1.Clear()
        txtHSN.Clear()
        txtMRP.Clear()
        txtSellingPrice.Clear()
        txtQnt.Clear()
        txtDisc.Clear()
        txtTotal.Clear()
        txtC_Per.Clear()
        txtC_Val.Clear()
        txtS_per.Clear()
        txtS_Val.Clear()
        txtTotalAmt.Clear()
        ddlProductName.SelectedIndex = -1
        txtQnt.Text = "1"

        txtTotal.Clear()
        txtGrandTotal.Clear()

        ListView1.Items.Clear()
        '  txtSubTotal.Text = subtotl()
        ddlPaymentType.Text = "Cash"
        ddlPaymentType.Text = "Online Payment"
        ddlProductName.Items.Clear()

        cmd = New SqlCommand("Select DISTINCT ITEM_NAME from MNG_ITEM_MASTER ", con)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds)
        For index = 0 To ds.Tables(0).Rows.Count - 1
            ddlProductName.Items.Add(ds.Tables(0).Rows(index).Item(0).ToString)
        Next

        cmd = New SqlCommand("Select DISTINCT COMPANY_NAME from MNG_COMPANY ", con)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        dap.Fill(ds)
        For index = 0 To ds.Tables(0).Rows.Count - 1
            ddlCompanyName.Items.Add(ds.Tables(0).Rows(index).Item(0).ToString)
        Next

        'Dim FileCount As Integer = (From row In OMSOFT.ADM_SELL_PANELs).Count()
        'txtInvoiceNo.Text = FileCount + 1
        'txtInvoiceNo.Focus()


    End Function


    Private Sub ddlProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlProductName.SelectedIndexChanged
        cmd = New SqlCommand("select * from MNG_ITEM_MASTER where ITEM_NAME = @2", con)
        cmd.Parameters.AddWithValue("@2", ddlProductName.Text)
        dap = New SqlDataAdapter(cmd)
        ds = New DataSet
        If dap.Fill(ds) Then
            txtItemCode1.Text = ds.Tables(0).Rows(0).Item(1).ToString
            ddlProductName.Text = ds.Tables(0).Rows(0).Item(2).ToString
            txtHSN.Text = ds.Tables(0).Rows(0).Item(5).ToString
            txtSellingPrice.Text = ds.Tables(0).Rows(0).Item(12).ToString
            'txtTotal.Text = ds.Tables(0).Rows(0).Item(8).ToString
            txtMRP.Text = ds.Tables(0).Rows(0).Item(6).ToString
            txtQnt.Text = "1"
            txtQnt.Text = ds.Tables(0).Rows(0).Item(9).ToString
            txtDisc.Text = ds.Tables(0).Rows(0).Item(8).ToString

            'txtQnt.Text = "1"
            txtTotal.Text = Val(txtMRP.Text) * Val(txtQnt.Text)
            txtC_Per.Text = ds.Tables(0).Rows(0).Item(10).ToString
            txtC_Val.Text = Val(txtTotal.Text) * Val(txtC_Per.Text) / 100
            txtS_per.Text = ds.Tables(0).Rows(0).Item(11).ToString
            txtS_Val.Text = Val(txtTotal.Text) * Val(txtS_per.Text) / 100
            txtTotalAmt.Text = Val(txtTotal.Text) + Val(txtC_Val.Text) + Val(txtS_Val.Text)

        End If

    End Sub


    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        If (String.IsNullOrEmpty(ddlProductName.Text)) Then
            MessageBox.Show(" Product Name Should not Empty !")
            ddlProductName.Focus()

        Else

            Dim k As Integer
            Dim lst1 As New ListViewItem(k)

            lst1.SubItems.Add(txtItemCode1.Text)
            lst1.SubItems.Add(ddlProductName.Text)
            lst1.SubItems.Add(txtHSN.Text)
            lst1.SubItems.Add(txtMRP.Text)
            lst1.SubItems.Add(txtSellingPrice.Text)
            lst1.SubItems.Add(txtQnt.Text)
            lst1.SubItems.Add(txtDisc.Text)
            lst1.SubItems.Add(txtTotal.Text)
            lst1.SubItems.Add(txtC_Per.Text)
            lst1.SubItems.Add(txtC_Val.Text)
            lst1.SubItems.Add(txtS_per.Text)
            lst1.SubItems.Add(txtS_Val.Text)
            lst1.SubItems.Add(txtTotalAmt.Text)
            ListView1.Items.Add(lst1)
            k = k + 1

            txtSubTotal.Text = subtotl()
            txtCGSTTotal.Text = cgsttotal()
            txtSGSTTTotal.Text = sgsttotal()
            CarttextboxClear()

            ' lastcal()
            ddlProductName.Focus()
        End If
    End Sub
    Public Function subtotl() As Double
        Dim i, j, k As Integer
        i = 0
        j = 0
        k = 0

        Try
            j = ListView1.Items.Count
            For i = 0 To j - 1
                k = k + CInt(ListView1.Items(i).SubItems(13).Text)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return k

    End Function

    Public Function cgsttotal() As Double
        Dim i, j, k As Integer
        i = 0
        j = 0
        k = 0

        Try
            j = ListView1.Items.Count
            For i = 0 To j - 1
                k = k + CInt(ListView1.Items(i).SubItems(10).Text)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return k

    End Function
    Public Function sgsttotal() As Double
        Dim i, j, k As Integer
        i = 0
        j = 0
        k = 0

        Try
            j = ListView1.Items.Count
            For i = 0 To j - 1
                k = k + CInt(ListView1.Items(i).SubItems(12).Text)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return k

    End Function

    Public Function CarttextboxClear() As Boolean
        txtItemCode1.Clear()
        ddlProductName.SelectedIndex = -1
        txtSellingPrice.Clear()
        txtQnt.Text = "1"
        txtTotal.Clear()
    End Function

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        dataclear()
    End Sub

    Private Sub btnRemoveSelected_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click
        Try
            If (ListView1.SelectedItems.Count > 0) Then
                Dim itmCnt, i, t As Integer
                ListView1.FocusedItem.Remove()
                itmCnt = ListView1.Items.Count
                t = 1
                txtSubTotal.Text = subtotl()

                'lastcal()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        ListView1.Items.Clear()
        txtSubTotal.Text = subtotl()

        'lastcal()

    End Sub
    Public Function Datacheck() As Boolean
        Try
            If (String.IsNullOrEmpty(txtInvoiceNumber.Text)) Then
                MessageBox.Show("Invoice No Should Not Empty ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtInvoiceNumber.Focus()
                Return False
            ElseIf (String.IsNullOrEmpty(ddlCompanyName.Text)) Then
                MessageBox.Show("Company Name Should Not Empty !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ddlCompanyName.Focus()
                Return False
            ElseIf ListView1.Items.Count = 0 Then
                MsgBox("Product Cart is Empty")
                ddlProductName.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub txtGiven_TextChanged(sender As Object, e As EventArgs) Handles txtGiven.TextChanged
        txtReturn.Text = Val(txtSubTotal.Text) - Val(txtGiven.Text)
    End Sub

    Private Sub btnUpdateandClear_Click(sender As Object, e As EventArgs) Handles btnUpdateandClear.Click
        cmd = New SqlCommand("insert into MNG_SALES_CART values (@1)", con)
        cmd.Parameters.AddWithValue("@1", txtInvoiceNumber.Text)
        'cmd.Parameters.AddWithValue("@3", txtItemCode1.Text)
        ''cmd.Parameters.AddWithValue("@4", txtP.Text)
        'cmd.Parameters.AddWithValue("@5", txtHSN.Text)
        'cmd.Parameters.AddWithValue("@6", txtMRP.Text)
        'cmd.Parameters.AddWithValue("@7", txtSellingPrice.Text)
        'cmd.Parameters.AddWithValue("@8", txtQnt.Text)
        'cmd.Parameters.AddWithValue("@9", txtDisc.Text)
        'cmd.Parameters.AddWithValue("@11", txtC_Per.Text)
        'cmd.Parameters.AddWithValue("@12", txtC_Val.Text)
        'cmd.Parameters.AddWithValue("@13", txtS_per.Text)
        'cmd.Parameters.AddWithValue("@14", txtS_Val.Text)
        ''cmd.Parameters.AddWithValue("@12", txtSellingPrice.Text)
        cmd.ExecuteNonQuery()

        MsgBox("Data Saved")
        dataclear()
    End Sub
End Class