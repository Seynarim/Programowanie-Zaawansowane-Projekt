using Microsoft.EntityFrameworkCore;

namespace Programowanie_Zaawansowane_Projekt.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
