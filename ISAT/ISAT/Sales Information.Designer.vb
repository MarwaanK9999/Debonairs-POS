<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesInformation))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstViewSales = New System.Windows.Forms.ListBox()
        Me.cboTransactionNo = New System.Windows.Forms.ComboBox()
        Me.btnViewSale = New System.Windows.Forms.Button()
        Me.lblTranactionNo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(341, 62)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(137, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(154, 62)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(181, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear Sales"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(340, 34)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(138, 23)
        Me.btnViewAll.TabIndex = 7
        Me.btnViewAll.Text = "View All Sales"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(154, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lstViewSales
        '
        Me.lstViewSales.FormattingEnabled = True
        Me.lstViewSales.Location = New System.Drawing.Point(12, 91)
        Me.lstViewSales.Name = "lstViewSales"
        Me.lstViewSales.Size = New System.Drawing.Size(466, 355)
        Me.lstViewSales.TabIndex = 5
        '
        'cboTransactionNo
        '
        Me.cboTransactionNo.FormattingEnabled = True
        Me.cboTransactionNo.Location = New System.Drawing.Point(97, 36)
        Me.cboTransactionNo.Name = "cboTransactionNo"
        Me.cboTransactionNo.Size = New System.Drawing.Size(51, 21)
        Me.cboTransactionNo.TabIndex = 10
        '
        'btnViewSale
        '
        Me.btnViewSale.Location = New System.Drawing.Point(12, 62)
        Me.btnViewSale.Name = "btnViewSale"
        Me.btnViewSale.Size = New System.Drawing.Size(136, 23)
        Me.btnViewSale.TabIndex = 11
        Me.btnViewSale.Text = "View Sale"
        Me.btnViewSale.UseVisualStyleBackColor = True
        '
        'lblTranactionNo
        '
        Me.lblTranactionNo.AutoSize = True
        Me.lblTranactionNo.Location = New System.Drawing.Point(12, 39)
        Me.lblTranactionNo.Name = "lblTranactionNo"
        Me.lblTranactionNo.Size = New System.Drawing.Size(83, 13)
        Me.lblTranactionNo.TabIndex = 12
        Me.lblTranactionNo.Text = "Transaction No:"
        '
        'frmSalesInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(495, 454)
        Me.Controls.Add(Me.lblTranactionNo)
        Me.Controls.Add(Me.btnViewSale)
        Me.Controls.Add(Me.cboTransactionNo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstViewSales)
        Me.Name = "frmSalesInformation"
        Me.Text = "Sales Information"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnViewAll As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstViewSales As ListBox
    Friend WithEvents cboTransactionNo As ComboBox
    Friend WithEvents btnViewSale As Button
    Friend WithEvents lblTranactionNo As Label
End Class
