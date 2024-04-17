using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.Contracts.Persistence
{
    /// <summary>
    /// Generic Repository
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Returns an entity of type T
        /// </summary>
        /// <param name="id">ID of the record</param>
        /// <returns>Returns an entity of type T</returns>
        Task<T> Get(int id);
        /// <summary>
        /// Returns a list of readonly entity of type T
        /// </summary>
        /// <returns>Return a list of readonly entity of type T</returns>
        Task<IReadOnlyList<T>> GetAll();
        /// <summary>
        /// Add an entity of type T in the database
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>Returns an entity</returns>
        Task<T> Add(T entity);
        /// <summary>
        /// Check if entity exist in the database
        /// </summary>
        /// <param name="id">ID of the entity</param>
        /// <returns>Returns true or false</returns>
        Task<bool> Exists(int id);
        /// <summary>
        /// Updates an entity of type T from the database
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <returns></returns>
        Task Update(T entity);
        /// <summary>
        /// Deletes an entity of type T in the database
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        /// <returns></returns>
        Task Delete(T entity);
    }
}
