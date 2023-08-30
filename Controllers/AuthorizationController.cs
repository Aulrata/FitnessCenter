using Microsoft.AspNetCore.Mvc;

namespace FitnessCenter.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn()
        {

            return Ok();
        }
    }
}
