using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain.Entities
{
    /// <summary>
    /// An entity can implement this interface if <see cref="MTime"/> of this entity must be stored.
    /// <see cref="MTime"/> is automatically set when updating <see cref="Entity"/>.
    /// </summary>
    public interface IHasModificationTime
    {
        /// <summary>
        /// The last modified time for this entity.
        /// </summary>
        DateTime? MTime { get; set; }
    }
}
