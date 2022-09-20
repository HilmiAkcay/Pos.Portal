namespace CloudDomain
{
    public class Application
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string ExeName { get; set; }
        public int StartMode { get; set; }
        public bool StartAfterInstall { get; set; }
        public bool IsAssignable { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<StationApp> StationApps { get; set; }
        public List<ConnectedApp> ConnectedApps { get; set; }
        public List<ReleaseDetail> ReleaseDetails { get; set; }
    }
}
