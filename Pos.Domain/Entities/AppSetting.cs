namespace CloudDomain.Domain
{
    public class AppSetting : DefaultEntity
    {
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Value { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }
        public int? PreviousID { get; set; }
        public Guid? SharedLineId { get; set; }


    }
}
