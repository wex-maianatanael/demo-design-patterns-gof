using Demo.Builder.Builders.Contracts;
using Demo.Entities;
using Demo.Entities.Enums;

namespace Demo.Builder.Builders
{
    public class SavingsAccountBuilder : BaseAccountBuilder<SavingsAccount>, ISavingsAccountBuilder
    {
        public void SetCompoundingFrequency(CompoundingFrequencyType compoundingFrequency) => this._account.SetCompoundingFrequency(compoundingFrequency);

        public void SetInterestRate(decimal interestRate) => this._account.SetInterestRate(interestRate);

        public void SetMinimumBalance(decimal minimumBalance) => this._account.SetBalance(minimumBalance);

        public void SetPenaltyFee(decimal penaltyFee) => this._account.SetPenaltyFee(penaltyFee);

        public void SetWithdrawLimit(int withdrawLimit) => this._account.SetWithdrawLimit(withdrawLimit);
    }
}