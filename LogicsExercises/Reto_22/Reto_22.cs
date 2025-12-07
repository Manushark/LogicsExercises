using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_22
{
    /*
     * EJERCICIO:
     * Explora el concepto de funciones de orden superior en tu lenguaje 
     * creando ejemplos simples (a tu elección) que muestren su funcionamiento.
     *
     * DIFICULTAD EXTRA (opcional):
     * Dada una lista de estudiantes (con sus nombres, fecha de nacimiento y 
     * lista de calificaciones), utiliza funciones de orden superior para
     * realizar las siguientes operaciones de procesamiento y análisis:
     * - Promedio calificaciones: Obtiene una lista de estudiantes por nombre
     *   y promedio de sus calificaciones.
     * - Mejores estudiantes: Obtiene una lista con el nombre de los estudiantes
     *   que tienen calificaciones con un 9 o más de promedio.
     * - Nacimiento: Obtiene una lista de estudiantes ordenada desde el más joven.
     * - Mayor calificación: Obtiene la calificación más alta de entre todas las
     *   de los alumnos.
     * - Una calificación debe estar comprendida entre 0 y 10 (admite decimales).
     */
    public class Reto_22
    {
        //Funcion de orden superior que divide un numero entre 2 usando una funcion interna
        public int DividirNumeros(int n)
        {
            int Mitad(int x = 2) 
            {
                Console.WriteLine("La mitad es: " + (n / x));
                return x / n;
                
            }
            return Mitad();
        }

        //Funcion de orden superior que recibe dos numeros y una operacion a realizar 
        //Y si usamos func no necesitamos usar delegados
        public int Operar(int x, int f, Func<int, int, int> operacion)
        {
            return operacion(x, f);
        }

        //Difficulta Extra 
        public class Estudiante
        {
            public string Nombre { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public List<double> Calificaciones { get; set; }

            public override string ToString()
            {
                return $"{Nombre} - Nacimiento: {FechaNacimiento.ToShortDateString()}";
            }
        }

        public void Run()
        {
            //Lista de estudiantes
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { Nombre = "Ana", FechaNacimiento = new DateTime(2004, 5, 12), Calificaciones = new List<double>{ 8.5, 9, 10 } },
                new Estudiante { Nombre = "Luis", FechaNacimiento = new DateTime(2003, 11, 3), Calificaciones = new List<double>{ 7.5, 6.8, 8 } },
                new Estudiante { Nombre = "Paola", FechaNacimiento = new DateTime(2005, 2, 28), Calificaciones = new List<double>{ 9.2, 9.8, 9.5 } },
                new Estudiante { Nombre = "Alito", FechaNacimiento = new DateTime(2004, 7, 12), Calificaciones = new List<double>{ 10, 10, 9.5 } },
                new Estudiante { Nombre = "Pedro", FechaNacimiento = new DateTime(2004, 7, 19), Calificaciones = new List<double>{ 5, 6.5, 7 } }
            };


            //Aqui realizamos las operaciones usando funciones de orden superior 
            var promedios = estudiantes
                .Select(e => new
                {
                    Nombre = e.Nombre,
                    Promedio = e.Calificaciones.Average()
                })
                .ToList();

            Console.WriteLine("PROMEDIOS:");
            foreach (var p in promedios)
                Console.WriteLine($"{p.Nombre} -> {p.Promedio:F2}");

            Console.WriteLine();

            //Lista de los mejores estudiantes
            var mejores = estudiantes
                .Where(e => e.Calificaciones.Average() >= 9)
                .Select(e => e.Nombre)
                .ToList();

            Console.WriteLine("MEJORES ESTUDIANTES (>=9):");
            mejores.ForEach(Console.WriteLine);

            Console.WriteLine();

            //Lista de estudiantes ordenada por fecha de nacimiento
            var porNacimiento = estudiantes
                .OrderByDescending(e => e.FechaNacimiento)
                .ToList();

            Console.WriteLine("DESDE EL MÁS JOVEN:");
            porNacimiento.ForEach(e => Console.WriteLine(e));

            Console.WriteLine();

            //Mayor calificación entre todos los estudiantes
            var mayorCalificacion = estudiantes
                .SelectMany(e => e.Calificaciones)
                .Max();
            
            Console.WriteLine($"MAYOR CALIFICACIÓN: {mayorCalificacion}");
        }
    }

//    Console.WriteLine("-----Funcion de orden superior que divide un numero entre 2-----");
//        reto_22.DividirNumeros(80);

//        Console.WriteLine("-----Operaciones con funciones de orden superior-----");
//        //Creamos funciones lambda para las operaciones
//        Func<int, int, int> suma = (a, b) => a + b;
//    Func<int, int, int> resta = (a, b) => a - b;
//    Func<int, int, int> multiplicacion = (a, b) => a * b;

//    Console.WriteLine("Suma: " + reto_22.Operar(56, 33, suma));
//        Console.WriteLine("Resta: " + reto_22.Operar(99, 7, resta));
//        Console.WriteLine("Multiplicacion: " + reto_22.Operar(19, 5, multiplicacion));

//        //Dificultad Extra
//        reto_22.Run();
}

