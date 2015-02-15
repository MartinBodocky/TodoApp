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
    public class LoadCustomerRequestProcessor : RequestProcessor<LoadRequest, LoadResponse>
    {
        #region Fields
        private ICustomerManager _customerManager;
        #endregion

        #region Constructor

        public LoadCustomerRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ICustomerManager customerManager)
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

        public override async Task ProcessRequest(LoadRequest request, LoadResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(LoadRequest request, LoadResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = CustomerActionResultType.Success;
        }

        #endregion
    }
}
