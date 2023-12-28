

namespace Pos.Domain.Entities
{
    public interface IAggregateRoot : IAggregateRoot<long>, IEntity
    {

    }

    public interface IAggregateRoot<TPrimaryKey> : IEntity<TPrimaryKey>, IGeneratesDomainEvents
    {

    }

   
    public interface IGeneratesDomainEvents
    {
        //Hilmi: Check if necessary for us
        //ICollection<IEventData> DomainEvents { get; }
    }
}
