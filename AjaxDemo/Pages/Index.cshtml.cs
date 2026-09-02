using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AjaxDemo.Pages;

public class IndexModel : PageModel
{
    public JsonResult OnGetHello(string name, int age, string city, string profession, string experience) {
        return new JsonResult(new
        {
            message = $"Привет, {name}! Возраст {age} лет, город {city}, профессия {profession}, стаж {experience} лет."
        });
    }
}
