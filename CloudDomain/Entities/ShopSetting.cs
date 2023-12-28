namespace CloudDomain.Domain
{
    public class ShopSetting:DefaultEntity
    {
        public long ShopId { get; set; }
        public DateTime LicenseExpireDate { get; set; }
        public long EmailSettingId { get; set; }
        public int ConcurrentBoCount { get; set; }
        public int ConcurrentFoCount { get; set; }
        public string DatabaseName { get; set; }
        public long DefaultReportId { get; set; }
    }
}
