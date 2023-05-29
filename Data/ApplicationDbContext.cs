using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NIC_PROJECT.Models;

namespace NIC_PROJECT.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<People> People { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
