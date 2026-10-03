using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class StudentFormModel : PageModel
{
    [BindProperty]
    public string Name { get; set; } = "";

    [BindProperty]
    public int Age { get; set; }

    public bool IsSubmitted { get; set; }

    public void OnGet()
    {
        
    }
    public void OnPost()
    {
        IsSubmitted = true;
    }

}