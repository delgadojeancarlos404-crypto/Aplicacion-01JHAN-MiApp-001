using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Mesa
    {
        public int IdMesa {  get; set; }
        public int NumeroMesa { get; set;}
        public int Capacidad { get; set;}
        public EstadoMesa Estado{ get; set; } 

    }
}
