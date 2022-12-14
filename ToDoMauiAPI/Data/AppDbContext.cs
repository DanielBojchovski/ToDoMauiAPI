using Microsoft.EntityFrameworkCore;
using ToDoMauiAPI.Models;

namespace ToDoMauiAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}
