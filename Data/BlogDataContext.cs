using Microsoft.EntityFrameworkCore;
using Blog.Models;
using Blog.Data.Mappings;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        private const string connString = "Server=.\\SQLEXPRESS;Database=Blog;Integrated Security=SSPI;TrustServerCertificate=True";

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(connString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}