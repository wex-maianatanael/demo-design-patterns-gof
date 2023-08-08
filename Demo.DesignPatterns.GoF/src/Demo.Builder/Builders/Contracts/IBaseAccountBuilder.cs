using Demo.Entities;

namespace Demo.Builder.Builders.Contracts
{
    public interface IBaseAccountBuilder<TEntity> 
        where TEntity : BaseAccount
    {
        void Reset();
        void SetAccountNumber(int accountNumber);
        void SetAccountBalance(decimal accountBalance);
        void SetOpenDate(DateTimeOffset accountOpenDate);
        void SetIsActive(bool isActive);
        TEntity GetAccount();
    }
}
