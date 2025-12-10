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

public class Program
{
    public static void Main() 
    {
        //Reto_24 reto_24 = new Reto_24();
        //Console.WriteLine("== Método base ==");
        //reto_24.EnviarMensaje("Hola Manuel");

        //Console.WriteLine("\n== Decorador con log ==");
        //reto_24.EnviarConLog("Hola Manuel");

        //Console.WriteLine("\n== Decorador con confirmación ==");
        //reto_24.EnviarConConfirmacion("Hola Manuel");

        IVehicle car = new Car();
        IVehicle Moto = new Motocycle();

        car.StartEngine();
        car.StopEngine();

        Moto.StartEngine();
        Moto.StopEngine();

        Console.WriteLine("=========");

        IDevice laptop = new Laptop();
        IDevice smartphone = new Smartphone();

        ((Laptop)laptop).AssignBrand();
        laptop.TurnOn();
        Thread.Sleep(1000);
        laptop.TurnOff();
        /*
         * El cast permite tratar un objeto IDevice como su clase real
         * para usar métodos que no están en la interfaz.
         * Ej: ((Laptop)device).AssignBrand();
         */

        ((Smartphone)smartphone).AssignBrand();
        smartphone.TurnOn();
        Thread.Sleep(1000);
        smartphone.TurnOff();
    }

}
















