using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class EstadoMesa
    {
        public int IdEstadoMesa {  get; set;}
        public string NombreEstado {  get; set;}
        public string ColorVisual {  get; set;}

        //constructor de la clase estadomesa
        public EstadoMesa(int id,string nombre, string colorvisual)
        {
            if (id <= 0)
                throw new ArgumentException("El id debe ser >0");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Elnombre no puede estar vacio");
            if (string.IsNullOrWhiteSpace(colorvisual))
                throw new ArgumentException("El color no puede estar vacio");

            //Asignacion de valores a los atributos de la clase
            IdEstadoMesa = id;
            NombreEstado = nombre;
            colorvisual = colorvisual;
        }
    }
}
