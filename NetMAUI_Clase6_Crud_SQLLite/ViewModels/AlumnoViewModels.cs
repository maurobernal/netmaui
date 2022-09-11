using System.ComponentModel.DataAnnotations;

using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;

namespace NetMAUI_Clase6_Crud_SQLLite.ViewModels;

public partial class AlumnoViewModels : ObservableValidator
{
    private readonly IAlumnos alumno_service;

    
    public ObservableCollection<string> Errores { get; set; }=new();

 
    private string apellido;

    [Required]
    [MaxLength(30)]
    public string Apellido
    {
        get => apellido;
        set => SetProperty(ref apellido, value, true);
    }

    [Required]
    [Range(0, 600000)]
    private int id;


   
    private string nombre;

    [Required]
    [MaxLength(30)]
    public string Nombre
    {
        get => nombre;
        set => SetProperty(ref apellido, value, true);
    }


    public AlumnoViewModels(IAlumnos alumno_service)
   => this.alumno_service = alumno_service;


    [RelayCommand]
    public async Task<string> GuardarAlumno(AlumnosModels A)
    {
        ValidateAllProperties();
       
        GetErrors(nameof(Nombre)).ToList().ForEach(f=> Errores.Add("Nombre:"+f.ErrorMessage));
        GetErrors(nameof(Apellido)).ToList().ForEach(f => Errores.Add("Apellido:"+f.ErrorMessage));
        return await Task.FromResult<string>("");
    }

}

