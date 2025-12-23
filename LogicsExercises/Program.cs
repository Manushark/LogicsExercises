using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using LogicsExercises;
using static LogicsExercises.Lambda;
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
using LogicsExercises.Reto_23;
using static LogicsExercises.Reto_23.Reto_23;
using LogicsExercises.Reto_24;
using LogicsExercises.Interfaces;
using System.Numerics;
using LogicsExercises.Reto_25;
using LogicsExercises.Reto_26;
using static LogicsExercises.Reto_27.Reto_27;
using LogicsExercises.Reto_27;
using LogicsExercises.Reto_28;

public class Program
{
    public static void Main()
    {
        //Ejemplo del uso incorrecto del LSP
        Reto_28.Character W1 = new Reto_28.Warrior();
        W1.Attack();

        Reto_28.Character personaje2 = new Reto_28.Wizard();
        try
        {
            personaje2.Attack();
        }
        catch (NotImplementedException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }
}
















