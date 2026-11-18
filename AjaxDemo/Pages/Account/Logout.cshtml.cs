using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AjaxDemo.Pages.Account;

public class LogoutModel : PageModel
{
    private readonly SignInManager<Models.ApplicationUser> _signInManager;
    public LogoutModel(
        SignInManager<Models.ApplicationUser> signInManager)
    {
        _signInManager = signInManager;
    }
    public async Task<IActionResult> OnGetAsync()
    {
        await _signInManager.SignOutAsync();
        return RedirectToPage("/Index");
    }
}