namespace CloudDomain.Domain
{
    public class ConnectedApp
    {
        public long ID { get; set; }
        public long ApplicationId { get; set; }
        public long StationId { get; set; }
        public bool IsConnected { get; set; }
        public string ConnectionId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
