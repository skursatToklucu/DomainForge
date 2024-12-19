namespace DomainForgeFramework.Domain.Aggregates.Events
{
    using System;
    
    /// <summary>
    /// Base class for domain events.
    /// Domain events are events that are raised by the domain model to notify the outside world of changes to the domain model.
    /// </summary>
    public abstract class BaseDomainEvent : IDomainEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDomainEvent"/> class.
        /// </summary>
        protected BaseDomainEvent()
        {
            OccurredOn = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets the date and time when the event occurred.
        /// </summary>
        public DateTime OccurredOn { get; }
    }
}