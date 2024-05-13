namespace CloudDomain.Domain
{
    public class Page:DefaultEntity
    {
        public int PurePosId { get; set; }
        public string Name { get; set; }
        public List<Module> Modules { get; set; }
        public List<ReleaseDetail> ReleaseDetails { get; set; }


        public Page(int id, int purePosId,string name)
        {
            ID = id;
            PurePosId = purePosId;
            Name = name;
        }

        public Page()
        {
            
        }

    }
}
