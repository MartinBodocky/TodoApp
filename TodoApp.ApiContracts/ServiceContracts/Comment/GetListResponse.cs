using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.DataContracts;
using TodoApp.ApiContracts.ResultTypes;

namespace TodoApp.ApiContracts.ServiceContracts.Comment
{
    /// <summary>
    /// Get list comment response object
    /// </summary>
    [DataContract]
    public class GetListResponse : ResponseBase
    {
        /// <summary>
        /// List of comments for particular todo
        /// </summary>
        [DataMember]
        public CommentDto[] Comments { get; set; }

        /// <summary>
        /// Result of Comment get list action
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
