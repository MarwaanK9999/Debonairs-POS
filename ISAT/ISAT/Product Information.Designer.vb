<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductInformation))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        Me.cboProducts = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnViewInformation = New System.Windows.Forms.Button()
        Me.dgProductDetails = New System.Windows.Forms.DataGridView()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProductDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(250, 12)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(360, 71)
        Me.lblHeading.TabIndex = 21
        Me.lblHeading.Text = "Choose a Group and a Product to view it's information."
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(179, 430)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(75, 23)
        Me.btnViewAll.TabIndex = 20
        Me.btnViewAll.Text = "View All"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.Image = CType(resources.GetObject("picImage.Image"), System.Drawing.Image)
        Me.picImage.Location = New System.Drawing.Point(12, 12)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(198, 87)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 19
        Me.picImage.TabStop = False
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Location = New System.Drawing.Point(428, 89)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(55, 13)
        Me.lblProducts.TabIndex = 18
        Me.lblProducts.Text = "Products :"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Location = New System.Drawing.Point(247, 89)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(42, 13)
        Me.lblGroup.TabIndex = 17
        Me.lblGroup.Text = "Group :"
        '
        'cboGroup
        '
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Location = New System.Drawing.Point(295, 86)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(121, 21)
        Me.cboGroup.TabIndex = 16
        '
        'cboProducts
        '
        Me.cboProducts.FormattingEnabled = True
        Me.cboProducts.Location = New System.Drawing.Point(489, 86)
        Me.cboProducts.Name = "cboProducts"
        Me.cboProducts.Size = New System.Drawing.Size(258, 21)
        Me.cboProducts.TabIndex = 15
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(475, 430)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(672, 430)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnViewInformation
        '
        Me.btnViewInformation.Location = New System.Drawing.Point(12, 430)
        Me.btnViewInformation.Name = "btnViewInformation"
        Me.btnViewInformation.Size = New System.Drawing.Size(75, 23)
        Me.btnViewInformation.TabIndex = 12
        Me.btnViewInformation.Text = "View Info"
        Me.btnViewInformation.UseVisualStyleBackColor = True
        '
        'dgProductDetails
        '
        Me.dgProductDetails.AllowUserToOrderColumns = True
        Me.dgProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductDetails.Location = New System.Drawing.Point(12, 113)
        Me.dgProductDetails.Name = "dgProductDetails"
        Me.dgProductDetails.Size = New System.Drawing.Size(733, 311)
        Me.dgProductDetails.TabIndex = 23
        '
        'frmProductInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(757, 466)
        Me.Controls.Add(Me.dgProductDetails)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.lblProducts)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.cboGroup)
        Me.Controls.Add(Me.cboProducts)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnViewInformation)
        Me.Name = "frmProductInformation"
        Me.Text = "Product Information"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProductDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnViewAll As Button
    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblProducts As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents cboGroup As ComboBox
    Friend WithEvents cboProducts As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnViewInformation As Button
    Friend WithEvents dgProductDetails As DataGridView
End Class
