using System;
using System.Collections.Generic;
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
using LogicsExercises.Reto_22;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LogicsExercises.Reto_08.Reto_08;
using static LogicsExercises.Reto_12.Reto_12;
using static LogicsExercises.Reto_19.Reto_19;

public class Program
{
    public static void Main() 
    { 
        Reto_22 reto_22 = new Reto_22();
        Console.WriteLine("-----Funcion de orden superior que divide un numero entre 2-----");
        reto_22.DividirNumeros(80);
        
        Console.WriteLine("-----Lista de numeros ordenada y filtrada para obtener solo los numeros pares-----");
        reto_22.lista();

        Console.WriteLine("-----Operaciones con funciones de orden superior-----");
        //Creamos funciones lambda para las operaciones
        Func<int, int, int> suma = (a, b) => a + b;
        Func<int, int, int> resta = (a, b) => a - b;
        Func<int, int, int> multiplicacion = (a, b) => a * b;
        
        Console.WriteLine("Suma: " + reto_22.Operar(56, 33, suma));
        Console.WriteLine("Resta: " + reto_22.Operar(99, 7, resta));
        Console.WriteLine("Multiplicacion: " + reto_22.Operar(19, 5, multiplicacion));



    }
        


}
















