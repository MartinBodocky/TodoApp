using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ServiceContracts.Todo
{
    /// <summary>
    /// Get list todos request object 
    /// </summary>
    [DataContract]
    public class GetListRequest : RequestBase
    {
        /// <summary>
        /// Flag to review only todos which I created or contributed to
        /// </summary>
        [DataMember]
        public bool OnlyMe { get; set; }
    }
}
