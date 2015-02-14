using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Data;
using TodoApp.DataContracts.Entities;
using TodoApp.OperationContracts;

namespace TodoApp.Framework
{
    /// <summary>
    /// Implements repository properties
    /// </summary>
    public class EntityRepository : IEntityRepository, IDisposable
    {
        private IEntityContext _context;
        private GenericRepository<Device> _devices;
        private GenericRepository<Platform> _platforms;
        private GenericRepository<Customer> _customers;
        private GenericRepository<Todo> _todos;
        private GenericRepository<Comment> _comments;

        public EntityRepository(IEntityContext context)
        {
            _context = context;
        }

        #region IEntity repository implementation

        public IGenericRepository<Device> DeviceRepository
        {
            get 
            {
                if (this._devices == null)
                    this._devices = new GenericRepository<Device>((DbContext)_context);

                return this._devices;
            }
        }

        public IGenericRepository<Platform> PlatformRepository
        {
            get 
            {
                if (this._platforms == null)
                    this._platforms = new GenericRepository<Platform>((DbContext)_context);

                return this._platforms;
            }
        }

        public IGenericRepository<Customer> CustomerRepository
        {
            get 
            {
                if (this._customers == null)
                    this._customers = new GenericRepository<Customer>((DbContext)_context);

                return this._customers;
            }
        }

        public IGenericRepository<Todo> TodoRepository
        {
            get 
            {
                if (this._todos == null)
                    this._todos = new GenericRepository<Todo>((DbContext)_context);

                return this._todos;
            }
        }

        public IGenericRepository<Comment> CommentRepository
        {
            get
            {
                if (this._comments == null)
                    this._comments = new GenericRepository<Comment>((DbContext)_context);

                return this._comments;
            }
        }

        public async Task SaveTask()
        {
            await _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        #endregion

        #region Dispose

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    _context.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
