using Microsoft.AspNetCore.Mvc;

public class StudentController: Controller
{
    private readonly MyDbContext _context;

    public StudentController(MyDbContext context)
    {
        _context = context;
    }

    public IActionResult Index ()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Student student)
    {
        _context.Add(student);
        _context.SaveChanges();
        ViewBag.message = "Create completed!";
        return View();
    }
}