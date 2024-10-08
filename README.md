# Loreto Stock Market

**LSM** is a virtual stock trading simulation that allows users to buy and sell shares of real-life companies listed on the London Stock Exchange using virtual currency. The simulator includes a virtual banking system with customizable loan options, making it an engaging learning tool for both finance students and professionals.

## Key Features:

- **Real-Time & Simulated Stock Prices**: The program fetches real-life stock prices from the London Stock Exchange website, but with additional random fluctuations to allow trading outside market hours.
- **Stock Value Prediction Tool**: Optionally enabled, this tool analyzes price trends to predict stock value changes, ideal for users who want assistance in making investment decisions.
- **Virtual Banking System**: Users can apply for loans and manage savings or current accounts with varying interest rates, acceptance requirements, and loan limits depending on the bank.
- **Interactive Graphs**: Real-time graphs track stock prices over time, providing a visual representation of stock trends. Graphs are updated automatically to display ongoing changes.
- **Self-Regulating Prices**: The stock values vary with multiple factors, including external stock movements and random adjustments to simulate market conditions.
- **Loan Default Mechanism**: Users can default on loans if they fail to meet repayment schedules, mimicking real-world consequences like losing assets.
- **Simple GUI for Seamless Interaction**: The intuitive user interface includes stock tables with price trends, bank options, and visual stock graphs, making it accessible for beginners and finance experts alike.

## How to Run:

1. Open the solution file `StockExchangeV6.sln` in **Visual Studio Community 2022**.
2. Run the program on **Windows**.
3. Ensure **Excel 2016** is installed for graph generation and data tracking.

## Technology Stack & Skills Used:

- **Visual Basic.NET**: Backend logic for stock price manipulation, bank features, loan calculations, and user interactions.
- **Excel Integration**: For generating and displaying live price trend graphs.
- **GUI Development**: Designed a clean and user-friendly interface for seamless navigation and stock management.
- **Algorithm Design**: Implemented stock value prediction, interest calculations, loan approval/rejection, and a system for managing stock price fluctuations.

## Detailed Features:

### Stock Value Prediction Tool:
- Designed for finance students to learn about trends, with the option to disable it for professionals.
- Analyzes stock price graphs and predicts whether prices will rise or fall based on trend gradients.

### Virtual Banking & Loan System:
- Different banks offer varying interest rates and loan conditions.
- Loans are accepted or rejected based on the user's credit score (LTM score), bank-specific factors, and the loan amount.
- Repayments are deducted at regular intervals, and users can choose a loan repayment term.
- If users default on loans, all assets are seized, mimicking real-life bank practices.

### Dynamic Stock Prices:
- Stock prices are self-regulating and vary based on the performance of other stocks and random factors to ensure market unpredictability.
- Predictive accuracy varies, making the simulation more realistic and challenging.

### Graphical Representation:
- Users can view historical price trends for each stock through dynamic line graphs, which automatically update as stock prices change.
- The system tracks past prices and time of change to provide detailed insights into stock behavior.

### Table Display for Stock Overview:
- Stock prices and average price changes are displayed in a sortable table, allowing users to organize by price shifts, profits, or losses.
- Clear and straightforward presentation to ensure ease of use for all skill levels.

## Achievements:

- Created a versatile trading simulator suitable for both educational and professional use.
- Implemented complex banking and stock-trading mechanics with realistic financial consequences.
- Designed an intuitive GUI that enhances user experience while providing rich financial insights.
