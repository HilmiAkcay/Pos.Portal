namespace CloudDomain.Domain
{
    public class Menu:DefaultEntity
    {
        public long ParentID { get; set; }
        public string Text { get; set; }
        public string Href { get; set; }
        public string IconUri { get; set; }
        public string Tag { get; set; }
        public int DisplayOrder { get; set; }
        public bool Expanded { get; set; }
        public List<Role> Roles { get; set; }
    }
}
