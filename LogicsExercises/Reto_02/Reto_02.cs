using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_02
{
    public class Reto_02
    {
        /*
          * EJERCICIO:
          * - Muestra ejemplos de creación de todas las estructuras soportadas por defecto
          *   en tu lenguaje.
          * - Utiliza operaciones de inserción, borrado, actualización y ordenación.
          *
          * DIFICULTAD EXTRA (opcional):
          * Crea una agenda de contactos por terminal.
          * - Debes implementar funcionalidades de búsqueda, inserción, actualización
          *   y eliminación de contactos.
          * - Cada contacto debe tener un nombre y un número de teléfono.
          * - El programa solicita en primer lugar cuál es la operación que se quiere realizar,
          *   y a continuación los datos necesarios para llevarla a cabo.
          * - El programa no puede dejar introducir números de teléfono no numéricos y con más
          *   de 11 dígitos (o el número de dígitos que quieras).
          * - También se debe proponer una operación de finalización del programa.
          */
        public static void Run() {


            Console.WriteLine("Estructuras soportadas por defecto en C#:");
            /// Estructuras C#
            // Array
            double[] array = { 5, 3, 8, 1, 99, 88, 0 };
            //foreach (var items in array) { Console.WriteLine($"Elemento del array: {items}"); }
            Array.Sort(array);//ordenar de mayor a menor
            //for (int i = 0; i < array.Length; i++){Console.WriteLine($"Elemento del array en posición {i}: {array[i]}");}
            foreach (var items in array) { Console.WriteLine($"Elemento del array: {items}"); }
            Console.WriteLine($"El promedio del array es: {array.Average()} ");
            Console.WriteLine($"El valor máximo del array es: {array.Max()} ");
            Console.WriteLine($"El valor mínimo del array es: {array.Min()} ");
            var NewOrder = array.OrderDescending();
            Console.WriteLine($"Este es el nuevo orden: {string.Join(" ", NewOrder)}");


            // List
            List<string> list1 = new List<string> { "Manzana", "Banana", "Cereza" };
            list1.Remove("Banana");
            foreach (var l in list1)
            {
                Console.WriteLine($"Elemento de la lista: {l}");
            }
            list1.Add("Chesse");
            list1.Sort();
            Console.WriteLine("Lista ordenada:");
            list1.ForEach(item => Console.WriteLine($"Elemento de la lista ordenada: {item}"));
            list1.Insert(3, "Naranja");
            list1.ForEach(item => Console.WriteLine($"Elemento de la lista con inserción: {item}"));
            list1.Clear();

            //Dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                {1, "Uno"},
                {2, "Dos"},
                {3, "Tres"}
            };
            dictionary.Add(4, "Cuatro");
            dictionary.Remove(2);
            dictionary.TryAdd(0, "Cero");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
            }

            Console.WriteLine("=======================================");
            //HashSet
            // HashSet es una colección de elementos únicos, no permite duplicados y no garantiza el orden.
            HashSet<int> hashSet = new HashSet<int> { 'D', 'B', 'C' };
            hashSet.Add('D');
            hashSet.Remove('B');
            foreach (var item in hashSet)
            {
                Console.WriteLine($"Elemento del HashSet: {item}");
            }
            Console.WriteLine("=======================================");

            //Queue
            // Queue es una cola (FIFO: First In, First Out)
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Primero");// Enqueue(x) → agrega un elemento al final
            queue.Enqueue("Segundo");
            queue.Enqueue("Tercero");
            queue.Count.ToString();
            Console.WriteLine($"Elemento al frente de la cola: {queue.Peek()}");
            while (queue.Count > 0)
            {
                // Dequeue() elimina y devuelve el elemento al frente o sea que te da el orden y lo borra
                Console.WriteLine($"Desencolando: {queue.Dequeue()}");
            }

            //Stack
            // Stack es una pila (LIFO: Last In, First Out)
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Count.ToString();
            Console.WriteLine($"Elemento en la cima de la pila: {stack.Peek()}");//te dice cual es el ultimo elemento que se ha metido
            while (stack.Count > 0)
            {
                // Pop() elimina y devuelve el elemento de la cima
                Console.WriteLine($"Desapilando: {stack.Pop()}");
            }

           
            //DIFICULTAD EXTRA(opcional):
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dificultad Extra");
            Console.ResetColor();
            Console.WriteLine("=======================================");
            Console.WriteLine("Agenda de contactos");
            Console.WriteLine("=======================================");
            int option;
            bool exit = false;
            List<Support> numberlist = new List<Support>();

            while (!exit)
            {
                Console.WriteLine($"Bienvenido a la agenda de contactos");
                Console.WriteLine($"1. Añadir contacto");
                Console.WriteLine($"2. Buscar contacto");
                Console.WriteLine($"3. Actualizar contacto");
                Console.WriteLine($"4. Eliminar contacto");
                Console.WriteLine($"5. Salir");
                Console.Write($"Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 5) { }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Por favor, introduce un número válido entre 1 y 5.");
                    Console.ResetColor();
                    continue;
                }
                Console.Clear();

                switch (option)
                {

                    case 1:
                        Console.WriteLine($"Introduce el nombre del contacto:");
                        Console.Write($"Nombre: ");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Introduce el número de teléfono del contacto (máximo 11 dígitos):");
                        Console.Write($"Número de teléfono: ");
                        string phoneNumber = Console.ReadLine();//Phone number changed from int to string to support more than 10 digits and avoid overflow.

                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("El nombre no puede estar vacío.");
                            Console.ResetColor();
                            break;
                        }

                        if (phoneNumber.ToString().Length > 11)
                        {
                            Console.WriteLine("El numero debe de tener menos de 11 caracteres");
                        }
                        else
                        {
                            Support Contacto = new Support(name, phoneNumber);
                            Console.WriteLine($"Contacto añadido: {Contacto.Name}, Teléfono: {Contacto.PhoneNumber}");
                            numberlist.Add(Contacto);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Contacto Agragado");
                            Console.ResetColor();
                            Console.WriteLine("=======================================");
                        }
                        break;

                    case 2:
                        Console.Write("Introduce el ID del contacto a buscar: ");
                        if (!int.TryParse(Console.ReadLine(), out int OneCont))
                        { Console.WriteLine("Esa contacto no se encuentra"); continue; }

                        var query = from i in numberlist
                                    where i.Id == OneCont
                                    select i;

                        if (query.Any())
                        {
                            foreach (var i in query)
                            {
                                i.mostarContactos();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontro el contacto");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Introduzca el Id del contacto de desea aditar: ");
                        if (int.TryParse(Console.ReadLine(), out int omg))
                        {
                            var edit = numberlist.Where(i => i.Id == omg);

                            if (edit.Any())
                            {
                                foreach (var contact in edit)// se utiliza la variable contact para modificar directamente el objeto en la lista
                                {
                                    Console.WriteLine($"Editando contacto: {contact.Name}, Telefono {contact.PhoneNumber}");
                                    Console.Write("Nuevo nombre: ");
                                    contact.Name = Console.ReadLine();
                                    Console.Write("Nuevo telefono: ");
                                    contact.PhoneNumber = Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontro el contacto");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontro el contacto");
                        }
                        Console.Clear();
                        break;

                    case 4:

                        Console.WriteLine("Introduzca el Id del contacto de desea eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int kl))
                        {
                            var delete = numberlist.Where(i => i.Id == kl).ToList();//ToList() para poder eliminar despues de hacer la consulta porque no se puede modificar la lista mientras se itera sobre ella.

                            if (delete.Any())
                            {
                                foreach (var contact in delete)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"El contacto {contact.Name} ha sido eliminado");
                                    Console.ResetColor();
                                    numberlist.Remove(contact);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontro el contacto");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontro el contacto");
                        }

                        break;

                    case 5:
                        exit = true;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }
            }

        }

    }
}
