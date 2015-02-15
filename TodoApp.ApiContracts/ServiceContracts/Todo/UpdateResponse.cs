using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;

namespace TodoApp.ApiContracts.ServiceContracts.Todo
{
    /// <summary>
    /// Update todo response object
    /// </summary>
    [DataContract]
    public class UpdateResponse : ResponseBase
    {
        /// <summary>
        /// Result of todo update action
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
