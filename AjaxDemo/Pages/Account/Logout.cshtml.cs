using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AjaxDemo.Models;

namespace AjaxDemo.Pages.Account;

public class LogoutModel : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    public LogoutModel(
        SignInManager<ApplicationUser> signInManager)
    {
        _signInManager = signInManager;
    }
    // public IActionResult OnGet()
    // {
    //     return RedirectToPage("/Index"); 
    // }
    public void onGet()
    {
    }
    public async Task<IActionResult> OnPostAsync()
    {
        await _signInManager.SignOutAsync();
        return RedirectToPage("/Index");
    }
}