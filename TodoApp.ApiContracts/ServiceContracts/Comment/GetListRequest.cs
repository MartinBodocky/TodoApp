using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ServiceContracts.Comment
{
    /// <summary>
    /// Get list of comment request object
    /// </summary>
    [DataContract]
    public class GetListRequest :RequestBase
    {
        /// <summary>
        /// Todo id of thread
        /// </summary>
        [DataMember]
        public long TodoId { get; set; }
    }
}
