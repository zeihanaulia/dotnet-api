using Microsoft.AspNetCore.Antiforgery;
using dotnet-api.Controllers;

namespace dotnet-api.Web.Host.Controllers
{
    public class AntiForgeryController : dotnet-apiControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
