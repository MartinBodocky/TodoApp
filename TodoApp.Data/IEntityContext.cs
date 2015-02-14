using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;

namespace TodoApp.Data
{
    public interface IEntityContext
    {
        IDbSet<Device> Devices { get; set; }
        IDbSet<Platform> Platforms { get; set; }
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Todo> Todos { get; set; }
        IDbSet<Comment> Comments { get; set; }

        DbChangeTracker ChangeTracker { get; }
        DbContextConfiguration Configuration { get; }
        Database Database { get; }

        void Dispose();
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet Set(Type entityType);
        
        void SetModified(object entity);
    }
}
