using PlayerWeb.Data;
using PlayerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace PlayerWeb.Controllers;
public class ProfileController:Controller
{
    private UserManager<AppUser> _userManager;
    private SignInManager<AppUser> _signInManager;
    private readonly ApplicationDbContext _context;
    public ProfileController(ApplicationDbContext context,UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
    {
        _context = context;
        _userManager = userManager;
        _signInManager = signInManager;
    }
    public async Task<IActionResult> Index()
    {
        // IEnumerable<AppUser> allUser = _context.Users;
        var userId =_signInManager.Context.User.Claims.FirstOrDefault().Value;
        AppUser user = await _userManager.FindByIdAsync(userId);
        return View(user);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update([Bind("FirstName,LastName")] AppUser userUpdate)
    {
            if (ModelState.IsValid)
            {
                try
                {
                    var userId =_signInManager.Context.User.Claims.FirstOrDefault().Value;
                    AppUser user = await _userManager.FindByIdAsync(userId);
                    user.FirstName = userUpdate.FirstName;
                    user.LastName= userUpdate.LastName;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
    }
    
}