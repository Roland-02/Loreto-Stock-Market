using WizardStockExchange.Models;

namespace WizardStockExchange.Services;

public class GameState
{
    public User CurrentUser { get; } = new(10000m);
    public List<Stock> AllStocks { get; } = new();
    public List<Stock> OwnedStocks { get; } = new();
    public List<Stock> WatchList { get; } = new();
    public List<Transaction> Transactions { get; } = new();
    public bool LoanActive { get; set; }
    public Bank? ActiveLender { get; set; }

    public Bank Barclays { get; } = new("Barclays", 10000, 200000, 140);
    public Bank Natwest { get; } = new("Natwest", 15000, 250000, 125);
    public Bank Lloyds { get; } = new("Lloyds", 20000, 300000, 115);
    public Bank HSBC { get; } = new("HSBC", 25000, 350000, 105);

    public event Action? OnStateChanged;
    public void NotifyStateChanged() => OnStateChanged?.Invoke();
}
