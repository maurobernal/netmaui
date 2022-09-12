using System.ComponentModel.DataAnnotations;

using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;

namespace NetMAUI_Clase6_Crud_SQLLite.ViewModels;

public partial class AlumnoViewModels : ObservableValidator
{
    private readonly IAlumnos alumno_service;

    
    public ObservableCollection<string> Errores { get; set; }=new();
    
    [ObservableProperty]
    private string resultado;

    [ObservableProperty]
   
    private bool isBusy;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsEnabled))]
    private bool isVisible;
     public bool IsEnabled =>!IsVisible;

    [ObservableProperty]
    private int id;




    private string apellido;
    

    [Required]
    [MaxLength(30)]
    public string Apellido
    {
        get => apellido;
        set => SetProperty(ref apellido, value, true);
    }




   
    private string nombre;

    [Required]
    [MaxLength(30)]
    public string Nombre
    {
        get => nombre;
        set => SetProperty(ref nombre, value, true);
    }


    public AlumnoViewModels(IAlumnos alumno_service)
   => this.alumno_service = alumno_service;


    [RelayCommand]
    public async Task GuardarAlumno(AlumnosModels A)
    {
        IsBusy = true;
        IsVisible = false;
        ValidateAllProperties();

        Errores.Clear();
        GetErrors(nameof(Nombre)).ToList().ForEach(f=> Errores.Add("Nombre:"+f.ErrorMessage));
        GetErrors(nameof(Apellido)).ToList().ForEach(f => Errores.Add("Apellido:"+f.ErrorMessage));
        IsBusy = false;
        if (Errores.Count > 0) return;


        IsBusy = true;
       Id=await alumno_service.InsertAlumno(new AlumnosModels() { Nombre = Nombre, Apellido = Apellido });

        Resultado = $" Se ha generado el registro {Id}";
        IsBusy = false;
        IsVisible = true;



    }

}

