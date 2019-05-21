using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcCookieAuthSample2.Models;

using IdentityServer4.Test;
using System.Security.Claims;

namespace mvcCookieAuthSample2.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestUserStore _users;
        private Claim[] props;

        public HomeController(TestUserStore users)
        {
            _users = users;
        }

        public   string LoginAsync(string[] Items)
        {
            var user =    _users.FindByUsername(Items[0]);
            var t = " ";
            //HttpContext.Sign
            Microsoft.AspNetCore.Http.AuthenticationManagerExtensions.SignInAsync(
                HttpContext,
                user.SubjectId,
                user.Username,
                props
                );
            return user.Username;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
