using CloudDomain.Domain;

namespace CloudDomain
{
    public class Page
    {
        public long ID { get; set; }
        public int PurePosId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<Module> Modules { get; set; }
        public List<ReleaseDetail> ReleaseDetails { get; set; }

    }
}
