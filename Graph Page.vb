'graph page displays the share price for a company in a graph, with time as the x-axis

Imports System.Windows.Forms

Public Class Graph_Page
    Private Sub Graph_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = (StocksList.Item(Index).GetStockName() + " Share Price")
            Me.TopMost = True
            LblStockName.Text = StocksList.Item(Index).GetStockName()
            FormatGraph()
            GraphPrice.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
            GraphPrice.ChartAreas(0).AxisX.Title = "Time"
            GraphPrice.ChartAreas(0).AxisY.Title = "Share price (£)"

            For i = 0 To StocksList.Item(Index).GetValueListCount - 1
                GraphPrice.Series(0).Points.AddXY(StocksList.Item(Index).GetTimeAtPos(i), StocksList.Item(Index).GetPriceAtPos(i))
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Me.Close()
        End Try
    End Sub

    Public Sub UpdateGraph(value As Double, t As DateTime)
        Try
            FormatGraph()
            GraphPrice.Series(0).Points.AddXY(t, value)

            If GraphPrice.ChartAreas(0).AxisX.Maximum > GraphPrice.ChartAreas(0).AxisX.ScaleView.Size Then
                GraphPrice.ChartAreas(0).AxisX.ScaleView.Scroll(GraphPrice.ChartAreas(0).AxisX.Maximum)
            End If
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Public Sub FormatGraph()
        Dim margin As Double = 0.1 * (StocksList.Item(Index).GetStockHigh() - StocksList.Item(Index).GetStockLow()) ' Adjust this margin percentage as needed
        GraphPrice.ChartAreas(0).AxisY.Minimum = Math.Round(StocksList.Item(Index).GetStockLow() - 1)
        GraphPrice.ChartAreas(0).AxisY.Maximum = Math.Round(StocksList.Item(Index).GetStockHigh() + 1 + margin)
    End Sub
End Class


