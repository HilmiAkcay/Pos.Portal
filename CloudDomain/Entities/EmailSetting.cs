namespace CloudDomain.Domain
{
    public class EmailSetting
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string SenderEmail { get; set; }
        public string SenderPassword { get; set; }
        public bool EnableSSL { get; set; }
        public int TimeOut { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<ShopSetting> ShopSettings { get; set; }
    }
}
