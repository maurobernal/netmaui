namespace NetMAUI_Clase6_Crud_SQLLite.Interfaces;

public interface IAlumnos
{
    public Task<List<AlumnosModels>> GetAll();
    public Task<AlumnosModels> GetById(int id);
    public Task<int> InsertAlumno(AlumnosModels A);
    public Task<int> DeleteAlumno(AlumnosModels A);
    public Task<int> UpdateAlumno(AlumnosModels A);

}

