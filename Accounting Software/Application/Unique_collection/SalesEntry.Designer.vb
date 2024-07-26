<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesEntry
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblMNG_Company = New System.Windows.Forms.Label()
        Me.txtS_Val = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.ddlCompanyName = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtTotalAmt = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtS_per = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtC_Val = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtC_Per = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtQnt = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.txtMRP = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtHSN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ddlProductName = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtItemCode1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ddlPaymentType = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtReturn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGiven = New System.Windows.Forms.TextBox()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSGSTTTotal = New System.Windows.Forms.TextBox()
        Me.txtCGSTTotal = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRoundOff = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdateandClear = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HSN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MRP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SellingPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Qnt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Disc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.C = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.S = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Value1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalAmt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.txtS_Val)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtTotalAmt)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.txtS_per)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txtC_Val)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.txtC_Per)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.txtDisc)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtQnt)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtSellingPrice)
        Me.Panel1.Controls.Add(Me.txtMRP)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtHSN)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.ddlProductName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtItemCode1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1672, 241)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.lblMNG_Company)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1666, 48)
        Me.Panel3.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Unique_collection.My.Resources.Resources.icons8_close_20__1_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(1607, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 46)
        Me.Button1.TabIndex = 72
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblMNG_Company
        '
        Me.lblMNG_Company.AutoSize = True
        Me.lblMNG_Company.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblMNG_Company.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMNG_Company.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblMNG_Company.Location = New System.Drawing.Point(8, 4)
        Me.lblMNG_Company.Name = "lblMNG_Company"
        Me.lblMNG_Company.Size = New System.Drawing.Size(156, 29)
        Me.lblMNG_Company.TabIndex = 71
        Me.lblMNG_Company.Text = "Sales Invoice"
        '
        'txtS_Val
        '
        Me.txtS_Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtS_Val.Location = New System.Drawing.Point(1468, 197)
        Me.txtS_Val.Name = "txtS_Val"
        Me.txtS_Val.Size = New System.Drawing.Size(95, 35)
        Me.txtS_Val.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnRemoveAll)
        Me.GroupBox1.Controls.Add(Me.btnRemoveSelected)
        Me.GroupBox1.Controls.Add(Me.btnCart)
        Me.GroupBox1.Controls.Add(Me.ddlCompanyName)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNumber)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1663, 129)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(642, 168)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 25)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "H.S.N"
        '
        'btnReset
        '
        Me.btnReset.Image = Global.Unique_collection.My.Resources.Resources.icons8_reset_48
        Me.btnReset.Location = New System.Drawing.Point(1164, 18)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 71)
        Me.btnReset.TabIndex = 23
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveAll.Image = Global.Unique_collection.My.Resources.Resources.icons8_remove_properties_30
        Me.btnRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveAll.Location = New System.Drawing.Point(988, 18)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(170, 70)
        Me.btnRemoveAll.TabIndex = 32
        Me.btnRemoveAll.Text = "Remove All"
        Me.btnRemoveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSelected.Image = Global.Unique_collection.My.Resources.Resources.icons8_close_30__1_
        Me.btnRemoveSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveSelected.Location = New System.Drawing.Point(795, 18)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(187, 70)
        Me.btnRemoveSelected.TabIndex = 31
        Me.btnRemoveSelected.Text = "Remove Selected"
        Me.btnRemoveSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'btnCart
        '
        Me.btnCart.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.btnCart.Image = Global.Unique_collection.My.Resources.Resources.icons8_cart_48
        Me.btnCart.Location = New System.Drawing.Point(671, 18)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(97, 70)
        Me.btnCart.TabIndex = 30
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'ddlCompanyName
        '
        Me.ddlCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlCompanyName.FormattingEnabled = True
        Me.ddlCompanyName.Location = New System.Drawing.Point(206, 82)
        Me.ddlCompanyName.Name = "ddlCompanyName"
        Me.ddlCompanyName.Size = New System.Drawing.Size(443, 37)
        Me.ddlCompanyName.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(192, 29)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Company Name:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(428, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(221, 35)
        Me.DateTimePicker1.TabIndex = 25
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(206, 25)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(202, 35)
        Me.txtInvoiceNumber.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(188, 29)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Invoice Number:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(258, 45)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(33, 7)
        Me.lblID.TabIndex = 19
        Me.lblID.Text = "City Name:"
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmt.Location = New System.Drawing.Point(1569, 197)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.Size = New System.Drawing.Size(87, 35)
        Me.txtTotalAmt.TabIndex = 61
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(1564, 171)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(96, 25)
        Me.Label33.TabIndex = 60
        Me.Label33.Text = "Total Amt"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(1479, 171)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 25)
        Me.Label30.TabIndex = 55
        Me.Label30.Text = "Value"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(1390, 169)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 25)
        Me.Label29.TabIndex = 54
        Me.Label29.Text = "S%"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(1281, 169)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 25)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "Value"
        '
        'txtS_per
        '
        Me.txtS_per.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtS_per.Location = New System.Drawing.Point(1367, 197)
        Me.txtS_per.Name = "txtS_per"
        Me.txtS_per.Size = New System.Drawing.Size(95, 35)
        Me.txtS_per.TabIndex = 51
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(1202, 169)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 25)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "C%"
        '
        'txtC_Val
        '
        Me.txtC_Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC_Val.Location = New System.Drawing.Point(1266, 197)
        Me.txtC_Val.Name = "txtC_Val"
        Me.txtC_Val.Size = New System.Drawing.Size(95, 35)
        Me.txtC_Val.TabIndex = 49
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(1318, 171)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 25)
        Me.Label26.TabIndex = 48
        '
        'txtC_Per
        '
        Me.txtC_Per.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC_Per.Location = New System.Drawing.Point(1199, 197)
        Me.txtC_Per.Name = "txtC_Per"
        Me.txtC_Per.Size = New System.Drawing.Size(61, 35)
        Me.txtC_Per.TabIndex = 47
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(1110, 169)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 25)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(1098, 197)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(95, 35)
        Me.txtTotal.TabIndex = 45
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1019, 169)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 25)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Disc"
        '
        'txtDisc
        '
        Me.txtDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Location = New System.Drawing.Point(997, 197)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(95, 35)
        Me.txtDisc.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(921, 169)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 25)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Qnt"
        '
        'txtQnt
        '
        Me.txtQnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQnt.Location = New System.Drawing.Point(896, 197)
        Me.txtQnt.Name = "txtQnt"
        Me.txtQnt.Size = New System.Drawing.Size(95, 35)
        Me.txtQnt.TabIndex = 41
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(754, 169)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 25)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Selling Price"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingPrice.Location = New System.Drawing.Point(746, 197)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(144, 35)
        Me.txtSellingPrice.TabIndex = 37
        '
        'txtMRP
        '
        Me.txtMRP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRP.Location = New System.Drawing.Point(637, 197)
        Me.txtMRP.Name = "txtMRP"
        Me.txtMRP.Size = New System.Drawing.Size(94, 35)
        Me.txtMRP.TabIndex = 36
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(660, 171)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 25)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "MRP"
        '
        'txtHSN
        '
        Me.txtHSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHSN.Location = New System.Drawing.Point(537, 197)
        Me.txtHSN.Name = "txtHSN"
        Me.txtHSN.Size = New System.Drawing.Size(94, 35)
        Me.txtHSN.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(552, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 25)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "H.S.N"
        '
        'ddlProductName
        '
        Me.ddlProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlProductName.FormattingEnabled = True
        Me.ddlProductName.Location = New System.Drawing.Point(137, 197)
        Me.ddlProductName.Name = "ddlProductName"
        Me.ddlProductName.Size = New System.Drawing.Size(392, 37)
        Me.ddlProductName.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(263, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Product Name"
        '
        'txtItemCode1
        '
        Me.txtItemCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode1.Location = New System.Drawing.Point(8, 199)
        Me.txtItemCode1.Name = "txtItemCode1"
        Me.txtItemCode1.Size = New System.Drawing.Size(107, 35)
        Me.txtItemCode1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Item Code"
        '
        'ddlPaymentType
        '
        Me.ddlPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlPaymentType.FormattingEnabled = True
        Me.ddlPaymentType.Location = New System.Drawing.Point(721, 17)
        Me.ddlPaymentType.Name = "ddlPaymentType"
        Me.ddlPaymentType.Size = New System.Drawing.Size(269, 37)
        Me.ddlPaymentType.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaShell
        Me.Panel2.Controls.Add(Me.txtReturn)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtGiven)
        Me.Panel2.Controls.Add(Me.txtGrandTotal)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtSGSTTTotal)
        Me.Panel2.Controls.Add(Me.txtCGSTTotal)
        Me.Panel2.Controls.Add(Me.txtSubTotal)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtRoundOff)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnUpdateandClear)
        Me.Panel2.Controls.Add(Me.ddlPaymentType)
        Me.Panel2.Controls.Add(Me.btnClearAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 409)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1672, 252)
        Me.Panel2.TabIndex = 17
        '
        'txtReturn
        '
        Me.txtReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturn.Location = New System.Drawing.Point(214, 172)
        Me.txtReturn.Name = "txtReturn"
        Me.txtReturn.Size = New System.Drawing.Size(270, 35)
        Me.txtReturn.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 29)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Return:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Given:"
        '
        'txtGiven
        '
        Me.txtGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiven.Location = New System.Drawing.Point(214, 117)
        Me.txtGiven.Name = "txtGiven"
        Me.txtGiven.Size = New System.Drawing.Size(270, 35)
        Me.txtGiven.TabIndex = 46
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.Location = New System.Drawing.Point(1242, 169)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Size = New System.Drawing.Size(270, 35)
        Me.txtGrandTotal.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1072, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 29)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Grand Total:"
        '
        'txtSGSTTTotal
        '
        Me.txtSGSTTTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSGSTTTotal.Location = New System.Drawing.Point(1242, 117)
        Me.txtSGSTTTotal.Name = "txtSGSTTTotal"
        Me.txtSGSTTTotal.Size = New System.Drawing.Size(270, 35)
        Me.txtSGSTTTotal.TabIndex = 39
        '
        'txtCGSTTotal
        '
        Me.txtCGSTTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCGSTTotal.Location = New System.Drawing.Point(1242, 67)
        Me.txtCGSTTotal.Name = "txtCGSTTotal"
        Me.txtCGSTTotal.Size = New System.Drawing.Size(270, 35)
        Me.txtCGSTTotal.TabIndex = 38
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(1242, 17)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(270, 35)
        Me.txtSubTotal.TabIndex = 37
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(720, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(270, 35)
        Me.TextBox2.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1057, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 29)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "SGSTT Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1072, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 29)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "CGST Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1096, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 29)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Sub Total:"
        '
        'txtRoundOff
        '
        Me.txtRoundOff.AutoSize = True
        Me.txtRoundOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundOff.Location = New System.Drawing.Point(578, 82)
        Me.txtRoundOff.Name = "txtRoundOff"
        Me.txtRoundOff.Size = New System.Drawing.Size(127, 29)
        Me.txtRoundOff.TabIndex = 27
        Me.txtRoundOff.Text = "Round Off:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(532, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 29)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Payment Type:"
        '
        'btnUpdateandClear
        '
        Me.btnUpdateandClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateandClear.Image = Global.Unique_collection.My.Resources.Resources.icons8_print_30
        Me.btnUpdateandClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateandClear.Location = New System.Drawing.Point(8, 36)
        Me.btnUpdateandClear.Name = "btnUpdateandClear"
        Me.btnUpdateandClear.Size = New System.Drawing.Size(235, 63)
        Me.btnUpdateandClear.TabIndex = 0
        Me.btnUpdateandClear.Text = "UPDATE AND CLEAR"
        Me.btnUpdateandClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnUpdateandClear.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Image = Global.Unique_collection.My.Resources.Resources.icons8_delete_view_30
        Me.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearAll.Location = New System.Drawing.Point(249, 36)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(235, 63)
        Me.btnClearAll.TabIndex = 1
        Me.btnClearAll.Text = "CLEAR ALL"
        Me.btnClearAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Column, Me.ItemCode, Me.ProductName, Me.HSN, Me.MRP, Me.SellingPrice, Me.Qnt, Me.Disc, Me.Total, Me.C, Me.Value, Me.S, Me.Value1, Me.TotalAmt})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 240)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1672, 172)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Column
        '
        Me.Column.Text = ""
        Me.Column.Width = 0
        '
        'ItemCode
        '
        Me.ItemCode.Text = "Item Code"
        Me.ItemCode.Width = 90
        '
        'ProductName
        '
        Me.ProductName.Text = "Product Name"
        Me.ProductName.Width = 260
        '
        'HSN
        '
        Me.HSN.Text = "HSN"
        Me.HSN.Width = 80
        '
        'MRP
        '
        Me.MRP.Text = "MRP"
        '
        'SellingPrice
        '
        Me.SellingPrice.Text = "Selling Price"
        Me.SellingPrice.Width = 105
        '
        'Qnt
        '
        Me.Qnt.Text = "Qnt"
        Me.Qnt.Width = 63
        '
        'Disc
        '
        Me.Disc.Text = "Disc"
        Me.Disc.Width = 70
        '
        'Total
        '
        Me.Total.Text = "Total"
        Me.Total.Width = 72
        '
        'C
        '
        Me.C.Text = "C%"
        Me.C.Width = 43
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 63
        '
        'S
        '
        Me.S.Text = "S%"
        Me.S.Width = 65
        '
        'Value1
        '
        Me.Value1.Text = "Value"
        Me.Value1.Width = 70
        '
        'TotalAmt
        '
        Me.TotalAmt.Text = "Total Amt"
        Me.TotalAmt.Width = 70
        '
        'SalesEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1672, 661)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesEntry"
        Me.Text = "SalesEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents ddlPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnUpdateandClear As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtRoundOff As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSGSTTTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCGSTTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtS_per As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtC_Val As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtC_Per As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtQnt As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtMRP As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtHSN As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ddlProductName As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents btnCart As System.Windows.Forms.Button
    Friend WithEvents ddlCompanyName As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Column As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtS_Val As System.Windows.Forms.TextBox
    Friend WithEvents ProductName As System.Windows.Forms.ColumnHeader
    Friend WithEvents HSN As System.Windows.Forms.ColumnHeader
    Friend WithEvents MRP As System.Windows.Forms.ColumnHeader
    Friend WithEvents SellingPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents Qnt As System.Windows.Forms.ColumnHeader
    Friend WithEvents Disc As System.Windows.Forms.ColumnHeader
    Friend WithEvents Total As System.Windows.Forms.ColumnHeader
    Friend WithEvents C As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Friend WithEvents S As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalAmt As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtReturn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGiven As System.Windows.Forms.TextBox
    Friend WithEvents lblMNG_Company As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
