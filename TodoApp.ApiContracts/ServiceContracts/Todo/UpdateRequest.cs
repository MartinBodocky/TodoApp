using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.DataContracts;

namespace TodoApp.ApiContracts.ServiceContracts.Todo
{
    /// <summary>
    /// Update todo request object
    /// </summary>
    [DataContract]
    public class UpdateRequest : RequestBase
    {
        /// <summary>
        /// Updated Todo
        /// </summary>
        [DataMember]
        public TodoDto Todo { get; set; }
    }
}
