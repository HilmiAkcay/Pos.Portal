namespace CloudDomain.Domain
{
    public class ReleaseNumber:DefaultEntity
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<Shop> Shops { get; set; }
        public List<ShopGroup> ShopGroups { get; set; }
        public List<ReleaseDetail> ReleaseDetails { get; set; }
    }
}
