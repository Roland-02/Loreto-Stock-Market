'graph page displays the share price for a company in a graph, with time as the x-axis
Public Class Graph_Page
    Private Sub Graph_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = (StocksList.Item(Index).GetStockName() + " Share Price") 'change text at top of form
        Me.TopMost = True  'bring form to top of other open pages
        LblStockName.Text = StocksList.Item(Index).GetStockName() 'display name of selected stock

        FormatGraph() 'set up graph axis
        GraphPrice.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
        GraphPrice.ChartAreas(0).AxisX.Title = "Time"          'set axis labels 
        GraphPrice.ChartAreas(0).AxisY.Title = "Share price (£)"

        For i = 0 To StocksList.Item(Index).GetValueListCount - 1
            'plot all past prices, and the times they were changed on graph
            GraphPrice.Series(0).Points.AddXY(StocksList.Item(Index).GetTimeAtPos(i), StocksList.Item(Index).GetPriceAtPos(i))
        Next
    End Sub
    Public Function CalcYinterval(min As Double, max As Double) As Integer
        'find suitable scale for y-axis (share price)
        Dim scale As Integer = ((min - 1) + max) / GraphPrice.Height
        Return scale
    End Function
    Public Sub UpdateGraph(value As Double, t As DateTime)
        'update graph 
        'try-catch stops crash when graph is closed
        Try
            FormatGraph()
            GraphPrice.Series(0).Points.AddXY(t, value) 'add new price and time of change to graph

            'adjust position of graph so that it all fits on the page
            If GraphPrice.ChartAreas(0).AxisX.Maximum > GraphPrice.ChartAreas(0).AxisX.ScaleView.Size Then
                GraphPrice.ChartAreas(0).AxisX.ScaleView.Scroll(GraphPrice.ChartAreas(0).AxisX.Maximum)
            End If
        Catch ex As NullReferenceException
            Me.Close() 'form is closed instead of program crashing
        End Try

    End Sub
    Public Sub FormatGraph()
        'set minimum and maximum y-axis values and scale for graph
        GraphPrice.ChartAreas(0).AxisY.Minimum = Math.Round(StocksList.Item(Index).GetStockLow() - 1)
        GraphPrice.ChartAreas(0).AxisY.Maximum = Math.Round(StocksList.Item(Index).GetStockHigh() + 1)
        GraphPrice.ChartAreas(0).AxisY.Interval = CalcYinterval(StocksList.Item(Index).GetStockLow, StocksList.Item(Index).GetStockHigh)

    End Sub

End Class