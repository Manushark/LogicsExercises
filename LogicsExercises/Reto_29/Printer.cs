using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogicsExercises.Reto_29.Printer;

namespace LogicsExercises.Reto_29
{
    /* DIFICULTAD EXTRA(opcional):
     * Crea un gestor de impresoras.
     * Requisitos:
     * 1. Algunas impresoras sólo imprimen en blanco y negro.
     * 2. Otras sólo a color.
     * 3. Otras son multifunción, pueden imprimir, escanear y enviar fax.
     * Instrucciones:
     * 1. Implementa el sistema, con los diferentes tipos de impresoras y funciones.
     * 2. Aplica el ISP a la implementación.
     * 3. Desarrolla un código que compruebe que se cumple el principio.
     */
    public class Printer
    {
        //========Interfaces=========

        public interface IPrinter
        {
            void Print(string text);
        }

        public interface IColorPrinter { 
            void ColorPrint(string text);
        }

        public interface IScannerPrinter
        {
            void ScannerPrint(string text);
        }

        public interface IFaxPrinter 
        { 
            void FaxPrint(string text);
        }

        //=======Clases=======

        public class BlackAndWhitePrinter : IPrinter
        {
            public void Print(string text)
            {
                Console.WriteLine($"Black and White Printer: {text}");
            }
        }

        public class ColorPrinter : IPrinter, IColorPrinter
        {
            public void Print(string text)
            {
                Console.WriteLine($"Black and White Printer: {text}");
            }
            public void ColorPrint(string text)
            {
                Console.WriteLine($"Color Printer: {text}");
            }
        }

        public class MultifunctionPrinter : IPrinter, IColorPrinter, IScannerPrinter, IFaxPrinter
        {
            public void Print(string text)
            {
                Console.WriteLine($"Black and White Printer: {text}");
            }

            public void ColorPrint(string text)
            {
                Console.WriteLine($"Color Printer: {text}");
            }

            public void ScannerPrint(string text)
            {
                Console.WriteLine($"Scanner Printer: {text}");
            }

            public void FaxPrint(string text)
            {
                Console.WriteLine($"Fax Printer: {text}");
            }

        }

        //=======Metodo de prueba=======
        public void TestPrinter()
        {
            Console.WriteLine("----Printer Test----");
            Console.WriteLine();
            Console.WriteLine("===================");
            Console.WriteLine("Black and White Printer:");
            IPrinter printer = new BlackAndWhitePrinter();
            printer.Print("Filesss.pdf");

            Console.WriteLine();
            Console.WriteLine("===================");
            Console.WriteLine("Color Printer:");
            IPrinter printers = new ColorPrinter();
            printers.Print("Photos.pdf");
            IColorPrinter colorPrinter = new ColorPrinter();
            colorPrinter.ColorPrint("File_with_color.pdf");
            Console.WriteLine();

            Console.WriteLine("===================");
            Console.WriteLine("Multifunction Printer:");
            IPrinter printerW_b = new MultifunctionPrinter();
            printerW_b.Print("Susano.dox");

            IScannerPrinter scannerPrinter = new MultifunctionPrinter();
            scannerPrinter.ScannerPrint("File_Mecanic.pdf");

            IFaxPrinter faxPrinter = new MultifunctionPrinter();
            faxPrinter.FaxPrint("File.pdf");
        }
    }
}