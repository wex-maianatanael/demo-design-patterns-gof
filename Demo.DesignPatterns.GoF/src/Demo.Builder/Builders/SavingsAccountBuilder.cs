using Demo.Builder.Builders.Contracts;
using Demo.Entities;
using Demo.Entities.Enums;

namespace Demo.Builder.Builders
{
    public class SavingsAccountBuilder : BaseAccountBuilder<SavingsAccount>, ISavingsAccountBuilder
    {
        public void SetCompoundingFrequency(CompoundingFrequencyType compoundingFrequency)
        {
            this._account.CompoundingFrequency = compoundingFrequency;
        }

        public void SetInterestRate(decimal interestRate)
        {
            this._account.InterestRate = interestRate;
        }

        public void SetMinimumBalance(decimal minimumBalance)
        {
            this._account.Balance = minimumBalance;
        }

        public void SetPenaltyFee(decimal penaltyFee)
        {
            this._account.PenaltyFee = penaltyFee;
        }

        public void SetWithdrawLimit(int withdrawLimit)
        {
            this._account.WithdrawLimit = withdrawLimit;
        }
    }
}
