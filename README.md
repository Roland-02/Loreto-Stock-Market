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

**Market**
<img width="2880" height="1558" alt="Screenshot 2026-01-25 at 12 00 03" src="https://github.com/user-attachments/assets/62c294bb-1712-4ed1-bfd4-e5dc808a7289" />
<img width="2880" height="1558" alt="Screenshot 2026-01-25 at 12 00 41" src="https://github.com/user-attachments/assets/204c29da-b458-4030-9d73-75045da1f26b" />


**Portfolio**
<img width="2880" height="1800" alt="Screenshot 2026-01-25 at 12 28 29" src="https://github.com/user-attachments/assets/b5bd3d0d-c1a1-4b82-b486-69daf0b03455" />


**Watchlist**
<img width="2880" height="1558" alt="Screenshot 2026-01-25 at 12 01 32" src="https://github.com/user-attachments/assets/af6709a7-c0f8-4a0d-a771-dd239f14e5a2" />


**History**
<img width="2880" height="1556" alt="Screenshot 2026-01-25 at 12 18 48" src="https://github.com/user-attachments/assets/bca1e205-0253-4f72-83a5-a1b1b056fdff" />


**Bank**
<img width="2880" height="1552" alt="Screenshot 2026-01-25 at 13 21 32" src="https://github.com/user-attachments/assets/9e28e84b-21d1-435e-887a-2f5c89d284cd" />


**About**
<img width="2880" height="1552" alt="Screenshot 2026-01-25 at 12 55 17" src="https://github.com/user-attachments/assets/6d73fe89-f511-4e49-b67e-2265228696c6" />




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

By [Roland Olajide](https://github.com/Roland-02)
