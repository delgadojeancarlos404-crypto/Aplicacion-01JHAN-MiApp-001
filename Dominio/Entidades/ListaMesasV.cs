using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    internal class ListaMesasV { }
       
        public class ListaMesaV
        {
            public int Id { get; set; }
            public string NombreEstado { get; set; }
            public string ColorVisual { get; set; }

            /// <summary>
            /// Constructor de la clase ListaMesaV.
            /// </summary>
            /// <param name="id">El identificador único de la mesa. Debe ser mayor que 0.</param>
            /// <param name="nombreEstado">El estado de la mesa. No puede ser nulo o vacío.</param>
            /// <param name="colorVisual">El color visual de la mesa. No puede ser nulo o vacío.</param>
            /// <exception cref="ArgumentException">Se lanza si los parámetros de entrada no son válidos.</exception>
            public ListaMesaV(int id, string nombreEstado, string colorVisual)
            {
                // Validar valores de entrada
                if (id <= 0)
                {
                    throw new ArgumentException("El Id debe ser un número positivo.");
                }
                if (string.IsNullOrWhiteSpace(nombreEstado))
                {
                    throw new ArgumentException("El NombreEstado no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(colorVisual))
                {
                    throw new ArgumentException("El ColorVisual no puede estar vacío.");
                }

                // Asignar valores a las propiedades
                Id = id;
                NombreEstado = nombreEstado;
                ColorVisual = colorVisual;
            }


        }
    }
