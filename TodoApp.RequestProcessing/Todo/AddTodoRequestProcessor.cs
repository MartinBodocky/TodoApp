﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;
using TodoApp.ApiContracts.ServiceContracts.Todo;
using TodoApp.OperationContracts;

namespace TodoApp.RequestProcessing.Todo
{
    public class AddTodoRequestProcessor : RequestProcessor<AddRequest, AddResponse>
    {
        #region Fields
        private ITodoManager _todoManager;
        #endregion

        #region Constructor

        public AddTodoRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ITodoManager todoManager)
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

        public override async Task ProcessRequest(AddRequest request, AddResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(AddRequest request, AddResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = TodoActionResultType.Success;
        }

        #endregion
    }
}
