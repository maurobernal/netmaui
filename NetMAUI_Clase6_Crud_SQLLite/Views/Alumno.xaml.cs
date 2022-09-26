namespace NetMAUI_Clase6_Crud_SQLLite.Views;

public partial class Alumno : ContentPage
{
	public Alumno()
	{
		BindingContext = App.Current.Services.GetService<AlumnoViewModels>();
		InitializeComponent();

	}
}
