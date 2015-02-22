using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;

namespace TodoApp.OperationContracts
{
    public interface IEntityContext : IContext
    {
        IDbSet<Device> Devices { get; set; }
        IDbSet<Platform> Platforms { get; set; }
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Todo> Todos { get; set; }
        IDbSet<Comment> Comments { get; set; }
    }
}
