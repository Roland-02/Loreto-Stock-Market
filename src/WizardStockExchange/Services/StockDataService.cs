using WizardStockExchange.Models;

namespace WizardStockExchange.Services;

public class StockDataService
{
    private readonly GameState _gameState;
    private readonly Random _random = new();
    private Timer? _priceUpdateTimer;

    private static readonly (string Ticker, string Name, decimal Price, long Volume, decimal MarketCap)[] SampleStocks = new[]
    {
        ("SHEL", "Shell", 2547.50m, 15234567L, 180000000000m),
        ("HSBA", "HSBC Holdings", 642.30m, 28456123L, 130000000000m),
        ("BP", "BP", 487.65m, 32145678L, 95000000000m),
        ("AZN", "AstraZeneca", 10234.00m, 4523678L, 165000000000m),
        ("GSK", "GSK", 1456.80m, 8765432L, 72000000000m),
        ("ULVR", "Unilever", 4123.50m, 3214567L, 108000000000m),
        ("DGE", "Diageo", 2876.40m, 5432167L, 65000000000m),
        ("RIO", "Rio Tinto", 5234.80m, 6543218L, 92000000000m),
        ("GLEN", "Glencore", 456.78m, 45678912L, 59000000000m),
        ("REL", "RELX", 2987.60m, 4321567L, 58000000000m),
        ("LLOY", "Lloyds Banking Group", 52.34m, 156234567L, 33000000000m),
        ("BARC", "Barclays", 187.65m, 87654321L, 30000000000m),
        ("NWG", "NatWest Group", 287.43m, 23456789L, 28000000000m),
        ("VOD", "Vodafone Group", 72.45m, 98765432L, 19000000000m),
        ("BT.A", "BT Group", 132.67m, 54321678L, 13000000000m),
        ("AAL", "Anglo American", 2345.67m, 6789012L, 42000000000m),
        ("ANTO", "Antofagasta", 1567.89m, 3456789L, 15000000000m),
        ("IMB", "Imperial Brands", 1987.54m, 4567890L, 16000000000m),
        ("BATS", "British American Tobacco", 2567.89m, 5678901L, 58000000000m),
        ("PRU", "Prudential", 987.65m, 8901234L, 27000000000m),
        ("LGEN", "Legal & General", 234.56m, 34567890L, 14000000000m),
        ("AVIVA", "Aviva", 456.78m, 23456789L, 12000000000m),
        ("NG", "National Grid", 1034.56m, 7890123L, 38000000000m),
        ("SSE", "SSE", 1756.89m, 6789012L, 18000000000m),
        ("CNA", "Centrica", 145.67m, 45678901L, 8000000000m),
        ("SVT", "Severn Trent", 2567.89m, 2345678L, 6000000000m),
        ("UU", "United Utilities", 1098.76m, 3456789L, 7500000000m),
        ("WPP", "WPP", 876.54m, 8901234L, 9000000000m),
        ("III", "3i Group", 2345.67m, 2345678L, 23000000000m),
        ("STAN", "Standard Chartered", 687.54m, 12345678L, 20000000000m),
        ("RKT", "Reckitt Benckiser", 5432.10m, 3456789L, 38000000000m),
        ("CPG", "Compass Group", 2187.65m, 5678901L, 38000000000m),
        ("EXPN", "Experian", 3254.32m, 3456789L, 30000000000m),
        ("SBRY", "Sainsbury's", 267.89m, 23456789L, 6000000000m),
        ("TSCO", "Tesco", 298.76m, 45678901L, 22000000000m),
        ("MKS", "Marks & Spencer", 287.65m, 18765432L, 5500000000m),
        ("JD", "JD Sports Fashion", 134.56m, 34567890L, 7000000000m),
        ("OCDO", "Ocado Group", 456.78m, 12345678L, 3500000000m),
        ("ABF", "Associated British Foods", 2123.45m, 4567890L, 17000000000m),
        ("PSON", "Pearson", 987.65m, 5678901L, 7000000000m),
        ("ITV", "ITV", 67.89m, 56789012L, 2700000000m),
        ("AUTO", "Auto Trader Group", 765.43m, 7890123L, 7000000000m),
        ("RMV", "Rightmove", 567.89m, 6789012L, 5000000000m),
        ("SGE", "Sage Group", 1098.76m, 5678901L, 11000000000m),
        ("DARK", "Darktrace", 345.67m, 8901234L, 2500000000m),
        ("BA", "BAE Systems", 1234.56m, 9012345L, 37000000000m),
        ("RR", "Rolls-Royce Holdings", 423.45m, 23456789L, 35000000000m),
        ("SMT", "Scottish Mortgage Investment Trust", 765.43m, 6789012L, 10000000000m),
        ("FRAS", "Frasers Group", 876.54m, 5678901L, 4000000000m),
        ("HIK", "Hikma Pharmaceuticals", 1876.54m, 3456789L, 4000000000m)
    };

    public StockDataService(GameState gameState)
    {
        _gameState = gameState;
    }

    public void LoadInitialStocks()
    {
        _gameState.AllStocks.Clear();
        foreach (var (ticker, name, price, volume, marketCap) in SampleStocks)
        {
            _gameState.AllStocks.Add(new Stock(ticker, name, volume, marketCap, price));
        }
    }

    public void StartPriceUpdates()
    {
        _priceUpdateTimer = new Timer(UpdatePrices, null, TimeSpan.FromSeconds(15), TimeSpan.FromSeconds(15));
    }

    public void StopPriceUpdates()
    {
        _priceUpdateTimer?.Dispose();
    }

    private void UpdatePrices(object? state)
    {
        var stocksToUpdate = _random.Next(1, _gameState.AllStocks.Count / 3);
        var indices = Enumerable.Range(0, _gameState.AllStocks.Count)
            .OrderBy(_ => _random.Next())
            .Take(stocksToUpdate)
            .ToList();

        foreach (var idx in indices)
        {
            var stock = _gameState.AllStocks[idx];
            var changePercent = (_random.NextDouble() - 0.5) * 0.04;
            var newPrice = stock.CurrentPrice * (1 + (decimal)changePercent);
            newPrice = Math.Max(0.01m, Math.Round(newPrice, 2));
            stock.UpdatePrice(newPrice);

            var volumeChange = (long)((_random.NextDouble() - 0.5) * stock.Volume * 0.01);
            stock.UpdateVolume(volumeChange);
        }

        _gameState.NotifyStateChanged();
    }
}
