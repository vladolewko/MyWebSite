using Microsoft.EntityFrameworkCore;
using MyWebSite.Models;
namespace MyWebSite.Data;

public class AppDbContext: DbContext
{
    public AppDbContext()
    {
        
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<ProductModel> Products { get; set; }
    public DbSet<UserModel> Users { get; set; }

}