using System.Collections.ObjectModel;
using System.Windows.Input;
using Dominio.Entidades;
using Microsoft.Maui.Controls;

namespace MiApp_001.viewmodels
{
    public class MesaListViewModel : BindableObject
    {
        public ObservableCollection<Mesa> Mesas { get; } = new ObservableCollection<Mesa>();

        public ICommand VerTodosCommand { get; }
        public ICommand VerLibresCommand { get; }
        public ICommand VerOcupadasCommand { get; }
        public ICommand VerReservadasCommand { get; }

        private readonly List<Mesa> allMesas = new List<Mesa>();

        public MesaListViewModel()
        {
            // comandos simples
            VerTodosCommand = new Command(() => CargarFiltro(null));
            VerLibresCommand = new Command(() => CargarFiltro("Libre"));
            VerOcupadasCommand = new Command(() => CargarFiltro("Ocupada"));
            VerReservadasCommand = new Command(() => CargarFiltro("Reservada"));

            // datos de ejemplo
            var libre = new EstadoMesa(1, "Libre", "#10B981");
            var ocupada = new EstadoMesa(2, "Ocupada", "#EF4444");
            var reservada = new EstadoMesa(3, "Reservada", "#F59E0B");

            allMesas.Add(new Mesa { IdMesa = 1, NumeroMesa = 1, Capacidad = 4, Estado = libre });
            allMesas.Add(new Mesa { IdMesa = 2, NumeroMesa = 2, Capacidad = 2, Estado = ocupada });
            allMesas.Add(new Mesa { IdMesa = 3, NumeroMesa = 3, Capacidad = 6, Estado = reservada });
            allMesas.Add(new Mesa { IdMesa = 4, NumeroMesa = 4, Capacidad = 8, Estado = libre });

            CargarFiltro(null);
        }

        private void CargarFiltro(string? estado)
        {
            Mesas.Clear();
            foreach (var m in allMesas)
            {
                if (estado == null || m.Estado?.NombreEstado == estado)
                    Mesas.Add(m);
            }
        }
    }
}