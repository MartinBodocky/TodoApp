using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TodoApp.ApiContracts.ServiceContracts.Todo;
using TodoApp.RequestProcessing;
using TodoApp.WebApi.Filters;

namespace TodoApp.WebApi.Controllers
{
    [ExceptionHandlingFilter]
    [Route("api/Todo")]
    public class TodoController : ApiController
    {
        private IRequestManager _requestManager;
        private IRequestProcessor<AddRequest, AddResponse> _add;
        private IRequestProcessor<UpdateRequest, UpdateResponse> _update;
        private IRequestProcessor<RemoveRequest, RemoveResponse> _remove;
        private IRequestProcessor<GetListRequest, GetListResponse> _getList;

        public TodoController(
            IRequestManager requestManager,
            IRequestProcessor<AddRequest, AddResponse> add,
            IRequestProcessor<UpdateRequest, UpdateResponse> update,
            IRequestProcessor<RemoveRequest, RemoveResponse> remove,
            IRequestProcessor<GetListRequest, GetListResponse> getList)
        {
            this._requestManager = requestManager;
            this._add = add;
            this._update = update;
            this._remove = remove;
            this._getList = getList;
        }


        [HttpPost]
        [ResponseType(typeof(AddResponse))]
        public async Task<HttpResponseMessage> Add(AddRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _add);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }

        [HttpPost]
        [ResponseType(typeof(GetListResponse))]
        public async Task<HttpResponseMessage> GetList(GetListRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _getList);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }

        [HttpPost]
        [ResponseType(typeof(RemoveResponse))]
        public async Task<HttpResponseMessage> Remove(RemoveRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _remove);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }

        [HttpPost]
        [ResponseType(typeof(UpdateResponse))]
        public async Task<HttpResponseMessage> Add(UpdateRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _update);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }
    }
}
