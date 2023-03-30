<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History_Page
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
        Me.LblTransactionHist = New System.Windows.Forms.Label()
        Me.BtnClearHist = New System.Windows.Forms.Button()
        Me.LstbxHistory = New System.Windows.Forms.ListBox()
        Me.LblLastCleared = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTransactionHist
        '
        Me.LblTransactionHist.BackColor = System.Drawing.Color.Transparent
        Me.LblTransactionHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransactionHist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTransactionHist.Location = New System.Drawing.Point(262, 6)
        Me.LblTransactionHist.Name = "LblTransactionHist"
        Me.LblTransactionHist.Size = New System.Drawing.Size(413, 60)
        Me.LblTransactionHist.TabIndex = 10
        Me.LblTransactionHist.Text = "Transaction History"
        Me.LblTransactionHist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClearHist
        '
        Me.BtnClearHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearHist.Location = New System.Drawing.Point(812, 36)
        Me.BtnClearHist.Name = "BtnClearHist"
        Me.BtnClearHist.Size = New System.Drawing.Size(121, 57)
        Me.BtnClearHist.TabIndex = 11
        Me.BtnClearHist.Text = "CLEAR HISTORY"
        Me.BtnClearHist.UseVisualStyleBackColor = True
        '
        'LstbxHistory
        '
        Me.LstbxHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LstbxHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstbxHistory.FormattingEnabled = True
        Me.LstbxHistory.ItemHeight = 15
        Me.LstbxHistory.Location = New System.Drawing.Point(133, 143)
        Me.LstbxHistory.Name = "LstbxHistory"
        Me.LstbxHistory.Size = New System.Drawing.Size(655, 289)
        Me.LstbxHistory.TabIndex = 12
        '
        'LblLastCleared
        '
        Me.LblLastCleared.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastCleared.Location = New System.Drawing.Point(536, 96)
        Me.LblLastCleared.Name = "LblLastCleared"
        Me.LblLastCleared.Size = New System.Drawing.Size(397, 44)
        Me.LblLastCleared.TabIndex = 13
        Me.LblLastCleared.Text = "History last cleared on:"
        Me.LblLastCleared.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'History_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(945, 491)
        Me.Controls.Add(Me.LblLastCleared)
        Me.Controls.Add(Me.LstbxHistory)
        Me.Controls.Add(Me.BtnClearHist)
        Me.Controls.Add(Me.LblTransactionHist)
        Me.Name = "History_Page"
        Me.Text = "Transaction History"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTransactionHist As Windows.Forms.Label
    Friend WithEvents BtnClearHist As Windows.Forms.Button
    Friend WithEvents LstbxHistory As Windows.Forms.ListBox
    Friend WithEvents LblLastCleared As Windows.Forms.Label
End Class
