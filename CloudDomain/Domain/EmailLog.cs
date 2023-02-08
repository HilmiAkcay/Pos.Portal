namespace CloudDomain
{
    public class EmailLog
    {
        public long ID { get; set; }
        public long ShopId { get; set; }
        public string Description { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentUri { get; set; }
        public bool IsSent { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
