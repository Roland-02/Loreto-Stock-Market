<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bank_Page
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxBanks = New System.Windows.Forms.GroupBox()
        Me.RdBtnNatwest = New System.Windows.Forms.RadioButton()
        Me.RdBtnLloyds = New System.Windows.Forms.RadioButton()
        Me.RdBtnHSBC = New System.Windows.Forms.RadioButton()
        Me.RdBtnBarclays = New System.Windows.Forms.RadioButton()
        Me.TxtbxInt = New System.Windows.Forms.TextBox()
        Me.TxtbxMax = New System.Windows.Forms.TextBox()
        Me.TxtbxAmount = New System.Windows.Forms.TextBox()
        Me.TxtbxRepay = New System.Windows.Forms.TextBox()
        Me.CmoBxTime = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblTotRepay = New System.Windows.Forms.Label()
        Me.TxtBxTotRepay = New System.Windows.Forms.TextBox()
        Me.BtnApply = New System.Windows.Forms.Button()
        Me.LblDisabledMsg = New System.Windows.Forms.Label()
        Me.GroupBoxBanks.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1040, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BANK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxBanks
        '
        Me.GroupBoxBanks.Controls.Add(Me.RdBtnNatwest)
        Me.GroupBoxBanks.Controls.Add(Me.RdBtnLloyds)
        Me.GroupBoxBanks.Controls.Add(Me.RdBtnHSBC)
        Me.GroupBoxBanks.Controls.Add(Me.RdBtnBarclays)
        Me.GroupBoxBanks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBanks.Location = New System.Drawing.Point(33, 83)
        Me.GroupBoxBanks.Name = "GroupBoxBanks"
        Me.GroupBoxBanks.Size = New System.Drawing.Size(156, 291)
        Me.GroupBoxBanks.TabIndex = 1
        Me.GroupBoxBanks.TabStop = False
        Me.GroupBoxBanks.Text = "Select Bank"
        '
        'RdBtnNatwest
        '
        Me.RdBtnNatwest.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RdBtnNatwest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdBtnNatwest.Location = New System.Drawing.Point(19, 222)
        Me.RdBtnNatwest.Name = "RdBtnNatwest"
        Me.RdBtnNatwest.Size = New System.Drawing.Size(129, 44)
        Me.RdBtnNatwest.TabIndex = 5
        Me.RdBtnNatwest.TabStop = True
        Me.RdBtnNatwest.Text = "Natwest"
        Me.RdBtnNatwest.UseVisualStyleBackColor = False
        '
        'RdBtnLloyds
        '
        Me.RdBtnLloyds.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RdBtnLloyds.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdBtnLloyds.Location = New System.Drawing.Point(19, 160)
        Me.RdBtnLloyds.Name = "RdBtnLloyds"
        Me.RdBtnLloyds.Size = New System.Drawing.Size(129, 44)
        Me.RdBtnLloyds.TabIndex = 4
        Me.RdBtnLloyds.TabStop = True
        Me.RdBtnLloyds.Text = "Lloyds"
        Me.RdBtnLloyds.UseVisualStyleBackColor = False
        '
        'RdBtnHSBC
        '
        Me.RdBtnHSBC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RdBtnHSBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdBtnHSBC.Location = New System.Drawing.Point(19, 95)
        Me.RdBtnHSBC.Name = "RdBtnHSBC"
        Me.RdBtnHSBC.Size = New System.Drawing.Size(129, 44)
        Me.RdBtnHSBC.TabIndex = 3
        Me.RdBtnHSBC.TabStop = True
        Me.RdBtnHSBC.Text = "HSBC"
        Me.RdBtnHSBC.UseVisualStyleBackColor = False
        '
        'RdBtnBarclays
        '
        Me.RdBtnBarclays.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RdBtnBarclays.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdBtnBarclays.Location = New System.Drawing.Point(19, 34)
        Me.RdBtnBarclays.Name = "RdBtnBarclays"
        Me.RdBtnBarclays.Size = New System.Drawing.Size(129, 44)
        Me.RdBtnBarclays.TabIndex = 2
        Me.RdBtnBarclays.TabStop = True
        Me.RdBtnBarclays.Text = "Barclays"
        Me.RdBtnBarclays.UseVisualStyleBackColor = False
        '
        'TxtbxInt
        '
        Me.TxtbxInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtbxInt.Location = New System.Drawing.Point(476, 274)
        Me.TxtbxInt.Name = "TxtbxInt"
        Me.TxtbxInt.ReadOnly = True
        Me.TxtbxInt.Size = New System.Drawing.Size(350, 26)
        Me.TxtbxInt.TabIndex = 2
        Me.TxtbxInt.Text = "Interest (%)"
        '
        'TxtbxMax
        '
        Me.TxtbxMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtbxMax.Location = New System.Drawing.Point(476, 106)
        Me.TxtbxMax.Name = "TxtbxMax"
        Me.TxtbxMax.ReadOnly = True
        Me.TxtbxMax.Size = New System.Drawing.Size(350, 26)
        Me.TxtbxMax.TabIndex = 3
        Me.TxtbxMax.Text = "Max Amount (£)"
        '
        'TxtbxAmount
        '
        Me.TxtbxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtbxAmount.Location = New System.Drawing.Point(476, 160)
        Me.TxtbxAmount.Name = "TxtbxAmount"
        Me.TxtbxAmount.Size = New System.Drawing.Size(350, 26)
        Me.TxtbxAmount.TabIndex = 4
        Me.TxtbxAmount.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtbxRepay
        '
        Me.TxtbxRepay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtbxRepay.Location = New System.Drawing.Point(476, 355)
        Me.TxtbxRepay.Name = "TxtbxRepay"
        Me.TxtbxRepay.ReadOnly = True
        Me.TxtbxRepay.Size = New System.Drawing.Size(350, 29)
        Me.TxtbxRepay.TabIndex = 5
        Me.TxtbxRepay.Text = "Monthly Repayment (£)"
        '
        'CmoBxTime
        '
        Me.CmoBxTime.DropDownWidth = 30
        Me.CmoBxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmoBxTime.FormattingEnabled = True
        Me.CmoBxTime.Items.AddRange(New Object() {"3", "6", "9", "12", "24", "36", "48", "60"})
        Me.CmoBxTime.Location = New System.Drawing.Point(476, 210)
        Me.CmoBxTime.Name = "CmoBxTime"
        Me.CmoBxTime.Size = New System.Drawing.Size(350, 26)
        Me.CmoBxTime.TabIndex = 6
        Me.CmoBxTime.Text = "Enter Repayment Time (months)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Interest (%)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(272, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 33)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Monthly Repayment (£)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 33)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Repayment Time (months)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 33)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Borrow Amount (£)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(331, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 33)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Max amount (£)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotRepay
        '
        Me.LblTotRepay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotRepay.Location = New System.Drawing.Point(334, 312)
        Me.LblTotRepay.Name = "LblTotRepay"
        Me.LblTotRepay.Size = New System.Drawing.Size(136, 33)
        Me.LblTotRepay.TabIndex = 14
        Me.LblTotRepay.Text = "Total Repay (£)"
        Me.LblTotRepay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBxTotRepay
        '
        Me.TxtBxTotRepay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxTotRepay.Location = New System.Drawing.Point(476, 312)
        Me.TxtBxTotRepay.Name = "TxtBxTotRepay"
        Me.TxtBxTotRepay.ReadOnly = True
        Me.TxtBxTotRepay.Size = New System.Drawing.Size(350, 29)
        Me.TxtBxTotRepay.TabIndex = 13
        Me.TxtBxTotRepay.Text = "Total Repay (£)"
        '
        'BtnApply
        '
        Me.BtnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnApply.Location = New System.Drawing.Point(873, 157)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(154, 65)
        Me.BtnApply.TabIndex = 15
        Me.BtnApply.Text = "APPLY"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'LblDisabledMsg
        '
        Me.LblDisabledMsg.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LblDisabledMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisabledMsg.Location = New System.Drawing.Point(195, 121)
        Me.LblDisabledMsg.Name = "LblDisabledMsg"
        Me.LblDisabledMsg.Size = New System.Drawing.Size(684, 188)
        Me.LblDisabledMsg.TabIndex = 16
        Me.LblDisabledMsg.Text = "YOU ALREADY HAVE A LOAN TAKEN OUT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "YOU CANNOT TAKE OUT ANOTHER UNTIL IT HAS BE" &
    "EN PAID OFF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblDisabledMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblDisabledMsg.Visible = False
        '
        'Bank_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1039, 443)
        Me.Controls.Add(Me.LblDisabledMsg)
        Me.Controls.Add(Me.BtnApply)
        Me.Controls.Add(Me.LblTotRepay)
        Me.Controls.Add(Me.TxtBxTotRepay)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmoBxTime)
        Me.Controls.Add(Me.TxtbxRepay)
        Me.Controls.Add(Me.TxtbxAmount)
        Me.Controls.Add(Me.TxtbxMax)
        Me.Controls.Add(Me.TxtbxInt)
        Me.Controls.Add(Me.GroupBoxBanks)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Bank_Page"
        Me.Text = "Bank_Page"
        Me.GroupBoxBanks.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBoxBanks As Windows.Forms.GroupBox
    Friend WithEvents RdBtnBarclays As Windows.Forms.RadioButton
    Friend WithEvents RdBtnNatwest As Windows.Forms.RadioButton
    Friend WithEvents RdBtnLloyds As Windows.Forms.RadioButton
    Friend WithEvents RdBtnHSBC As Windows.Forms.RadioButton
    Friend WithEvents TxtbxInt As Windows.Forms.TextBox
    Friend WithEvents TxtbxMax As Windows.Forms.TextBox
    Friend WithEvents TxtbxAmount As Windows.Forms.TextBox
    Friend WithEvents TxtbxRepay As Windows.Forms.TextBox
    Friend WithEvents CmoBxTime As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents LblTotRepay As Windows.Forms.Label
    Friend WithEvents TxtBxTotRepay As Windows.Forms.TextBox
    Friend WithEvents BtnApply As Windows.Forms.Button
    Friend WithEvents LblDisabledMsg As Windows.Forms.Label
End Class
