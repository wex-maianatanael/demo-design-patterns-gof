using Demo.Entities;

namespace Demo.Builder.Directors.Contracts
{
    public interface IAccountDirector<in TDto> // contravariant
        where TDto : class
    {
        CheckingAccount BuildCheckingAccount(TDto account);
        InvestmentAccount BuildInvestmentAccount(TDto account);
        SavingsAccount BuildSavingsAccount(TDto account);
        StudentAccount BuildStudentAccount(TDto account);
    }
}
