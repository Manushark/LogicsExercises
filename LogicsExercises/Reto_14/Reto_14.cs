using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_14
{
    public class Reto_14
    {
        /*
         * EJERCICIO:
         * Crea dos variables utilizando los objetos fecha (date, o semejante) de tu lenguaje:
         * - Una primera que represente la fecha (día, mes, año, hora, minuto, segundo) actual.
         * - Una segunda que represente tu fecha de nacimiento (te puedes inventar la hora).
         * Calcula cuántos años han transcurrido entre ambas fechas.
         *
         * DIFICULTAD EXTRA (opcional):
         * Utilizando la fecha de tu cumpleaños, formatéala y muestra su resultado de
         * 10 maneras diferentes. Por ejemplo:
         * - Día, mes y año.
         * - Hora, minuto y segundo.
         * - Día de año.
         * - Día de la semana.
         * - Nombre del mes.
         * (lo que se te ocurra...)
         */

        DateTime time = DateTime.Now;
        DateTime birth = new DateTime(2004, 10, 23, 8, 50, 4);//Establezco mi fecha de nacimiento 
        public void read()
        {
            Console.WriteLine($"Tiempo Actual: {time} ");
            Console.WriteLine($"El dia de mi nacimiento: {birth}");

            var date = time.Year - birth.Year;//Calculo la diferencia de años entre ambas fechas

            //Por si todavia no has cumplido anos (Yo ya si los cumpli)
            if (birth.Month > time.Month || birth.Month == time.Month && birth.Day > time.Day)//evaluo si el mes de nacimiento todavia no ha llegado o si es el mismo mes pero el dia aun no ha llegado
            {
                date--;//en caso de ser asi, resto un año a la diferencia
            }

            Console.WriteLine($"Años transcurridos: {date} ");
        }

        //DIFICULTAD EXTRA
        public void extra()
        {
            Console.WriteLine("Formatos diferentes de mi fecha de nacimiento:");
            Console.WriteLine($"1. Día, mes y año: {birth:dd/MM/yyyy}");
            Console.WriteLine($"2. Hora, minuto y segundo: {birth:HH:mm:ss}");
            Console.WriteLine($"3. Día de año: {birth:ddd}");
            Console.WriteLine($"4. Día de la semana: {birth:dddd}");
            Console.WriteLine($"5. Nombre del mes: {birth:MMMM}");
            Console.WriteLine($"6. Formato completo: {birth:F}");
            Console.WriteLine($"7. Formato corto: {birth:d}");
            Console.WriteLine($"8. Formato largo: {birth:D}");
            Console.WriteLine($"9. Formato universal: {birth:u}");
            Console.WriteLine($"10. Formato RFC1123: {birth:R}");
        }
    }
}
