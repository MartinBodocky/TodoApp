using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace TodoApp.WebApi.Filters
{
    public class ExceptionHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public ExceptionHandlingFilterAttribute()
        {

        }

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var httpResponse = actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError, "Exception: " + actionExecutedContext.Exception.ToString());
            actionExecutedContext.Response = httpResponse;

            base.OnException(actionExecutedContext);
        }

        public override Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            var httpResponse = actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError, "Exception: " + actionExecutedContext.Exception.ToString());
            actionExecutedContext.Response = httpResponse;

            return base.OnExceptionAsync(actionExecutedContext, cancellationToken);
        }
    }
}