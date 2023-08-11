using Demo.Builder.Builders.Contracts;
using Demo.Entities;
using Demo.Entities.Enums;

namespace Demo.Builder.Builders
{
    public class InvestmentAccountBuilder : BaseAccountBuilder<InvestmentAccount>, IInvestmentAccountBuilder
    {
        public void SetCapitalGains(decimal capitalGains) => this._account.SetCapitalGains(capitalGains);

        public void SetDividends(decimal dividends) => this._account.SetDividends(dividends);

        public void SetInvestmentReturn(decimal investmentReturn) => this._account.SetInvestmentReturn(investmentReturn);

        public void SetManagementFee(decimal managementFee) => this._account.SetCapitalGains(managementFee);

        public void SetStrategy(InvestmentStrategyType strategy) => this._account.SetStrategy(strategy);

        public void SetToleranceRisk(ToleranceRiskType toleranceRisk) => this._account.SetToleranceRisk(toleranceRisk);
    }
}