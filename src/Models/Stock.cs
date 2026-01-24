namespace WizardStockExchange.Models;

public class Stock
{
    public string Ticker { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public long Volume { get; set; }
    public decimal MarketCap { get; set; }
    public List<decimal> PriceHistory { get; private set; } = new();
    public List<DateTime> TimeHistory { get; private set; } = new();
    public long OwnedShares { get; set; }
    public decimal TotalCostBasis { get; set; }

    public Stock() { }

    public Stock(string ticker, string name, long volume, decimal marketCap, decimal initialPrice)
    {
        Ticker = ticker;
        Name = name;
        Volume = volume;
        MarketCap = marketCap;
        PriceHistory.Add(initialPrice);
        TimeHistory.Add(DateTime.Now);
        OwnedShares = 0;
        TotalCostBasis = 0;
    }

    public decimal AverageCostPerShare => OwnedShares > 0 ? TotalCostBasis / OwnedShares : 0;
    
    public decimal UnrealizedProfit => OwnedShares > 0 ? (CurrentPrice * OwnedShares) - TotalCostBasis : 0;

    public decimal CurrentPrice => PriceHistory.Count > 0 ? PriceHistory[^1] : 0;

    public decimal PriceChange
    {
        get
        {
            if (PriceHistory.Count < 2) return 0;
            return Math.Round(PriceHistory[^1] - PriceHistory[^2], 2);
        }
    }

    public decimal PercentChange
    {
        get
        {
            if (PriceHistory.Count < 2 || PriceHistory[^2] == 0) return 0;
            return Math.Round((PriceHistory[^1] - PriceHistory[^2]) / PriceHistory[^2] * 100, 2);
        }
    }

    public decimal High => PriceHistory.Count > 0 ? PriceHistory.Max() : 0;
    public decimal Low => PriceHistory.Count > 0 ? PriceHistory.Min() : 0;

    public void UpdatePrice(decimal newPrice)
    {
        PriceHistory.Add(newPrice);
        TimeHistory.Add(DateTime.Now);
    }

    public void UpdateVolume(long change) => Volume += change;
    public void UpdateOwnedShares(long change) => OwnedShares += change;

    public decimal PredictedValue
    {
        get
        {
            if (PriceHistory.Count <= 1) return CurrentPrice;
            var gradient = (PriceHistory[^1] - PriceHistory[0]) / (PriceHistory.Count - 1);
            var predicted = (gradient * PriceHistory.Count) + PriceHistory[0];
            return predicted <= 0 ? 0.01m : predicted;
        }
    }

    public decimal PredictedProfitPercent
    {
        get
        {
            if (CurrentPrice == 0) return 0;
            return Math.Round((PredictedValue - CurrentPrice) / CurrentPrice * 100, 2);
        }
    }
}
