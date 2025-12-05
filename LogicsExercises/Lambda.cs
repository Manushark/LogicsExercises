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

            // Sobrescribimos ToString() para que al imprimir un objeto Persona
            // muestre sus valores (Nombre y Edad) en lugar del nombre de la clase.
            public override string ToString()
            {
                return $"Nombre: {Nombre}, Edad: {Edad}";
            }
        }

        public class Producto
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Category { get; set; }
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

            Console.WriteLine("===========================");
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

            Console.WriteLine("===========================");
            Console.Write("Lista de precios de los productos: ");
            var producs = productos.Select(s => s.Price).ToList(); 
            foreach(var p in producs) { Console.WriteLine(p); }

            //Buscar un elemento en especifico
            List<int> numeros = new List<int> { 3, 5, 7, 9, 11 };
            var sooe = numeros.FirstOrDefault(x => x >= 6);
            var s = numeros.FirstOrDefault(x => x.Equals(5));

            Console.WriteLine("===========================");
            Console.WriteLine(sooe); 
            Console.WriteLine(s);


            Console.WriteLine("===========================");
            //Si existe un elemento en la lista 
            List<string> ciudades = new List<string> { "Santo Domingo", "Santiago", "La Vega" };
            var exist = ciudades.Any(v => v == "La Vega");
            Console.WriteLine(exist);
            Console.WriteLine("===========================");


            //Filtar los mayores de edad
            List<int> edades = new List<int> { 10, 15, 18, 20, 30, 40 };
            var olders = edades.Count(e => e >= 18);//el metodo Count devuelve la "cantidad" de elementos que cumplen la condicion 
            Console.WriteLine(olders);
            Console.WriteLine("===========================");

            //Obtener los 3 numeros mas altos y mostrarlos
            List<int> nums = new List<int> { 1, 50, 20, 40, 10, 5 };
            var tall = nums.OrderByDescending(n => n).Take(3);//Obtener los 3 numeros mas altos
            foreach (var n in tall)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("===========================");

            //Agrupar productos por categoria
            var producto = new List<Producto> {
            new Producto { Name="Manzana", Category="Fruta" },
            new Producto { Name="Pera", Category="Fruta" },
            new Producto { Name="Lechuga", Category="Vegetal" }
            };

            var groupedProducts = producto.GroupBy(p => p.Category);

            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"Categoria: {group.Key}");//group.Key es la categoria
                foreach (var item in group)
                {
                    Console.WriteLine($" - {item.Name}");
                }
            }
            Console.WriteLine("===========================");




        }
    }
}
