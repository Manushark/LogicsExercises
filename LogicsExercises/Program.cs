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
using static LogicsExercises.Reto_29.Reto_29;
using static LogicsExercises.Reto_29.Reto_29.Teachers;


public class Program
{
    public static void Main()
    {

        //Forma incorrecta de ISP
        ISchoolPerson Alumno = new Students();
        Console.WriteLine("--Bad---Students-----");
        Alumno.AttendClasses(); // Aqui tenemos un metodo que no le corresponde al alumno
        Alumno.DoHomework();
        Alumno.TakeExams();
        Alumno.TeachClasses(); // Aqui tenemos un metodo que no le corresponde al alumno

        Console.WriteLine();
        Console.WriteLine("--Bad---Teachers-----");
        ISchoolPerson Maestro = new Teachers();
        Maestro.TeachClasses();
        Maestro.DoHomework(); // Aqui tenemos un metodo que no le corresponde al maestro


        //Forma correcta de ISP

        IStudent student = new Student();
        Console.WriteLine();
        Console.WriteLine("--Nice---Students-----");
        student.AttendClasses(); // Aqui solo tenemos los metodos que le corresponden al estudiante
        student.DoHomework();
        student.TakeExams();

        Console.WriteLine();
        Console.WriteLine("--Nice---Teachers-----");
        ITeacher teacher = new Teacher();
        teacher.TeachClasses(); // Aqui solo tenemos los metodos que le corresponden al profesor
        teacher.AttendClasses();

        /* De esta manera, hemos separado las interfaces
         * para que cada clase implemente solo los métodos
         * que le corresponden, cumpliendo así con el 
         * Principio de Segregación de Interfaces (ISP).
         */
    }
}