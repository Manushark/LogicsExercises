using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace LogicsExercises.Reto_12
{
    /*
     * IMPORTANTE: Sólo debes subir el fichero de código como parte del ejercicio.
     *
     * EJERCICIO:
     * Desarrolla un programa capaz de crear un archivo XML y JSON que guarde los
     * siguientes datos (haciendo uso de la sintaxis correcta en cada caso):
     * - Nombre
     * - Edad
     * - Fecha de nacimiento
     * - Listado de lenguajes de programación
     * Muestra el contenido de los archivos.
     * Borra los archivos.
     *
     * DIFICULTAD EXTRA (opcional):
     * Utilizando la lógica de creación de los archivos anteriores, crea un
     * programa capaz de leer y transformar en una misma clase custom de tu 
     * lenguaje los datos almacenados en el XML y el JSON.
     * Borra los archivos.
     */
    public static class Reto_12
    {

        public static void Run()
        {
            //Precursor precursor = new Precursor("Manuel", 50, 'R'); 
            //string myjson = JsonSerializer.Serialize(precursor);
            //string basepath = Directory.GetCurrentDirectory();
            //string Pathjson = Path.Combine(basepath, "C:\\C#\\LogicsExercises\\LogicsExercises\\Reto_12\\Precursores.json");//Dure 30 minutos aqui porque habia alvidado que necesitaba ponerle el nombre del archivo junto con la ubicacion del archivo
            //File.WriteAllText(Pathjson, myjson);

            string jason = File.ReadAllText("C:\\C#\\LogicsExercises\\LogicsExercises\\Reto_12\\Precursores.json");
            Precursor precursor1 = JsonSerializer.Deserialize<Precursor>(jason);
            Console.WriteLine(jason);
            Console.ReadKey();


            //string xmlPath = "user_data.xml";
            //string jsonPath = "user_data.json";
            //// Datos de ejemplo
            //var userData = new
            //{
            //    Nombre = "Juan Pérez",
            //    Edad = 30,
            //    FechaNacimiento = new DateTime(1993, 5, 15),
            //    LenguajesProgramacion = new List<string> { "C#", "JavaScript", "Python" }
            //};
            //// Crear XML
            //XElement xml = new XElement("Usuario",
            //    new XElement("Nombre", userData.Nombre),
            //    new XElement("Edad", userData.Edad),
            //    new XElement("FechaNacimiento", userData.FechaNacimiento.ToString("yyyy-MM-dd")),
            //    new XElement("LenguajesProgramacion",
            //        userData.LenguajesProgramacion.Select(lang => new XElement("Lenguaje", lang))
            //    )
            //);
            //xml.Save(xmlPath);
            //Console.WriteLine("Archivo XML creado:\n" + xml);
            //// Crear JSON
            //string json = JsonSerializer.Serialize(userData, new JsonSerializerOptions { WriteIndented = true });
            //File.WriteAllText(jsonPath, json);
            //Console.WriteLine("\nArchivo JSON creado:\n" + json);
            //// Borrar archivos
            //File.Delete(xmlPath);
            //File.Delete(jsonPath);
            //Console.WriteLine("\nArchivos XML y JSON borrados.");
        }

    }
}
