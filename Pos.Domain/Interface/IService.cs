using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain.Interface
{
    public interface IService<Tread, Tupdate> where Tread : class where Tupdate : class
    {
        Task<Tread> GetByIdAsync(long id);
        Task<IAsyncEnumerable<Tread>> GetAllAsync();
        Task<Tread> AddAsync(Tupdate entity);
        Task UpdateAsync(Tupdate entity);
        Task<bool> DeleteAsync(long id);
    }
}
