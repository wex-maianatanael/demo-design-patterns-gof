using Demo.Entities;

namespace Demo.Builder.Builders.Contracts
{
    public interface ICheckingAccountBuilder : IBaseAccountBuilder<CheckingAccount>
    {
        void SetOverdraftLimit(decimal overdraftLimit);

        void SetMonthlyFreeTransactions(int monthlyFreeTransactions);

        void SetMonthlyFee(decimal monthlyFee);

        void SetTransactionFee(decimal transactionFee);
    }
}