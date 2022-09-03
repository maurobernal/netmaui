using NetMAUI_Clase6_Crud_SQLLite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMAUI_Clase6_Crud_SQLLite.Services;

public class AlumnosServices : IAlumnos
{
    private readonly SQLLiteHelper<AlumnosModels> db;
    public AlumnosServices()
    =>
        db = new();

    public Task<List<AlumnosModels>> GetAll()
        =>
      Task.FromResult(db.GetAllData());



    public Task<AlumnosModels> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> InsertAlumno(AlumnosModels A)
    => Task.FromResult(db.Add(A));
    
}
