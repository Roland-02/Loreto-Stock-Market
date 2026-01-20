# Wizard Stock Exchange

A stock exchange simulator that lets you practice trading with virtual money. Originally built as a Windows Forms VB.NET application, now modernized as a cross-platform Blazor web application.

![.NET](https://img.shields.io/badge/.NET-7.0-512BD4?style=flat-square)
![Blazor](https://img.shields.io/badge/Blazor-Server-512BD4?style=flat-square)
![Platform](https://img.shields.io/badge/Platform-Cross--Platform-green?style=flat-square)

## Features

- 📊 **Live Market** - View 50 stocks from the London Stock Exchange (simulated) with real-time price updates
- 💼 **Portfolio Management** - Buy and sell stocks, track your investments
- 👁️ **Watchlist** - Keep an eye on stocks you're interested in
- 📋 **Transaction History** - View all your past trades
- 🏦 **Bank Loans** - Borrow money from various banks to expand your portfolio
- 📈 **Price Charts** - Visual price history for each stock
- 🎯 **Score System** - Earn points based on your trading performance

## Requirements

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) or later
- Works on macOS, Windows, and Linux

## Quick Start

1. **Clone the repository**
   ```bash
   git clone https://github.com/Roland-02/WizardStockExchange.git
   cd Loreto_Stock_Market
   ```

2. **Run the application**
   ```bash
   cd src/WizardStockExchange
   dotnet run --urls "http://localhost:5000"
   ```

3. **Open in browser**
   
   Navigate to `http://localhost:5000`

## Project Structure

```
Loreto_Stock_Market/
├── src/
│   └── WizardStockExchange/
│       ├── Components/
│       │   ├── Layout/         # Main layout
│       │   ├── Pages/          # Page components
│       │   └── Shared/         # Shared components
│       ├── Models/             # Data models
│       ├── Services/           # Business logic
│       └── wwwroot/            # Static assets
├── legacy/                     # Original VB.NET Windows Forms code
└── WizardStockExchange.sln     # Solution file
```

## How to Play

1. **Start with £10,000** - Your initial balance to begin trading
2. **Browse the Market** - Click on any stock to view details and trade
3. **Buy Low, Sell High** - The classic trading strategy
4. **Build Your Score** - Your score increases based on profitable trades
5. **Take Loans** - Once your score reaches 100, you can apply for bank loans
6. **Use the Watchlist** - Track stocks you're interested in without buying

## Technologies

- **Blazor Server** - For interactive UI with real-time updates
- **C# / .NET 7** - Modern, cross-platform runtime
- **CSS3** - Custom dark theme with animations

## Original Project

This was originally a school project built with:
- Visual Basic .NET
- Windows Forms
- Microsoft Excel Interop (for stock data)

The new version replaces all Windows-specific dependencies with cross-platform alternatives.

## License

MIT License - Feel free to use and modify!

---

Made with ❤️ by Roland
