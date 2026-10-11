using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter10.DTO;

namespace WebAppStarter10.Pages.Students;

public class ViewStudentsModel : PageModel
{
    public List<StudentReadOnlyDTO> StudentsReadOnlyDTOs { get; set; } = [];
    public void OnGet()
    {
        string? lastname = Request.Query["lastname"];

        StudentsReadOnlyDTOs = string.IsNullOrEmpty(lastname)
            ? GetAllStudents()
            : [.. GetAllStudents().Where(s => s.Lastname == lastname)];
    }




    private List<StudentReadOnlyDTO> GetAllStudents()
    {
        return [
            new StudentReadOnlyDTO(1, "Georgios", "Alexandris"),
            new StudentReadOnlyDTO(2, "Georgia", "Alexandri"),
            new StudentReadOnlyDTO(3, "Geo", "Alex")
            ];

    }
}
