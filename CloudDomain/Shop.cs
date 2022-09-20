namespace CloudDomain
{
    public class Shop
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long ShopGroupId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<User> Users { get; set; }
        public List<Station> Stations { get; set; }
        public List<Report> Reports { get; set; }
        public List<ReleaseNumber> ReleaseNumbers { get; set; }
        public List<EmailLog> EmailLogs { get; set; }
    }
}
