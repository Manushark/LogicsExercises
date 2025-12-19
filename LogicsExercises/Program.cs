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

public class Program
{
    public static void Main() 
    {
        //Precio base
        double price = 1000;

        /* Para que funcione debemos de crear una instancia de la interfaz
         * luego crear una instancia de la clase PriceCalculator
         * y luego llamar al metodo CalculatePrice pasandole
         * el precio y el tipo de descuento que queremos aplicar
         */
        IDiscount discount = new StudentDiscount();
        PriceCalculator Calculator = new PriceCalculator();
        double finalPrice = Calculator.CalculatePrice(price, discount);
        Console.WriteLine("Precio original: " + price);
        Console.WriteLine($"Precio final con descuento de estudiante: {finalPrice}");

        //Vip Discount

        PriceCalculator Calculator2 = new PriceCalculator();
        IDiscount discount2 = new VipDiscount();
        double finalPrice2 = Calculator2.CalculatePrice(price, discount2);
        Console.WriteLine("Precio original: " + price);
        Console.WriteLine($"Precio final con descuento VIP: {finalPrice2}");
    }

}
















