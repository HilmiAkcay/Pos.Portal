namespace CloudDomain.Domain
{
    public class InstallLog:DefaultEntity
    {
        public long StationId { get; set; }
        public long ApplicationId { get; set; }
        public int StartMode { get; set; }
        public int Status { get; set; }
    }
}
