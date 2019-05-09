using Microsoft.AspNetCore.Antiforgery;
using DgMission.Controllers;

namespace DgMission.Web.Host.Controllers
{
    public class AntiForgeryController : DgMissionControllerBase
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
