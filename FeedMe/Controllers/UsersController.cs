using Microsoft.AspNetCore.Mvc;
using System;

namespace FeedMe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        // GET api/<UsersController>/5
        [HttpGet("{userName}")]
        public ActionResult GetUser(string userName)
        {
            throw new NotImplementedException();
        }

        // GET api/<UsersController>/5
        [HttpGet("{userName}/feeds/{id}")]
        public ActionResult GetFeeds(string userName, string id)
        {
            throw new NotImplementedException();
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }
    }
}