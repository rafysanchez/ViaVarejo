using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AmigosAPI.Models
{
    public class AmigosAPIContext : IdentityDbContext
    {
        public AmigosAPIContext (DbContextOptions<AmigosAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
