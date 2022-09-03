using System.Runtime.CompilerServices;

namespace NetMAUI_Clase6_Crud_SQLLite.Helpers;

public class SQLLiteHelper<T> where T :  new()
{
    private string _rutaDB;
    private SQLiteConnection _connection;
    public SQLLiteHelper()
    {
        _rutaDB = FileAccessHelper.GetPathFile("alumnos.db3"); ;
        if (_connection != null) return;
        _connection = new SQLiteConnection(_rutaDB);
        _connection.CreateTable<AlumnosModels>();
    }


    public List<T> GetAllData()
    => _connection.Table<T>().ToList();

    public int Add(T row)
    {
      var res=  _connection.Insert(row);
        return res;
    }
}
