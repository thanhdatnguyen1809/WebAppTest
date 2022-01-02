using Microsoft.EntityFrameworkCore;
using WebAppTest.Models;

namespace WebAppTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
