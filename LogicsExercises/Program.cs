public class Program
{
    public static void Main()
    {
        #region
        /*
         * EJERCICIO:
         * - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
         *   Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
         *   (Ten en cuenta que cada lenguaje puede poseer unos diferentes)
         * - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
         *   que representen todos los tipos de estructuras de control que existan
         *   en tu lenguaje:
         *   Condicionales, iterativas, excepciones...
         * - Debes hacer print por consola del resultado de todos los ejemplos.
         *
         * DIFICULTAD EXTRA (opcional):
         * Crea un programa que imprima por consola todos los números comprendidos
         * entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.
         *
         * Seguro que al revisar detenidamente las posibilidades has descubierto algo nuevo.
         */
        // Ejemplos de operadores
        //int a = 10, b = 5;
        //Console.WriteLine($"Aritméticos: {a} + {b} = {a + b}, {a} - {b} = {a - b}, {a} * {b} = {a * b}, {a} / {b} = {a / b}, {a} % {b} = {a % b}");

        //bool x = true, y = false;
        //Console.WriteLine($"Lógicos: {x} AND {y} = {x && y}, {x} OR {y} = {x || y}, NOT {x} = {!x}");

        //Console.WriteLine($"Comparación: {a} == {b} = {a == b}, {a} != {b} = {a != b}, {a} > {b} = {a > b}, {a} < {b} = {a < b}, {a} >= {b} = {a >= b}, {a} <= {b} = {a <= b}");

        //int c = a;
        //c += b; // Asignación
        //Console.WriteLine($"Asignación: c starts as a ({c - b}), then c += b results in c = {c}");

        //object obj1 = new object();
        //object obj2 = obj1;
        //Console.WriteLine($"Identidad: obj1 is obj2: {ReferenceEquals(obj1, obj2)}");

        //string str = "hello";
        //Console.WriteLine($"Pertenencia: 'h' in '{str}' = {str.Contains('h')}");

        //int bitA = 5; // 0101
        //int bitB = 3; // 0011
        //Console.WriteLine($"Bits: {bitA} & {bitB} = {bitA & bitB}, {bitA} | {bitB} = {bitA | bitB}, ~{bitA} = !{bitA}, {bitA} ^ {bitB} = {bitA ^ bitB}");
        //// Estructuras de control
        //if (a > b)
        //{
        //    Console.WriteLine($"{a} is greater than {b}");
        //}
        //else
        //{
        //    Console.WriteLine($"{a} is not greater than {b}");

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine($"For loop iteration: {i}");
        //    }

        //}

        //int count = 0;
        //while (count < 5)
        //{
        //    Console.WriteLine($"While loop count: {count}");
        //    count++;
        //}
        //try
        //{
        //    int zero = 0;
        //    int result = a / zero;
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine($"Exception caught: {ex.Message}");
        //}
        //// DIFICULTAD EXTRA

        //Console.WriteLine("Números entre 10 y 55, pares, que no son ni el 16 ni múltiplos de 3:");

        //for (int i = 10; i <= 55; i++)
        //{
        //    if (i == 16 || i % 3 == 0 || i % 2 != 0)
        //    {

        //    }
        //    else
        //    {
        //        Console.WriteLine($"Numero: {i}");
        //    }
        //}
        #endregion

        #region        
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

        Console.WriteLine("Estructuras soportadas por defecto en C#:");
        /// Estructuras C#
        // Array
        double[] array = { 5, 3, 8, 1, 99, 88, 0 };
        //foreach (var items in array) { Console.WriteLine($"Elemento del array: {items}"); }
        Array.Sort(array);//ordenar de mayor a menor
        //for (int i = 0; i < array.Length; i++){Console.WriteLine($"Elemento del array en posición {i}: {array[i]}");}
        foreach (var items in array) { Console.WriteLine($"Elemento del array: {items}");}
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

        //HashSet
        HashSet<char> hashSet = new HashSet<char> { 'A', 'B', 'C' };
        hashSet.Add('D');
        hashSet.Remove('B');
        foreach (var item in hashSet)
        {
            Console.WriteLine($"Elemento del HashSet: {item}");
        }

        //Queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Primero");
        queue.Enqueue("Segundo");
        queue.Enqueue("Tercero");
        queue.Count.ToString();
        Console.WriteLine($"Elemento al frente de la cola: {queue.Peek()}");
        while (queue.Count > 0)
        {
            Console.WriteLine($"Desencolando: {queue.Dequeue()}");
        }
        //Stack
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Count.ToString();
        Console.WriteLine($"Elemento en la cima de la pila: {stack.Peek()}");
        while (stack.Count > 0)
        {
            Console.WriteLine($"Desapilando: {stack.Pop()}");
        }

        //DIFICULTAD EXTRA(opcional):












        #endregion













    }

}

