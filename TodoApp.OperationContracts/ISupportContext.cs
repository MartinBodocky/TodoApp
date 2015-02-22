using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;

namespace TodoApp.OperationContracts
{
    public interface ISupportContext : IContext
    {
        IDbSet<CommunicationLog> CommunicationLog { get; set; }
        IDbSet<ExceptionLog> ExceptionLog { get; set; }
    }
}
