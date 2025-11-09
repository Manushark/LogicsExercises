using NUnit.Framework;
using LogicsExercises.Reto_13;
namespace Reto_1
{
    public class Sum_Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        //Cada test debe ser independiente uno del otro 
        [Test]
        public void Sum_Test()//Test para verificar que la función de suma funciona correctamente
        {
            int result = Reto_13.Sum(5, 9);
            Assert.AreEqual(14, result);
        }

        //el diccionario a testear
        Dictionary<string, object> dictionary;

        //El método SetUp se ejecuta antes de cada test para inicializar el diccionario y asegurar que cada test trabaje con una copia fresca del diccionario
        [SetUp]
        public void Dictionary()
        {
            dictionary = new Dictionary<string, object>() {
            {"Name: ", "Manuel Rivas"},
            {"Age: ", "21"},
            {"Birth_Date: ", "10/23/2004"},
            {"programming_languages: ", new List<string>{"C#", "HTML", "SQL" } }};
        }

        [Test]
        public void File_Exist_Test()
        {
            Assert.IsTrue(dictionary.ContainsKey("Name: "));//Assert que verifica la existencia de las claves en el diccionario
            Assert.IsTrue(dictionary.ContainsKey("Age: "));//IsTrue devuelve verdadero si la condición es verdadera 
            Assert.IsTrue(dictionary.ContainsKey("Birth_Date: "));//ContainsKey verifica si el diccionario contiene la clave especificada
            Assert.IsTrue(dictionary.ContainsKey("programming_languages: "));
        }

        // El segundo test verifica que los valores asociados a cada clave en el diccionario son correctos
        [Test]
        public void Data_Test()
        {
            Assert.That(dictionary["Name: "], Is.EqualTo("Manuel Rivas"));//Assert que verifica que el valor asociado a la clave "Name: " es igual a "Manuel Rivas"
            Assert.That(dictionary["Age: "], Is.EqualTo("21"));// isEqualTo compara el valor real con el valor esperado
            Assert.That(dictionary["Birth_Date: "], Is.EqualTo("10/23/2004"));

            //el valor asociado a la clave "programming_languages: " es una lista de strings, por lo que se castea a List<string> para compararlo con la lista esperada
            var list = (List<string>)dictionary["programming_languages: "];
            Assert.That(list, Is.EquivalentTo(new List<string> { "C#", "HTML", "SQL" }));//EquivalentTo verifica que dos colecciones contienen los mismos elementos, sin importar el orden
        } 

    }
}