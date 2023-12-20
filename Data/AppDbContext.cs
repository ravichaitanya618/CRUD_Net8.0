using Microsoft.EntityFrameworkCore;

namespace CRUD_Net8._0.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Model.Task> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
    }
}
