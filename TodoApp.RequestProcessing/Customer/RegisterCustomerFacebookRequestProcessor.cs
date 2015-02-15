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
    public class RegisterCustomerFacebookRequestProcessor : RequestProcessor<RegisterFacebookRequest, RegisterFacebookResponse>
    {
        #region Fields
        private ICustomerManager _customerManager;
        #endregion

        #region Constructor

        public RegisterCustomerFacebookRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ICustomerManager customerManager)
            : base(platformManager, deviceManager)
        {
            this._customerManager = customerManager;
        }

        #endregion

        #region Members
        public override async Task ProcessRequest(RegisterFacebookRequest request, RegisterFacebookResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(RegisterFacebookRequest request, RegisterFacebookResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = CustomerActionResultType.Success;
        }

        #endregion
    }
}
