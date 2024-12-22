using DomainForgeFramework.Domain.Aggregates.Events;

namespace DomainForgeFramework.Application.Interfaces
{
    /// <summary>
    /// Represents a domain event dispatcher that can dispatch domain events in the application.
    /// Domain event dispatchers are used to dispatch domain events to the appropriate handlers.
    /// </summary>
    public interface IDomainEventDispatcher
    {
        // Dispatches the domain event to the appropriate handlers.
        Task DispatchAsync(IEnumerable<IDomainEvent> domainEvent);
    }
}