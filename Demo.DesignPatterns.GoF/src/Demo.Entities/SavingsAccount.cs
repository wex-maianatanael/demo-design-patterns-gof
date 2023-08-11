using Demo.Entities.Enums;

namespace Demo.Entities
{
    public class SavingsAccount : BaseAccount
    {
        public int WithdrawLimit { get; private set; }
        public decimal PenaltyFee { get; private set; }
        public CompoundingFrequencyType CompoundingFrequency { get; private set; }
        public decimal MinimumBalance { get; private set; }
        public decimal InterestRate { get; private set; }

        public void SetWithdrawLimit(int value)
        {
            this.WithdrawLimit = value;
        }

        public void SetPenaltyFee(decimal value)
        {
            this.PenaltyFee = value;
        }

        public void SetCompoundingFrequency(CompoundingFrequencyType value)
        {
            this.CompoundingFrequency = value;
        }

        public void SetMinimumBalance(decimal value)
        {
            this.MinimumBalance = value;
        }

        public void SetInterestRate(decimal value)
        {
            this.InterestRate = value;
        }

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Account Number: {Number}\n" +
                $"Balance: {Balance}\n" +
                $"Open Date: {OpenedDate}\n" +
                $"Is Active: {IsActive}\n" +
                $"Withdraw Limit: {WithdrawLimit}\n" +
                $"Penalty Fee: {PenaltyFee}\n" +
                $"Compounding Frequency: {CompoundingFrequency}\n" +
                $"Minimum Balance: {MinimumBalance}\n" +
                $"Interest Rate: {InterestRate}\n\n";
        }
    }
}