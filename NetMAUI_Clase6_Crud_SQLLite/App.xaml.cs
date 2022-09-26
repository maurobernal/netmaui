using NetMAUI_Clase6_Crud_SQLLite.Services;

namespace NetMAUI_Clase6_Crud_SQLLite;

public partial class App : Application
{
    public new static App Current => (App)Application.Current;

    public IServiceProvider Services { get; }
    public App()
    {
        var services = new ServiceCollection();

        Services = ConfigureServices(services);

        InitializeComponent();

        MainPage = new AppShell();
    }

    private static IServiceProvider ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<IAlumnos, AlumnosServices>();

        //ViewModels
        services.AddTransient<AlumnosViewModels>();
        services.AddTransient<AlumnoViewModels>();

        //Views
        services.AddSingleton<ListadoAlumnos>();
        services.AddSingleton<Alumno>();

        //Services
        services.AddTransient<IAlumnos, AlumnosServices>();
        services.AddTransient<IDialogService, DialogService>();


        return services.BuildServiceProvider();
    }
}
