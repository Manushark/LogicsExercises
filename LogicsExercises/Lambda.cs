using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicsExercises
{
    public static class Lambda
    {
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public override string ToString()
            {
                return $"Nombre: {Nombre}, Edad: {Edad}";
            }
        }

        public class Producto
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
       



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


            var personas = new List<Persona>
            {
                new Persona { Nombre = "Ana", Edad = 28 },
                new Persona { Nombre = "Luis", Edad = 35 },
                new Persona { Nombre = "Paola", Edad = 22 },
                new Persona { Nombre = "Pedro", Edad = 40 }
            };

            //Expresion lambda para ordenar personas por edad 

            var personas2 = personas.OrderBy(p => p.Edad);
            foreach (var p in personas2) { Console.WriteLine(p); }


            //Expresion para obtener solo la lista de precios 
            var productos = new List<Producto> {
            new Producto { Name="Mouse", Price=500 },
            new Producto { Name="Teclado", Price=800 },
            new Producto { Name="Monitor", Price=4500 }
            };


            Console.Write("Lista de precios de los productos: ");
            var producs = productos.Select(s => s.Price).ToList(); 
            foreach(var p in producs) { Console.WriteLine(p); }



        }
    }
}
