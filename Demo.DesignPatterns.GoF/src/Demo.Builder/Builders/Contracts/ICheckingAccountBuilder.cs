namespace Demo.Builder.Builders.Contracts
{
    public interface ICheckingAccountBuilder
    {
        void SetOverdraftLimit(decimal overdraftLimit);
        void SetMonthlyFreeTransactions(int monthlyFreeTransactions);
        void SetMonthlyFee(decimal monthlyFee);
        void SetTransactionFee(decimal transactionFee);
    }
}
