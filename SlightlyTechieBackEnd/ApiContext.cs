using SlightlyTechieBackEnd.Models;
using Microsoft.EntityFrameworkCore;
namespace SlightlyTechieBackEnd
{

    public class ApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "BlogDB");
        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
