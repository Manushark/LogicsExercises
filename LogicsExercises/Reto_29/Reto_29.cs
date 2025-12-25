using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_29
{
    /*
     * EJERCICIO:
     * Explora el "Principio SOLID de Segregación de Interfaces
     * (Interface Segregation Principle, ISP)", y crea un ejemplo
     * simple donde se muestre su funcionamiento de forma correcta e incorrecta.
     *
     * DIFICULTAD EXTRA (opcional):
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
    public class Reto_29
    {
        //Funcionamiento del ISP de forma incorrecta.

        public interface ISchoolPerson
        {
            public void TeachClasses();
            public void AttendClasses();
            public void DoHomework();
            public void TakeExams();

        }

        public class Students : ISchoolPerson 
        {
            public void TeachClasses() 
            {
                Console.WriteLine("The student can not impart class"); // Aqui tenemos un metodo que no le corresponde al estudiante
            }
            public void AttendClasses()
            {
                Console.WriteLine("The student can not attend to class"); // Aqui tenemos un metodo que no le corresponde al estudiante
            }
            public void DoHomework()
            {
                Console.WriteLine("The student is doing homework");
            }
            public void TakeExams()
            {
                Console.WriteLine("The student is taking a exam");
            }
        }

        public class Teachers : ISchoolPerson
        {

            public void TeachClasses()
            {
                Console.WriteLine("The teacher is imparting the class");
            }
            public void AttendClasses()
            {
                Console.WriteLine("The teacher is attending to the class");
            }
            public void DoHomework()
            {
                Console.WriteLine("The teacher do not have homework"); // Aqui tenemos un metodo que no le corresponde al profesor
            }
            public void TakeExams()
            {
                Console.WriteLine("The teacher makes exams"); // Aqui tenemos un metodo que no le corresponde al profesor
            }

            //Funcionamiento del ISP de forma correcta.
            public interface IStudent
            {
                public void AttendClasses();
                public void DoHomework();
                public void TakeExams();
            }
            public interface ITeacher
            {
                public void TeachClasses();
                public void AttendClasses();
            }

            //Now the classes only implement the methods that correspond to them
            public class Student : IStudent
            {
                public void AttendClasses()
                {
                    Console.WriteLine("The student is attending to class");
                }
                public void DoHomework()
                {
                    Console.WriteLine("The student is doing homework");
                }
                public void TakeExams()
                {
                    Console.WriteLine("The student is taking a exam");
                }
            }

            // And the teacher class
            public class Teacher : ITeacher
            {
                public void TeachClasses()
                {
                    Console.WriteLine("The professor is imparting the class");
                }
                public void AttendClasses()
                {
                    Console.WriteLine("The professor is attending to the class");
                }
            }

            /* El ISP nos ayuda a crear interfaces más específicas y
             * a evitar que las clases implementen métodos que no utilizan,
             * adeamas, facilita el mantenimiento y la escalabilidad del código.
             */
        }
    }
}
