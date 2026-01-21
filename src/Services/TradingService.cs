using WizardStockExchange.Models;

namespace WizardStockExchange.Services;

public class TradingService
{
    private readonly GameState _gameState;

    public TradingService(GameState gameState)
    {
        _gameState = gameState;
    }

    public (bool Success, string Message) BuyStock(Stock stock, int quantity)
    {
        if (quantity <= 0)
            return (false, "Quantity must be positive");

        if (quantity > stock.Volume)
            return (false, "Insufficient shares available");

        var cost = stock.CurrentPrice * quantity;
        if (cost > _gameState.CurrentUser.Balance)
            return (false, "Insufficient funds");

        _gameState.CurrentUser.AdjustBalance(-cost);
        stock.UpdateVolume(-quantity);

        var isNewInvestment = !_gameState.OwnedStocks.Contains(stock);
        if (isNewInvestment)
        {
            _gameState.OwnedStocks.Add(stock);
        }

        stock.UpdateOwnedShares(quantity);

        _gameState.Transactions.Add(new Transaction(
            stock.Name, -cost, quantity, _gameState.CurrentUser.Balance, isNewInvestment));

        _gameState.NotifyStateChanged();
        return (true, $"Bought {quantity} shares of {stock.Name} for £{cost:N2}");
    }

    public (bool Success, string Message) SellStock(Stock stock, int quantity)
    {
        if (quantity <= 0)
            return (false, "Quantity must be positive");

        if (quantity > stock.OwnedShares)
            return (false, "You don't own that many shares");

        var proceeds = stock.CurrentPrice * quantity;
        _gameState.CurrentUser.AdjustBalance(proceeds);
        stock.UpdateVolume(quantity);
        stock.UpdateOwnedShares(-quantity);

        _gameState.Transactions.Add(new Transaction(
            stock.Name, proceeds, quantity, _gameState.CurrentUser.Balance, false));

        if (stock.OwnedShares == 0)
        {
            var profit = CalculateProfit(stock);
            _gameState.CurrentUser.AdjustProfit(profit);
            _gameState.OwnedStocks.Remove(stock);
        }

        _gameState.NotifyStateChanged();
        return (true, $"Sold {quantity} shares of {stock.Name} for £{proceeds:N2}");
    }

    public (bool Success, string Message) SellAllStocks()
    {
        var totalProceeds = 0m;
        foreach (var stock in _gameState.OwnedStocks.ToList())
        {
            var proceeds = stock.CurrentPrice * stock.OwnedShares;
            totalProceeds += proceeds;

            _gameState.Transactions.Add(new Transaction(
                stock.Name, proceeds, stock.OwnedShares, _gameState.CurrentUser.Balance + proceeds, false));

            var profit = CalculateProfit(stock);
            _gameState.CurrentUser.AdjustProfit(profit);

            stock.UpdateVolume(stock.OwnedShares);
            stock.UpdateOwnedShares(-stock.OwnedShares);
        }

        _gameState.CurrentUser.AdjustBalance(totalProceeds);
        _gameState.OwnedStocks.Clear();
        _gameState.NotifyStateChanged();

        return (true, $"Sold all stocks for £{totalProceeds:N2}");
    }

    private decimal CalculateProfit(Stock stock)
    {
        var buyTotal = 0m;
        var sellTotal = 0m;

        foreach (var t in _gameState.Transactions.Where(t => t.StockName == stock.Name))
        {
            if (t.Amount < 0)
                buyTotal += -t.Amount;
            else
                sellTotal += t.Amount;
        }

        return sellTotal - buyTotal;
    }

    public void AddToWatchList(Stock stock)
    {
        if (!_gameState.WatchList.Contains(stock))
        {
            _gameState.WatchList.Add(stock);
            _gameState.NotifyStateChanged();
        }
    }

    public void RemoveFromWatchList(Stock stock)
    {
        _gameState.WatchList.Remove(stock);
        _gameState.NotifyStateChanged();
    }

    public void ClearWatchList()
    {
        _gameState.WatchList.Clear();
        _gameState.NotifyStateChanged();
    }

    public void ClearTransactionHistory()
    {
        _gameState.Transactions.Clear();
        _gameState.CurrentUser.TotalProfit = 0;
        _gameState.NotifyStateChanged();
    }
}
