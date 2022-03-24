<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductDetails))
        Me.grpUpdate = New System.Windows.Forms.GroupBox()
        Me.radPrice = New System.Windows.Forms.RadioButton()
        Me.radCode = New System.Windows.Forms.RadioButton()
        Me.radName = New System.Windows.Forms.RadioButton()
        Me.radGroup = New System.Windows.Forms.RadioButton()
        Me.txtProductGroupUpdate = New System.Windows.Forms.TextBox()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.cboSelectProductUpdate = New System.Windows.Forms.ComboBox()
        Me.lblSelectProductU = New System.Windows.Forms.Label()
        Me.lblProductGroupU = New System.Windows.Forms.Label()
        Me.lstUpdate = New System.Windows.Forms.ListBox()
        Me.btnUpdateClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboProductGroupUpdate = New System.Windows.Forms.ComboBox()
        Me.txtProductPriceUpdate = New System.Windows.Forms.TextBox()
        Me.txtProductCodeUpdate = New System.Windows.Forms.TextBox()
        Me.txtProductNameUpdate = New System.Windows.Forms.TextBox()
        Me.lstNewProductDetails = New System.Windows.Forms.ListBox()
        Me.lblProductQuantityA = New System.Windows.Forms.Label()
        Me.txtProductQuantityAdd = New System.Windows.Forms.TextBox()
        Me.lblProductGroupA = New System.Windows.Forms.Label()
        Me.lblProductPriceA = New System.Windows.Forms.Label()
        Me.lblProductCodeA = New System.Windows.Forms.Label()
        Me.lblProductNameA = New System.Windows.Forms.Label()
        Me.cboProductGroupAdd = New System.Windows.Forms.ComboBox()
        Me.txtProductCodeAdd = New System.Windows.Forms.TextBox()
        Me.txtProductNameAdd = New System.Windows.Forms.TextBox()
        Me.grpAddProducts = New System.Windows.Forms.GroupBox()
        Me.btnAddClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtProductPriceAdd = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnProductDetails = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpUpdate.SuspendLayout()
        Me.grpAddProducts.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUpdate
        '
        Me.grpUpdate.Controls.Add(Me.radPrice)
        Me.grpUpdate.Controls.Add(Me.radCode)
        Me.grpUpdate.Controls.Add(Me.radName)
        Me.grpUpdate.Controls.Add(Me.radGroup)
        Me.grpUpdate.Controls.Add(Me.txtProductGroupUpdate)
        Me.grpUpdate.Controls.Add(Me.btnDeleteProduct)
        Me.grpUpdate.Controls.Add(Me.cboSelectProductUpdate)
        Me.grpUpdate.Controls.Add(Me.lblSelectProductU)
        Me.grpUpdate.Controls.Add(Me.lblProductGroupU)
        Me.grpUpdate.Controls.Add(Me.lstUpdate)
        Me.grpUpdate.Controls.Add(Me.btnUpdateClear)
        Me.grpUpdate.Controls.Add(Me.btnUpdate)
        Me.grpUpdate.Controls.Add(Me.cboProductGroupUpdate)
        Me.grpUpdate.Controls.Add(Me.txtProductPriceUpdate)
        Me.grpUpdate.Controls.Add(Me.txtProductCodeUpdate)
        Me.grpUpdate.Controls.Add(Me.txtProductNameUpdate)
        Me.grpUpdate.Location = New System.Drawing.Point(418, 93)
        Me.grpUpdate.Name = "grpUpdate"
        Me.grpUpdate.Size = New System.Drawing.Size(400, 394)
        Me.grpUpdate.TabIndex = 14
        Me.grpUpdate.TabStop = False
        Me.grpUpdate.Text = "Edit Product Details:"
        '
        'radPrice
        '
        Me.radPrice.AutoSize = True
        Me.radPrice.Location = New System.Drawing.Point(10, 191)
        Me.radPrice.Name = "radPrice"
        Me.radPrice.Size = New System.Drawing.Size(52, 17)
        Me.radPrice.TabIndex = 22
        Me.radPrice.TabStop = True
        Me.radPrice.Text = "Price:"
        Me.radPrice.UseVisualStyleBackColor = True
        '
        'radCode
        '
        Me.radCode.AutoSize = True
        Me.radCode.Location = New System.Drawing.Point(10, 162)
        Me.radCode.Name = "radCode"
        Me.radCode.Size = New System.Drawing.Size(53, 17)
        Me.radCode.TabIndex = 21
        Me.radCode.TabStop = True
        Me.radCode.Text = "Code:"
        Me.radCode.UseVisualStyleBackColor = True
        '
        'radName
        '
        Me.radName.AutoSize = True
        Me.radName.Location = New System.Drawing.Point(10, 132)
        Me.radName.Name = "radName"
        Me.radName.Size = New System.Drawing.Size(56, 17)
        Me.radName.TabIndex = 20
        Me.radName.TabStop = True
        Me.radName.Text = "Name:"
        Me.radName.UseVisualStyleBackColor = True
        '
        'radGroup
        '
        Me.radGroup.AutoSize = True
        Me.radGroup.Location = New System.Drawing.Point(10, 102)
        Me.radGroup.Name = "radGroup"
        Me.radGroup.Size = New System.Drawing.Size(57, 17)
        Me.radGroup.TabIndex = 19
        Me.radGroup.TabStop = True
        Me.radGroup.Text = "Group:"
        Me.radGroup.UseVisualStyleBackColor = True
        '
        'txtProductGroupUpdate
        '
        Me.txtProductGroupUpdate.Location = New System.Drawing.Point(144, 101)
        Me.txtProductGroupUpdate.Name = "txtProductGroupUpdate"
        Me.txtProductGroupUpdate.Size = New System.Drawing.Size(250, 20)
        Me.txtProductGroupUpdate.TabIndex = 18
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Location = New System.Drawing.Point(170, 214)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(89, 47)
        Me.btnDeleteProduct.TabIndex = 17
        Me.btnDeleteProduct.Text = "Delete Product"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'cboSelectProductUpdate
        '
        Me.cboSelectProductUpdate.FormattingEnabled = True
        Me.cboSelectProductUpdate.Location = New System.Drawing.Point(144, 69)
        Me.cboSelectProductUpdate.Name = "cboSelectProductUpdate"
        Me.cboSelectProductUpdate.Size = New System.Drawing.Size(250, 21)
        Me.cboSelectProductUpdate.TabIndex = 16
        '
        'lblSelectProductU
        '
        Me.lblSelectProductU.AutoSize = True
        Me.lblSelectProductU.Location = New System.Drawing.Point(7, 72)
        Me.lblSelectProductU.Name = "lblSelectProductU"
        Me.lblSelectProductU.Size = New System.Drawing.Size(80, 13)
        Me.lblSelectProductU.TabIndex = 15
        Me.lblSelectProductU.Text = "Select Product:"
        '
        'lblProductGroupU
        '
        Me.lblProductGroupU.AutoSize = True
        Me.lblProductGroupU.Location = New System.Drawing.Point(7, 35)
        Me.lblProductGroupU.Name = "lblProductGroupU"
        Me.lblProductGroupU.Size = New System.Drawing.Size(79, 13)
        Me.lblProductGroupU.TabIndex = 14
        Me.lblProductGroupU.Text = "Product Group:"
        '
        'lstUpdate
        '
        Me.lstUpdate.FormattingEnabled = True
        Me.lstUpdate.Location = New System.Drawing.Point(6, 267)
        Me.lstUpdate.Name = "lstUpdate"
        Me.lstUpdate.Size = New System.Drawing.Size(388, 121)
        Me.lstUpdate.TabIndex = 4
        '
        'btnUpdateClear
        '
        Me.btnUpdateClear.Location = New System.Drawing.Point(319, 216)
        Me.btnUpdateClear.Name = "btnUpdateClear"
        Me.btnUpdateClear.Size = New System.Drawing.Size(75, 45)
        Me.btnUpdateClear.TabIndex = 8
        Me.btnUpdateClear.Text = "Clear"
        Me.btnUpdateClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(6, 214)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 47)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update Product"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cboProductGroupUpdate
        '
        Me.cboProductGroupUpdate.FormattingEnabled = True
        Me.cboProductGroupUpdate.Location = New System.Drawing.Point(144, 32)
        Me.cboProductGroupUpdate.Name = "cboProductGroupUpdate"
        Me.cboProductGroupUpdate.Size = New System.Drawing.Size(250, 21)
        Me.cboProductGroupUpdate.TabIndex = 5
        '
        'txtProductPriceUpdate
        '
        Me.txtProductPriceUpdate.Location = New System.Drawing.Point(144, 190)
        Me.txtProductPriceUpdate.Name = "txtProductPriceUpdate"
        Me.txtProductPriceUpdate.Size = New System.Drawing.Size(250, 20)
        Me.txtProductPriceUpdate.TabIndex = 3
        '
        'txtProductCodeUpdate
        '
        Me.txtProductCodeUpdate.Location = New System.Drawing.Point(144, 161)
        Me.txtProductCodeUpdate.Name = "txtProductCodeUpdate"
        Me.txtProductCodeUpdate.Size = New System.Drawing.Size(250, 20)
        Me.txtProductCodeUpdate.TabIndex = 1
        '
        'txtProductNameUpdate
        '
        Me.txtProductNameUpdate.Location = New System.Drawing.Point(144, 131)
        Me.txtProductNameUpdate.Name = "txtProductNameUpdate"
        Me.txtProductNameUpdate.Size = New System.Drawing.Size(250, 20)
        Me.txtProductNameUpdate.TabIndex = 0
        '
        'lstNewProductDetails
        '
        Me.lstNewProductDetails.FormattingEnabled = True
        Me.lstNewProductDetails.Location = New System.Drawing.Point(6, 267)
        Me.lstNewProductDetails.Name = "lstNewProductDetails"
        Me.lstNewProductDetails.Size = New System.Drawing.Size(388, 121)
        Me.lstNewProductDetails.TabIndex = 4
        '
        'lblProductQuantityA
        '
        Me.lblProductQuantityA.AutoSize = True
        Me.lblProductQuantityA.Location = New System.Drawing.Point(7, 172)
        Me.lblProductQuantityA.Name = "lblProductQuantityA"
        Me.lblProductQuantityA.Size = New System.Drawing.Size(89, 13)
        Me.lblProductQuantityA.TabIndex = 16
        Me.lblProductQuantityA.Text = "Product Quantity:"
        '
        'txtProductQuantityAdd
        '
        Me.txtProductQuantityAdd.Location = New System.Drawing.Point(144, 169)
        Me.txtProductQuantityAdd.Name = "txtProductQuantityAdd"
        Me.txtProductQuantityAdd.Size = New System.Drawing.Size(250, 20)
        Me.txtProductQuantityAdd.TabIndex = 15
        '
        'lblProductGroupA
        '
        Me.lblProductGroupA.AutoSize = True
        Me.lblProductGroupA.Location = New System.Drawing.Point(7, 35)
        Me.lblProductGroupA.Name = "lblProductGroupA"
        Me.lblProductGroupA.Size = New System.Drawing.Size(79, 13)
        Me.lblProductGroupA.TabIndex = 14
        Me.lblProductGroupA.Text = "Product Group:"
        '
        'lblProductPriceA
        '
        Me.lblProductPriceA.AutoSize = True
        Me.lblProductPriceA.Location = New System.Drawing.Point(7, 138)
        Me.lblProductPriceA.Name = "lblProductPriceA"
        Me.lblProductPriceA.Size = New System.Drawing.Size(74, 13)
        Me.lblProductPriceA.TabIndex = 12
        Me.lblProductPriceA.Text = "Product Price:"
        '
        'lblProductCodeA
        '
        Me.lblProductCodeA.AutoSize = True
        Me.lblProductCodeA.Location = New System.Drawing.Point(7, 108)
        Me.lblProductCodeA.Name = "lblProductCodeA"
        Me.lblProductCodeA.Size = New System.Drawing.Size(75, 13)
        Me.lblProductCodeA.TabIndex = 10
        Me.lblProductCodeA.Text = "Product Code:"
        '
        'lblProductNameA
        '
        Me.lblProductNameA.AutoSize = True
        Me.lblProductNameA.Location = New System.Drawing.Point(7, 72)
        Me.lblProductNameA.Name = "lblProductNameA"
        Me.lblProductNameA.Size = New System.Drawing.Size(78, 13)
        Me.lblProductNameA.TabIndex = 9
        Me.lblProductNameA.Text = "Product Name:"
        '
        'cboProductGroupAdd
        '
        Me.cboProductGroupAdd.FormattingEnabled = True
        Me.cboProductGroupAdd.Location = New System.Drawing.Point(144, 32)
        Me.cboProductGroupAdd.Name = "cboProductGroupAdd"
        Me.cboProductGroupAdd.Size = New System.Drawing.Size(250, 21)
        Me.cboProductGroupAdd.TabIndex = 5
        '
        'txtProductCodeAdd
        '
        Me.txtProductCodeAdd.Location = New System.Drawing.Point(144, 105)
        Me.txtProductCodeAdd.Name = "txtProductCodeAdd"
        Me.txtProductCodeAdd.Size = New System.Drawing.Size(250, 20)
        Me.txtProductCodeAdd.TabIndex = 1
        '
        'txtProductNameAdd
        '
        Me.txtProductNameAdd.Location = New System.Drawing.Point(144, 69)
        Me.txtProductNameAdd.Name = "txtProductNameAdd"
        Me.txtProductNameAdd.Size = New System.Drawing.Size(250, 20)
        Me.txtProductNameAdd.TabIndex = 0
        '
        'grpAddProducts
        '
        Me.grpAddProducts.Controls.Add(Me.lblProductQuantityA)
        Me.grpAddProducts.Controls.Add(Me.txtProductQuantityAdd)
        Me.grpAddProducts.Controls.Add(Me.lblProductGroupA)
        Me.grpAddProducts.Controls.Add(Me.lblProductPriceA)
        Me.grpAddProducts.Controls.Add(Me.lstNewProductDetails)
        Me.grpAddProducts.Controls.Add(Me.lblProductCodeA)
        Me.grpAddProducts.Controls.Add(Me.lblProductNameA)
        Me.grpAddProducts.Controls.Add(Me.btnAddClear)
        Me.grpAddProducts.Controls.Add(Me.btnAdd)
        Me.grpAddProducts.Controls.Add(Me.cboProductGroupAdd)
        Me.grpAddProducts.Controls.Add(Me.txtProductPriceAdd)
        Me.grpAddProducts.Controls.Add(Me.txtProductCodeAdd)
        Me.grpAddProducts.Controls.Add(Me.txtProductNameAdd)
        Me.grpAddProducts.Location = New System.Drawing.Point(12, 93)
        Me.grpAddProducts.Name = "grpAddProducts"
        Me.grpAddProducts.Size = New System.Drawing.Size(400, 394)
        Me.grpAddProducts.TabIndex = 12
        Me.grpAddProducts.TabStop = False
        Me.grpAddProducts.Text = "Add Product:"
        '
        'btnAddClear
        '
        Me.btnAddClear.Location = New System.Drawing.Point(319, 214)
        Me.btnAddClear.Name = "btnAddClear"
        Me.btnAddClear.Size = New System.Drawing.Size(75, 47)
        Me.btnAddClear.TabIndex = 8
        Me.btnAddClear.Text = "Clear"
        Me.btnAddClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 214)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 47)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add New Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtProductPriceAdd
        '
        Me.txtProductPriceAdd.Location = New System.Drawing.Point(144, 135)
        Me.txtProductPriceAdd.Name = "txtProductPriceAdd"
        Me.txtProductPriceAdd.Size = New System.Drawing.Size(250, 20)
        Me.txtProductPriceAdd.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(743, 493)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 44)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnProductDetails
        '
        Me.btnProductDetails.Location = New System.Drawing.Point(11, 493)
        Me.btnProductDetails.Name = "btnProductDetails"
        Me.btnProductDetails.Size = New System.Drawing.Size(116, 44)
        Me.btnProductDetails.TabIndex = 13
        Me.btnProductDetails.Text = "View Product Details"
        Me.btnProductDetails.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(807, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmProductDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(827, 541)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpUpdate)
        Me.Controls.Add(Me.grpAddProducts)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnProductDetails)
        Me.Name = "frmProductDetails"
        Me.Text = "Product Details"
        Me.grpUpdate.ResumeLayout(False)
        Me.grpUpdate.PerformLayout()
        Me.grpAddProducts.ResumeLayout(False)
        Me.grpAddProducts.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUpdate As GroupBox
    Friend WithEvents cboSelectProductUpdate As ComboBox
    Friend WithEvents lblSelectProductU As Label
    Friend WithEvents lblProductGroupU As Label
    Friend WithEvents lstUpdate As ListBox
    Friend WithEvents btnUpdateClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cboProductGroupUpdate As ComboBox
    Friend WithEvents txtProductPriceUpdate As TextBox
    Friend WithEvents txtProductCodeUpdate As TextBox
    Friend WithEvents txtProductNameUpdate As TextBox
    Friend WithEvents lstNewProductDetails As ListBox
    Friend WithEvents lblProductQuantityA As Label
    Friend WithEvents txtProductQuantityAdd As TextBox
    Friend WithEvents lblProductGroupA As Label
    Friend WithEvents lblProductPriceA As Label
    Friend WithEvents lblProductCodeA As Label
    Friend WithEvents lblProductNameA As Label
    Friend WithEvents cboProductGroupAdd As ComboBox
    Friend WithEvents txtProductCodeAdd As TextBox
    Friend WithEvents txtProductNameAdd As TextBox
    Friend WithEvents grpAddProducts As GroupBox
    Friend WithEvents btnAddClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtProductPriceAdd As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnProductDetails As Button
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents txtProductGroupUpdate As TextBox
    Friend WithEvents radGroup As RadioButton
    Friend WithEvents radPrice As RadioButton
    Friend WithEvents radCode As RadioButton
    Friend WithEvents radName As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
