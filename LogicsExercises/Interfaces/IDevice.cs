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
            Console.Write("Enter the Laptop brand: ");
            this.Brand = Console.ReadLine();
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
            Console.Write("Enter the Smartphone brand: ");
            this.Brand = Console.ReadLine();
        }
    }

    //Para compilar el código de ejemplo
    //Console.WriteLine("=========");

    //    IDevice laptop = new Laptop();
    //IDevice smartphone = new Smartphone();

    //((Laptop) laptop).AssignBrand();
    //laptop.TurnOn();
    //    Thread.Sleep(1000);
    //    laptop.TurnOff();
    //    /*
    //     * El cast permite tratar un objeto IDevice como su clase real
    //     * para usar métodos que no están en la interfaz.
    //     * Ej: ((Laptop)device).AssignBrand();
    //     */

    //    ((Smartphone) smartphone).AssignBrand();
    //smartphone.TurnOn();
    //    Thread.Sleep(1000);
    //    smartphone.TurnOff();
}
