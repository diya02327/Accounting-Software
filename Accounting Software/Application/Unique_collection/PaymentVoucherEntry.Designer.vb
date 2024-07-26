<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentVoucherEntry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblPaymentVoucher = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.lblNarration = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNowBalanceDr = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ddlDr = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNowBalanceCr = New System.Windows.Forms.Label()
        Me.txtVoucherNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalCollection = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ddlCr = New System.Windows.Forms.ComboBox()
        Me.lblCr = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtBalanceCr = New System.Windows.Forms.TextBox()
        Me.txtBalanceDr = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblPaymentVoucher)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1178, 62)
        Me.Panel1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.Unique_collection.My.Resources.Resources.icons8_close_30
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.Location = New System.Drawing.Point(1113, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(61, 56)
        Me.btnClose.TabIndex = 21
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblPaymentVoucher
        '
        Me.lblPaymentVoucher.AutoSize = True
        Me.lblPaymentVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentVoucher.Location = New System.Drawing.Point(12, 9)
        Me.lblPaymentVoucher.Name = "lblPaymentVoucher"
        Me.lblPaymentVoucher.Size = New System.Drawing.Size(240, 32)
        Me.lblPaymentVoucher.TabIndex = 20
        Me.lblPaymentVoucher.Text = "Payment Voucher"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(718, 615)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(221, 55)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(945, 615)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(221, 55)
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(718, 615)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(221, 55)
        Me.btnUpdate.TabIndex = 37
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(718, 453)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(448, 118)
        Me.txtNarration.TabIndex = 36
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNarration.Location = New System.Drawing.Point(572, 453)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(140, 32)
        Me.lblNarration.TabIndex = 35
        Me.lblNarration.Text = "Narration:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-3, 539)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 32)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Doc Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 539)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(340, 48)
        Me.DateTimePicker1.TabIndex = 34
        '
        'txtDocNo
        '
        Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(143, 464)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(340, 48)
        Me.txtDocNo.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 32)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Doc. No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBalanceDr)
        Me.GroupBox2.Controls.Add(Me.lblNowBalanceDr)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ddlDr)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1177, 173)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Debitors Details"
        '
        'lblNowBalanceDr
        '
        Me.lblNowBalanceDr.AutoSize = True
        Me.lblNowBalanceDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNowBalanceDr.Location = New System.Drawing.Point(395, 126)
        Me.lblNowBalanceDr.Name = "lblNowBalanceDr"
        Me.lblNowBalanceDr.Size = New System.Drawing.Size(266, 25)
        Me.lblNowBalanceDr.TabIndex = 18
        Me.lblNowBalanceDr.Text = "(Now: Now Balance               )"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(889, 34)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(264, 48)
        Me.txtAmount.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(762, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 32)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Amount:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Balance:"
        '
        'ddlDr
        '
        Me.ddlDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlDr.FormattingEnabled = True
        Me.ddlDr.Location = New System.Drawing.Point(141, 40)
        Me.ddlDr.Name = "ddlDr"
        Me.ddlDr.Size = New System.Drawing.Size(520, 48)
        Me.ddlDr.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(74, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 32)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Dr:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox1.Controls.Add(Me.txtBalanceCr)
        Me.GroupBox1.Controls.Add(Me.lblNowBalanceCr)
        Me.GroupBox1.Controls.Add(Me.txtVoucherNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblTotalCollection)
        Me.GroupBox1.Controls.Add(Me.lblFrom)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.ddlCr)
        Me.GroupBox1.Controls.Add(Me.lblCr)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1177, 173)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creditors Details"
        '
        'lblNowBalanceCr
        '
        Me.lblNowBalanceCr.AutoSize = True
        Me.lblNowBalanceCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNowBalanceCr.Location = New System.Drawing.Point(395, 126)
        Me.lblNowBalanceCr.Name = "lblNowBalanceCr"
        Me.lblNowBalanceCr.Size = New System.Drawing.Size(266, 25)
        Me.lblNowBalanceCr.TabIndex = 18
        Me.lblNowBalanceCr.Text = "(Now: Now Balance               )"
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherNo.Location = New System.Drawing.Point(889, 103)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(264, 48)
        Me.txtVoucherNo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(711, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 32)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Voucher No:"
        '
        'lblTotalCollection
        '
        Me.lblTotalCollection.AutoSize = True
        Me.lblTotalCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCollection.Location = New System.Drawing.Point(6, 126)
        Me.lblTotalCollection.Name = "lblTotalCollection"
        Me.lblTotalCollection.Size = New System.Drawing.Size(89, 25)
        Me.lblTotalCollection.TabIndex = 14
        Me.lblTotalCollection.Text = "Balance:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(800, 34)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(83, 32)
        Me.lblFrom.TabIndex = 12
        Me.lblFrom.Text = "Date:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(889, 34)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(264, 48)
        Me.DateTimePicker2.TabIndex = 13
        '
        'ddlCr
        '
        Me.ddlCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlCr.FormattingEnabled = True
        Me.ddlCr.Location = New System.Drawing.Point(132, 34)
        Me.ddlCr.Name = "ddlCr"
        Me.ddlCr.Size = New System.Drawing.Size(520, 48)
        Me.ddlCr.TabIndex = 11
        '
        'lblCr
        '
        Me.lblCr.AutoSize = True
        Me.lblCr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCr.Location = New System.Drawing.Point(74, 34)
        Me.lblCr.Name = "lblCr"
        Me.lblCr.Size = New System.Drawing.Size(52, 32)
        Me.lblCr.TabIndex = 2
        Me.lblCr.Text = "Cr:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(255, 64)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(33, 7)
        Me.lblID.TabIndex = 22
        Me.lblID.Text = "City Name:"
        '
        'txtBalanceCr
        '
        Me.txtBalanceCr.Location = New System.Drawing.Point(95, 127)
        Me.txtBalanceCr.Name = "txtBalanceCr"
        Me.txtBalanceCr.Size = New System.Drawing.Size(121, 26)
        Me.txtBalanceCr.TabIndex = 40
        '
        'txtBalanceDr
        '
        Me.txtBalanceDr.Location = New System.Drawing.Point(95, 127)
        Me.txtBalanceDr.Name = "txtBalanceDr"
        Me.txtBalanceDr.Size = New System.Drawing.Size(121, 26)
        Me.txtBalanceDr.TabIndex = 39
        '
        'PaymentVoucherEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1178, 685)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.lblNarration)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtDocNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentVoucherEntry"
        Me.Text = "PaymentVoucherEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblPaymentVoucher As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents lblNarration As System.Windows.Forms.Label
    Protected WithEvents Label10 As System.Windows.Forms.Label
    Protected WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNowBalanceDr As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ddlDr As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNowBalanceCr As System.Windows.Forms.Label
    Friend WithEvents txtVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCollection As System.Windows.Forms.Label
    Protected WithEvents lblFrom As System.Windows.Forms.Label
    Protected WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ddlCr As System.Windows.Forms.ComboBox
    Friend WithEvents lblCr As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtBalanceCr As System.Windows.Forms.TextBox
    Friend WithEvents txtBalanceDr As System.Windows.Forms.TextBox
End Class
