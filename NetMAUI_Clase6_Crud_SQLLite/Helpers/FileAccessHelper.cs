using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMAUI_Clase6_Crud_SQLLite.Helpers;
public class FileAccessHelper
{
    public static string GetPathFile(string File)
        => System.IO.Path.Combine(FileSystem.AppDataDirectory, File);

    public static string GetAppDirectory()
        => FileSystem.AppDataDirectory;

}
