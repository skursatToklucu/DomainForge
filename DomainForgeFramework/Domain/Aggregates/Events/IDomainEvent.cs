namespace DomainForgeFramework.Domain.Aggregates.Events
{
    /// <summary>
    /// Marker interface for domain events.
    /// Domain events are events that are raised by the domain model to notify the outside world of changes to the domain model.
    /// </summary>
    public interface IDomainEvent
    {
        /// <summary>
        /// Gets the date and time when the event occurred.
        /// </summary>
        DateTime OccurredOn { get; }
    }
}