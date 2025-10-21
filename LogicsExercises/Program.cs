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
using LogicsExercises.Reto_06;
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


        /////////////////////////////////////////////Reto_06
        //Números del 100 al 0 de manera recursiva (Reto_06)
        Reto_06.oneToOne(100);


        //Dificultad Extra

        //Factorial normal de manera recursiva 
        int hola = Reto_06.factorial(5);
        Console.WriteLine(hola);

        //Fibonacci de manera recursiva (Reto_06)
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine(Reto_06.fibonacci(i));
        }

        //se imprime el valor del elemento en la posición 12 de la sucesión de Fibonacci
        Console.WriteLine(Reto_06.fibonacci2());

        //Aprendí mucho haciendo este reto porque la recursividad es un concepto nuevo para mi y al principio me costó entenderlo, pero con la practica logre comprender c0mo funcionan las funciones recursivas y como pueden ser utilizadas para resolver problemas de manera eficiente.


    }
}












