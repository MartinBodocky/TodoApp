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
    /// Add todo request object
    /// </summary>
    [DataContract]
    public class AddRequest : RequestBase
    {
        /// <summary>
        /// New todo object
        /// </summary>
        [DataMember]
        public TodoDto Todo { get; set; }
    }
}
