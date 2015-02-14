using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ServiceContracts
{
    /// <summary>
    /// Base request
    /// </summary>
    [DataContract]
    public class RequestBase
    {
        /// <summary>
        /// The device GUID of the QJMP client
        /// </summary>
        [DataMember]
        public Guid DeviceGuid { get; set; }

        /// <summary>
        ///     The device platform e.g. iPhone, Nokia, Android.
        /// </summary>
        [DataMember]
        public string Platform { get; set; }

        /// <summary>
        ///     The culture code mobile application.
        /// </summary>
        [DataMember]
        public string CultureCode { get; set; }

        /// <summary>
        ///     The mobile application's timezone
        /// </summary>
        [DataMember]
        public int TimeZoneOffset { get; set; }

        /// <summary>
        /// The security authentication token.
        /// </summary>
        [DataMember]
        public string DeviceToken { get; set; }
    }
}
