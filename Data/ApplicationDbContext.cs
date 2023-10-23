using Microsoft.EntityFrameworkCore;
using Upload.Models;

namespace Upload.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Upload.Models.Person> Person { get; set; } = default!;
    }
}