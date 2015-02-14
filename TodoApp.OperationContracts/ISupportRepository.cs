using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;

namespace TodoApp.OperationContracts
{
    /// <summary>
    /// Interface defines list of repositories for Support Context
    /// </summary>
    public interface ISupportRepository
    {
        IGenericRepository<CommunicationLog> CommunicationLog { get; }
        IGenericRepository<ExceptionLog> ExceptionLog { get; }
    }
}
