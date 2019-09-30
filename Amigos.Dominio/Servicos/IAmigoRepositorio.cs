using System;
using System.Collections.Generic;
using System.Text;
using ViaVarejo.Dominio.Entidades;

namespace ViaVarejo.Dominio.Servicos
{
   public  interface IAmigoRepositorio
    {
        List<Amigo> GetAmigos();

        Amigo GetAmigoById(Amigo amigo);

        bool DeleteAmigo(Amigo amigo);

        bool InsertAmigo(Amigo _amigo);

       
    }
}
