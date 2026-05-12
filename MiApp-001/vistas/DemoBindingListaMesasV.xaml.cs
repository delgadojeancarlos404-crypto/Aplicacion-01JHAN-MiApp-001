using MiApp_001.VistaModelos;

namespace MiApp_001.vistas;

public partial class DemoBindingListaMesasV : ContentPage
{
	public DemoBindingListaMesasV()
	{
		InitializeComponent();
		BindingContext = new DemoMesasVM();
	}
}