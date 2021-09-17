using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;
using WebApp.Helpers;
using BCryptNet = BCrypt.Net.BCrypt;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sController : ControllerBase
    {
        private readonly DataContext context;

        public sController(DataContext context)
        {
            this.context = context;
        }



        [AllowAnonymous]
        [HttpGet]
        public IActionResult apr()
        {
                 // add hardcoded test user to db on startup
                var testUser = new User
                {
                    FirstName = "a",
                    LastName = "a",
                    Username = "a",
                    Role = "Admin",
                    PasswordHash = BCryptNet.HashPassword("a")
                };
                context.Users.Add(testUser);
                context.SaveChanges();            
            return Ok(User);

        }

    }
}
