using Microsoft.EntityFrameworkCore;
using TodoAPI.db;
using TodoAPI.models;


namespace TodoAPI.db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}