namespace AjaxDemo.Models;

public class Student
{

    public int Id { get; set; }
    public string Name { get; set; }  = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public string Speciality { get; set; } = "";
    public string Course { get; set; } = "";
    public string BirthDate { get; set; } = "";
    public string[] Technologies { get; set; } = Array.Empty<string>();
    public string City { get; set; } = "";
    public string MainLang { get; set; } = "";
    public string StudyForm { get; set; } = "";
    public string ExtraInfo { get; set; } = "";
} 