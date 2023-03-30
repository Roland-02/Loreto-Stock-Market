'first page to open
'contains all teh timers for updating stock price and deducting loan payments 
'has menu to navigate between pages
Public Class MainPage
    Dim MarketOpen As Boolean = False  'is the real life stock exhange is open
    Dim watchpageList As New List(Of WatchList_Page) 'stores instances of watchlist page
    Dim histpageList As New List(Of History_Page) 'stores instances of history page
    Dim bankpageList As New List(Of Bank_Page) 'stores instances of bank page

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStocksToList() 'load stocks from database to list
        'open market page straight away
        Dim market As New Market_Page()
        market.MdiParent = Me
        marketpageList.Add(market)
        market.Show()
    End Sub
    Private Sub MainPgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainPgeToolStripMenuItem.Click
        'open market page
        Dim market As New Market_Page()
        market.MdiParent = Me
        market.Show()
        'if market page is already open, close one of the pages
        marketpageList.Add(market)
        If marketpageList.Count > 1 Then
            marketpageList.Item(0).Close()
            marketpageList.RemoveAt(0)
        End If
    End Sub
    Private Sub WatchListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatchListToolStripMenuItem.Click
        'open watchlist page
        Dim watchpage As New WatchList_Page
        watchpage.MdiParent = Me
        watchpage.Show()
        'if watchlist page is already open, close one of the pages
        watchpageList.Add(watchpage)
        If watchpageList.Count > 1 Then
            watchpageList.Item(0).Close()
            watchpageList.RemoveAt(0)
        End If
    End Sub
    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        'open history page
        Dim histpage As New History_Page
        histpage.MdiParent = Me
        histpage.Show()
        'if history pay is already open, close one of the pages
        histpageList.Add(histpage)
        If histpageList.Count > 1 Then
            histpageList.Item(0).Close()
            histpageList.RemoveAt(0)
        End If
    End Sub
    Private Sub PortfolioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortfolioToolStripMenuItem.Click
        'open portfolio page
        Dim portfolio As New Portfolio_Page
        portfolio.MdiParent = Me
        portfolio.Show()
        'if portfolio is already open, close one of the pages
        portList.Add(portfolio)
        If portList.Count > 1 Then
            portList.Item(0).Close()
            portList.RemoveAt(0)
        End If
    End Sub
    Private Sub BankToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankToolStripMenuItem.Click
        'open bank page
        Dim bank As New Bank_Page
        bank.MdiParent = Me
        bank.Show()
        'if bank is already open, close one of the pages 
        bankpageList.Add(bank)
        If bankpageList.Count > 1 Then
            bankpageList.Item(0).Close()
            bankpageList.RemoveAt(0)
        End If
    End Sub

    Private Sub ChangeTimer_Tick(sender As Object, e As EventArgs) Handles ChangeTimer.Tick
        'ammend stock price and volume manually when market form is closed
        ChangeTimer.Interval = DecideWhichTime() 'set the interval for ChangeTimer
        For Each item As Integer In DecideWhichStocks() 'every stock that is being amended is held in this list
            AmendStockPrice(item) 'amend stock share price
            AmendStockVol(item) 'amend stock volume
            StocksList.Item(item).AddTime(DateTime.Now) 'add time of price change
        Next

        'if market page is open update table
        If marketpageList.Count = 1 Then
            marketpageList.Item(0).DisplayData()
        End If
        'if watch page is open update table
        If watchpageList.Count = 1 Then
            watchpageList.Item(0).DisplayData()
        End If
        'if transaction page is open update table
        If TranPageList.Count = 1 Then
            TranPageList.Item(0).UpdatePageLabels(Index)
            If TranPageList.Item(0).graphpageList.Count = 1 Then   'plot new share price on graph
                TranPageList.Item(0).graphpageList.Item(0).UpdateGraph(StocksList.Item(Index).GetStockPrice(), DateTime.Now)
            End If
        End If
        'if portfolio page is open update table
        If portList.Count = 1 Then
            portList.Item(0).DisplayData()
        End If


    End Sub
    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        'refresh data from file and re-display every 15 minutes
        'only enabled betwwen 9am-4pm
        RefreshData()

        'if market page is open update table
        If marketpageList.Count = 1 Then
            marketpageList.Item(0).DisplayData()
        End If
        'if watch page is open update table
        If watchpageList.Count = 1 Then
            watchpageList.Item(0).DisplayData()
        End If
        'update transaction page
        If TranPageList.Count = 1 Then
            TranPageList.Item(0).UpdatePageLabels(Index)
            If TranPageList.Item(0).graphpageList.Count = 1 Then  'plot new share price on graph
                TranPageList.Item(0).graphpageList.Item(0).UpdateGraph(StocksList.Item(Index).GetStockPrice(), StocksList.Item(Index).GetRecentTime())
            End If
        End If
        'if portfolio page is open update table
        If portList.Count = 1 Then
            portList.Item(0).DisplayData()
        End If

    End Sub
    Private Sub TimeTimer_Tick(sender As Object, e As EventArgs) Handles TimeTimer.Tick
        'display current time and day in market page
        If marketpageList.Count = 1 Then
            marketpageList.Item(0).LblTime.Text = TimeString
            marketpageList.Item(0).LblDate.Text = DateString
        End If

        'if market is closed, values don't need to be updated from file 
        If isMarketOpen() = True Then
            RefreshTimer.Enabled = True
            ChangeTimer.Enabled = True
        Else
            RefreshTimer.Enabled = False
            ChangeTimer.Enabled = True
        End If

        'if the user has taken a loan out, activate timer
        If LoanActive = True Then
            If PaymentTimer.Enabled = False Then
                PaymentTimer.Enabled = True
                Dim lender As Bank = bankpageList.Item(0).CheckedBank
            End If
        Else
            PaymentTimer.Enabled = False
        End If
    End Sub
    Private Sub PaymentTimer_Tick(sender As Object, e As EventArgs) Handles PaymentTimer.Tick
        'user makes loan repayment
        'interval is already set to 10 mintutes, so user won't pay straight away
        Dim lender As Bank = bankpageList.Item(0).CheckedBank()

        If User1.Balance > lender.BankLoan Then
            If lender.BankLoan <= 0 Then
                LoanActive = False 'loan has been fully paid off
                lender.Mpay = lender.Mpay
                lender.BankLoan = lender.BankLoan
            Else
                User1.Balance = -(lender.Mpay) 'deduct payment from balance
                lender.BankLoan = lender.Mpay 'deduct payment from total repayment amount
                transList.Add(New Transaction(lender.GetBankName + " Loan Payment", -(lender.Mpay), 0, User1.Balance, False)) 'create transaction record
            End If

        Else
            DefaultLoan() 'sell users assets, set LTM and balance to 0
            LoanActive = False
        End If

        UpdateMarketPageLbls()

    End Sub
    Function isMarketOpen() As Boolean
        'check is the real-life stock market is open or closed (only open from 9am to 4pm)
        If TimeString < #9:30:00 AM# Or TimeString > #4:00:00 PM# Then
            MarketOpen = False 'stock market is closed
        Else
            MarketOpen = True 'stock market is closed
        End If
        Return MarketOpen
    End Function

End Class