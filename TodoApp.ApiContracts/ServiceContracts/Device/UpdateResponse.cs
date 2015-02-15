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
    /// Update device response
    /// </summary>
    [DataContract]
    public class UpdateResponse : ResponseBase
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
    }
}
