Imports Microsoft.Office.Interop 'needed to access excel files
Module Module1
    Dim random As New Random
    Dim file As String = CurDir() + "\Stocks.xlsx" 'excel spreadsheet with the stocks
    Public Index As Integer = 0 'selected item in list
    Dim idList As New List(Of String) 'stores transaction ID's made to ensure they're unique
    Public LoanActive As Boolean = False 'is the user paying back a loan?

    Public StocksList As New List(Of Stock)  'list of objects stores each sock and it's properties
    Public OwnedStocksList As New List(Of Stock) 'stores the stocks that the user has purchased
    Public transList As New List(Of Transaction) 'stores the user's transactions
    Public WatchList As New List(Of Stock) 'stocks added to watchlist

    Public User1 As New User(10000, 0, 0) 'instantiate user object with £10,000, 0 LTMscore and 0 total profit

    Public Barclays As New Bank("Barclays", 10000, 200000, 140, 0, 0) 'high acc rate, low interst rate 
    Public Natwest As New Bank("Natwest", 15000, 250000, 125, 0, 0)
    Public Lloyds As New Bank("Lloyds", 20000, 300000, 115, 0, 0)
    Public HSBC As New Bank("HSBC", 25000, 350000, 105, 0, 0) 'low acc rate, high interest

    Public TranPageList As New List(Of Transaction_Page) 'stores instances of transaction page
    Public marketpageList As New List(Of Market_Page) 'stores instances of market page
    Public portList As New List(Of Portfolio_Page) 'stores instances of portfolio page

    Public Structure Transaction 'public scope for easier access
        'record structure for a transaction
        Dim tID As String
        Dim sName As String
        Dim cost As Double
        Dim qty As Long
        Dim tDate As Date
        Dim Bafter As Double
        Dim mark As Boolean 'if shares are from a new or pre-existing investment

        Public Sub New(s As String, c As Double, q As Long, a As Double, m As Boolean)
            'constructor for transaction class
            tID = CreateId() 'calls function to make ID
            sName = s
            cost = c
            qty = q
            tDate = Date.Now 'current date
            Bafter = a
            mark = m
        End Sub

    End Structure
    Sub Main()


    End Sub
    Public Sub LoadStocksToList()
        'open stocks file and instantiate new stock objects with values from the excel database

        'initialise variables 
        Dim ticker As String = ""
        Dim name As String = ""
        Dim val As Double = 0
        Dim vol As Long = 0
        Dim mktcap As Double = 0
        Dim owned As Long = 0

        Dim xl As New Excel.Application
        xl.Workbooks.Open(file) 'open excel workbook
        xl.Worksheets("Sheet1").Activate() 'activate sheet in workbook with the data
        xl.ActiveWorkbook.RefreshAll() 'refresh data connections in workbook before reading data
        Dim totalRow As Integer = xl.ActiveSheet.UsedRange.Rows.Count 'total number of rows

        For i = 1 To totalRow
            With xl.Worksheets("Sheet1")
                ticker = .Range(("B" + i.ToString)).value  'assign value from cell in each row to variable
                name = .Range(("C" + i.ToString)).value
                val = .Range(("D" + i.ToString)).value
                vol = .Range(("E" + i.ToString)).value
                mktcap = .Range(("I" + i.ToString)).value
                owned = False
            End With
            name = FormatStockName(name) 'format the stock name to exclude uneeded characters

            Dim Values As New List(Of Double) 'list of price values for that stock item
            Values.Add(val) 'add the first stock price to the list of vlaues 
            Dim Times As New List(Of DateTime) 'list of times of price change
            Times.Add(DateTime.Now) 'add first tm=ime to list of times
            'create new object and add to list of objects
            StocksList.Add(New Stock(ticker, name, vol, mktcap, Values, Times, owned))
        Next
        xl.Workbooks.Close() 'close workbook

    End Sub
    Sub RefreshData()
        'refresh the values for each stock with updated data  from database
        Dim xl As New Excel.Application
        xl.Workbooks.Open(file) 'open excel workbook
        xl.Worksheets("Sheet1").Activate()
        xl.ActiveWorkbook.RefreshAll() 'refresh data connections in workbook

        'initialise variables
        Dim newPrice As Double = 0
        Dim newVol As Double = 0
        Dim newHigh As Double = 0
        Dim newLow As Double = 0
        Dim newCompval As Long = 0


        For i = 0 To StocksList.Count - 1
            'if the values from the database are different to the current values, update them
            With xl.Worksheets("Sheet1")
                newPrice = .Range(("D" + (i + 1).ToString)).value
                newVol = .Range(("E" + (i + 1).ToString)).value
                newHigh = .Range(("G" + (i + 1).ToString)).value
                newLow = .Range(("H" + (i + 1).ToString)).value
                newCompval = .Range(("I" + (i + 1).ToString)).value

                If StocksList.Item(i).GetStockPrice() <> newPrice Then
                    StocksList.Item(i).UpdatePrice(newPrice) 'add new price to list     
                    StocksList.Item(i).AddTime(DateTime.Now) 'add new time of price change
                End If

                If StocksList.Item(i).GetStockVol() <> newVol Then
                    StocksList.Item(i).UpdateVol(newVol) 'update share volume
                End If

                If StocksList.Item(i).GetMktCap() <> newCompval Then
                    StocksList.Item(i).UpdateMktCap(newCompval) 'update market cap value
                End If
            End With
        Next
        xl.Workbooks.Close() 'close file

    End Sub
    Function CalcBoundPrice(pos As Integer) As Integer
        Randomize()
        Dim rand1 As Integer = random.Next(100, 1000)
        Dim rand2 As Integer = random.Next(10, rand1)
        Dim val As Integer = StocksList.Item(pos).GetStockPrice() / rand2
        Return val
    End Function
    Sub AmendStockPrice(pos As Integer)
        'change the share price of stock at position pos
        Randomize() 'refresh random numbers
        Dim num As Integer = random.Next(1, 100)
        Dim change As Double = 0
        Dim val As Double = 0
        Dim bound As Integer = CalcBoundPrice(pos) 'call function to find the bound

        If num Mod 2 = 0 Then '50/50 chance of price increasing or decreasing 
            change = random.Next(0, bound) + Rnd()
            val = Math.Round((StocksList.Item(pos).GetStockPrice() + change), 2) 'increase share price
            StocksList.Item(pos).UpdatePrice(val)
        Else
            change = random.Next(0, bound) + Rnd()
            val = Math.Round((StocksList.Item(pos).GetStockPrice() - change), 2) 'decrease share price
            If val <= 0 Then 'if the price can nver fall below £0
                val = Math.Round(Rnd(), 2)
            End If
            StocksList.Item(pos).UpdatePrice(val)
        End If

    End Sub
    Function CalcBoundVol(pos As Integer) As Long
        Randomize()
        Dim rand1 As Integer = random.Next(100, 10000)
        Dim rand2 As Integer = random.Next(10, rand1)
        Dim val As Long = StocksList.Item(pos).GetStockVol() / rand2
        Return val
    End Function
    Sub AmendStockVol(pos As Integer)
        'change stock volume of stock as index 'pos'
        Randomize()
        Dim num As Integer = random.Next(1, 100)
        Dim change As Long = 0
        Dim bound As Long = CalcBoundVol(pos)
        If num Mod 2 = 0 Then
            change = random.Next(0, bound) 'volume can change by 0
            StocksList.Item(pos).UpdateVol(change)
        Else
            change = random.Next(0, bound)
            StocksList.Item(pos).UpdateVol(-change)
        End If

    End Sub

    Function DecideWhichStocks() As List(Of Integer)
        'generate 'length' amont of unique rnadom numbers and return in the list
        Randomize()
        Dim length As Integer = random.Next(0, 351) 'number of stocks to be changed
        Dim StocksToChange As New List(Of Integer) 'stores the indexes
        Dim place As Integer = 0
        Dim j As Integer = 0
        Do
            Randomize()
            place = random.Next(0, 352)
            If IsInList(StocksToChange, place) = False Then
                StocksToChange.Add(place) 'only add to list if it's not already in there
                j += 1
            End If
        Loop Until j = length
        Return StocksToChange
    End Function
    Function IsInList(collection As List(Of Integer), value As Integer) As Boolean
        'check is value is in collection
        Dim found As Boolean = False
        For Each item As Integer In collection
            If item = value Then
                found = True
            End If
        Next
        Return found
    End Function
    Function DecideWhichTime() As Integer
        'determine what time to change price and volume
        Dim time As Integer = random.Next(15000, 60000) 'between 10sec and 10min
        Return time
    End Function

    Function RangeCheck(min As Long, max As Long, input As Long) As Boolean
        'check if inputted value is within the inputted bounds
        Dim valid As Boolean = False
        If min <= input And input <= max Then
            valid = True
        Else
            valid = False
        End If
        Return valid
    End Function
    Function TypeCheckInteger(input As String) As Boolean
        'check if inputted value is an integer
        Dim valid As Boolean = False
        If IsNumeric(input) And Not (input.Contains(".")) And Not (input.Contains("-")) And Not (input.Contains("+")) Then
            valid = True
        Else
            valid = False
        End If
        Return valid
    End Function

    Function FormatStockName(ByVal word As String) As String
        'remove unnecessary characters from stockname
        Dim search As String = "PLC"
        Dim search2 As String = "PUBLIC LIMITED COMPANY"
        Dim search3 As String = "P.L.C"
        Dim search4 As String = "LIMITED"
        Dim search5 As String = "Limited"
        Dim search6 As String = "P L C"

        word = word.Replace(search, "")
        word = word.Replace(search2, "")
        word = word.Replace(search3, "")
        word = word.Replace(search4, "")
        word = word.Replace(search5, "")
        word = word.Replace(search6, "")

        Return word
    End Function
    Function CreateId() As String
        'create unique ID, 2 letter + 3 numbers
        Dim id As String = ""
        Dim letter() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

        Do
            For i = 0 To 1
                Randomize() 'add 2 random letters
                id += letter(random.Next(0, 26))
            Next
            For i = 0 To 2
                Randomize() 'add two random numbers
                id += random.Next(1, 10).ToString
            Next
            idList.Add(id)
            'check if id is a duplciated
            If IsInListString(idList, id) = True Then
                idList.Remove(id)
            End If
        Loop Until IsInListString(idList, id) = False

        Return id
    End Function
    Function IsInListString(collection As List(Of String), value As String) As Boolean
        Dim found As Boolean = False
        For Each item As String In collection
            If item = value Then
                found = True
            End If
        Next
        Return found
    End Function
    Function IsInListStock(collection As List(Of Stock), comp As String) As Boolean
        'check if comp is already in watch-list
        Dim found As Boolean = False
        For Each item As Stock In collection
            If item.GetStockID = comp Then
                found = True
            End If
        Next
        Return found
    End Function

    Function FindIndexinTransList(loc As Integer, list As List(Of Stock)) As Integer
        'find most recent market position of bought stock to find how much it was bought for in transaction list
        Dim place As Integer = 0
        Dim temp As Stock = list.Item(loc)
        Dim name As String = temp.GetStockName()

        For i = (transList.Count - 1) To 0 Step -1 'search list in reverse order
            'find most recent instance that stock was bought for the first time
            If transList.Item(i).sName = name And transList.Item(i).cost < 0 And transList.Item(i).mark = True Then
                place = i
            End If
        Next

        Return place
    End Function
    Function FindIndexinOwnedStocks(id As String) As Integer
        'find index of stock in OwnedStocksList in StocksList 
        Dim place As Integer = 0
        For Each item As Stock In OwnedStocksList 'linear search
            If item.GetStockID = id Then
                place = OwnedStocksList.IndexOf(item)
            End If
        Next
        Return place
    End Function

    Sub UpdateMarketPageLbls()
        'update labels in market page if it's open
        If marketpageList.Count = 1 Then 'if market page is open
            marketpageList.Item(0).LblBalance.Text = ("Balance: £" + User1.Balance().ToString("N")) 'call property to update label
            marketpageList.Item(0).LblScore.Text = ("Score: " + User1.Score().ToString)
        End If
    End Sub
    Sub UpdatePortPageLbls()
        'update lables in portfolio page if it's open
        If portList.Count = 1 Then
            portList.Item(0).LblTotProf.Text = ("Total profit: £" + User1.Totalprof().ToString("N"))
            portList.Item(0).DisplayData()
        End If
    End Sub

    Public Sub DefaultLoan()
        'user can't afford loan payment; take all assets
        MsgBox("YOU CANNOT AFFORD TO PAY YOUR LOAN, YOU ACCOUNT WILL NOW BE DEFAULTED")
        portList.Item(0).SellOwnedStocks()
        User1.Balance = -(User1.Balance)
        User1.Score = -(User1.Score)
    End Sub


End Module