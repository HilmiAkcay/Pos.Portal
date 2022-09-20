namespace CloudDomain
{
    public class ShopSetting
    {
        public long ID { get; set; }

        public long ShopId { get; set; }
        public DateTime LicenseExpireDate { get; set; }
        public long EmailSettingId { get; set; }
        public int ConcurrentBoCount { get; set; }
        public int ConcurrentFoCount { get; set; }
        public string DatabaseName { get; set; }
        public long DefaultReportId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
