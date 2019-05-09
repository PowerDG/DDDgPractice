using Microsoft.AspNetCore.Mvc;

namespace DgCore.MyMission.Web.Controllers
{
    public class HomeController : MyMissionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}