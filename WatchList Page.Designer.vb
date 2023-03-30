<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WatchList_Page
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
        Me.LstbxWatchList = New System.Windows.Forms.ListBox()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnClearAll = New System.Windows.Forms.Button()
        Me.LblWacthList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstbxWatchList
        '
        Me.LstbxWatchList.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LstbxWatchList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstbxWatchList.FormattingEnabled = True
        Me.LstbxWatchList.ItemHeight = 16
        Me.LstbxWatchList.Location = New System.Drawing.Point(12, 130)
        Me.LstbxWatchList.Name = "LstbxWatchList"
        Me.LstbxWatchList.Size = New System.Drawing.Size(784, 340)
        Me.LstbxWatchList.TabIndex = 0
        '
        'BtnRemove
        '
        Me.BtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.Location = New System.Drawing.Point(845, 200)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(182, 69)
        Me.BtnRemove.TabIndex = 1
        Me.BtnRemove.Text = "REMOVE"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnClearAll
        '
        Me.BtnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearAll.Location = New System.Drawing.Point(845, 285)
        Me.BtnClearAll.Name = "BtnClearAll"
        Me.BtnClearAll.Size = New System.Drawing.Size(182, 69)
        Me.BtnClearAll.TabIndex = 2
        Me.BtnClearAll.Text = "CLEAR ALL"
        Me.BtnClearAll.UseVisualStyleBackColor = True
        '
        'LblWacthList
        '
        Me.LblWacthList.BackColor = System.Drawing.Color.Transparent
        Me.LblWacthList.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWacthList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblWacthList.Location = New System.Drawing.Point(335, 9)
        Me.LblWacthList.Name = "LblWacthList"
        Me.LblWacthList.Size = New System.Drawing.Size(332, 69)
        Me.LblWacthList.TabIndex = 9
        Me.LblWacthList.Text = "Watch List"
        Me.LblWacthList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WatchList_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1039, 493)
        Me.Controls.Add(Me.LblWacthList)
        Me.Controls.Add(Me.BtnClearAll)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.LstbxWatchList)
        Me.Name = "WatchList_Page"
        Me.Text = "WatchList_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstbxWatchList As Windows.Forms.ListBox
    Friend WithEvents BtnRemove As Windows.Forms.Button
    Friend WithEvents BtnClearAll As Windows.Forms.Button
    Friend WithEvents LblWacthList As Windows.Forms.Label
End Class
