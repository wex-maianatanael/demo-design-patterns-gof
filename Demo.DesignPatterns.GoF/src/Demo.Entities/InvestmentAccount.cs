using Demo.Entities.Enums;

namespace Demo.Entities
{
    public class InvestmentAccount : BaseAccount
    {
        public InvestmentStrategyType Strategy { get; private set; }
        public ToleranceRiskType ToleranceRisk { get; private set; }
        public decimal Dividends { get; private set; }
        public decimal ManagementFee { get; private set; }
        public decimal InvestmentReturn { get; private set; }
        public decimal CapitalGains { get; private set; }

        public void SetStrategy(InvestmentStrategyType strategy)
        {
            this.Strategy = strategy;
        }

        public void SetToleranceRisk(ToleranceRiskType toleranceRisk)
        {
            this.ToleranceRisk = toleranceRisk;
        }

        public void SetDividends(decimal dividends)
        {
            this.Dividends = dividends;
        }

        public void SetManagementFee(decimal managementFee)
        {
            this.ManagementFee = managementFee;
        }

        public void SetInvestmentReturn(decimal investmentReturn)
        {
            this.InvestmentReturn = investmentReturn;
        }

        public void SetCapitalGains(decimal capitalGains)
        {
            this.CapitalGains = capitalGains;
        }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Account Number: {Number}\n" +
                $"Balance: {Balance}\n" +
                $"Open Date: {OpenedDate}\n" +
                $"Is Active: {IsActive}\n" +
                $"Strategy: {Strategy}\n" +
                $"Tolerance Risk: {ToleranceRisk}\n" +
                $"Dividends: {Dividends}\n" +
                $"Management Fee: {ManagementFee}\n" +
                $"Investment Return: {InvestmentReturn}\n" +
                $"Capital Gains: {CapitalGains}\n\n";
        }
    }
}