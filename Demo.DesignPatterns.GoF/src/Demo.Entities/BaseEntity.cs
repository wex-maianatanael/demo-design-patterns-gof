namespace Demo.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
        public void SetID(Guid id)
        {
            ID = id;
        }
    }
}
