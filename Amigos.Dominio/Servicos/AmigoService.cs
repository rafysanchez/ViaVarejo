using System;
using System.Collections.Generic;
using System.Text;
using ViaVarejo.Dominio.Entidades;

namespace ViaVarejo.Dominio.Servicos
{

    public class AmigoService : IAmigosService
    {
        private readonly IAmigoRepositorio _amigoRepositorio;
        public AmigoService(IAmigoRepositorio amigoRepositorio)
        {
            _amigoRepositorio = amigoRepositorio;
        }
        public bool DeleteAmigo(Amigo amigo)
        {
            return _amigoRepositorio.DeleteAmigo(amigo);
        }

        public List<Amigo> GeProximos(Amigo amigo)
        {
            return _amigoRepositorio.GeProximos(amigo);
        }

        public Amigo GetAmigoById(Amigo amigo)
        {
            return _amigoRepositorio.GetAmigoById(amigo);
        }

        public Amigo GetAmigoById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Amigo> GetAmigos()
        {
            return _amigoRepositorio.GetAmigos();
        }

        public bool InsertAmigo(Amigo _amigo)
        {
            return _amigoRepositorio.InsertAmigo(_amigo);
        }


    }
}


