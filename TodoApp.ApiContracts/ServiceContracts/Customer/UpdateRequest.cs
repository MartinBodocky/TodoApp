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
    /// Update customer request object
    /// </summary>
    [DataContract]
    public class UpdateRequest : RequestBase
    {
        /// <summary>
        /// Customer object
        /// </summary>
        [DataMember]
        public CustomerDto Customer { get; set; }
    }
}
