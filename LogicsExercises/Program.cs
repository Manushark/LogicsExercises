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
using LogicsExercises.Reto_29;
using static LogicsExercises.Reto_30.Reto_30;
using LogicsExercises.Reto_30;


public class Program
{
    public static void Main()
    {
        // Implementación del patrón Strategy para notificaciones
        Notifier notifier = new EmailNotifier();
        NotificationService notificationService = new NotificationService(notifier);
        notificationService.Notify("Hello, this is a test notification!");

        // Cambiamos la estrategia a SMS
        notifier = new SMSNotifier();
        notificationService = new NotificationService(notifier);
        notificationService.Notify("Hello, this is a test notification via SMS!");

        // Cambiamos la estrategia a PUSH
        notifier = new PushNotifier();
        notificationService = new NotificationService(notifier);
        notificationService.Notify("Hello, this is a test PUSH notification!");

    }
}