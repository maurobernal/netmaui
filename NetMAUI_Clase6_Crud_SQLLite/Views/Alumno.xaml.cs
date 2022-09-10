namespace NetMAUI_Clase6_Crud_SQLLite.Views;

public partial class Alumno : ContentPage
{
	public Alumno(AlumnoViewModels vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}
