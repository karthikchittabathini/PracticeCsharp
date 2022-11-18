using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiDemo1.Infrastructure
{
    public interface IRepository<TEntity, Tkey> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync();

        Task<TEntity> GetByIdAsync(Tkey id);

        Task CreateAsync(TEntity item);

        Task UpdateAsync(TEntity item);

        Task DeleteAsync(Tkey id);
    }
}
