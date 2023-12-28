namespace CloudDomain.Domain
{
    public class EmailSetting:DefaultEntity
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string SenderEmail { get; set; }
        public string SenderPassword { get; set; }
        public bool EnableSSL { get; set; }
        public int TimeOut { get; set; }
        public List<ShopSetting> ShopSettings { get; set; }
    }
}
