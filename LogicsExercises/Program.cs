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
using LogicsExercises.Reto_09;
using LogicsExercises.Reto_10;
using LogicsExercises.Reto_11;
using LogicsExercises.Reto_12;
using LogicsExercises.Reto_13;
using LogicsExercises.Reto_14;
using LogicsExercises.Reto_15;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LogicsExercises.Reto_08.Reto_08;
using static LogicsExercises.Reto_12.Reto_12;

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

        //Reto_11.Sales();

        //Reto_12.Run();

        //ArchivoServices archivoServices = new ArchivoServices();

        //Precursor precursor = new Precursor("Majagg talgul", 50, 'R');
        ////archivoServices.SaveJson(precursor);
        ////archivoServices.LoadJson(precursor);

        //archivoServices.SaveXml(precursor, "Xml.xml");
        //archivoServices.LeerXML("Xml.xml");


        //Reto_14 reto_14 = new Reto_14();
        //reto_14.extra();

        Reto_15 reto_15 = new Reto_15();
        reto_15.Run(5).GetAwaiter().GetResult();
    }
}













