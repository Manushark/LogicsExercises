using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Interfaces
{
    public interface IDevice
    {
        string Brand { get; set; }
        void TurnOn();
        void TurnOff();
    }

    public class Laptop : IDevice
    {
        public string Brand { get; set; }
        public void TurnOn() 
        { Console.WriteLine($"La Laptop {Brand} is turning on... "); }
        public void TurnOff()
        { Console.WriteLine($"La Laptop {Brand} is turning pff..."); }

        public void AssignBrand()
        {
            Console.Write("Enter the phone model: ");
            Brand = Console.ReadLine();
        }
    }
    public class Smartphone : IDevice
    {
        public string Brand { get; set; }
        public void TurnOn()
        { Console.WriteLine($"Smartphone {Brand} is turning on... "); }
        public void TurnOff()
        { Console.WriteLine($"Smartphone {Brand} is turning off..."); }

        public void AssignBrand()
        {
            Console.Write("Enter the phone model: ");
            Brand = Console.ReadLine();
        }
    }

}
