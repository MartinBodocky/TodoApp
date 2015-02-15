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
    public class RemoveCommentRequestProcessor : RequestProcessor<RemoveRequest, RemoveResponse>
    {
        #region Fields
        private ICommentManager _commentManager;
        #endregion

        #region Constructor

        public RemoveCommentRequestProcessor(IDeviceManager deviceManager, IPlatformManager platformManager, ICommentManager commentManager)
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

        public override async Task ProcessRequest(RemoveRequest request, RemoveResponse response)
        {
            throw new NotImplementedException();
        }

        public override void InitializeResponse(RemoveRequest request, RemoveResponse response)
        {
            base.InitializeResponse(request, response);
            response.Result = CommentActionResultType.Success;
        }

        #endregion
    }
}
