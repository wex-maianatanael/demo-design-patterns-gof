namespace Demo.Entities
{
    public abstract class BaseAccount : BaseEntity
    {
        public int Number { get; private set; }
        public decimal Balance { get; private set; }
        public DateTimeOffset OpenedDate { get; private set; }
        public bool IsActive { get; private set; }

        public void SetNumber(int number)
        {
            this.Number = number;
        }

        public void SetBalance(decimal balance)
        {
            this.Balance = balance;
        }

        public void SetOpenedDate(DateTimeOffset openedDate)
        {
            this.OpenedDate = openedDate;
        }

        public void SetIsActive(bool isActive)
        {
            this.IsActive = isActive;
        }
    }
}