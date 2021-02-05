using FeedMe.WebClient;
using FeedMe.WebClient.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FeedMe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController()
        {
            _userService = new UserService();
        }

        // GET api/<UsersController>/5
        [HttpGet("{userName}")]
        public async Task<ActionResult> GetUser(string userName)
        {
            UserDto user = await _userService.GetUserByUserName(userName);
            return Ok(user);
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