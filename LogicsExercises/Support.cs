using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises
{
    public class Support
    {
        private static int idCounter = 0;
        public int Id { get; } // solo lectura
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public Support(string name, int phoneNumber)
        {
            idCounter++;
            Id = idCounter;
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }

}




