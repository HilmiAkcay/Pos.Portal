namespace CloudDomain
{
    public class ReleaseNumber
    {
        public long ID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<Shop> Shops { get; set; }
        public List<ShopGroup> ShopGroups { get; set; }
        public List<ReleaseDetail> ReleaseDetails { get; set; }
    }
}
