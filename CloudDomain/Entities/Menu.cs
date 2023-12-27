namespace CloudDomain.Domain
{
    public class Menu
    {
        public long ID { get; set; }
        public long ParentID { get; set; }
        public string Text { get; set; }
        public string Href { get; set; }
        public string IconUri { get; set; }
        public string Tag { get; set; }
        public int DisplayOrder { get; set; }
        public bool Expanded { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<Role> Roles { get; set; }
    }
}
