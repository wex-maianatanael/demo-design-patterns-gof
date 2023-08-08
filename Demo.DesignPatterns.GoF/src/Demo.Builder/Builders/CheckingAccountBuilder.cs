using Demo.Builder.Builders.Contracts;
using Demo.Entities;

namespace Demo.Builder.Builders
{
    public class CheckingAccountBuilder : BaseAccountBuilder<CheckingAccount>, ICheckingAccountBuilder
    {
        private CheckingAccount _account = new();

        public void SetMonthlyFee(decimal monthlyFee)
        {
            this._account.MonthlyFee = monthlyFee;
        }

        public void SetMonthlyFreeTransactions(int monthlyFreeTransactions)
        {
            this._account.MonthlyFreeTransactions = monthlyFreeTransactions;
        }

        public void SetOverdraftLimit(decimal overdraftLimit)
        {
            this._account.OverdraftLimit = overdraftLimit;
        }

        public void SetTransactionFee(decimal transactionFee)
        {
            this._account.TransactionFee = transactionFee;
        }
    }
}
