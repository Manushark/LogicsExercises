using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_28
{
    /*
     * EJERCICIO:
     * Explora el "Principio SOLID de Sustitución de Liskov (Liskov Substitution Principle, LSP)"
     * y crea un ejemplo simple donde se muestre su funcionamiento
     * de forma correcta e incorrecta.
     *
     * DIFICULTAD EXTRA (opcional):
     * Crea una jerarquía de vehículos. Todos ellos deben poder acelerar y frenar, así como
     * cumplir el LSP.
     * Instrucciones:
     * 1. Crea la clase Vehículo.
     * 2. Añade tres subclases de Vehículo.
     * 3. Implementa las operaciones "acelerar" y "frenar" como corresponda.
     * 4. Desarrolla un código que compruebe que se cumple el LSP.
     */
    public class Reto_28
    {
        /*
         * El principio de sustitución de Liskov (LSP)
         * establece que los objetos de una clase padre
         * deben poder ser reemplazados por objetos de 
         * clases hijas sin alterar la integridad del 
         * programa
         */

        //Implementacion incorrecta del principio de sustitucion
        public abstract class Character
        {
            public abstract void Attack();
        }

        public class Warrior : Character
        {
            public override void Attack()
            {
                Console.WriteLine("El guerrero ataca con espada");
            }
        }

        public class Wizard : Character
        {
            public override void Attack()
            {
                //El mago no puede atacar físicamente
                throw new NotImplementedException("El mago no puede atacar así");
                /* Esto viola el principio de sustitución de Liskov,
                 * ya que si se espera que un personaje pueda atacar,
                 * y si el mago no puede hacerlo, entonces no se puede
                 * Pero el exception es solamente un ejemplo para ilustrar la violacion del principio
                 * ya que en un diseño correcto, todas las subclases deberian cumplir con el contrato definido por la clase padre.
                 */
            }
        }
    }


    //Implementacion correcta del principio de sustitucion

    /* La clase padre define el contrato,
     * y las clases hijas deben cumplirlo,
     * cada una a su manera, pero sin fallar.
     */
    public class Game
    {
        public abstract class Character
        {
            public abstract void Attack();
        }

        public class Warrior : Character
        {
            public override void Attack()
            {
                Console.WriteLine("El guerrero ataca con espada");
            }
        }

        public class Wizard : Character
        {
            public override void Attack()
            {
                Console.WriteLine("El mago lanza un hechizo");
            }
        }
    }
}