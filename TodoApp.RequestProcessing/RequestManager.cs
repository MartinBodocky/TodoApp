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
    public class RequestManager : IRequestManager
    {
        #region Fields

        private readonly IDeviceManager _deviceManager;
        private readonly IExceptionManager _exceptionManager;

        #endregion

        #region Constructor

        public RequestManager(IDeviceManager deviceManager, IExceptionManager exceptionManager)
        {
            _deviceManager = deviceManager;
            _exceptionManager = exceptionManager;
        }

        #endregion

        #region Members

        public async Task<TResponse> HandleRequest<TRequest, TResponse>(TRequest request, IRequestProcessor<TRequest, TResponse> processor)

            where TRequest : RequestBase
            where TResponse : ResponseBase
        {

            // Create the response object
            var response = Activator.CreateInstance<TResponse>();

            try
            {
                // Check request
                if (request == null)
                {
                    // This happens if you submit an invalid request (I.e. Invalid JSON)                    
                    response.StatusCode = ResponseCodeType.InvalidRequest;
                    return response;
                }
                // Initialize the response in the request
                processor.InitializeResponse(request, response);

                if (!(await processor.Authorise(request, response))) return response;


                // Set the base return values
                response.DeviceGuid = request.DeviceGuid;

                var device = await _deviceManager.GetDevice(request.DeviceGuid);

                // Check whether authentication is required for the request
                if (processor.RequiresAuthentication && !device.IsLoggedIn)
                {

                    response.StatusCode = ResponseCodeType.AuthenticationRequired;
                    return response;
                }

                // Process the request
                await processor.ProcessRequest(request, response);

            }
            catch (Exception ex)
            {

                // Log the exception
                response.LogLookupId = _exceptionManager.LogException(ex,
                    response.DeviceGuid).Result;

                // Set the response status
                response.StatusCode = ResponseCodeType.InternalError;
            }

            return response;
        }

        #endregion
    }
}
