using AngularProject.DB.Entities;
using FoodNetwork.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodNetwork.Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserManagementController : ControllerBase
    {
        public UserManagementController() { }

        [Route("create")]
        [HttpPost]
        public IActionResult CreateUser([FromBody] User userModel)
        {
            //var user = new UserServices().CreateUser(userModel);

            var response = new User
            {
                FirstName = "Pesho",
                LastName = "Ivanov"
            };

            return Ok(response);
        }
    }
}
