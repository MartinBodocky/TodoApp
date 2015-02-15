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
    /// Register customer response with update Customer object
    /// </summary>
    [DataContract]
    public class RegisterResponse : ResponseBase
    {
        /// <summary>
        /// Result of register process step
        /// </summary>
        [DataMember]
        public CustomerActionResultType Result { get; set; }

        /// <summary>
        /// Text representation or Result
        /// </summary>
        [DataMember]
        public string ResultText { get { return Result.ToString(); } }

        /// <summary>
        /// Customer object
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CustomerDto Customer { get; set; }
    }
}
