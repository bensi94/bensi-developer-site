using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NET_backend.Models;

namespace ASP.NET_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly BoskarssonContext _context;

        public UserController(BoskarssonContext context) {
            _context = context;
        }

        [HttpGet]
        public ContentResult Get()
        {
            User user = _context.User.Find(1);
            return Content(user.Email);
        }
    }
}
