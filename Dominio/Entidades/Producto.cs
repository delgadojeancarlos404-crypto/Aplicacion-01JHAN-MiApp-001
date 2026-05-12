using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    
        public class Producto
        {
            public int IdProducto { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public string Categoria { get; set; }
            public bool Disponible { get; set; }
            public string Ingredientes { get; set; } // Asumiendo que "innradianter" es Ingredientes
                                                     // Propiedad de navegación
        }
    }

