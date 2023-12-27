namespace CloudDomain.Domain
{
    public class ReleaseDetail
    {
        public long ID { get; set; }
        public long ReleaseNumberId { get; set; }
        public int Type { get; set; }
        public long ApplicationId { get; set; }
        public long PageId { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
