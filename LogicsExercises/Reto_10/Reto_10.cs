using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_10
{
    /*
     * EJERCICIO:
     * Explora el concepto de manejo de excepciones según tu lenguaje.
     * Fuerza un error en tu código, captura el error, imprime dicho error
     * y evita que el programa se detenga de manera inesperada.
     * Prueba a dividir "10/0" o acceder a un índice no existente
     * de un listado para intentar provocar un error.
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea una función que sea capaz de procesar parámetros, pero que también
     * pueda lanzar 3 tipos diferentes de excepciones (una de ellas tiene que
     * corresponderse con un tipo de excepción creada por nosotros de manera
     * personalizada, y debe ser lanzada de manera manual) en caso de error.
     * - Captura todas las excepciones desde el lugar donde llamas a la función.
     * - Imprime el tipo de error.
     * - Imprime si no se ha producido ningún error.
     * - Imprime que la ejecución ha finalizado.
     */
    public class Reto_10
    {
        public static void Ejecutar()
        {
            try
            {
                int zero = 0;
                int resultado = 10 / zero;
                Console.WriteLine($"El resultado es: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("La ejecución ha finalizado.");
            }
           
            Console.ReadKey(); // Evita que se cierre la consola
        }

        //DIFICULTAD EXTRA

        public static void New(List<int> lista)
        {
            // Validaciones primero (antes de operar con los índices)
            if (lista.Count < 3)
            {
                throw new IndexOutOfRangeException("La lista no tiene suficientes elementos.");
            }
            else if (lista[1] == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre 0.");
            }
            else if (lista[2] == 0)
            {
                throw new error("El tercer elemento no puede ser cero (error personalizado).");
            }

            //Si todo está correcto, realiza las operaciones
            Console.WriteLine(lista[0] / lista[1]);
            Console.WriteLine(lista[2] + 5);
        }

        public class error : Exception
        {
            public error(string message) : base(message) { }
        }

        public static void Run()
        {
            // Prueba cambiando los valores de la lista para ver los distintos errores
            try
            {
                // Cambia estos valores para probar los tres tipos de excepción
                // 1 { 2 } -> IndexOutOfRangeException
                // 2️{ 2, 0, 7 } -> DivideByZeroException
                // 3️ { 2, 3, 0 } -> error personalizado
                // 4 { 2, 3, 7 } -> sin error

                New(new List<int> { 2, 3, 7 });
                Console.WriteLine("No se ha producido ningún error.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (error ex)
            {
                Console.WriteLine($"Error personalizado: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Ejecución finalizada.");
            }
        }

    }

}
