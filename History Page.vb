'displays past transactions, e.g. stock sales and purchases as well as loan payments
Imports System.Windows.Forms

Public Class History_Page
    Dim MyFormat As String = "{0,-50}{1,-25}{2,-15}{3,-30}{4,-25}" 'format list box
    Private Sub History_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DisplayData()
    End Sub
    Public Sub DisplayData()
        'display transaction list to table
        LstbxHistory.Items.Clear()
        LstbxHistory.Items.Add(String.Format(MyFormat, "Company name", "Cost", "Qty", "Date", "Balance"))
        For i = 0 To transList.Count() - 1
            With transList.Item(i)
                LstbxHistory.Items.Add(String.Format(MyFormat, .sName, .cost.ToString("N"), .qty.ToString("N0"), .tDate.ToString(), .Bafter.ToString("N")))
            End With
        Next

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClearHist.Click
        'clear the user's transaction history 
        DialogResult = MsgBox("WIPING HISTORY WILL RESET LTM SCORE, ARE YOU SURE?", MsgBoxStyle.YesNo, "WARNING")
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            transList.Clear()
            DisplayData()
            User1.Score = -User1.Score 'wipe LTM score
            LblLastCleared.Text = ("History last cleard on " + Date.Now.ToString()) 'update label
        End If
    End Sub
    Private Sub History_Page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit? All progress will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ConfirmationDialog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class