<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductQuantity))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.grpUpdateQuantity = New System.Windows.Forms.GroupBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblProductQuantity = New System.Windows.Forms.Label()
        Me.lblProductSelect = New System.Windows.Forms.Label()
        Me.lblProductGroup = New System.Windows.Forms.Label()
        Me.lstDisplayQuantity = New System.Windows.Forms.ListBox()
        Me.cboSelectedProduct = New System.Windows.Forms.ComboBox()
        Me.cboProductGroup = New System.Windows.Forms.ComboBox()
        Me.txtProductQuantity = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUpdateQuantity.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(241, 352)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(164, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(88, 352)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(58, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'grpUpdateQuantity
        '
        Me.grpUpdateQuantity.Controls.Add(Me.txtProductCode)
        Me.grpUpdateQuantity.Controls.Add(Me.lblCode)
        Me.grpUpdateQuantity.Controls.Add(Me.lblProductQuantity)
        Me.grpUpdateQuantity.Controls.Add(Me.lblProductSelect)
        Me.grpUpdateQuantity.Controls.Add(Me.lblProductGroup)
        Me.grpUpdateQuantity.Controls.Add(Me.lstDisplayQuantity)
        Me.grpUpdateQuantity.Controls.Add(Me.cboSelectedProduct)
        Me.grpUpdateQuantity.Controls.Add(Me.cboProductGroup)
        Me.grpUpdateQuantity.Controls.Add(Me.txtProductQuantity)
        Me.grpUpdateQuantity.Location = New System.Drawing.Point(12, 68)
        Me.grpUpdateQuantity.Name = "grpUpdateQuantity"
        Me.grpUpdateQuantity.Size = New System.Drawing.Size(289, 276)
        Me.grpUpdateQuantity.TabIndex = 5
        Me.grpUpdateQuantity.TabStop = False
        Me.grpUpdateQuantity.Text = "Update Quantity:"
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(139, 24)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(140, 20)
        Me.txtProductCode.TabIndex = 10
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(9, 27)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(75, 13)
        Me.lblCode.TabIndex = 9
        Me.lblCode.Text = "Product Code:"
        '
        'lblProductQuantity
        '
        Me.lblProductQuantity.AutoSize = True
        Me.lblProductQuantity.Location = New System.Drawing.Point(9, 124)
        Me.lblProductQuantity.Name = "lblProductQuantity"
        Me.lblProductQuantity.Size = New System.Drawing.Size(71, 13)
        Me.lblProductQuantity.TabIndex = 8
        Me.lblProductQuantity.Text = "Add Quantity:"
        '
        'lblProductSelect
        '
        Me.lblProductSelect.AutoSize = True
        Me.lblProductSelect.Location = New System.Drawing.Point(9, 90)
        Me.lblProductSelect.Name = "lblProductSelect"
        Me.lblProductSelect.Size = New System.Drawing.Size(47, 13)
        Me.lblProductSelect.TabIndex = 7
        Me.lblProductSelect.Text = "Product:"
        '
        'lblProductGroup
        '
        Me.lblProductGroup.AutoSize = True
        Me.lblProductGroup.Location = New System.Drawing.Point(9, 57)
        Me.lblProductGroup.Name = "lblProductGroup"
        Me.lblProductGroup.Size = New System.Drawing.Size(39, 13)
        Me.lblProductGroup.TabIndex = 6
        Me.lblProductGroup.Text = "Group:"
        '
        'lstDisplayQuantity
        '
        Me.lstDisplayQuantity.FormattingEnabled = True
        Me.lstDisplayQuantity.Location = New System.Drawing.Point(9, 149)
        Me.lstDisplayQuantity.Name = "lstDisplayQuantity"
        Me.lstDisplayQuantity.Size = New System.Drawing.Size(270, 121)
        Me.lstDisplayQuantity.TabIndex = 5
        '
        'cboSelectedProduct
        '
        Me.cboSelectedProduct.FormattingEnabled = True
        Me.cboSelectedProduct.Location = New System.Drawing.Point(139, 87)
        Me.cboSelectedProduct.Name = "cboSelectedProduct"
        Me.cboSelectedProduct.Size = New System.Drawing.Size(140, 21)
        Me.cboSelectedProduct.TabIndex = 4
        '
        'cboProductGroup
        '
        Me.cboProductGroup.FormattingEnabled = True
        Me.cboProductGroup.Location = New System.Drawing.Point(139, 54)
        Me.cboProductGroup.Name = "cboProductGroup"
        Me.cboProductGroup.Size = New System.Drawing.Size(140, 21)
        Me.cboProductGroup.TabIndex = 3
        '
        'txtProductQuantity
        '
        Me.txtProductQuantity.Location = New System.Drawing.Point(139, 121)
        Me.txtProductQuantity.Name = "txtProductQuantity"
        Me.txtProductQuantity.Size = New System.Drawing.Size(140, 20)
        Me.txtProductQuantity.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 352)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmProductQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(316, 387)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.grpUpdateQuantity)
        Me.Name = "frmProductQuantity"
        Me.Text = "Product Quantity"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUpdateQuantity.ResumeLayout(False)
        Me.grpUpdateQuantity.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents grpUpdateQuantity As GroupBox
    Friend WithEvents lblProductQuantity As Label
    Friend WithEvents lblProductSelect As Label
    Friend WithEvents lblProductGroup As Label
    Friend WithEvents lstDisplayQuantity As ListBox
    Friend WithEvents cboSelectedProduct As ComboBox
    Friend WithEvents cboProductGroup As ComboBox
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents lblCode As Label
End Class
