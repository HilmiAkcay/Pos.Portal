namespace CloudDomain.Domain
{
    public class User:DefaultEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public long ShopId { get; set; }
        public bool RememberMe { get; set; }
        public bool IsValidated { get; set; }
        public List<Role> Roles { get; set; }
    }
}