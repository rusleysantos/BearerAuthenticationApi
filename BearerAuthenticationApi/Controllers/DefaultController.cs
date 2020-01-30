using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BearerAuthenticationApi.Controllers
{
    [Route("api")]
    public class DefaultController : Controller
    {
        [Route("testefumaca")]
        public IActionResult Index()
        {
            return Ok("foi");
        }
    }
}