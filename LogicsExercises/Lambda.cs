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

        }
    }
}
