namespace CloudDomain.Domain
{
    public class ReleaseDetail:DefaultEntity
    {
        public long ReleaseNumberId { get; set; }
        public int Type { get; set; }
        public long ApplicationId { get; set; }
        public long PageId { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
    }
}
