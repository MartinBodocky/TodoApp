using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ServiceContracts;

namespace TodoApp.RequestProcessing
{
    public interface IRequestProcessor<in TRequest, in TResponse>
        where TRequest : RequestBase
        where TResponse : ResponseBase
    {
        bool RequiresAuthentication { get; }
        void InitializeResponse(TRequest request, TResponse response);
        
        Task ProcessRequest(TRequest request, TResponse response);

        /// <summary>
        /// Authorize the request token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        Task<bool> Authorise(TRequest request, TResponse response);
    }
}
