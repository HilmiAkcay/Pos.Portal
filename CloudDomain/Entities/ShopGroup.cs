namespace CloudDomain.Domain
{
    public class ShopGroup
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<Shop> Shops { get; set; }
        public List<ReleaseNumber> ReleaseNumbers { get; set; }
    }
}
