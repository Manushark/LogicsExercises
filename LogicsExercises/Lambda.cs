using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises
{
    public static class Lambda
    {
        public static void lambda() {
            
            List<int> lista = new List<int> { 1, 3, 5, 4, 8, 9, 3, 4 };
            //Expresion lambda para filtrar, transformar y filtrar nuevamente
            var le = lista.Where(n => n % 3 == 0)
                .Select(c => c + 122)
                .Where(c => c >= 126)
                .ToList();

            foreach (var n in le)
            {
                Console.WriteLine(n);
            }

            List<string> nombres = new List<string> { "Ana", "Pedro", "Luis", "Paola", "Armando" };
            
            //Expresion lambda para filtrar nombres que empiezan con A o contienen A
            var result = nombres.Where(n => n.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            //Expresion lambda para filtrar nombres que contienen A
            var result2 = nombres.Where(n => n.Contains("A", StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("====Nombres que contienen A====");

            foreach (var n in result2)
            {
                Console.WriteLine(n);
            }

        }
    }
}
