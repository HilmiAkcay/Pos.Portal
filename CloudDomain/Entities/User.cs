namespace CloudDomain.Domain
{
    public class User
    {
        public long ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long ShopId { get; set; }
        public bool RememberMe { get; set; }
        public bool IsValidated { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<Role> Roles { get; set; }
    }
}