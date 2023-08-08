using Demo.Builder.Builders.Contracts;
using Demo.Entities;
using Demo.Entities.Enums;

namespace Demo.Builder.Builders
{
    public class InvestmentAccountBuilder : BaseAccountBuilder<InvestmentAccount>, IInvestmentAccountBuilder
    {
        public void SetCapitalGains(decimal capitalGains)
        {
            this._account.CapitalGains = capitalGains;
        }

        public void SetDividends(decimal dividends)
        {
            this._account.Dividends = dividends;
        }

        public void SetInvestmentReturn(decimal investmentReturn)
        {
            this._account.InvestmentReturn = investmentReturn;
        }

        public void SetManagementFee(decimal managementFee)
        {
            this._account.ManagementFee = managementFee;
        }

        public void SetStrategy(InvestmentStrategyType strategy)
        {
            this._account.Strategy = strategy;
        }

        public void SetToleranceRisk(ToleranceRiskType toleranceRisk)
        {
            this._account.ToleranceRisk = toleranceRisk;
        }
    }
}
