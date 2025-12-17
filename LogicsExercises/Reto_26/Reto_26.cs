using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_26
{
    /*
     * EJERCICIO:
     * Explora el "Principio SOLID de Responsabilidad Única (Single Responsibility
     * Principle, SRP)" y crea un ejemplo simple donde se muestre su funcionamiento
     * de forma correcta e incorrecta.
     *
     * DIFICULTAD EXTRA (opcional):
     * Desarrolla un sistema de gestión para una biblioteca. El sistema necesita
     * manejar diferentes aspectos como el registro de libros, la gestión de usuarios
     * y el procesamiento de préstamos de libros.
     * Requisitos:
     * 1. Registrar libros: El sistema debe permitir agregar nuevos libros con
     * información básica como título, autor y número de copias disponibles.
     * 2. Registrar usuarios: El sistema debe permitir agregar nuevos usuarios con
     * información básica como nombre, número de identificación y correo electrónico.
     * 3. Procesar préstamos de libros: El sistema debe permitir a los usuarios
     * tomar prestados y devolver libros.
     * Instrucciones:
     * 1. Diseña una clase que no cumple el SRP: Crea una clase Library que maneje
     * los tres aspectos mencionados anteriormente (registro de libros, registro de
     * usuarios y procesamiento de préstamos).
     * 2. Refactoriza el código: Separa las responsabilidades en diferentes clases
     * siguiendo el Principio de Responsabilidad Única.
     */
    public class Reto_26
    {
        /*
         * El Principio de Responsabilidad Única (SRP) establece que una clase debe
         * tener una única razón para cambiar, es decir, debe tener una sola
         * responsabilidad o función dentro del sistema.
         */
        /// Clase que no cumple el Principio de Responsabilidad Única
        public class User
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public string Email { get; set; }

            public User(string name, string id, string email)
            {
                Name = name;
                Id = id;
                Email = email;
            }

            // Métodos relacionados con la gestión de usuarios

            public void RegisterUser()
            {
                // Lógica para registrar un usuario
            }

            public void UpdateUser()
            {
                // Lógica para actualizar la información del usuario
            }

            public void SaveUser()
            {
                // Lógica para guardar la información del usuario en una base de datos
            }
        }

        /* 
         * Mantenimiento: Facilita la comprensión y el mantenimiento del código.
         * Pruebas: Facilita la creación de pruebas unitarias específicas para cada
         * responsabilidad.
         * Reutilización: Permite reutilizar clases en diferentes contextos sin
         * arrastrar responsabilidades no relacionadas.
         * Escalabilidad: Facilita la ampliación del sistema al agregar nuevas
         * funcionalidades sin afectar las existentes.
         */

        
        /// Clases que cumplen el Principio de Responsabilidad Única
        public class UserManager
        {
            public void RegisterUser(string name, string id, string email)
            {
                // Lógica para registrar un usuario
            }
            public void UpdateUser(string id, string newName, string newEmail)
            {
                // Lógica para actualizar la información del usuario
            }
        }

        // Clase responsable de la persistencia de datos
        public class UserRepository
        {
            public void SaveUser(User user)
            {
                // Lógica para guardar la información del usuario en una base de datos
            }
        }
        //Aqui vemos como cada clase tiene una única responsabilidad
    }


    //Dificultad Extra  

/*
 * DIFICULTAD EXTRA (opcional):
 * Desarrolla un sistema de gestión para una biblioteca. El sistema necesita
 * manejar diferentes aspectos como el registro de libros, la gestión de usuarios
 * y el procesamiento de préstamos de libros.
 * Requisitos:
 * 1. Registrar libros: El sistema debe permitir agregar nuevos libros con
 * información básica como título, autor y número de copias disponibles.
 * 2. Registrar usuarios: El sistema debe permitir agregar nuevos usuarios con
 * información básica como nombre, número de identificación y correo electrónico.
 * 3. Procesar préstamos de libros: El sistema debe permitir a los usuarios
 * tomar prestados y devolver libros.
 * Instrucciones:
 * 1. Diseña una clase que no cumple el SRP: Crea una clase Library que maneje
 * los tres aspectos mencionados anteriormente (registro de libros, registro de
 * usuarios y procesamiento de préstamos).
 * 2. Refactoriza el código: Separa las responsabilidades en diferentes clases
 * siguiendo el Principio de Responsabilidad Única.
*/

    //Clase que no cumple el Principio de Responsabilidad Única
    public class Librery
    {
        private List<string> books = new List<string>();

        private List<string> users = new List<string>();

        private Dictionary<string, string> loans = new Dictionary<string, string>();

        public void RegisterBook(string title)
        {
            books.Add(title);
            Console.WriteLine($"Book registered: {title}");
        }

        public void RegisterUser(string name)
        {
            users.Add(name);
            Console.WriteLine($"User registered: {name}");
        }

        public void LoanBook(string book, string user)
        {
            loans[book] = user;
            Console.WriteLine($"{book} loaned to {user}");
        }

        public void ReturnBook(string book)
        {
            loans.Remove(book);
            Console.WriteLine($"{book} returned");
        }
    }


    //Clase que cumplen el Principio de Responsabilidad Única
    //Estara em la clase librery2
}




