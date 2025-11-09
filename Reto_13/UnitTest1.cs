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

        [Test]
        public void Sum_Test()
        {
            int result = Reto_13.Sum(5, 9);
            Assert.AreEqual(14, result);
        }

        Dictionary<string, object> dictionary;

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
            Assert.IsTrue(dictionary.ContainsKey("Name: "));
            Assert.IsTrue(dictionary.ContainsKey("Age: "));
            Assert.IsTrue(dictionary.ContainsKey("Birth_Date: "));
            Assert.IsTrue(dictionary.ContainsKey("programming_languages: "));
        }

        [Test]
        public void Data_Test()
        {
            Assert.That(dictionary["Name: "], Is.EqualTo("Manuel Rivas"));
            Assert.That(dictionary["Age: "], Is.EqualTo("21"));
            Assert.That(dictionary["Birth_Date: "], Is.EqualTo("10/23/2004"));
            
            var list = (List<string>)dictionary["programming_languages: "];
            Assert.That(list, Is.EquivalentTo(new List<string> { "C#", "HTML", "SQL" }));
        } 

    }
}