using Microsoft.AspNetCore.Mvc;

namespace FitnessCenter.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
