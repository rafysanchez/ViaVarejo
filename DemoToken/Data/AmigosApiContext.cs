using AmigosAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ViaVarejo.Dominio.Entidades;

namespace AmigosApi.Data
{
    public class AmigosAPIContext : IdentityDbContext
    {
        public AmigosAPIContext(DbContextOptions<AmigosAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
    }
}
