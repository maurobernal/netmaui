namespace NetMAUI_Clase6_Crud_SQLLite.Models;

[Table("alumnos")]
public class AlumnosModels
{

    [PrimaryKey,AutoIncrement]
    public int  Id { get; set; }

    [MaxLength(30)]
    public string Nombre { get; set; } = "";

    [MaxLength(30)]
    public string Apellido { get; set; } = "";
    
    public override string ToString() =>
    $"Id:{Id} - {Nombre} {Apellido}";
    
}
