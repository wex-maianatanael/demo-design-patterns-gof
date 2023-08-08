using Demo.Builder.Builders;
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
            if (_checkingAccountBuilder is CheckingAccountBuilder checkingAccountBuilder && account is CheckingAccount checkingAccount) 
            {
                checkingAccountBuilder.Reset();
                checkingAccountBuilder.SetAccountNumber(checkingAccount.Number);
                checkingAccountBuilder.SetAccountBalance(checkingAccount.Balance);
                checkingAccountBuilder.SetOpenDate(checkingAccount.OpenedDate);
                checkingAccountBuilder.SetIsActive(checkingAccount.IsActive);
                checkingAccountBuilder.SetMonthlyFee(checkingAccount.MonthlyFee);
                checkingAccountBuilder.SetMonthlyFreeTransactions(checkingAccount.MonthlyFreeTransactions);
                checkingAccountBuilder.SetOverdraftLimit(checkingAccount.OverdraftLimit);
                checkingAccountBuilder.SetTransactionFee(checkingAccount.TransactionFee);
                return checkingAccountBuilder.GetAccount();
            }

            throw new InvalidOperationException($"The current builder ({_checkingAccountBuilder.GetType().Name}) doesn't support CheckingAccount construction.");
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
