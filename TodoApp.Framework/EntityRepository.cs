using System;
using System.Collections.Generic;
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
    public class EntityRepository : IEntityRepository
    {
        private IEntityContext _context;
        public EntityRepository(IEntityContext context)
        {

        }

        public IGenericRepository<Device> DeviceRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Platform> PlatformRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Customer> CustomerRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Todo> TodoRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Comment> CommentRepository
        {
            get { throw new NotImplementedException(); }
        }
    }
}
