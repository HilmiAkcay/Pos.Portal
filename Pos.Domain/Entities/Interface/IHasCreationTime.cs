﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Domain.Entities
{
    /// <summary>
    /// An entity can implement this interface if <see cref="CTime"/> of this entity must be stored.
    /// <see cref="CreationTime"/> is automatically set when saving <see cref="Entity"/> to database.
    /// </summary>
    public interface IHasCreationTime
    {
        /// <summary>
        /// Creation time of this entity.
        /// </summary>
        DateTime CTime { get; set; }
    }
}
