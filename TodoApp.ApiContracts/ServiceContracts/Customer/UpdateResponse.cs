using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;

namespace TodoApp.ApiContracts.ServiceContracts.Customer
{
    /// <summary>
    /// Update customer response object
    /// </summary>
    [DataContract]
    public class UpdateResponse : ResponseBase
    {
        /// <summary>
        /// REsult of update details action
        /// </summary>
        [DataMember]
        public CustomerActionResultType Result { get; set; }

        /// <summary>
        /// Text representation or Result
        /// </summary>
        [DataMember]
        public string ResultText { get { return Result.ToString(); } }
    }
}
