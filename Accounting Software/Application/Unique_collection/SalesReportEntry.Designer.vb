<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReportEntry
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
        Me.pnlSalesReport = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblSalesReport = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddlPayment = New System.Windows.Forms.ComboBox()
        Me.lblCollection = New System.Windows.Forms.Label()
        Me.lblTotalCollection = New System.Windows.Forms.Label()
        Me.btnGetExcel = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDailySales = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnlSalesReport.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSalesReport
        '
        Me.pnlSalesReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlSalesReport.Controls.Add(Me.btnClose)
        Me.pnlSalesReport.Controls.Add(Me.lblSalesReport)
        Me.pnlSalesReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSalesReport.Location = New System.Drawing.Point(0, 0)
        Me.pnlSalesReport.Name = "pnlSalesReport"
        Me.pnlSalesReport.Size = New System.Drawing.Size(1179, 60)
        Me.pnlSalesReport.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.Unique_collection.My.Resources.Resources.icons8_close_30
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.Location = New System.Drawing.Point(1114, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 54)
        Me.btnClose.TabIndex = 7
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblSalesReport
        '
        Me.lblSalesReport.AutoSize = True
        Me.lblSalesReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesReport.Location = New System.Drawing.Point(12, 9)
        Me.lblSalesReport.Name = "lblSalesReport"
        Me.lblSalesReport.Size = New System.Drawing.Size(179, 32)
        Me.lblSalesReport.TabIndex = 6
        Me.lblSalesReport.Text = "Sales Report"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(35, 18)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(88, 32)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "From:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(140, 78)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(205, 35)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(140, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(205, 35)
        Me.DateTimePicker1.TabIndex = 4
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(67, 78)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(56, 32)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "To:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaShell
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ddlPayment)
        Me.Panel2.Controls.Add(Me.lblCollection)
        Me.Panel2.Controls.Add(Me.lblTotalCollection)
        Me.Panel2.Controls.Add(Me.btnGetExcel)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnDailySales)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.lblFrom)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.lblTo)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.lblID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1179, 178)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(657, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Payment Mode"
        '
        'ddlPayment
        '
        Me.ddlPayment.FormattingEnabled = True
        Me.ddlPayment.Items.AddRange(New Object() {"cash", "Online Payment"})
        Me.ddlPayment.Location = New System.Drawing.Point(650, 94)
        Me.ddlPayment.Name = "ddlPayment"
        Me.ddlPayment.Size = New System.Drawing.Size(212, 28)
        Me.ddlPayment.TabIndex = 11
        '
        'lblCollection
        '
        Me.lblCollection.AutoSize = True
        Me.lblCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollection.ForeColor = System.Drawing.Color.Red
        Me.lblCollection.Location = New System.Drawing.Point(185, 145)
        Me.lblCollection.Name = "lblCollection"
        Me.lblCollection.Size = New System.Drawing.Size(71, 29)
        Me.lblCollection.TabIndex = 10
        Me.lblCollection.Text = "00.00"
        '
        'lblTotalCollection
        '
        Me.lblTotalCollection.AutoSize = True
        Me.lblTotalCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCollection.Location = New System.Drawing.Point(3, 145)
        Me.lblTotalCollection.Name = "lblTotalCollection"
        Me.lblTotalCollection.Size = New System.Drawing.Size(188, 29)
        Me.lblTotalCollection.TabIndex = 9
        Me.lblTotalCollection.Text = "Total Collection:"
        '
        'btnGetExcel
        '
        Me.btnGetExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetExcel.Location = New System.Drawing.Point(990, 16)
        Me.btnGetExcel.Name = "btnGetExcel"
        Me.btnGetExcel.Size = New System.Drawing.Size(177, 80)
        Me.btnGetExcel.TabIndex = 8
        Me.btnGetExcel.Text = "Get Excel"
        Me.btnGetExcel.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Image = Global.Unique_collection.My.Resources.Resources.icons8_reset_48
        Me.btnReset.Location = New System.Drawing.Point(901, 16)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 80)
        Me.btnReset.TabIndex = 7
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDailySales
        '
        Me.btnDailySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailySales.Location = New System.Drawing.Point(466, 27)
        Me.btnDailySales.Name = "btnDailySales"
        Me.btnDailySales.Size = New System.Drawing.Size(135, 95)
        Me.btnDailySales.TabIndex = 6
        Me.btnDailySales.Text = "Daily Sales"
        Me.btnDailySales.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Unique_collection.My.Resources.Resources.icons8_search_48
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSearch.Location = New System.Drawing.Point(382, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 95)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(312, 43)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(33, 7)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "City Name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1179, 466)
        Me.DataGridView1.TabIndex = 6
        '
        'SalesReportEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 715)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlSalesReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesReportEntry"
        Me.Text = "SalesReportEntry"
        Me.pnlSalesReport.ResumeLayout(False)
        Me.pnlSalesReport.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSalesReport As System.Windows.Forms.Panel
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnGetExcel As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnDailySales As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSalesReport As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblCollection As System.Windows.Forms.Label
    Friend WithEvents lblTotalCollection As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ddlPayment As System.Windows.Forms.ComboBox
End Class
