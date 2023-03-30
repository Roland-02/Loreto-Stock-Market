<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Market_Page
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
        Me.LstBxStockTable = New System.Windows.Forms.ListBox()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblBalance = New System.Windows.Forms.Label()
        Me.LblLoretoTradeMarket = New System.Windows.Forms.Label()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstBxStockTable
        '
        Me.LstBxStockTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LstBxStockTable.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBxStockTable.ForeColor = System.Drawing.Color.Black
        Me.LstBxStockTable.FormattingEnabled = True
        Me.LstBxStockTable.ItemHeight = 16
        Me.LstBxStockTable.Location = New System.Drawing.Point(39, 159)
        Me.LstBxStockTable.Name = "LstBxStockTable"
        Me.LstBxStockTable.ScrollAlwaysVisible = True
        Me.LstBxStockTable.Size = New System.Drawing.Size(1008, 308)
        Me.LstBxStockTable.TabIndex = 4
        '
        'LblTime
        '
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(49, 104)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(237, 52)
        Me.LblTime.TabIndex = 5
        Me.LblTime.Text = "LblTime"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDate
        '
        Me.LblDate.BackColor = System.Drawing.Color.Transparent
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(810, 117)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(237, 39)
        Me.LblDate.TabIndex = 6
        Me.LblDate.Text = "LblDate"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBalance
        '
        Me.LblBalance.BackColor = System.Drawing.Color.Transparent
        Me.LblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance.Location = New System.Drawing.Point(12, 26)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(237, 52)
        Me.LblBalance.TabIndex = 8
        Me.LblBalance.Text = "balance"
        Me.LblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblLoretoTradeMarket
        '
        Me.LblLoretoTradeMarket.BackColor = System.Drawing.Color.Transparent
        Me.LblLoretoTradeMarket.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoretoTradeMarket.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblLoretoTradeMarket.Location = New System.Drawing.Point(339, 7)
        Me.LblLoretoTradeMarket.Name = "LblLoretoTradeMarket"
        Me.LblLoretoTradeMarket.Size = New System.Drawing.Size(450, 71)
        Me.LblLoretoTradeMarket.TabIndex = 11
        Me.LblLoretoTradeMarket.Text = "Loreto Stock Exchange"
        Me.LblLoretoTradeMarket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblScore
        '
        Me.LblScore.BackColor = System.Drawing.Color.Transparent
        Me.LblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.Location = New System.Drawing.Point(834, 20)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(237, 52)
        Me.LblScore.TabIndex = 12
        Me.LblScore.Text = "Score: "
        Me.LblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Market_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1083, 529)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.LblLoretoTradeMarket)
        Me.Controls.Add(Me.LblBalance)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LstBxStockTable)
        Me.Name = "Market_Page"
        Me.Text = "Market_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstBxStockTable As Windows.Forms.ListBox
    Friend WithEvents LblTime As Windows.Forms.Label
    Friend WithEvents LblDate As Windows.Forms.Label
    Friend WithEvents LblBalance As Windows.Forms.Label
    Friend WithEvents LblLoretoTradeMarket As Windows.Forms.Label
    Friend WithEvents LblScore As Windows.Forms.Label
End Class
