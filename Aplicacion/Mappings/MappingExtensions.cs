using Aplicacion.DTOs;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Mappings
{
    public static class MappingExtensions
    {
        // Convertir Entidad a DTO
        public static MesaDto ToDto(this Mesa mesa)
        {
            return new MesaDto
            {
                IdMesa = mesa.IdMesa,
                NumeroMesa = mesa.NumeroMesa,
                Capacidad = mesa.Capacidad

            };
        }
        //Convertir la lista de Entidades Mesa a la Lista de MesaDto
        public static List<MesaDto> ToDToList(this IEnumerable<Mesa> mesas)
        {
            //select es un metodo  de LINQ que proyecta cada elemento

            return mesas.Select(m => m.ToDto()).ToList();
        }

    }
}