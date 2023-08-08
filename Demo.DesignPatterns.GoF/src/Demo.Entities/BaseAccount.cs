namespace Demo.Entities
{
    public abstract class BaseAccount : BaseEntity
    {
        public int Number { get; set; }
        public decimal Balance { get; set; }
        public DateTimeOffset OpenedDate { get; set; }
        public bool IsActive { get; set; }
    }
}