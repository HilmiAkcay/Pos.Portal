namespace CloudDomain.Domain
{
    public class Role:DefaultEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<User> Users { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
