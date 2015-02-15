using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ResultTypes;
using TodoApp.ApiContracts.ServiceContracts.Comment;
using TodoApp.OperationContracts;

namespace TodoApp.RequestProcessing.Comment
{
    public class AddCommentRequestProcessor : RequestProcessor<AddRequest, AddResponse>
    {
        #region Fields
        private ICommentManager _commentManager;
        #endregion

        #region Constructor

        public AddCommentRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ICommentManager commentManager)
            : base(platformManager, deviceManager)
        {
            this._commentManager = commentManager;
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
            response.Result = CommentActionResultType.Success;
        }

        #endregion
    }
}
