Public Class DashboardEntry

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click

    End Sub

    Private Sub NewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAccountToolStripMenuItem.Click
        AccoountCreateEntry.Show()

    End Sub

    Private Sub SalesInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesInvoiceToolStripMenuItem.Click
        SalesEntry.Show()

    End Sub

    Private Sub NewItemMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewItemMasterToolStripMenuItem.Click
        ItemMasterEntry.Show()

    End Sub

    Private Sub CountraVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountraVoucherToolStripMenuItem.Click
        ContraVoucherEntry.Show()

    End Sub

    Private Sub ReciptVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReciptVoucherToolStripMenuItem.Click
        ReciptVoucherEntry.Show()

    End Sub

    Private Sub CompanyEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyEntryToolStripMenuItem.Click
        CompanyCreate.Show()

    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub DashboardEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        RegistrationEntry.Show()
    End Sub

    Private Sub CityEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CityEntryToolStripMenuItem.Click
        CityEntry.Show()
    End Sub

    Private Sub PackEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackEntryToolStripMenuItem.Click
        PackEntry.Show()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        SalesReportEntry.Show()
    End Sub
End Class