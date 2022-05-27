using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
 
namespace PlayerWeb.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        //...
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}