using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TodoApp.ApiContracts.ServiceContracts.Device;
using TodoApp.RequestProcessing;
using TodoApp.WebApi.Filters;

namespace TodoApp.WebApi.Controllers
{
    [ExceptionHandlingFilter]
    [Route("api/Device")]
    public class DeviceController : ApiController
    {
        private IRequestManager _requestManager;
        private IRequestProcessor<RegisterRequest, RegisterResponse> _register;
        private IRequestProcessor<UpdateRequest, UpdateResponse> _update;

        public DeviceController(
            IRequestManager requestManager,
            IRequestProcessor<RegisterRequest, RegisterResponse> register,
            IRequestProcessor<UpdateRequest, UpdateResponse> update)
        {
            this._requestManager = requestManager;
            this._register = register;
            this._update = update;
        }


        [HttpPost]
        [ResponseType(typeof(RegisterResponse))]
        public async Task<HttpResponseMessage> Register(RegisterRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _register);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }

        [HttpPost]
        [ResponseType(typeof(UpdateResponse))]
        public async Task<HttpResponseMessage> Update(UpdateRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _update);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }
    }
}
