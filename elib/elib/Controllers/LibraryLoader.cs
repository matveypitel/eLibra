using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using eLibra.Models;

namespace eLibra;

public static class LibraryLoader
{

    public static Library LoadLibrary(string fileName)
    {
        try
        {
            XmlSerializer serializer = new(typeof(Library));

            using (FileStream fileStream = new(fileName, FileMode.OpenOrCreate))
            {
                return (Library)serializer.Deserialize(fileStream);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка загрузки библиотеки: {ex.Message}");
        }
    }

    public static void SaveLibrary(Library library, string fileName)
    {
        try
        {
            XmlSerializer serializer = new(typeof(Library));

            using (FileStream fileStream = new(fileName, FileMode.Create))
            {
                serializer.Serialize(fileStream, library);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка сохранения библиотеки: {ex.Message}");
        }
    }
}
