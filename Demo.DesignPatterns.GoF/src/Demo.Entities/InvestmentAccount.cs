using Demo.Entities.Enums;

namespace Demo.Entities
{
    public class InvestmentAccount : BaseAccount
    {
        public InvestmentStrategyType Strategy { get; set; }
        public ToleranceRiskType ToleranceRisk { get; set; }
        public decimal Dividends { get; set; }
        public decimal ManagementFee { get; set; }
        public decimal InvestmentReturn { get; set; }
        public decimal CapitalGains { get; set; }
    }
}
