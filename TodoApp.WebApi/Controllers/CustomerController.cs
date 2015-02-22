using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TodoApp.ApiContracts.ServiceContracts.Customer;
using TodoApp.RequestProcessing;
using TodoApp.WebApi.Filters;

namespace TodoApp.WebApi.Controllers
{
    [ExceptionHandlingFilter]
    [RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
        private IRequestManager _requestManager;
        private IRequestProcessor<RegisterRequest, RegisterResponse> _register;
        private IRequestProcessor<RegisterFacebookRequest, RegisterFacebookResponse> _registerFacebook;
        private IRequestProcessor<UpdateRequest, UpdateResponse> _update;
        private IRequestProcessor<LoadRequest, LoadResponse> _load;
        private IRequestProcessor<LogInFacebookRequest, LogInFacebookResponse> _logInFacebook;
        private IRequestProcessor<LogInRequest, LogInResponse> _logIn;
        private IRequestProcessor<LogOutRequest, LogOutResponse> _logOut;

        public CustomerController(
            IRequestManager requestManager,
            IRequestProcessor<RegisterRequest, RegisterResponse> register,
            IRequestProcessor<RegisterFacebookRequest, RegisterFacebookResponse> registerFacebook,
            IRequestProcessor<UpdateRequest, UpdateResponse> update,
            IRequestProcessor<LoadRequest, LoadResponse> load,
            IRequestProcessor<LogInFacebookRequest, LogInFacebookResponse> logInFacebook,
            IRequestProcessor<LogInRequest, LogInResponse> logIn,
            IRequestProcessor<LogOutRequest, LogOutResponse> logOut)
        {
            this._requestManager = requestManager;
            this._register = register;
            this._registerFacebook = registerFacebook;
            this._update = update;
            this._load = load;
            this._logInFacebook = logInFacebook;
            this._logIn = logIn;
            this._logOut = logOut;
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
        [ResponseType(typeof(RegisterFacebookResponse))]
        public async Task<HttpResponseMessage> RegisterFacebook(RegisterFacebookRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _registerFacebook);
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

        [HttpPost]
        [ResponseType(typeof(LoadResponse))]
        public async Task<HttpResponseMessage> Load(LoadRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _load);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }

        [HttpPost]
        [ResponseType(typeof(LogInFacebookResponse))]
        public async Task<HttpResponseMessage> LogInFacebook(LogInFacebookRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _logInFacebook);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }

        [HttpPost]
        [ResponseType(typeof(LogInResponse))]
        public async Task<HttpResponseMessage> LogIn(LogInRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _logIn);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }

        [HttpPost]
        [ResponseType(typeof(LogOutResponse))]
        public async Task<HttpResponseMessage> LogOut(LogOutRequest request)
        {
            var response = await _requestManager.HandleRequest(request, _logOut);
            var httpResponse = Request.CreateResponse(HttpStatusCode.OK, response);

            return httpResponse;
        }
    }
}
