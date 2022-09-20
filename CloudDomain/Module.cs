using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudDomain
{
    public class Module
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public bool IsPack { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
        public List<Page> Pages { get; set; }
    }
}
