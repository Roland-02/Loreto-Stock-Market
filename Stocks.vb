'the stock
Public Class Stock
    Private StockID As String 'stock ID is just the ticker symbol form the database, as they're unique
    Private StockName As String 'name of the stock
    Private StockVol As Long 'amount of stock shares available
    Private StockMktCap As Long 'value of company
    Private ValueList As List(Of Double) 'list of past values, past values will be loaded into the list
    Private TimeList As List(Of DateTime) 'list of times at which past values have been changed
    Private OwnedShares As Long 'number of shares the user owns for the company
    Public Sub New(id As String, n As String, Q As Long, cv As Long, v As List(Of Double), t As List(Of DateTime), o As Long)
        'constructor
        StockID = id
        StockName = n
        StockVol = Q
        StockMktCap = cv
        ValueList = v
        TimeList = t
        OwnedShares = o
    End Sub
    'getters
    Public Function GetStockName() As String
        'output the name of the stock
        Return StockName
    End Function
    Public Function GetStockID() As String
        'output the ID of the stock
        Return StockID
    End Function
    Public Function GetStockVol() As Long
        'output the quantity of stock shares
        Return StockVol
    End Function
    Public Function GetPriceChange() As Double
        'output the change in stock price
        Dim change As Double = 0
        If ValueList.Count = 1 Then
            change = 0
        Else
            Dim pos As Integer = ValueList.Count - 2
            change = Math.Round((ValueList.Last - ValueList.Item(pos)), 2)
        End If
        Return change
    End Function
    Public Function GetStockPrice() As Double
        'output the share value of the stock
        Return ValueList.Last 'return the last value added to the list
    End Function
    Public Function GetStockHigh() As Double
        Return ValueList.Max
    End Function
    Public Function GetStockLow() As Double
        Return ValueList.Min
    End Function
    Public Function GetMktCap() As Long
        'return market cap of the stock 
        Return StockMktCap
    End Function
    Public Function GetOwnedShares() As Long
        'return amount shares the user owns
        Return OwnedShares
    End Function
    Public Function GetTimeAtPos(i As Integer) As DateTime
        'return time at position i
        Return TimeList.Item(i)
    End Function
    Public Function GetRecentTime() As DateTime
        'return most recent time of price change
        Return TimeList.Last
    End Function
    Public Function GetValueListCount() As Integer
        'output number of prices in valuelist
        Return ValueList.Count
    End Function
    Public Function GetPriceAtPos(pos As Integer) As Double
        'return price at position pos
        Return ValueList.Item(pos)
    End Function

    'setters
    Public Sub UpdateVol(ByVal value As Long)
        'update the volume of available stock shares
        StockVol += value
    End Sub
    Public Sub UpdateMktCap(ByVal value As Double)
        'update the market cap of the company
        StockMktCap = value
    End Sub
    Public Sub UpdatePrice(ByVal value As Double)
        'add value to list of share prices
        ValueList.Add(value)
    End Sub
    Public Sub UpdateOwnedShares(ByVal value As Long)
        'update amount of shares the user owns
        OwnedShares += value
    End Sub
    Public Sub AddTime(ByVal value As DateTime)
        'add time to list
        TimeList.Add(value)
    End Sub

    'calculations
    Public Function GetPredictedVal() As Double
        'calculate and reuturn the predicetd price of the stock using regression
        Dim PredVal As Double = 0
        Dim grad As Double = 0
        'if there is only one value in the predicted value is the same as the current price
        If ValueList.Count = 1 Then
            PredVal = ValueList.Item(0)
        Else
            grad = (ValueList.Last - ValueList.First) / (ValueList.Count - 1)   'get gradient of graph
            PredVal = (grad * ValueList.Count) + ValueList.First
        End If

        If PredVal <= 0 Then 'predicted value should be never negative
            PredVal = 0.01
        End If

        Return PredVal
    End Function
    Public Function CalcPredProf() As Double
        'calculated predicted percentage profit per share
        Dim prof As Double = ((GetPredictedVal() - ValueList.Last) / ValueList.Last()) * 100
        prof = Math.Round(prof, 2)

        Return prof
    End Function


End Class
