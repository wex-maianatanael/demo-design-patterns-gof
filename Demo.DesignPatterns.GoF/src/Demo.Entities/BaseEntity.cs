namespace Demo.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
    }
}
