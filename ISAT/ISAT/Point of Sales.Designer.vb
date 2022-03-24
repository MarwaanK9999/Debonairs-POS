<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.lblEnterAmount = New System.Windows.Forms.Label()
        Me.txtEnterAmount = New System.Windows.Forms.TextBox()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        Me.cboProducts = New System.Windows.Forms.ComboBox()
        Me.lstSalesList = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.grpProducts = New System.Windows.Forms.GroupBox()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.grpSalesList = New System.Windows.Forms.GroupBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.grpProducts.SuspendLayout()
        Me.grpSalesList.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterAmount
        '
        Me.lblEnterAmount.AutoSize = True
        Me.lblEnterAmount.Location = New System.Drawing.Point(6, 62)
        Me.lblEnterAmount.Name = "lblEnterAmount"
        Me.lblEnterAmount.Size = New System.Drawing.Size(77, 13)
        Me.lblEnterAmount.TabIndex = 5
        Me.lblEnterAmount.Text = "Enter Amount :"
        '
        'txtEnterAmount
        '
        Me.txtEnterAmount.Location = New System.Drawing.Point(89, 59)
        Me.txtEnterAmount.Name = "txtEnterAmount"
        Me.txtEnterAmount.Size = New System.Drawing.Size(174, 20)
        Me.txtEnterAmount.TabIndex = 4
        '
        'cboGroup
        '
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(96, 20)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(246, 21)
        Me.cboGroup.TabIndex = 0
        '
        'cboProducts
        '
        Me.cboProducts.FormattingEnabled = True
        Me.cboProducts.Location = New System.Drawing.Point(96, 54)
        Me.cboProducts.Name = "cboProducts"
        Me.cboProducts.Size = New System.Drawing.Size(246, 21)
        Me.cboProducts.TabIndex = 0
        '
        'lstSalesList
        '
        Me.lstSalesList.FormattingEnabled = True
        Me.lstSalesList.Location = New System.Drawing.Point(54, 22)
        Me.lstSalesList.Name = "lstSalesList"
        Me.lstSalesList.Size = New System.Drawing.Size(542, 264)
        Me.lstSalesList.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 89)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 62)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(195, 89)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(147, 62)
        Me.btnRemove.TabIndex = 34
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'grpProducts
        '
        Me.grpProducts.Controls.Add(Me.lblProduct)
        Me.grpProducts.Controls.Add(Me.lblGroup)
        Me.grpProducts.Controls.Add(Me.cboGroup)
        Me.grpProducts.Controls.Add(Me.cboProducts)
        Me.grpProducts.Controls.Add(Me.btnRemove)
        Me.grpProducts.Controls.Add(Me.btnAdd)
        Me.grpProducts.Location = New System.Drawing.Point(12, 92)
        Me.grpProducts.Name = "grpProducts"
        Me.grpProducts.Size = New System.Drawing.Size(357, 157)
        Me.grpProducts.TabIndex = 31
        Me.grpProducts.TabStop = False
        Me.grpProducts.Text = "Products:"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(12, 57)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(47, 13)
        Me.lblProduct.TabIndex = 37
        Me.lblProduct.Text = "Product:"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(20, 23)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(39, 13)
        Me.lblGroup.TabIndex = 36
        Me.lblGroup.Text = "Group:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 558)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(138, 33)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(527, 558)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 33)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(89, 89)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(169, 62)
        Me.btnPurchase.TabIndex = 28
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'grpSalesList
        '
        Me.grpSalesList.Controls.Add(Me.lstSalesList)
        Me.grpSalesList.Location = New System.Drawing.Point(12, 255)
        Me.grpSalesList.Name = "grpSalesList"
        Me.grpSalesList.Size = New System.Drawing.Size(646, 297)
        Me.grpSalesList.TabIndex = 27
        Me.grpSalesList.TabStop = False
        Me.grpSalesList.Text = "Sales List :"
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(12, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(646, 77)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 25
        Me.picLogo.TabStop = False
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.lblEnterAmount)
        Me.grpPayment.Controls.Add(Me.btnPurchase)
        Me.grpPayment.Controls.Add(Me.txtEnterAmount)
        Me.grpPayment.Location = New System.Drawing.Point(375, 92)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(287, 157)
        Me.grpPayment.TabIndex = 34
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment:"
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(674, 603)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpProducts)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpSalesList)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.picLogo)
        Me.Name = "frmPOS"
        Me.Text = "Point of Sales"
        Me.grpProducts.ResumeLayout(False)
        Me.grpProducts.PerformLayout()
        Me.grpSalesList.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEnterAmount As Label
    Friend WithEvents txtEnterAmount As TextBox
    Friend WithEvents cboGroup As ComboBox
    Friend WithEvents cboProducts As ComboBox
    Friend WithEvents lstSalesList As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents grpProducts As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPurchase As Button
    Friend WithEvents grpSalesList As GroupBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblGroup As Label
End Class
