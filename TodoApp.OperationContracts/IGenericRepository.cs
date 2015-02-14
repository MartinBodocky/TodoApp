using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.OperationContracts
{
    /// <summary>
    /// Interface defines basic action for repository class
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string include = null);
        Task<TEntity> GetById(object id);
        Task Insert(TEntity entity);
        Task Delete(object id);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
    }
}
