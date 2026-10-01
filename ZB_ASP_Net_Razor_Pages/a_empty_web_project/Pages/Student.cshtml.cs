using Microsoft.AspNetCore.Mvc.RazorPages;

public class StudentModel : PageModel
{
    public string Name { get; set; } = "Ram";
    public int Age { get; set; } = 27;
    public string Course { get; set; } = "ICTED";
}