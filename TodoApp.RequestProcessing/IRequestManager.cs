using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ApiContracts.ServiceContracts;

namespace TodoApp.RequestProcessing
{
    public interface IRequestManager
    {
        Task<TResponse> HandleRequest<TRequest, TResponse>(TRequest request, IRequestProcessor<TRequest, TResponse> processor)
            where TRequest : RequestBase
            where TResponse : ResponseBase;
    }
}
