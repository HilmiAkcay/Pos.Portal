namespace CloudDomain.Domain
{
    public class Station
    {
        public long ID { get; set; }
        public string HostName { get; set; }
        public string MacAddress { get; set; }
        public long ShopId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<StationApp> StationApps { get; set; }
        public List<ConnectedApp> ConnectedApps { get; set; }
        public List<InstallLog> InstallLogs { get; set; }
    }
}
