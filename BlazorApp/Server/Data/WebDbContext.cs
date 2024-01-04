using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Data
{
    public class WebDbContext:DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options) { }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
    }
}
