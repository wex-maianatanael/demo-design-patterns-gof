using Demo.Entities;
using Demo.Entities.Enums;

namespace Demo.Builder.Builders.Contracts
{
    public interface IInvestmentAccountBuilder : IBaseAccountBuilder<InvestmentAccount>
    {
        void SetStrategy(InvestmentStrategyType strategy);

        void SetToleranceRisk(ToleranceRiskType toleranceRisk);

        void SetDividends(decimal dividends);

        void SetManagementFee(decimal managementFee);

        void SetInvestmentReturn(decimal investmentReturn);

        void SetCapitalGains(decimal capitalGains);
    }
}