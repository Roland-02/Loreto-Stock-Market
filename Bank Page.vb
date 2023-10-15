'user can take out loan which they pay back, including interest, over a chosen period
Imports System.Windows.Forms

Public Class Bank_Page

    Private Sub Bank_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        lockPage()
        'if LTM is less than 100 disable form


    End Sub


    Private Sub lockPage()
        If User1.Score < 100 Then
            Enable(False)
        Else
            If LoanActive Then
                Enable(False)
                LblDisabledMsg.Visible = True
            Else
                Enable(True)
                LblDisabledMsg.Visible = False
            End If
        End If
    End Sub

    Private Sub Enable(pick As Boolean)
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is GroupBox Or TypeOf ctl Is Button Then
                ctl.Enabled = pick
            End If
        Next ctl
    End Sub

    Private Sub RdBtnBarclays_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnBarclays.CheckedChanged
        DisplayData(Barclays)
    End Sub
    Private Sub RdBtnHSBC_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnHSBC.CheckedChanged
        DisplayData(HSBC)
    End Sub
    Private Sub RdBtnLloyds_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnLloyds.CheckedChanged
        DisplayData(Lloyds)
    End Sub
    Private Sub RdBtnNatwest_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnNatwest.CheckedChanged
        DisplayData(Natwest)
    End Sub

    Private Sub TxtbxAmount_TextChanged(sender As Object, e As EventArgs) Handles TxtbxAmount.TextChanged
        'update labels when text is changed
        DisplayData(CheckedBank())
    End Sub
    Private Sub CmoBxTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmoBxTime.SelectedIndexChanged
        'update labels when time is changed
        DisplayData(CheckedBank())
    End Sub

    Public Sub DisplayData(lender As Bank)
        'display loan information in form 
        TxtbxMax.Text = ("£" + lender.GetBankMax().ToString()) 'display maximum loan amount for bank
        If TypeCheckInteger(TxtbxAmount.Text) = True Then 'validate input is number
            Dim borrow As Integer = TxtbxAmount.Text
            If RangeCheck(1000, lender.GetBankMax(), borrow) = True Then 'validate input is within bounds
                Dim int As Double = lender.CalcInterest(borrow, User1.Score) 'calculate interest rate
                Dim repay As Double = borrow + (borrow * (int)) 'calculate total repay amount
                TxtbxInt.Text = int * 100 'display interest
                TxtBxTotRepay.Text = ("£" + repay.ToString("N")) 'display total repay amount
                If TypeCheckInteger(CmoBxTime.Text) = True Then 'validate time is valid number
                    TxtbxRepay.Text = ("£" + (repay / CmoBxTime.Text).ToString("N")) 'display monthly repay amount
                Else
                    TxtbxRepay.Text = ("-")
                End If
            Else
                TxtBxTotRepay.Text = ("-")
                TxtbxRepay.Text = ("-")
                TxtbxInt.Text = ("-")
            End If
        Else
            TxtBxTotRepay.Text = ("-")
            TxtbxRepay.Text = ("-")
            TxtbxInt.Text = ("-")
        End If

    End Sub
    Public Function CheckedBank() As Bank
        'return selected bank
        If RdBtnBarclays.Checked = True Then
            Return Barclays
        ElseIf RdBtnHSBC.Checked = True Then
            Return HSBC
        ElseIf RdBtnLloyds.Checked = True Then
            Return Lloyds
        Else
            Return Natwest
        End If
    End Function
    Public Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
        'apply for loan
        If IsNumeric(TxtbxRepay.Text) Then 'if valid data has been entered
            If CheckedBank().LoanApply(User1.Score, TxtbxAmount.Text, TxtbxRepay.Text) = True Then 'if application is accepted
                If Confirmation() = True Then 'user confirms loan through msgbx
                    DoLoan(CheckedBank(), TxtBxTotRepay.Text, CmoBxTime.Text) 'carry out loan
                End If
            Else
                MsgBox("CREDIT INSUFFICIENT OR AMOUNT TOO LARGE")
            End If
        Else
            MsgBox("INVALID DATA ENTERED")
        End If
    End Sub
    Public Function Confirmation() As Boolean
        'confirm loan
        DialogResult = MsgBox("Total to repay: " + TxtBxTotRepay.Text + Environment.NewLine + "Monthly Repayments: " + TxtbxRepay.Text, MsgBoxStyle.OkCancel)
        If DialogResult = Windows.Forms.DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub DoLoan(lender As Bank, tPay As Integer, m As Integer)
        lender.Mpay = (-(tPay / m)) 'set MonthlyPay attribute
        lender.BankLoan = -tPay 'set BankLoan attribute
        User1.Balance = TxtbxAmount.Text 'increment user's balance
        LoanActive = True

    End Sub

    Private Sub Bank_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit? All progress will be lost.", "Exit sTrade?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ConfirmationDialog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class