using NetMAUI_Clase4_MVVM.ViewModel;

namespace NetMAUI_Clase4_MVVM;

public partial class App : Application
{
	public App(ContadorViewModel contadorViewModel)
	{
		InitializeComponent();

		MainPage = new MainPage(contadorViewModel);
	}
}
