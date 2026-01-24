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
        stock.TotalCostBasis += cost;

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
        var costBasisForSold = stock.AverageCostPerShare * quantity;
        var profit = proceeds - costBasisForSold;
        
        _gameState.CurrentUser.AdjustBalance(proceeds);
        _gameState.CurrentUser.AdjustProfit(profit);
        
        stock.UpdateVolume(quantity);
        stock.UpdateOwnedShares(-quantity);
        stock.TotalCostBasis -= costBasisForSold;

        _gameState.Transactions.Add(new Transaction(
            stock.Name, proceeds, quantity, _gameState.CurrentUser.Balance, false));

        if (stock.OwnedShares == 0)
        {
            stock.TotalCostBasis = 0;
            _gameState.OwnedStocks.Remove(stock);
        }

        _gameState.NotifyStateChanged();
        return (true, $"Sold {quantity} shares for £{proceeds:N2} (Profit: £{profit:N2})");
    }

    public (bool Success, string Message) SellAllStocks()
    {
        var totalProceeds = 0m;
        var totalProfit = 0m;
        
        foreach (var stock in _gameState.OwnedStocks.ToList())
        {
            var proceeds = stock.CurrentPrice * stock.OwnedShares;
            var profit = proceeds - stock.TotalCostBasis;
            
            totalProceeds += proceeds;
            totalProfit += profit;

            _gameState.Transactions.Add(new Transaction(
                stock.Name, proceeds, stock.OwnedShares, _gameState.CurrentUser.Balance + totalProceeds, false));

            stock.UpdateVolume(stock.OwnedShares);
            stock.UpdateOwnedShares(-stock.OwnedShares);
            stock.TotalCostBasis = 0;
        }

        _gameState.CurrentUser.AdjustBalance(totalProceeds);
        _gameState.CurrentUser.AdjustProfit(totalProfit);
        _gameState.OwnedStocks.Clear();
        _gameState.NotifyStateChanged();

        return (true, $"Sold all stocks for £{totalProceeds:N2} (Profit: £{totalProfit:N2})");
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
