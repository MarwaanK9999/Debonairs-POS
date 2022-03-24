<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnViewSales = New System.Windows.Forms.Button()
        Me.btnViewInformation = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnUpdateQuantity = New System.Windows.Forms.Button()
        Me.btnUpdateDetails = New System.Windows.Forms.Button()
        Me.picLogo1 = New System.Windows.Forms.PictureBox()
        Me.picLogo2 = New System.Windows.Forms.PictureBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        CType(Me.picLogo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Teal
        Me.lblHeading.Location = New System.Drawing.Point(141, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(143, 25)
        Me.lblHeading.TabIndex = 13
        Me.lblHeading.Text = "WELCOME"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Teal
        Me.btnExit.Location = New System.Drawing.Point(133, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(171, 34)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnViewSales
        '
        Me.btnViewSales.BackColor = System.Drawing.Color.Teal
        Me.btnViewSales.Location = New System.Drawing.Point(133, 225)
        Me.btnViewSales.Name = "btnViewSales"
        Me.btnViewSales.Size = New System.Drawing.Size(171, 33)
        Me.btnViewSales.TabIndex = 11
        Me.btnViewSales.Text = "View Sales"
        Me.btnViewSales.UseVisualStyleBackColor = False
        '
        'btnViewInformation
        '
        Me.btnViewInformation.BackColor = System.Drawing.Color.Teal
        Me.btnViewInformation.Location = New System.Drawing.Point(133, 178)
        Me.btnViewInformation.Name = "btnViewInformation"
        Me.btnViewInformation.Size = New System.Drawing.Size(171, 41)
        Me.btnViewInformation.TabIndex = 10
        Me.btnViewInformation.Text = "View Product Information"
        Me.btnViewInformation.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.Teal
        Me.btnSales.Location = New System.Drawing.Point(133, 135)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(171, 37)
        Me.btnSales.TabIndex = 9
        Me.btnSales.Text = "Point of Sales"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnUpdateQuantity
        '
        Me.btnUpdateQuantity.BackColor = System.Drawing.Color.Teal
        Me.btnUpdateQuantity.Location = New System.Drawing.Point(133, 92)
        Me.btnUpdateQuantity.Name = "btnUpdateQuantity"
        Me.btnUpdateQuantity.Size = New System.Drawing.Size(171, 37)
        Me.btnUpdateQuantity.TabIndex = 8
        Me.btnUpdateQuantity.Text = "Update Product Quantity"
        Me.btnUpdateQuantity.UseVisualStyleBackColor = False
        '
        'btnUpdateDetails
        '
        Me.btnUpdateDetails.BackColor = System.Drawing.Color.Teal
        Me.btnUpdateDetails.Location = New System.Drawing.Point(133, 52)
        Me.btnUpdateDetails.Name = "btnUpdateDetails"
        Me.btnUpdateDetails.Size = New System.Drawing.Size(171, 34)
        Me.btnUpdateDetails.TabIndex = 7
        Me.btnUpdateDetails.Text = "Add/Update Product Information"
        Me.btnUpdateDetails.UseVisualStyleBackColor = False
        '
        'picLogo1
        '
        Me.picLogo1.Image = CType(resources.GetObject("picLogo1.Image"), System.Drawing.Image)
        Me.picLogo1.Location = New System.Drawing.Point(2, 9)
        Me.picLogo1.Name = "picLogo1"
        Me.picLogo1.Size = New System.Drawing.Size(100, 77)
        Me.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo1.TabIndex = 14
        Me.picLogo1.TabStop = False
        '
        'picLogo2
        '
        Me.picLogo2.Image = CType(resources.GetObject("picLogo2.Image"), System.Drawing.Image)
        Me.picLogo2.Location = New System.Drawing.Point(339, 237)
        Me.picLogo2.Name = "picLogo2"
        Me.picLogo2.Size = New System.Drawing.Size(100, 77)
        Me.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo2.TabIndex = 15
        Me.picLogo2.TabStop = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Teal
        Me.btnLogOut.Location = New System.Drawing.Point(133, 267)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(171, 34)
        Me.btnLogOut.TabIndex = 16
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(440, 353)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.picLogo2)
        Me.Controls.Add(Me.picLogo1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnViewSales)
        Me.Controls.Add(Me.btnViewInformation)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnUpdateQuantity)
        Me.Controls.Add(Me.btnUpdateDetails)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        CType(Me.picLogo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnViewSales As Button
    Friend WithEvents btnViewInformation As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnUpdateQuantity As Button
    Friend WithEvents btnUpdateDetails As Button
    Friend WithEvents picLogo1 As PictureBox
    Friend WithEvents picLogo2 As PictureBox
    Friend WithEvents btnLogOut As Button
End Class
