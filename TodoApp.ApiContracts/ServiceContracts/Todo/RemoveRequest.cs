using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ServiceContracts.Todo
{
    /// <summary>
    /// Remove todo request object
    /// </summary>
    [DataContract]
    public class RemoveRequest : RequestBase
    {
        /// <summary>
        /// Todo id of thread
        /// </summary>
        [DataMember]
        public long TodoId { get; set; }
    }
}
