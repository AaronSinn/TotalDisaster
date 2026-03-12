using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { } 
    public DbSet<DLC> DLCs { get; set; }

}