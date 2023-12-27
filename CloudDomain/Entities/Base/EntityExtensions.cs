﻿

using JetBrains.Annotations;

namespace Pos.Domain.Entities
{
    /// <summary>
    /// Some useful extension methods for Entities.
    /// </summary>
    public static class EntityExtensions
    {
        /// <summary>
        /// Check if this Entity is null of marked as deleted.
        /// </summary>
        [ContractAnnotation("null => true")]
        public static bool IsNullOrDeleted(this ISoftDelete entity)
        {
            return entity == null || entity.IsDeleted;
        }

        /// <summary>
        /// Undeletes this entity by setting <see cref="ISoftDelete.IsDeleted"/> to false and
        /// <see cref="IDeletionAudited"/> properties to null.
        /// </summary>
        public static void UnDelete(this ISoftDelete entity)
        {
            entity.IsDeleted = false;
            if (entity is IDeletionAudited)
            {
                var deletionAuditedEntity = (IDeletionAudited)entity;
                deletionAuditedEntity.DeletionTime = null;
                deletionAuditedEntity.DeleterUserId = null;
            }
        }
    }
}
