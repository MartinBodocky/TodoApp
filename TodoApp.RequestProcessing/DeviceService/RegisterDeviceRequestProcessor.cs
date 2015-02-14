using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;
using TodoApp.ApiContracts.ServiceContracts.Device;
using TodoApp.OperationContracts;

namespace TodoApp.RequestProcessing.RequestProcessors
{
    public class RegisterDeviceRequestProcessor :
        RequestProcessor<RegisterDeviceRequest, RegisterDeviceResponse>
    {
        #region Fields

        #endregion

        #region Constructor

        public RegisterDeviceRequestProcessor(IDeviceManager deviceManager,
            IPlatformManager platformManager)
            : base(platformManager, deviceManager)
        {
        
        }

        #endregion

        #region Members

        public override bool RequiresAuthToken
        {
            get
            {
                // The auth token is not required here as this is the point where it is generated.
                return false;
            }
        }

        public override async Task ProcessRequest(RegisterDeviceRequest request,
            RegisterDeviceResponse response)
        {
         
            var registrationResult = await _deviceManager.RegisterDevice(request.DeviceGuid, request.Platform);
            
            //response.Result = registrationResult;
            //response.DeviceToken = registrationResult;

            //response.StatusCode = registrationResult.Outcome.ToResponseCodeType();
        }

        public override void InitializeResponse(RegisterDeviceRequest request, RegisterDeviceResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = DeviceActionResultType.Success;
        }

        #endregion
    }
}
