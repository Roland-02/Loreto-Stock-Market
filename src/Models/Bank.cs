namespace WizardStockExchange.Models;

public class Bank
{
    public string Name { get; }
    public int MaxLoan { get; }
    // Base annual percentage rate (e.g. 0.08 = 8% APR).
    public decimal BaseApr { get; }
    public decimal LoanAmount { get; set; }
    public decimal MonthlyPayment { get; set; }

    public Bank(string name, int maxLoan, decimal baseApr)
    {
        Name = name;
        MaxLoan = maxLoan;
        BaseApr = baseApr;
        LoanAmount = 0;
        MonthlyPayment = 0;
    }

    // Effective APR from score; higher score lowers rate, clamped to 0.5x–2x base.
    public decimal CalculateEffectiveApr(int score)
    {
        if (score <= 0) return BaseApr * 2m;
        var modifier = 1m + (100m - score) / 100m;
        if (modifier < 0.5m) modifier = 0.5m;
        if (modifier > 2m) modifier = 2m;
        return Math.Round(BaseApr * modifier, 4);
    }

    // Amortization: P * r * (1+r)^n / ((1+r)^n - 1).
    public decimal CalculateMonthlyPayment(int principal, int months, decimal effectiveApr)
    {
        if (principal <= 0 || months <= 0) return 0;
        var r = effectiveApr / 12m;
        if (r <= 0) return (decimal)principal / months;
        var n = (double)months;
        var factor = (double)(1 + r);
        var pow = Math.Pow(factor, n);
        var monthly = (double)principal * (double)r * pow / (pow - 1);
        return Math.Round((decimal)monthly, 2);
    }

    // Total repayable (principal + interest) over the term.
    public decimal GetTotalRepayable(int principal, int months, decimal effectiveApr)
    {
        var monthly = CalculateMonthlyPayment(principal, months, effectiveApr);
        return monthly * months;
    }

    public bool EvaluateLoanApplication(int score, int amount, decimal monthlyPayment, decimal userBalance)
    {
        if (userBalance <= 0) return false;
        var maxMonthlyVsBalance = 0.35m;
        if (monthlyPayment > userBalance * maxMonthlyVsBalance) return false;
        var maxLoanToBalance = 3m;
        if (amount > userBalance * maxLoanToBalance) return false;
        return true;
    }
}
