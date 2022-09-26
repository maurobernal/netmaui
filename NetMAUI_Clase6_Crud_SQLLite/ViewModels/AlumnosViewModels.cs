

namespace NetMAUI_Clase6_Crud_SQLLite.ViewModels;
public partial class AlumnosViewModels : ObservableObject
{
    private readonly IAlumnos _alumnosservice;

    public AlumnosViewModels()
    {
        _alumnosservice = App.Current.Services.GetService<IAlumnos>();
        
    }
    public ObservableCollection<AlumnosModels> Alumnos { get; set; } = new();


    [RelayCommand]
    public async Task ListarAlumnos()
    {
        Alumnos.Clear();
        var lista = await _alumnosservice.GetAll();
        foreach (var item in lista) Alumnos.Add(item);
    }


    [RelayCommand]
     public async Task EditarAlumno(AlumnosModels alumno)
    {
        var A = await _alumnosservice.GetById(1);
        //await _alumnosservice.DeleteAlumno(A);
    }

    [RelayCommand]
    public async Task EliminarAlumno( AlumnosModels alumno)
    {
        var A = await _alumnosservice.DeleteAlumno(alumno);
        await ListarAlumnos();

    }

    [RelayCommand]
    public async Task AddNew()
    {
        await Shell.Current.Navigation.PushAsync(new Alumno(), false);
    }


}
