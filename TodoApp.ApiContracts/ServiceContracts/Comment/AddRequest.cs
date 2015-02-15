using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ServiceContracts.Comment
{
    /// <summary>
    /// Add comment request object
    /// </summary>
    [DataContract]
    public class AddRequest : RequestBase
    {
        /// <summary>
        /// Unique id of todo, you like add comment
        /// </summary>
        [DataMember]
        public long TodoId { get; set; }

        /// <summary>
        /// Text of comment
        /// </summary>
        [DataMember]
        public string Text { get; set; }
    }
}
