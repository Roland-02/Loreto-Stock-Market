Public Class WatchList_Page
    'ticker symbol, company name, price change, date added
    Dim MyFormat As String = "{0,-15}{1,-50}{2,-20}{3,-25}{4,-25}" 'format list box
    Private Sub WatchList_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
        DisplayData() 'display watched stock in list box
    End Sub
    Public Sub DisplayData()
        'diplay stocklist to table 
        LstbxWatchList.Items.Clear()
        LstbxWatchList.Items.Add(String.Format(MyFormat, "Ticker", "Company name", "Price(£)", "Price change(£)", "Pred. profit(£)"))
        For i = 0 To WatchList.Count - 1
            With WatchList.Item(i)
                LstbxWatchList.Items.Add(String.Format(MyFormat, .GetStockID, .GetStockName, .GetStockPrice().ToString("N"), .GetPriceChange.ToString("N"), .CalcPredProf().ToString("N")))
            End With
        Next
    End Sub
    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles BtnClearAll.Click
        'clear watchlist
        WatchList.Clear()
        DisplayData() 'update table
    End Sub
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        'remove selected item from list
        Try
            WatchList.RemoveAt(LstbxWatchList.SelectedIndex)
            DisplayData() 'update table 
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Table is updating")
        End Try

    End Sub
    Private Sub LstbxWatchList_DoubleClick(sender As Object, e As EventArgs) Handles LstbxWatchList.DoubleClick
        'open transaction form for selected stock in listbox when it's double clicked
        Try
            If LstbxWatchList.SelectedIndex - 1 >= 0 Then
                Dim temp As Stock = WatchList.Item(LstbxWatchList.SelectedIndex - 1) 'create temporary stock
                Index = StocksList.IndexOf(temp) 'find index of slected item
                Dim TransactionForm As New Transaction_Page
                TransactionForm.Show()

                'if more than one form is open, close the first one
                TranPageList.Add(TransactionForm)
                If TranPageList.Count() > 1 Then
                    TranPageList.Item(0).Close()
                    TranPageList.RemoveAt(0)
                End If
            End If
        Catch ex As ArgumentOutOfRangeException
            MsgBox("Table is updating")
        End Try

    End Sub

End Class