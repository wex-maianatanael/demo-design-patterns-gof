using Demo.Entities.Enums;

namespace Demo.Builder.DTOs
{
    public class InvestmentAccountDto
    {
        #region ' Base properties '

        public int Number { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset OpenedDate { get; set; }
        public bool IsActive { get; set; }

        #endregion ' Base properties '

        public InvestmentStrategyType Strategy { get; set; }
        public ToleranceRiskType ToleranceRisk { get; set; }
        public decimal Dividends { get; set; }
        public decimal ManagementFee { get; set; }
        public decimal InvestmentReturn { get; set; }
        public decimal CapitalGains { get; set; }
    }
}
