<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Portfolio_Page
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
        Me.LblPortfolioPage = New System.Windows.Forms.Label()
        Me.LstbxPortfolio = New System.Windows.Forms.ListBox()
        Me.BtnSellAll = New System.Windows.Forms.Button()
        Me.LblTotProf = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblPortfolioPage
        '
        Me.LblPortfolioPage.BackColor = System.Drawing.Color.Transparent
        Me.LblPortfolioPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPortfolioPage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPortfolioPage.Location = New System.Drawing.Point(373, 9)
        Me.LblPortfolioPage.Name = "LblPortfolioPage"
        Me.LblPortfolioPage.Size = New System.Drawing.Size(170, 60)
        Me.LblPortfolioPage.TabIndex = 11
        Me.LblPortfolioPage.Text = "Portfolio"
        Me.LblPortfolioPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LstbxPortfolio
        '
        Me.LstbxPortfolio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LstbxPortfolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstbxPortfolio.FormattingEnabled = True
        Me.LstbxPortfolio.ItemHeight = 15
        Me.LstbxPortfolio.Location = New System.Drawing.Point(47, 151)
        Me.LstbxPortfolio.Name = "LstbxPortfolio"
        Me.LstbxPortfolio.Size = New System.Drawing.Size(873, 289)
        Me.LstbxPortfolio.TabIndex = 12
        '
        'BtnSellAll
        '
        Me.BtnSellAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSellAll.Location = New System.Drawing.Point(47, 73)
        Me.BtnSellAll.Name = "BtnSellAll"
        Me.BtnSellAll.Size = New System.Drawing.Size(161, 60)
        Me.BtnSellAll.TabIndex = 13
        Me.BtnSellAll.Text = "SELL ALL"
        Me.BtnSellAll.UseVisualStyleBackColor = True
        '
        'LblTotProf
        '
        Me.LblTotProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotProf.Location = New System.Drawing.Point(670, 87)
        Me.LblTotProf.Name = "LblTotProf"
        Me.LblTotProf.Size = New System.Drawing.Size(290, 46)
        Me.LblTotProf.TabIndex = 14
        Me.LblTotProf.Text = "Total Profit: "
        Me.LblTotProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Portfolio_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(981, 458)
        Me.Controls.Add(Me.LblTotProf)
        Me.Controls.Add(Me.BtnSellAll)
        Me.Controls.Add(Me.LstbxPortfolio)
        Me.Controls.Add(Me.LblPortfolioPage)
        Me.Name = "Portfolio_Page"
        Me.Text = "Portfolio_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblPortfolioPage As Windows.Forms.Label
    Friend WithEvents LstbxPortfolio As Windows.Forms.ListBox
    Friend WithEvents BtnSellAll As Windows.Forms.Button
    Friend WithEvents LblTotProf As Windows.Forms.Label
End Class
