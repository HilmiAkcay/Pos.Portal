using System.ComponentModel.DataAnnotations.Schema;

namespace Pos.Domain.Entities
{
    public class DefaultEntity : AuditedEntity, ISoftDelete
    {
        public bool IsDeleted { get; set; }
    }
}
