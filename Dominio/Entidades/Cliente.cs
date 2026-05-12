using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    
        // Tb_Cliente
        public class Cliente
        {
            public int IdCliente { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Preferencias { get; set; }
            // Propiedad de navegación
            public ICollection<Pedido> Pedidos { get; set; }
        }
 
    }

