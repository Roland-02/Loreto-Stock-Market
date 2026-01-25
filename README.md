# Wizard Stock Market

A stock exchange simulator that lets you practice trading with virtual money. Originally built as a Windows Forms VB.NET application, now modernized as a cross-platform Blazor web application.

![.NET](https://img.shields.io/badge/.NET-7.0-512BD4?style=flat-square)
![Blazor](https://img.shields.io/badge/Blazor-Server-512BD4?style=flat-square)
![Platform](https://img.shields.io/badge/Platform-Cross--Platform-green?style=flat-square)

## Features

- **Live Market** - View 50 stocks from the London Stock Exchange (simulated) with real-time price updates
- **Portfolio Management** - Buy and sell stocks, track your investments
- **Watchlist** - Keep an eye on stocks you're interested in
- **Transaction History** - View all your past trades
- **Bank Loans** - Borrow money from various banks to expand your portfolio
- **Price Charts** - Visual price history for each stock
- **Score System** - Earn points based on your trading performance

## Requirements

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) or later
- Works on macOS, Windows, and Linux

## Clone and Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/Roland-02/WizardStockExchange.git
   cd WizardStockExchange
   ```

2. **Run the application**
   ```bash
   dotnet run --project src/WizardStockExchange.csproj --urls "http://localhost:5000"
   ```

3. **Open in browser**

   Navigate to `http://localhost:5000`

## Screenshots

Add your screenshots to `docs/screenshots/` using these filenames so they appear below:

| Page | Filename |
|------|----------|
| Market (dashboard) | `market.png` |
| Portfolio | `portfolio.png` |
| Watchlist | `watchlist.png` |
| History | `history.png` |
| Bank | `bank.png` |
| About | `about.png` |

**Market (dashboard)**

![Market](docs/screenshots/market.png)

**Portfolio**

![Portfolio](docs/screenshots/portfolio.png)

**Watchlist**

![Watchlist](docs/screenshots/watchlist.png)

**History**

![History](docs/screenshots/history.png)

**Bank**

![Bank](docs/screenshots/bank.png)

**About**

![About](docs/screenshots/about.png)

## Project Structure

```
Wizard_Stock_Market/
├── src/
│   ├── Components/
│   │   ├── Layout/         # Main layout, navbar, side menu
│   │   ├── Pages/          # Market, Portfolio, Watchlist, History, Bank, About
│   │   └── Shared/         # Trade modal and shared components
│   ├── Models/             # Stock, User, Transaction, Bank
│   ├── Services/           # GameState, TradingService, StockDataService, LoanService
│   ├── wwwroot/            # CSS, favicon, static assets
│   └── WizardStockExchange.csproj
└── README.md
```

## How to Play

1. **Start with £10,000** - Your initial balance to begin trading
2. **Browse the Market** - Click on any stock to view details and trade
3. **Buy Low, Sell High** - The classic trading strategy
4. **Build Your Score** - Your score increases based on profitable trades
5. **Take Loans** - Once your score reaches 100, you can apply for bank loans
6. **Use the Watchlist** - Track stocks you're interested in without buying

## Technologies

- **Blazor Server** - Interactive UI with real-time updates
- **C# / .NET 7** - Cross-platform runtime
- **CSS3** - Custom dark theme with animations

## Original Project

This was originally a school project built with:
- Visual Basic .NET
- Windows Forms
- Microsoft Excel Interop (for stock data)

The new version replaces all Windows-specific dependencies with cross-platform alternatives.

## License

MIT License - Feel free to use and modify.

---

By [Roland Olajide](https://github.com/Roland-02)
