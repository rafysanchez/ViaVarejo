using System;
using System.Collections.Generic;
using System.Text;
using ViaVarejo.Dominio.Entidades;
using ViaVarejo.Dominio.Servicos;
using ViaVarejo.Repositorio.Data;

namespace ViaVarejo.Repositorio
{
    public class AmigoRepositorio : IAmigoRepositorio
    {
        private readonly AmigosContext _context;

        public AmigoRepositorio(AmigosContext context)
        {
            _context = context;
        }

        public bool DeleteAmigo(Amigo amigo)
        {
            _context.Amigos.Remove(amigo);
            _context.SaveChanges();
            return true;
        }

        public List<Amigo> GeProximos(Amigo amigo)
        {
            throw new NotImplementedException();
        }

        public Amigo GetAmigoById(Amigo amigo)
        {
            throw new NotImplementedException();
        }

        public List<Amigo> GetAmigos()
        {
            throw new NotImplementedException();
        }

        public bool InsertAmigo(Amigo _amigo)
        {
            _context.Amigos.Add(_amigo);
             _context.SaveChangesAsync();

            return true;
        }

    }
}
