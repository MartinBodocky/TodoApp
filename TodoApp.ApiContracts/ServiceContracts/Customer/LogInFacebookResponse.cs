using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.DataContracts;
using TodoApp.ApiContracts.ResultTypes;

namespace TodoApp.ApiContracts.ServiceContracts.Customer
{
    /// <summary>
    /// Log in response for customer via Facebook
    /// </summary>
    [DataContract]
    public class LogInFacebookResponse : ResponseBase
    {
        /// <summary>
        /// Result of Customer log in
        /// </summary>
        [DataMember]
        public CustomerActionResultType Result { get; set; }

        /// <summary>
        /// Test representation of Result
        /// </summary>
        [DataMember]
        public string ResultText { get { return Result.ToString(); } }

        /// <summary>
        /// Customer returns as successful authentication
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CustomerDto Customer { get; set; }
    }
}
