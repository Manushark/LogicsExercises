using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_02
{
    public class Support
    {
        private static int idCounter = 0;
        public int Id { get; } // solo lectura
        public string Name { get; set; }
        public string PhoneNumber { get; set; }///Siempre que un “número” no se vaya a usar para cálculos matemáticos, es mejor guardarlo como string.
                                               ///Ejemplos: teléfono, código postal, Cedula, tarjeta de crédito.

        public Support(string name, string phoneNumber)
        {
            idCounter++;
            Id = idCounter;
            Name = name;
            PhoneNumber = phoneNumber;
        }
       
        public void mostarContactos()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n--- Tarea #{Id} ---");
            Console.ResetColor();
            Console.WriteLine($"-Nombre: {Name}");
            Console.WriteLine($"-Telefono: {PhoneNumber}");
        }
    }

}




