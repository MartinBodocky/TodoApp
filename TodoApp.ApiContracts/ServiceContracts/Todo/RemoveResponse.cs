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
    /// Remove todo response object
    /// </summary>
    [DataContract]
    public class RemoveResponse : ResponseBase
    {
        /// <summary>
        /// Result of todo remove action
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
