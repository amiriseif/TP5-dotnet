using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tp5.Data;

[Authorize]
public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ApplicationDbContext _context;

    public AccountController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
    {
        _userManager = userManager;
        _context = context;
    }

    public async Task<IActionResult> UserManagement()
    {
        var users = await _userManager.Users.ToListAsync();
        return View(users);
    }

    public IActionResult PanierParUser()
    {
        var currentUserId = _userManager.GetUserId(User);
        var paniers = _context.Paniers
            .Where(c => c.UserID == currentUserId)
            .ToList();
        return View(paniers);
    }
}
