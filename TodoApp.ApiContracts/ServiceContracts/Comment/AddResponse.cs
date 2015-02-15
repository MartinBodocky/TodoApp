using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;

namespace TodoApp.ApiContracts.ServiceContracts.Comment
{
    /// <summary>
    /// Add comment response object
    /// </summary>
    [DataContract]
    public class AddResponse : ResponseBase
    {
        /// <summary>
        /// Result of Comment add action
        /// </summary>
        [DataMember]
        public CommentActionResultType Result { get; set; }

        /// <summary>
        /// Text representation or Result
        /// </summary>
        [DataMember]
        public string ResultText { get { return Result.ToString(); } }
    }
}
