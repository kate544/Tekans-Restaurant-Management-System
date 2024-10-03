<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTransferDetails = New System.Windows.Forms.TextBox()
        Me.lblEnterAmount = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblMpesaStatus = New System.Windows.Forms.Label()
        Me.btnMpesaConfirm = New System.Windows.Forms.Button()
        Me.txtMpesaTransactionCode = New System.Windows.Forms.TextBox()
        Me.lblMpesaTransactionCode = New System.Windows.Forms.Label()
        Me.txtMpesaPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblMpesaPhoneNumber = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTransferDetails)
        Me.GroupBox2.Controls.Add(Me.lblEnterAmount)
        Me.GroupBox2.Location = New System.Drawing.Point(393, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 101)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Amount"
        '
        'txtTransferDetails
        '
        Me.txtTransferDetails.Location = New System.Drawing.Point(176, 37)
        Me.txtTransferDetails.Name = "txtTransferDetails"
        Me.txtTransferDetails.Size = New System.Drawing.Size(143, 20)
        Me.txtTransferDetails.TabIndex = 1
        '
        'lblEnterAmount
        '
        Me.lblEnterAmount.AutoSize = True
        Me.lblEnterAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterAmount.Location = New System.Drawing.Point(6, 35)
        Me.lblEnterAmount.Name = "lblEnterAmount"
        Me.lblEnterAmount.Size = New System.Drawing.Size(125, 20)
        Me.lblEnterAmount.TabIndex = 0
        Me.lblEnterAmount.Text = "Enter Amount:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblMpesaStatus)
        Me.GroupBox3.Controls.Add(Me.btnMpesaConfirm)
        Me.GroupBox3.Controls.Add(Me.txtMpesaTransactionCode)
        Me.GroupBox3.Controls.Add(Me.lblMpesaTransactionCode)
        Me.GroupBox3.Controls.Add(Me.txtMpesaPhoneNumber)
        Me.GroupBox3.Controls.Add(Me.lblMpesaPhoneNumber)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 245)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "M-PESA"
        '
        'lblMpesaStatus
        '
        Me.lblMpesaStatus.AutoSize = True
        Me.lblMpesaStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMpesaStatus.ForeColor = System.Drawing.Color.Red
        Me.lblMpesaStatus.Location = New System.Drawing.Point(17, 215)
        Me.lblMpesaStatus.Name = "lblMpesaStatus"
        Me.lblMpesaStatus.Size = New System.Drawing.Size(67, 20)
        Me.lblMpesaStatus.TabIndex = 5
        Me.lblMpesaStatus.Text = "Status:"
        '
        'btnMpesaConfirm
        '
        Me.btnMpesaConfirm.Location = New System.Drawing.Point(114, 132)
        Me.btnMpesaConfirm.Name = "btnMpesaConfirm"
        Me.btnMpesaConfirm.Size = New System.Drawing.Size(98, 48)
        Me.btnMpesaConfirm.TabIndex = 4
        Me.btnMpesaConfirm.Text = "Confirm Payment"
        Me.btnMpesaConfirm.UseVisualStyleBackColor = True
        '
        'txtMpesaTransactionCode
        '
        Me.txtMpesaTransactionCode.Location = New System.Drawing.Point(153, 66)
        Me.txtMpesaTransactionCode.Name = "txtMpesaTransactionCode"
        Me.txtMpesaTransactionCode.Size = New System.Drawing.Size(179, 24)
        Me.txtMpesaTransactionCode.TabIndex = 3
        '
        'lblMpesaTransactionCode
        '
        Me.lblMpesaTransactionCode.AutoSize = True
        Me.lblMpesaTransactionCode.Location = New System.Drawing.Point(7, 69)
        Me.lblMpesaTransactionCode.Name = "lblMpesaTransactionCode"
        Me.lblMpesaTransactionCode.Size = New System.Drawing.Size(147, 18)
        Me.lblMpesaTransactionCode.TabIndex = 2
        Me.lblMpesaTransactionCode.Text = "Transaction Code:"
        '
        'txtMpesaPhoneNumber
        '
        Me.txtMpesaPhoneNumber.Location = New System.Drawing.Point(153, 28)
        Me.txtMpesaPhoneNumber.Name = "txtMpesaPhoneNumber"
        Me.txtMpesaPhoneNumber.Size = New System.Drawing.Size(179, 24)
        Me.txtMpesaPhoneNumber.TabIndex = 1
        '
        'lblMpesaPhoneNumber
        '
        Me.lblMpesaPhoneNumber.AutoSize = True
        Me.lblMpesaPhoneNumber.Location = New System.Drawing.Point(6, 34)
        Me.lblMpesaPhoneNumber.Name = "lblMpesaPhoneNumber"
        Me.lblMpesaPhoneNumber.Size = New System.Drawing.Size(125, 18)
        Me.lblMpesaPhoneNumber.TabIndex = 0
        Me.lblMpesaPhoneNumber.Text = "Phone Number:"
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(430, 167)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(116, 57)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 408)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form3"
        Me.Text = "Payment Options"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTransferDetails As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterAmount As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMpesaStatus As System.Windows.Forms.Label
    Friend WithEvents btnMpesaConfirm As System.Windows.Forms.Button
    Friend WithEvents txtMpesaTransactionCode As System.Windows.Forms.TextBox
    Friend WithEvents lblMpesaTransactionCode As System.Windows.Forms.Label
    Friend WithEvents txtMpesaPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblMpesaPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
