using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.Enumerators;

namespace TodoApp.ApiContracts.ServiceContracts
{
    /// <summary>
    /// Base Response
    /// </summary>
    [DataContract]
    public class ResponseBase
    {
        /// <summary>
        ///     The devices unique identifier.
        /// </summary>
        [DataMember]
        public Guid DeviceGuid { get; set; }

        /// <summary>
        ///     If an error occurs this enumeration will allow the client to take appropriate action. E.g. Session expiry.
        /// </summary>
        [DataMember]
        public ResponseCodeType StatusCode { get; set; }

        /// <summary>
        ///     The text representation of the status code.
        /// </summary>
        [DataMember]
        public string Status
        {
            get
            {
                return StatusCode.ToString();
            }
        }

        /// <summary>
        /// If specified contains additional information about the failure.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string StatusAdditionalDetails { get; set; }

        /// <summary>
        ///     The lookup ID in the logging system for the error.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Guid? LogLookupId { get; set; }

        
    }
}
