using Demo.Builder.Builders.Contracts;
using Demo.Entities;

namespace Demo.Builder.Builders
{
    public class CheckingAccountBuilder : BaseAccountBuilder<CheckingAccount>, ICheckingAccountBuilder
    {
        public void SetMonthlyFee(decimal monthlyFee) => this._account.SetMonthlyFee(monthlyFee);

        public void SetMonthlyFreeTransactions(int monthlyFreeTransactions) => this._account.SetMonthlyFreeTransactions(monthlyFreeTransactions);

        public void SetOverdraftLimit(decimal overdraftLimit) => this._account.SetOverdraftLimit(overdraftLimit);

        public void SetTransactionFee(decimal transactionFee) => this._account.SetTransactionFee(transactionFee);
    }
}