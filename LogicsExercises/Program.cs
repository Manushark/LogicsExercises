using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using LogicsExercises;
using LogicsExercises.Reto_01;
using LogicsExercises.Reto_02;
using LogicsExercises.Reto_03;
using LogicsExercises.Reto_04;
using LogicsExercises.Reto_05;
using LogicsExercises.Reto_06;
using LogicsExercises.Reto_07;
using LogicsExercises.Reto_08;
//using LogicsExercises.Reto_09;
//using LogicsExercises.Reto_10;
//using LogicsExercises.Reto_11;
//using LogicsExercises.Reto_12;

using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LogicsExercises.Reto_08.Reto_08;

public class Program
{
    public static void Main()
    {

        //Ejemplos de asignación de variables "por referencia" (Reto_05)
        //Reto_05 PersonaRandom = new Reto_05();
        //PersonaRandom.nombre = "camilo";

        //Reto_05 PersonaRandomNo2 = new Reto_05();

        //PersonaRandomNo2 = PersonaRandom; // PersonaRandomNo2 referencia al mismo objeto que PersonaRandom

        //PersonaRandomNo2.nombre = "Sofia"; // cambia el mismo objeto en memoria

        //Console.WriteLine(PersonaRandom.nombre);
        //Console.WriteLine(PersonaRandomNo2.nombre); //O sea, ambos apuntan al mismo lugar en la memoria RAM. por eso si cambias PR2 se actuliza el nombre de PR1 porque los datos estan guardados en el mismo lugar en memoria

        ///////////////////////////////Parte2 del (Reto_05)

        //int numero1 = 10;
        //int numero2 = 20;

        //Console.WriteLine("Antes de llamar a las funciones:");
        //Console.WriteLine($"numero1 = {numero1}");
        //Console.WriteLine($"numero2 = {numero2}\n");

        //// Llamada por valor
        //Reto_05.valor(numero1);
        //// Llamada por referencia
        //Reto_05.valorRef(ref numero2);

        //Console.WriteLine("Después de llamar a las funciones:");
        //Console.WriteLine($"numero1 = {numero1} (por valor, no cambió)");
        //Console.WriteLine($"numero2 = {numero2} (por referencia, sí cambió)");

        ////Por valor: la función recibe una copia del dato → cambiarlo dentro de la funcion *no afecta* al original.
        ////Por referencia: la función recibe el dato original → cambiarlo dentro de la funcion *sí afecta* al original.


        //Console.WriteLine("Antes de llamar a las funciones:");
        //Console.WriteLine($"numero1 = {numero1}");
        //Console.WriteLine($"numero2 = {numero2}\n");

        ////(no cambia las originales)
        //(int nuevo1, int nuevo2) = Reto_05.IntercambioPorValor(numero1, numero2);
        //Console.WriteLine("Después de llamar a la función por valor:");
        //Console.WriteLine($"numero1 = {numero1} (por valor, no cambió)");
        //Console.WriteLine($"numero2 = {numero2} (por valor, no cambió)");
        //Console.WriteLine($"nuevo1 = {nuevo1} (valor intercambiado)");
        //Console.WriteLine($"nuevo2 = {nuevo2} (valor intercambiado)\n");

        ////referencia (si cambia las originales)
        //Reto_05.IntercambioPorReferencia(ref numero1, ref numero2);

        //Console.WriteLine("Después de llamar a la función por referencia:");
        //Console.WriteLine($"numero1 = {numero1} (por referencia, sí cambió)");
        //Console.WriteLine($"numero2 = {numero2} (por referencia, sí cambió)");

        //Reto_07.Run();

        //Reto_07.printer();

        ///Reto_08
        //Se crea el objeto Iphone con los atributos iniciales
        //Celular phone = new Celular("A12" , "Sansung");

        //phone.mostrar();

        //phone.NuevoCelular();

        //phone.mostrar();

        //DIFICULTAD EXTRA (opcional):
        //int opcion = 0;
        //bool True = true;
        //Pila pila = new Pila();

        //while (True)
        //{
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    Console.WriteLine("          Agregar ropa             ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine("1. Agregar ropa");
        //    Console.WriteLine("2. Ver lista de ropa");
        //    Console.WriteLine("3. Eliminar ropa");
        //    Console.WriteLine("4. Salir");
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.Write("~Ingrese una opción: ");
        //    Console.ResetColor();

        //    if (int.TryParse(Console.ReadLine(), out opcion))//validación de entrada
        //    {

        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Entrada no válida, intente de nuevo");
        //        Console.ResetColor();
        //    }


        //    switch (opcion)
        //    {
        //        case 1:
        //            pila.Agregar();
        //            break;
        //        case 2:
        //            pila.MostrarPila();

        //            break;
        //        case 3:
        //            pila.SacarRopa();
        //            break;
        //        case 4:
        //            True = false;
        //            break;
        //    }


        int opcion = 0;
        bool True = true;
        Cola cola = new Cola();

        while (True)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("          Agregar ropa             ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Agregar en la fila");
            Console.WriteLine("2. Ver la fila");
            Console.WriteLine("3. Despachar");
            Console.WriteLine("4. Obtener cantidad");
            Console.WriteLine("5. Salir");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("~Ingrese una opción: ");
            Console.ResetColor();

            if (int.TryParse(Console.ReadLine(), out opcion))//validación de entrada
            {

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada no válida, intente de nuevo");
                Console.ResetColor();
            }


            switch (opcion)
            {
                case 1:
                    cola.EntrarFila();
                    break;
                case 2:
                    cola.MostrarFila();
                    break;
                case 3:
                    cola.Despachar();
                    break;
                case 4:
                    Console.WriteLine(cola.ObtenerCantidad());
                    break;
                case 5:
                    True = false;
                    break;
            }
        }
    }
}













