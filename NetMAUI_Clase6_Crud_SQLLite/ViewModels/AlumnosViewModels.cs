namespace NetMAUI_Clase6_Crud_SQLLite.ViewModels;
public partial class AlumnosViewModels : ObservableObject
{
    private readonly IAlumnos _alumnosservice;
    private readonly IDialogService _dialog;
    public ObservableCollection<AlumnosModels> Alumnos { get; set; } = new();

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsReady))]
    private bool isLoading;

    [ObservableProperty]
    bool isRefreshing;
    public bool IsReady => !IsLoading;


    public AlumnosViewModels()
    {
        _alumnosservice = App.Current.Services.GetService<IAlumnos>();
        _dialog = App.Current.Services.GetService<IDialogService>();
        Task.Run(async () => await ListarAlumnos());

    }


    [RelayCommand]
    public async Task ListarAlumnos()
    {
        IsLoading = true;
        Alumnos.Clear();
        var lista = await _alumnosservice.GetAll();
        foreach (var item in lista) Alumnos.Add(item);
        IsLoading = false;
        IsRefreshing = false;
    }


    [RelayCommand]
    public async Task EditarAlumno(AlumnosModels alumno)
    {

        await Shell.Current.GoToAsync($"/Alumno?Id={alumno.Id}&Nombre={alumno.Nombre}&Apellido={alumno.Apellido}", false);

    }

    [RelayCommand]
    public async Task EliminarAlumno(AlumnosModels alumno)
    {

        IsLoading = true;
        var res = await _dialog.ShowAlertAsync("Eliminar", $"Desea eliminiar el registro {alumno.Id}", "Aceptar", "Cancelar");
        if (!res) return;
        var A = await _alumnosservice.DeleteAlumno(alumno);
        await ListarAlumnos();

    }

    [RelayCommand]
    public async Task AddNew()
    {

        await Shell.Current.Navigation.PushAsync(new Alumno(), false);
    }


}
