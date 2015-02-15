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
    /// Register customer via facebook request
    /// </summary>
    [DataContract]
    public class RegisterFacebookRequest : RequestBase
    {
        /// <summary>
        /// Customer information
        /// </summary>
        [DataMember]
        public CustomerDto Customer { get; set; }

        /// <summary>
        /// Facebook authentication object
        /// </summary>
        [DataMember]
        public FacebookTokenDto Authentication { get; set; }

        /// <summary>
        /// Step of registration process
        /// </summary>
        [DataMember]
        public int Step { get; set; }
    }
}
