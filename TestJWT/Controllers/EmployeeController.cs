using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestJWT.Model;

namespace TestJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticated with JWT";
        }

        [HttpGet]
        [Route("GetDetails")]
        public string GetDetails()
        {
            return "Authenticated with JWT";
        }
        [Authorize]
        [HttpPost]
        public string AddData(Users user)
        {
            return "USer Added with Username " + user.Username;
        }
        
        
    }
}
