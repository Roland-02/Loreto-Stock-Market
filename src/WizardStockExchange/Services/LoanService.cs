using WizardStockExchange.Models;

namespace WizardStockExchange.Services;

public class LoanService
{
    private readonly GameState _gameState;
    private readonly TradingService _tradingService;
    private Timer? _paymentTimer;

    public LoanService(GameState gameState, TradingService tradingService)
    {
        _gameState = gameState;
        _tradingService = tradingService;
    }

    public (bool Success, string Message) ApplyForLoan(Bank bank, int amount, int months)
    {
        if (_gameState.LoanActive)
            return (false, "You already have an active loan");

        if (_gameState.CurrentUser.Score < 100)
            return (false, "Your score must be at least 100 to apply for a loan");

        if (amount < 1000 || amount > bank.MaxLoan)
            return (false, $"Loan amount must be between £1,000 and £{bank.MaxLoan:N0}");

        var interest = bank.CalculateInterest(amount, _gameState.CurrentUser.Score);
        var totalRepay = amount + (amount * (decimal)interest);
        var monthlyPayment = totalRepay / months;

        if (!bank.EvaluateLoanApplication(_gameState.CurrentUser.Score, amount, monthlyPayment, _gameState.CurrentUser.Balance))
            return (false, "Loan application rejected - credit insufficient or amount too large");

        bank.LoanAmount = totalRepay;
        bank.MonthlyPayment = monthlyPayment;
        _gameState.CurrentUser.AdjustBalance(amount);
        _gameState.LoanActive = true;
        _gameState.ActiveLender = bank;

        StartPaymentTimer();
        _gameState.NotifyStateChanged();

        return (true, $"Loan approved! £{amount:N0} added to your balance. Monthly payments: £{monthlyPayment:N2}");
    }

    private void StartPaymentTimer()
    {
        _paymentTimer = new Timer(ProcessPayment, null, TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(1));
    }

    private void ProcessPayment(object? state)
    {
        if (!_gameState.LoanActive || _gameState.ActiveLender == null)
        {
            _paymentTimer?.Dispose();
            return;
        }

        var bank = _gameState.ActiveLender;
        if (bank.LoanAmount <= 0)
        {
            _gameState.LoanActive = false;
            _paymentTimer?.Dispose();
            _gameState.NotifyStateChanged();
            return;
        }

        if (_gameState.CurrentUser.Balance >= bank.MonthlyPayment)
        {
            _gameState.CurrentUser.AdjustBalance(-bank.MonthlyPayment);
            bank.LoanAmount -= bank.MonthlyPayment;

            _gameState.Transactions.Add(new Transaction(
                $"{bank.Name} Loan Payment", -bank.MonthlyPayment, 0, _gameState.CurrentUser.Balance, false));

            if (bank.LoanAmount <= 0)
            {
                _gameState.LoanActive = false;
                _paymentTimer?.Dispose();
            }
        }
        else
        {
            DefaultLoan();
        }

        _gameState.NotifyStateChanged();
    }

    private void DefaultLoan()
    {
        _tradingService.SellAllStocks();
        _gameState.CurrentUser.Balance = -_gameState.CurrentUser.Balance;
        _gameState.CurrentUser.TotalProfit = -_gameState.CurrentUser.TotalProfit;
        _gameState.LoanActive = false;
        _paymentTimer?.Dispose();
    }
}
