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
    public class LogOutRequestProcessor : RequestProcessor<LogOutRequest, LogOutResponse>
    {
        #region Fields
        private ICustomerManager _customerManager;
        #endregion

        #region Constructor

        public LogOutRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ICustomerManager customerManager)
            : base(platformManager, deviceManager)
        {
            this._customerManager = customerManager;
        }

        #endregion

        #region Members

        public override bool RequiresAuthentication
        {
            get
            {
                return true;
            }
        }

        public override async Task ProcessRequest(LogOutRequest request, LogOutResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(LogOutRequest request, LogOutResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = CustomerActionResultType.Success;
        }

        #endregion
    }
}
