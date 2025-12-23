using Microsoft.EntityFrameworkCore;
using TaskManagerSqliteMvc.Models;

namespace TaskManagerSqliteMvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks => Set<TaskItem>();
    }
}
