namespace CloudDomain.Domain
{
    public class Station:DefaultEntity
    {
        public string HostName { get; set; }
        public string MacAddress { get; set; }
        public long ShopId { get; set; }
        public List<StationApp> StationApps { get; set; }
        public List<ConnectedApp> ConnectedApps { get; set; }
        public List<InstallLog> InstallLogs { get; set; }
    }
}
