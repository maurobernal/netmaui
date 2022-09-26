namespace NetMAUI_Clase6_Crud_SQLLite.Views.Templates;

public partial class ItemsAlumnos : ContentView
{
	private readonly AlumnosViewModels viewmodel;
	public ItemsAlumnos()
	{
		try
		{

		

		viewmodel = App.Current.Services.GetService<AlumnosViewModels>();
            InitializeComponent();
          //  BindingContext = viewmodel;

        }
        catch (Exception ex)
        {

            throw ex;
        }
        
	}
}