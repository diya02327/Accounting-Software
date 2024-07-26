Public Class DashBoardEntry1

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        CityEntry.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        SalesEntry.Show()
    End Sub

    Private Sub NewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAccountToolStripMenuItem.Click
        ItemMasterEntry.Show()
    End Sub

    Private Sub ReciptVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReciptVoucherToolStripMenuItem.Click
        ReciptVoucherEntry.Show()
    End Sub
End Class