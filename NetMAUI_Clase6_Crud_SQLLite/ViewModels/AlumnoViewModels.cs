namespace NetMAUI_Clase6_Crud_SQLLite.ViewModels;

public partial class AlumnoViewModels : ObservableValidator
{
    private readonly IAlumnos _alumno;
    [ObservableProperty]
    private AlumnosModels alumno;

    public AlumnoViewModels(IAlumnos alumno)
    {
        _alumno = alumno;
    }

    [RelayCommand]
    public async Task<string> GuardarAlumno(AlumnosModels A)
    {

        return await Task.FromResult<string>("");
    }

}

