using Demo.Entities.Enums;

namespace Demo.Builder.DTOs
{
    public class SavingsAccountDto
    {
        #region ' Base properties '

        public int Number { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset OpenedDate { get; set; }
        public bool IsActive { get; set; }

        #endregion ' Base properties '

        public int WithdrawLimit { get; set; }
        public decimal PenaltyFee { get; set; }
        public CompoundingFrequencyType CompoundingFrequency { get; set; }
        public decimal MinimumBalance { get; set; }
        public decimal InterestRate { get; set; }
    }
}
