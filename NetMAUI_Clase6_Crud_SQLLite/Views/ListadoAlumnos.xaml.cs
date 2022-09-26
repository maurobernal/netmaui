namespace NetMAUI_Clase6_Crud_SQLLite.Views;

public partial class ListadoAlumnos : ContentPage
{
	public ListadoAlumnos()
	{
		InitializeComponent();
		BindingContext = App.Current.Services.GetService<AlumnosViewModels>();
	}

    
}