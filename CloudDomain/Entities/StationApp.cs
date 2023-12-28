namespace CloudDomain.Domain
{
    public class StationApp:DefaultEntity
    {
        public long ApplicationId { get; set; }
        public long StationId { get; set; }
        public int StartMode { get; set; }
        public bool StartAfterInstall { get; set; }
    }
}
