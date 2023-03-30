<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graph_Page
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.LblStockName = New System.Windows.Forms.Label()
        Me.GraphPrice = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.GraphPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblStockName
        '
        Me.LblStockName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockName.Location = New System.Drawing.Point(0, 5)
        Me.LblStockName.Name = "LblStockName"
        Me.LblStockName.Size = New System.Drawing.Size(779, 39)
        Me.LblStockName.TabIndex = 0
        Me.LblStockName.Text = "Company name"
        Me.LblStockName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GraphPrice
        '
        ChartArea1.Name = "ChartArea1"
        Me.GraphPrice.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.GraphPrice.Legends.Add(Legend1)
        Me.GraphPrice.Location = New System.Drawing.Point(1, 54)
        Me.GraphPrice.Name = "GraphPrice"
        Me.GraphPrice.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Red
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.Maroon
        Series1.Name = "SharePrice"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.GraphPrice.Series.Add(Series1)
        Me.GraphPrice.Size = New System.Drawing.Size(774, 385)
        Me.GraphPrice.TabIndex = 1
        Me.GraphPrice.Text = "Chart"
        '
        'Graph_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 444)
        Me.Controls.Add(Me.GraphPrice)
        Me.Controls.Add(Me.LblStockName)
        Me.Name = "Graph_Page"
        Me.Text = "Graph_Page"
        CType(Me.GraphPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblStockName As Windows.Forms.Label
    Friend WithEvents GraphPrice As Windows.Forms.DataVisualization.Charting.Chart
End Class
