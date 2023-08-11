using AutoMapper;
using Demo.Builder.Builders.Contracts;
using Demo.Builder.Directors.Contracts;
using Demo.Builder.DTOs;
using Demo.Entities;

namespace Demo.Builder.Directors
{
    public class AccountDirector<TDto> : IAccountDirector<TDto>
        where TDto : class
    {
        private readonly ICheckingAccountBuilder _checkingAccountBuilder;
        private readonly IInvestmentAccountBuilder _investmentAccountBuilder;
        private readonly ISavingsAccountBuilder _savingsAccountBuilder;
        private readonly IStudentAccountBuilder _studentAccountBuilder;
        private readonly IMapper _mapper;

        public AccountDirector(ICheckingAccountBuilder checkingAccountBuilder,
                               IInvestmentAccountBuilder investmentAccountBuilder,
                               ISavingsAccountBuilder savingsAccountBuilder,
                               IStudentAccountBuilder studentAccountBuilder,
                               IMapper mapper)
        {
            _checkingAccountBuilder = checkingAccountBuilder;
            _investmentAccountBuilder = investmentAccountBuilder;
            _savingsAccountBuilder = savingsAccountBuilder;
            _studentAccountBuilder = studentAccountBuilder;
            _mapper = mapper;
        }

        public CheckingAccount BuildCheckingAccount(TDto account)
        {
            if (account is not CheckingAccountDto)
                throw new InvalidOperationException($"The current account ({account.GetType().Name}) doesn't support CheckingAccount construction.");

            var checkingAccount = _mapper.Map<CheckingAccount>(account);

            _checkingAccountBuilder.Reset();

            // base account data
            _checkingAccountBuilder.SetAccountNumber(checkingAccount.Number);
            _checkingAccountBuilder.SetAccountBalance(checkingAccount.Balance);
            _checkingAccountBuilder.SetOpenDate(checkingAccount.OpenedDate);
            _checkingAccountBuilder.SetIsActive(checkingAccount.IsActive);

            // checking account data
            _checkingAccountBuilder.SetMonthlyFee(checkingAccount.MonthlyFee);
            _checkingAccountBuilder.SetMonthlyFreeTransactions(checkingAccount.MonthlyFreeTransactions);
            _checkingAccountBuilder.SetOverdraftLimit(checkingAccount.OverdraftLimit);
            _checkingAccountBuilder.SetTransactionFee(checkingAccount.TransactionFee);

            return _checkingAccountBuilder.GetAccount();
        }

        public InvestmentAccount BuildInvestmentAccount(TDto account)
        {
            if (account is not InvestmentAccountDto)
                throw new InvalidOperationException($"The current account ({account.GetType().Name}) doesn't support InvestmentAccount construction.");

            var investmentAccount = _mapper.Map<InvestmentAccount>(account);

            _investmentAccountBuilder.Reset();

            // base account data
            _investmentAccountBuilder.SetAccountNumber(investmentAccount.Number);
            _investmentAccountBuilder.SetAccountBalance(investmentAccount.Balance);
            _investmentAccountBuilder.SetOpenDate(investmentAccount.OpenedDate);
            _investmentAccountBuilder.SetIsActive(investmentAccount.IsActive);

            // investment account data
            _investmentAccountBuilder.SetStrategy(investmentAccount.Strategy);
            _investmentAccountBuilder.SetToleranceRisk(investmentAccount.ToleranceRisk);
            _investmentAccountBuilder.SetDividends(investmentAccount.Dividends);
            _investmentAccountBuilder.SetManagementFee(investmentAccount.ManagementFee);
            _investmentAccountBuilder.SetInvestmentReturn(investmentAccount.InvestmentReturn);
            _investmentAccountBuilder.SetCapitalGains(investmentAccount.CapitalGains);

            return _investmentAccountBuilder.GetAccount();
        }

        public SavingsAccount BuildSavingsAccount(TDto account)
        {
            if (account is not SavingsAccountDto)
                throw new InvalidOperationException($"The current account ({account.GetType().Name}) doesn't support SavingsAccount construction.");

            var savingsAccount = _mapper.Map<SavingsAccount>(account);

            _savingsAccountBuilder.Reset();

            // base account data
            _savingsAccountBuilder.SetAccountNumber(savingsAccount.Number);
            _savingsAccountBuilder.SetAccountBalance(savingsAccount.Balance);
            _savingsAccountBuilder.SetOpenDate(savingsAccount.OpenedDate);
            _savingsAccountBuilder.SetIsActive(savingsAccount.IsActive);

            // savings account data
            _savingsAccountBuilder.SetWithdrawLimit(savingsAccount.WithdrawLimit);
            _savingsAccountBuilder.SetPenaltyFee(savingsAccount.PenaltyFee);
            _savingsAccountBuilder.SetCompoundingFrequency(savingsAccount.CompoundingFrequency);
            _savingsAccountBuilder.SetMinimumBalance(savingsAccount.MinimumBalance);
            _savingsAccountBuilder.SetInterestRate(savingsAccount.InterestRate);

            return _savingsAccountBuilder.GetAccount();
        }

        public StudentAccount BuildStudentAccount(TDto account)
        {
            if (account is not StudentAccountDto)
                throw new InvalidOperationException($"The current account ({account.GetType().Name}) doesn't support StudentAccount construction.");

            var studentAccount = _mapper.Map<StudentAccount>(account);

            _studentAccountBuilder.Reset();

            // base account data
            _studentAccountBuilder.SetAccountNumber(studentAccount.Number);
            _studentAccountBuilder.SetAccountBalance(studentAccount.Balance);
            _studentAccountBuilder.SetOpenDate(studentAccount.OpenedDate);
            _studentAccountBuilder.SetIsActive(studentAccount.IsActive);

            // student account data
            _studentAccountBuilder.SetStudentStatus(studentAccount.StudentStatus);
            _studentAccountBuilder.SetEnrolledInstitution(studentAccount.EnrolledInstitution);
            _studentAccountBuilder.SetLowBalanceAlert(studentAccount.LowBalanceAlert);
            _studentAccountBuilder.SetHasParentalAccess(studentAccount.HasParentalAccess);
            _studentAccountBuilder.SetATMLimit(studentAccount.ATMLimit);

            return _studentAccountBuilder.GetAccount();
        }
    }
}