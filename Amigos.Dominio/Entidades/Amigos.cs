﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ViaVarejo.Dominio.Entidades
{
   public  class Amigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Distancia { get; set; }
    }
}
