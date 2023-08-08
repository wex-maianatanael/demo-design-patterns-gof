using Demo.Entities.Enums;

namespace Demo.Builder.Builders.Contracts
{
    public interface ISavingsAccountBuilder
    {
        void SetWithdrawLimit(int withdrawLimit);
        void SetPenaltyFee(decimal penaltyFee);
        void SetCompoundingFrequency(CompoundingFrequencyType compoundingFrequency);
        void SetMinimumBalance(decimal minimumBalance);
        void SetInterestRate(decimal interestRate);
    }
}
