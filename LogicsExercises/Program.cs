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

public class Program
{
    public static void Main() 
    {
        //var ceo1 = CEOAccess.Instance;
        //var ceo2 = CEOAccess.Instance;

        //ceo1.AccessRestrictedArea();

        //Console.WriteLine(ceo1 == ceo2);
        //// True → Ambos son el mismo CEO

        var userSeccion = UserSeccion.Instance;
        userSeccion.setUser(1,"Manushark","Lito","Manuel@gmail.com");
        Console.WriteLine(userSeccion.getUser());

        var userSession2 = UserSeccion.Instance;
        userSession2.ClearUser();
        Console.WriteLine(userSession2.getUser());

    }



}
















