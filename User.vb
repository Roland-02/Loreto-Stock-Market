'the user
Public Class User
    Private UserBalance As Double 'user's balance
    Private LTMscore As Integer 'Loreto Trade Market score
    Private TotalProft As Double 'total profit user makes in the solution

    'constructor
    Public Sub New(b As Integer, p As Double, l As Integer)
        UserBalance = b
        LTMscore = l
        TotalProft = p
    End Sub
    Public Property Balance As Double
        'access the user's balance
        Get
            Return UserBalance
        End Get
        Set(value As Double)
            UserBalance += value
        End Set
    End Property
    Public Property Score As Integer
        'update and access LTM score
        Get
            Return LTMscore
        End Get
        Set(value As Integer) 'total profit rounded to integer
            Try
                LTMscore = (75 * Math.Log10(value + 1))
            Catch ex As OverflowException
                'occurs when total profit is negative
                LTMscore = 0
            End Try

        End Set
    End Property
    Public Property Totalprof As Double
        'access and amend TotalProf attribute
        Get
            Return TotalProft
        End Get
        Set(value As Double)
            TotalProft += value
        End Set
    End Property

    Public Function CalcProfit(pos As Integer, sellPrice As Double) As Double
        'calculate profit from stock after all shares have been sold
        'profit = previous sale prices - buy price

        Dim buyPrice As Double = (-(transList.Item(pos).cost)) 'price of buy transaction
        Dim profit As Double = 0

        For i = pos + 1 To transList.Count - 1
            'add previous sale prices
            If transList.Item(pos).sName = transList.Item(i).sName And transList.Item(i).cost > 0 Then
                profit += transList.Item(i).cost
            ElseIf transList.Item(pos).sName = transList.Item(i).sName And transList.Item(i).cost < 0 Then
                'add previous buy prices to buyprice (total £ in buying shares)
                buyPrice += (-transList.Item(i).cost)
            End If
        Next
        profit -= buyPrice 'deduct price of buy transactions

        Return profit
    End Function

End Class
