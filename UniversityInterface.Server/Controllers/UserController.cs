using UniversityInterface.Server.Models;
using Microsoft.AspNetCore.Mvc;
using DAL;

namespace UniversityInterface.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get() 
        {
            List<User> user_list = new List<User>();

            user_list = new UserDataAccess(_configuration.GetConnectionString("DefaultConnection")).getUsers();


            return user_list;
        }
    }
}
