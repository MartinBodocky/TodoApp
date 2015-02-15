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
    public class RegisterCustomerRequestProcessor : RequestProcessor<RegisterRequest, RegisterResponse>
    {
        #region Fields
        private ICustomerManager _customerManager;
        #endregion

        #region Constructor

        public RegisterCustomerRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ICustomerManager customerManager)
            : base(platformManager, deviceManager)
        {
            this._customerManager = customerManager;
        }

        #endregion

        #region Members
        public override async Task ProcessRequest(RegisterRequest request, RegisterResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(RegisterRequest request, RegisterResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = CustomerActionResultType.Success;
        }

        #endregion
    }
}
