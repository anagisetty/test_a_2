using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_a_2.Models;

namespace test_a_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        // POST: api/Signup
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            try
            {
                // TODO: Add insert logic here
                if (user != null)
                {
                    UserDataAccessLayer objuser = new UserDataAccessLayer();
                    objuser.AddUser(user);
                    return Ok("User Added successfully");
                }
                else
                {
                    return BadRequest("User object is null");
                }
            }
            catch
            {
                return BadRequest("Error while creating user");
            }
        }
    }
}