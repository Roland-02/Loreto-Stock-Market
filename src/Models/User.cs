namespace WizardStockExchange.Models;

public class User
{
    private decimal _balance;
    private decimal _totalProfit;
    private const decimal PointsPerPound = 0.1m;

    public User(decimal initialBalance = 10000m)
    {
        _balance = initialBalance;
        _totalProfit = 0;
    }

    public decimal Balance
    {
        get => _balance;
        set => _balance = value;
    }

    public void AdjustBalance(decimal amount) => _balance += amount;

    public int Score
    {
        get
        {
            // 1 point per £10 profit, starts at 0
            return (int)Math.Round(_totalProfit * PointsPerPound);
        }
    }

    public decimal TotalProfit
    {
        get => _totalProfit;
        set => _totalProfit = value;
    }

    public void AdjustProfit(decimal amount) => _totalProfit += amount;
}
