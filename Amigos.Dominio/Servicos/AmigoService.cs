using System;
using System.Collections.Generic;
using System.Linq;
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

        List<Amigo> IAmigosService.proximos(int Id)
        {
            // var amigo = new Amigo();
            if (Id > 0)
            {
                List<Amigo> listaComDistancia = new List<Amigo>();
                var todosAmigos = _amigoRepositorio.GetAmigos();
                var amigoAtual = todosAmigos.Find(x => x.Id == Id);
                todosAmigos.Remove(amigoAtual);

                foreach (var item in todosAmigos)
                {
                    Amigo TempAmigo = new Amigo();
                    TempAmigo.Id = item.Id;
                    TempAmigo.Nome = item.Nome;
                    TempAmigo.CEP = item.CEP;
                    TempAmigo.Distancia = Distance(item.Latitude, item.Longitude, amigoAtual.Latitude, amigoAtual.Longitude);
                    listaComDistancia.Add(TempAmigo);
                }

                var proximos = listaComDistancia.OrderBy(x => x.Distancia).Take(3);
                return proximos.ToList();
            }
            else
            {
                return new List<Amigo>();
            }

        }

        public class Distancia
        {
            public double RadianosOrigem;
            public double RadianosDestino;
            public double RadianosTheta;
            public double Seno;
            public double Coseno;
            public double Angulo;
            public double Milhas;
            public double Kilometros;

        }

        public double Distance(double lat1, double lon1, double lat2, double lon2)
        {

            Distancia calculo = new Distancia();
            calculo.RadianosOrigem = Math.PI * lat1 / 180;
            calculo.RadianosDestino = Math.PI * lat2 / 180;
            calculo.RadianosTheta = Math.PI * (lon1 - lon2) / 180;

            calculo.Seno = Math.Sin(calculo.RadianosOrigem) * Math.Sin(calculo.RadianosDestino);
            calculo.Coseno = Math.Cos(calculo.RadianosOrigem) * Math.Cos(calculo.RadianosDestino) * Math.Cos(calculo.RadianosTheta);
            calculo.Angulo = Math.Acos(calculo.Seno + calculo.Coseno);
            calculo.Milhas = calculo.Angulo * 180 / Math.PI * 60 * 1.1515;
            var Kilometros = calculo.Milhas * 1.609344;

            return Kilometros;

        }

    }
}


