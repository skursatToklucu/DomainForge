    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DomainForgeFramework.Domain.Aggregates.Events;

namespace DomainForgeFramework.Domain.Aggregates
{
    /// <summary>
    /// Base class for aggregate roots.
    /// Aggregate roots are the root entities of an aggregate. They are the only entities that can be accessed from outside the aggregate.
    /// </summary>
    public abstract class BaseAggregateRoot : IAggregateRoot
    {
        // The domain events that have occurred in the aggregate root.
        private readonly List<IDomainEvent> _domainEvents = [];

        /// <summary>
        /// Gets the unique identifier of the aggregate root.
        /// </summary>
        public Guid Id { get; protected set; }

        /// <summary>
        /// Gets the domain events that have occurred in the aggregate root.
        /// </summary>
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        /// <summary>
        /// Adds a domain event to the aggregate root.
        /// Domain events are events that are raised by the domain model to notify the outside world of changes to the domain model.
        /// </summary>
        /// <param name="domainEvent">The domain event to add.</param>
        protected void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        /// <summary>
        /// Clears the domain events that have occurred in the aggregate root.
        /// </summary>
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        /// <summary>
        /// Gets the domain events that have occurred in the aggregate root of the specified type.
        /// </summary>
        /// <typeparam name="TDomainEvent">The type of domain event to get.</typeparam>
        /// <returns>The domain events that have occurred in the aggregate root of the specified type.</returns>
        public IEnumerable<TDomainEvent> GetDomainEvents<TDomainEvent>() where TDomainEvent : IDomainEvent
        {
            return _domainEvents.OfType<TDomainEvent>();
        }
    }
}