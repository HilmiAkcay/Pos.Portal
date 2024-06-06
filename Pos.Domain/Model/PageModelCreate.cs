using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain.Model
{
    public class PageModelCreate: DefaultEntity
    {
        public int PurePosId { get; set; }
        public string Name { get; set; }
    }
}
