using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_30
{
    /*
     * EJERCICIO:
     * Explora el "Principio SOLID de Inversión de Dependencias (Dependency Inversion
     * Principle, DIP)" y crea un ejemplo simple donde se muestre su funcionamiento 
     * de forma correcta e incorrecta.
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea un sistema de notificaciones.
     * Requisitos:
     * 1. El sistema puede enviar Email, PUSH y SMS (implementaciones específicas).
     * 2. El sistema de notificaciones no puede depender de las implementaciones específicas.
     * Instrucciones:
     * 1. Crea la interfaz o clase abstracta.
     * 2. Desarrolla las implementaciones específicas.
     * 3. Crea el sistema de notificaciones usando el DIP.
     * 4. Desarrolla un código que compruebe que se cumple el principio.
     */
    public class Reto_30
    {
        /*El Principio de Inversión de Dependencias (DIP) establece que las entidades de alto nivel no deben depender de entidades de bajo nivel, 
         * sino que ambas deben depender de abstracciones. Además, las abstracciones no deben depender de detalles, sino que los detalles deben depender de abstracciones.
         * 
         * En palabras sencillas, el DIP promueve la separación de responsabilidades y la reducción de acoplamientos entre componentes de software.
         * como por ejemplo, en lugar de que una clase de alto nivel dependa directamente de una clase de bajo nivel, ambas deberían depender de una interfaz o clase abstracta.
         */
       
        
        //Implementacion incorrecta del DIP
        
        // Clase de bajo nivel
        public class MySqlDatabase
        {
            public void Save(string data)
            {
                Console.WriteLine("Saving data in MySQL database");
            }
        }

        // Clase de alto nivel (depende directamente de MySqlDatabase)
        public class UserService
        {
            private MySqlDatabase database;

            public UserService()
            {
                database = new MySqlDatabase(); // Aqui esta la dependencia directa
            }

            public void CreateUser(string user)
            {
                database.Save(user);
            }
        }

        //Implementacion correcta del DIP

        // Interfaz de abstracción
        public interface IDatabase
        {
            void save(string data);
        }

        // Clase de bajo nivel que implementa la interfaz
        public class MySqlDataBase : IDatabase
        {
            public void save(string data)
            {
                Console.WriteLine("Saving data in MySQL database");
            }
        }

        // Podria agregar otras implementaciones de bases de datos, sin afectar al UserService
        public class SqlServerDatabase : IDatabase
        {
            public void save(string data)
            {
                Console.WriteLine("Saving data in SQL Server database");
            }
        }

       




    }
}
