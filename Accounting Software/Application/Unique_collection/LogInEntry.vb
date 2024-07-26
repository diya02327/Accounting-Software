Imports System.Data.SqlClient
Public Class LogInEntry
    Dim constr As String = "Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True"
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim dap As Object

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        'If ddlUserName.Text = "Admin" Then
        '    If txtUserId.Text = "admin" And txtPassword.Text = "admin" Then
        '        DashboardEntry.Show()
        '        Me.Hide()
        '    Else
        '        MsgBox("Password incorrect")
        '        txtPassword.Clear()
        '        txtUserId.Clear()
        '    End If
        'Else
        '    If txtUserId.Text = "manager" And txtPassword.Text = "manager" Then
        '        DashBoardEntry1.Show()
        '        Me.Hide()
        '    Else
        '        MsgBox("Password incorrect")
        '        txtPassword.Clear()
        '        txtUserId.Clear()
        '    End If
        'End If
     
        Dim connectionString As String = "Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True"
        Dim con As New SqlConnection("Data Source=LAPTOP-OGMJMVM7\SPARTA;Initial Catalog=UNIQUE_COLLECTION;Integrated Security=True")
        Using connection As New SqlConnection(connectionString)

            cmd = New SqlCommand("select * from ADM_REGI where USER_ID=@USER_ID AND PASSWORD=@PASSWORD", con)
            cmd.Parameters.AddWithValue("@USER_ID", txtUserId.Text)
            cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text)
            adapter = New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            adapter.Fill(ds)
            dap = New SqlDataAdapter(cmd)
            ds = New DataSet
            If dap.Fill(ds) Then

                'LogInEntry.lblID.Text = txtUserId.Text
                DashboardEntry.Show()
                Me.Hide()
            Else
                MsgBox("Username OR Password Not Match")
                txtPassword.Clear()
                txtUserId.Clear()

            End If

        End Using
    End Sub



End Class