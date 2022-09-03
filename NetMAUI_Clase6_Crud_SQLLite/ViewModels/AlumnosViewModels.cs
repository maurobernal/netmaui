using CommunityToolkit.Mvvm.Input;
using NetMAUI_Clase6_Crud_SQLLite.Interfaces;
using System.Collections.ObjectModel;

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


       var lista= await _alumnosservice.GetAll();
        foreach (var item in lista)
        {
            Alumnos.Add(item);
        }



    }



}
