using System;
using System.Collections.Generic;

namespace DomainForgeFramework.Infrastructure
{

    /// <summary>
    /// Represents a repository that can be used to store and retrieve entities.
    /// </summary>
    /// <typeparam name="T">The type of entity that the repository stores.</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Adds an entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>The entity that was added.</returns>
        T Add(T entity);

        /// <summary>
        /// Gets an entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity to get.</param>
        /// <returns>The entity with the specified unique identifier.</returns>
        T GetById(Guid id);

        /// <summary>
        /// Gets all entities in the repository.
        /// </summary>
        /// <returns>All entities in the repository.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Updates an entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        void Update(T entity);

        /// <summary>
        /// Removes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        void Remove(T entity);

        // Opsiyonel: IUnitOfWork UnitOfWork { get; }
    }
}
