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
    public interface ISupportContext
    {
        IDbSet<CommunicationLog> CommunicationLog { get; set; }
        IDbSet<ExceptionLog> ExceptionLog { get; set; }

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
