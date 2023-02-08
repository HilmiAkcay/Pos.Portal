namespace CloudDomain.Domain
{
    public class Role
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<User> Users { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
