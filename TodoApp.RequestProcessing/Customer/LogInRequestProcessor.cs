using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;
using TodoApp.ApiContracts.ServiceContracts.Customer;
using TodoApp.OperationContracts;

namespace TodoApp.RequestProcessing.Customer
{
    public class LogInRequestProcessor : RequestProcessor<LogInRequest, LogInResponse>
    {
        #region Fields
        private ICustomerManager _customerManager;
        #endregion

        #region Constructor

        public LogInRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ICustomerManager customerManager)
            : base(platformManager, deviceManager)
        {
            this._customerManager = customerManager;
        }

        #endregion

        #region Members
        public override async Task ProcessRequest(LogInRequest request, LogInResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(LogInRequest request, LogInResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = CustomerActionResultType.Success;
        }

        #endregion
    }
}
