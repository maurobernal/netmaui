using NetMAUI_Clase6_Crud_SQLLite.ViewModels;
using Xamarin.Google.Crypto.Tink.Proto;

namespace NetMAUI_Clase6_Crud_SQLLite.Views;

public partial class ListadoAlumnos : ContentPage
{
	public ListadoAlumnos(AlumnosViewModels viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
	
}