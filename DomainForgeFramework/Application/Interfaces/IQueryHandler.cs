namespace DomainForgeFramework.Application.Interfaces
{
    /// <summary>
    /// Represents a query handler that can execute queries in the application.
    /// Query handlers are used to execute queries and retrieve data from the application.
    /// </summary>
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        // Executes the query and returns the result.
        Task<TResult> HandleAsync(TQuery query);
    }
}