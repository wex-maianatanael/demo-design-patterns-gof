using Demo.Builder.Builders.Contracts;
using Demo.Entities;

namespace Demo.Builder.Builders
{
    public class BaseAccountBuilder<TEntity> : IBaseAccountBuilder<TEntity>
        where TEntity : BaseAccount, new()
    {
        protected TEntity _account = new();

        public void Reset()
        {
            this._account = new TEntity();
        }

        public TEntity GetAccount()
        {
            return this._account;
        }

        public void SetAccountBalance(decimal accountBalance)
        {
            this._account.Balance = accountBalance;
        }

        public void SetAccountNumber(int accountNumber)
        {
            this._account.Number = accountNumber;
        }

        public void SetIsActive(bool isActive)
        {
            this._account.IsActive = isActive;
        }

        public void SetOpenDate(DateTimeOffset accountOpenDate)
        {
            this._account.OpenedDate = accountOpenDate;
        }
    }
}
