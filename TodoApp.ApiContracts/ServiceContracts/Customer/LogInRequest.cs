using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ServiceContracts.Customer
{
    /// <summary>
    /// Log in request object
    /// </summary>
    [DataContract]
    public class LogInRequest : RequestBase
    {
        /// <summary>
        /// Customer User name
        /// </summary>
        [DataMember]
        public string Username { get; set; }

        /// <summary>
        /// Customer password
        /// </summary>
        [DataMember]
        public string Password { get; set; }
    }
}
