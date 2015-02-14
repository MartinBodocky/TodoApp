using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;

namespace TodoApp.OperationContracts
{
    /// <summary>
    /// Interface defines repositories for Entity Context
    /// </summary>
    public interface IEntityRepository
    {
        IGenericRepository<Device> DeviceRepository { get; }
        IGenericRepository<Platform> PlatformRepository { get; }
        IGenericRepository<Customer> CustomerRepository { get; }
        IGenericRepository<Todo> TodoRepository { get; }
        IGenericRepository<Comment> CommentRepository { get; }

        Task SaveTask();
        void Save();
    }
}
