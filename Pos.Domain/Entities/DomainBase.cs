namespace CloudDomain.Domain
{
    public class DomainBase
    {
        public long ID { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime ModifiedDate { get; set; } = DateTime.Now.ToUniversalTime();
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
