using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
