Public Class Bank
    Private Name As String
    Private Max As Integer
    Private IntConst As Integer
    Private AccConst As Integer
    Private LoanAmount As Integer
    Private MonthlyPay As Double

    'constructor
    Public Sub New(n As String, m As Integer, i As Double, acc As Double, l As Integer, mpay As Double)
        Name = n
        Max = m
        IntConst = i
        AccConst = acc
        LoanAmount = l
        MonthlyPay = mpay
    End Sub

    'setters/getters
    Public Function GetBankName()
        'output name of bank
        Return Name
    End Function
    Public Function GetBankMax()
        'output maximum loan amount
        Return Max
    End Function
    Public Property Mpay As Double
        Get
            Return MonthlyPay
        End Get
        Set(value As Double)
            MonthlyPay -= value
        End Set
    End Property
    Public Property BankLoan As Integer
        'access loan taken out from bank
        Get
            Return LoanAmount
        End Get
        Set(value As Integer)
            LoanAmount -= value
        End Set
    End Property
    Public Function CalcInterest(amount As Integer, score As Integer)
        'calculate interest for loan
        Return Math.Round((IntConst / (amount * score)), 2)
    End Function
    Public Function LoanApply(score As Integer, amount As Integer, mPay As Double)
        'accept or reject loan application
        If (score / AccConst) > (amount / User1.Balance) And (mPay * 2) < User1.Balance Then
            Return True
        Else
            Return False
        End If
    End Function

End Class