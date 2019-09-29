﻿using System;
using System.Collections.Generic;
using System.Text;
using ViaVarejo.Dominio.Entidades;

namespace ViaVarejo.Dominio.Servicos
{
    public interface IAmigosService
    {
        List<Amigo> GetAmigos();
        Amigo GetAmigoById(int Id);
        Amigo GetAmigoById(Amigo amigo);
        bool DeleteAmigo(Amigo amigo);
        bool InsertAmigo(Amigo _amigo);
        List<Amigo> GeProximos(Amigo amigo);
    }
}
