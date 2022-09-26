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
    => db = new();

    public Task<int> DeleteAlumno(AlumnosModels A)
     => Task.FromResult(db.Delete(A));

    public Task<List<AlumnosModels>> GetAll()
     => Task.FromResult(db.GetAllData());

    public Task<AlumnosModels> GetById(int id)
    => Task.FromResult(db.Get(id));

    public Task<int> InsertAlumno(AlumnosModels A)
   => Task.FromResult(db.Add(A));
    

    public Task<int> UpdateAlumno(AlumnosModels A)
    => Task.FromResult(db.Update(A));

}
