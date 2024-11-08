using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebSite.Data;
using MyWebSite.Models;

namespace MyWebSite.Controllers;

public class ProductController : Controller
{
    private readonly AppDbContext _context;
    
    private readonly IConfiguration _configuration;

    public ProductController(AppDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
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
    
    
    
    

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var products = await _context.Products.ToListAsync(); // Ensure this is IQueryable or DbSet
        return View();
    }
    
    
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
    




    
    
    
    
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var product = await _context.Products
            .FirstOrDefaultAsync(m => m.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        return View(product);

    }
    
    
    [HttpPost]
    public IActionResult Edit(ProductModel product)
    {
        // Find the product in the database
        var existingProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);
    
        if (existingProduct != null)
        {
            // Update the product fields
            existingProduct.ProductName = product.ProductName;
            existingProduct.ShortDesc = product.ShortDesc;
            existingProduct.Demention = product.Demention;
            existingProduct.Weight = product.Weight;
            existingProduct.IsFavorite = product.IsFavorite;
            existingProduct.Price = product.Price;

            // Save changes to the database
            _context.SaveChanges();
        }

        return RedirectToAction("Index"); // Redirect back to the product list page
    }
    
    [HttpPost]
    public IActionResult SaveAll(List<ProductModel> Products)
    {
        foreach (var product in Products)
        {
            var existingProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                // Update the existing product with new values
                existingProduct.ProductName = product.ProductName;
                existingProduct.ShortDesc = product.ShortDesc;
                existingProduct.FullDesc = product.FullDesc;
                existingProduct.Demention = product.Demention;
                existingProduct.Weight = product.Weight;
                existingProduct.IsFavorite = product.IsFavorite;
                existingProduct.Price = product.Price;

                // Save changes to the database
                _context.SaveChanges();
            }
        }
        return RedirectToAction("Index");
    }



}