using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;
using TodoApp.ApiContracts.ServiceContracts.Todo;
using TodoApp.OperationContracts;

namespace TodoApp.RequestProcessing.Todo
{
    public class UpdateTodoRequestProcessor : RequestProcessor<UpdateRequest, UpdateResponse>
    {
        #region Fields
        private ITodoManager _todoManager;
        #endregion

        #region Constructor

        public UpdateTodoRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ITodoManager todoManager)
            : base(platformManager, deviceManager)
        {
            this._todoManager = todoManager;
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

        public override async Task ProcessRequest(UpdateRequest request, UpdateResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(UpdateRequest request, UpdateResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = TodoActionResultType.Success;
        }

        #endregion
    }
}
