using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using LogicsExercises;
using LogicsExercises.Reto_01;
using LogicsExercises.Reto_02;
using LogicsExercises.Reto_03;
using LogicsExercises.Reto_04;
using Microsoft.Win32;

public class Program
{
    public static void Main()
    {
        Reto_04.suma(5, 7);
        Reto_04.Saludar();
        Reto_04.Jimi("Matos");
        int aleatorio = Reto_04.ramdomNumer();
        Console.WriteLine(aleatorio);
        string perfil = Reto_04.registro(3, "manu");
        Console.WriteLine(perfil);

        Reto_04.nombre();

        int sum = Reto_04.sumas();
        Console.WriteLine(sum);
        string varG = Reto_04.global();
        Console.WriteLine(varG);
    }
}












