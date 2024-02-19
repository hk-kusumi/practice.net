using Microsoft.EntityFrameworkCore;

namespace StudentCrudManagemant.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        } 


        public DbSet<Models.Student> Students { get; set; }
    }


}
