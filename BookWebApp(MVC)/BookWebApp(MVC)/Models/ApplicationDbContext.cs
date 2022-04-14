using Microsoft.EntityFrameworkCore;

namespace BookWebApp_MVC_.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        //For Book Model Create
        public DbSet<Book> Books { get; set; }
    }
}
