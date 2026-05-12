using Aplicacion.DTOs;
using Aplicacion.Interfaces;
using Aplicacion.Mappings;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.CasosDeUsos
{
    public class ObtenerMesasCU
    {
        //Inyeccion de dependencias para el repositorio de mesas
        private readonly IRepository<Mesa> _mesaRepository;

        //2. Constructor para inyectar el repositorio de mesas a través de la interfaz genérica IRepository<Mesa>
        public ObtenerMesasCU(IRepository<Mesa> mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }
        //3. Método para obtener todas las mesas utilizando el repositorio
        public async Task<List<MesaDto>> ExecuteAsync()
        {
            // Obtener todas las mesas
            var mesas = await _mesaRepository.GetAllAsync();

            // Mapear entidades a DTOs
            return mesas.ToDToList();
        }
    }
}
