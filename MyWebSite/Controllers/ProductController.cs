using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyWebSite.Data;
using MyWebSite.Models;
public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.ToListAsync(); // Ensure this is IQueryable or DbSet
        return View(products);
    }
    public async Task<IActionResult> Edit()
    {
        var products = await _context.Products.ToListAsync(); // Ensure this is IQueryable or DbSet
        return View(products);
    }
    
    
    public async Task<IActionResult> Delete(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
    
    
    
    
    // GET: Products/Create
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var products = await _context.Products.ToListAsync(); // Ensure this is IQueryable or DbSet
        return View();
    }

    // POST: Products/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ProductModel product)
    {
        if (ModelState.IsValid)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(product);
    }
}

