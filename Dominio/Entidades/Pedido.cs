using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
        public class Pedido
        {
            public int IdPedido { get; set; }
            public int IdMesa { get; set; }
            public int IdCliente { get; set; }
            public int? IdMesero { get; set; } // Nullable si un pedido puede no tener un mesero asignado inicialmente
            public DateTime FechaHoraCreacion { get; set; }
            public DateTime? FechaHoraModificacion { get; set; } // Nullable
            public string EstadoPedido { get; set; }
            public string NotasEspeciales { get; set; }
            public string TipoPedido { get; set; }
            public decimal TotalPedido { get; set; }
            public int? IdRepartidor { get; set; } // Nullable si la entrega no es inmediata o no existe
                                                   // Propiedades de navegación
       
        }
}
