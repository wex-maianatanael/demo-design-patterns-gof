using Demo.Entities;

namespace Demo.Builder.Directors.Contracts
{
    public interface IAccountDirector<TEntity> 
        where TEntity : BaseAccount
    {
        CheckingAccount BuildCheckingAccount(TEntity account); //todo: depending on the context it could be a viewmodel class instead of a domain class.
        void BuildInvestmentAccount(TEntity account);
        void BuildSavingsAccount(TEntity account);
        void BuildStudentAccount(TEntity account);
    }
}
