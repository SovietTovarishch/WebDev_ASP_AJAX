using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AjaxDemo.Models;

namespace AjaxDemo.Pages;

public class EditResumeModel : PageModel {
    [BindProperty]
    public Student Resume { get; set; } = new();
    public string TechnologiesText { get; set; } = "";
    public IActionResult OnGet(int id) 
    {
        var student = CreateResumeModel.Students
        .FirstOrDefault(s => s.Id == id);

        if (student == null) {
            return NotFound();
        }

        Resume = new Student
        {
            Id = student.Id,
            Name = student.Name,
            Phone = student.Phone,
            Email = student.Email,
            Speciality = student.Speciality,
            Course = student.Course,
            BirthDate = student.BirthDate,
            Technologies = student.Technologies.ToArray(),
            City = student.City,
            MainLang = student.MainLang,
            StudyForm = student.StudyForm,
            ExtraInfo = student.ExtraInfo
        };
        TechnologiesText = string.Join(" ", student.Technologies);
        return Page();
    }

    public IActionResult OnPost() {
        var student = CreateResumeModel.Students
        .FirstOrDefault(s => s.Id == Resume.Id);
        if (student == null) {
            return NotFound();
        }

        student.Name = Resume.Name;
        student.Phone = Resume.Phone;
        student.Email = Resume.Email;
        student.Speciality = Resume.Speciality;
        student.Course = Resume.Course;
        student.BirthDate = Resume.BirthDate;
        //student.Technologies = Resume.Technologies ?? Array.Empty<string>();
        student.Technologies = TechnologiesText
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(technology => technology.Trim())
        .Where(technology => technology.Length > 0)
        .ToArray();
        student.City = Resume.City;
        student.MainLang = Resume.MainLang;
        student.StudyForm = Resume.StudyForm;
        student.ExtraInfo = Resume.ExtraInfo;

        return RedirectToPage("/Resume", new { id = student.Id });
    }
}