'user buys/sells shares of stock 
'user can also add stocks to watch-list
'graph page opened from this form
Public Class Transaction_Page
    Public graphpageList As New List(Of Graph_Page) 'stores instances of graph pages

    Private Sub Transaction_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LblBalance.Text = ("Balance: £" + User1.Balance.ToString("N"))
            Name = (StocksList.Item(Index).GetStockName())
            LblStockName.Text = (StocksList.Item(Index).GetStockName())
            LblStockPrice.Text = ("Price: £" + StocksList.Item(Index).GetStockPrice().ToString("N"))
            LblStockPriceChange.Text = ("Change: £" + StocksList.Item(Index).GetPriceChange().ToString("N"))
            LblPredVal.Text = ("Predicted value: £" + StocksList.Item(Index).GetPredictedVal().ToString("N"))
            LblStockProf.Text = ("Predicted profit: " + StocksList.Item(Index).CalcPredProf().ToString("N") + "%")
            LblStockHigh.Text = ("High: £" + StocksList.Item(Index).GetStockHigh().ToString("N"))
            LblStockLow.Text = ("Low: £" + StocksList.Item(Index).GetStockLow().ToString("N"))
            LblStockMktCap.Text = ("Market cap: £" + StocksList.Item(Index).GetMktCap().ToString("N0"))
            LblOwnedShares.Text = ("Owned shares: " + StocksList.Item(Index).GetOwnedShares().ToString("N0"))
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Table is updating")
        End Try

        CheckifWatched() 'check if watch button should be enabled or  disbaled

    End Sub
    Private Sub BtnBuy_Click(sender As Object, e As EventArgs) Handles BtnBuy.Click
        'buy  inputted amount of shares of selected stock and update balance
        Dim balance As Double = User1.Balance 'call property
        Dim vol As Long = StocksList.Item(Index).GetStockVol()

        If TypeCheckInteger(TxtbxQty.Text) = True Then 'if input qty is a number convert it to type long
            Dim InpQty = Convert.ToInt32(TxtbxQty.Text)
            Dim cost As Double = CalculateCost(InpQty, StocksList.Item(Index).GetStockPrice())
            If RangeCheck(1, vol, InpQty) = True Then 'if input qty is not more than the available shares
                If RangeCheck(0.01, balance, cost) = True Then 'if the cost is not more that the user's balance 

                    'subtract from balance
                    User1.Balance = (-cost)

                    'update the stock volume and owned shares
                    StocksList.Item(Index).UpdateVol(-InpQty)

                    Dim mark As Boolean
                    'check if stock is owned and add to list
                    If IsInListStock(OwnedStocksList, StocksList.Item(Index).GetStockID) = False Then
                        OwnedStocksList.Add(StocksList.Item(Index)) 'add to list of owned stocks if it's not already there
                        mark = True 'new investment
                    Else
                        mark = False 'buying more shares in current investment
                    End If

                    'create transaction record and add to list
                    transList.Add(New Transaction(StocksList.Item(Index).GetStockName(), (-cost), InpQty, User1.Balance, mark))

                    'find position of selected stock in ownedStockList
                    Dim tempPos As Integer = FindIndexinOwnedStocks(StocksList.Item(Index).GetStockID())
                    OwnedStocksList.Item(tempPos).UpdateOwnedShares(InpQty) 'update number of shares owned

                    'update labels
                    LblBalance.Text = ("Balance: £" + User1.Balance.ToString("N"))
                    LblStockProf.Text = ("Volume: " + StocksList.Item(Index).GetStockVol().ToString("N0"))
                    LblOwnedShares.Text = ("Owned shares: " + StocksList.Item(Index).GetOwnedShares().ToString("N0"))

                    If marketPage IsNot Nothing Then
                        marketPage.UpdateLabels()
                    End If



                Else
                    MsgBox("Insufficient funds")
                End If
            Else
                MsgBox("Quantity not in allowed range")
            End If
        Else
            MsgBox("Quantity must be a valid integer")
        End If

    End Sub
    Private Sub BtnSell_Click(sender As Object, e As EventArgs) Handles BtnSell.Click
        'sell inputted qty of stock shares and update attributes

        If TypeCheckInteger(TxtbxQty.Text) = True Then 'if input qty is a number convert it to type long

            Dim InpQty = Convert.ToInt32(TxtbxQty.Text)
            If StocksList.Item(Index).GetOwnedShares() > 0 Then
                Dim OwnedShares As Double = StocksList.Item(Index).GetOwnedShares() 'get amount of shares owned for stock 
                If RangeCheck(1, OwnedShares, InpQty) = True Then 'if input isn't more than owned shares
                    Dim cost As Double = CalculateCost(InpQty, StocksList.Item(Index).GetStockPrice())

                    'increment user balance
                    User1.Balance = cost

                    'update stock volume
                    StocksList.Item(Index).UpdateVol(InpQty)

                    'find position of selected stock in ownedStockList
                    Dim tempPos As Integer = FindIndexinOwnedStocks(StocksList.Item(Index).GetStockID) 'need?
                    OwnedStocksList.Item(tempPos).UpdateOwnedShares(-InpQty)

                    'create transaction record and add to list
                    transList.Add(New Transaction(StocksList.Item(Index).GetStockName(), cost, InpQty, User1.Balance, False))

                    'remove from list of owned stocks if all shares are sold and find profit from investment
                    If StocksList.Item(Index).GetOwnedShares() = 0 Then
                        OwnedStocksList.Remove(StocksList.Item(Index))
                        'update total profit
                        Dim profit As Double = User1.CalcProfit(FindIndexinTransList(Index, StocksList), cost)
                        User1.Totalprof = profit
                    End If

                    'update LTM score
                    User1.Score = User1.Totalprof

                    'update labels
                    LblStockProf.Text = ("Volume: " + StocksList.Item(Index).GetStockVol().ToString("N0"))
                    LblBalance.Text = ("Balance: £" + User1.Balance.ToString("N"))
                    LblOwnedShares.Text = ("Owned shares: " + StocksList.Item(Index).GetOwnedShares().ToString("N0"))


                    If marketPage IsNot Nothing Then
                        marketPage.UpdateLabels()
                    End If

                    If portfolioPage IsNot Nothing Then
                        portfolioPage.UpdateLabels()
                    End If



                Else
                    MsgBox("You do not own this many shares")
                End If
            Else
                MsgBox("You do not own any shares of this stock")
            End If
        Else
            MsgBox("Quantity must be a valid integer")
        End If

    End Sub
    Private Sub TxtbxQty_TextChanged(sender As Object, e As EventArgs) Handles TxtbxQty.TextChanged
        Try
            If TypeCheckInteger(TxtbxQty.Text) = True Then
                Dim InpQty = Convert.ToInt32(TxtbxQty.Text)
                LbltCost.Text = ("Cost: £" + (CalculateCost(InpQty, StocksList.Item(Index).GetStockPrice())).ToString("N"))
            Else
                LbltCost.Text = ("Cost: £-")
            End If
        Catch ex As OverflowException 'prevents crash from overflow
            MsgBox("Enter a smaller value")
        End Try

    End Sub
    Function CalculateCost(qty As Integer, price As Double) As Double
        'find cost of transaction
        Dim cost As Double = Math.Round((qty * price), 2)
        Return cost
    End Function
    Sub UpdatePageLabels(pos As Integer)
        'update the labels in the transaction form for the stock at index 'pos'
        'try-except stops crash when user clicks table while it's empty
        Try
            LblBalance.Text = ("Balance: £" + User1.Balance.ToString("N"))
            Name = (StocksList.Item(pos).GetStockName())
            LblStockName.Text = (StocksList.Item(pos).GetStockName())
            LblStockPrice.Text = ("Price: £" + StocksList.Item(pos).GetStockPrice().ToString("N"))
            LblPredVal.Text = ("Predicted value: £" + StocksList.Item(Index).GetPredictedVal().ToString("N"))
            LblStockPriceChange.Text = ("Change: £" + StocksList.Item(pos).GetPriceChange().ToString("N"))
            LblStockProf.Text = ("Predicted profit: " + StocksList.Item(pos).CalcPredProf().ToString("N") + "%")
            LblStockHigh.Text = ("High: £" + StocksList.Item(pos).GetStockHigh().ToString("N"))
            LblStockLow.Text = ("Low: £" + StocksList.Item(pos).GetStockLow().ToString("N"))
            LblStockMktCap.Text = ("Market cap: £" + StocksList.Item(Index).GetMktCap().ToString("N0"))
            LblOwnedShares.Text = ("Owned shares: " + StocksList.Item(Index).GetOwnedShares().ToString("N0"))
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Table is updating")
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnWatch.Click
        'add selected stock to watch-list
        WatchList.Add(StocksList.Item(Index))
        CheckifWatched()
        If watchListPage IsNot Nothing Then
            watchListPage.DisplayData()
        End If
    End Sub
    Private Sub CheckifWatched()
        'if the stock is already in the watch-list disable the button
        If IsInListStock(WatchList, StocksList.Item(Index).GetStockID) = True Then
            BtnWatch.Enabled = False
        Else
            BtnWatch.Enabled = True
        End If
    End Sub
    Private Sub BtnGraph_Click(sender As Object, e As EventArgs) Handles BtnGraph.Click
        'open graph form
        'if stock price hasn't been changed yet graph is not opened
        If StocksList.Item(Index).GetStockHigh() = StocksList.Item(Index).GetStockLow() Then
            MsgBox("Chart not currently available for this company")
        Else
            Dim graphForm As New Graph_Page()
            graphForm.Show()
            graphpageList.Add(graphForm)
            If graphpageList.Count > 1 Then   'only one page opens at a time
                graphpageList.Item(0).Close()
                graphpageList.RemoveAt(0)
            End If
        End If

    End Sub
    Private Sub Transaction_Page_FormClosed(sender As Object, e As Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'close graph page if it's open when transaction form is opened
        If graphpageList.Count = 1 Then
            graphpageList.Item(0).Close()
            graphpageList.RemoveAt(0)
        End If

    End Sub
End Class