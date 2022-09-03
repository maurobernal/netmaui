namespace NetMAUI_Clase6_Crud_SQLLite.Views;

public partial class ListadoAlumnos : ContentPage
{
	public ListadoAlumnos(AlumnosViewModels viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}

    void OnSwiped(System.Object sender, Microsoft.Maui.Controls.SwipedEventArgs e)
    {
    }
}