<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_Page
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
        Me.LblStockName = New System.Windows.Forms.Label()
        Me.LblStockPrice = New System.Windows.Forms.Label()
        Me.LblStockHigh = New System.Windows.Forms.Label()
        Me.LblStockProf = New System.Windows.Forms.Label()
        Me.LblStockLow = New System.Windows.Forms.Label()
        Me.LblStockMktCap = New System.Windows.Forms.Label()
        Me.LblStockPriceChange = New System.Windows.Forms.Label()
        Me.BtnBuy = New System.Windows.Forms.Button()
        Me.BtnSell = New System.Windows.Forms.Button()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.TxtbxQty = New System.Windows.Forms.TextBox()
        Me.LbltCost = New System.Windows.Forms.Label()
        Me.LblBalance = New System.Windows.Forms.Label()
        Me.LblOwnedShares = New System.Windows.Forms.Label()
        Me.LblPredVal = New System.Windows.Forms.Label()
        Me.BtnWatch = New System.Windows.Forms.Button()
        Me.BtnGraph = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblStockName
        '
        Me.LblStockName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockName.Location = New System.Drawing.Point(12, 41)
        Me.LblStockName.Name = "LblStockName"
        Me.LblStockName.Size = New System.Drawing.Size(468, 50)
        Me.LblStockName.TabIndex = 0
        Me.LblStockName.Text = "name"
        Me.LblStockName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStockPrice
        '
        Me.LblStockPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockPrice.Location = New System.Drawing.Point(22, 88)
        Me.LblStockPrice.Name = "LblStockPrice"
        Me.LblStockPrice.Size = New System.Drawing.Size(259, 34)
        Me.LblStockPrice.TabIndex = 1
        Me.LblStockPrice.Text = "price"
        Me.LblStockPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblStockHigh
        '
        Me.LblStockHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockHigh.Location = New System.Drawing.Point(22, 237)
        Me.LblStockHigh.Name = "LblStockHigh"
        Me.LblStockHigh.Size = New System.Drawing.Size(259, 34)
        Me.LblStockHigh.TabIndex = 2
        Me.LblStockHigh.Text = "high"
        Me.LblStockHigh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblStockProf
        '
        Me.LblStockProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockProf.Location = New System.Drawing.Point(22, 200)
        Me.LblStockProf.Name = "LblStockProf"
        Me.LblStockProf.Size = New System.Drawing.Size(259, 34)
        Me.LblStockProf.TabIndex = 3
        Me.LblStockProf.Text = "Predicted profit:"
        Me.LblStockProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblStockLow
        '
        Me.LblStockLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockLow.Location = New System.Drawing.Point(22, 276)
        Me.LblStockLow.Name = "LblStockLow"
        Me.LblStockLow.Size = New System.Drawing.Size(259, 34)
        Me.LblStockLow.TabIndex = 4
        Me.LblStockLow.Text = "low"
        Me.LblStockLow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblStockMktCap
        '
        Me.LblStockMktCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockMktCap.Location = New System.Drawing.Point(22, 318)
        Me.LblStockMktCap.Name = "LblStockMktCap"
        Me.LblStockMktCap.Size = New System.Drawing.Size(259, 34)
        Me.LblStockMktCap.TabIndex = 5
        Me.LblStockMktCap.Text = "market cap"
        Me.LblStockMktCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblStockPriceChange
        '
        Me.LblStockPriceChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockPriceChange.Location = New System.Drawing.Point(22, 127)
        Me.LblStockPriceChange.Name = "LblStockPriceChange"
        Me.LblStockPriceChange.Size = New System.Drawing.Size(259, 34)
        Me.LblStockPriceChange.TabIndex = 6
        Me.LblStockPriceChange.Text = "change"
        Me.LblStockPriceChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBuy
        '
        Me.BtnBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuy.Location = New System.Drawing.Point(41, 498)
        Me.BtnBuy.Name = "BtnBuy"
        Me.BtnBuy.Size = New System.Drawing.Size(168, 64)
        Me.BtnBuy.TabIndex = 7
        Me.BtnBuy.Text = "BUY"
        Me.BtnBuy.UseVisualStyleBackColor = True
        '
        'BtnSell
        '
        Me.BtnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSell.Location = New System.Drawing.Point(242, 498)
        Me.BtnSell.Name = "BtnSell"
        Me.BtnSell.Size = New System.Drawing.Size(168, 64)
        Me.BtnSell.TabIndex = 8
        Me.BtnSell.Text = "SELL"
        Me.BtnSell.UseVisualStyleBackColor = True
        '
        'LblQty
        '
        Me.LblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQty.Location = New System.Drawing.Point(13, 366)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(119, 36)
        Me.LblQty.TabIndex = 9
        Me.LblQty.Text = "Enter quantity:"
        Me.LblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtbxQty
        '
        Me.TxtbxQty.Location = New System.Drawing.Point(138, 376)
        Me.TxtbxQty.Name = "TxtbxQty"
        Me.TxtbxQty.Size = New System.Drawing.Size(301, 20)
        Me.TxtbxQty.TabIndex = 10
        '
        'LbltCost
        '
        Me.LbltCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltCost.Location = New System.Drawing.Point(22, 426)
        Me.LbltCost.Name = "LbltCost"
        Me.LbltCost.Size = New System.Drawing.Size(259, 34)
        Me.LbltCost.TabIndex = 11
        Me.LbltCost.Text = "Cost:"
        Me.LbltCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBalance
        '
        Me.LblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance.Location = New System.Drawing.Point(12, 9)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(197, 34)
        Me.LblBalance.TabIndex = 12
        Me.LblBalance.Text = "Balance: "
        Me.LblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblOwnedShares
        '
        Me.LblOwnedShares.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOwnedShares.Location = New System.Drawing.Point(266, 9)
        Me.LblOwnedShares.Name = "LblOwnedShares"
        Me.LblOwnedShares.Size = New System.Drawing.Size(216, 34)
        Me.LblOwnedShares.TabIndex = 13
        Me.LblOwnedShares.Text = "Owned shares: "
        Me.LblOwnedShares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPredVal
        '
        Me.LblPredVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPredVal.Location = New System.Drawing.Point(22, 163)
        Me.LblPredVal.Name = "LblPredVal"
        Me.LblPredVal.Size = New System.Drawing.Size(259, 34)
        Me.LblPredVal.TabIndex = 14
        Me.LblPredVal.Text = "Predicted value:"
        Me.LblPredVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnWatch
        '
        Me.BtnWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWatch.Location = New System.Drawing.Point(374, 426)
        Me.BtnWatch.Name = "BtnWatch"
        Me.BtnWatch.Size = New System.Drawing.Size(107, 45)
        Me.BtnWatch.TabIndex = 16
        Me.BtnWatch.Text = "WATCH"
        Me.BtnWatch.UseVisualStyleBackColor = True
        '
        'BtnGraph
        '
        Me.BtnGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGraph.Location = New System.Drawing.Point(416, 250)
        Me.BtnGraph.Name = "BtnGraph"
        Me.BtnGraph.Size = New System.Drawing.Size(64, 38)
        Me.BtnGraph.TabIndex = 17
        Me.BtnGraph.Text = "GRAPH"
        Me.BtnGraph.UseVisualStyleBackColor = True
        '
        'Transaction_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 576)
        Me.Controls.Add(Me.BtnGraph)
        Me.Controls.Add(Me.BtnWatch)
        Me.Controls.Add(Me.LblPredVal)
        Me.Controls.Add(Me.LblOwnedShares)
        Me.Controls.Add(Me.LblBalance)
        Me.Controls.Add(Me.LbltCost)
        Me.Controls.Add(Me.TxtbxQty)
        Me.Controls.Add(Me.LblQty)
        Me.Controls.Add(Me.BtnSell)
        Me.Controls.Add(Me.BtnBuy)
        Me.Controls.Add(Me.LblStockPriceChange)
        Me.Controls.Add(Me.LblStockMktCap)
        Me.Controls.Add(Me.LblStockLow)
        Me.Controls.Add(Me.LblStockProf)
        Me.Controls.Add(Me.LblStockHigh)
        Me.Controls.Add(Me.LblStockPrice)
        Me.Controls.Add(Me.LblStockName)
        Me.Name = "Transaction_Page"
        Me.Text = "Transaction_Page"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblStockName As Windows.Forms.Label
    Friend WithEvents LblStockPrice As Windows.Forms.Label
    Friend WithEvents LblStockHigh As Windows.Forms.Label
    Friend WithEvents LblStockProf As Windows.Forms.Label
    Friend WithEvents LblStockLow As Windows.Forms.Label
    Friend WithEvents LblStockMktCap As Windows.Forms.Label
    Friend WithEvents LblStockPriceChange As Windows.Forms.Label
    Friend WithEvents BtnBuy As Windows.Forms.Button
    Friend WithEvents BtnSell As Windows.Forms.Button
    Friend WithEvents LblQty As Windows.Forms.Label
    Friend WithEvents TxtbxQty As Windows.Forms.TextBox
    Friend WithEvents LbltCost As Windows.Forms.Label
    Friend WithEvents LblBalance As Windows.Forms.Label
    Friend WithEvents LblOwnedShares As Windows.Forms.Label
    Friend WithEvents LblPredVal As Windows.Forms.Label
    Friend WithEvents BtnWatch As Windows.Forms.Button
    Friend WithEvents BtnGraph As Windows.Forms.Button
End Class
