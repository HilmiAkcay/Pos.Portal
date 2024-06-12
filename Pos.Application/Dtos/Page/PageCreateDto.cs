using Pos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Application.Dtos.Page
{
    public class PageCreateDto : Entity
    {
        public int PurePosId { get; set; }
        public string Name { get; set; }
    }
}
