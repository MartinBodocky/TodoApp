using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.DataContracts
{
    /// <summary>
    /// Object represents Facebook authentication
    /// </summary>
    [DataContract]
    public class FacebookTokenDto
    {
        /// <summary>
        /// Facebook's access token
        /// </summary>
        [DataMember]
        public string AccessToken { get; set; }

        /// <summary>
        /// Expiration of access token
        /// </summary>
        [DataMember]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Customer's Facebook User ID
        /// </summary>
        [DataMember]
        public string FacebookUserID { get; set; }
    }
}
