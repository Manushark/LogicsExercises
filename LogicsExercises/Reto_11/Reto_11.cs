using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.FileIO;

namespace LogicsExercises.Reto_11
{
    public class Reto_11
    {
        /*
         * IMPORTANTE: Sólo debes subir el fichero de código como parte del ejercicio.
         *
         * EJERCICIO:
         * Desarrolla un programa capaz de crear un archivo que se llame como
         * tu usuario de GitHub y tenga la extensión .txt.
         * Añade varias líneas en ese fichero:
         * - Tu nombre.
         * - Edad.
         * - Lenguaje de programación favorito.
         * Imprime el contenido.
         * Borra el fichero.
         *
         * DIFICULTAD EXTRA (opcional):
         * Desarrolla un programa de gestión de ventas que almacena sus datos en un 
         * archivo .txt.
         * - Cada producto se guarda en una línea del archivo de la siguiente manera:
         *   [nombre_producto], [cantidad_vendida], [precio].
         * - Siguiendo ese formato, y mediante terminal, debe permitir añadir, consultar,
         *   actualizar, eliminar productos y salir.
         * - También debe poseer opciones para calcular la venta total y por producto.
         * - La opción salir borra el .txt.
         */

        public static void Run()
        {
            string path = "C:\\Users\\manue\\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\\Datos adjuntos\\Manushark.txt";

            // Crear y escribir en el archivo
            using (TextWriter archivo = new StreamWriter(path))
            {
                archivo.WriteLine("Me llamo Manuel Rivas");
                archivo.WriteLine("Tengo 21 años de edad");
                archivo.WriteLine("Mi lenguaje de programación favorito es C#");

                Console.WriteLine("Escribe una línea extra para añadir al archivo:");
                string lineaExtra = Console.ReadLine();
                archivo.WriteLine(lineaExtra);
            }

            // Leer e imprimir el contenido del archivo
            string contenido = File.ReadAllText(path);
            Console.WriteLine("Esto es lo que dice el archivo:\n");
            Console.WriteLine(contenido);

            // Borrar el archivo
            File.Delete(path);
            Console.WriteLine("\nArchivo eliminado correctamente.");

            //verificar si el archivo existe
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("El archivo existe.");
            //}

            //Borrar el contenido del archivo sin eliminarlo
            //File.WriteAllText("C:\\Users\\Manuel\\Desktop\\Manushark.txt", string.Empty);


        }

        //DIFICULTAD EXTRA
        //Desarrolla un programa de gestión de ventas que almacena sus datos en un
        //* archivo.txt.
        // * - Cada producto se guarda en una línea del archivo de la siguiente manera:
        // *   [nombre_producto], [cantidad_vendida], [precio].
        // * - Siguiendo ese formato, y mediante terminal, debe permitir añadir, consultar,

        //* actualizar, eliminar productos y salir.
        // * - También debe poseer opciones para calcular la venta total y por producto.
        // * - La opción salir borra el.txt.

        public static void Sales() {
          
            bool exit = true;
            while (exit)
            {
                Console.WriteLine($"Bienvenido a la agenda de venta");
                Console.WriteLine($"1. Añadir venta");
                Console.WriteLine($"2. Buscar venta");
                Console.WriteLine($"3. Mostrar venta");
                Console.WriteLine($"4. Actualizar venta");
                Console.WriteLine($"5. Eliminar archivo de ventas");
                Console.WriteLine($"6. Salir");
                Console.Write($"Seleccione una opción: ");
               
                if (int.TryParse(Console.ReadLine(), out int sus) && sus >= 1 && sus <= 5) { }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Por favor, introduce un número válido entre 1 y 5.");
                    Console.ResetColor();
                }
                string path = "C:\\Users\\manue\\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\\Datos adjuntos\\Manushark.txt";

                switch (sus)
                {
                    case 1:

                        using (TextWriter archivo = new StreamWriter(path, true))
                        {
                            Console.Write("Ingrese el nombre del producto: ");
                            string Name = Console.ReadLine();

                            Console.Write("Ingrese la cantidad del producto: ");
                            string Mount = Console.ReadLine();

                            Console.Write("Ingrese el precio del producto: ");
                            string Price = Console.ReadLine();

                            archivo.WriteLine($"{Name} | {Mount} | {Price}\n");
                        }
                        break;
                    case 2:

                        break;
                    case 3:

                        string contenido = File.ReadAllText(path);
                        Console.WriteLine("Esto es lo que dice el archivo:\n");
                        Console.WriteLine(contenido);
                        break;

                    case 4:
                        


                        break;
                    case 5:
                            if (!File.Exists(path))
                            {
                               Console.WriteLine("El archivo no existe.");
                            }
                            else
                            {
                                File.Delete(path);
                                Console.WriteLine("Archivo eliminado correctamente");
                            }
                        break;
                    case 6:

                        exit = false;
                        break;
                }
            }
           
        }
    }
}
