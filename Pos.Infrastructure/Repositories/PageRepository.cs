using CloudDomain.Domain;
using Pos.Domain.Interface;
using Pos.EfCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Infrastructure.Repositories
{
    public class PageRepository : Repository<Page>, IPageRepository
    {
        public PageRepository(CloudContext context) : base(context)
        {

        }
    }
}
