using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    internal class Ambiente
    {
        public int IdAmbiente {  get; set;}
        public string NombreAmbiente { get; set;}
        public int CapacidadTotal { get; set;}


        //contructor de la clase ambiente
        public Ambiente(int id,string nombre, int capacidad)
        {
            //validar valores
            if (id <= 0)
                throw new ArgumentException("El id debe ser > 0");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del ambiente no puede estar vacio");
            if (capacidad <= 0)
                throw new ArgumentException("la capcidad debe ser >0");

        //Asignar Valores
        IdAmbiente = id;
        NombreAmbiente = nombre;
        CapacidadTotal = capacidad;



        }


    }
    
}
