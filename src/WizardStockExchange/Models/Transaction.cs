namespace WizardStockExchange.Models;

public class Transaction
{
    private static readonly Random _random = new();
    private static readonly HashSet<string> _usedIds = new();

    public string Id { get; }
    public string StockName { get; }
    public decimal Amount { get; }
    public long Quantity { get; }
    public DateTime Date { get; }
    public decimal BalanceAfter { get; }
    public bool IsNewInvestment { get; }

    public Transaction(string stockName, decimal amount, long quantity, decimal balanceAfter, bool isNewInvestment)
    {
        Id = GenerateUniqueId();
        StockName = stockName;
        Amount = amount;
        Quantity = quantity;
        Date = DateTime.Now;
        BalanceAfter = balanceAfter;
        IsNewInvestment = isNewInvestment;
    }

    private static string GenerateUniqueId()
    {
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string id;
        do
        {
            var chars = new char[2];
            chars[0] = letters[_random.Next(26)];
            chars[1] = letters[_random.Next(26)];
            var numbers = _random.Next(100, 1000);
            id = new string(chars) + numbers;
        } while (_usedIds.Contains(id));

        _usedIds.Add(id);
        return id;
    }
}
