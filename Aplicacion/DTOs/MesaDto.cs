using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.DTOs
{
    public class MesaDto
    {
        public int IdMesa { get; set; }
        public int NumeroMesa { get; set; }
        public int Capacidad {  get; set; }
        public int EstadoId { get; set; }
        public string EstadoMesa { get; set; } = string.Empty;
        public string NombreColor { get; set; } = string.Empty;
        public string InformacionAdicional {  get; set; } = string.Empty;
    }
}
