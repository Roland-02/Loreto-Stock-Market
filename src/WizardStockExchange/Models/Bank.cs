namespace WizardStockExchange.Models;

public class Bank
{
    public string Name { get; }
    public int MaxLoan { get; }
    public double InterestConstant { get; }
    public double AcceptanceConstant { get; }
    public decimal LoanAmount { get; set; }
    public decimal MonthlyPayment { get; set; }

    public Bank(string name, int maxLoan, double interestConstant, double acceptanceConstant)
    {
        Name = name;
        MaxLoan = maxLoan;
        InterestConstant = interestConstant;
        AcceptanceConstant = acceptanceConstant;
        LoanAmount = 0;
        MonthlyPayment = 0;
    }

    public double CalculateInterest(int amount, int score)
    {
        if (amount == 0 || score == 0) return 0;
        return Math.Round(InterestConstant / (amount * score), 4);
    }

    public bool EvaluateLoanApplication(int score, int amount, decimal monthlyPayment, decimal userBalance)
    {
        if (userBalance == 0 || AcceptanceConstant == 0) return false;
        var scoreRatio = (double)score / AcceptanceConstant;
        var amountRatio = (double)amount / (double)userBalance;
        var canAfford = monthlyPayment * 2 < userBalance;
        return scoreRatio > amountRatio && canAfford;
    }
}
