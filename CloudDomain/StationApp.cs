using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudDomain
{
    public class StationApp
    {
        public long ID { get; set; }
        public long ApplicationId { get; set; }
        public long StationId { get; set; }
        public int StartMode { get; set; }
        public bool StartAfterInstall { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public Guid UID { get; set; } = Guid.NewGuid();
    }
}
