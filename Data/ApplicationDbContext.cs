using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlayerWeb.Models;

namespace PlayerWeb.Data;

public class ApplicationDbContext : IdentityDbContext <AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Bot> Bots{ get; set; }
}
