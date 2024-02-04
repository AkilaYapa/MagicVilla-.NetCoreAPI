using MagicVilla_Simple_.NET_API_project.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_Simple_.NET_API_project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public DbSet<Villa> Villas { get; set; }
    }
}
