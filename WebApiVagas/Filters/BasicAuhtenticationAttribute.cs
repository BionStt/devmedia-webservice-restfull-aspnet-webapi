using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiVagas.Filters
{
    public class BasicAuhtenticationAttribute : AuthorizationFilterAttribute
    {
        private const string TOKEN = "admin";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authorizationHeader = actionContext.Request.Headers.Authorization;
            if(authorizationHeader == null || authorizationHeader.Scheme != "Bearer" || authorizationHeader.Parameter != TOKEN)
            {
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
        }
    }
}