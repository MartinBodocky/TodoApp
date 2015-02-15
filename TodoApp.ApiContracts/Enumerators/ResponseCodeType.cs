using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.Enumerators
{
    public enum ResponseCodeType
    {
        /// <summary>
        ///     No error has occurred.
        /// </summary>
        Success = 1,

        /// <summary>
        ///     The function has not been implemented.
        /// </summary>
        NotImplemented = 2,

        /// <summary>
        ///     An internal error occurred.
        /// </summary>
        InternalError = 3,

        /// <summary>
        ///     The platform is invalid.
        /// </summary>
        InvalidPlatform = 4,

        /// <summary>
        ///     The device ID is required but was not present in the request.
        /// </summary>
        DeviceIdRequired = 5,

        /// <summary>
        ///     Authentication is required.
        /// </summary>
        AuthenticationRequired = 6,

        /// <summary>
        ///     The device token is not valid for this device.
        /// </summary>
        InvalidDeviceToken = 7,

        /// <summary>
        ///     The request is not valid.
        /// </summary>
        InvalidRequest = 8,
        /// <summary>
        ///     Missing Device token
        /// </summary>
        MissingDeviceToken = 9
    }
}
