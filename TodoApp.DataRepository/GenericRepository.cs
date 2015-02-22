using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TodoApp.OperationContracts;

namespace TodoApp.DataRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private IContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(IContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        /// <summary>
        /// Getting objects from db context
        /// </summary>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="include"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> where = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string include = null)
        {
            IQueryable<TEntity> query = _dbSet;
            //apply where clause
            if (where != null)
                query = query.Where(where);

            //apply include clause
            if (string.IsNullOrEmpty(include))
            {
                foreach (var prop in include.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(prop);
                }
            }

            //apply order by clause
            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            else
                return await query.ToListAsync();
        }

        public async Task<TEntity> GetById(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Insert(TEntity entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Add(entity);
            });
        }

        public async Task Delete(object id)
        {
            TEntity entity = await _dbSet.FindAsync(id);
            await Delete(entity);
        }

        public async Task Delete(TEntity entity)
        {
            await Task.Run(() =>
            {
                if (_context.Entry<TEntity>(entity).State == EntityState.Detached)
                    _dbSet.Attach(entity);

                _dbSet.Remove(entity);
            });
        }

        public async Task Update(TEntity entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Attach(entity);
                _context.Entry<TEntity>(entity).State = EntityState.Modified;
            });
        }
    }
}
