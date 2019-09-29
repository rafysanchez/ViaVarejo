using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ViaVarejo.Dominio.Entidades;

namespace ViaVarejo.Repositorio.Data
{
    public class AmigosContext : IdentityDbContext
    {
        public AmigosContext(DbContextOptions<AmigosContext> options)
            : base(options)
        {
        }

        public DbSet<Amigo> Amigos { get; set; }
    }
}
