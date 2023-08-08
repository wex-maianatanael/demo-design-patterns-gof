using Demo.Entities.Enums;

namespace Demo.Entities
{
    public class SavingsAccount : BaseAccount
    {
        public int WithdrawLimit { get; set; }
        public decimal PenaltyFee { get; set; }
        public CompoundingFrequencyType CompoundingFrequency { get; set; }
        public decimal MinimumBalance { get; set; }
        public decimal InterestRate { get; set; }
    }
}
