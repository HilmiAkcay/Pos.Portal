namespace CloudDomain.Domain
{
    public class Module:DefaultEntity
    {
        public string Name { get; set; }
        public bool IsPack { get; set; }
        public List<Page> Pages { get; set; }
    }
}
