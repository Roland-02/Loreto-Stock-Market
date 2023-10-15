'displays the stocks that user is currently invested in
Imports System.Windows.Forms

Public Class Portfolio_Page
    Dim MyFormat As String = "{0,-10}{1,-53}{2,-25}{3,-25}{4,-25}{5,-25}" 'format list box

    'Dim marketPage As Market_Page

    Private Sub Portfolio_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        UpdateLabels()
    End Sub
    Private Sub LstbxPortfolio_DoubleClick(sender As Object, e As EventArgs) Handles LstbxPortfolio.DoubleClick
        'open transaction form on double click
        Try
            If LstbxPortfolio.SelectedIndex - 1 >= 0 Then
                Dim temp As Stock = OwnedStocksList.Item(LstbxPortfolio.SelectedIndex - 1) 'create temporary stock
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
    Private Sub BtnSellAll_Click(sender As Object, e As EventArgs) Handles BtnSellAll.Click
        'sell every stock in the user's portfolio 
        DialogResult = MsgBox("SELL ALL ASSETS FOR £" + CalcTotProf().ToString("N") + " ?", MsgBoxStyle.OkCancel)
        If DialogResult = Windows.Forms.DialogResult.OK Then
            SellOwnedStocks() 'call subroutine to sell everything in the ownedstocksList
        End If
    End Sub
    Sub DisplayData()
        LstbxPortfolio.Items.Clear()
        LstbxPortfolio.Items.Add(String.Format(MyFormat, "Ticker", "Company name", "Price(£)", "Price change(£)", "Pred. profit(£)", "Owned shares"))
        For i = 0 To OwnedStocksList.Count - 1
            With OwnedStocksList.Item(i)
                LstbxPortfolio.Items.Add(String.Format(MyFormat, .GetStockID, .GetStockName, .GetStockPrice.ToString("N"), .GetPriceChange.ToString("N"), .CalcPredProf().ToString("N"), .GetOwnedShares().ToString("N0")))
            End With
        Next
    End Sub
    Function CalcTotProf() As Double
        'calulate total proft from selling all owned shares at once
        Dim total As Double = 0
        For Each item As Stock In OwnedStocksList
            total += (item.GetStockPrice() * item.GetOwnedShares())
        Next
        Return total
    End Function
    Sub SellOwnedStocks()
        'sell every stock in the owned stocks list 
        For i = 0 To OwnedStocksList.Count - 1
            Dim amount As Long = OwnedStocksList.Item(i).GetOwnedShares
            Dim price As Double = amount * OwnedStocksList.Item(i).GetStockPrice()

            'update stock volume and owned shares
            OwnedStocksList.Item(i).UpdateOwnedShares(-(amount))
            OwnedStocksList.Item(i).UpdateVol(amount)

            User1.Balance = price 'update balance

            'calls constructor to create tranasction record
            transList.Add(New Transaction(OwnedStocksList.Item(i).GetStockName(), price, amount, User1.Balance, False))

            'Update total profit
            Dim ind As Integer = FindIndexinTransList(i, OwnedStocksList)
            User1.Totalprof = User1.CalcProfit(ind, amount)
        Next
        User1.Score = User1.Totalprof() 'update score
        OwnedStocksList.Clear() 'clear list
        LblTotProf.Text = ("Total profit: £" + User1.Totalprof.ToString("N")) 'update label
        DisplayData() 'update table

        If marketPage IsNot Nothing Then
            marketPage.UpdateLabels()
        End If

    End Sub

    Sub UpdateLabels()
        LblTotProf.Text = ("Total profit: £" + User1.Totalprof.ToString("N"))
        DisplayData() 'display data to list box upon loading

    End Sub

    Private Sub Portfolio_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit? All progress will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ConfirmationDialog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class