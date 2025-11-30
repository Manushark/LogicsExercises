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
using LogicsExercises.Reto_16;
using LogicsExercises.Reto_17;
using LogicsExercises.Reto_18;
using LogicsExercises.Reto_19;
using LogicsExercises.Reto_20;
using LogicsExercises.Reto_21;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LogicsExercises.Reto_08.Reto_08;
using static LogicsExercises.Reto_12.Reto_12;
using static LogicsExercises.Reto_19.Reto_19;

public class Program
{
    public static void Main() 
    { 
        Reto_21 reto_21 = new Reto_21();
        reto_21.Procesar(5, MostrarNumero);//imprime el numero 5


        // Imprimir el nombre en mayúsculas
        reto_21.MostrarNombre("Manuel", ImprimirMayus);//Aqui podemos usar el metodo ImprimirMayus como callback para mostrar el nombre en mayusculas

        // Imprimir con un saludo
        reto_21.MostrarNombre("Andrea", Saludar);

        // Extra Difficulty
        reto_21.Order_Process("Pizza de Jamon con peperoni y queso parmesano", reto_21.Confirm_Order, reto_21.Order_ready, reto_21.Order_delivered);
    }

    // ====== Callbacks ======
    public static void ImprimirMayus(string n)
    {
        Console.WriteLine(n.ToUpper());
    }

    public static void Saludar(string n)
    {
        Console.WriteLine($"Hola {n}, que tengas un buen día.");
    }

    public static void MostrarNumero(int n)
    {
        Console.WriteLine($"El número es: {n}");
    }
}















