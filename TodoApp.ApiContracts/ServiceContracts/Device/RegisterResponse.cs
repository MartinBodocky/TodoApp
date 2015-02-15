using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;

namespace TodoApp.ApiContracts.ServiceContracts.Device
{
    /// <summary>
    /// Register device response
    /// </summary>
    [DataContract]
    public class RegisterResponse : ResponseBase
    {

        /// <summary>
        /// Result of action
        /// </summary>
        [DataMember]
        public DeviceActionResultType Result { get; set; }

        /// <summary>
        /// Text representation of Result
        /// </summary>
        [DataMember]
        public string ResultText { get { return Result.ToString(); } }

        /// <summary>
        /// The security authentication token to use for all calls from this device.
        /// </summary>
        [DataMember]
        public string DeviceToken { get; set; }
    }
}
