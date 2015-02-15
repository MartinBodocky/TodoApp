using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.DataContracts;

namespace TodoApp.ApiContracts.ServiceContracts.Device
{
    /// <summary>
    /// Update device request with update location or push token
    /// </summary>
    [DataContract]
    public class UpdateRequest : RequestBase
    {
        /// <summary>
        /// Current location of device
        /// </summary>
        [DataMember]
        public GeolocationDto Location { get; set; }

        /// <summary>
        /// Push notification from mobile device
        /// </summary>
        [DataMember]
        public string PushNotification { get; set; }
    }
}
