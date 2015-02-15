using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;
using TodoApp.ApiContracts.ServiceContracts.Device;
using TodoApp.OperationContracts;

namespace TodoApp.RequestProcessing.Device
{
    public class UpdateDeviceRequestProcessor :RequestProcessor<UpdateRequest, UpdateResponse>
    {
        #region Fields

        #endregion

        #region Constructor

        public UpdateDeviceRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager)
            : base(platformManager, deviceManager)
        {

        }

        #endregion

        #region Members
        public override async Task ProcessRequest(UpdateRequest request, UpdateResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(UpdateRequest request, UpdateResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = DeviceActionResultType.Success;
        }

        #endregion
    }
}
