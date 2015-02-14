using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.Enumerators;
using TodoApp.ApiContracts.ServiceContracts;
using TodoApp.OperationContracts;

namespace TodoApp.RequestProcessing
{
    public abstract class RequestProcessor<TRequest, TResponse> : IRequestProcessor<TRequest, TResponse>
        where TRequest : RequestBase
        where TResponse : ResponseBase
    {
        #region Fields

        
        protected readonly IPlatformManager _platformManager;
        protected readonly IDeviceManager _deviceManager;

        protected RequestProcessor(IPlatformManager platformManager,
            IDeviceManager deviceManager)
        {
            _platformManager = platformManager;
            _deviceManager = deviceManager;
            
        }
        #endregion

        public virtual bool RequiresAuthentication
        {
            get { return false; }
        }

        /// <summary>
        /// This is true by default.
        /// This means that all calls should provide the auth token unless
        /// explicitly specified.
        /// Note that the auth token is returned during registration
        /// </summary>
        public virtual bool RequiresAuthToken
        {
            get { return true; }
        }
        public virtual void InitializeResponse(TRequest request, TResponse response)
        {
            response.StatusCode = ResponseCodeType.Success;
            response.DeviceGuid = request.DeviceGuid;
        }

        public virtual async Task ProcessRequest(TRequest request, TResponse response)
        {
        }

        /// <summary>
        /// Authorize the request token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public virtual async Task<bool> Authorise(TRequest request, TResponse response)
        {
            if (string.IsNullOrEmpty(request.DeviceToken))
            {
                response.StatusCode = ResponseCodeType.MissingAuthToken;

                return false;
            }

            var validToken = await _deviceManager.ValidateToken(request.DeviceToken, request.DeviceGuid);

            if (validToken) return true;

            response.StatusCode = ResponseCodeType.InvalidDeviceToken;

            return false;
        }
    }
}
