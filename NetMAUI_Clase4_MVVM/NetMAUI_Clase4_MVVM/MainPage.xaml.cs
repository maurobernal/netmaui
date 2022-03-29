using NetMAUI_Clase4_MVVM.ViewModel;
namespace NetMAUI_Clase4_MVVM;

public partial class MainPage : ContentPage
{
	private int contador=0;

	public MainPage(ContadorViewModel contadorViewModel)
	{
		InitializeComponent();
		BindingContext = contadorViewModel;

	}



   
}

