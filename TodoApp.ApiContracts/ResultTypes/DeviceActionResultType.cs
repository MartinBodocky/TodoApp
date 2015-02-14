using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ResultTypes
{
    /// <summary>
    /// Device action result type
    /// </summary>
    public enum DeviceActionResultType
    {
        /// <summary>
        /// Action succeeds 
        /// </summary>
        Success = 1,

        /// <summary>
        /// Device already exists
        /// </summary>
        DeviceAlreadyExists = 2,

        /// <summary>
        /// Device hasn't been found
        /// </summary>
        DeviceNotFound = 3
    }
}
