using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;

namespace TodoApp.OperationContracts
{
    public interface IExceptionManager
    {
        Task<IEnumerable<ExceptionLog>> GetExceptions(Guid? exceptionLogId, Guid? deviceGuid, int? count);
        Task<ExceptionLog> GetException(Guid exceptionLogId);
        Task<Guid> LogException(Exception ex, Guid? deviceGuid);
    }
}
