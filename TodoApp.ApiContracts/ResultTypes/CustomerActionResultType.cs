using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ResultTypes
{
    /// <summary>
    /// Enumeration for Customer Action
    /// </summary>
    [DataContract]
    public enum CustomerActionResultType
    {
        /// <summary>
        /// Action succeeds 
        /// </summary>
        Success = 1,

        /// <summary>
        /// Action Fails
        /// </summary>
        Failure = 2,

        /// <summary>
        /// Authentication fails
        /// </summary>
        AuthenticationFailed = 3,

        /// <summary>
        /// Customer wasn't found
        /// </summary>
        CustomerNotFound = 4,

        /// <summary>
        /// Email is in Use
        /// </summary>
        EmailInUse = 5,

        /// <summary>
        /// Mobile Phone number is in Use
        /// </summary>
        MobileInUse = 6,

        /// <summary>
        /// Customer is blocked
        /// </summary>
        CustomerBlocked = 7,

        /// <summary>
        /// Customer is already registered
        /// </summary>
        CustomerAlreadyRegistered = 8,

        /// <summary>
        /// Device hasn't registered
        /// </summary>
        DeviceHasntRegistered = 9,

        /// <summary>
        /// Customer has already registered, new device it's added
        /// </summary>
        CustomerAlreadyRegisteredAddNewDevice = 10,

        /// <summary>
        /// Customer is deactivated
        /// </summary>
        CustomerDeactivated = 11,
        
        /// <summary>
        /// Customer hasn't accepted terms.
        /// </summary>
        TermsNotAccepted = 12
    }
}
