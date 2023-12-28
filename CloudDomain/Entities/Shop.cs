namespace CloudDomain.Domain
{
    public class Shop:DefaultEntity
    {
        public string Name { get; set; }
        public long ShopGroupId { get; set; }
        public List<User> Users { get; set; }
        public List<Station> Stations { get; set; }
        public List<Report> Reports { get; set; }
        public List<ReleaseNumber> ReleaseNumbers { get; set; }
        public List<EmailLog> EmailLogs { get; set; }
    }
}
