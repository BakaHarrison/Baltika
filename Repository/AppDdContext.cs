using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using testWeb.Model;

namespace WebApplication1.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Baltika> Beer { get; set; }
    }
}
