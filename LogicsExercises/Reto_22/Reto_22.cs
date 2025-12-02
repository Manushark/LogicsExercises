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


        //Lista de numeros ordenada y filtrada para obtener solo los numeros pares
        public List<int> lista()
        {
            List<int> t = new List<int> { 1, 8, 22, 30, 45, 7, 2, 9 };
            t.Sort();

            List<int> Couples = new List<int>();
            foreach (var item in t)
            {
                if (item % 2 == 0)
                {
                    Couples.Add(item);
                    Console.WriteLine(item);
                }
                else { continue; }
            }
            return Couples;
        }

    }
}
