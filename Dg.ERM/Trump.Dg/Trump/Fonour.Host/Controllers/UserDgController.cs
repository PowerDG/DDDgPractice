using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fonour.Domain.Users;
using Fonour.EntityFrameworkCore.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fonour.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDgController : ControllerBase
    {

        private readonly IRepository<DgUser> _dgUserRepository;


        private readonly IRepository<MenuItem> _menuUserRepository;
        //public readonly IRepository<TruckInfo, long> _userRepository;

        public UserDgController(
                 IRepository<DgUser> dgUserRepository
                )
        {
            _dgUserRepository = dgUserRepository;

        }

        [HttpGet]
        public string CCTV()
        {
            return "WelcomeCCTV";
        }

        //[HttpGet("id")]
        public void DeleteImage(int taskId)
        {


     
        }

    }
}