using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.ServiceContracts.Customer
{
    /// <summary>
    /// Log in customer request via Facebook
    /// </summary>
    [DataContract]
    public class LogInFacebookRequest : RequestBase
    {
    }
}
