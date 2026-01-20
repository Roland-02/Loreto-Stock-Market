namespace WizardStockExchange.Models;

public class User
{
    private decimal _balance;
    private decimal _totalProfit;

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
            if (_totalProfit <= 0) return 0;
            return (int)(75 * Math.Log10((double)_totalProfit + 1));
        }
    }

    public decimal TotalProfit
    {
        get => _totalProfit;
        set => _totalProfit = value;
    }

    public void AdjustProfit(decimal amount) => _totalProfit += amount;
}
