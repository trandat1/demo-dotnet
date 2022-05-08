using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    private readonly MyDbContext _context;

    public ProductController(MyDbContext context)
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
    public IActionResult Create(Product product)
    {
        _context.Add(product);
        _context.SaveChanges();
        ViewBag.message = "Create completed!";
        return View();
    }
}