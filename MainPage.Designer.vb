<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MainPgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortfolioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WatchListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PaymentTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainPgeToolStripMenuItem, Me.PortfolioToolStripMenuItem, Me.WatchListToolStripMenuItem, Me.BankToolStripMenuItem, Me.HistoryToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1094, 37)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MainPgeToolStripMenuItem
        '
        Me.MainPgeToolStripMenuItem.Name = "MainPgeToolStripMenuItem"
        Me.MainPgeToolStripMenuItem.Size = New System.Drawing.Size(76, 33)
        Me.MainPgeToolStripMenuItem.Text = "Market"
        '
        'PortfolioToolStripMenuItem
        '
        Me.PortfolioToolStripMenuItem.Name = "PortfolioToolStripMenuItem"
        Me.PortfolioToolStripMenuItem.Size = New System.Drawing.Size(90, 33)
        Me.PortfolioToolStripMenuItem.Text = "Portfolio"
        '
        'WatchListToolStripMenuItem
        '
        Me.WatchListToolStripMenuItem.Name = "WatchListToolStripMenuItem"
        Me.WatchListToolStripMenuItem.Size = New System.Drawing.Size(100, 33)
        Me.WatchListToolStripMenuItem.Text = "Watch List"
        '
        'BankToolStripMenuItem
        '
        Me.BankToolStripMenuItem.Name = "BankToolStripMenuItem"
        Me.BankToolStripMenuItem.Size = New System.Drawing.Size(60, 33)
        Me.BankToolStripMenuItem.Text = "Bank"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(78, 33)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'ChangeTimer
        '
        Me.ChangeTimer.Interval = 10000
        '
        'TimeTimer
        '
        Me.TimeTimer.Enabled = True
        Me.TimeTimer.Interval = 1000
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Interval = 900253
        '
        'PaymentTimer
        '
        Me.PaymentTimer.Interval = 600000
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.Name = "MainPage"
        Me.Text = "WSM"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip As Windows.Forms.MenuStrip
    Friend WithEvents MainPgeToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortfolioToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents WatchListToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents BankToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeTimer As Windows.Forms.Timer
    Friend WithEvents TimeTimer As Windows.Forms.Timer
    Friend WithEvents RefreshTimer As Windows.Forms.Timer
    Friend WithEvents PaymentTimer As Windows.Forms.Timer
End Class
