namespace CloudDomain
{
    public class InstallLog
    {
        public long ID { get; set; }
        public long StationId { get; set; }
        public long ApplicationId { get; set; }
        public int StartMode { get; set; }
        public int Status { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
