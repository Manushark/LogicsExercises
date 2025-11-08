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
            int result = Reto_13.Sum(5 , 9);
            Assert.AreEqual(14, result);
        }
    }
}