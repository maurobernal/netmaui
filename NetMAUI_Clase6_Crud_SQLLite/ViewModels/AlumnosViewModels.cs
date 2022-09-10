

namespace NetMAUI_Clase6_Crud_SQLLite.ViewModels;
public partial class AlumnosViewModels : ObservableObject
{
    private readonly IAlumnos _alumnosservice;

    public AlumnosViewModels(IAlumnos alumnos)
    {
        _alumnosservice = alumnos;
    }
    public ObservableCollection<AlumnosModels> Alumnos { get; set; } = new();


    [RelayCommand]
    public async Task ListarAlumnos()
    {
        Alumnos.Clear();
        //Conexión base de datos
        await _alumnosservice.InsertAlumno(new AlumnosModels { Apellido = "Bernal", Nombre = "Mauro" });


        var lista = await _alumnosservice.GetAll();
        foreach (var item in lista) Alumnos.Add(item);




    }


    [RelayCommand]
    public async Task ListarAlumnos2()
    {
        var A = await _alumnosservice.GetById(1);
        await _alumnosservice.DeleteAlumno(A);


    }

    [RelayCommand]
     async Task EliminarAlumno(AlumnosModels Alumno)
    {
        var A = await _alumnosservice.GetById(1);
        await _alumnosservice.DeleteAlumno(A);


    }

    [RelayCommand]
     async Task EditarAlumno()
    {
        var A = await _alumnosservice.GetById(1);
        //await _alumnosservice.DeleteAlumno(A);


    }



}
