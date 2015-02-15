using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ServiceContracts.Comment
{
    /// <summary>
    /// Update comment request object
    /// </summary>
    [DataContract]
    public class UpdateRequest : RequestBase
    {
        /// <summary>
        /// Todo id of thread
        /// </summary>
        [DataMember]
        public long TodoId { get; set; }

        /// <summary>
        /// Unique comment id
        /// </summary>
        [DataMember]
        public long CommentId { get; set; }

        /// <summary>
        /// Changed text of comment
        /// </summary>
        [DataMember]
        public string NewText { get; set; }
    }
}
