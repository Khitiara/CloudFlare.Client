using System.Net.Http;
using CloudFlare.Client.Api.Authentication;

namespace CloudFlare.Client.Contexts
{
    internal class ApiConnection : Connection
    {
        public ApiConnection(IAuthentication authentication, ConnectionInfo connectionInfo,
            IHttpMessageHandlerFactory factory)
            : base(authentication, connectionInfo, factory)
        {
        }
    }
}
