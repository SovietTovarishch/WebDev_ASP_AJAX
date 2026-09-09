using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AjaxDemo.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }
    [BindProperty]
    public string Phone { get; set; }
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Speciality { get; set; }
    [BindProperty]
    public string Course { get; set; }
    [BindProperty]
    public string BirthDate { get; set; }
    [BindProperty]
    public string[] Technologies { get; set; } = Array.Empty<string>();
    public string Message { get; set; }
    public void OnGet() {
       // Message = "Привет! Сообщение от C#";
    }
    public void OnPost() {
        string technologies = Technologies.Length > 0 
            ? string.Join(", ", Technologies)
            : "Не выбраны";

        Message = $"Анкета студента\n\n" +
            $"Имя: {Name}\n" +
            $"Телефон: {Phone}\n" +
            $"Email: {Email}\n" +
            $"Специальность: {Speciality}\n" +
            $"Курс: {Course}\n" + 
            $"Дата Рождения: {BirthDate}\n" + 
            $"Технологии: {technologies}";
    }  
}
