using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.DataContracts;
using TodoApp.ApiContracts.ResultTypes;

namespace TodoApp.ApiContracts.ServiceContracts.Todo
{
    /// <summary>
    /// Get list todos response object
    /// </summary>
    [DataContract]
    public class GetListResponse : ResponseBase
    {
        /// <summary>
        /// List of requested todos
        /// </summary>
        [DataMember]
        public TodoDto[] Todos { get; set; }

        /// <summary>
        /// Result of get list todo action
        /// </summary>
        [DataMember]
        public TodoActionResultType Result { get; set; }

        /// <summary>
        /// Text representation or Result
        /// </summary>
        [DataMember]
        public string ResultText { get { return Result.ToString(); } }
    }
}
