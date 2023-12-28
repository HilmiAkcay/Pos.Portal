namespace CloudDomain.Domain
{
    public class Report:DefaultEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Uri { get; set; }
        public string IconUri { get; set; }
        public List<Shop> Shops { get; set; }
        public List<ShopSetting> ShopSettings { get; set; }
    }
}
