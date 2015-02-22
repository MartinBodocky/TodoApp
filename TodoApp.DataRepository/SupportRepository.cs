using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;
using TodoApp.OperationContracts;

namespace TodoApp.DataRepository
{
    /// <summary>
    /// Implement support repository properties
    /// </summary>
    public class SupportRepository : ISupportRepository
    {
        private ISupportContext _context;
        private GenericRepository<CommunicationLog> _communicationLog;
        private GenericRepository<ExceptionLog> _exceptionLog;

        public SupportRepository(ISupportContext context)
        {
            _context = context;
        }

        public IGenericRepository<CommunicationLog> CommunicationLog
        {
            get
            {
                if (this._communicationLog == null)
                    this._communicationLog = new GenericRepository<CommunicationLog>(_context);

                return this._communicationLog;
            }
        }

        public IGenericRepository<ExceptionLog> ExceptionLog
        {
            get
            {
                if (this._exceptionLog == null)
                    this._exceptionLog = new GenericRepository<ExceptionLog>(_context);

                return this._exceptionLog;
            }
        }
    }
}
