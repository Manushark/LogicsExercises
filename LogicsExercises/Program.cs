using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using LogicsExercises;
using LogicsExercises.Reto_01;
using LogicsExercises.Reto_02;
using LogicsExercises.Reto_03;
using LogicsExercises.Reto_04;
using LogicsExercises.Reto_05;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        ///(Reto_04)
        //Reto_04.suma(5, 7);
        //Reto_04.Saludar();
        //Reto_04.Jimi("Matos");
        //int aleatorio = Reto_04.ramdomNumer();
        //Console.WriteLine(aleatorio);
        //string perfil = Reto_04.registro(3, "manu");
        //Console.WriteLine(perfil);
        //Reto_04.nombre();

        //int sum = Reto_04.sumas();
        //Console.WriteLine(sum);
        //string varG = Reto_04.global();
        //Console.WriteLine(varG);

        //Console.WriteLine("==========");
        //Reto_04.algo("Te", "Extrano");


        //Ejemplos de asignación de variables "por referencia" (Reto_05)
        //Reto_05 PersonaRandom = new Reto_05();
        //PersonaRandom.nombre = "camilo";

        //Reto_05 PersonaRandomNo2 = new Reto_05();
        
        //PersonaRandomNo2 = PersonaRandom; // PersonaRandomNo2 referencia al mismo objeto que PersonaRandom

        //PersonaRandomNo2.nombre = "Sofia"; // cambia el mismo objeto en memoria

        //Console.WriteLine(PersonaRandom.nombre);
        //Console.WriteLine(PersonaRandomNo2.nombre); //O sea, ambos apuntan al mismo lugar en la memoria RAM. por eso si cambias PR2 se actuliza el nombre de PR1 porque los datos estan guardados en el mismo lugar en memoria

        //Parte2 del (Reto_05)

        int numero1 = 10;
        int numero2 = 20;

        Console.WriteLine("Antes de llamar a las funciones:");
        Console.WriteLine($"numero1 = {numero1}");
        Console.WriteLine($"numero2 = {numero2}\n");

        // Llamada por valor
        Reto_05.valor(numero1);
        // Llamada por referencia
        Reto_05.valorRef(ref numero2);

        Console.WriteLine("Después de llamar a las funciones:");
        Console.WriteLine($"numero1 = {numero1} (por valor, no cambió)");
        Console.WriteLine($"numero2 = {numero2} (por referencia, sí cambió)");

        //Por valor: la función recibe una copia del dato → cambiarlo dentro de la funcion *no afecta* al original.
        //Por referencia: la función recibe el dato original → cambiarlo dentro de la funcion *sí afecta* al original.

    }
}












