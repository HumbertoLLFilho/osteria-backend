namespace Osteria.Backend.Core.Models.Base
{
    public class BaseEntity
    {
        public Guid ID { get; set; }

        public bool IsDeleted { get; private set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
        public DateTime? DeletedOn { get; private set; }

        public void Delete()
        {
            IsDeleted = true;
            DeletedOn = DateTime.UtcNow;
        }

        public virtual void Update()
        {
            UpdatedOn = DateTime.UtcNow;
        }
    }
}
