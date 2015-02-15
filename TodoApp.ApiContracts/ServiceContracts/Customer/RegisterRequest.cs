using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.DataContracts;

namespace TodoApp.ApiContracts.ServiceContracts.Customer
{
    /// <summary>
    /// Register customer request with desired step
    /// </summary>
    [DataContract]
    public class RegisterRequest : RequestBase
    {
        /// <summary>
        /// Customer object
        /// </summary>
        [DataMember]
        public CustomerDto Customer { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// Step of registration process
        /// </summary>
        [DataMember]
        public int Step { get; set; }
    }
}
