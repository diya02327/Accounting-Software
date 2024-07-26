<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewItemMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountraVoucherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciptVoucherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 40)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1117, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.ManageNewToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.MasterToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1117, 40)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.RegistrationToolStripMenuItem})
        Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(142, 36)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesInvoiceToolStripMenuItem, Me.SalesReportToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(216, 36)
        Me.SalesToolStripMenuItem.Text = "Sales Entry"
        '
        'SalesInvoiceToolStripMenuItem
        '
        Me.SalesInvoiceToolStripMenuItem.Name = "SalesInvoiceToolStripMenuItem"
        Me.SalesInvoiceToolStripMenuItem.Size = New System.Drawing.Size(227, 36)
        Me.SalesInvoiceToolStripMenuItem.Text = "Sales Invoice"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(216, 36)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'ManageNewToolStripMenuItem
        '
        Me.ManageNewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewItemMasterToolStripMenuItem, Me.NewAccountToolStripMenuItem})
        Me.ManageNewToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageNewToolStripMenuItem.Name = "ManageNewToolStripMenuItem"
        Me.ManageNewToolStripMenuItem.Size = New System.Drawing.Size(169, 36)
        Me.ManageNewToolStripMenuItem.Text = "Manage New"
        '
        'NewItemMasterToolStripMenuItem
        '
        Me.NewItemMasterToolStripMenuItem.Name = "NewItemMasterToolStripMenuItem"
        Me.NewItemMasterToolStripMenuItem.Size = New System.Drawing.Size(232, 36)
        Me.NewItemMasterToolStripMenuItem.Text = "Add Item"
        '
        'NewAccountToolStripMenuItem
        '
        Me.NewAccountToolStripMenuItem.Name = "NewAccountToolStripMenuItem"
        Me.NewAccountToolStripMenuItem.Size = New System.Drawing.Size(232, 36)
        Me.NewAccountToolStripMenuItem.Text = "New Account"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CountraVoucherToolStripMenuItem, Me.ReciptVoucherToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(147, 36)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'CountraVoucherToolStripMenuItem
        '
        Me.CountraVoucherToolStripMenuItem.Name = "CountraVoucherToolStripMenuItem"
        Me.CountraVoucherToolStripMenuItem.Size = New System.Drawing.Size(269, 36)
        Me.CountraVoucherToolStripMenuItem.Text = "Countra Voucher"
        '
        'ReciptVoucherToolStripMenuItem
        '
        Me.ReciptVoucherToolStripMenuItem.Name = "ReciptVoucherToolStripMenuItem"
        Me.ReciptVoucherToolStripMenuItem.Size = New System.Drawing.Size(269, 36)
        Me.ReciptVoucherToolStripMenuItem.Text = "Recipt Voucher"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyEntryToolStripMenuItem, Me.CityEntryToolStripMenuItem, Me.PackEntryToolStripMenuItem})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(100, 36)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'CompanyEntryToolStripMenuItem
        '
        Me.CompanyEntryToolStripMenuItem.Name = "CompanyEntryToolStripMenuItem"
        Me.CompanyEntryToolStripMenuItem.Size = New System.Drawing.Size(253, 36)
        Me.CompanyEntryToolStripMenuItem.Text = "Company Entry"
        '
        'CityEntryToolStripMenuItem
        '
        Me.CityEntryToolStripMenuItem.Name = "CityEntryToolStripMenuItem"
        Me.CityEntryToolStripMenuItem.Size = New System.Drawing.Size(253, 36)
        Me.CityEntryToolStripMenuItem.Text = "City Entry"
        '
        'PackEntryToolStripMenuItem
        '
        Me.PackEntryToolStripMenuItem.Name = "PackEntryToolStripMenuItem"
        Me.PackEntryToolStripMenuItem.Size = New System.Drawing.Size(253, 36)
        Me.PackEntryToolStripMenuItem.Text = "Pack Entry"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(102, 36)
        Me.ReportToolStripMenuItem.Text = "Logout"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(227, 36)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'DashboardEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Unique_collection.My.Resources.Resources.im
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1117, 622)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DashboardEntry"
        Me.Text = "UNQUE COLLECTION  [ V.1.1 ]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewItemMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountraVoucherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReciptVoucherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CityEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PackEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
