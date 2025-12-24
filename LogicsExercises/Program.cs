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
using static LogicsExercises.Reto_28.Vehicle;
using static LogicsExercises.Reto_28.Game;


public class Program
{
    public static void Main()
    {
        //Reto 28 - Principio de Sustitución de Liskov (LSP)
        static void TestVehicle(Vehicle vehicle)
        {
            vehicle.Accelerate(10);
            vehicle.Brake(5);
            Console.WriteLine($"Velocidad final: {vehicle.Speed}");
        }
        
        Console.WriteLine("Pruebas de Vehículos:");
        Console.WriteLine("Carros");
        Console.WriteLine("----------------------");
        Vehicle car = new Car();
        car.Accelerate(50);
        car.Brake(15);

        TestVehicle(car);


        Console.WriteLine("----------------------");
        Console.WriteLine("Motocicletas");
        Vehicle moto = new Motocycle();
        moto.Accelerate(30);
        moto.Brake(20); 

        TestVehicle(moto);//Esto comprueba el LSP porque estamos usando la clase base Vehicle para probar las subclases Car y Motocycle sin importar su implementación interna

        Console.WriteLine("----------------------");
        Console.WriteLine("Bicicletas");
        Vehicle bike = new Bicycle();
        bike.Accelerate(15);
        bike.Accelerate(10);
        bike.Brake(26);

        TestVehicle(bike);

    }
}
















