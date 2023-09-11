using PersonApi.Models;

namespace PersonApi.Repositories
{
    public interface IGenericRepository<T> : IDisposable where T : BaseEntity
    {
        /// <summary>
        /// GetAllAsync
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T?> GetAsync(int id);

        /// <summary>
        /// SaveAsync
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> SaveAsync(T entity);

        /// <summary>
        /// UpdateAsync
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity);

        /// <summary>
        /// DeleteAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(int id);
    }
}
