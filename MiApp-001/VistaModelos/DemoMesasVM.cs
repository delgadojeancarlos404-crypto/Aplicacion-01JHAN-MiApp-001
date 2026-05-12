using Aplicacion.DTOs;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MiApp_001.VistaModelos
{
    public partial class DemoMesasVM : ObservableObject
    {
        [ObservableProperty]
        public partial ObservableCollection<string> ListaDeMesas { get; set; }

        [RelayCommand]
        private void CargarMesas()
        {
          //simular carga de datos
            ListaDeMesas = new ObservableCollection<string>
            {
                "Mesa #1 - Capacidad 2 -Libre",
                "Mesa #2 - Capacidad 4 - Ocupada",
                "Mesa #3 - Capacidad 6 - Reservada"
            };
        }

        [ObservableProperty]
        private  ObservableCollection<MesaDto> listaDeMesasDTO = new();

        [RelayCommand]
        private void CargarMesasDTO()
        {
            ListaDeMesasDTO = new ObservableCollection<MesaDto>
               {
                   new MesaDto{IdMesa=1, NumeroMesa=1, Capacidad=2, EstadoId=1,EstadoMesa="Libre", NombreColor="DarkGreen" },
                   new MesaDto{IdMesa=2, NumeroMesa=2, Capacidad=4, EstadoId=2,EstadoMesa="Ocupada", NombreColor="red"},
                   new MesaDto{IdMesa=3, NumeroMesa=3, Capacidad=6, EstadoId=3,EstadoMesa="Reservada", NombreColor="DarkOgrange"}

                };
            
            

        }
        public DemoMesasVM()
        {
            ListaDeMesas = new ObservableCollection<string>();
        }
    }
}
