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

    public Bank Barclays { get; } = new("Barclays", 10000, 0.069m);
    public Bank Natwest { get; } = new("Natwest", 15000, 0.089m);
    public Bank Lloyds { get; } = new("Lloyds", 20000, 0.119m);
    public Bank HSBC { get; } = new("HSBC", 25000, 0.149m);

    public event Action? OnStateChanged;
    public void NotifyStateChanged() => OnStateChanged?.Invoke();
}
