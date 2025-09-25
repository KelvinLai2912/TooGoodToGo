using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SecurityDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options) { }
    }
}
