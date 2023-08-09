using Demo.Builder.Builders.Contracts;
using Demo.Builder.Directors.Contracts;
using Demo.Entities;

namespace Demo.Builder.Directors
{
    public class AccountDirector<TEntity> : IAccountDirector<TEntity>
        where TEntity : BaseAccount
    {
        private readonly ICheckingAccountBuilder _checkingAccountBuilder;
        private readonly IInvestmentAccountBuilder _investmentAccountBuilder;
        private readonly ISavingsAccountBuilder _savingsAccountBuilder;
        private readonly IStudentAccountBuilder _studentAccountBuilder;

        public AccountDirector(ICheckingAccountBuilder checkingAccountBuilder, 
                               IInvestmentAccountBuilder investmentAccountBuilder, 
                               ISavingsAccountBuilder savingsAccountBuilder, 
                               IStudentAccountBuilder studentAccountBuilder)
        {
            _checkingAccountBuilder = checkingAccountBuilder;
            _investmentAccountBuilder = investmentAccountBuilder;
            _savingsAccountBuilder = savingsAccountBuilder;
            _studentAccountBuilder = studentAccountBuilder;
        }

        public CheckingAccount BuildCheckingAccount(TEntity account) // todo: when receiving a dto or viewmodel here, we could use automapper to handle the obj.
        {
            if (account is CheckingAccount checkingAccount) 
            {
                _checkingAccountBuilder.Reset();
                _checkingAccountBuilder.SetAccountNumber(checkingAccount.Number);
                _checkingAccountBuilder.SetAccountBalance(checkingAccount.Balance);
                _checkingAccountBuilder.SetOpenDate(checkingAccount.OpenedDate);
                _checkingAccountBuilder.SetIsActive(checkingAccount.IsActive);
                _checkingAccountBuilder.SetMonthlyFee(checkingAccount.MonthlyFee);
                _checkingAccountBuilder.SetMonthlyFreeTransactions(checkingAccount.MonthlyFreeTransactions);
                _checkingAccountBuilder.SetOverdraftLimit(checkingAccount.OverdraftLimit);
                _checkingAccountBuilder.SetTransactionFee(checkingAccount.TransactionFee);

                return _checkingAccountBuilder.GetAccount();
            }

            throw new InvalidOperationException($"The current account ({account.GetType().Name}) doesn't support CheckingAccount construction.");
        }

        public void BuildInvestmentAccount(TEntity account)
        {
            throw new NotImplementedException();
        }

        public void BuildSavingsAccount(TEntity account)
        {
            throw new NotImplementedException();
        }

        public void BuildStudentAccount(TEntity account)
        {
            throw new NotImplementedException();
        }
    }
}
