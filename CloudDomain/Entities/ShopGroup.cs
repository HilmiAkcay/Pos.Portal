namespace CloudDomain.Domain
{
    public class ShopGroup:DefaultEntity
    {
        public string Name { get; set; }
        public List<Shop> Shops { get; set; }
        public List<ReleaseNumber> ReleaseNumbers { get; set; }
    }
}
